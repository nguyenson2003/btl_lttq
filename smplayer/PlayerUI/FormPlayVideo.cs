using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PlayerUI
{
    public partial class FormPlayVideo : Form
    {
        string path;
        string[] paths;
        public FormPlayVideo()
        {
            /*OpenFileDialog ofd = new OpenFileDialog();

            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                paths = ofd.FileNames;
            }*/
            InitializeComponent();
            path = System.IO.Directory.GetCurrentDirectory().ToString() +
                "\\Videos\\Luis Fonsi - Despacito ft. Daddy Yankee.mp4";
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {

                pbTrackVideo.Maximum = (int)(player.Ctlcontrols.currentItem.duration * 100000);
                pbTrackVideo.Value = (int)(player.Ctlcontrols.currentPosition * 100000);
                lbTrack.Text = player.Ctlcontrols.currentPositionString + "/" +
                    player.Ctlcontrols.currentItem.durationString;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            /*player.settings.volume=trackBar1.Value;
            player.Ctlcontrols.currentPosition = 0;*/
        }

        private void FormPlayVideo_Load(object sender, EventArgs e)
        {
            player.uiMode = "None";
            player.URL = path;
            player.Ctlcontrols.play();
            btnPlay.Image = btnPlayState.Image;
            pbVolume.Value = player.settings.volume = 100;
            lbVolume.Text = "100%";
            player.fullScreen=player.enableContextMenu = false;
            tbKeyPress.TabIndex = 0;
            tbKeyPress.Select();  

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if(ofd.ShowDialog() == DialogResult.OK) { 
                files= ofd.SafeFileNames;
                paths = ofd.FileNames;
                for(int i=0;i<files.Length; i++)
                    trackList.Items.Add(files[i]);
            }*/

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
        }
    }
}
