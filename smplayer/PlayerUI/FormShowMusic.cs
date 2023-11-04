using QLBanHang.Classes;
using System;
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

namespace PlayerUI
{
    public partial class FormShowMusic : Form
    {
        DataProcesser dtBase = new DataProcesser();
        DataTable dtMusic;
        string Username,sql;
        Dictionary<int, int> map = new Dictionary<int, int>();
        public FormShowMusic(string sql, string username)
        {
            this.sql = sql;
            
            InitializeComponent();
            lbMusicList.Items.Clear();
            map = new Dictionary<int, int>();
            dtMusic = dtBase.DocBang(sql);
            for (int i = 0; i < dtMusic.Rows.Count; i++)
            {
                lbMusicList.Items.Add((i + 1).ToString() + ": " + dtMusic.Rows[i]["MusicName"].ToString()
                    + " (" + dtMusic.Rows[i]["FullName"].ToString() + ")");
                map[i] = i;
            }
            Username = username;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                pbTrackVideo.Maximum = (int)(player.Ctlcontrols.currentItem.duration * 100000);
                pbTrackVideo.Value = Math.Min((int)(player.Ctlcontrols.currentPosition * 100000), pbTrackVideo.Maximum);
                lbTrack.Text = player.Ctlcontrols.currentPositionString==""?"00:00": player.Ctlcontrols.currentPositionString + "/" +
                    player.Ctlcontrols.currentItem.durationString;
            }

        }
        DataTable dataTableLists;
        private void FormShowMusic_Load(object sender, EventArgs e)
        {
            player.uiMode = "None";
            pbVolume.Value = player.settings.volume = 100;
            lbVolume.Text = "100%";
            player.fullScreen = player.enableContextMenu = false;
            tbKeyPress.TabIndex = 0;

            cbLists.Items.Clear();
            dataTableLists = dtBase.DocBang("select * from tblMusicList " +
                "where UserName=N'" + Username + "'");
            cbLists.Items.Add("Tất cả");
            cbLists.SelectedIndex = 0;
            for (int i=0; i<dataTableLists.Rows.Count; i++)
            {
                cbLists.Items.Add(dataTableLists.Rows[i]["ListName"].ToString()+" ("+
                    dataTableLists.Rows[i]["ListId"].ToString() + ")");
            }
            
            Thread.Sleep(1000);
            tbKeyPress.Select();

        }
        private void changePlayState()
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                player.Ctlcontrols.pause();
                btnPlay.Image = btnPauseState.Image;
            }
            else
            {
                player.Ctlcontrols.play();
                btnPlay.Image = btnPlayState.Image;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (lbMusicList == null|| lbMusicList.Items.Count == 0)
                return;
            if (lbMusicList.SelectedIndex < 0|| lbMusicList.SelectedIndex>= lbMusicList.Items.Count)
                lbMusicList.SelectedIndex = 0;
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
            if (this.WindowState == FormWindowState.Maximized && this.FormBorderStyle == FormBorderStyle.None)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
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
            }
            else if (e.KeyCode == Keys.Down)
            {
                pbVolume.Value = player.settings.volume = Math.Max(player.settings.volume - 5, 0);
                lbVolume.Text = pbVolume.Value.ToString() + "%";
            }
            else if (e.KeyCode == Keys.Left)
            {
                player.Ctlcontrols.currentPosition = Math.Max(player.Ctlcontrols.currentPosition - 5, 0);
            }
            else if (e.KeyCode == Keys.Right)
            {
                player.Ctlcontrols.currentPosition = Math.Min(player.Ctlcontrols.currentPosition + 5
                    , player.currentMedia.duration);
            }
            
            e.Handled = true;
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
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                btnPlay.Image = btnPlayState.Image;
            }
            else if(player.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                
                Thread.Sleep(1000);
                btnPlay.Image = btnPauseState.Image;
                if (refreshState == 0 &&
                    lbMusicList.SelectedIndex < lbMusicList.Items.Count - 1)
                {
                    lbMusicList.SelectedIndex++;
                    lbMusicList_SelectedIndexChanged(null, null);
                }else if(refreshState == 1)
                {
                    lbMusicList.SelectedIndex= (lbMusicList.SelectedIndex+1)% lbMusicList.Items.Count;
                    lbMusicList_SelectedIndexChanged(null, null);
                }
                else if (refreshState == 2)
                {
                    lbMusicList_SelectedIndexChanged(null, null);
                }
                
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (player.fullScreen)
            {
                player.fullScreen = false;
                timer2.Stop();
            }
        }

        private void btnSpeaker_Click(object sender, EventArgs e)
        {
            if (player.settings.mute == true)
            {
                player.settings.mute = false;
                btnSpeaker.Image = btnUnmuteState.Image;
            }
            else
            {
                player.settings.mute = true;
                btnSpeaker.Image = btnMuteState.Image;
            }
        }

        private void FormShowVideo_FormClosed(object sender, FormClosedEventArgs e)
        {
            player.Ctlcontrols.pause();
            player.URL = "";
        }

        private void lbMusicList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbMusicList == null)
                return;
            int i=lbMusicList.SelectedIndex;
            player.URL = System.IO.Directory.GetCurrentDirectory().ToString()+ dtMusic.Rows[map[i]]["Path"].ToString();
            tbFullName.Text = dtMusic.Rows[map[i]]["FullName"].ToString();
            tbMusicName.Text= dtMusic.Rows[map[i]]["MusicName"].ToString();
            tbMusicId.Text= dtMusic.Rows[map[i]]["MusicId"].ToString();
            timer3.Start();
        }
        bool isShuffle = false;

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            if(isShuffle == false) { 
                btnShuffle.Image=btnShuffleStateOn.Image;
                var rand = new Random();
                lbMusicList.Items.Clear();
                map = new Dictionary<int, int>();
                int[]temp=new int[dtMusic.Rows.Count];
                for (int i = 0; i < temp.Length; i++)
                {
                    temp[i] = i;
                }
                for (int i = 0; i < temp.Length; i++)
                {
                    int k=rand.Next(temp.Length);
                    (temp[i], temp[k]) = (temp[k], temp[i]);
                }
                for(int i = 0;i < temp.Length; i++)
                {
                    lbMusicList.Items.Add((i + 1).ToString() + ": " + dtMusic.Rows[temp[i]]["MusicName"].ToString()
                        + " (" + dtMusic.Rows[temp[i]]["FullName"].ToString() + ")");
                    map[i] = temp[i];
                }
                lbMusicList.SelectedIndex = 0;
            }
            else
            {
                btnShuffle.Image = btnShuffleStateOff.Image;
                lbMusicList.Items.Clear();
                map = new Dictionary<int, int>();
                for (int i = 0; i < dtMusic.Rows.Count; i++)
                {
                    lbMusicList.Items.Add((i + 1).ToString() + ": " + dtMusic.Rows[i]["MusicName"].ToString()
                        + " (" + dtMusic.Rows[i]["FullName"].ToString() + ")");
                    map[i] = i;
                }
                lbMusicList.SelectedIndex = 0;
            }
            isShuffle ^= true;
        }
        int refreshState = 0;
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshState = (refreshState + 1) % 3;
            if(refreshState == 0)
            {
                btnRefresh.Image = btnRefreshStateOff.Image;
            }else if(refreshState == 1)
            {
                btnRefresh.Image=btnRefreshStateOn.Image;

            }else if (refreshState == 2) { 
                btnRefresh.Image= btnRefreshStateOn1.Image;
            }
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (player != null)
                player.Ctlcontrols.play();
            timer3.Stop();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (lbMusicList == null || lbMusicList.Items.Count == 0)
                return;
            if (lbMusicList.SelectedIndex == null)
            {
                lbMusicList.SelectedIndex = 0;
                lbMusicList_SelectedIndexChanged(null, null);
                return;
            }
            lbMusicList.SelectedIndex = (lbMusicList.SelectedIndex + 1) % lbMusicList.Items.Count;
            lbMusicList_SelectedIndexChanged(null, null);
           
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (lbMusicList == null || lbMusicList.Items.Count == 0)
                return;
            if (lbMusicList.SelectedIndex == null)
            {
                lbMusicList.SelectedIndex = 0;
                lbMusicList_SelectedIndexChanged(null, null);
                return;
            } 
            lbMusicList.SelectedIndex = (lbMusicList.SelectedIndex - 1+ lbMusicList.Items.Count) % lbMusicList.Items.Count;
            lbMusicList_SelectedIndexChanged(null, null);
            
        }

        private void btnAddYourList_Click(object sender, EventArgs e)
        {
            if (player != null)
            {
                if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    player.Ctlcontrols.pause();
                    btnPlay.Image = btnPauseState.Image;
                }
            }
            if (cbLists == null|| lbMusicList==null)
                return;
            if (lbMusicList.Items.Count == 0)
            {
                MessageBox.Show("chưa có bài hát nào trong csdl");
                return;
            }
            if (cbLists.Items.Count == 0)
            {
                new FormNewListMusic(Username).ShowDialog();
                this.Refresh();
            }
            if (lbMusicList.SelectedIndex < 0 || lbMusicList.SelectedIndex >= lbMusicList.Items.Count)
                lbMusicList.SelectedIndex = 0;
            new FormShowMusicList(Username, tbMusicName.Text,tbMusicId.Text).ShowDialog();
            FormShowMusic_Load(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (player != null)
            {
                if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    player.Ctlcontrols.pause();
                    btnPlay.Image = btnPauseState.Image;
                }
            }
            if (cbLists.SelectedIndex < 1)
            {
                MessageBox.Show("Hãy chọn 1 danh sách");
                return;
            }
            string MusicId = tbMusicId.Text;
            string ListId = dataTableLists.Rows[cbLists.SelectedIndex - 1]["ListId"].ToString();
            dtBase.CapNhatDuLieu("delete tblMusicListDetail where " +
                "ListId=N'" + ListId + "'and MusicId=N'" + MusicId + "'");
            cbLists_SelectedIndexChanged(null, null);
        }

        private void cbLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (player != null)
            {
                if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    player.Ctlcontrols.pause();
                    btnPlay.Image = btnPauseState.Image;
                }
            }
                
            lbMusicList.Items.Clear();
            map = new Dictionary<int, int>();
            /*MusicName,Path,FullName,tblMusic.MusicId*/
            if (cbLists.SelectedIndex == 0)
            {
                dtMusic = dtBase.DocBang(sql);
                for (int i = 0; i < dtMusic.Rows.Count; i++)
                {
                    lbMusicList.Items.Add((i + 1).ToString() + ": " + dtMusic.Rows[i]["MusicName"].ToString()
                        + " (" + dtMusic.Rows[i]["FullName"].ToString() + ")");
                    map[i] = i;
                }
                return;
            }
            string ListId = dataTableLists.Rows[cbLists.SelectedIndex-1]["ListId"].ToString();
            dtMusic = dtBase.DocBang(" select Path,MusicName,t2.MusicId,FullName from " +
                "(select Path,MusicName,t1.MusicId,UserName from (select MusicId,ListId " +
                "from tblMusicListDetail where ListId=N'"+ListId+"') t1 join tblMusic" +
                " on tblMusic.MusicId=t1.MusicId) t2 join tblUser " +
                "on tblUser.UserName=t2.UserName");
            for (int i = 0; i < dtMusic.Rows.Count; i++)
            {
                lbMusicList.Items.Add((i + 1).ToString() + ": " + dtMusic.Rows[i]["MusicName"].ToString()
                    + " (" + dtMusic.Rows[i]["FullName"].ToString() + ")");
                map[i] = i;
            }
        }
    }
}
