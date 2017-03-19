namespace CoD_SCZ_FoV_Changer
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.chkAutoStart = new System.Windows.Forms.CheckBox();
            this.chkAutoSelect = new System.Windows.Forms.CheckBox();
            this.lblGithub = new System.Windows.Forms.Label();
            this.txtFovTotal = new System.Windows.Forms.TextBox();
            this.btnFovScaleReset = new System.Windows.Forms.Button();
            this.nudFovScale = new System.Windows.Forms.NumericUpDown();
            this.lblFovScale = new System.Windows.Forms.Label();
            this.lblFov = new System.Windows.Forms.Label();
            this.chkBeep = new System.Windows.Forms.CheckBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.cmdFovReset = new System.Windows.Forms.Button();
            this.nudFov = new System.Windows.Forms.NumericUpDown();
            this.lblFovTotal = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblGame = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudFovScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFov)).BeginInit();
            this.SuspendLayout();
            // 
            // chkAutoStart
            // 
            this.chkAutoStart.AutoSize = true;
            this.chkAutoStart.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.chkAutoStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.chkAutoStart.Location = new System.Drawing.Point(174, 141);
            this.chkAutoStart.Name = "chkAutoStart";
            this.chkAutoStart.Size = new System.Drawing.Size(118, 23);
            this.chkAutoStart.TabIndex = 10;
            this.chkAutoStart.Text = "auto start";
            this.chkAutoStart.UseVisualStyleBackColor = true;
            // 
            // chkAutoSelect
            // 
            this.chkAutoSelect.AutoSize = true;
            this.chkAutoSelect.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.chkAutoSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.chkAutoSelect.Location = new System.Drawing.Point(30, 169);
            this.chkAutoSelect.Name = "chkAutoSelect";
            this.chkAutoSelect.Size = new System.Drawing.Size(262, 23);
            this.chkAutoSelect.TabIndex = 11;
            this.chkAutoSelect.Text = "auto select CoD on startup";
            this.chkAutoSelect.UseVisualStyleBackColor = true;
            // 
            // lblGithub
            // 
            this.lblGithub.AutoSize = true;
            this.lblGithub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblGithub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.lblGithub.Location = new System.Drawing.Point(116, 237);
            this.lblGithub.Name = "lblGithub";
            this.lblGithub.Size = new System.Drawing.Size(86, 13);
            this.lblGithub.TabIndex = 14;
            this.lblGithub.Text = "check on Github";
            this.lblGithub.Click += new System.EventHandler(this.lblGithub_Click);
            // 
            // txtFovTotal
            // 
            this.txtFovTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.txtFovTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFovTotal.Font = new System.Drawing.Font("Verdana", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFovTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.txtFovTotal.Location = new System.Drawing.Point(196, 54);
            this.txtFovTotal.MaxLength = 16;
            this.txtFovTotal.Name = "txtFovTotal";
            this.txtFovTotal.ReadOnly = true;
            this.txtFovTotal.Size = new System.Drawing.Size(88, 21);
            this.txtFovTotal.TabIndex = 2;
            this.txtFovTotal.Text = "0,00";
            this.txtFovTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFovScaleReset
            // 
            this.btnFovScaleReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnFovScaleReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFovScaleReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFovScaleReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.btnFovScaleReset.Location = new System.Drawing.Point(262, 114);
            this.btnFovScaleReset.Name = "btnFovScaleReset";
            this.btnFovScaleReset.Size = new System.Drawing.Size(22, 22);
            this.btnFovScaleReset.TabIndex = 8;
            this.btnFovScaleReset.Text = "*";
            this.btnFovScaleReset.UseVisualStyleBackColor = false;
            this.btnFovScaleReset.Click += new System.EventHandler(this.btnFovScaleReset_Click);
            // 
            // nudFovScale
            // 
            this.nudFovScale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.nudFovScale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudFovScale.DecimalPlaces = 3;
            this.nudFovScale.Font = new System.Drawing.Font("Verdana", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudFovScale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.nudFovScale.Increment = new decimal(new int[] {
            25,
            0,
            0,
            196608});
            this.nudFovScale.Location = new System.Drawing.Point(196, 114);
            this.nudFovScale.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudFovScale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFovScale.Name = "nudFovScale";
            this.nudFovScale.Size = new System.Drawing.Size(60, 21);
            this.nudFovScale.TabIndex = 7;
            this.nudFovScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudFovScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFovScale.ValueChanged += new System.EventHandler(this.nudFovAndFovScale_ValueChanged);
            // 
            // lblFovScale
            // 
            this.lblFovScale.AutoSize = true;
            this.lblFovScale.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFovScale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.lblFovScale.Location = new System.Drawing.Point(26, 112);
            this.lblFovScale.Name = "lblFovScale";
            this.lblFovScale.Size = new System.Drawing.Size(91, 19);
            this.lblFovScale.TabIndex = 6;
            this.lblFovScale.Text = "cg_fovScale";
            // 
            // lblFov
            // 
            this.lblFov.AutoSize = true;
            this.lblFov.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.lblFov.Location = new System.Drawing.Point(26, 81);
            this.lblFov.Name = "lblFov";
            this.lblFov.Size = new System.Drawing.Size(55, 19);
            this.lblFov.TabIndex = 3;
            this.lblFov.Text = "cg_fov";
            // 
            // chkBeep
            // 
            this.chkBeep.AutoSize = true;
            this.chkBeep.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.chkBeep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.chkBeep.Location = new System.Drawing.Point(30, 141);
            this.chkBeep.Name = "chkBeep";
            this.chkBeep.Size = new System.Drawing.Size(127, 23);
            this.chkBeep.TabIndex = 9;
            this.chkBeep.Text = "enable beep";
            this.chkBeep.UseVisualStyleBackColor = true;
            this.chkBeep.CheckedChanged += new System.EventHandler(this.chkEnableBeep_CheckedChanged);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.lblVersion.Location = new System.Drawing.Point(0, 238);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(40, 13);
            this.lblVersion.TabIndex = 13;
            this.lblVersion.Text = "0.0.0.0";
            this.lblVersion.Click += new System.EventHandler(this.lblVersion_Click);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.lblAuthor.Location = new System.Drawing.Point(252, 238);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(65, 13);
            this.lblAuthor.TabIndex = 15;
            this.lblAuthor.Text = "by Marvin L.";
            this.lblAuthor.Click += new System.EventHandler(this.lblAuthor_Click);
            // 
            // cmdFovReset
            // 
            this.cmdFovReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.cmdFovReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdFovReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFovReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.cmdFovReset.Location = new System.Drawing.Point(262, 83);
            this.cmdFovReset.Name = "cmdFovReset";
            this.cmdFovReset.Size = new System.Drawing.Size(22, 22);
            this.cmdFovReset.TabIndex = 5;
            this.cmdFovReset.Text = "*";
            this.cmdFovReset.UseVisualStyleBackColor = false;
            this.cmdFovReset.Click += new System.EventHandler(this.btnFovReset_Click);
            // 
            // nudFov
            // 
            this.nudFov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.nudFov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudFov.Font = new System.Drawing.Font("Verdana", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudFov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.nudFov.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudFov.Location = new System.Drawing.Point(196, 83);
            this.nudFov.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudFov.Name = "nudFov";
            this.nudFov.Size = new System.Drawing.Size(60, 21);
            this.nudFov.TabIndex = 4;
            this.nudFov.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudFov.Value = new decimal(new int[] {
            65,
            0,
            0,
            0});
            this.nudFov.ValueChanged += new System.EventHandler(this.nudFovAndFovScale_ValueChanged);
            // 
            // lblFovTotal
            // 
            this.lblFovTotal.AutoSize = true;
            this.lblFovTotal.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFovTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.lblFovTotal.Location = new System.Drawing.Point(26, 50);
            this.lblFovTotal.Name = "lblFovTotal";
            this.lblFovTotal.Size = new System.Drawing.Size(110, 22);
            this.lblFovTotal.TabIndex = 1;
            this.lblFovTotal.Text = "Field of View";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Consolas", 11F);
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.btnStart.Location = new System.Drawing.Point(30, 201);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(254, 29);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "start game on Steam";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblGame
            // 
            this.lblGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(76)))));
            this.lblGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGame.Font = new System.Drawing.Font("Impact", 16F);
            this.lblGame.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGame.Location = new System.Drawing.Point(0, 0);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(318, 39);
            this.lblGame.TabIndex = 0;
            this.lblGame.Text = "Call of Duty";
            this.lblGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(318, 251);
            this.Controls.Add(this.chkAutoStart);
            this.Controls.Add(this.chkAutoSelect);
            this.Controls.Add(this.lblGithub);
            this.Controls.Add(this.txtFovTotal);
            this.Controls.Add(this.btnFovScaleReset);
            this.Controls.Add(this.nudFovScale);
            this.Controls.Add(this.lblFovScale);
            this.Controls.Add(this.lblFov);
            this.Controls.Add(this.chkBeep);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.cmdFovReset);
            this.Controls.Add(this.nudFov);
            this.Controls.Add(this.lblFovTotal);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(334, 290);
            this.MinimumSize = new System.Drawing.Size(334, 290);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoD SCZ FoV Changer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFovScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAutoStart;
        private System.Windows.Forms.CheckBox chkAutoSelect;
        private System.Windows.Forms.Label lblGithub;
        private System.Windows.Forms.TextBox txtFovTotal;
        internal System.Windows.Forms.Button btnFovScaleReset;
        internal System.Windows.Forms.NumericUpDown nudFovScale;
        internal System.Windows.Forms.Label lblFovScale;
        internal System.Windows.Forms.Label lblFov;
        private System.Windows.Forms.CheckBox chkBeep;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblAuthor;
        internal System.Windows.Forms.Button cmdFovReset;
        internal System.Windows.Forms.NumericUpDown nudFov;
        internal System.Windows.Forms.Label lblFovTotal;
        internal System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblGame;
    }
}

