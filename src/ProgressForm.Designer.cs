﻿namespace HugeJSONViewer
{
    partial class ProgressForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressForm));
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.SuspendLayout();
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("progressPanel1.Appearance.BackColor")));
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this.progressPanel1, "progressPanel1");
            this.progressPanel1.LookAndFeel.SkinMaskColor = System.Drawing.Color.Red;
            this.progressPanel1.LookAndFeel.SkinName = "Office 2010 Black";
            this.progressPanel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.progressPanel1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.progressPanel1.LookAndFeel.UseWindowsXPTheme = true;
            this.progressPanel1.Name = "progressPanel1";
            // 
            // ProgressForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.progressPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProgressForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClose);
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
    }
}