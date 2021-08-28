using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cids_Installer
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        //[MTAThread]
        static void Main()
        {
            LocalTest.MvDir();
            //LocalTest.MvTest();
            //MainTodo();
        }
            //ÍË³ö
            //Application.Run(new Configuration());
            //Form First = new Configuration();
            //Form Last = new Configuration();
            //Application.Run(First);
            //Application.Run(Last);
        static void MainTodo()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Installer());
        }
    }
}
