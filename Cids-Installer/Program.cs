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
        static void Main()
        {
            //SqlTest.QueryTestData();
            //SqlTest.QueryTestEmpty();
            //SqlTest.QueryIdMap();
            LocalTest.JsonTest();
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
