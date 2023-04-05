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
    public partial class fMA : Form
    {
        public fMA()
        {
            InitializeComponent();
            setColor(btnAcc);
            load();
        }

        void resetColor(Panel pnl)
        {
            pnl.BackColor = Color.FromArgb(8, 26, 89);
        }
        void setColor(Panel pnl)
        {
            pnl.BackColor = Color.FromArgb(21, 64, 197);
        }
        void load()
        {
            if (btnAcc.BackColor == Color.FromArgb(21, 64, 197))
            {
                string usn = Utils.getUsername(dtgvHistory);

                using (ChatBotEntities db = new ChatBotEntities())
                {
                    Account acc = db.Account.Find(usn);
                    txtName.Text = acc.fullname;
                    txtPass.Text = acc.password;
                    txtUsername.Text = acc.username;
                    txtPhone.Text = acc.phone.ToString();
                    txtAge.Text = acc.age.ToString();
                    cbxGender.Text = acc.gender;
                }
            }

        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            resetColor(btnExit);
            resetColor(btnRegistry);
            resetColor(btnChangePass);
            setColor(btnAcc);

            int i = dtgvHistory.CurrentRow.Index;
            string username = Utils.getUsername(dtgvHistory);//dtgvHistory.Rows[i].Cells[0].Value.ToString();
            using (ChatBotEntities db = new ChatBotEntities())
            {
                Account acc = db.Account.Find(username);
                txtName.Text = acc.fullname;
                txtPass.Text = acc.password;
                txtUsername.Text = acc.username;
                txtPhone.Text = acc.phone.ToString();
                txtAge.Text = acc.age.ToString();
                cbxGender.Text = acc.gender;
            }

        }

        private void fMA_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form f = new fHome();
            f.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            resetColor(btnChangePass);
            resetColor(btnAcc);
            resetColor(btnRegistry);
            setColor(btnExit);
            Form f = new fHome();
            f.Show();
            this.Hide();
        }

        private void btnRegistry_Click(object sender, EventArgs e)
        {
            resetColor(btnExit);
            resetColor(btnAcc);
            resetColor(btnChangePass);
            setColor(btnRegistry);
            fResign f = new fResign();
            this.Hide();
            f.ShowDialog();
            this.Show();
            resetColor(btnRegistry);
            setColor(btnAcc);

        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            resetColor(btnExit);
            resetColor(btnAcc);
            resetColor(btnRegistry);
            setColor(btnChangePass);
            fChangePass f = new fChangePass();
            this.Hide();
            f.ShowDialog();
            this.Show();
            resetColor(btnChangePass);
            setColor(btnAcc);
        }
    }
}
