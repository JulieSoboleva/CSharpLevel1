using System;
using System.Windows.Forms;

namespace Doubler
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDoubler());
        }
    }
}
