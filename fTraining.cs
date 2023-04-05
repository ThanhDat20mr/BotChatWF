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
    public partial class fTraining : Form
    {
        public fTraining()
        {
            InitializeComponent();
            Utils.load_cbxType(cbxType);
        }

        private void fTraining_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form f = new fHome();
            f.Show();
            this.Hide();
        }
        void setError()
        {
            if (string.IsNullOrEmpty(txtA.Text))
            {
                errorProvider1.SetError(txtA,"Is Empty!");
            }
            if  (string.IsNullOrEmpty(txtQ.Text))
            {
                errorProvider1.SetError(txtQ, "Is Empty!");
            }
        }
        void removeError()
        {
            errorProvider1.SetError(txtA, null);
            errorProvider1.SetError(txtQ, null);
        }
        private void btnTrain_Click(object sender, EventArgs e)
        {
            removeError();
            using (ChatBotEntities db = new ChatBotEntities())
            {
                if(string.IsNullOrEmpty(txtA.Text)||string.IsNullOrEmpty(txtQ.Text))
                {
                    
                    setError();
                }
                else{
                    db.Answer.Add(new Answer() { Me = txtQ.Text, Bot = txtA.Text, maloai = int.Parse(cbxType.SelectedValue.ToString()) });
                    db.SaveChanges();
                    MessageBox.Show("Training completely!");
                    label1.Text = "Iu anh nhất~";
                    int time = 2000;
                    Task.Delay(time).Wait();
                    this.Close();
                }
                
            }
        }
        

        
    }
}
