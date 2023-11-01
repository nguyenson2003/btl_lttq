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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnFullScreenState = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPauseState = new System.Windows.Forms.Button();
            this.btnNomalScreenState = new System.Windows.Forms.Button();
            this.btnPlayState = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTrack = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pbTrackVideo = new System.Windows.Forms.ProgressBar();
            this.lbVolume = new System.Windows.Forms.Label();
            this.pbVolume = new System.Windows.Forms.ProgressBar();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSpeaker = new System.Windows.Forms.Button();
            this.tbKeyPress = new System.Windows.Forms.TextBox();
            this.btnUnmuteState = new System.Windows.Forms.Button();
            this.btnMuteState = new System.Windows.Forms.Button();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(652, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 597);
            this.panel1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(340, 597);
            this.listBox1.TabIndex = 0;
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
            this.btnFullScreenState.Location = new System.Drawing.Point(993, 594);
            this.btnFullScreenState.Name = "btnFullScreenState";
            this.btnFullScreenState.Size = new System.Drawing.Size(26, 26);
            this.btnFullScreenState.TabIndex = 8;
            this.btnFullScreenState.UseVisualStyleBackColor = false;
            this.btnFullScreenState.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
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
            this.btnNomalScreenState.Location = new System.Drawing.Point(961, 594);
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
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.lbTrack);
            this.panel2.Controls.Add(this.btnPlay);
            this.panel2.Controls.Add(this.pbTrackVideo);
            this.panel2.Controls.Add(this.lbVolume);
            this.panel2.Controls.Add(this.pbVolume);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.btnSpeaker);
            this.panel2.Controls.Add(this.tbKeyPress);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 502);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(652, 95);
            this.panel2.TabIndex = 12;
            // 
            // lbTrack
            // 
            this.lbTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTrack.AutoSize = true;
            this.lbTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrack.Location = new System.Drawing.Point(521, 46);
            this.lbTrack.Name = "lbTrack";
            this.lbTrack.Size = new System.Drawing.Size(118, 25);
            this.lbTrack.TabIndex = 6;
            this.lbTrack.Text = "18:48/18:45";
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlay.BackColor = System.Drawing.Color.Black;
            this.btnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.BackgroundImage")));
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(27, 34);
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
            this.lbVolume.Location = new System.Drawing.Point(308, 46);
            this.lbVolume.Name = "lbVolume";
            this.lbVolume.Size = new System.Drawing.Size(55, 24);
            this.lbVolume.TabIndex = 5;
            this.lbVolume.Text = "100%";
            // 
            // pbVolume
            // 
            this.pbVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbVolume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbVolume.Location = new System.Drawing.Point(202, 54);
            this.pbVolume.Name = "pbVolume";
            this.pbVolume.Size = new System.Drawing.Size(100, 10);
            this.pbVolume.TabIndex = 4;
            this.pbVolume.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbVolume_MouseClick);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(92, 46);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(26, 26);
            this.btnNext.TabIndex = 3;
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnSpeaker
            // 
            this.btnSpeaker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSpeaker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpeaker.FlatAppearance.BorderSize = 0;
            this.btnSpeaker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpeaker.Image = ((System.Drawing.Image)(resources.GetObject("btnSpeaker.Image")));
            this.btnSpeaker.Location = new System.Drawing.Point(156, 42);
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
            this.btnUnmuteState.Location = new System.Drawing.Point(125, 461);
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
            this.btnMuteState.Location = new System.Drawing.Point(166, 461);
            this.btnMuteState.Name = "btnMuteState";
            this.btnMuteState.Size = new System.Drawing.Size(35, 35);
            this.btnMuteState.TabIndex = 3;
            this.btnMuteState.UseVisualStyleBackColor = true;
            this.btnMuteState.Visible = false;
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(652, 597);
            this.player.TabIndex = 7;
            this.player.Visible = false;
            this.player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.player_PlayStateChange);
            this.player.KeyDownEvent += new AxWMPLib._WMPOCXEvents_KeyDownEventHandler(this.player_KeyDownEvent);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(216, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // FormShowMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(992, 597);
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
            this.Text = "FormShowMusic";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormShowVideo_FormClosed);
            this.Load += new System.EventHandler(this.FormShowMusic_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
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
    }
}