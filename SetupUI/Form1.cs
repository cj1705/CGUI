using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetupUI
{

    public partial class Form1 : Form
    {
        string TitleTxt;
        string appnametxt;
        string defaultinstalltxt;
        bool Options;
        string filespath;
        string mainexe;
        string installto;
        string version = "Beta1.0";

        public Form1(string Title, string appnametxt, bool Options, string filespath, string mainexe)
        {
            InitializeComponent();
            TitleTxt = Title;
            this.appnametxt = appnametxt;
            this.Options = Options;
            this.filespath = filespath;
            this.mainexe = mainexe;
        }

        private void flatTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            versiontxt.Text =version;
            TitleLabel.Text = TitleTxt;
            if (defaultinstalltxt == null)
            {
                defaultinstalltxt = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\appdata\local\CarsonGames\" + appnametxt;
            }
            locationtxt.Text = defaultinstalltxt;
            if (Options)
            {
                groupBox1.Visible = true;
            }
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void copy_Click(object sender, EventArgs e)
        {

        }


        private void flatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                installto = locationtxt.Text;
                tabControl1.SelectedIndex = 1;



                List<string> files = new List<string>();
                foreach (string file in Directory.EnumerateFiles(filespath, "*.*", SearchOption.AllDirectories))
                {
                    files.Add(Path.GetFullPath(file));
                }


                if (!Directory.Exists(installto))
                {
                    Directory.CreateDirectory(installto);
                }
                else
                {
                    if (MessageBox.Show("Folder already Exists! Replace?", "Conflict", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Directory.Delete(installto, true);
                        Directory.CreateDirectory(installto);
                    }
                }

                int numoffiles = files.Count;
                int numoffilespro = 0;

                foreach (var file in files)


                {
                    Copy(filespath, installto);
                }
            }
            catch (UnauthorizedAccessException ee)
            {
                MessageBox.Show("Unable to write to the selected folder. Check if the current user has proper permission. Exiting.");
                Environment.Exit(0);
            }







            if (startmenucheck.Checked)
            {
                CreateShortcut();
            }
            tabControl1.SelectedIndex = 2;


        }


        public  void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            try
            {

                Directory.CreateDirectory(target.FullName);

                // Copy each file into the new directory.
                foreach (FileInfo fi in source.GetFiles())
                {
                    richTextBox1.AppendText($"Copying {target.FullName}\\{fi.Name} \n");
                    fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
                }

                // Copy each subdirectory using recursion.
                foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
                {
                    DirectoryInfo nextTargetSubDir =
                        target.CreateSubdirectory(diSourceSubDir.Name);
                    CopyAll(diSourceSubDir, nextTargetSubDir);
                }
            }
            catch(UnauthorizedAccessException e)
            {
                MessageBox.Show("Unable to write to the selected folder. Check if the current user has proper permission. Exiting.");
                Environment.Exit(0);
            }
        }
        public  void Copy(string sourceDirectory, string targetDirectory)
        {
            DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
            DirectoryInfo diTarget = new DirectoryInfo(targetDirectory);

            CopyAll(diSource, diTarget);
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
           
        }

        public void CreateShortcut()
        {
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\appdata\Roaming\Microsoft\Windows\Start Menu\Programs\" + appnametxt+".lnk");
            shortcut.TargetPath = installto+ @"\" +mainexe;                
            shortcut.Save();                               
        }
        private void flatLabel1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flatLabel2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void startmenucheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FIlesTXT_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void flatLabel3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            Process.Start(installto); 
        }

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            string tempstring = e.KeyValue.ToString();
            if (tempstring == "37" || tempstring == "38" || tempstring == "39" || tempstring == "40")
            {
                e.Handled = true;
            }
        }

        private void flatButton3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
