using PlayerUI;
using QLBanHang.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SMPlayer
{
    
    public partial class FormLogin : System.Windows.Forms.Form
    {
        string initUserName,initPassword;
        DataProcesser dtBase = new DataProcesser();
        bool isConnect = true;
        public FormAdmin formAdmin;
        public FormUser formUser;
        public FormLogin()
        {
            formAdmin = null;
            formUser=null;
            InitializeComponent();
        }
        public FormLogin(string us,string pw)
        {
            initUserName = us;
            initPassword = pw;
            InitializeComponent();
        }
        private void linkLabel4_LinkSignUp(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbSignUpUserName.Text=tbSignUpPassword.Text=tbSignUpRepeat.Text="";
            tbSignUpUserName.Select();
            pnSignUp.Visible = true;
            pnSignUp.BringToFront();

        }

        private void linkLabel2_LinkLogin(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbLoginUserName.Text = tbLoginPassword.Text = "";
            tbLoginUserName.Select();
            pnSignUp.Visible = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        bool isHiddenSignUp = true,isHiddenLogin=true;

        private void btnSignUpHidden_MouseDown(object sender, MouseEventArgs e)
        {
            if (isHiddenSignUp) {
                btnSignUpHidden.Image = btnShowState.Image;
                tbSignUpPassword.PasswordChar = '\0';
                tbSignUpRepeat.PasswordChar = '\0';   
                isHiddenSignUp = false;
            }
            
        }

        private void btnSignUpHidden_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isHiddenSignUp)
            {
                btnSignUpHidden.Image = btnHiddenState.Image;
                tbSignUpPassword.PasswordChar = '*';
                tbSignUpRepeat.PasswordChar = '*';
                isHiddenSignUp = true;
            }
        }

        private void btnLoginHidden_MouseDown(object sender, MouseEventArgs e)
        {
            if (isHiddenLogin)
            {
                btnLoginHidden.Image = btnShowState.Image;
                tbLoginPassword.PasswordChar = '\0';
                isHiddenLogin = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbLoginUserName.Text;
            string password = tbLoginPassword.Text;
            if (username == "")
            {
                MessageBox.Show("Bạn phải nhập tên đăng nhập");
                tbLoginUserName.Select();
            }
            else if (password == "")
            {
                MessageBox.Show("Bạn phải nhập mật khẩu");
                tbLoginPassword.Select();
            }
            else 
            {
                DataTable dtUser;
                try
                {
                    dtUser = dtBase.DocBang("Select * from tblUser where UserName=N'"
                        + username + "' and Password=N'"+password+"'");
                }
                catch
                {
                    MessageBox.Show("Kết nối cơ sở dữ liệu không thành công");
                    return;
                }
                if (dtUser.Rows.Count == 0)
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác");
                }
                else if (dtUser.Select()[0]["isOnline"].ToString() == "1")
                {
                    MessageBox.Show("Tài khoản đang được đăng nhập");
                }
                else if (dtUser.Select()[0]["Enable"].ToString() == "0") {
                    MessageBox.Show("Tài khoản không khả dụng");
                }else
                {
                    if (password == "123" && username.ToLower() == "admin")
                        if (dtBase.DocBang("select* from tblUser where UserName = N'admin'").Rows.Count == 0)
                            dtBase.CapNhatDuLieu("insert into tblUser values(N'admin',N'123',N'Lê Văn Minh',1,0)");
                            
                    dtBase.CapNhatDuLieu("update tblUser set isOnline=1 where tblUser.UserName=N'"+username+"'");
                    if (password == "123" && username.ToLower() == "admin")
                    {
                        formAdmin = new FormAdmin(this);
                        formAdmin.Show(); 
                        this.Hide();
                    }else
                    {
                        formUser = new FormUser(tbLoginUserName.Text, tbLoginPassword.Text, 0, this);
                        formUser.Show();  
                        this.Hide();
                    }
                    tbLoginUserName.Text = tbLoginPassword.Text = "";
                    
                }
            }
            
           /*...*/
            
            
                
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            tbLoginUserName.Select();
            if (initUserName != null && initPassword != null)
            {
                tbLoginUserName.Text = initUserName;
                tbLoginPassword.Text = initPassword;
            }
            
        }

        private void tbLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
                btnLogin_Click(sender, e);
        }

        private void tbSignUp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSignUp_Click(sender, e);
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string email = tbSignUpUserName.Text;
            string password = tbSignUpPassword.Text;
            string repeat= tbSignUpRepeat.Text;
            if (email == "")
            {
                MessageBox.Show("Bạn phải nhập tên đăng nhập");
                tbSignUpUserName.Select();
            }else if (password == "")
            {
                MessageBox.Show("Bạn phải nhập mật khẩu");
                tbSignUpPassword.Select();
            }else if (repeat == "")
            {
                MessageBox.Show("Bạn phải nhắc lại mật khẩu");
                tbSignUpRepeat.Select();
            }else if (password != repeat)
            {
                MessageBox.Show("Mật khẩu không khớp");
                tbSignUpRepeat.Select();
            }
            else
            {
                DataTable dtUser;
                try
                {
                    dtUser = dtBase.DocBang("Select * from tblUser where UserName='"
                                            + tbSignUpUserName.Text + "'");
                }
                catch
                {
                    MessageBox.Show("Kết nối cơ sở dữ liệu không thành công");
                    return;
                }
                
                if (dtUser.Rows.Count != 0)
                {
                    MessageBox.Show("Tên đăng nhập này đã tồn tại. Bạn phải nhập tên khác");
                    tbSignUpUserName.Focus();
                }
                else
                {
                    dtBase.CapNhatDuLieu("insert into tblUser values(N'"+tbSignUpUserName.Text+"',N'"+
                        tbSignUpPassword.Text+"',N'"+tbSignUpUserName.Text+"',1,0)");
                    dtUser = dtBase.DocBang("Select * from tblUser where UserName='"
                                            + tbSignUpUserName.Text + "'");
                    if (dtUser.Rows.Count != 0)
                        MessageBox.Show("Tạo tài khoản thành công");
                    else
                        MessageBox.Show("Tạo tài khoản không thành công");
                    tbLoginUserName.Text= tbSignUpUserName.Text;
                    tbLoginPassword.Text= tbSignUpPassword.Text;
                    tbLoginUserName.Select();
                    pnSignUp.Visible = false;
                }
            }
            
        }




        private void btnLoginHidden_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isHiddenLogin)
            {
                btnLoginHidden.Image = btnHiddenState.Image;
                tbLoginPassword.PasswordChar = '*';
                isHiddenLogin = true;
            }
        }
    }
}
