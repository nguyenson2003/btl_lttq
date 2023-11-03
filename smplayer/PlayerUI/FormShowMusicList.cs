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

namespace PlayerUI
{
    public partial class FormShowMusicList : Form
    {
        string Username;
        string MusicName;
        string MusicId;
        DataProcesser dataProcesser=new DataProcesser();
        public FormShowMusicList(string username, string musicName,string musicId)
        {
            InitializeComponent();
            Username = username;
            MusicName = musicName;
            MusicId = musicId;
        }
        DataTable dttableLists;
        private void FormShowMusicList_Load(object sender, EventArgs e)
        {
            tbMusicId.Text = MusicId;
            tbMusicName.Text = MusicName;
            tbUsername.Text = Username;
            dttableLists = dataProcesser.DocBang("select * from tblMusicList " +
                "where UserName=N'" + Username + "'");
            for(int i=0;i<dttableLists.Rows.Count;i++)
            {
                cbLists.Items.Add(dttableLists.Rows[i]["ListName"].ToString() + 
                    " (" + dttableLists.Rows[i]["ListId"].ToString() + ")");
            }
            if(cbLists.Items.Count > 0) { 
                cbLists.SelectedIndex = 0; 
            }
        }

        private void btnNewList_Click(object sender, EventArgs e)
        {
            new FormNewListMusic(Username).ShowDialog();
            this.Refresh();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cbLists.SelectedIndex < 0 || cbLists.SelectedIndex >= cbLists.Items.Count)
                return;
            string ListId = dttableLists.Rows[cbLists.SelectedIndex]["ListId"].ToString();
            if(dataProcesser.DocBang("select * from tblMusicListDetail " +
                "where ListId=N'"+ListId+"' and MusicId=N'"+MusicId+"'").Rows.Count==0)
            {   
                dataProcesser.CapNhatDuLieu("insert into tblMusicListDetail " +
                    "values(N'"+ListId+"',N'"+MusicId+"')");
                MessageBox.Show("Bài hát này đã được thêm vào danh sách");
            }
            this.Hide();
        }
    }
}
