using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiCopy
{
    public partial class Form1 : Form
    {
        bool showLog;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowLog_Click(object sender, EventArgs e)
        {
            showLog = !showLog;

            if (showLog)
            {
                //size 699; 583
                this.SetBounds(0, 0, 699, 583);
            }
            else
            {
                //size 699; 261
                this.SetBounds(0, 0, 699, 261);
            }
        }

        private void btnStartCopy_Click(object sender, EventArgs e)
        {
            string src = txtPathSource.Text;
            string dest = txtPathDest.Text;
            Log("Kopiervorgang gestartet");
            CopyFolder(src, dest);
        }

        private void btnSearchSource_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            txtPathSource.Text = dialog.SelectedPath;
        }

        private void btnSearchDest_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            txtPathDest.Text = dialog.SelectedPath;
        }





        DateTime start, stop;

        List<string> files = new List<string>();
        List<string> folders = new List<string>();

        string src_main = "";
        bool collected = false;
        bool created = false;

        private void Log(string text)
        {
            txtLog.Text += "[" + DateTime.Now.ToLongTimeString() + "] " + text + "\r\n";
        }

        Timer t = new Timer();

        private void CopyFolder(string source, string destination)
        {
            pbProgress.Value = 0;

            if (Directory.Exists(source))
            {
                if (!Directory.Exists(destination))
                {
                    try
                    {
                        Directory.CreateDirectory(destination);
                    }
                    catch { }
                }

                start = DateTime.Now;

                Log("Sammeln von Datei- und Ordnernamen ...");

                src_main = source;

                collected = false;
                created = false;

                Task t5 = new Task(() => { GetPaths(source); });
                t5.Start();

                Task t6 = new Task(() => { Folder(destination); });
                t6.Start();

                Task t7 = new Task(() => { Copying(destination); });
                t7.Start();

                t.Interval = 100;
                t.Tick += T_Tick;
                t.Start();
            }
        }

        //Check for End
        private void T_Tick(object sender, EventArgs e)
        {
            if (pbProgress.Value == pbProgress.Maximum)
            {
                if (!txtLog.Text.EndsWith("Kopiervorgang beendet!\r\n"))
                {
                    Log("Kopiervorgang beendet!");
                    stop = DateTime.Now;
                    MessageBox.Show("Kopiervorgang beendet!");
                    cbProgressCopied.CheckState = CheckState.Checked;
                    
                    GetTime();
                }
                t.Stop();
            }
        }

        private void GetTime()
        {
            double diff_ms = (stop - start).TotalMilliseconds;
            double diff_s = (stop - start).TotalSeconds;
            double diff_m = (stop - start).TotalMinutes;
            double diff_h = (stop - start).TotalHours;

            MessageBox.Show("Benötigte Zeit: " + (int)diff_h + ":" + (int)diff_m + ":" + (int)diff_s + ":" + (int)diff_ms + " (h,m,s,ms)");
        }



        //Async
        private void Folder(string destination)
        {
            while (true)
            {
                bool tm = false;
                this.Invoke((MethodInvoker)delegate
                {
                    tm = collected;
                });
                if (tm)
                    break;
            }

            foreach (string folder in folders)
            {
                Task t1 = new Task(() => { CreateFolder(destination + "\\" + folder); });
                t1.Start();
            }

            this.Invoke((MethodInvoker)delegate
            {
                Log("Ordner erstellt.");
                cbProgressCreated.CheckState = CheckState.Checked;

                Log("Starte Kopieren der Dateien ...");
            });
        }

        //Async
        private void Copying(string destination)
        {
            while (true)
            {
                bool tm = false;
                this.Invoke((MethodInvoker)delegate
                {
                    tm = collected;
                });
                if (tm)
                    break;
            }

            while (true)
            {
                bool tm = false;
                this.Invoke((MethodInvoker)delegate
                {
                    tm = created;
                });
                if (tm)
                    break;
            }

            foreach (string file in files)
            {
                Task t2 = new Task(() => { CopyFile(src_main + "\\" + file, destination + "\\" + file); });
                t2.Start();
            }
        }

        //Async
        private void CreateFolder(string dir)
        {
            try
            {
                Directory.CreateDirectory(dir);
            }
            catch
            {
                this.Invoke((MethodInvoker)delegate
                {
                    Log("Überspringe " + dir);
                });
            }

            this.Invoke((MethodInvoker)delegate
            {
                pbProgress.Value++;
                created = true;
            });
        }

        //Async
        private void CopyFile(string source, string destination)
        {
            try
            {
                File.Copy(source, destination);
            }
            catch
            {
                this.Invoke((MethodInvoker)delegate
                {
                    Log("Überspringe " + source);
                });
            }

            this.Invoke((MethodInvoker)delegate
            {
                pbProgress.Value++;
            });
        }

        
        //Rekursiv + Async
        private void GetPaths(string src)
        {
            GetDirs(src);

            foreach (string dir in folders)
            {
                GetFiles(src + "\\" + dir);
            }

            this.Invoke((MethodInvoker)delegate
            {
                collected = true;
                Log("Sammeln beendet.");
                cbProgressGet.CheckState = CheckState.Checked;

                int d = folders.Count;
                int f = files.Count;

                pbProgress.Maximum = d + f + 1;

                pbProgress.Value = 1;
                Log("Erstelle Ordner in Zielordner ...");
            });
        }

        //Rekursiv
        private void GetDirs(string dir)
        {
            DirectoryInfo di = null;

            try
            {
                di = new DirectoryInfo(dir);
            }
            catch { }

            foreach (DirectoryInfo d in di.GetDirectories())
            {
                folders.Add(d.FullName.Replace(src_main + "\\", ""));

                int l = 0;

                try
                {
                    l = d.GetDirectories().Length;
                }
                catch { }

                if (l > 0)
                {
                    GetDirs(d.FullName);
                }
            }
        }

        //Rekursiv
        private void GetFiles(string dir)
        {
            DirectoryInfo di = null;

            try
            {
                di = new DirectoryInfo(dir);
            }
            catch { }

            try
            {
                foreach (FileInfo f in di.GetFiles())
                {
                    files.Add(f.FullName.Replace(src_main + "\\", ""));
                }
            }
            catch { }
        }
    }
}
