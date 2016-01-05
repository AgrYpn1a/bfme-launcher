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
            this.Install = new System.Windows.Forms.Button();
            this.checkBoxEmpty = new System.Windows.Forms.PictureBox();
            this.checkBoxChecked = new System.Windows.Forms.PictureBox();
            this.notesPictureBox = new System.Windows.Forms.PictureBox();
            this.refresh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.update = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.but_Pause = new System.Windows.Forms.Button();
            this.but_Stop = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Percentage = new System.Windows.Forms.Label();
            this.btnDwPlay = new System.Windows.Forms.Button();
            this.btnDwPause = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxEmpty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxChecked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.Play.Location = new System.Drawing.Point(789, 535);
            this.Play.Margin = new System.Windows.Forms.Padding(0);
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
            this.BFME1Pb.Size = new System.Drawing.Size(155, 126);
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
            this.SelectBFME1.MouseEnter += new System.EventHandler(this.SelectBFME1_MouseEnter);
            this.SelectBFME1.MouseLeave += new System.EventHandler(this.SelectBFME1_MouseLeave);
            // 
            // SelectBFME2
            // 
            this.SelectBFME2.BackColor = System.Drawing.Color.Transparent;
            this.SelectBFME2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectBFME2.Location = new System.Drawing.Point(4, 281);
            this.SelectBFME2.Name = "SelectBFME2";
            this.SelectBFME2.Size = new System.Drawing.Size(148, 90);
            this.SelectBFME2.TabIndex = 21;
            this.SelectBFME2.TabStop = false;
            this.SelectBFME2.Click += new System.EventHandler(this.SelectBFME2_Click);
            this.SelectBFME2.MouseEnter += new System.EventHandler(this.SelectBFME2_MouseEnter);
            this.SelectBFME2.MouseLeave += new System.EventHandler(this.SelectBFME2_MouseLeave);
            // 
            // SelectROTWK
            // 
            this.SelectROTWK.BackColor = System.Drawing.Color.Transparent;
            this.SelectROTWK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectROTWK.Location = new System.Drawing.Point(10, 387);
            this.SelectROTWK.Name = "SelectROTWK";
            this.SelectROTWK.Size = new System.Drawing.Size(146, 126);
            this.SelectROTWK.TabIndex = 22;
            this.SelectROTWK.TabStop = false;
            this.SelectROTWK.Click += new System.EventHandler(this.SelectROTWK_Click);
            this.SelectROTWK.MouseEnter += new System.EventHandler(this.SelectROTWK_MouseEnter);
            this.SelectROTWK.MouseLeave += new System.EventHandler(this.SelectROTWK_MouseLeave);
            // 
            // EALogo
            // 
            this.EALogo.BackColor = System.Drawing.Color.Transparent;
            this.EALogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EALogo.Image = global::BFME_LAUNCHER.Properties.Resources.ea;
            this.EALogo.Location = new System.Drawing.Point(164, 547);
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
            this.T3A.Location = new System.Drawing.Point(8, 555);
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
            this.BFMETeam.Location = new System.Drawing.Point(70, 533);
            this.BFMETeam.Name = "BFMETeam";
            this.BFMETeam.Size = new System.Drawing.Size(93, 93);
            this.BFMETeam.TabIndex = 26;
            this.BFMETeam.TabStop = false;
            this.BFMETeam.Click += new System.EventHandler(this.BFMETeam_Click);
            this.BFMETeam.MouseEnter += new System.EventHandler(this.BFMETeam_MouseEnter);
            this.BFMETeam.MouseLeave += new System.EventHandler(this.BFMETeam_MouseLeave);
            // 
            // Install
            // 
            this.Install.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.Install.BackColor = System.Drawing.Color.Transparent;
            this.Install.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Install.BackgroundImage")));
            this.Install.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Install.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Install.FlatAppearance.BorderSize = 0;
            this.Install.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Install.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Install.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Install.ForeColor = System.Drawing.Color.Transparent;
            this.Install.Location = new System.Drawing.Point(644, 569);
            this.Install.Margin = new System.Windows.Forms.Padding(0);
            this.Install.Name = "Install";
            this.Install.Size = new System.Drawing.Size(143, 49);
            this.Install.TabIndex = 0;
            this.Install.UseVisualStyleBackColor = false;
            this.Install.Click += new System.EventHandler(this.Install_Click);
            this.Install.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Install_MouseDown);
            this.Install.MouseEnter += new System.EventHandler(this.Install_MouseEnter);
            this.Install.MouseLeave += new System.EventHandler(this.Install_MouseLeave);
            this.Install.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Install_MouseUp);
            // 
            // checkBoxEmpty
            // 
            this.checkBoxEmpty.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEmpty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxEmpty.Image = global::BFME_LAUNCHER.Properties.Resources.checkBoxEmpty;
            this.checkBoxEmpty.Location = new System.Drawing.Point(912, 619);
            this.checkBoxEmpty.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxEmpty.Name = "checkBoxEmpty";
            this.checkBoxEmpty.Size = new System.Drawing.Size(27, 27);
            this.checkBoxEmpty.TabIndex = 27;
            this.checkBoxEmpty.TabStop = false;
            this.checkBoxEmpty.Click += new System.EventHandler(this.checkBoxEmpty_Click);
            // 
            // checkBoxChecked
            // 
            this.checkBoxChecked.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxChecked.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxChecked.Image = global::BFME_LAUNCHER.Properties.Resources.checkBoxChecked;
            this.checkBoxChecked.Location = new System.Drawing.Point(912, 619);
            this.checkBoxChecked.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxChecked.Name = "checkBoxChecked";
            this.checkBoxChecked.Size = new System.Drawing.Size(27, 27);
            this.checkBoxChecked.TabIndex = 28;
            this.checkBoxChecked.TabStop = false;
            this.checkBoxChecked.Click += new System.EventHandler(this.checkBoxChecked_Click);
            // 
            // notesPictureBox
            // 
            this.notesPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.notesPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.notesPictureBox.Image = global::BFME_LAUNCHER.Properties.Resources.notesWindow;
            this.notesPictureBox.Location = new System.Drawing.Point(668, 135);
            this.notesPictureBox.Name = "notesPictureBox";
            this.notesPictureBox.Size = new System.Drawing.Size(291, 379);
            this.notesPictureBox.TabIndex = 29;
            this.notesPictureBox.TabStop = false;
            // 
            // refresh
            // 
            this.refresh.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.refresh.BackColor = System.Drawing.Color.Transparent;
            this.refresh.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.refresh;
            this.refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh.FlatAppearance.BorderSize = 0;
            this.refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.ForeColor = System.Drawing.Color.Transparent;
            this.refresh.Location = new System.Drawing.Point(683, 168);
            this.refresh.Margin = new System.Windows.Forms.Padding(0);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(25, 22);
            this.refresh.TabIndex = 30;
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.refresh_MouseDown);
            this.refresh.MouseUp += new System.Windows.Forms.MouseEventHandler(this.refresh_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.version;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(12, 629);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 17);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // update
            // 
            this.update.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.update.BackColor = System.Drawing.Color.Transparent;
            this.update.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.update;
            this.update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.ForeColor = System.Drawing.Color.Transparent;
            this.update.Location = new System.Drawing.Point(705, 534);
            this.update.Margin = new System.Windows.Forms.Padding(0);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(79, 27);
            this.update.TabIndex = 32;
            this.update.TabStop = false;
            this.update.UseVisualStyleBackColor = false;
            this.update.MouseDown += new System.Windows.Forms.MouseEventHandler(this.update_MouseDown);
            this.update.MouseEnter += new System.EventHandler(this.update_MouseEnter);
            this.update.MouseLeave += new System.EventHandler(this.update_MouseLeave);
            this.update.MouseUp += new System.Windows.Forms.MouseEventHandler(this.update_MouseUp);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(250, 585);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(378, 18);
            this.progressBar1.TabIndex = 33;
            // 
            // but_Pause
            // 
            this.but_Pause.Location = new System.Drawing.Point(465, 523);
            this.but_Pause.Name = "but_Pause";
            this.but_Pause.Size = new System.Drawing.Size(75, 23);
            this.but_Pause.TabIndex = 35;
            this.but_Pause.Text = "Pause";
            this.but_Pause.UseVisualStyleBackColor = true;
            this.but_Pause.Click += new System.EventHandler(this.but_Pause_Click);
            // 
            // but_Stop
            // 
            this.but_Stop.Location = new System.Drawing.Point(559, 523);
            this.but_Stop.Name = "but_Stop";
            this.but_Stop.Size = new System.Drawing.Size(75, 23);
            this.but_Stop.TabIndex = 36;
            this.but_Stop.Text = "Stop";
            this.but_Stop.UseVisualStyleBackColor = true;
            this.but_Stop.Click += new System.EventHandler(this.but_Stop_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // Percentage
            // 
            this.Percentage.AutoSize = true;
            this.Percentage.BackColor = System.Drawing.Color.Transparent;
            this.Percentage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Percentage.Location = new System.Drawing.Point(247, 570);
            this.Percentage.Name = "Percentage";
            this.Percentage.Size = new System.Drawing.Size(64, 13);
            this.Percentage.TabIndex = 37;
            this.Percentage.Text = "Percentage";
            // 
            // btnDwPlay
            // 
            this.btnDwPlay.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.btnDwPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnDwPlay.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.dwPlay;
            this.btnDwPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDwPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDwPlay.FlatAppearance.BorderSize = 0;
            this.btnDwPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDwPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDwPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDwPlay.ForeColor = System.Drawing.Color.Transparent;
            this.btnDwPlay.Location = new System.Drawing.Point(240, 606);
            this.btnDwPlay.Margin = new System.Windows.Forms.Padding(0);
            this.btnDwPlay.Name = "btnDwPlay";
            this.btnDwPlay.Size = new System.Drawing.Size(32, 28);
            this.btnDwPlay.TabIndex = 38;
            this.btnDwPlay.TabStop = false;
            this.btnDwPlay.UseVisualStyleBackColor = false;
            this.btnDwPlay.Click += new System.EventHandler(this.btnDwPlay_Click);
            this.btnDwPlay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDwPlay_MouseDown);
            this.btnDwPlay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDwPlay_MouseUp);
            // 
            // btnDwPause
            // 
            this.btnDwPause.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.btnDwPause.BackColor = System.Drawing.Color.Transparent;
            this.btnDwPause.BackgroundImage = global::BFME_LAUNCHER.Properties.Resources.dwPause;
            this.btnDwPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDwPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDwPause.FlatAppearance.BorderSize = 0;
            this.btnDwPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDwPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDwPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDwPause.ForeColor = System.Drawing.Color.Transparent;
            this.btnDwPause.Location = new System.Drawing.Point(242, 606);
            this.btnDwPause.Margin = new System.Windows.Forms.Padding(0);
            this.btnDwPause.Name = "btnDwPause";
            this.btnDwPause.Size = new System.Drawing.Size(32, 28);
            this.btnDwPause.TabIndex = 39;
            this.btnDwPause.TabStop = false;
            this.btnDwPause.UseVisualStyleBackColor = false;
            this.btnDwPause.Click += new System.EventHandler(this.but_Pause_Click);
            this.btnDwPause.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDwPause_MouseDown);
            this.btnDwPause.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDwPause_MouseUp);
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
            this.Controls.Add(this.btnDwPause);
            this.Controls.Add(this.btnDwPlay);
            this.Controls.Add(this.Percentage);
            this.Controls.Add(this.but_Stop);
            this.Controls.Add(this.but_Pause);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.update);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.notesPictureBox);
            this.Controls.Add(this.checkBoxEmpty);
            this.Controls.Add(this.checkBoxChecked);
            this.Controls.Add(this.Install);
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
            this.Controls.Add(this.Play);
            this.Controls.Add(this.SelectedBG);
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
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxEmpty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxChecked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button Install;
        private System.Windows.Forms.PictureBox checkBoxEmpty;
        private System.Windows.Forms.PictureBox checkBoxChecked;
        private System.Windows.Forms.PictureBox notesPictureBox;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button but_Pause;
        private System.Windows.Forms.Button but_Stop;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label Percentage;
        private System.Windows.Forms.Button btnDwPlay;
        private System.Windows.Forms.Button btnDwPause;
    }
}

