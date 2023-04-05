using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
namespace WinFormChatBot
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();

        }



        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure?", " Message", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        ChatBotEntities con = new ChatBotEntities();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (con.Account.Where(p =>p.active==true && p.username == txtUsn.Text && p.password == txtPwd.Text).Count() > 0 )
            {
                using (ChatBotEntities db = new ChatBotEntities())
                {
                    Account acc = db.Account.Find(txtUsn.Text);
                    db.History.Add(new History { username = acc.username, administration = acc.administration, date = DateTime.Now.ToLocalTime(), active = acc.active });
                    db.SaveChanges();
                }
                MessageBox.Show("Login successful!");
                fMessage f = new fMessage();
                this.Hide();
                f.ShowDialog();
                this.Show();

            }
            else
            {
                MessageBox.Show("Login failed!");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void linkRegister_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fResign f = new fResign();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

    }
}
