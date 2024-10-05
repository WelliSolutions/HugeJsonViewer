using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;

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
            using (_progress = new Progress(this))
            {
                var reader = new HugeJsonReader();
                ErrorInfo<FileInfo> file = reader.OpenFile(filename);
                if (file.HasError)
                {
                    throw new JsonHasErrorsException(file.Message);
                }

                var fileInfo = file.Value;

                Invoke(new Action(() => _progress.Caption = "Parsing JSON"));
                Invoke(new Action(() => _progress.Description = "Please wait..."));
                var json = reader.Deserialize(fileInfo, s => _progress.Description = s);
                if (json.HasError)
                {
                    throw new JsonHasErrorsException(json.Message);
                }

                Invoke(new Action(() => _progress.Caption = "Converting into display data"));
                Invoke(new Action(() => _progress.Description = "Please wait..."));
                // Convert into a displayable object (DevExpress)
                dataSource = new List<HierarchicalJObject>();
                var h = new HierarchicalJObject(dataSource) {Object = json.Value.Value};
                HierarchicalJObject.OnProgress += OnProgress;
                dataSource.Add(h);

                var jsonViewer = AddNewTab(file.Value.Name);
                jsonViewer.JsonFile = file.Value;
                jsonViewer.ParseTime = HumanReadable.Time(json.Value.ElapsedMilliseconds);
                _progress.Caption = "Displaying";
                jsonViewer.TreeViewData = dataSource;
                jsonViewer.treeJsonTree.RootValue = h.ID;
                HierarchicalJObject.OnProgress -= OnProgress;
                HierarchicalJObject.ResetProgress();
                dataSource = null;
            }
            _progress = null;
        }

        List<HierarchicalJObject> dataSource = new List<HierarchicalJObject>();
        private Progress _progress;

        private void OnProgress(int progress)
        {
            Invoke(new Action(() => _progress.Description = $"{progress*50/dataSource.Count-50}%"));
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
                    jsonViewer = null;
                    GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);
                }
            }
            jsonTabs.TabPages.Remove(pageToClose);
        }

        private void OnShown(object sender, EventArgs e)
        {
            string allerrors = string.Empty;
            foreach (var filename in OpenFiles)
            {
                try
                {
                    LoadJson(filename);
                }
                catch (JsonHasErrorsException exception)
                {
                    allerrors += exception.Message + Environment.NewLine + Environment.NewLine;
                }
            }
            if (!string.IsNullOrEmpty(allerrors))
            {
                ShowJsonError(allerrors);
            }
        }

        private void ShowJsonError(string message)
        {
            MessageBox.Show(this, message, "Error loading JSON", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}