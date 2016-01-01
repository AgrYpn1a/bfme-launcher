using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFME_LAUNCHER
{

    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
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
            ROTWKPb.BringToFront() ;
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
            BFME1Pb.BringToFront();
            SelectBFME2.BringToFront();
            SelectROTWK.BringToFront();
            this.BFME1Pb.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.bfme1Active;
            this.BFME2Pb.BackgroundImage = null;
            this.ROTWKPb.BackgroundImage = null;
            this.SelectedBG.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.bfme1Background;
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


    }
}
