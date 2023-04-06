namespace smb_launcher
{
    using IWshRuntimeLibrary;
    using Microsoft.CSharp.RuntimeBinder;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    public class smb_launcher : Form
    {
        private Process smb = new Process();
        private string textBox;
        private string textBox2;
        private string textBoxDeleteSaveExe;
        private bool islnk;
        private string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private IContainer components = null;
        private Button HighDetail;
        private Button LowDetail;
        private Button UltraLowDetail;
        private Button Savegame;
        private Button GamePath;
        private GroupBox groupBox;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button Help;

        public smb_launcher()
        {
            this.InitializeComponent();
            this.groupBox.Enabled = false;
            this.Savegame.Enabled = false;
            this.Help.Enabled = false;
            base.MinimizeBox = false;
            base.MaximizeBox = false;
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            if (!Directory.Exists(this.appdata + @"\JankiestFlashGame"))
            {
                Directory.CreateDirectory(this.appdata + @"\JankiestFlashGame");
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void GamePath_Click(object sender, EventArgs e)
        {
            string path = this.appdata + @"\JankiestFlashGame\path.cfg";
            if (File.Exists(path))
            {
                string str3 = "";
                using (StreamReader reader = File.OpenText(path))
                {
                    str3 = reader.ReadLine();
                }
                if (MessageBox.Show("There's a previously selected path:\n\n" + str3 + "\n\nWould you like to keep it?", "Path check", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    File.Delete(this.appdata + @"\JankiestFlashGame\path.cfg");
                    this.groupBox.Enabled = false;
                    this.Savegame.Enabled = false;
                    this.Help.Enabled = false;
                    this.GamePath_Click(sender, e);
                }
                else
                {
                    if (str3.EndsWith(".lnk"))
                    {
                        this.islnk = true;
                        this.textBox = str3;
                    }
                    else
                    {
                        this.islnk = false;
                        if (File.Exists(this.appdata + @"\JankiestFlashGame\SuperMeatBoy.lnk"))
                        {
                            WshShell shell3 = (WshShell) Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")));
                            if (<>o__7.<>p__2 == null)
                            {
                                <>o__7.<>p__2 = CallSite<Func<CallSite, object, IWshShortcut>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(IWshShortcut), typeof(smb_launcher.smb_launcher)));
                            }
                            IWshShortcut shortcut3 = <>o__7.<>p__2.Target(<>o__7.<>p__2, shell3.CreateShortcut(this.appdata + @"\JankiestFlashGame\SuperMeatBoy.lnk"));
                            this.textBoxDeleteSaveExe = shortcut3.WorkingDirectory;
                            this.textBox = this.appdata + @"\JankiestFlashGame\SuperMeatBoy.lnk";
                        }
                        else
                        {
                            WshShell shell2 = (WshShell) Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")));
                            string pathLink = this.appdata + @"\JankiestFlashGame\SuperMeatBoy.lnk";
                            if (<>o__7.<>p__1 == null)
                            {
                                <>o__7.<>p__1 = CallSite<Func<CallSite, object, IWshShortcut>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(IWshShortcut), typeof(smb_launcher.smb_launcher)));
                            }
                            IWshShortcut shortcut2 = <>o__7.<>p__1.Target(<>o__7.<>p__1, shell2.CreateShortcut(pathLink));
                            shortcut2.WorkingDirectory = str3.Remove(str3.Length - 0x10);
                            shortcut2.Description = "jankiestflashgame";
                            shortcut2.TargetPath = str3;
                            shortcut2.Save();
                            this.textBoxDeleteSaveExe = str3.Remove(str3.Length - 0x10);
                            this.textBox = pathLink;
                        }
                    }
                    this.groupBox.Enabled = true;
                    this.Savegame.Enabled = true;
                    this.Help.Enabled = true;
                }
            }
            else if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBox = this.folderBrowserDialog1.SelectedPath;
                if (!File.Exists(this.textBox + @"\SuperMeatBoy.exe"))
                {
                    if (!File.Exists(this.textBox + @"\SuperMeatBoy.lnk"))
                    {
                        MessageBox.Show("SuperMeatBoy.exe or its shortcut isn't located in the specified folder.");
                        this.groupBox.Enabled = false;
                        this.Savegame.Enabled = false;
                        this.Help.Enabled = false;
                    }
                    else
                    {
                        this.groupBox.Enabled = true;
                        this.Savegame.Enabled = true;
                        this.Help.Enabled = true;
                        this.islnk = true;
                        this.textBox = this.textBox + @"\SuperMeatBoy.lnk";
                        using (StreamWriter writer2 = File.CreateText(path))
                        {
                            writer2.WriteLine(this.textBox);
                        }
                    }
                }
                else
                {
                    this.groupBox.Enabled = true;
                    this.Savegame.Enabled = true;
                    this.Help.Enabled = true;
                    this.islnk = false;
                    WshShell shell = (WshShell) Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")));
                    string pathLink = this.appdata + @"\JankiestFlashGame\SuperMeatBoy.lnk";
                    if (<>o__7.<>p__0 == null)
                    {
                        <>o__7.<>p__0 = CallSite<Func<CallSite, object, IWshShortcut>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(IWshShortcut), typeof(smb_launcher.smb_launcher)));
                    }
                    IWshShortcut shortcut = <>o__7.<>p__0.Target(<>o__7.<>p__0, shell.CreateShortcut(pathLink));
                    shortcut.WorkingDirectory = this.textBox;
                    shortcut.Description = "jankiestflashgame";
                    shortcut.TargetPath = this.textBox + @"\SuperMeatBoy.exe";
                    shortcut.Save();
                    using (StreamWriter writer = File.CreateText(path))
                    {
                        writer.WriteLine(this.textBox + @"\SuperMeatBoy.exe");
                    }
                    this.textBoxDeleteSaveExe = this.textBox;
                    this.textBox = pathLink;
                }
            }
        }

        private void Help_Click(object sender, EventArgs e)
        {
            Process.Start("https://puu.sh/l10Ar.png");
        }

        private void HighDetail_Click(object sender, EventArgs e)
        {
            this.smb.StartInfo.FileName = this.textBox;
            this.smb.StartInfo.Arguments = "-highdetail";
            this.smb.Start();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(smb_launcher.smb_launcher));
            this.HighDetail = new Button();
            this.LowDetail = new Button();
            this.UltraLowDetail = new Button();
            this.Savegame = new Button();
            this.GamePath = new Button();
            this.groupBox = new GroupBox();
            this.folderBrowserDialog1 = new FolderBrowserDialog();
            this.Help = new Button();
            this.groupBox.SuspendLayout();
            base.SuspendLayout();
            this.HighDetail.Location = new Point(6, 0x13);
            this.HighDetail.Name = "HighDetail";
            this.HighDetail.Size = new Size(0x4b, 0x17);
            this.HighDetail.TabIndex = 0;
            this.HighDetail.Text = "High";
            this.HighDetail.UseVisualStyleBackColor = true;
            this.HighDetail.Click += new EventHandler(this.HighDetail_Click);
            this.LowDetail.Location = new Point(6, 0x30);
            this.LowDetail.Name = "LowDetail";
            this.LowDetail.Size = new Size(0x4b, 0x17);
            this.LowDetail.TabIndex = 1;
            this.LowDetail.Text = "Low";
            this.LowDetail.UseVisualStyleBackColor = true;
            this.LowDetail.Click += new EventHandler(this.LowDetail_Click);
            this.UltraLowDetail.Location = new Point(6, 0x4d);
            this.UltraLowDetail.Name = "UltraLowDetail";
            this.UltraLowDetail.Size = new Size(0x4b, 0x17);
            this.UltraLowDetail.TabIndex = 2;
            this.UltraLowDetail.Text = "Ultra low";
            this.UltraLowDetail.UseVisualStyleBackColor = true;
            this.UltraLowDetail.Click += new EventHandler(this.UltraLowDetail_Click);
            this.Savegame.Location = new Point(0x68, 0x31);
            this.Savegame.Name = "Savegame";
            this.Savegame.Size = new Size(0x4b, 0x43);
            this.Savegame.TabIndex = 3;
            this.Savegame.Text = "Delete savegame";
            this.Savegame.UseVisualStyleBackColor = true;
            this.Savegame.Click += new EventHandler(this.Savegame_Click);
            this.GamePath.Location = new Point(12, 12);
            this.GamePath.Name = "GamePath";
            this.GamePath.Size = new Size(0xa7, 0x17);
            this.GamePath.TabIndex = 4;
            this.GamePath.Text = "Game path...";
            this.GamePath.UseVisualStyleBackColor = true;
            this.GamePath.Click += new EventHandler(this.GamePath_Click);
            this.groupBox.Controls.Add(this.HighDetail);
            this.groupBox.Controls.Add(this.LowDetail);
            this.groupBox.Controls.Add(this.UltraLowDetail);
            this.groupBox.Location = new Point(12, 0x29);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new Size(0x56, 0x6b);
            this.groupBox.TabIndex = 5;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Start game";
            this.Help.Location = new Point(0x68, 0x79);
            this.Help.Name = "Help";
            this.Help.Size = new Size(0x4b, 0x17);
            this.Help.TabIndex = 6;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new EventHandler(this.Help_Click);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0xbf, 0x9b);
            base.Controls.Add(this.Help);
            base.Controls.Add(this.groupBox);
            base.Controls.Add(this.GamePath);
            base.Controls.Add(this.Savegame);
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Name = "smb_launcher";
            this.Text = "smb launcher";
            this.groupBox.ResumeLayout(false);
            base.ResumeLayout(false);
        }

        private void LowDetail_Click(object sender, EventArgs e)
        {
            this.smb.StartInfo.FileName = this.textBox;
            this.smb.StartInfo.Arguments = "-lowdetail";
            this.smb.Start();
        }

        private void Savegame_Click(object sender, EventArgs e)
        {
            if (!this.islnk)
            {
                if (File.Exists(this.textBoxDeleteSaveExe + @"\UserData\savegame.dat"))
                {
                    File.Delete(this.textBoxDeleteSaveExe + @"\UserData\savegame.dat");
                }
            }
            else
            {
                WshShell shell = (WshShell) Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")));
                if (<>o__8.<>p__0 == null)
                {
                    <>o__8.<>p__0 = CallSite<Func<CallSite, object, IWshShortcut>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(IWshShortcut), typeof(smb_launcher.smb_launcher)));
                }
                IWshShortcut shortcut = <>o__8.<>p__0.Target(<>o__8.<>p__0, shell.CreateShortcut(this.textBox));
                IWshShell shell2 = (WshShell) Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")));
                if (<>o__8.<>p__1 == null)
                {
                    <>o__8.<>p__1 = CallSite<Func<CallSite, object, IWshShortcut>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(IWshShortcut), typeof(smb_launcher.smb_launcher)));
                }
                IWshShortcut shortcut2 = <>o__8.<>p__1.Target(<>o__8.<>p__1, shell2.CreateShortcut(this.textBox));
                this.textBox2 = shortcut2.TargetPath.Remove(shortcut2.TargetPath.Length - 0x10);
                this.textBox2 = this.textBox2 + @"UserData\savegame.dat";
                if (File.Exists(this.textBox2))
                {
                    File.Delete(this.textBox2);
                }
            }
        }

        private void UltraLowDetail_Click(object sender, EventArgs e)
        {
            this.smb.StartInfo.FileName = this.textBox;
            this.smb.StartInfo.Arguments = "-ultralowdetail";
            this.smb.Start();
        }

        [CompilerGenerated]
        private static class <>o__7
        {
            public static CallSite<Func<CallSite, object, IWshShortcut>> <>p__0;
            public static CallSite<Func<CallSite, object, IWshShortcut>> <>p__1;
            public static CallSite<Func<CallSite, object, IWshShortcut>> <>p__2;
        }

        [CompilerGenerated]
        private static class <>o__8
        {
            public static CallSite<Func<CallSite, object, IWshShortcut>> <>p__0;
            public static CallSite<Func<CallSite, object, IWshShortcut>> <>p__1;
        }
    }
}
