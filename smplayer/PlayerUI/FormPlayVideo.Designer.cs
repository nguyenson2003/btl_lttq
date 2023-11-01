namespace PlayerUI
{
    partial class FormPlayVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlayVideo));
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.pbTrackVideo = new System.Windows.Forms.ProgressBar();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSpeaker = new System.Windows.Forms.Button();
            this.pbVolume = new System.Windows.Forms.ProgressBar();
            this.lbVolume = new System.Windows.Forms.Label();
            this.btnFullScreen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSpeed = new System.Windows.Forms.Label();
            this.lbTrack = new System.Windows.Forms.Label();
            this.btnUnmuteState = new System.Windows.Forms.Button();
            this.btnMuteState = new System.Windows.Forms.Button();
            this.tbKeyPress = new System.Windows.Forms.TextBox();
            this.btnPlayState = new System.Windows.Forms.Button();
            this.btnPauseState = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnFullScreenState = new System.Windows.Forms.Button();
            this.btnNomalScreenState = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(10, 0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(857, 501);
            this.player.TabIndex = 1;
            this.player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.player_PlayStateChange);
            this.player.ClickEvent += new AxWMPLib._WMPOCXEvents_ClickEventHandler(this.player_ClickEvent);
            this.player.KeyDownEvent += new AxWMPLib._WMPOCXEvents_KeyDownEventHandler(this.player_KeyDownEvent);
            // 
            // pbTrackVideo
            // 
            this.pbTrackVideo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbTrackVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbTrackVideo.Location = new System.Drawing.Point(13, 16);
            this.pbTrackVideo.Name = "pbTrackVideo";
            this.pbTrackVideo.Size = new System.Drawing.Size(831, 10);
            this.pbTrackVideo.TabIndex = 2;
            this.pbTrackVideo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbTrackVideo_MouseClick);
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
            // btnFullScreen
            // 
            this.btnFullScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFullScreen.BackColor = System.Drawing.Color.Black;
            this.btnFullScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFullScreen.BackgroundImage")));
            this.btnFullScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFullScreen.FlatAppearance.BorderSize = 0;
            this.btnFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullScreen.Image = ((System.Drawing.Image)(resources.GetObject("btnFullScreen.Image")));
            this.btnFullScreen.Location = new System.Drawing.Point(818, 46);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(26, 26);
            this.btnFullScreen.TabIndex = 3;
            this.btnFullScreen.UseVisualStyleBackColor = false;
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lbSpeed);
            this.panel1.Controls.Add(this.lbTrack);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.btnFullScreen);
            this.panel1.Controls.Add(this.pbTrackVideo);
            this.panel1.Controls.Add(this.lbVolume);
            this.panel1.Controls.Add(this.pbVolume);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnUnmuteState);
            this.panel1.Controls.Add(this.btnMuteState);
            this.panel1.Controls.Add(this.btnSpeaker);
            this.panel1.Controls.Add(this.tbKeyPress);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 501);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(857, 95);
            this.panel1.TabIndex = 6;
            // 
            // lbSpeed
            // 
            this.lbSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSpeed.AutoSize = true;
            this.lbSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSpeed.Location = new System.Drawing.Point(581, 47);
            this.lbSpeed.Name = "lbSpeed";
            this.lbSpeed.Size = new System.Drawing.Size(53, 25);
            this.lbSpeed.TabIndex = 6;
            this.lbSpeed.Text = "1.0X";
            this.lbSpeed.Click += new System.EventHandler(this.lbSpeed_Click);
            // 
            // lbTrack
            // 
            this.lbTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTrack.AutoSize = true;
            this.lbTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrack.Location = new System.Drawing.Point(671, 47);
            this.lbTrack.Name = "lbTrack";
            this.lbTrack.Size = new System.Drawing.Size(118, 25);
            this.lbTrack.TabIndex = 6;
            this.lbTrack.Text = "18:48/18:45";
            // 
            // btnUnmuteState
            // 
            this.btnUnmuteState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUnmuteState.Enabled = false;
            this.btnUnmuteState.FlatAppearance.BorderSize = 0;
            this.btnUnmuteState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnmuteState.Image = ((System.Drawing.Image)(resources.GetObject("btnUnmuteState.Image")));
            this.btnUnmuteState.Location = new System.Drawing.Point(410, 49);
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
            this.btnMuteState.Location = new System.Drawing.Point(369, 47);
            this.btnMuteState.Name = "btnMuteState";
            this.btnMuteState.Size = new System.Drawing.Size(35, 35);
            this.btnMuteState.TabIndex = 3;
            this.btnMuteState.UseVisualStyleBackColor = true;
            this.btnMuteState.Visible = false;
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
            this.tbKeyPress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnKeyPress_KeyUp);
            // 
            // btnPlayState
            // 
            this.btnPlayState.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayState.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlayState.BackgroundImage")));
            this.btnPlayState.FlatAppearance.BorderSize = 0;
            this.btnPlayState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayState.Image = ((System.Drawing.Image)(resources.GetObject("btnPlayState.Image")));
            this.btnPlayState.Location = new System.Drawing.Point(12, 403);
            this.btnPlayState.Name = "btnPlayState";
            this.btnPlayState.Size = new System.Drawing.Size(50, 50);
            this.btnPlayState.TabIndex = 3;
            this.btnPlayState.UseVisualStyleBackColor = false;
            this.btnPlayState.Visible = false;
            // 
            // btnPauseState
            // 
            this.btnPauseState.BackColor = System.Drawing.Color.Transparent;
            this.btnPauseState.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPauseState.BackgroundImage")));
            this.btnPauseState.FlatAppearance.BorderSize = 0;
            this.btnPauseState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPauseState.Image = ((System.Drawing.Image)(resources.GetObject("btnPauseState.Image")));
            this.btnPauseState.Location = new System.Drawing.Point(68, 403);
            this.btnPauseState.Name = "btnPauseState";
            this.btnPauseState.Size = new System.Drawing.Size(50, 50);
            this.btnPauseState.TabIndex = 3;
            this.btnPauseState.UseVisualStyleBackColor = false;
            this.btnPauseState.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnFullScreenState
            // 
            this.btnFullScreenState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFullScreenState.BackColor = System.Drawing.Color.Transparent;
            this.btnFullScreenState.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFullScreenState.BackgroundImage")));
            this.btnFullScreenState.FlatAppearance.BorderSize = 0;
            this.btnFullScreenState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullScreenState.Image = ((System.Drawing.Image)(resources.GetObject("btnFullScreenState.Image")));
            this.btnFullScreenState.Location = new System.Drawing.Point(828, 469);
            this.btnFullScreenState.Name = "btnFullScreenState";
            this.btnFullScreenState.Size = new System.Drawing.Size(26, 26);
            this.btnFullScreenState.TabIndex = 3;
            this.btnFullScreenState.UseVisualStyleBackColor = false;
            this.btnFullScreenState.Visible = false;
            this.btnFullScreenState.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // btnNomalScreenState
            // 
            this.btnNomalScreenState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNomalScreenState.BackColor = System.Drawing.Color.Transparent;
            this.btnNomalScreenState.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNomalScreenState.BackgroundImage")));
            this.btnNomalScreenState.FlatAppearance.BorderSize = 0;
            this.btnNomalScreenState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNomalScreenState.Image = ((System.Drawing.Image)(resources.GetObject("btnNomalScreenState.Image")));
            this.btnNomalScreenState.Location = new System.Drawing.Point(796, 469);
            this.btnNomalScreenState.Name = "btnNomalScreenState";
            this.btnNomalScreenState.Size = new System.Drawing.Size(26, 26);
            this.btnNomalScreenState.TabIndex = 3;
            this.btnNomalScreenState.UseVisualStyleBackColor = false;
            this.btnNomalScreenState.Visible = false;
            this.btnNomalScreenState.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FormPlayVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(877, 596);
            this.Controls.Add(this.player);
            this.Controls.Add(this.btnPauseState);
            this.Controls.Add(this.btnNomalScreenState);
            this.Controls.Add(this.btnFullScreenState);
            this.Controls.Add(this.btnPlayState);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(793, 643);
            this.Name = "FormPlayVideo";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Text = "SMPlayer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPlayVideo_FormClosed);
            this.Load += new System.EventHandler(this.FormPlayVideo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.ProgressBar pbTrackVideo;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSpeaker;
        private System.Windows.Forms.ProgressBar pbVolume;
        private System.Windows.Forms.Label lbVolume;
        private System.Windows.Forms.Button btnFullScreen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPlayState;
        private System.Windows.Forms.Button btnPauseState;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbTrack;
        private System.Windows.Forms.Button btnFullScreenState;
        private System.Windows.Forms.Button btnNomalScreenState;
        private System.Windows.Forms.Label lbSpeed;
        private System.Windows.Forms.TextBox tbKeyPress;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnUnmuteState;
        private System.Windows.Forms.Button btnMuteState;
    }
}