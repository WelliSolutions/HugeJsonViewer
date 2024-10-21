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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JSONViewer));
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
            this.lblNdJson = new System.Windows.Forms.Label();
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
            resources.ApplyResources(this.splitter, "splitter");
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
            // 
            // treeJsonTree
            // 
            this.treeJsonTree.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2});
            resources.ApplyResources(this.treeJsonTree, "treeJsonTree");
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
            this.treeJsonTree.AfterFocusNode += new DevExpress.XtraTreeList.NodeEventHandler(this.OnAfterFocusNode);
            // 
            // treeListColumn1
            // 
            resources.ApplyResources(this.treeListColumn1, "treeListColumn1");
            this.treeListColumn1.FieldName = "Path";
            this.treeListColumn1.Name = "treeListColumn1";
            // 
            // treeListColumn2
            // 
            resources.ApplyResources(this.treeListColumn2, "treeListColumn2");
            this.treeListColumn2.FieldName = "Value";
            this.treeListColumn2.Name = "treeListColumn2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbExpandLevel);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cmbExpandLevel
            // 
            this.cmbExpandLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExpandLevel.FormattingEnabled = true;
            this.cmbExpandLevel.Items.AddRange(new object[] {
            resources.GetString("cmbExpandLevel.Items"),
            resources.GetString("cmbExpandLevel.Items1"),
            resources.GetString("cmbExpandLevel.Items2"),
            resources.GetString("cmbExpandLevel.Items3"),
            resources.GetString("cmbExpandLevel.Items4"),
            resources.GetString("cmbExpandLevel.Items5"),
            resources.GetString("cmbExpandLevel.Items6"),
            resources.GetString("cmbExpandLevel.Items7"),
            resources.GetString("cmbExpandLevel.Items8"),
            resources.GetString("cmbExpandLevel.Items9"),
            resources.GetString("cmbExpandLevel.Items10")});
            resources.ApplyResources(this.cmbExpandLevel, "cmbExpandLevel");
            this.cmbExpandLevel.Name = "cmbExpandLevel";
            this.cmbExpandLevel.SelectedIndexChanged += new System.EventHandler(this.OnExpandLevelChanged);
            // 
            // txtArrayData
            // 
            resources.ApplyResources(this.txtArrayData, "txtArrayData");
            this.txtArrayData.Name = "txtArrayData";
            // 
            // lblArrayData
            // 
            resources.ApplyResources(this.lblArrayData, "lblArrayData");
            this.lblArrayData.Name = "lblArrayData";
            // 
            // propJsonProperties
            // 
            this.propJsonProperties.AutoGenerateRows = true;
            resources.ApplyResources(this.propJsonProperties, "propJsonProperties");
            this.propJsonProperties.Name = "propJsonProperties";
            this.propJsonProperties.OptionsBehavior.Editable = false;
            // 
            // lblProperties
            // 
            resources.ApplyResources(this.lblProperties, "lblProperties");
            this.lblProperties.Name = "lblProperties";
            // 
            // pnlStatistics
            // 
            this.pnlStatistics.Controls.Add(this.lblNdJson);
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
            resources.ApplyResources(this.pnlStatistics, "pnlStatistics");
            this.pnlStatistics.Name = "pnlStatistics";
            // 
            // lblBool
            // 
            resources.ApplyResources(this.lblBool, "lblBool");
            this.lblBool.Name = "lblBool";
            // 
            // txtNodeCountBool
            // 
            resources.ApplyResources(this.txtNodeCountBool, "txtNodeCountBool");
            this.txtNodeCountBool.Name = "txtNodeCountBool";
            // 
            // txtString
            // 
            resources.ApplyResources(this.txtString, "txtString");
            this.txtString.Name = "txtString";
            // 
            // txtNodeCountString
            // 
            resources.ApplyResources(this.txtNodeCountString, "txtNodeCountString");
            this.txtNodeCountString.Name = "txtNodeCountString";
            // 
            // lblFloat
            // 
            resources.ApplyResources(this.lblFloat, "lblFloat");
            this.lblFloat.Name = "lblFloat";
            // 
            // txtNodeCountFloat
            // 
            resources.ApplyResources(this.txtNodeCountFloat, "txtNodeCountFloat");
            this.txtNodeCountFloat.Name = "txtNodeCountFloat";
            // 
            // lblInt
            // 
            resources.ApplyResources(this.lblInt, "lblInt");
            this.lblInt.Name = "lblInt";
            // 
            // txtNodeCountInt
            // 
            resources.ApplyResources(this.txtNodeCountInt, "txtNodeCountInt");
            this.txtNodeCountInt.Name = "txtNodeCountInt";
            // 
            // lblArray
            // 
            resources.ApplyResources(this.lblArray, "lblArray");
            this.lblArray.Name = "lblArray";
            // 
            // txtNodeCountArray
            // 
            resources.ApplyResources(this.txtNodeCountArray, "txtNodeCountArray");
            this.txtNodeCountArray.Name = "txtNodeCountArray";
            // 
            // lblObject
            // 
            resources.ApplyResources(this.lblObject, "lblObject");
            this.lblObject.Name = "lblObject";
            // 
            // txtNodeCountObject
            // 
            resources.ApplyResources(this.txtNodeCountObject, "txtNodeCountObject");
            this.txtNodeCountObject.Name = "txtNodeCountObject";
            // 
            // lblNodeCount
            // 
            resources.ApplyResources(this.lblNodeCount, "lblNodeCount");
            this.lblNodeCount.Name = "lblNodeCount";
            // 
            // txtNodeCount
            // 
            resources.ApplyResources(this.txtNodeCount, "txtNodeCount");
            this.txtNodeCount.Name = "txtNodeCount";
            // 
            // txtDisplayTime
            // 
            resources.ApplyResources(this.txtDisplayTime, "txtDisplayTime");
            this.txtDisplayTime.Name = "txtDisplayTime";
            // 
            // lblDisplayTime
            // 
            resources.ApplyResources(this.lblDisplayTime, "lblDisplayTime");
            this.lblDisplayTime.Name = "lblDisplayTime";
            // 
            // txtParseTime
            // 
            resources.ApplyResources(this.txtParseTime, "txtParseTime");
            this.txtParseTime.Name = "txtParseTime";
            // 
            // lblParseTime
            // 
            resources.ApplyResources(this.lblParseTime, "lblParseTime");
            this.lblParseTime.Name = "lblParseTime";
            // 
            // txtFileSize
            // 
            resources.ApplyResources(this.txtFileSize, "txtFileSize");
            this.txtFileSize.Name = "txtFileSize";
            // 
            // lblFileSize
            // 
            resources.ApplyResources(this.lblFileSize, "lblFileSize");
            this.lblFileSize.Name = "lblFileSize";
            // 
            // txtFileName
            // 
            resources.ApplyResources(this.txtFileName, "txtFileName");
            this.txtFileName.Name = "txtFileName";
            // 
            // lblFileName
            // 
            resources.ApplyResources(this.lblFileName, "lblFileName");
            this.lblFileName.Name = "lblFileName";
            // 
            // lblNdJson
            // 
            resources.ApplyResources(this.lblNdJson, "lblNdJson");
            this.lblNdJson.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNdJson.Name = "lblNdJson";
            // 
            // JSONViewer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitter);
            this.Name = "JSONViewer";
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
        private System.Windows.Forms.Label lblNdJson;
    }
}
