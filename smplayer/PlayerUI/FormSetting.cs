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
    public partial class FormSetting : Form
    {
        DataProcesser dataProcesser=new DataProcesser();
        string Username;
        public FormSetting(string us)
        {
            Username= us;   
            InitializeComponent();
        }
        
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(dataProcesser.DocBang("select * from tblUser " +
                "where Username=N'" + Username + "'").Rows[0]["FullName"].ToString() != tbFullName.Text)
            {
                if (MessageBox.Show("Bạn có chắc muốn dùng tên này không?", "", MessageBoxButtons.YesNo) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    dataProcesser.CapNhatDuLieu("update tblUser set FullName=N'"+
                        tbFullName.Text+"' where UserName=N'"+Username+"'");
                    MessageBox.Show("Cập nhập thành công");
                    FormSetting_Load(null, null);
                }
                    
            }
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            tbUsername.Text = Username;
            tbFullName.Text = dataProcesser.DocBang("select * from tblUser " +
                "where Username=N'" + Username + "'").Rows[0]["FullName"].ToString();
        }

        private void llbChangePassword_Click(object sender, EventArgs e)
        {
            new FormChangePassword(Username).ShowDialog();
        }

        private void tbFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\n')
            {
                e.Handled = true;
                btnConfirm_Click(sender, e);
            }
        }
    }
}
