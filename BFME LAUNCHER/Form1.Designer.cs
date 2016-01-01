using System.Drawing;

namespace BFME_LAUNCHER
{
    partial class Launcher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.Play = new System.Windows.Forms.Button();
            this.MainLogo = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.SelectedBG = new System.Windows.Forms.PictureBox();
            this.Info = new System.Windows.Forms.PictureBox();
            this.BFME1Pb = new System.Windows.Forms.PictureBox();
            this.ROTWKPb = new System.Windows.Forms.PictureBox();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.BFME2Pb = new System.Windows.Forms.PictureBox();
            this.SelectBFME1 = new System.Windows.Forms.PictureBox();
            this.SelectBFME2 = new System.Windows.Forms.PictureBox();
            this.SelectROTWK = new System.Windows.Forms.PictureBox();
            this.EALogo = new System.Windows.Forms.PictureBox();
            this.T3A = new System.Windows.Forms.PictureBox();
            this.BFMETeam = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BFME1Pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROTWKPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BFME2Pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectBFME1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectBFME2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectROTWK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EALogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T3A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BFMETeam)).BeginInit();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.Play.BackColor = System.Drawing.Color.Transparent;
            this.Play.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.Play;
            this.Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Play.FlatAppearance.BorderSize = 0;
            this.Play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Play.ForeColor = System.Drawing.Color.Transparent;
            this.Play.Location = new System.Drawing.Point(788, 535);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(144, 83);
            this.Play.TabIndex = 0;
            this.Play.UseVisualStyleBackColor = false;
            this.Play.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Play_MouseDown);
            this.Play.MouseEnter += new System.EventHandler(this.Play_MouseEnter);
            this.Play.MouseLeave += new System.EventHandler(this.Play_MouseLeave);
            this.Play.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Play_MouseUp);
            // 
            // MainLogo
            // 
            this.MainLogo.BackColor = System.Drawing.Color.Transparent;
            this.MainLogo.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.main_bfme;
            this.MainLogo.Location = new System.Drawing.Point(348, -7);
            this.MainLogo.Name = "MainLogo";
            this.MainLogo.Size = new System.Drawing.Size(264, 129);
            this.MainLogo.TabIndex = 4;
            this.MainLogo.TabStop = false;
            this.MainLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainLogo_MouseDown);
            this.MainLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainLogo_MouseMove);
            this.MainLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainLogo_MouseUp);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.quit;
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Close.Cursor = System.Windows.Forms.Cursors.Default;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Location = new System.Drawing.Point(884, 0);
            this.Close.Margin = new System.Windows.Forms.Padding(0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(69, 24);
            this.Close.TabIndex = 0;
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.MouseEnter += new System.EventHandler(this.Close_MouseEnter);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.min;
            this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Default;
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Location = new System.Drawing.Point(845, 0);
            this.Minimize.Margin = new System.Windows.Forms.Padding(0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(39, 24);
            this.Minimize.TabIndex = 5;
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            this.Minimize.MouseEnter += new System.EventHandler(this.Minimize_MouseEnter);
            this.Minimize.MouseLeave += new System.EventHandler(this.Minimize_MouseLeave);
            // 
            // SelectedBG
            // 
            this.SelectedBG.BackColor = System.Drawing.Color.Transparent;
            this.SelectedBG.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.bfme1Background;
            this.SelectedBG.ErrorImage = global::BFME_LAUNCHER.Properties.Resources.bfme1Background;
            this.SelectedBG.Location = new System.Drawing.Point(157, 172);
            this.SelectedBG.Margin = new System.Windows.Forms.Padding(0);
            this.SelectedBG.Name = "SelectedBG";
            this.SelectedBG.Size = new System.Drawing.Size(767, 327);
            this.SelectedBG.TabIndex = 9;
            this.SelectedBG.TabStop = false;
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.Color.Transparent;
            this.Info.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.info;
            this.Info.Location = new System.Drawing.Point(4, 0);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(37, 32);
            this.Info.TabIndex = 10;
            this.Info.TabStop = false;
            this.Info.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Info_MouseDown);
            this.Info.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Info_MouseMove);
            this.Info.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Info_MouseUp);
            // 
            // BFME1Pb
            // 
            this.BFME1Pb.BackColor = System.Drawing.Color.Transparent;
            this.BFME1Pb.ErrorImage = null;
            this.BFME1Pb.InitialImage = null;
            this.BFME1Pb.Location = new System.Drawing.Point(-2, 166);
            this.BFME1Pb.Margin = new System.Windows.Forms.Padding(0);
            this.BFME1Pb.Name = "BFME1Pb";
            this.BFME1Pb.Size = new System.Drawing.Size(155, 124);
            this.BFME1Pb.TabIndex = 11;
            this.BFME1Pb.TabStop = false;
            this.BFME1Pb.WaitOnLoad = true;
            // 
            // ROTWKPb
            // 
            this.ROTWKPb.BackColor = System.Drawing.Color.Transparent;
            this.ROTWKPb.Location = new System.Drawing.Point(8, 385);
            this.ROTWKPb.Name = "ROTWKPb";
            this.ROTWKPb.Size = new System.Drawing.Size(150, 128);
            this.ROTWKPb.TabIndex = 13;
            this.ROTWKPb.TabStop = false;
            this.ROTWKPb.Click += new System.EventHandler(this.ROTWKPb_Click);
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.Transparent;
            this.TitleBar.Location = new System.Drawing.Point(-3, -69);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(966, 161);
            this.TitleBar.TabIndex = 15;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // BFME2Pb
            // 
            this.BFME2Pb.BackColor = System.Drawing.Color.Transparent;
            this.BFME2Pb.Location = new System.Drawing.Point(3, 279);
            this.BFME2Pb.Name = "BFME2Pb";
            this.BFME2Pb.Size = new System.Drawing.Size(155, 128);
            this.BFME2Pb.TabIndex = 19;
            this.BFME2Pb.TabStop = false;
            // 
            // SelectBFME1
            // 
            this.SelectBFME1.BackColor = System.Drawing.Color.Transparent;
            this.SelectBFME1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectBFME1.ErrorImage = null;
            this.SelectBFME1.InitialImage = null;
            this.SelectBFME1.Location = new System.Drawing.Point(-4, 166);
            this.SelectBFME1.Name = "SelectBFME1";
            this.SelectBFME1.Size = new System.Drawing.Size(157, 117);
            this.SelectBFME1.TabIndex = 20;
            this.SelectBFME1.TabStop = false;
            this.SelectBFME1.Click += new System.EventHandler(this.SelectBFME1_Click);
            // 
            // SelectBFME2
            // 
            this.SelectBFME2.BackColor = System.Drawing.Color.Transparent;
            this.SelectBFME2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectBFME2.Location = new System.Drawing.Point(4, 289);
            this.SelectBFME2.Name = "SelectBFME2";
            this.SelectBFME2.Size = new System.Drawing.Size(148, 90);
            this.SelectBFME2.TabIndex = 21;
            this.SelectBFME2.TabStop = false;
            this.SelectBFME2.Click += new System.EventHandler(this.SelectBFME2_Click);
            // 
            // SelectROTWK
            // 
            this.SelectROTWK.BackColor = System.Drawing.Color.Transparent;
            this.SelectROTWK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectROTWK.Location = new System.Drawing.Point(8, 383);
            this.SelectROTWK.Name = "SelectROTWK";
            this.SelectROTWK.Size = new System.Drawing.Size(146, 128);
            this.SelectROTWK.TabIndex = 22;
            this.SelectROTWK.TabStop = false;
            this.SelectROTWK.Click += new System.EventHandler(this.SelectROTWK_Click);
            // 
            // EALogo
            // 
            this.EALogo.BackColor = System.Drawing.Color.Transparent;
            this.EALogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EALogo.Image = global::BFME_LAUNCHER.Properties.Resources.ea;
            this.EALogo.Location = new System.Drawing.Point(168, 547);
            this.EALogo.Name = "EALogo";
            this.EALogo.Size = new System.Drawing.Size(70, 69);
            this.EALogo.TabIndex = 24;
            this.EALogo.TabStop = false;
            this.EALogo.Click += new System.EventHandler(this.EALogo_Click);
            this.EALogo.MouseEnter += new System.EventHandler(this.EALogo_MouseEnter);
            this.EALogo.MouseLeave += new System.EventHandler(this.EALogo_MouseLeave);
            // 
            // T3A
            // 
            this.T3A.BackColor = System.Drawing.Color.Transparent;
            this.T3A.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.t3a;
            this.T3A.Cursor = System.Windows.Forms.Cursors.Hand;
            this.T3A.Location = new System.Drawing.Point(12, 555);
            this.T3A.Name = "T3A";
            this.T3A.Size = new System.Drawing.Size(60, 47);
            this.T3A.TabIndex = 25;
            this.T3A.TabStop = false;
            this.T3A.Click += new System.EventHandler(this.T3A_Click);
            this.T3A.MouseEnter += new System.EventHandler(this.T3A_MouseEnter);
            this.T3A.MouseLeave += new System.EventHandler(this.T3A_MouseLeave);
            // 
            // BFMETeam
            // 
            this.BFMETeam.BackColor = System.Drawing.Color.Transparent;
            this.BFMETeam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BFMETeam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BFMETeam.Image = global::BFME_LAUNCHER.Properties.Resources.bfmeteam;
            this.BFMETeam.Location = new System.Drawing.Point(72, 533);
            this.BFMETeam.Name = "BFMETeam";
            this.BFMETeam.Size = new System.Drawing.Size(93, 93);
            this.BFMETeam.TabIndex = 26;
            this.BFMETeam.TabStop = false;
            this.BFMETeam.Click += new System.EventHandler(this.BFMETeam_Click);
            this.BFMETeam.MouseEnter += new System.EventHandler(this.BFMETeam_MouseEnter);
            this.BFMETeam.MouseLeave += new System.EventHandler(this.BFMETeam_MouseLeave);
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.mainBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(960, 660);
            this.Controls.Add(this.T3A);
            this.Controls.Add(this.SelectROTWK);
            this.Controls.Add(this.SelectBFME2);
            this.Controls.Add(this.BFME2Pb);
            this.Controls.Add(this.ROTWKPb);
            this.Controls.Add(this.BFME1Pb);
            this.Controls.Add(this.SelectBFME1);
            this.Controls.Add(this.BFMETeam);
            this.Controls.Add(this.EALogo);
            this.Controls.Add(this.MainLogo);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.SelectedBG);
            this.Controls.Add(this.Play);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Launcher";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.Launcher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BFME1Pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROTWKPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BFME2Pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectBFME1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectBFME2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectROTWK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EALogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T3A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BFMETeam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.PictureBox MainLogo;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.PictureBox SelectedBG;
        private System.Windows.Forms.PictureBox Info;
        private System.Windows.Forms.PictureBox BFME1Pb;
        private System.Windows.Forms.PictureBox ROTWKPb;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.PictureBox BFME2Pb;
        private System.Windows.Forms.PictureBox SelectBFME1;
        private System.Windows.Forms.PictureBox SelectBFME2;
        private System.Windows.Forms.PictureBox SelectROTWK;
        private System.Windows.Forms.PictureBox EALogo;
        private System.Windows.Forms.PictureBox T3A;
        private System.Windows.Forms.PictureBox BFMETeam;
    }
}

