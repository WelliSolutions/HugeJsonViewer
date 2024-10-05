using System;
using System.Globalization;
using System.Windows.Forms;

namespace HugeJSONViewer
{
    static class Program
    {
        [STAThread]
        static int Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.CurrentCulture;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mainForm = new MainForm {OpenFiles = args};
            Application.Run(mainForm);

            return (int) ExitCode.Success;
        }
    }
}
