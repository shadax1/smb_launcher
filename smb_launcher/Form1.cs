using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smb_launcher
{
    public partial class Form1 : Form
    {
        private Process smb = new Process();

        public Form1()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void HighDetail_Click(object sender, EventArgs e)
        {
            smb.StartInfo.FileName = "SuperMeatBoy.exe";
            smb.StartInfo.Arguments = "-highdetail";
            smb.Start();
        }

        private void LowDetail_Click(object sender, EventArgs e)
        {
            smb.StartInfo.FileName = "SuperMeatBoy.exe";
            smb.StartInfo.Arguments = "-lowdetail";
            smb.Start();
        }

        private void UltraLowDetail_Click(object sender, EventArgs e)
        {
            smb.StartInfo.FileName = "SuperMeatBoy.exe";
            smb.StartInfo.Arguments = "-ultralowdetail";
            smb.Start();
        }

        private void Savegame_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"UserData\savegame.dat"))
                File.Delete(@"UserData\savegame.dat");
        }
    }
}
