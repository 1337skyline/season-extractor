using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Season_Extractor
{
    public partial class Main : Form
    {
        int i;
        string sDir, xTractPath;
        bool TF = false;

        public Main()
        {
            InitializeComponent();
        }



        public void DirSearch(string sDir)
        {
            foreach (string d in Directory.GetDirectories(sDir))
            {
                foreach (string f in Directory.GetFiles(d, @"*.rar"))
                {
                    FilesInsDir.Items.Add(f);
                    Console.WriteLine(f);
                }

                DirSearch(d);
            }
        }

        private void DirButton_Click(object sender, EventArgs e)
        {
            PathChooseDialog.ShowDialog();
            sDir = (PathChooseDialog.SelectedPath.ToString());
            label2.Text = "Choosen Path: " + sDir;
        }

        private void SrcButton_Click(object sender, EventArgs e)
        {
            SrcButton.Text = "Searching...";
            FilesInsDir.Items.Clear();
            DirSearch(sDir);
            SrcButton.Text = "Search";
            TF = true;
        }

        private void SlctAllBtn_Click(object sender, EventArgs e)
        {
            if (TF == true)
            {
                for (i = 0; i < FilesInsDir.Items.Count; i++)
                    FilesInsDir.SetItemChecked(i, true);
            }
        }

        private void DSlctAllBtn_Click(object sender, EventArgs e)
        {
            if (TF == true)
            {
                for (i = 0; i < FilesInsDir.Items.Count; i++)
                    FilesInsDir.SetItemChecked(i, false);
            }
        }

        private void xTract_Click(object sender, EventArgs e)
        {
            PathChooseDialog.ShowDialog();
            xTractPath = PathChooseDialog.SelectedPath.ToString();
            
            unrar();
        }

        public void ZCreate()
        {
            Assembly myAssemblyE = Assembly.GetExecutingAssembly();
            int sLengthE;
            Stream streamE;
            streamE = myAssemblyE.GetManifestResourceStream(@"Season_Extractor.Resources.unrar.exe");
            sLengthE = (int)streamE.Length;
            byte[] bytesE = new byte[sLengthE];
            streamE.Read(bytesE, 0, bytesE.Length);
            File.WriteAllBytes(sDir + "/unrar.exe", bytesE);

            Assembly myAssembly3 = Assembly.GetExecutingAssembly();
            int sLength3;
            Stream stream3;
            stream3 = myAssembly3.GetManifestResourceStream(@"Season_Extractor.Resources.unrar3.dll");
            sLength3 = (int)stream3.Length;
            byte[] bytes3 = new byte[sLength3];
            stream3.Read(bytes3, 0, bytes3.Length);
            File.WriteAllBytes(sDir + "/unrar3.dll", bytes3);
        }

        public void unrar()
        {
            ZCreate();
            if (TF == true)
            {
                foreach (object ItemChecked in FilesInsDir.CheckedItems)
                {
                    Process p = new Process();
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.FileName = (sDir + "/unrar.exe");
                    p.StartInfo.Arguments = ("x " + ItemChecked.ToString() + " " + xTractPath + "/");
                    p.Start();
                    p.WaitForExit();
                }
                OpenExtractPath();
            }

            File.Delete(sDir + "/unrar.exe");
            File.Delete(sDir + "/unrar3.dll");

        }

        public void OpenExtractPath()
        {
            if (OpenPathCheck.Checked == true)
            {
                Process.Start("explorer.exe", xTractPath);
            }
        }
    }
}

