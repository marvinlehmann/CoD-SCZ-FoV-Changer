using System;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoD_SCZ_FoV_Changer.Properties;

namespace CoD_SCZ_FoV_Changer
{
    public partial class FrmMain : Form
    {
        private CallOfDuty _cod;
        private Memory _memory;

        private IntPtr _addrFoV;
        private IntPtr _addrFoVScale;

        private float _desiredFoV;
        private float _desiredFoVScale;

        private Task _fovTask;
        private CancellationToken _ct;
        private CancellationTokenSource _tokenSource;


        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // load and upgrade settings if necessary & delete config if it is corrupt
            try
            {
                if (Settings.Default.UpgradeRequired)
                {
                    Settings.Default.Upgrade();
                    Settings.Default.UpgradeRequired = false;
                    Settings.Default.Save();
                }

                // load settings into controls
                nudFov.Value = Settings.Default.FieldOfView;
                nudFovScale.Value = Settings.Default.FieldOfViewScale;
                chkBeep.Checked = Settings.Default.Beep;
                chkAutoSelect.Checked = Settings.Default.AutoSelect;
                chkAutoStart.Checked = Settings.Default.AutoStart;
            }
            catch (ConfigurationErrorsException ex)
            {
                var filename = ((ConfigurationErrorsException)ex.InnerException).Filename;
                File.Delete(filename);
            }

            var selection = new FrmSelection(Settings.Default.AutoSelect);
            if (selection.ShowDialog() == DialogResult.OK)
            {
                _cod = selection.SelectedCoD;
                lblGame.Text = _cod.Name;

                lblVersion.Text = Application.ProductVersion;

                // calculate total fov to ensure fov variables are set without relying onto nudFovAndFovScale_ValueChanged
                CalculateFov();

                // thread & memory stuff
                _tokenSource = new CancellationTokenSource();
                _ct = _tokenSource.Token;
                _fovTask = new Task(FovChanger, _tokenSource.Token, TaskCreationOptions.LongRunning);
                _memory = new Memory(_cod.ProcessName);
                _fovTask.Start();

                // start game if AutoStart is activated
                if (chkAutoStart.Checked) StartGame();
            }
            else
            {
                Application.Exit();
            }
        }

        private void FovChanger()
        {
            while (!_ct.IsCancellationRequested)
            {
                if (_memory.IsRunning())
                {
                    if (btnStart.Enabled) SetStartButtonStatus(false);

                    try
                    {
                        if (!_cod.FovPointer.IsPointingCorrectly(_addrFoV) || !_cod.FovScalePointer.IsPointingCorrectly(_addrFoVScale))
                        {
                            _addrFoV = _memory.ReadPointerAddress(_cod.FovPointer);
                            _addrFoVScale = _memory.ReadPointerAddress(_cod.FovScalePointer);
                            if (_cod.FovPointer.IsPointingCorrectly(_addrFoV) && _cod.FovScalePointer.IsPointingCorrectly(_addrFoVScale)) Beeper.BeepActivated();
                        }
                        else
                        {
                            if (!_memory.ReadFloat(_addrFoV).Equals(_desiredFoV)) _memory.WriteFloat(_addrFoV, _desiredFoV);
                            if (!_memory.ReadFloat(_addrFoVScale).Equals(_desiredFoVScale)) _memory.WriteFloat(_addrFoVScale, _desiredFoVScale);
                        }
                    }
                    catch (Exception ex)
                    {
                        Thread.CurrentThread.Abort();
                        Beeper.BeepDeactivated();
                        MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                }
                else
                {
                    if (!btnStart.Enabled) SetStartButtonStatus(true);

                    _addrFoV = IntPtr.Zero;
                    _addrFoVScale = IntPtr.Zero;
                    _memory.ProcessId = 0;

                    Beeper.BeepDeactivated();
                }

                Thread.Sleep(1000);
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_cod == null) return;

            Settings.Default.FieldOfView = nudFov.Value;
            Settings.Default.FieldOfViewScale = nudFovScale.Value;
            Settings.Default.Beep = chkBeep.Checked;
            Settings.Default.AutoSelect = chkAutoSelect.Checked;
            Settings.Default.AutoStart = chkAutoStart.Checked;
            Settings.Default.Save();

            _tokenSource?.Cancel();
            Beeper.BeepDeactivated();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void StartGame()
        {
            try
            {
                if (!_memory.IsRunning()) Process.Start($"steam://rungameid/{_cod.SteamAppId}");
            }
            catch (Exception e)
            {
                if (MessageBox.Show(
                    string.Format("{1} could not be started.{0}Are {1} and Steam installed correctly?{0}{0}Error message:{0}{2}{0}{0}Click 'Yes' to open a Steam Support article for a potential fix.", Environment.NewLine, _cod.Name, e),
                    "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    Process.Start("https://support.steampowered.com/kb_article.php?ref=2087-MZES-9065");
                }
            }
        }

        private void SetStartButtonStatus(bool enabled)
        {
            if (btnStart.InvokeRequired)
            {
                btnStart.Invoke(new Action(() =>
                {
                    btnStart.Enabled = enabled;
                    btnStart.Text = !enabled ? "game is already running.." : "start game on Steam";
                }));
            }
            else
            {
                btnStart.Enabled = enabled;
                btnStart.Text = !enabled ? "game is already running.." : "start game on Steam";
            }
        }

        private void CalculateFov()
        {
            _desiredFoV = (float)nudFov.Value;
            _desiredFoVScale = (float)nudFovScale.Value;
            txtFovTotal.Text = Math.Round(_desiredFoV*_desiredFoVScale, 3).ToString(CultureInfo.CurrentCulture);
        }

        private void nudFovAndFovScale_ValueChanged(object sender, EventArgs e)
        {
            CalculateFov();
        }

        private void btnFovReset_Click(object sender, EventArgs e)
        {
            nudFov.Value = 65M;
        }

        private void btnFovScaleReset_Click(object sender, EventArgs e)
        {
            nudFovScale.Value = 1M;
        }

        private void chkEnableBeep_CheckedChanged(object sender, EventArgs e)
        {
            Beeper.Enabled = ((CheckBox)sender).Checked;
        }

        private void lblAuthor_Click(object sender, EventArgs e)
        {
            Process.Start("http://steamcommunity.com/profiles/76561198037206797");
        }

        private void lblGithub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/marvinlehmann/CoD-SCZ-FoV-Changer");
        }

        private void lblVersion_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/marvinlehmann/CoD-SCZ-FoV-Changer/releases");
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            if (_fovTask != null)
            {
                if (_fovTask.Status == TaskStatus.Running) Task.WaitAll(_fovTask);
                _fovTask.Dispose();
            }
            if (_tokenSource != null) _tokenSource.Dispose();

            base.Dispose(disposing);
        }
    }
}