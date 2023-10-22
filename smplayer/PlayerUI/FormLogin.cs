using QLBanHang.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMPlayer
{
    
    public partial class FormLogin : System.Windows.Forms.Form
    {
        
        DataProcesser dtBase = new DataProcesser();
        Form form1;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void linkLabel4_LinkSignUp(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbSignUpEmail.Select();
            pnSignUp.Visible = true;
            pnSignUp.BringToFront();
        }

        private void linkLabel2_LinkLogin(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbLoginEmail.Select();
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
            string email = tbLoginEmail.Text;
            string password = tbLoginPassword.Text;
            if (password == "123" && email == "admin")
            {
                form1 = new Form(this);
                form1.Show();
                this.Hide();
                tbLoginEmail.Text = tbLoginPassword.Text = "";
                return;
            }
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                if (true)
                {
                    return;
                }
                else
                {
                    MessageBox.Show("Email or password is incorrect");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please enter a email");
                return;
            }
                
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            tbLoginEmail.Select();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string email = tbSignUpEmail.Text;
            string password = tbSignUpPassword.Text;
            string repeat= tbSignUpRepeat.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (!match.Success)
            {
                MessageBox.Show("Please enter a email");
                return;
                
            }
            else
            {
                if (password!=repeat)
                {
                    MessageBox.Show("Password and repeat do not match");
                    return;
                }
                else
                {
                    //check có acc chưa

                    //them acc vào cơ sở dữ liệu
                    tbSignUpEmail.Text = tbSignUpPassword.Text = tbSignUpRepeat.Text = "";
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
