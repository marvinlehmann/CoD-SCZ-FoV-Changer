namespace CoD_SCZ_FoV_Changer
{
    partial class FrmSelection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelection));
            this.lstCoDs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstCoDs
            // 
            this.lstCoDs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCoDs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.lstCoDs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstCoDs.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.lstCoDs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(179)))), ((int)(((byte)(181)))));
            this.lstCoDs.FormattingEnabled = true;
            this.lstCoDs.ItemHeight = 22;
            this.lstCoDs.Location = new System.Drawing.Point(0, 0);
            this.lstCoDs.Name = "lstCoDs";
            this.lstCoDs.ScrollAlwaysVisible = true;
            this.lstCoDs.Size = new System.Drawing.Size(344, 68);
            this.lstCoDs.TabIndex = 0;
            this.lstCoDs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstCoDs_KeyDown);
            this.lstCoDs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstCoDs_MouseDoubleClick);
            // 
            // FrmSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(344, 68);
            this.Controls.Add(this.lstCoDs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 176);
            this.MinimumSize = new System.Drawing.Size(360, 66);
            this.Name = "FrmSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CoD SCZ FoV Changer - CoD Selection";
            this.Load += new System.EventHandler(this.FrmSelection_Load);
            this.Shown += new System.EventHandler(this.FrmSelection_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCoDs;
    }
}