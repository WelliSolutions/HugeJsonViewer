using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using HugeJSONViewer.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace HugeJSONViewer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public string[] OpenFiles { get; set; }


        private void mnuFileOpen_Click(object sender, EventArgs e)
        {

            var answer = openJsonFile.ShowDialog(this);
            if (answer == DialogResult.Cancel) return;
            var fileName = openJsonFile.FileName;

            try
            {
                LoadJson(fileName);
            }
            catch (JsonHasErrorsException exception)
            {
                ShowJsonError(exception.Message);
            }
        }

        private void LoadJson(string filename)
        {
            using (_progress = new ProgressForm())
            {
                _progress.Show();
                WindowPositioner.CenterOnParent(_progress, this);
                var reader = new HugeJsonReader();
                var file = reader.OpenFile(filename);
                if (file.HasError)
                {
                    throw new JsonHasErrorsException(file.Message);
                }

                var fileInfo = file.Value;

                Invoke(new Action(() => _progress.Caption = Resources.ParsingJsonCaption));
                Invoke(new Action(() => _progress.Description = Resources.ParsingJsonWaitMessage));
                var json = reader.Deserialize(fileInfo, s => _progress.Description = s);
                if (json.HasError)
                {
                    throw new JsonHasErrorsException(json.Message);
                }
                if (!json.Value.Value.ReachedEndOfStream)
                {
                    MessageBox.Show(this, Resources.MaybeNewlineDelimited, Resources.MaybeNewlineDelimitedCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                Invoke(new Action(() => _progress.Caption = Resources.ConvertingJsonCaption));
                Invoke(new Action(() => _progress.Description = Resources.ConvertingJsonWaitMessage));
                // Convert into a displayable object (DevExpress)
                _dataSource = new List<HierarchicalJObject>();
                var h = new HierarchicalJObject(_dataSource) {Token = json.Value.Value.Data};
                HierarchicalJObject.OnProgress += OnProgress;
                _dataSource.Add(h);

                var jsonViewer = AddNewTab(file.Value.Name);
                jsonViewer.JsonFile = file.Value;
                jsonViewer.ParseTime = HumanReadable.Time(json.Value.ElapsedMilliseconds);
                _progress.Caption = Resources.DisplayingJsonCaption;
                _progress.Description = Resources.DisplayingJsonWaitMessage;
                jsonViewer.TreeViewData = _dataSource;
                jsonViewer.treeJsonTree.RootValue = h.ID;
                HierarchicalJObject.OnProgress -= OnProgress;
                HierarchicalJObject.ResetProgress();
                _dataSource = null;
            }
            _progress = null;
        }

        List<HierarchicalJObject> _dataSource = new List<HierarchicalJObject>();
        private ProgressForm _progress;

        private void OnProgress(int progress)
        {
            Invoke(new Action(() => _progress.Description = string.Format(Resources.ProcessingJsonProgress, progress * 50 / _dataSource.Count - 50)));
            Application.DoEvents();
        }

        private JSONViewer AddNewTab(string title)
        {
            var tabPage = new XtraTabPage {Text = title, ShowCloseButton = DefaultBoolean.True};

            var jsonViewer = new JSONViewer {Dock = DockStyle.Fill};
            tabPage.Controls.Add(jsonViewer);

            jsonTabs.TabPages.Add(tabPage);
            jsonTabs.SelectedTabPage = tabPage;
            return jsonViewer;
        }

        private void OnClose(object sender, EventArgs e)
        {
            var closeArgs = e as ClosePageButtonEventArgs;
            var pageToClose = (XtraTabPage) closeArgs?.Page;
            var jsonViewer = pageToClose?.Controls[0] as JSONViewer;            
            if (jsonViewer != null)
            {
                if (jsonViewer.JsonFile.Length > 100.MBToBytes())
                {
                    jsonViewer.TreeViewData = null;
                    // ReSharper disable once RedundantAssignment
                    jsonViewer = null;
                    GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);
                }
            }
            jsonTabs.TabPages.Remove(pageToClose);
        }

        private void OnShown(object sender, EventArgs e)
        {
            var allErrors = string.Empty;
            foreach (var filename in OpenFiles)
            {
                try
                {
                    LoadJson(filename);
                }
                catch (JsonHasErrorsException exception)
                {
                    allErrors += exception.Message + Environment.NewLine + Environment.NewLine;
                }
            }
            if (!string.IsNullOrEmpty(allErrors))
            {
                ShowJsonError(allErrors);
            }
        }

        private void ShowJsonError(string message)
        {
            MessageBox.Show(this, message, Resources.ErrorLoadingJson, MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, Resources.AboutMessage, Resources.AboutTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}