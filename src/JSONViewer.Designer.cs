namespace HugeJSONViewer
{
    partial class JSONViewer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitter = new System.Windows.Forms.SplitContainer();
            this.treeJsonTree = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbExpandLevel = new System.Windows.Forms.ComboBox();
            this.txtArrayData = new System.Windows.Forms.TextBox();
            this.lblArrayData = new System.Windows.Forms.Label();
            this.propJsonProperties = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            this.lblProperties = new System.Windows.Forms.Label();
            this.pnlStatistics = new System.Windows.Forms.Panel();
            this.lblBool = new System.Windows.Forms.Label();
            this.txtNodeCountBool = new System.Windows.Forms.TextBox();
            this.txtString = new System.Windows.Forms.Label();
            this.txtNodeCountString = new System.Windows.Forms.TextBox();
            this.lblFloat = new System.Windows.Forms.Label();
            this.txtNodeCountFloat = new System.Windows.Forms.TextBox();
            this.lblInt = new System.Windows.Forms.Label();
            this.txtNodeCountInt = new System.Windows.Forms.TextBox();
            this.lblArray = new System.Windows.Forms.Label();
            this.txtNodeCountArray = new System.Windows.Forms.TextBox();
            this.lblObject = new System.Windows.Forms.Label();
            this.txtNodeCountObject = new System.Windows.Forms.TextBox();
            this.lblNodeCount = new System.Windows.Forms.Label();
            this.txtNodeCount = new System.Windows.Forms.TextBox();
            this.txtDisplayTime = new System.Windows.Forms.TextBox();
            this.lblDisplayTime = new System.Windows.Forms.Label();
            this.txtParseTime = new System.Windows.Forms.TextBox();
            this.lblParseTime = new System.Windows.Forms.Label();
            this.txtFileSize = new System.Windows.Forms.TextBox();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).BeginInit();
            this.splitter.Panel1.SuspendLayout();
            this.splitter.Panel2.SuspendLayout();
            this.splitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeJsonTree)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propJsonProperties)).BeginInit();
            this.pnlStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter
            // 
            this.splitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitter.Location = new System.Drawing.Point(0, 0);
            this.splitter.Name = "splitter";
            // 
            // splitter.Panel1
            // 
            this.splitter.Panel1.Controls.Add(this.treeJsonTree);
            this.splitter.Panel1.Controls.Add(this.panel1);
            // 
            // splitter.Panel2
            // 
            this.splitter.Panel2.Controls.Add(this.txtArrayData);
            this.splitter.Panel2.Controls.Add(this.lblArrayData);
            this.splitter.Panel2.Controls.Add(this.propJsonProperties);
            this.splitter.Panel2.Controls.Add(this.lblProperties);
            this.splitter.Panel2.Controls.Add(this.pnlStatistics);
            this.splitter.Size = new System.Drawing.Size(705, 477);
            this.splitter.SplitterDistance = 460;
            this.splitter.TabIndex = 4;
            // 
            // treeJsonTree
            // 
            this.treeJsonTree.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2});
            this.treeJsonTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeJsonTree.Location = new System.Drawing.Point(0, 41);
            this.treeJsonTree.Name = "treeJsonTree";
            this.treeJsonTree.OptionsBehavior.AllowIncrementalSearch = true;
            this.treeJsonTree.OptionsBehavior.AutoChangeParent = false;
            this.treeJsonTree.OptionsBehavior.Editable = false;
            this.treeJsonTree.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.True;
            this.treeJsonTree.OptionsClipboard.CopyNodeHierarchy = DevExpress.Utils.DefaultBoolean.True;
            this.treeJsonTree.OptionsCustomization.AllowBandMoving = false;
            this.treeJsonTree.OptionsCustomization.AllowBandResizing = false;
            this.treeJsonTree.OptionsCustomization.AllowColumnMoving = false;
            this.treeJsonTree.OptionsCustomization.ShowBandsInCustomizationForm = false;
            this.treeJsonTree.OptionsFind.AllowFindPanel = true;
            this.treeJsonTree.OptionsFind.AlwaysVisible = true;
            this.treeJsonTree.OptionsView.ShowColumns = false;
            this.treeJsonTree.OptionsView.ShowFilterPanelMode = DevExpress.XtraTreeList.ShowFilterPanelMode.Never;
            this.treeJsonTree.RootValue = 1;
            this.treeJsonTree.Size = new System.Drawing.Size(460, 436);
            this.treeJsonTree.TabIndex = 1;
            this.treeJsonTree.AfterFocusNode += new DevExpress.XtraTreeList.NodeEventHandler(this.OnAfterFocusNode);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Element";
            this.treeListColumn1.FieldName = "Path";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Value";
            this.treeListColumn2.FieldName = "Value";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbExpandLevel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 41);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Expand level";
            // 
            // cmbExpandLevel
            // 
            this.cmbExpandLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExpandLevel.FormattingEnabled = true;
            this.cmbExpandLevel.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbExpandLevel.Location = new System.Drawing.Point(77, 10);
            this.cmbExpandLevel.Name = "cmbExpandLevel";
            this.cmbExpandLevel.Size = new System.Drawing.Size(66, 21);
            this.cmbExpandLevel.TabIndex = 0;
            this.cmbExpandLevel.SelectedIndexChanged += new System.EventHandler(this.OnExpandLevelChanged);
            // 
            // txtArrayData
            // 
            this.txtArrayData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtArrayData.Enabled = false;
            this.txtArrayData.Location = new System.Drawing.Point(0, 439);
            this.txtArrayData.Multiline = true;
            this.txtArrayData.Name = "txtArrayData";
            this.txtArrayData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtArrayData.Size = new System.Drawing.Size(241, 38);
            this.txtArrayData.TabIndex = 5;
            // 
            // lblArrayData
            // 
            this.lblArrayData.AutoSize = true;
            this.lblArrayData.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblArrayData.Location = new System.Drawing.Point(0, 426);
            this.lblArrayData.Name = "lblArrayData";
            this.lblArrayData.Size = new System.Drawing.Size(58, 13);
            this.lblArrayData.TabIndex = 7;
            this.lblArrayData.Text = "Array data:";
            // 
            // propJsonProperties
            // 
            this.propJsonProperties.AutoGenerateRows = true;
            this.propJsonProperties.Dock = System.Windows.Forms.DockStyle.Top;
            this.propJsonProperties.Location = new System.Drawing.Point(0, 275);
            this.propJsonProperties.Name = "propJsonProperties";
            this.propJsonProperties.OptionsBehavior.Editable = false;
            this.propJsonProperties.Size = new System.Drawing.Size(241, 151);
            this.propJsonProperties.TabIndex = 4;
            // 
            // lblProperties
            // 
            this.lblProperties.AutoSize = true;
            this.lblProperties.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProperties.Location = new System.Drawing.Point(0, 262);
            this.lblProperties.Name = "lblProperties";
            this.lblProperties.Size = new System.Drawing.Size(136, 13);
            this.lblProperties.TabIndex = 6;
            this.lblProperties.Text = "Properties of selected node";
            // 
            // pnlStatistics
            // 
            this.pnlStatistics.Controls.Add(this.lblBool);
            this.pnlStatistics.Controls.Add(this.txtNodeCountBool);
            this.pnlStatistics.Controls.Add(this.txtString);
            this.pnlStatistics.Controls.Add(this.txtNodeCountString);
            this.pnlStatistics.Controls.Add(this.lblFloat);
            this.pnlStatistics.Controls.Add(this.txtNodeCountFloat);
            this.pnlStatistics.Controls.Add(this.lblInt);
            this.pnlStatistics.Controls.Add(this.txtNodeCountInt);
            this.pnlStatistics.Controls.Add(this.lblArray);
            this.pnlStatistics.Controls.Add(this.txtNodeCountArray);
            this.pnlStatistics.Controls.Add(this.lblObject);
            this.pnlStatistics.Controls.Add(this.txtNodeCountObject);
            this.pnlStatistics.Controls.Add(this.lblNodeCount);
            this.pnlStatistics.Controls.Add(this.txtNodeCount);
            this.pnlStatistics.Controls.Add(this.txtDisplayTime);
            this.pnlStatistics.Controls.Add(this.lblDisplayTime);
            this.pnlStatistics.Controls.Add(this.txtParseTime);
            this.pnlStatistics.Controls.Add(this.lblParseTime);
            this.pnlStatistics.Controls.Add(this.txtFileSize);
            this.pnlStatistics.Controls.Add(this.lblFileSize);
            this.pnlStatistics.Controls.Add(this.txtFileName);
            this.pnlStatistics.Controls.Add(this.lblFileName);
            this.pnlStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatistics.Location = new System.Drawing.Point(0, 0);
            this.pnlStatistics.Name = "pnlStatistics";
            this.pnlStatistics.Size = new System.Drawing.Size(241, 262);
            this.pnlStatistics.TabIndex = 3;
            // 
            // lblBool
            // 
            this.lblBool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBool.AutoSize = true;
            this.lblBool.Location = new System.Drawing.Point(142, 204);
            this.lblBool.Name = "lblBool";
            this.lblBool.Size = new System.Drawing.Size(28, 13);
            this.lblBool.TabIndex = 21;
            this.lblBool.Text = "Bool";
            // 
            // txtNodeCountBool
            // 
            this.txtNodeCountBool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNodeCountBool.Enabled = false;
            this.txtNodeCountBool.Location = new System.Drawing.Point(186, 201);
            this.txtNodeCountBool.Name = "txtNodeCountBool";
            this.txtNodeCountBool.Size = new System.Drawing.Size(52, 20);
            this.txtNodeCountBool.TabIndex = 20;
            this.txtNodeCountBool.Text = "0";
            // 
            // txtString
            // 
            this.txtString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtString.AutoSize = true;
            this.txtString.Location = new System.Drawing.Point(142, 178);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(34, 13);
            this.txtString.TabIndex = 19;
            this.txtString.Text = "String";
            // 
            // txtNodeCountString
            // 
            this.txtNodeCountString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNodeCountString.Enabled = false;
            this.txtNodeCountString.Location = new System.Drawing.Point(186, 175);
            this.txtNodeCountString.Name = "txtNodeCountString";
            this.txtNodeCountString.Size = new System.Drawing.Size(52, 20);
            this.txtNodeCountString.TabIndex = 18;
            this.txtNodeCountString.Text = "0";
            // 
            // lblFloat
            // 
            this.lblFloat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFloat.AutoSize = true;
            this.lblFloat.Location = new System.Drawing.Point(142, 152);
            this.lblFloat.Name = "lblFloat";
            this.lblFloat.Size = new System.Drawing.Size(30, 13);
            this.lblFloat.TabIndex = 17;
            this.lblFloat.Text = "Float";
            // 
            // txtNodeCountFloat
            // 
            this.txtNodeCountFloat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNodeCountFloat.Enabled = false;
            this.txtNodeCountFloat.Location = new System.Drawing.Point(186, 149);
            this.txtNodeCountFloat.Name = "txtNodeCountFloat";
            this.txtNodeCountFloat.Size = new System.Drawing.Size(52, 20);
            this.txtNodeCountFloat.TabIndex = 16;
            this.txtNodeCountFloat.Text = "0";
            // 
            // lblInt
            // 
            this.lblInt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInt.AutoSize = true;
            this.lblInt.Location = new System.Drawing.Point(29, 204);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(19, 13);
            this.lblInt.TabIndex = 15;
            this.lblInt.Text = "Int";
            // 
            // txtNodeCountInt
            // 
            this.txtNodeCountInt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNodeCountInt.Enabled = false;
            this.txtNodeCountInt.Location = new System.Drawing.Point(73, 201);
            this.txtNodeCountInt.Name = "txtNodeCountInt";
            this.txtNodeCountInt.Size = new System.Drawing.Size(52, 20);
            this.txtNodeCountInt.TabIndex = 14;
            this.txtNodeCountInt.Text = "0";
            // 
            // lblArray
            // 
            this.lblArray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArray.AutoSize = true;
            this.lblArray.Location = new System.Drawing.Point(29, 178);
            this.lblArray.Name = "lblArray";
            this.lblArray.Size = new System.Drawing.Size(31, 13);
            this.lblArray.TabIndex = 13;
            this.lblArray.Text = "Array";
            // 
            // txtNodeCountArray
            // 
            this.txtNodeCountArray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNodeCountArray.Enabled = false;
            this.txtNodeCountArray.Location = new System.Drawing.Point(73, 175);
            this.txtNodeCountArray.Name = "txtNodeCountArray";
            this.txtNodeCountArray.Size = new System.Drawing.Size(52, 20);
            this.txtNodeCountArray.TabIndex = 12;
            this.txtNodeCountArray.Text = "0";
            // 
            // lblObject
            // 
            this.lblObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblObject.AutoSize = true;
            this.lblObject.Location = new System.Drawing.Point(29, 152);
            this.lblObject.Name = "lblObject";
            this.lblObject.Size = new System.Drawing.Size(38, 13);
            this.lblObject.TabIndex = 11;
            this.lblObject.Text = "Object";
            // 
            // txtNodeCountObject
            // 
            this.txtNodeCountObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNodeCountObject.Enabled = false;
            this.txtNodeCountObject.Location = new System.Drawing.Point(73, 149);
            this.txtNodeCountObject.Name = "txtNodeCountObject";
            this.txtNodeCountObject.Size = new System.Drawing.Size(52, 20);
            this.txtNodeCountObject.TabIndex = 10;
            this.txtNodeCountObject.Text = "0";
            // 
            // lblNodeCount
            // 
            this.lblNodeCount.AutoSize = true;
            this.lblNodeCount.Location = new System.Drawing.Point(4, 126);
            this.lblNodeCount.Name = "lblNodeCount";
            this.lblNodeCount.Size = new System.Drawing.Size(63, 13);
            this.lblNodeCount.TabIndex = 9;
            this.lblNodeCount.Text = "Node count";
            // 
            // txtNodeCount
            // 
            this.txtNodeCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNodeCount.Enabled = false;
            this.txtNodeCount.Location = new System.Drawing.Point(73, 123);
            this.txtNodeCount.Name = "txtNodeCount";
            this.txtNodeCount.Size = new System.Drawing.Size(165, 20);
            this.txtNodeCount.TabIndex = 8;
            this.txtNodeCount.Text = "0";
            // 
            // txtDisplayTime
            // 
            this.txtDisplayTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDisplayTime.Enabled = false;
            this.txtDisplayTime.Location = new System.Drawing.Point(73, 97);
            this.txtDisplayTime.Name = "txtDisplayTime";
            this.txtDisplayTime.Size = new System.Drawing.Size(165, 20);
            this.txtDisplayTime.TabIndex = 7;
            this.txtDisplayTime.Text = "00:00.000 min";
            // 
            // lblDisplayTime
            // 
            this.lblDisplayTime.AutoSize = true;
            this.lblDisplayTime.Location = new System.Drawing.Point(4, 100);
            this.lblDisplayTime.Name = "lblDisplayTime";
            this.lblDisplayTime.Size = new System.Drawing.Size(63, 13);
            this.lblDisplayTime.TabIndex = 6;
            this.lblDisplayTime.Text = "Display time";
            // 
            // txtParseTime
            // 
            this.txtParseTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParseTime.Enabled = false;
            this.txtParseTime.Location = new System.Drawing.Point(73, 71);
            this.txtParseTime.Name = "txtParseTime";
            this.txtParseTime.Size = new System.Drawing.Size(165, 20);
            this.txtParseTime.TabIndex = 5;
            this.txtParseTime.Text = "00:00.000 min";
            // 
            // lblParseTime
            // 
            this.lblParseTime.AutoSize = true;
            this.lblParseTime.Location = new System.Drawing.Point(4, 74);
            this.lblParseTime.Name = "lblParseTime";
            this.lblParseTime.Size = new System.Drawing.Size(56, 13);
            this.lblParseTime.TabIndex = 4;
            this.lblParseTime.Text = "Parse time";
            // 
            // txtFileSize
            // 
            this.txtFileSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileSize.Enabled = false;
            this.txtFileSize.Location = new System.Drawing.Point(73, 45);
            this.txtFileSize.Name = "txtFileSize";
            this.txtFileSize.Size = new System.Drawing.Size(165, 20);
            this.txtFileSize.TabIndex = 3;
            this.txtFileSize.Text = "0.00 GB";
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Location = new System.Drawing.Point(4, 48);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(44, 13);
            this.lblFileSize.TabIndex = 2;
            this.lblFileSize.Text = "File size";
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileName.Enabled = false;
            this.txtFileName.Location = new System.Drawing.Point(7, 21);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(231, 20);
            this.txtFileName.TabIndex = 1;
            this.txtFileName.Text = "c:\\...\\file.json";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(4, 4);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(51, 13);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.Text = "JSON file";
            // 
            // JSONViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitter);
            this.Name = "JSONViewer";
            this.Size = new System.Drawing.Size(705, 477);
            this.splitter.Panel1.ResumeLayout(false);
            this.splitter.Panel2.ResumeLayout(false);
            this.splitter.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).EndInit();
            this.splitter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeJsonTree)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propJsonProperties)).EndInit();
            this.pnlStatistics.ResumeLayout(false);
            this.pnlStatistics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitter;
        public DevExpress.XtraTreeList.TreeList treeJsonTree;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraVerticalGrid.PropertyGridControl propJsonProperties;
        private System.Windows.Forms.Panel pnlStatistics;
        private System.Windows.Forms.TextBox txtDisplayTime;
        private System.Windows.Forms.Label lblDisplayTime;
        private System.Windows.Forms.TextBox txtParseTime;
        private System.Windows.Forms.Label lblParseTime;
        private System.Windows.Forms.TextBox txtFileSize;
        private System.Windows.Forms.Label lblFileSize;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtArrayData;
        private System.Windows.Forms.Label lblArrayData;
        private System.Windows.Forms.Label lblProperties;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private System.Windows.Forms.Label lblNodeCount;
        private System.Windows.Forms.TextBox txtNodeCount;
        private System.Windows.Forms.Label lblObject;
        private System.Windows.Forms.TextBox txtNodeCountObject;
        private System.Windows.Forms.Label lblArray;
        private System.Windows.Forms.TextBox txtNodeCountArray;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.TextBox txtNodeCountInt;
        private System.Windows.Forms.Label lblBool;
        private System.Windows.Forms.TextBox txtNodeCountBool;
        private System.Windows.Forms.Label txtString;
        private System.Windows.Forms.TextBox txtNodeCountString;
        private System.Windows.Forms.Label lblFloat;
        private System.Windows.Forms.TextBox txtNodeCountFloat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbExpandLevel;
    }
}
