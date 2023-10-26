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
using WMPLib;

namespace PlayerUI
{
    public partial class FormShowVideo : Form
    {
        string sql= "select * from tblVideo";
        DataProcesser dtBase = new DataProcesser();
        DataTable dtVideo;
        PanelCell[] pnCellList=new PanelCell[0];
        PanelCell pnCellTemp=new PanelCell();
        public FormShowVideo()
        {
            InitializeComponent();
            dtVideo = dtBase.DocBang(sql);
            pnCellList = new PanelCell[dtVideo.Rows.Count];
            for (int i = 0; i < pnCellList.Length; i++)
            {
                pnCellList[i] = new PanelCell();
            }
        }

        private void FormShowVideo_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < pnCellList.Length; i++)
            {
                pnCellList[i].BackColor = Color.Red;
                pnCellList[i].lbLike.BackColor = Color.Green;
                pnCellList[i].pnBottom.BackColor = Color.Black;
                pnCellList[i].lbUserName.BackColor = Color.Aqua;
                pnCellList[i].lbVideoName.BackColor = Color.Yellow;
                pnCellList[i].pbAvatar.BackColor = Color.Silver;
                pnCellList[i].wmpPlay.BackColor = Color.Purple;
                pnCellList[i].Visible = true;
                flpContain.Controls.Add(pnCellList[i]);

                pnCellList[i].wmpPlay.setPath(dtVideo.Rows[i]["Path"].ToString());
                pnCellList[i].lbVideoName.Text = dtVideo.Rows[i]["VideoName"].ToString();
                pnCellList[i].lbUserName.Text= dtVideo.Rows[i]["UserName"].ToString();
                pnCellList[i].lbLike.Text = dtVideo.Rows[i]["Likes"].ToString();
                //pnCellList[i].wmpPlay.Play("");
                pnCellList[i].lbUserName.MouseEnter += new System.EventHandler(pnCellList_MouseEnter);
                pnCellList[i].lbUserName.MouseLeave+= new System.EventHandler(pnCellList_MouseLeave);
            }
            FormShowVideo_Resize(null, null);
        }

        private void pnCellList_MouseLeave(object sender, EventArgs e)
        {
            PanelCell temp = sender as PanelCell;
            //temp.wmpPlay.Pause();
            label1.Text = "pause";
        }

        private void pnCellList_MouseEnter(object sender, EventArgs e)
        {
            PanelCell temp = sender as PanelCell;
            //temp.wmpPlay.Play();
            label1.Text = "play";
        }

        private void FormShowVideo_Resize(object sender, EventArgs e)
        {
            //this.BackColor = Color.Black;
            int n = Math.Min(flpContain.Width / (pnCellTemp.Width + 10), pnCellList.Length);
            int temp = flpContain.Width - n * (pnCellTemp.Width + 10);
            //flpContain.Padding = new Padding(temp / 2, 0, temp / 2, 0);
            if (n != 0)
                for (int i = 0; i < pnCellList.Length; i++)
                {
                    pnCellList[i].Margin = new Padding(temp / n / 2,0, temp / n / 2, 20);
                }
            label1.Text = temp + " " + n;
        }
    }
}
