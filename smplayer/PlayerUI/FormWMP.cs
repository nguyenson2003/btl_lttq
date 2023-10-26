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
    public partial class FormWMP : Form
    {
        /*WindowsMediaPlayer*/
        public FormWMP()
        {
            InitializeComponent();
            player.uiMode = "None";
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            
        }
        public void setPath(string path)
        {
            player.URL= System.IO.Directory.GetCurrentDirectory().ToString() + path;
            
        }
        public void Play()
        {
            player.Ctlcontrols.play();
        }
        public void Pause()
        {
            player.Ctlcontrols.pause();
        }

        private void FormWMP_Load(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }
    }
}
