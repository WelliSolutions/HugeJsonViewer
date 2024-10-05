using System.Windows.Forms;

namespace HugeJSONViewer
{
    public partial class ProgressForm : Form
    {
        public ProgressForm()
        {
            InitializeComponent();
        }

        private void OnClose(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
