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
    public partial class FormRemove : Form
    {
        string Username;
        int isVideo=1;
        DataProcesser dataProcesser=new DataProcesser();
        DataTable dataTable;
        public FormRemove(string username, int isVideo)
        {
            InitializeComponent();
            Username = username;
            this.isVideo = isVideo;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbListItem == null || lbListItem.Items.Count == 0)
                return;
            if (lbListItem.SelectedIndex < 0 || lbListItem.SelectedIndex >= lbListItem.Items.Count)
                lbListItem.SelectedIndex = 0;
            if (isVideo == 1)
            {
                tbId.Text = dataTable.Rows[lbListItem.SelectedIndex]["VideoId"].ToString();
                tbName.Text= dataTable.Rows[lbListItem.SelectedIndex]["VideoName"].ToString();
            }
            else
            {
                tbId.Text = dataTable.Rows[lbListItem.SelectedIndex]["MusicId"].ToString();
                tbName.Text = dataTable.Rows[lbListItem.SelectedIndex]["MusicName"].ToString();
            }


        }

        private void FormRemove_Load(object sender, EventArgs e)
        {
            lbListItem.Items.Clear();
            if (isVideo == 1)
            {
                dataTable = dataProcesser.DocBang("select * from tblVideo " +
                    "where UserName=N'"+Username+"'");
                if(dataTable.Rows.Count == 0) {
                    MessageBox.Show("You don't have any videos");
                    
                }
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    lbListItem.Items.Add(dataTable.Rows[i]["VideoName"].ToString() + " (" +
                        dataTable.Rows[i]["VideoId"].ToString() + ")");
                }
                lbId.Text = "Video Id";
                lbName.Text = "Video Name";
            }
            else
            {
                dataTable = dataProcesser.DocBang("select * from tblMusic " +
                    "where UserName=N'" + Username + "'");
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("You don't have any songs");
                    
                }
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    lbListItem.Items.Add(dataTable.Rows[i]["MusicName"].ToString() + " (" +
                        dataTable.Rows[i]["MusicId"].ToString() + ")");
                }
                lbId.Text = "Music Id";
                lbName.Text = "Music Name";
            }
            
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (lbListItem == null || lbListItem.Items.Count == 0)
                return;
            if (lbListItem.SelectedIndex < 0 || lbListItem.SelectedIndex >= lbListItem.Items.Count)
                lbListItem.SelectedIndex = 0;
            new FormPlayVideo(System.IO.Directory.GetCurrentDirectory().ToString() +
                dataTable.Rows[lbListItem.SelectedIndex]["Path"].ToString()).ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbListItem == null || lbListItem.Items.Count == 0)
                return;
            if (lbListItem.SelectedIndex < 0 || lbListItem.SelectedIndex >= lbListItem.Items.Count)
            {
                MessageBox.Show("Select the item you want to delete");
                return;
            }
            if (MessageBox.Show("Are you sure you want to delete this item?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == System.Windows.Forms.DialogResult.Yes)
            {
                if (isVideo == 1)
                {
                    dataProcesser.CapNhatDuLieu("delete tblVideo where VideoId=N'" + tbId.Text + "'");
                }
                else
                {
                    dataProcesser.CapNhatDuLieu("delete tblMusic where MusicId=N'" + tbId.Text + "'");
                }
                MessageBox.Show("Deleted successfully");
                FormRemove_Load(null, null);
            }
        }
    }
}
