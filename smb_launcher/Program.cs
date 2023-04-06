using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smb_launcher
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
            if (File.Exists(@"SuperMeatBoy.exe"))
            {
                Application.Run(new Form1());
            }
            else
            {
                MessageBox.Show("SuperMeatBoy.exe wasn't found. Make sure the launcher is located in the same folder.");
                Environment.Exit(1);
            }
        }
    }
}
