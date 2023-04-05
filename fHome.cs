using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormChatBot
{
    public partial class fHome : Form
    {
        public fHome()
        {
            InitializeComponent();
        }

        private void btnChabot_Click(object sender, EventArgs e)
        {
            Form f = new fMessage();
            f.Show();
            this.Hide();
        }

        private void btnTrainning_Click(object sender, EventArgs e)
        {
            Form f = new fTraining();
            f.Show();
            this.Hide();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            Form f = new fData();
            f.Show();
            this.Hide();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            
                Form f = new fMA();
                f.Show();
                this.Hide();
            
            
        }
    }
}
