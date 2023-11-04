using QLBanHang.Classes;
using SMPlayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class FormUser : Form
    {
        DataProcesser dtBase = new DataProcesser();
        public string UserName, Password;
        int isAdmin = 0;
        FormLogin formLogin;
        public FormPlayVideo formPlayVideo;
        public FormUser(string us,string pw,int isAdmin,FormLogin flg)
        {
            formLogin = flg;
            this.isAdmin = isAdmin;
            UserName = us;
            Password = pw;
            InitializeComponent();
            hideSubMenu();
        }
        private void hideSubMenu()
        {
            pnVideoSubMenu.Visible = false;
            pnSubRemove.Visible= false;
        }

        private void showSubMenu(Panel subMenu)
        {
            hideSubMenu();
            subMenu.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            dtBase.CapNhatDuLieu("update tblUser set isOnline=0 where tblUser.UserName=N'"+UserName+"'");

            if (isAdmin == 0)
                formLogin.Show();
            this.Hide();
        }
        public System.Windows.Forms.Form activeForm = null;

        private void FormUser_Load(object sender, EventArgs e)
        {
            DataTable dtUser = dtBase.DocBang("Select * from tblUser where UserName=N'"
                        + UserName + "'");
            try
            {
                lbHello.Text ="Hello "+ dtUser.Select()[0]["FullName"].ToString();
            }
            catch
            {
                MessageBox.Show("looix ow dday");
            }
        }

        private void FormUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtBase.CapNhatDuLieu("update tblUser set isOnline=0 where tblUser.UserName=N'"+UserName+"'");
            if (isAdmin == 0)
                Application.Exit();
            if (activeForm != null) activeForm.Close();
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            showSubMenu(pnVideoSubMenu);
            string sql = "select tblVideo.UserName,VideoId,FullName,VideoName,Path " +
                "from tblVideo join tblUser on tblVideo.UserName=tblUser.UserName";
            openChildForm(new FormShowVideo(this,sql));

        }

        private void btnLikedListVideo_Click(object sender, EventArgs e)
        {
            //open form liked list
            string sql = "select VideoName,Path,FullName,tblVideo.UserName,tblVideo.VideoId from " +
                "(select VideoId from tblLikeVideoDetail where UserName = N'"+UserName+"') t1 " +
                "join tblVideo on t1.VideoId = tblVideo.VideoId join tblUser on " +
                "tblVideo.UserName = tblUser.UserName";
            openChildForm(new FormShowVideo(this, sql));

        }

        private void btnOpenLocalVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd=new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Filter = "Mở mp4 thôi nhé ^^|*.mp4|Mở mp3 thôi nhé ^^|*.mp3";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                formPlayVideo =new FormPlayVideo(ofd.FileName);
                formPlayVideo.ShowDialog();
            }
        }

        private void btnMusic_Click(object sender, EventArgs e)
        {
            string sql = "select MusicName,Path,FullName,tblMusic.MusicId " +
                "from tblMusic join tblUser on tblMusic.UserName=tblUser.UserName";
            openChildForm(new FormShowMusic(sql,UserName));
        }

        private void logo_Click(object sender, EventArgs e)
        {
            if (activeForm != null) activeForm.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FormUpload(UserName));
        }

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            if (activeForm != null) activeForm.Close();
            new FormSetting(UserName).ShowDialog();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            openChildForm(new FormHelp());
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            showSubMenu(pnSubRemove);
        }

        private void btnRemoveVideo_Click(object sender, EventArgs e)
        {
            //open form remove video
            /*...*/
        }

        private void btnRemoveMusic_Click(object sender, EventArgs e)
        {
            //open form remove music
            /*...*/
        }

        public void openChildForm(System.Windows.Forms.Form childForm)
        {
            
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.Size = panelChildForm.Size;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
