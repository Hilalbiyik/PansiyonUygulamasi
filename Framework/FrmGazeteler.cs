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
    public partial class FrmGazeteler : Form
    {
        public FrmGazeteler()
        {
            InitializeComponent();
        }

        private void BtnHurriyet_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.hurriyet.com.tr/");
        }

        private void BtnMiliyet_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.milliyet.com.tr/");
        }

        private void BtnHaberTurk_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.haberturk.com/");
        }

        private void BtnSozcu_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.sozcu.com.tr/");
        }

        private void BtnSabah_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.sabah.com.tr/");
        }

        private void BtnShiftDelete_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://shiftdelete.net/");
        }

        private void BtnWebTekno_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.webtekno.com/");
        }
    }
}
