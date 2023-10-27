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
using WMPLib;

namespace PlayerUI
{
    public partial class FormWMP : Form
    {
        /*WindowsMediaPlayer*/
        public string path;
        public FormWMP()
        {
            InitializeComponent();
            player.uiMode = "None";
            player.URL = "";
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
        }
        public void fPlay()
        {
            if (player.URL == "")
                player.URL = this.path;
            player.Ctlcontrols.play();
        }
        public void fPause()
        {
            player.Ctlcontrols.pause();
        }

        private void player_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            fPlay();
            /*if (e.)//left la preview
            {
                timer2.Start();
                fPause();
            }*/
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.fullScreen)
            {
                player.fullScreen = false;
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
            timer2.Stop();
        }
    }
}
