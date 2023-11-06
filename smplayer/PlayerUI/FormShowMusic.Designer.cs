namespace PlayerUI
{
    partial class FormShowMusic
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShowMusic));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbMusicList = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAddYourList = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbLists = new System.Windows.Forms.ComboBox();
            this.tbMusicName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMusicId = new System.Windows.Forms.TextBox();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnFullScreenState = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPauseState = new System.Windows.Forms.Button();
            this.btnNomalScreenState = new System.Windows.Forms.Button();
            this.btnPlayState = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.lbTrack = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pbTrackVideo = new System.Windows.Forms.ProgressBar();
            this.lbVolume = new System.Windows.Forms.Label();
            this.pbVolume = new System.Windows.Forms.ProgressBar();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSpeaker = new System.Windows.Forms.Button();
            this.tbKeyPress = new System.Windows.Forms.TextBox();
            this.btnUnmuteState = new System.Windows.Forms.Button();
            this.btnMuteState = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnShuffleStateOn = new System.Windows.Forms.Button();
            this.btnShuffleStateOff = new System.Windows.Forms.Button();
            this.btnRefreshStateOff = new System.Windows.Forms.Button();
            this.btnRefreshStateOn = new System.Windows.Forms.Button();
            this.btnRefreshStateOn1 = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbMusicList);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(652, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 577);
            this.panel1.TabIndex = 0;
            // 
            // lbMusicList
            // 
            this.lbMusicList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.lbMusicList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbMusicList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMusicList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMusicList.ForeColor = System.Drawing.Color.White;
            this.lbMusicList.FormattingEnabled = true;
            this.lbMusicList.ItemHeight = 25;
            this.lbMusicList.Location = new System.Drawing.Point(0, 316);
            this.lbMusicList.Name = "lbMusicList";
            this.lbMusicList.Size = new System.Drawing.Size(340, 261);
            this.lbMusicList.TabIndex = 0;
            this.lbMusicList.SelectedIndexChanged += new System.EventHandler(this.lbMusicList_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.cbLists);
            this.panel3.Controls.Add(this.tbMusicName);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tbMusicId);
            this.panel3.Controls.Add(this.tbFullName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.panel3.Size = new System.Drawing.Size(340, 316);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAddYourList);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 253);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(340, 43);
            this.panel4.TabIndex = 9;
            // 
            // btnAddYourList
            // 
            this.btnAddYourList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddYourList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddYourList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddYourList.Location = new System.Drawing.Point(169, 0);
            this.btnAddYourList.Name = "btnAddYourList";
            this.btnAddYourList.Size = new System.Drawing.Size(171, 43);
            this.btnAddYourList.TabIndex = 7;
            this.btnAddYourList.Text = "Add to list";
            this.btnAddYourList.UseVisualStyleBackColor = true;
            this.btnAddYourList.Click += new System.EventHandler(this.btnAddYourList_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(0, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(169, 43);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete from list";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbLists
            // 
            this.cbLists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.cbLists.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLists.ForeColor = System.Drawing.Color.White;
            this.cbLists.FormattingEnabled = true;
            this.cbLists.Location = new System.Drawing.Point(0, 183);
            this.cbLists.Name = "cbLists";
            this.cbLists.Size = new System.Drawing.Size(340, 33);
            this.cbLists.TabIndex = 8;
            this.cbLists.SelectedIndexChanged += new System.EventHandler(this.cbLists_SelectedIndexChanged);
            // 
            // tbMusicName
            // 
            this.tbMusicName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.tbMusicName.Enabled = false;
            this.tbMusicName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMusicName.ForeColor = System.Drawing.Color.White;
            this.tbMusicName.Location = new System.Drawing.Point(112, 60);
            this.tbMusicName.Name = "tbMusicName";
            this.tbMusicName.Size = new System.Drawing.Size(214, 30);
            this.tbMusicName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên bài hát";
            // 
            // tbMusicId
            // 
            this.tbMusicId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.tbMusicId.Enabled = false;
            this.tbMusicId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMusicId.ForeColor = System.Drawing.Color.White;
            this.tbMusicId.Location = new System.Drawing.Point(112, 98);
            this.tbMusicId.Name = "tbMusicId";
            this.tbMusicId.Size = new System.Drawing.Size(214, 30);
            this.tbMusicId.TabIndex = 5;
            this.tbMusicId.Visible = false;
            // 
            // tbFullName
            // 
            this.tbFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.tbFullName.Enabled = false;
            this.tbFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFullName.ForeColor = System.Drawing.Color.White;
            this.tbFullName.Location = new System.Drawing.Point(112, 129);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(214, 30);
            this.tbFullName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tài khoản";
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnFullScreenState
            // 
            this.btnFullScreenState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFullScreenState.BackColor = System.Drawing.Color.Transparent;
            this.btnFullScreenState.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFullScreenState.BackgroundImage")));
            this.btnFullScreenState.FlatAppearance.BorderSize = 0;
            this.btnFullScreenState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullScreenState.Image = ((System.Drawing.Image)(resources.GetObject("btnFullScreenState.Image")));
            this.btnFullScreenState.Location = new System.Drawing.Point(993, 574);
            this.btnFullScreenState.Name = "btnFullScreenState";
            this.btnFullScreenState.Size = new System.Drawing.Size(26, 26);
            this.btnFullScreenState.TabIndex = 8;
            this.btnFullScreenState.UseVisualStyleBackColor = false;
            this.btnFullScreenState.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnPauseState
            // 
            this.btnPauseState.BackColor = System.Drawing.Color.Transparent;
            this.btnPauseState.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPauseState.BackgroundImage")));
            this.btnPauseState.FlatAppearance.BorderSize = 0;
            this.btnPauseState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPauseState.Image = ((System.Drawing.Image)(resources.GetObject("btnPauseState.Image")));
            this.btnPauseState.Location = new System.Drawing.Point(69, 446);
            this.btnPauseState.Name = "btnPauseState";
            this.btnPauseState.Size = new System.Drawing.Size(50, 50);
            this.btnPauseState.TabIndex = 9;
            this.btnPauseState.UseVisualStyleBackColor = false;
            this.btnPauseState.Visible = false;
            // 
            // btnNomalScreenState
            // 
            this.btnNomalScreenState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNomalScreenState.BackColor = System.Drawing.Color.Transparent;
            this.btnNomalScreenState.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNomalScreenState.BackgroundImage")));
            this.btnNomalScreenState.FlatAppearance.BorderSize = 0;
            this.btnNomalScreenState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNomalScreenState.Image = ((System.Drawing.Image)(resources.GetObject("btnNomalScreenState.Image")));
            this.btnNomalScreenState.Location = new System.Drawing.Point(961, 574);
            this.btnNomalScreenState.Name = "btnNomalScreenState";
            this.btnNomalScreenState.Size = new System.Drawing.Size(26, 26);
            this.btnNomalScreenState.TabIndex = 10;
            this.btnNomalScreenState.UseVisualStyleBackColor = false;
            this.btnNomalScreenState.Visible = false;
            // 
            // btnPlayState
            // 
            this.btnPlayState.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayState.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlayState.BackgroundImage")));
            this.btnPlayState.FlatAppearance.BorderSize = 0;
            this.btnPlayState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayState.Image = ((System.Drawing.Image)(resources.GetObject("btnPlayState.Image")));
            this.btnPlayState.Location = new System.Drawing.Point(13, 446);
            this.btnPlayState.Name = "btnPlayState";
            this.btnPlayState.Size = new System.Drawing.Size(50, 50);
            this.btnPlayState.TabIndex = 11;
            this.btnPlayState.UseVisualStyleBackColor = false;
            this.btnPlayState.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.btnShuffle);
            this.panel2.Controls.Add(this.lbTrack);
            this.panel2.Controls.Add(this.btnPlay);
            this.panel2.Controls.Add(this.pbTrackVideo);
            this.panel2.Controls.Add(this.lbVolume);
            this.panel2.Controls.Add(this.pbVolume);
            this.panel2.Controls.Add(this.btnPrevious);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.btnSpeaker);
            this.panel2.Controls.Add(this.tbKeyPress);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 482);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(652, 95);
            this.panel2.TabIndex = 12;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(438, 46);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(33, 26);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShuffle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShuffle.FlatAppearance.BorderSize = 0;
            this.btnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShuffle.Image = ((System.Drawing.Image)(resources.GetObject("btnShuffle.Image")));
            this.btnShuffle.Location = new System.Drawing.Point(395, 46);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(37, 26);
            this.btnShuffle.TabIndex = 3;
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // lbTrack
            // 
            this.lbTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTrack.AutoSize = true;
            this.lbTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrack.Location = new System.Drawing.Point(521, 46);
            this.lbTrack.Name = "lbTrack";
            this.lbTrack.Size = new System.Drawing.Size(86, 25);
            this.lbTrack.TabIndex = 6;
            this.lbTrack.Text = "--:--/--:--";
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.BackgroundImage")));
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(69, 34);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(50, 50);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pbTrackVideo
            // 
            this.pbTrackVideo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbTrackVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbTrackVideo.Location = new System.Drawing.Point(13, 16);
            this.pbTrackVideo.Name = "pbTrackVideo";
            this.pbTrackVideo.Size = new System.Drawing.Size(626, 10);
            this.pbTrackVideo.TabIndex = 2;
            this.pbTrackVideo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbTrackVideo_MouseClick);
            // 
            // lbVolume
            // 
            this.lbVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbVolume.AutoSize = true;
            this.lbVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVolume.ForeColor = System.Drawing.Color.White;
            this.lbVolume.Location = new System.Drawing.Point(332, 46);
            this.lbVolume.Name = "lbVolume";
            this.lbVolume.Size = new System.Drawing.Size(55, 24);
            this.lbVolume.TabIndex = 5;
            this.lbVolume.Text = "100%";
            // 
            // pbVolume
            // 
            this.pbVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbVolume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbVolume.Location = new System.Drawing.Point(226, 54);
            this.pbVolume.Name = "pbVolume";
            this.pbVolume.Size = new System.Drawing.Size(100, 10);
            this.pbVolume.TabIndex = 4;
            this.pbVolume.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbVolume_MouseClick);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.Location = new System.Drawing.Point(23, 51);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(26, 26);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(134, 51);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(26, 26);
            this.btnNext.TabIndex = 3;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSpeaker
            // 
            this.btnSpeaker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSpeaker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpeaker.FlatAppearance.BorderSize = 0;
            this.btnSpeaker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpeaker.Image = ((System.Drawing.Image)(resources.GetObject("btnSpeaker.Image")));
            this.btnSpeaker.Location = new System.Drawing.Point(180, 42);
            this.btnSpeaker.Name = "btnSpeaker";
            this.btnSpeaker.Size = new System.Drawing.Size(35, 35);
            this.btnSpeaker.TabIndex = 3;
            this.btnSpeaker.UseVisualStyleBackColor = true;
            this.btnSpeaker.Click += new System.EventHandler(this.btnSpeaker_Click);
            // 
            // tbKeyPress
            // 
            this.tbKeyPress.BackColor = System.Drawing.Color.Black;
            this.tbKeyPress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbKeyPress.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbKeyPress.Location = new System.Drawing.Point(427, 51);
            this.tbKeyPress.Name = "tbKeyPress";
            this.tbKeyPress.Size = new System.Drawing.Size(0, 15);
            this.tbKeyPress.TabIndex = 8;
            this.tbKeyPress.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnKeyPress_KeyUp);
            // 
            // btnUnmuteState
            // 
            this.btnUnmuteState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUnmuteState.Enabled = false;
            this.btnUnmuteState.FlatAppearance.BorderSize = 0;
            this.btnUnmuteState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnmuteState.Image = ((System.Drawing.Image)(resources.GetObject("btnUnmuteState.Image")));
            this.btnUnmuteState.Location = new System.Drawing.Point(125, 441);
            this.btnUnmuteState.Name = "btnUnmuteState";
            this.btnUnmuteState.Size = new System.Drawing.Size(35, 35);
            this.btnUnmuteState.TabIndex = 3;
            this.btnUnmuteState.UseVisualStyleBackColor = true;
            this.btnUnmuteState.Visible = false;
            // 
            // btnMuteState
            // 
            this.btnMuteState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMuteState.Enabled = false;
            this.btnMuteState.FlatAppearance.BorderSize = 0;
            this.btnMuteState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuteState.Image = ((System.Drawing.Image)(resources.GetObject("btnMuteState.Image")));
            this.btnMuteState.Location = new System.Drawing.Point(166, 441);
            this.btnMuteState.Name = "btnMuteState";
            this.btnMuteState.Size = new System.Drawing.Size(35, 35);
            this.btnMuteState.TabIndex = 3;
            this.btnMuteState.UseVisualStyleBackColor = true;
            this.btnMuteState.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(202, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnShuffleStateOn
            // 
            this.btnShuffleStateOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShuffleStateOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShuffleStateOn.FlatAppearance.BorderSize = 0;
            this.btnShuffleStateOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShuffleStateOn.Image = ((System.Drawing.Image)(resources.GetObject("btnShuffleStateOn.Image")));
            this.btnShuffleStateOn.Location = new System.Drawing.Point(393, 445);
            this.btnShuffleStateOn.Name = "btnShuffleStateOn";
            this.btnShuffleStateOn.Size = new System.Drawing.Size(26, 26);
            this.btnShuffleStateOn.TabIndex = 3;
            this.btnShuffleStateOn.UseVisualStyleBackColor = true;
            this.btnShuffleStateOn.Visible = false;
            // 
            // btnShuffleStateOff
            // 
            this.btnShuffleStateOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShuffleStateOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShuffleStateOff.FlatAppearance.BorderSize = 0;
            this.btnShuffleStateOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShuffleStateOff.Image = ((System.Drawing.Image)(resources.GetObject("btnShuffleStateOff.Image")));
            this.btnShuffleStateOff.Location = new System.Drawing.Point(361, 445);
            this.btnShuffleStateOff.Name = "btnShuffleStateOff";
            this.btnShuffleStateOff.Size = new System.Drawing.Size(26, 26);
            this.btnShuffleStateOff.TabIndex = 3;
            this.btnShuffleStateOff.UseVisualStyleBackColor = true;
            this.btnShuffleStateOff.Visible = false;
            // 
            // btnRefreshStateOff
            // 
            this.btnRefreshStateOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefreshStateOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshStateOff.FlatAppearance.BorderSize = 0;
            this.btnRefreshStateOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshStateOff.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshStateOff.Image")));
            this.btnRefreshStateOff.Location = new System.Drawing.Point(427, 445);
            this.btnRefreshStateOff.Name = "btnRefreshStateOff";
            this.btnRefreshStateOff.Size = new System.Drawing.Size(26, 26);
            this.btnRefreshStateOff.TabIndex = 3;
            this.btnRefreshStateOff.UseVisualStyleBackColor = true;
            this.btnRefreshStateOff.Visible = false;
            // 
            // btnRefreshStateOn
            // 
            this.btnRefreshStateOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefreshStateOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshStateOn.FlatAppearance.BorderSize = 0;
            this.btnRefreshStateOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshStateOn.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshStateOn.Image")));
            this.btnRefreshStateOn.Location = new System.Drawing.Point(459, 445);
            this.btnRefreshStateOn.Name = "btnRefreshStateOn";
            this.btnRefreshStateOn.Size = new System.Drawing.Size(26, 26);
            this.btnRefreshStateOn.TabIndex = 3;
            this.btnRefreshStateOn.UseVisualStyleBackColor = true;
            this.btnRefreshStateOn.Visible = false;
            // 
            // btnRefreshStateOn1
            // 
            this.btnRefreshStateOn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefreshStateOn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshStateOn1.FlatAppearance.BorderSize = 0;
            this.btnRefreshStateOn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshStateOn1.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshStateOn1.Image")));
            this.btnRefreshStateOn1.Location = new System.Drawing.Point(491, 445);
            this.btnRefreshStateOn1.Name = "btnRefreshStateOn1";
            this.btnRefreshStateOn1.Size = new System.Drawing.Size(26, 26);
            this.btnRefreshStateOn1.TabIndex = 3;
            this.btnRefreshStateOn1.UseVisualStyleBackColor = true;
            this.btnRefreshStateOn1.Visible = false;
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(652, 577);
            this.player.TabIndex = 7;
            this.player.Visible = false;
            this.player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.player_PlayStateChange);
            this.player.KeyDownEvent += new AxWMPLib._WMPOCXEvents_KeyDownEventHandler(this.player_KeyDownEvent);
            // 
            // FormShowMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(992, 597);
            this.Controls.Add(this.btnRefreshStateOn1);
            this.Controls.Add(this.btnRefreshStateOn);
            this.Controls.Add(this.btnRefreshStateOff);
            this.Controls.Add(this.btnShuffleStateOff);
            this.Controls.Add(this.btnShuffleStateOn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFullScreenState);
            this.Controls.Add(this.btnPauseState);
            this.Controls.Add(this.btnNomalScreenState);
            this.Controls.Add(this.btnPlayState);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.player);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUnmuteState);
            this.Controls.Add(this.btnMuteState);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FormShowMusic";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.Text = "FormShowMusic";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormShowVideo_FormClosed);
            this.Load += new System.EventHandler(this.FormShowMusic_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbMusicList;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnFullScreenState;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPauseState;
        private System.Windows.Forms.Button btnNomalScreenState;
        private System.Windows.Forms.Button btnPlayState;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTrack;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ProgressBar pbTrackVideo;
        private System.Windows.Forms.Label lbVolume;
        private System.Windows.Forms.ProgressBar pbVolume;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSpeaker;
        private System.Windows.Forms.TextBox tbKeyPress;
        private System.Windows.Forms.Button btnUnmuteState;
        private System.Windows.Forms.Button btnMuteState;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddYourList;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.TextBox tbMusicName;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnShuffleStateOn;
        private System.Windows.Forms.Button btnShuffleStateOff;
        private System.Windows.Forms.Button btnRefreshStateOff;
        private System.Windows.Forms.Button btnRefreshStateOn;
        private System.Windows.Forms.Button btnRefreshStateOn1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbMusicId;
        private System.Windows.Forms.ComboBox cbLists;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDelete;
    }
}