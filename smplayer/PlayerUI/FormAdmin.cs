using PlayerUI;
using QLBanHang.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SMPlayer
{
    public partial class FormAdmin : System.Windows.Forms.Form
    {
        DataProcesser dtBase = new DataProcesser();
        public FormLogin formLogin;
        public FormUser formUser;
        private System.Windows.Forms.Form activeForm = null;
        public FormAdmin(FormLogin f)
        {
            formLogin = f;
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            openChildForm(new FormShowUser(this));
        }

        private void btnMusic_Click(object sender, EventArgs e)
        {

        }

        private void btnVideo_Click(object sender, EventArgs e)
        {

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            dtBase.CapNhatDuLieu("update tblUser set isOnline=0 where tblUser.UserName=N'admin'");
            formLogin.Show();
            this.Hide();
        }

        
        private void openChildForm(System.Windows.Forms.Form childForm)
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

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtBase.CapNhatDuLieu("update tblUser set isOnline=0 where tblUser.UserName=N'admin'");
            Application.Exit();
        }

        private void logo_Click(object sender, EventArgs e)
        {
            if(activeForm != null) activeForm.Close();
            
        }
    }
}
