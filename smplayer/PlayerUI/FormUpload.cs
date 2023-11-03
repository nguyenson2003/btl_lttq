using QLBanHang.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class FormUpload : Form
    {
        string Username;
        DataProcesser dataProcesser=new DataProcesser();
        public FormUpload(string username)
        {
            InitializeComponent();
            Username = username;
        }
        OpenFileDialog ofd = new OpenFileDialog();
        string strFilter = "";
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            
            ofd.Filter = strFilter;
            if(ofd.ShowDialog() == DialogResult.OK) {
                btnPreview.Enabled = true;
                /*FileInfo fi = new FileInfo(ofd.FileName);
                fi.CopyTo(System.IO.Directory.GetCurrentDirectory().ToString()+"\\Musics\\hello.mp3", true);*/
                tbVideoName.Text = ofd.FileName.Substring(ofd.FileName.LastIndexOf('\\')+1) ;
                btnConfirm.Enabled = true;
            }
        }

        private void cbObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbVideoName.Text = "";
            if(cbObject.SelectedIndex == 0) {
                strFilter= "Mở mp4 thôi nhé ^^|*.mp4";
                lbVideoName.Text = "Video Name";
            }
            else
            {
                lbVideoName.Text = "Music Name";
                strFilter = "Mở mp3 thôi nhé ^^|*.mp3";
            }
        }

        private void FormUpload_Load(object sender, EventArgs e)
        {
            cbObject.SelectedIndex = 0;
            tbUsername.Text = Username;
            ofd.Multiselect = false;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            new FormPlayVideo(ofd.FileName).ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string strtime = (DateTime.Now.Ticks / 10000000).ToString();
            FileInfo fi = new FileInfo(ofd.FileName);
            
            if (cbObject.SelectedIndex == 0)
            {
                //save video
                string mvd = "vd" + strtime;
                string mus = Username;
                string vdn = tbVideoName.Text;
                string path = "\\Videos\\" + mvd + ".mp4";
                dataProcesser.CapNhatDuLieu("insert into tblVideo values(N'"
                    + mvd + "', N'" + mus + "', N'" + vdn + "', N'" + path + "')");
                fi.CopyTo(System.IO.Directory.GetCurrentDirectory().ToString() + path, true);
                MessageBox.Show("Up load thành công");
            }
            else
            {
                //save music
                string mms = "ms" + strtime;
                string mus =Username;
                string msn =tbVideoName.Text;
                string path = "\\Musics\\" + mms+".mp3";
                dataProcesser.CapNhatDuLieu("insert into tblMusic values(N'" +
                    mms + "',N'" + mus + "',N'" + msn + "',N'" + path + "')");
                fi.CopyTo(System.IO.Directory.GetCurrentDirectory().ToString() + path, true);
                MessageBox.Show("Up load thành công");
            }
            tbVideoName.Text = "";
            btnConfirm.Enabled=btnPreview.Enabled=false;
        }
    }
}
