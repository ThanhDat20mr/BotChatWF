﻿using System;
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
    public partial class OutGoing : UserControl
    {
        public OutGoing()
        {
            InitializeComponent();
            lblTime.Text = DateTime.Now.ToString("hh:mm tt");
        }

        public string Message
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text=value; //txtBot
                AdjustHeight();
            }
        }
        void location()
        {
            int count = Utils.GetTextCount(label1);
            int X_min = 341; int Y = 2;
            int X_max = 153; int X = 0;
            X = 341 - (5*count);
            if (X <= X_max)
            {
                X = X_max;
                txtBot.Location = new Point(X, Y);
            }
            else
            {
                txtBot.Location = new Point(X, Y);
            }
            
        }
        void AdjustHeight()
        {
            location();
            label1.Height = Utils.GetTextHeight(label1) + 10;
            txtBot.Width = label1.Top + txtBot.Top + label1.Width;
            this.Width = txtBot.Bottom + 10;
            txtBot.Height = label1.Height + 15;
            txtBot.Width = label1.Width +15;
            Utils.GetText(label1);
            int X = txtBot.Location.X -75; 
            lblTime.Location = new Point(X, 30);
        }
      
        private void Chatter_resize()
        {
            AdjustHeight();
        }

        private void OutGoing_DockChanged(object sender, EventArgs e)
        {
            AdjustHeight();
        }

        private void txtBot_Click(object sender, EventArgs e)
        {

        }
    }
}
