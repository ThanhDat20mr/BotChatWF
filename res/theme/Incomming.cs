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
    public partial class Incomming : UserControl
    {
        public Incomming()
        {
            InitializeComponent();
            setAvt();
            lblTime.Text = DateTime.Now.ToString("hh:mm tt") ;
            
        }
        public string Message
        {
            get
            {
                return label1.Text;      
            }
            set
            {
                label1.Text=value;
                AdjustHeight();
            }
        }
       
        void setAvt()
        {
            Avt.Image = Properties.Resources.train;
        }
        void AdjustHeight()
        {
            Avt.Location = new Point(4, 3);
            label1.Height = Utils.GetTextHeight(label1) + 10;
            txtBot.Width = label1.Top + txtBot.Top + label1.Width;
            this.Width = txtBot.Bottom + 10;
            txtBot.Height = label1.Height + 20;
            int X=160+ txtBot.Width - 80;
            lblTime.Location = new Point(X, 60);
        }
        public Image Avatar { get => Avt.Image; set => Avt.Image = value; }
        
        private void Chatter_resize()
        {
            AdjustHeight();
        }
    }
}
