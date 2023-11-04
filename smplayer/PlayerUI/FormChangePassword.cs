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

namespace PlayerUI
{
    public partial class FormChangePassword : Form
    {
        string Username;
        DataProcesser dataProcesser=new DataProcesser();
        public FormChangePassword(string username)
        {
            InitializeComponent();
            Username = username;
        }

        private void btnHide_MouseDown(object sender, MouseEventArgs e)
        {

            tbOldPassword.PasswordChar = tbNewPassword.PasswordChar 
                = tbConfirmPassword.PasswordChar = '\0';
            btnHide.Image = btnShowState.Image;
        }

        private void btnHide_MouseUp(object sender, MouseEventArgs e)
        {
            tbOldPassword.PasswordChar = tbNewPassword.PasswordChar
                = tbConfirmPassword.PasswordChar = '*';
            btnHide.Image = btnHideState.Image;
        }

        private void btnCanCel_Click(object sender, EventArgs e)
        {
            if (!(tbConfirmPassword.Text != "" || tbNewPassword.Text != "" || tbOldPassword.Text != ""))
            { this.Hide();
                return; 
            }
            if(MessageBox.Show("Hủy bỏ thay đổi?","",MessageBoxButtons.YesNo)
                == System.Windows.Forms.DialogResult.Yes)
            {
                this.Hide();
                return;
            }
                    

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(tbOldPassword.Text!=dataProcesser.DocBang("select * from tblUser " +
                "where Username=N'" + Username + "'").Rows[0]["PassWord"].ToString())
            {
                MessageBox.Show("Mật khẩu cũ chưa chính xác");
                return;
            }
            if(tbNewPassword.Text!=tbConfirmPassword.Text) {
                MessageBox.Show("Xác nhận mật khẩu mới chưa chính xác");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn lưu? ", "", MessageBoxButtons.YesNo)
                == System.Windows.Forms.DialogResult.Yes)
            {
                dataProcesser.CapNhatDuLieu("update tblUser set PassWord=N'"+
                    tbNewPassword.Text+"' where UserName=N'"+Username+"'");
                MessageBox.Show("Cập nhập thành công");
                this.Hide();
            }
        }

        private void tbConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar =='\n')
            {   e.Handled = true; 
                btnConfirm_Click(null,null); 
            }
        }
    }
}
