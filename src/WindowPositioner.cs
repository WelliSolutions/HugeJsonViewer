using System;
using System.Drawing;
using System.Windows.Forms;

namespace HugeJSONViewer
{
    public static class WindowPositioner
    {
        public static void CenterOnParent(Form child, Form parent)
        {
            var x = parent.Location.X + (parent.Width - child.Width) / 2;
            var y = parent.Location.Y + (parent.Height - child.Height) / 2;
            child.Location = new Point(Math.Max(x, 0), Math.Max(y, 0));
        }
    }
}
