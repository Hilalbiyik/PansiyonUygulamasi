using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Framework
{
    public partial class FrmRadyoDinle : Form
    {
        public FrmRadyoDinle()
        {
            InitializeComponent();
        }

        private void LnkKanal1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://17733.live.streamtheworld.com/SUPER_FM.mp3";
        }

        private void LnkKanal2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer2.URL = "https://playerservices.streamtheworld.com/api/livestream-redirect/METRO_FM.mp3  ";
        }

        private void LnkKanal3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer3.URL = "https://ssldyg.radyotvonline.com/smil/smil:kralfm.smil/playlist.m3u8";
        }
   
    }
}
