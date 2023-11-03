namespace PlayerUI
{
    partial class FormCell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCell));
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnSpeaker = new System.Windows.Forms.Button();
            this.btnMuteState = new System.Windows.Forms.Button();
            this.btnUnmuteState = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.llbVideoName = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.llbFullName = new System.Windows.Forms.LinkLabel();
            this.btnLikes = new System.Windows.Forms.Button();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.btnLikeState = new System.Windows.Forms.Button();
            this.btnUnlikeState = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(472, 241);
            this.player.TabIndex = 0;
            this.player.ClickEvent += new AxWMPLib._WMPOCXEvents_ClickEventHandler(this.player_ClickEvent);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 3000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnSpeaker
            // 
            this.btnSpeaker.BackColor = System.Drawing.Color.Black;
            this.btnSpeaker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpeaker.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSpeaker.FlatAppearance.BorderSize = 0;
            this.btnSpeaker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpeaker.ForeColor = System.Drawing.Color.White;
            this.btnSpeaker.Image = ((System.Drawing.Image)(resources.GetObject("btnSpeaker.Image")));
            this.btnSpeaker.Location = new System.Drawing.Point(368, 2);
            this.btnSpeaker.Name = "btnSpeaker";
            this.btnSpeaker.Size = new System.Drawing.Size(102, 47);
            this.btnSpeaker.TabIndex = 1;
            this.btnSpeaker.UseVisualStyleBackColor = false;
            this.btnSpeaker.Click += new System.EventHandler(this.btnSpeaker_Click);
            this.btnSpeaker.MouseEnter += new System.EventHandler(this.llbVideoName_MouseEnter);
            this.btnSpeaker.MouseLeave += new System.EventHandler(this.llbVideoName_MouseLeave);
            // 
            // btnMuteState
            // 
            this.btnMuteState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMuteState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuteState.ForeColor = System.Drawing.Color.White;
            this.btnMuteState.Image = ((System.Drawing.Image)(resources.GetObject("btnMuteState.Image")));
            this.btnMuteState.Location = new System.Drawing.Point(41, 0);
            this.btnMuteState.Name = "btnMuteState";
            this.btnMuteState.Size = new System.Drawing.Size(35, 35);
            this.btnMuteState.TabIndex = 1;
            this.btnMuteState.UseVisualStyleBackColor = true;
            this.btnMuteState.Visible = false;
            // 
            // btnUnmuteState
            // 
            this.btnUnmuteState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnmuteState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnmuteState.ForeColor = System.Drawing.Color.White;
            this.btnUnmuteState.Image = ((System.Drawing.Image)(resources.GetObject("btnUnmuteState.Image")));
            this.btnUnmuteState.Location = new System.Drawing.Point(0, 0);
            this.btnUnmuteState.Name = "btnUnmuteState";
            this.btnUnmuteState.Size = new System.Drawing.Size(35, 35);
            this.btnUnmuteState.TabIndex = 1;
            this.btnUnmuteState.UseVisualStyleBackColor = true;
            this.btnUnmuteState.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.llbVideoName);
            this.panel1.Controls.Add(this.btnSpeaker);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pbAvatar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 241);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(472, 75);
            this.panel1.TabIndex = 2;
            // 
            // llbVideoName
            // 
            this.llbVideoName.BackColor = System.Drawing.Color.Black;
            this.llbVideoName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llbVideoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbVideoName.ForeColor = System.Drawing.Color.White;
            this.llbVideoName.LinkColor = System.Drawing.Color.White;
            this.llbVideoName.Location = new System.Drawing.Point(65, 2);
            this.llbVideoName.Name = "llbVideoName";
            this.llbVideoName.Size = new System.Drawing.Size(303, 47);
            this.llbVideoName.TabIndex = 4;
            this.llbVideoName.TabStop = true;
            this.llbVideoName.Text = "linkLabel1";
            this.llbVideoName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbVideoName_LinkClicked);
            this.llbVideoName.MouseEnter += new System.EventHandler(this.llbVideoName_MouseEnter);
            this.llbVideoName.MouseLeave += new System.EventHandler(this.llbVideoName_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.llbFullName);
            this.panel2.Controls.Add(this.btnLikes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(65, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 24);
            this.panel2.TabIndex = 3;
            // 
            // llbFullName
            // 
            this.llbFullName.BackColor = System.Drawing.Color.Black;
            this.llbFullName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llbFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbFullName.LinkColor = System.Drawing.Color.White;
            this.llbFullName.Location = new System.Drawing.Point(0, 0);
            this.llbFullName.Name = "llbFullName";
            this.llbFullName.Size = new System.Drawing.Size(303, 24);
            this.llbFullName.TabIndex = 6;
            this.llbFullName.TabStop = true;
            this.llbFullName.Text = "linkLabel2";
            this.llbFullName.MouseEnter += new System.EventHandler(this.llbVideoName_MouseEnter);
            this.llbFullName.MouseLeave += new System.EventHandler(this.llbVideoName_MouseLeave);
            // 
            // btnLikes
            // 
            this.btnLikes.BackColor = System.Drawing.Color.Black;
            this.btnLikes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLikes.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLikes.FlatAppearance.BorderSize = 0;
            this.btnLikes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLikes.ForeColor = System.Drawing.Color.White;
            this.btnLikes.Image = ((System.Drawing.Image)(resources.GetObject("btnLikes.Image")));
            this.btnLikes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLikes.Location = new System.Drawing.Point(303, 0);
            this.btnLikes.Name = "btnLikes";
            this.btnLikes.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnLikes.Size = new System.Drawing.Size(102, 24);
            this.btnLikes.TabIndex = 5;
            this.btnLikes.Text = "1234";
            this.btnLikes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLikes.UseVisualStyleBackColor = false;
            this.btnLikes.Click += new System.EventHandler(this.btnLikes_Click);
            this.btnLikes.MouseEnter += new System.EventHandler(this.llbVideoName_MouseEnter);
            this.btnLikes.MouseLeave += new System.EventHandler(this.llbVideoName_MouseLeave);
            // 
            // pbAvatar
            // 
            this.pbAvatar.BackColor = System.Drawing.Color.Black;
            this.pbAvatar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pbAvatar.Image")));
            this.pbAvatar.Location = new System.Drawing.Point(2, 2);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(63, 71);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 2;
            this.pbAvatar.TabStop = false;
            this.pbAvatar.MouseEnter += new System.EventHandler(this.llbVideoName_MouseEnter);
            this.pbAvatar.MouseLeave += new System.EventHandler(this.llbVideoName_MouseLeave);
            // 
            // btnLikeState
            // 
            this.btnLikeState.BackColor = System.Drawing.Color.Black;
            this.btnLikeState.Image = ((System.Drawing.Image)(resources.GetObject("btnLikeState.Image")));
            this.btnLikeState.Location = new System.Drawing.Point(0, -1);
            this.btnLikeState.Name = "btnLikeState";
            this.btnLikeState.Size = new System.Drawing.Size(64, 36);
            this.btnLikeState.TabIndex = 3;
            this.btnLikeState.UseVisualStyleBackColor = false;
            this.btnLikeState.Visible = false;
            // 
            // btnUnlikeState
            // 
            this.btnUnlikeState.BackColor = System.Drawing.Color.Black;
            this.btnUnlikeState.Image = ((System.Drawing.Image)(resources.GetObject("btnUnlikeState.Image")));
            this.btnUnlikeState.Location = new System.Drawing.Point(63, 0);
            this.btnUnlikeState.Name = "btnUnlikeState";
            this.btnUnlikeState.Size = new System.Drawing.Size(64, 36);
            this.btnUnlikeState.TabIndex = 3;
            this.btnUnlikeState.UseVisualStyleBackColor = false;
            this.btnUnlikeState.Visible = false;
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // FormCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(472, 316);
            this.Controls.Add(this.btnUnlikeState);
            this.Controls.Add(this.btnLikeState);
            this.Controls.Add(this.player);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUnmuteState);
            this.Controls.Add(this.btnMuteState);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCell";
            this.Text = "FormWMP";
            this.Load += new System.EventHandler(this.FormCell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnSpeaker;
        private System.Windows.Forms.Button btnMuteState;
        private System.Windows.Forms.Button btnUnmuteState;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLikes;
        private System.Windows.Forms.LinkLabel llbVideoName;
        private System.Windows.Forms.LinkLabel llbFullName;
        private System.Windows.Forms.Button btnLikeState;
        private System.Windows.Forms.Button btnUnlikeState;
        private System.Windows.Forms.Timer timer3;
    }
}