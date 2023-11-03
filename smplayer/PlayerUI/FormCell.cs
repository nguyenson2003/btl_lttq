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
using WMPLib;

namespace PlayerUI
{
    public partial class FormCell : Form
    {
        /*WindowsMediaPlayer*/
        public string path;
        string videoid;
        DataProcesser dtBase = new DataProcesser();
        FormUser formUser;
        public FormCell()
        {
            InitializeComponent();
            player.uiMode = "None";
            player.URL = "";
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
        }
        public FormCell(FormUser fu,string vi,string path,string videoname,string fullname
            ,string likes)
        {
            this.formUser = fu;
            InitializeComponent();
            player.uiMode = "None";
            player.URL = "";
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;

            this.path = path;
            llbFullName.Text = fullname;
            llbVideoName.Text = videoname;
            btnLikes.Text = likes;
            videoid = vi;

            if (dtBase.DocBang("select * from tblLikeVideoDetail " +
                "where UserName=N'" + formUser.UserName + "' and VideoId=N'" + videoid + "'").Rows.Count != 0)
                btnLikes.Image = btnLikeState.Image;
            else
                btnLikes.Image = btnUnlikeState.Image;

        }
        public void fPlay()
        {
            if (player.URL == "")
            {
                player.URL = this.path;
                timer3.Start();
            }
                
            player.Ctlcontrols.play();
            
        }
        public void fPause()
        {
            player.Ctlcontrols.pause();
        }

        private void player_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            if (formUser.formPlayVideo != null)
            {
                formUser.formPlayVideo.Hide();
            }
                
            formUser.formPlayVideo= new FormPlayVideo(path);
            formUser.formPlayVideo.ShowDialog();
            player.Ctlcontrols.pause();
            // lock full screen
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.fullScreen)
            {
                player.Ctlcontrols.pause();
                player.fullScreen = false;
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
            timer2.Stop();
        }

        private void btnSpeaker_Click(object sender, EventArgs e)
        {
            if(player.settings.mute==true)
            {
                player.settings.mute = false;
                btnSpeaker.Image=btnUnmuteState.Image;
            }
            else
            {
                player.settings.mute = true;
                btnSpeaker.Image = btnMuteState.Image;
            }
        }

        private void btnLikes_Click(object sender, EventArgs e)
        {

            if (dtBase.DocBang("select * from tblLikeVideoDetail " +
                "where UserName=N'" + formUser.UserName + "' and VideoId=N'" + videoid + "'").Rows.Count == 0)
            {
                dtBase.CapNhatDuLieu("insert into tblLikeVideoDetail" +
                    " values(N'" + formUser.UserName + "',N'" + videoid + "')");
                btnLikes.Image=btnLikeState.Image;
            }
            else
            {
                dtBase.CapNhatDuLieu("delete tblLikeVideoDetail " +
                    "where UserName=N'"+ formUser.UserName + "' and VideoId=N'"+videoid+"'");
                btnLikes.Image = btnUnlikeState.Image;
            }
            
            btnLikes.Text = dtBase.DocBang("select * from tblLikeVideoDetail " +
                    "where tblLikeVideoDetail.VideoId=N'" + videoid + "'").Rows.Count.ToString();
        }

        private void llbVideoName_MouseEnter(object sender, EventArgs e)
        {
            fPlay();
        }

        private void FormCell_Load(object sender, EventArgs e)
        {
            //btnSpeaker_Click(null, null);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            player.Ctlcontrols.pause();
            btnSpeaker_Click(null, null);
        }

        private void llbVideoName_Click(object sender, EventArgs e)
        {
            player_ClickEvent(null, null);
        }

        private void llbVideoName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            player_ClickEvent(null, null);
        }

        private void llbVideoName_MouseLeave(object sender, EventArgs e)
        {
            fPause();
        }
    }
}
