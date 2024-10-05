using System;
using System.Drawing;

namespace HugeJSONViewer
{
    class Progress:IDisposable
    {
        private ProgressForm _form;

        internal Progress(MainForm parent)
        {
            _form = new ProgressForm();
            var x = parent.Location.X + (parent.Width - _form.Width) / 2;
            var y = parent.Location.Y + (parent.Height - _form.Height) / 2;
            _form.Location = new Point(Math.Max(x, 0), Math.Max(y, 0));
            _form.Show();
        }

        public string Caption
        {
            set { _form.progressPanel1.Caption = value; }
        }

        public string Description {
            set { _form.progressPanel1.Description = value; } }

        public void Dispose()
        {
            _form.Hide();
            _form.Close();
            _form.Dispose();
            _form = null;
        }
    }
}
