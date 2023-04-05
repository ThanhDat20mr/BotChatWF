using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormChatBot.res.theme
{
    public partial class voiceIncomming : UserControl
    {
        public voiceIncomming()
        {
            InitializeComponent();
            //setAvt();
            lblTime.Text = DateTime.Now.ToString("hh:mm tt");
            //AdjustHeight();
        }
        void setAvt()
        {
            Avt.Image = Properties.Resources.train;
        }
        void AdjustHeight()
        {
            Avt.Location = new Point(4, 3);
            //label1.Height = Utils.GetTextHeight(label1) + 10;
            //txtBot.Width = label1.Top + txtBot.Top + label1.Width;
            this.Width = txtBot.Bottom + 10;
            txtBot.Height = btnPlay.Height + 20;
            int X = 160 + txtBot.Width - 80;
            lblTime.Location = new Point(X, 60);
        }
        public Image Avatar { get => Avt.Image; set => Avt.Image = value; }
        WMPLib.WindowsMediaPlayer love = new WMPLib.WindowsMediaPlayer();

        private void btnPlay_Click(object sender, EventArgs e)
        {
            love.URL = "D:\\LT_Web\\WinFormChatBot\\res\\voice\\voice_love.mp3";
            love.controls.play();
        }
    }
}
