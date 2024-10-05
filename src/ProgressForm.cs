using System.Windows.Forms;

namespace HugeJSONViewer
{
    public partial class ProgressForm : Form
    {
        public ProgressForm()
        {
            InitializeComponent();
        }

        public string Caption
        {
            set { progressPanel1.Caption = value; }
        }

        public string Description
        {
            set { progressPanel1.Description = value; }
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                Hide();
                Close();
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void OnClose(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
