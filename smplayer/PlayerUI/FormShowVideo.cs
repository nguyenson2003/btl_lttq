using QLBanHang.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PlayerUI
{
    public partial class FormShowVideo : Form
    {
        DataProcesser dtBase = new DataProcesser();
        DataTable dtVideo;
        FormCell []fCellList =new FormCell[0];
        FormCell fTemp = new FormCell();
        FormUser formUser;
        public FormShowVideo(FormUser fu,string sql)
        {
            formUser = fu;
            InitializeComponent();
            dtVideo = dtBase.DocBang(sql);
            fCellList=new FormCell[dtVideo.Rows.Count];
            
            for (int i = 0; i < fCellList.Length; i++)
                fCellList[i] = new FormCell();
        }

        private void FormShowVideo_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < fCellList.Length; i++)
            {
                string videoidtemp = dtVideo.Rows[i]["VideoId"].ToString();
                fCellList[i]=new FormCell(
                    formUser,
                    videoidtemp,
                    System.IO.Directory.GetCurrentDirectory().ToString() + dtVideo.Rows[i]["Path"].ToString(),
                    dtVideo.Rows[i]["VideoName"].ToString(),
                    dtVideo.Rows[i]["FullName"].ToString(),
                    dtBase.DocBang("select count(UserName) as Liked from tblLikeVideoDetail " +
                    "where VideoId = N'" + videoidtemp + "'").Rows[0]["Liked"].ToString()
                    );
                fCellList[i].Visible = true;

                flpContain.Controls.Add(fCellList[i]);
            }
            FormShowVideo_Resize(null, null);
        }

        private void FormShowVideo_Resize(object sender, EventArgs e)
        {
            if (fCellList == null)
                return;

            int n = Math.Min(flpContain.Width / fTemp.Width, fCellList.Length);
            int temp = flpContain.Width - n*fTemp.Width;
            if (n != 0)
                for (int i = 0; i < fCellList.Length; i++)
                {
                    fCellList[i].Size=new Size(fTemp.Size.Width+temp/n-20, 
                        (fTemp.Size.Width + temp / n-20)*fTemp.Size.Height/fTemp.Size.Width);
                    /*if(i%n==0)
                        fCellList[i].Margin = new Padding(temp-20, 0, 0, 10);*/
                }

                    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FormShowVideo_Resize(sender,  e);
        }
    }
}
