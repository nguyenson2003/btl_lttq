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
    public partial class FormNewListMusic : Form
    {
        DataProcesser dataProcesser=new DataProcesser();
        string Username;
        public FormNewListMusic(string username)
        {
            InitializeComponent();
            Username = username;
        }

        private void FormNewListMusic_Load(object sender, EventArgs e)
        {
            tbUsername.Text = Username;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string strtime = (DateTime.Now.Ticks / 10000000).ToString();
            string mlms = "lms" + strtime;
            dataProcesser.CapNhatDuLieu("insert into tblMusicList values(N'"+
                mlms+"',N'"+Username+"',N'"+tbListName.Text+"')");
            MessageBox.Show("Tạo thành công");
            this.Hide();
        }
    }
}
