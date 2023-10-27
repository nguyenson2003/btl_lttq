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
    }
}
