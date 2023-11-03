﻿namespace PlayerUI
{
    partial class FormUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            this.lbHello = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVideo = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnOpenLocalVideo = new System.Windows.Forms.Button();
            this.btnLikedListVideo = new System.Windows.Forms.Button();
            this.btnMusic = new System.Windows.Forms.Button();
            this.pnVideoSubMenu = new System.Windows.Forms.Panel();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnEqualizer = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLogo.SuspendLayout();
            this.pnVideoSubMenu.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHello
            // 
            this.lbHello.AutoSize = true;
            this.lbHello.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbHello.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbHello.Location = new System.Drawing.Point(713, 0);
            this.lbHello.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHello.Name = "lbHello";
            this.lbHello.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.lbHello.Size = new System.Drawing.Size(164, 45);
            this.lbHello.TabIndex = 0;
            this.lbHello.Text = "Hello Minh";
            this.lbHello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(258, 229);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(412, 150);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox9.TabIndex = 2;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.logo_Click);
            // 
            // btnVideo
            // 
            this.btnVideo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVideo.FlatAppearance.BorderSize = 0;
            this.btnVideo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.btnVideo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(38)))), ((int)(((byte)(85)))));
            this.btnVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideo.ForeColor = System.Drawing.Color.White;
            this.btnVideo.Image = ((System.Drawing.Image)(resources.GetObject("btnVideo.Image")));
            this.btnVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVideo.Location = new System.Drawing.Point(0, 180);
            this.btnVideo.Margin = new System.Windows.Forms.Padding(0);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnVideo.Size = new System.Drawing.Size(322, 64);
            this.btnVideo.TabIndex = 1;
            this.btnVideo.Text = "Video";
            this.btnVideo.UseVisualStyleBackColor = true;
            this.btnVideo.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(6);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(322, 180);
            this.panelLogo.TabIndex = 0;
            // 
            // btnOpenLocalVideo
            // 
            this.btnOpenLocalVideo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenLocalVideo.FlatAppearance.BorderSize = 0;
            this.btnOpenLocalVideo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.btnOpenLocalVideo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(38)))), ((int)(((byte)(85)))));
            this.btnOpenLocalVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenLocalVideo.ForeColor = System.Drawing.Color.White;
            this.btnOpenLocalVideo.Location = new System.Drawing.Point(0, 45);
            this.btnOpenLocalVideo.Margin = new System.Windows.Forms.Padding(6);
            this.btnOpenLocalVideo.Name = "btnOpenLocalVideo";
            this.btnOpenLocalVideo.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnOpenLocalVideo.Size = new System.Drawing.Size(322, 45);
            this.btnOpenLocalVideo.TabIndex = 3;
            this.btnOpenLocalVideo.Text = "Open local media";
            this.btnOpenLocalVideo.UseVisualStyleBackColor = true;
            this.btnOpenLocalVideo.Click += new System.EventHandler(this.btnOpenLocalVideo_Click);
            // 
            // btnLikedListVideo
            // 
            this.btnLikedListVideo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLikedListVideo.FlatAppearance.BorderSize = 0;
            this.btnLikedListVideo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.btnLikedListVideo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(38)))), ((int)(((byte)(85)))));
            this.btnLikedListVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLikedListVideo.ForeColor = System.Drawing.Color.White;
            this.btnLikedListVideo.Location = new System.Drawing.Point(0, 0);
            this.btnLikedListVideo.Margin = new System.Windows.Forms.Padding(6);
            this.btnLikedListVideo.Name = "btnLikedListVideo";
            this.btnLikedListVideo.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnLikedListVideo.Size = new System.Drawing.Size(322, 45);
            this.btnLikedListVideo.TabIndex = 0;
            this.btnLikedListVideo.Text = "Liked list";
            this.btnLikedListVideo.UseVisualStyleBackColor = true;
            this.btnLikedListVideo.Click += new System.EventHandler(this.btnLikedListVideo_Click);
            // 
            // btnMusic
            // 
            this.btnMusic.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMusic.FlatAppearance.BorderSize = 0;
            this.btnMusic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.btnMusic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(38)))), ((int)(((byte)(85)))));
            this.btnMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusic.ForeColor = System.Drawing.Color.White;
            this.btnMusic.Image = ((System.Drawing.Image)(resources.GetObject("btnMusic.Image")));
            this.btnMusic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusic.Location = new System.Drawing.Point(0, 339);
            this.btnMusic.Margin = new System.Windows.Forms.Padding(6);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnMusic.Size = new System.Drawing.Size(322, 64);
            this.btnMusic.TabIndex = 3;
            this.btnMusic.Text = "Music";
            this.btnMusic.UseVisualStyleBackColor = true;
            this.btnMusic.Click += new System.EventHandler(this.btnMusic_Click);
            // 
            // pnVideoSubMenu
            // 
            this.pnVideoSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.pnVideoSubMenu.Controls.Add(this.btnOpenLocalVideo);
            this.pnVideoSubMenu.Controls.Add(this.btnLikedListVideo);
            this.pnVideoSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnVideoSubMenu.Location = new System.Drawing.Point(0, 244);
            this.pnVideoSubMenu.Margin = new System.Windows.Forms.Padding(6);
            this.pnVideoSubMenu.Name = "pnVideoSubMenu";
            this.pnVideoSubMenu.Size = new System.Drawing.Size(322, 95);
            this.pnVideoSubMenu.TabIndex = 2;
            // 
            // btnUpload
            // 
            this.btnUpload.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.btnUpload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(38)))), ((int)(((byte)(85)))));
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Image = ((System.Drawing.Image)(resources.GetObject("btnUpload.Image")));
            this.btnUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpload.Location = new System.Drawing.Point(0, 403);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnUpload.Size = new System.Drawing.Size(322, 64);
            this.btnUpload.TabIndex = 6;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(38)))), ((int)(((byte)(85)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(0, 531);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(6);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(322, 64);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "  Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnEqualizer
            // 
            this.btnEqualizer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEqualizer.FlatAppearance.BorderSize = 0;
            this.btnEqualizer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.btnEqualizer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(38)))), ((int)(((byte)(85)))));
            this.btnEqualizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqualizer.ForeColor = System.Drawing.Color.White;
            this.btnEqualizer.Image = ((System.Drawing.Image)(resources.GetObject("btnEqualizer.Image")));
            this.btnEqualizer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEqualizer.Location = new System.Drawing.Point(0, 467);
            this.btnEqualizer.Margin = new System.Windows.Forms.Padding(6);
            this.btnEqualizer.Name = "btnEqualizer";
            this.btnEqualizer.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnEqualizer.Size = new System.Drawing.Size(322, 64);
            this.btnEqualizer.TabIndex = 5;
            this.btnEqualizer.Text = "Setting";
            this.btnEqualizer.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(48)))), ((int)(((byte)(13)))));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 643);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(322, 57);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "  Log out";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Controls.Add(this.pictureBox9);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelChildForm.Location = new System.Drawing.Point(322, 50);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(6);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(877, 650);
            this.panelChildForm.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lbHello);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(322, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 50);
            this.panel1.TabIndex = 6;
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.btnHelp);
            this.panelSideMenu.Controls.Add(this.btnEqualizer);
            this.panelSideMenu.Controls.Add(this.btnExit);
            this.panelSideMenu.Controls.Add(this.btnUpload);
            this.panelSideMenu.Controls.Add(this.btnMusic);
            this.panelSideMenu.Controls.Add(this.pnVideoSubMenu);
            this.panelSideMenu.Controls.Add(this.btnVideo);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(6);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(322, 700);
            this.panelSideMenu.TabIndex = 4;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 700);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMPlayer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUser_FormClosed);
            this.Load += new System.EventHandler(this.FormUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLogo.ResumeLayout(false);
            this.pnVideoSubMenu.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSideMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbHello;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVideo;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnOpenLocalVideo;
        private System.Windows.Forms.Button btnLikedListVideo;
        private System.Windows.Forms.Button btnMusic;
        private System.Windows.Forms.Panel pnVideoSubMenu;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnEqualizer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSideMenu;
    }
}