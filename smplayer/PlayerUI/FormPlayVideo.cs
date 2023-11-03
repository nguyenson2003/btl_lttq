﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PlayerUI
{
    public partial class FormPlayVideo : Form
    {
        string path;
        public FormPlayVideo(string p)
        {
            InitializeComponent();
            path = p;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                pbTrackVideo.Maximum = (int)(player.Ctlcontrols.currentItem.duration * 100000);
                pbTrackVideo.Value = Math.Min((int)(player.Ctlcontrols.currentPosition * 100000),pbTrackVideo.Maximum);
                lbTrack.Text = player.Ctlcontrols.currentPositionString + "/" +
                    player.Ctlcontrols.currentItem.durationString;
            }
        }

        private void FormPlayVideo_Load(object sender, EventArgs e)
        {
            player.uiMode = "None";
            player.URL = path;
            btnPlay.Image = btnPlayState.Image;
            pbVolume.Value = player.settings.volume = 100;
            lbVolume.Text = "100%";
            player.fullScreen=player.enableContextMenu = false;
            tbKeyPress.TabIndex = 0;
            Thread.Sleep(1000);
            tbKeyPress.Select();  
            
        }
        private void changePlayState()
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                player.Ctlcontrols.pause();
                btnPlay.Image = btnPauseState.Image;
            } else
            {
                player.Ctlcontrols.play();
                btnPlay.Image = btnPlayState.Image;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            changePlayState();
        }

        private void pbTrackVideo_MouseClick(object sender, MouseEventArgs e)
        {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * 
                    e.X / pbTrackVideo.Width;
        }

        private void pbVolume_MouseClick(object sender, MouseEventArgs e)
        {
            pbVolume.Value = player.settings.volume = e.X * 100 / pbVolume.Width;
            lbVolume.Text = pbVolume.Value.ToString() + "%";
        }
        private void changeWindowState()
        {
            if (this.WindowState == FormWindowState.Maximized&&this.FormBorderStyle==FormBorderStyle.None)
            {
                btnFullScreen.Image = btnFullScreenState.Image;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                btnFullScreen.Image = btnNomalScreenState.Image;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Normal;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            changeWindowState();

        }

        private void btnKeyPress_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                pbVolume.Value = player.settings.volume = Math.Min(player.settings.volume + 5, 100);
                lbVolume.Text = pbVolume.Value.ToString() + "%";
            } else if (e.KeyCode == Keys.Down)
            {
                pbVolume.Value = player.settings.volume = Math.Max(player.settings.volume - 5, 0);
                lbVolume.Text = pbVolume.Value.ToString() + "%";
            } else if (e.KeyCode == Keys.Left)
            {
                player.Ctlcontrols.currentPosition = Math.Max(player.Ctlcontrols.currentPosition - 5, 0);
            } else if (e.KeyCode == Keys.Right)
            {
                player.Ctlcontrols.currentPosition = Math.Min(player.Ctlcontrols.currentPosition +5
                    , player.currentMedia.duration) ;
            }else if (e.KeyCode == Keys.Z)
            {
                speedPlayer -= 0.25;
                if (speedPlayer < 0.25)
                    speedPlayer = 2;
                player.settings.rate = speedPlayer;
                lbSpeed.Text = speedPlayer.ToString() + "X";
            }else if (e.KeyCode == Keys.X)
            {
                speedPlayer += 0.25;
                if (speedPlayer > 2)
                    speedPlayer = 0.25;
                player.settings.rate = speedPlayer;
                lbSpeed.Text = speedPlayer.ToString() + "X";
            }
            e.Handled = true;
        }
        double speedPlayer = 1;
        private void lbSpeed_Click(object sender, EventArgs e)
        {
            speedPlayer += 0.25;
            if (speedPlayer > 2)
                speedPlayer = 0.25;
            player.settings.rate = speedPlayer;
            lbSpeed.Text = speedPlayer.ToString() + "X"; 
            
        }

        private void player_KeyDownEvent(object sender, AxWMPLib._WMPOCXEvents_KeyDownEvent e)
        {
            if (e.Equals(Keys.Up))
            {
                pbVolume.Value = player.settings.volume = Math.Min(player.settings.volume + 5, 100);
                lbVolume.Text = pbVolume.Value.ToString() + "%";
            }
            else if (e.Equals(Keys.Down))
            {
                pbVolume.Value = player.settings.volume = Math.Max(player.settings.volume - 5, 0);
                lbVolume.Text = pbVolume.Value.ToString() + "%";
            }
            else if (e.Equals(Keys.Left))
            {
                player.Ctlcontrols.currentPosition = Math.Max(player.Ctlcontrols.currentPosition - 5, 0);
            }
            else if (e.Equals(Keys.Right))
            {
                player.Ctlcontrols.currentPosition = Math.Min(player.Ctlcontrols.currentPosition + 5
                    , player.currentMedia.duration);
            }
        }

        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (player.playState != WMPLib.WMPPlayState.wmppsPlaying)
            {
                btnPlay.Image = btnPauseState.Image;
            }
            else
            {
                btnPlay.Image = btnPlayState.Image;
            }
        }

        private void player_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            changePlayState();
            tbKeyPress.Select();
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(player.fullScreen) {
                player.fullScreen=false;
                timer2.Stop();
            }
        }

        private void btnSpeaker_Click(object sender, EventArgs e)
        {
            if(player.settings.mute==true)
            {
                player.settings.mute=false;
                btnSpeaker.Image=btnUnmuteState.Image;
            }
            else
            {
                player.settings.mute = true;
                btnSpeaker.Image = btnMuteState.Image;
            }
        }

        private void FormPlayVideo_FormClosed(object sender, FormClosedEventArgs e)
        {
            player.Ctlcontrols.pause();
            player.URL = "";
        }
    }
}
