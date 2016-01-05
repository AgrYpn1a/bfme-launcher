using SharpUpdate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFME_LAUNCHER
{

    public partial class Launcher : Form, ISharpUpdatable
    {
        // UPDATER
        private SharpUpdater updater;

        private void button1_Click(object sender, EventArgs e)
        {
            updater.DoUpdate();
        }

        #region SharpUpdate
        public string ApplicationName
        {
            get { return "BfmeLauncher"; }
        }

        public string ApplicationID
        {
            get { return "BfmeLauncher"; }
        }

        public Assembly ApplicationAssembly
        {
            get { return Assembly.GetExecutingAssembly(); }
        }

        public Icon ApplicationIcon
        {
            get { return this.Icon; }
        }

        public Uri UpdateXmlLocation
        {
            get { return new Uri("https://www.dropbox.com/s/px5wxkvjccnkfr4/update.xml?dl=1"); }
        }

        public Form Context
        {
            get { return this; }
        }
        #endregion










        // MAIN FORM

        public Launcher()
        {
            InitializeComponent();

            // fix button white borders
            update.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            Play.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            Install.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            Minimize.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            Close.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            this.initDownloader();
        }


        // PLAY BUTTON mouse events
        // NOTE that I have switched PlayHover with PlayClicked because it looks better
        private void Play_MouseEnter(object sender, EventArgs e)
        {
            this.Play.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.PlayClicked;
        }

        private void Play_MouseLeave(object sender, EventArgs e)
        {
            this.Play.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.Play;
        }

        private void Play_MouseDown(object sender, MouseEventArgs e)
        {
            this.Play.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.PlayHover;
        }

        private void Play_MouseUp(object sender, MouseEventArgs e)
        {
            this.Play.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.PlayClicked;
        }




        private void Close_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("BFME Download");
            foreach (var process in processes)
            {
                process.Kill();
            }
            this.Close.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.quitClicked;
            this.Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.Minimize.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.minClicked;
            this.WindowState = FormWindowState.Minimized;
        }
        private bool drag = false;
        //private Point _offset;
        private Point startPoint = new Point(0, 0);

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {

            this.startPoint = e.Location;

            this.drag = true;



        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.drag)
            {
                Point p1 = new Point(e.X, e.Y);

                Point p2 = this.PointToScreen(p1);

                Point p3 = new Point(p2.X - this.startPoint.X,

                                     p2.Y - this.startPoint.Y);

                this.Location = p3;

            }


        }

        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            this.drag = false;
        }

        private void SelectBFME1_Click(object sender, EventArgs e)
        {
            SelectBFME1.Visible = false;
            SelectBFME2.Visible = true;
            SelectROTWK.Visible = true;
            SelectBFME2.BringToFront();
            SelectROTWK.BringToFront();
            BFME1Pb.BringToFront();
            this.BFME1Pb.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.bfme1Active;
            this.BFME2Pb.BackgroundImage = null;
            this.ROTWKPb.BackgroundImage = null;
            this.SelectedBG.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.bfme1Background;
        }

        private void SelectBFME2_Click(object sender, EventArgs e)
        {
            //this.BFME1Pb.Parent = this.BFME2Pb;
            SelectBFME2.Visible = false;
            SelectBFME1.Visible = true;
            SelectROTWK.Visible = true;
            SelectBFME1.BringToFront();
            SelectROTWK.BringToFront();
            BFME2Pb.BringToFront();
            this.BFME1Pb.BackgroundImage = null;
            this.BFME2Pb.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.bfme2Active;
            this.ROTWKPb.BackgroundImage = null;
            this.SelectedBG.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.bfme2Background;
        }

        private void SelectROTWK_Click(object sender, EventArgs e)
        {
            SelectROTWK.Visible = false;
            SelectBFME1.Visible = true;
            SelectBFME2.Visible = true;
            SelectBFME1.BringToFront();
            SelectBFME2.BringToFront();
            ROTWKPb.BringToFront();
            this.BFME1Pb.BackgroundImage = null;
            this.BFME2Pb.BackgroundImage = null;
            this.ROTWKPb.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.bfmeRotwkActive;
            this.SelectedBG.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.bfmeRotwkBackground;
        }

        private void Launcher_Load(object sender, EventArgs e)
        {
            SelectBFME1.Visible = false;
            SelectBFME2.Visible = true;
            SelectROTWK.Visible = true;
            SelectBFME2.BringToFront();
            SelectROTWK.BringToFront();
            BFME1Pb.BringToFront();
            this.BFME1Pb.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.bfme1Active;
            this.BFME2Pb.BackgroundImage = null;
            this.ROTWKPb.BackgroundImage = null;
            this.SelectedBG.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.bfme1Background;
            getFilesize();
            backgroundWorker1.RunWorkerAsync();
        }


        private void Close_MouseEnter(object sender, EventArgs e)
        {
            this.Close.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.quitHover;

        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            this.Close.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.quit;
        }

        private void Minimize_MouseEnter(object sender, EventArgs e)
        {
            this.Minimize.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.minHover;

        }

        private void Minimize_MouseLeave(object sender, EventArgs e)
        {
            this.Minimize.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.min;
        }

        private void MainLogo_MouseDown(object sender, MouseEventArgs e)
        {
            this.startPoint = e.Location;

            this.drag = true;

        }

        private void MainLogo_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.drag)
            {
                Point p1 = new Point(e.X, e.Y);

                Point p2 = this.PointToScreen(p1);

                Point p3 = new Point(p2.X - this.startPoint.X,

                                     p2.Y - this.startPoint.Y);

                this.Location = p3;
            }

        }

        private void MainLogo_MouseUp(object sender, MouseEventArgs e)
        {
            this.drag = false;
        }

        private void Info_MouseDown(object sender, MouseEventArgs e)
        {
            this.startPoint = e.Location;

            this.drag = true;

        }

        private void Info_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.drag)
            {
                Point p1 = new Point(e.X, e.Y);

                Point p2 = this.PointToScreen(p1);

                Point p3 = new Point(p2.X - this.startPoint.X,

                                     p2.Y - this.startPoint.Y);

                this.Location = p3;
            }

        }

        private void Info_MouseUp(object sender, MouseEventArgs e)
        {
            this.drag = false;
        }


        /*
            ------------
            |LOGO-LINKS| >>>>> BEGIN
            ------------
        */

        // T3A mouse events
        private void T3A_Click(object sender, EventArgs e)
        {
            Process.Start("https://forums.revora.net/");
        }

        private void T3A_MouseEnter(object sender, EventArgs e)
        {
            this.T3A.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.t3aHover;
        }

        private void T3A_MouseLeave(object sender, EventArgs e)
        {
            this.T3A.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.t3a;
        }
        // END T3A


        // BFMETEAM mouse events
        private void BFMETeam_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/thebfme/");
        }

        private void BFMETeam_MouseEnter(object sender, EventArgs e)
        {
            this.BFMETeam.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.bfmeteamHover;
        }

        private void BFMETeam_MouseLeave(object sender, EventArgs e)
        {
            this.BFMETeam.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.bfmeteam;
        }
        // END BFMETEAM


        // EA LOGO mouse events
        private void EALogo_Click(object sender, EventArgs e)
        {
            Process.Start("https://help.ea.com/en/contact-us/new/");
        }

        private void EALogo_MouseEnter(object sender, EventArgs e)
        {
            this.EALogo.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.eaHover;
        }

        private void EALogo_MouseLeave(object sender, EventArgs e)
        {
            this.EALogo.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.ea;
        }
        // EA LOGO END


        /*
        ------------
        |LOGO-LINKS| >>>>>>> END
        ------------
        */
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ROTWKPb_Click(object sender, EventArgs e)
        {

        }


        // INSTALL mouse events
        private void Install_MouseDown(object sender, MouseEventArgs e)
        {
            this.Install.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.installClicked;
        }

        private void Install_MouseUp(object sender, MouseEventArgs e)
        {
            this.Install.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.installHover;
        }

        private void Install_MouseLeave(object sender, EventArgs e)
        {
            this.Install.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.install;
        }

        private void Install_MouseEnter(object sender, EventArgs e)
        {
            this.Install.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.installHover;
        }

        private void SelectBFME2_MouseEnter(object sender, EventArgs e)
        {
            this.SelectBFME2.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.bfme2Hover;
        }

        private void SelectBFME2_MouseLeave(object sender, EventArgs e)
        {
            this.SelectBFME2.BackgroundImage = null;
        }

        private void SelectROTWK_MouseEnter(object sender, EventArgs e)
        {
            this.SelectROTWK.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.bfmeRotwkHover;
            SelectROTWK.BringToFront();
        }

        private void SelectROTWK_MouseLeave(object sender, EventArgs e)
        {
            this.SelectROTWK.BackgroundImage = null;
        }

        private void SelectBFME1_MouseEnter(object sender, EventArgs e)
        {
            this.SelectBFME1.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.bfme1Hover;

        }

        private void SelectBFME1_MouseLeave(object sender, EventArgs e)
        {
            this.SelectBFME1.BackgroundImage = null;
        }

        private void checkBoxChecked_Click(object sender, EventArgs e)
        {
            checkBoxEmpty.BringToFront();

        }

        private void checkBoxEmpty_Click(object sender, EventArgs e)
        {
            checkBoxChecked.BringToFront();
        }

        // REFRESH button, mouse events
        private void refresh_MouseDown(object sender, MouseEventArgs e)
        {
            this.refresh.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.refreshClicked;
            // GET notes
            try
            {
                var request = WebRequest.Create("https://www.dropbox.com/s/5wc7wv0m5vz8bzf/news1.png?dl=1");

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    notesPictureBox.Image = Bitmap.FromStream(stream);
                }
            }
            catch
            {
                MessageBox.Show("No internet connection!");
            }
        }

        private void refresh_MouseUp(object sender, MouseEventArgs e)
        {
            this.refresh.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.refresh;
        }
        // END REFRESH button

        // UPDATE button, mouse events
        private void update_MouseEnter(object sender, EventArgs e)
        {
            this.update.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.updateHover;
        }

        private void update_MouseLeave(object sender, EventArgs e)
        {
            this.update.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.update;
        }

        private void update_MouseUp(object sender, MouseEventArgs e)
        {
            this.update.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.updateHover;
        }

        private void update_MouseDown(object sender, MouseEventArgs e)
        {
            this.update.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.updateClicked;
            updater = new SharpUpdater(this);
            updater.DoUpdate();
        }
        // END UPDATE button




        // GAME DOWNLOADER
        public void getFilesize()
        {
            string URL = "https://www.dropbox.com/s/mk5saoj34ev6eog/bfme-launcher.zip?dl=1";
            string filetype = URL.Substring(URL.LastIndexOf(".") + 1,
                    (URL.Length - URL.LastIndexOf(".") - 1));

            string filename = URL.Substring(URL.LastIndexOf("/") + 1,
                    (URL.Length - URL.LastIndexOf("/") - 1));

            System.Net.WebRequest req = System.Net.HttpWebRequest.Create(URL);
            req.Method = "HEAD";
            System.Net.WebResponse resp = req.GetResponse();

            if (long.TryParse(resp.Headers.Get("Content-Length"), out ContentLength))
            {
                double s3 = ContentLength;
            }
        }

        //Get filesize from the link
        public long ContentLength;
        //global variable declared for file size
        public int r;
        public string s2;
        public void pb()
        {
            try {
                const string fileName = @"setup.exe";
                FileInfo f = new FileInfo(fileName);
                double s1 = f.Length;

                double result;
                result = (s1 / ContentLength) * 100;
                r = (int)result;
                s2 = s1.ToString();
                //MessageBox.Show(s2);

                result = (s1 / ContentLength) * 100;
                r = (int)result;
                backgroundWorker1.ReportProgress(r);
            }
            catch
            { }
        

        }
        //get progressbar , r is the percentage of download, s1 is bytes downloaded
        
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while(r<=100)
            pb();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            this.Percentage.Text = s2;
        }

        private void btnDwPlay_Click(object sender, EventArgs e)
        {
            string ApplicationPath = "BFME Download.exe";
            string ApplicationArguments = "-c -x";

            // Create a new process object
            Process ProcessObj = new Process();

            // StartInfo contains the startup information of
            // the new process
            ProcessObj.StartInfo.FileName = ApplicationPath;
            ProcessObj.StartInfo.Arguments = ApplicationArguments;

            // These two optional flags ensure that no DOS window
            // appears
            ProcessObj.StartInfo.UseShellExecute = false;
            ProcessObj.StartInfo.CreateNoWindow = true;

            // If this option is set the DOS window appears again :-/
            // ProcessObj.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            // This ensures that you get the output from the DOS application
            ProcessObj.StartInfo.RedirectStandardOutput = true;

            // Start the process
            ProcessObj.Start();
            backgroundWorker1.ReportProgress(r);

        }

        private void btnDwPlay_MouseUp(object sender, MouseEventArgs e)
        {
            this.btnDwPlay.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.dwPlay;
        }

        private void btnDwPlay_MouseDown(object sender, MouseEventArgs e)
        {
            this.btnDwPlay.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.dwPlayClicked;
        }



        public int f = 0;//flag for async work
        private void Install_Click(object sender, EventArgs e)
        {
            getFilesize();
            string ApplicationPath = "BFME Download.exe";
            string ApplicationArguments = "-c -x";

            // Create a new process object
            Process ProcessObj = new Process();

            // StartInfo contains the startup information of
            // the new process
            ProcessObj.StartInfo.FileName = ApplicationPath;
            ProcessObj.StartInfo.Arguments = ApplicationArguments;

            // These two optional flags ensure that no DOS window
            // appears
            ProcessObj.StartInfo.UseShellExecute = false;
            ProcessObj.StartInfo.CreateNoWindow = true;

            // If this option is set the DOS window appears again :-/
            // ProcessObj.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            // This ensures that you get the output from the DOS application
            ProcessObj.StartInfo.RedirectStandardOutput = true;

            // Start the process
            ProcessObj.Start();
            
           
                
            this.Install.Visible = false;

        }
        
        private void but_Pause_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("BFME Download");
            foreach (var process in processes)
            {
                process.Kill();
            }
            
        }

        private void btnDwPause_MouseDown(object sender, MouseEventArgs e)
        {
            this.btnDwPause.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.dwPauseClicked;
        }

        private void btnDwPause_MouseUp(object sender, MouseEventArgs e)
        {
            this.btnDwPause.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.dwPause;
        }



        private void but_Stop_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("BFME Download");
            foreach (var process in processes)
            {
                process.Kill();
                process.WaitForExit();
            }
            if (File.Exists(@"setup.exe"))
            {
                
                File.Delete(@"setup.exe");
            }
            r=0;
            s2 = "0";
            backgroundWorker1.ReportProgress(r);
           // this.Percentage.Text = "FUCK U";
            // backgroundWorker1.ReportProgress(0);
        }


        private void initDownloader()
        {
            btnDwPause.Enabled = false;
            btnDwPause.Visible = false;
        }

    }
}

// This comment should not be changed

