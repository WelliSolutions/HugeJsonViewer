using DevExpress.XtraWaitForm;

namespace HugeJSONViewer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.jsonTabs = new DevExpress.XtraTab.XtraTabControl();
            this.openJsonFile = new System.Windows.Forms.OpenFileDialog();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.jsonTabs)).BeginInit();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // jsonTabs
            // 
            resources.ApplyResources(this.jsonTabs, "jsonTabs");
            this.jsonTabs.Name = "jsonTabs";
            this.jsonTabs.CloseButtonClick += new System.EventHandler(this.OnClose);
            // 
            // openJsonFile
            // 
            this.openJsonFile.DefaultExt = "json";
            resources.ApplyResources(this.openJsonFile, "openJsonFile");
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuHelp});
            resources.ApplyResources(this.mnuMain, "mnuMain");
            this.mnuMain.Name = "mnuMain";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpen,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            resources.ApplyResources(this.mnuFile, "mnuFile");
            // 
            // mnuFileOpen
            // 
            resources.ApplyResources(this.mnuFileOpen, "mnuFileOpen");
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
            // 
            // mnuFileExit
            // 
            resources.ApplyResources(this.mnuFileExit, "mnuFileExit");
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            resources.ApplyResources(this.mnuHelp, "mnuHelp");
            // 
            // mnuHelpAbout
            // 
            resources.ApplyResources(this.mnuHelpAbout, "mnuHelpAbout");
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.jsonTabs);
            this.Controls.Add(this.mnuMain);
            this.Name = "MainForm";
            this.Shown += new System.EventHandler(this.OnShown);
            ((System.ComponentModel.ISupportInitialize)(this.jsonTabs)).EndInit();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraTab.XtraTabControl jsonTabs;
        private System.Windows.Forms.OpenFileDialog openJsonFile;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
    }
}

