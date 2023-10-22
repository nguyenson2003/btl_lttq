﻿using System;
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
    public partial class FormPlayVideo : Form
    {
        public FormPlayVideo()
        {
            InitializeComponent();
        }
        string[] paths, files;

        private void trackList_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Start();
            player.URL = paths[trackList.SelectedIndex];
            player.Ctlcontrols.play();
        }

        private void btnPlayVideo_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar1.Maximum = (int)(player.Ctlcontrols.currentItem.duration * 100000);
                progressBar1.Value=(int)(player.Ctlcontrols.currentPosition*100000);
                label1.Text = player.Ctlcontrols.currentPositionString;
                label2.Text=player.Ctlcontrols.currentItem.durationString;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            player.settings.volume=trackBar1.Value;
            player.Ctlcontrols.currentPosition = 0;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if(ofd.ShowDialog() == DialogResult.OK) { 
                files= ofd.SafeFileNames;
                paths = ofd.FileNames;
                for(int i=0;i<files.Length; i++)
                    trackList.Items.Add(files[i]);
            }

        }
    }
}
