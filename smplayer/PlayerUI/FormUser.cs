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
            panelPlaylistSubMenu.Visible = false;
            panelToolsSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {

            showSubMenu(pnVideoSubMenu);
        }

        #region MediaSubMenu
        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);
        }

        #region PlayListManagemetSubMenu
        private void button8_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubMenu);
        }
        #region ToolsSubMenu
        private void button13_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
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
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            showSubMenu(pnVideoSubMenu);
            string sql = "select tblVideo.UserName,VideoId,FullName,VideoName,Path " +
                "from tblVideo join tblUser on tblVideo.UserName=tblUser.UserName";
            openChildForm(new FormShowVideo(this,sql));

        }
        public Panel getPnChildForm()
        {
            return panelChildForm;
        }

        private void btnLikedListVideo_Click(object sender, EventArgs e)
        {
            //open form liked list
            string sql = "select tblVideo.UserName,tblVideo.VideoId,FullName,VideoName,Path " +
                "from tblLikeVideoDetail join tblUser on tblLikeVideoDetail.UserName = tblUser.UserName " +
                "join tblVideo on tblVideo.VideoId = tblLikeVideoDetail.VideoId " +
                "where tblUser.UserName = N'"+UserName+"'";
            openChildForm(new FormShowVideo(this, sql));

        }

        private void btnOpenLocalVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd=new OpenFileDialog();
            ofd.Multiselect = false;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                formPlayVideo =new FormPlayVideo(ofd.FileName, this);
            }
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
