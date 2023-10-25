using QLBanHang.Classes;
using SMPlayer;
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

namespace PlayerUI
{
    public partial class FormShowUser : System.Windows.Forms.Form
    {
        FormAdmin formAdmin;
        bool isConnected = true;
        DataProcesser dtBase = new DataProcesser();
        public FormShowUser(FormAdmin f)
        {
            InitializeComponent();
            this.formAdmin = f;
        }
        private void FormShowUser_Load(object sender, EventArgs e)
        {
            try
            {
                dgvUser.DataSource = dtBase.DocBang("select * from tblUser");
                dgvUser.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            }catch (Exception ex)
            {
                isConnected = false;
                MessageBox.Show("Kết nối cơ sở dữ liệu không thành công");
            }
            
        }

        private void dgvUser_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Kết nối cơ sở dữ liệu không thành công");
                return;
            }
            tbUserName.Text = dgvUser.CurrentRow.Cells[0].Value.ToString();
            tbPassword.Text = dgvUser.CurrentRow.Cells[1].Value.ToString();
            tbFullName.Text = dgvUser.CurrentRow.Cells[2].Value.ToString();
            tbEnable.Text = dgvUser.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Kết nối cơ sở dữ liệu không thành công");
                return;
            }
            if (tbUserName.Text == "")
            {
                MessageBox.Show("Bạn phải tên đăng nhập");
                tbUserName.Focus();
            }
            else if (tbPassword.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mật khẩu");
                tbPassword.Focus();
            }
            else if (tbFullName.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên người dùng");
                tbFullName.Focus();
            }else
            {
                DataTable dtUser = dtBase.DocBang("Select * from tblUser where UserName=N'" 
                        + tbUserName.Text + "'");
                if (dtUser.Rows.Count == 0)
                {
                    dtBase.CapNhatDuLieu("insert into tblUser values(N'"+
                        tbUserName.Text+"', N'"+tbPassword.Text+"', N'"+tbFullName.Text +"',1,0)");
                    dgvUser.DataSource = dtBase.DocBang("Select * from tblUser");
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập này đã tồn tại. Bạn phải nhập tên khác");
                    tbUserName.Focus();
                }
                
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Kết nối cơ sở dữ liệu không thành công");
                return;
            }
            DataTable dtUser;
            try
            {
                dtUser = dtBase.DocBang("Select * from tblUser where UserName=N'"
                    + tbUserName.Text + "' and Password=N'" + tbPassword.Text + "'");
            }
            catch
            {
                MessageBox.Show("Kết nối cơ sở dữ liệu không thành công");
                return;
            }
            if (dtUser.Rows.Count == 0)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác");
                return;
            }
            else if (dtUser.Select()[0]["isOnline"].ToString() == "1")
            {
                MessageBox.Show("Tài khoản đang được đăng nhập ở nơi khác");
                return;
            }
            dtBase.CapNhatDuLieu("update tblUser set Enable=0 where tblUser.UserName=N'" +
                tbUserName.Text + "'");
            dgvUser.DataSource = dtBase.DocBang("Select * from tblUser");
            ClearData();
            MessageBox.Show("Xóa thành công");
        }
        private void ClearData()
        {
            tbEnable.Text = tbFullName.Text = tbPassword.Text = tbUserName.Text = "";
        }
        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Kết nối cơ sở dữ liệu không thành công");
                return;
            }
            DataTable dtUser = dtBase.DocBang("Select * from tblUser where UserName='"
                        + tbUserName.Text + "'");
            if (dtUser.Rows.Count == 0)
            {
                dtBase.CapNhatDuLieu("update tblUser set PassWord=N'" + tbPassword.Text + "',FullName=N'"
                + tbFullName.Text + "',Enable=1 where tblUser.UserName=N'" + tbUserName.Text + "'");
                dgvUser.DataSource = dtBase.DocBang("Select * from tblUser");
                ClearData();
                MessageBox.Show("Cập nhập thành công");
            }
            else
            {
                MessageBox.Show("Tên đăng nhập này đã tồn tại. Bạn phải nhập tên khác");
                tbUserName.Focus();
            }
            
        }

        private void btnLoginUser_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Kết nối cơ sở dữ liệu không thành công");
                return;
            }
            DataTable dtUser;
            try
            {
                dtUser = dtBase.DocBang("Select * from tblUser where UserName=N'"
                    + tbUserName.Text + "' and Password=N'" + tbPassword.Text + "'");
            }
            catch
            {
                MessageBox.Show("Kết nối cơ sở dữ liệu không thành công");
                return;
            }
            if (dtUser.Rows.Count == 0)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác");
                return;
            }
            else if (dtUser.Select()[0]["isOnline"].ToString() == "1")
            {
                MessageBox.Show("Tài khoản đang được đăng nhập ở nơi khác");
                return;
            }
            dgvUser.DataSource = dtBase.DocBang("Select * from tblUser");
            if (dtUser.Select()[0]["Enable"].ToString() != "0"){
                dtBase.CapNhatDuLieu("update tblUser set isOnline=1 where tblUser.UserName=N'" + tbUserName.Text + "'");
                formAdmin.formUser = new FormUser(tbUserName.Text, tbPassword.Text, 1, formAdmin.formLogin);
                formAdmin.formUser.ShowDialog();
            }       
            else
                MessageBox.Show("Tài khoản này không khả dụng");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvUser.DataSource = dtBase.DocBang("Select * from tblUser");
        }
    }
}
