using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace CoD_SCZ_FoV_Changer
{
    public partial class FrmSelection : Form
    {
        private readonly bool _autoSelect;
        private readonly List<CallOfDuty> _cods = new List<CallOfDuty>();

        public FrmSelection(bool autoSelect)
        {
            _autoSelect = autoSelect;
            InitializeComponent();
        }

        public CallOfDuty SelectedCoD { get; private set; }

        private void FrmSelection_Load(object sender, EventArgs e)
        {
            AddCoDs();
            lstCoDs.DataSource = _cods;

            // load and process start parameters
            // start parameters are prioritized over settings (auto select)
            var args = Environment.GetCommandLineArgs();
            if (args.Length > 1) HandleStartParameters(args);
            else if (_autoSelect) Select(GetActiveCoD());
        }

        private void FrmSelection_Shown(object sender, EventArgs e)
        {
            // auto select running CoD in list
            var activeCoD = GetActiveCoD();
            if (activeCoD != null) SelectListItemByText(lstCoDs, activeCoD.Name);
        }

        private void lstCoDs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var index = lstCoDs.IndexFromPoint(e.Location);
            if (index != -1) Select(_cods.ElementAt(index));
        }

        private void lstCoDs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) if (lstCoDs.SelectedIndex != -1) Select(_cods.ElementAt(lstCoDs.SelectedIndex));
        }

        private void AddCoDs()
        {
            /*var mw1 = new CallOfDuty("Call of Duty: Modern Warfare 1", "iw3sp", 10180)
            {
                FovPointer = new Memory.Pointer((IntPtr)0x007F77CC, new short[] {0xC}),
                FovScalePointer = null // non-existent?
            };
            _cods.Add(mw1);*/

            var waw = new CallOfDuty("Call of Duty: World at War", "CoDWaW", 10090)
            {
                FovPointer = new Memory.Pointer((IntPtr)0x0328EB70, new short[] {0x10}),
                FovScalePointer = new Memory.Pointer((IntPtr)0x03288A04, new short[] {0x10})
            };
            _cods.Add(waw);

            var mw2 = new CallOfDuty("Call of Duty: Modern Warfare 2", "iw4sp", 10180)
            {
                FovPointer = new Memory.Pointer((IntPtr)0x0045E968, new short[] {0x10}),
                FovScalePointer = new Memory.Pointer((IntPtr)0x0045E854, new short[] {0x10})
            };
            _cods.Add(mw2);

            var bo1 = new CallOfDuty("Call of Duty: Black Ops", "BlackOps", 42700)
            {
                FovPointer = new Memory.Pointer((IntPtr)0x02BF6888, new short[] {0x18}),
                FovScalePointer = new Memory.Pointer((IntPtr)0x02BF66A8, new short[] {0x18})
            };
            _cods.Add(bo1);

            var mw3 = new CallOfDuty("Call of Duty: Modern Warfare 3", "iw5sp", 42680)
            {
                FovPointer = new Memory.Pointer((IntPtr)0x00676130, new short[] {0xC}),
                FovScalePointer = new Memory.Pointer((IntPtr)0x0067601C, new short[] {0xC})
            };
            _cods.Add(mw3);
        }

        private void Select(CallOfDuty cod)
        {
            if (cod == null) return;
            SelectedCoD = cod;
            DialogResult = DialogResult.OK;
        }

        private void SelectListItemByText(ListBox listBox, string keyword)
        {
            var items = listBox.Items;
            foreach (var item in items)
            {
                if (item.ToString().Contains(keyword))
                {
                    listBox.SelectedItem = item;
                    break;
                }
            }
        }

        private CallOfDuty GetActiveCoD()
        {
            foreach (var cod in _cods)
            {
                if (Process.GetProcessesByName(cod.ProcessName).Length >= 1) return cod;
            }
            return null;
        }

        private void HandleStartParameters(string[] args)
        {
            // starting at [1] because [0] contains the program's path
            for (var i = 1; i < args.Length; ++i)
            {
                foreach (var cod in _cods)
                {
                    if (cod.ToString().ToLower().Contains(args[i].ToLower()))
                    {
                        Select(cod);
                        return;
                    }
                }
            }
        }
    }
}