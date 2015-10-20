using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AdbConnect
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            var form = new Form1();
            form.notifyIcon1.Visible = true;
            Application.Run();
        }
    }
}
