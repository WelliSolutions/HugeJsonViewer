using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace HugeJSONViewer
{
    public partial class JSONViewer : UserControl
    {
        private FileInfo _jsonFile;

        public JSONViewer()
        {
            InitializeComponent();
        }

        public IList<HierarchicalJObject> TreeViewData
        {
            set
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();

                SuspendLayout();
                treeJsonTree.DataSource = value;

                if (value != null)
                {
                    {
                        txtNodeCount.Text = value.Count.ToString();
                        txtNodeCountObject.Text = value.Count(x => x.Token.Type == JTokenType.Object).ToString();
                        txtNodeCountArray.Text = value.Count(x => x.Token.Type == JTokenType.Array).ToString();
                        txtNodeCountInt.Text = value.Count(x => x.Token.Type == JTokenType.Integer).ToString();
                        txtNodeCountFloat.Text = value.Count(x => x.Token.Type == JTokenType.Float).ToString();
                        txtNodeCountString.Text = value.Count(x => x.Token.Type == JTokenType.String).ToString();
                        txtNodeCountBool.Text = value.Count(x => x.Token.Type == JTokenType.Boolean).ToString();
                    }
                }
                ResumeLayout(true);
                stopwatch.Stop();
                var parseTimeMilliseconds = stopwatch.ElapsedMilliseconds;
                txtDisplayTime.Text = HumanReadable.Time(parseTimeMilliseconds);
            }
        }

        public string ParseTime
        {
            set
            {
                txtParseTime.Text = value;
            }
        }

        public FileInfo JsonFile
        {
            get { return _jsonFile; }
            set
            {
                _jsonFile = value;
                txtFileName.Text = value.Name;
                txtFileSize.Text = HumanReadable.FileSize(value.Length);
            }
        }

        public bool IsNdJson
        {
            set => lblNdJson.Visible = value;
        }


        private void OnAfterFocusNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            var node =  treeJsonTree.GetDataRecordByNode(treeJsonTree.FocusedNode) as HierarchicalJObject;
            if (node == null) return;

            txtArrayData.Text = "";
            propJsonProperties.CloseEditor();
            propJsonProperties.SelectedObject = null;
            var propertyData = ConvertJsonItemToPropertyData(node);
            propJsonProperties.SelectedObject = propertyData;
        }

        private JsonDisplayData ConvertJsonItemToPropertyData(HierarchicalJObject node)
        {
            var propertyData = new JsonDisplayData();

            if (node.Token is JObject) propertyData.Type = "Object";
            else if (node.Token is JProperty) propertyData.Type = "Property";
            else if (node.Token is JArray) propertyData.Type = "Array";
            else propertyData.Type = node.Token.GetType().ToString();

            if (node.Token is JValue)
            {
                var jValue = (JValue) node.Token;
                propertyData.Value = jValue.Value?.ToString() ?? "";
                propertyData.Type = jValue.Type.ToString();
            }

            if (node.Token is JArray)
            {
                var array = (JArray)node.Token;
                propertyData.ArrayLength = array.Count;
                if (array.Count > 0)
                {
                    propertyData.Type = array.Children().First().Type + "[]";
                }

                txtArrayData.Text = array.ToString();
            }

            return propertyData;
        }

        private void OnExpandLevelChanged(object sender, EventArgs e)
        {
            treeJsonTree.CollapseAll();
            treeJsonTree.ExpandToLevel(int.Parse(cmbExpandLevel.SelectedItem.ToString()));
        }
    }
}
