using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace PlayerUI
{
    internal class PanelCell:Panel
    {
        public Panel pnBottom;
        public PictureBox pbAvatar;
        public Label lbVideoName;
        public Label lbUserName;
        public Label lbLike;
        public FormWMP wmpPlay;
        public PanelCell()
        {
            pnBottom= new Panel(); 
            pbAvatar=new PictureBox();
            lbLike= new Label(); 
            lbUserName = new Label(); 
            lbVideoName =new Label();
            wmpPlay=new FormWMP();

            this.Size = new System.Drawing.Size(500,300);
            pnBottom.Size = new System.Drawing.Size(10, 55);

            this.Padding=this.Margin=new Padding(0);


            this.Controls.Add(pnBottom);
            this.Controls.Add(wmpPlay);
            //wmpPlay.Size = this.Size;
            //wmpPlay.TopLevel = false;
            //wmpPlay.FormBorderStyle = FormBorderStyle.None;


            //this.Tag = wmpPlay;
            pnBottom.BringToFront();
            pnBottom.Dock = DockStyle.Bottom;
            wmpPlay.BringToFront();
            wmpPlay.Dock = DockStyle.Fill;
            wmpPlay.Show();


            pnBottom.Controls.Add(pbAvatar);
            pnBottom.Controls.Add(lbLike);
            pnBottom.Controls.Add(lbUserName);
            pnBottom.Controls.Add(lbVideoName);

            pbAvatar.BringToFront();
            pbAvatar.Dock = DockStyle.Left;

            lbLike.BringToFront();
            lbLike.Dock = DockStyle.Right;
            lbUserName.BringToFront();
            lbUserName.Dock = DockStyle.Bottom;
            lbVideoName.BringToFront();
            lbVideoName.Dock = DockStyle.Fill;

            pnBottom.Font = new Font("Microsoft Sans Serif", 12);

            pbAvatar.Size = new System.Drawing.Size(60, 10);
            lbLike.Size = new System.Drawing.Size(75, 10);
            lbUserName.Size = new System.Drawing.Size(10, 25);

            lbLike.TextAlign= System.Drawing.ContentAlignment.MiddleRight;
            lbLike.ImageAlign= System.Drawing.ContentAlignment.MiddleLeft;
            lbLike.Padding = new Padding(10, 0, 10, 0);
            lbLike.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory().ToString() 
                + "\\images\\facebook_like_20px.png");

            pbAvatar.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory().ToString() 
                + "\\images\\User_50px.png");
            pbAvatar.SizeMode=PictureBoxSizeMode.Zoom;
        }
        /*private void openChildForm(System.Windows.Forms.Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.Size = panelChildForm.Size;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }*/
    }
}
