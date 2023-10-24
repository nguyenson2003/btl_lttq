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

namespace PlayerUI
{
    public partial class FormShowUser : System.Windows.Forms.Form
    {
        DataProcesser dtBase = new DataProcesser();
        public FormShowUser()
        {
            InitializeComponent();
        }

        private void FormShowUser_Load(object sender, EventArgs e)
        {
            dgvUser.DataSource = dtBase.DocBang("select * from tbUser");
        }
    }
}
