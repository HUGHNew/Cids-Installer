using System;
using System.Windows.Forms;

namespace Cids_Installer {
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        //[MTAThread]
        static void Main()
        {
            MainTodo();
        }
        static void MainTodo()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Installer());
        }
    }
}
