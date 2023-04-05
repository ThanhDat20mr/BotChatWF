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
    public partial class fData : Form
    {
        public fData()
        {
            InitializeComponent();
            //setColor(btnAcc);
            loadData();
            
        }
        ChatBotEntities con = new ChatBotEntities();
        //Image img = Properties.Resources.acti;
        void addDel()
        {
            DataGridViewImageColumn btn = new DataGridViewImageColumn();
            //btn.UseColumnTextForButtonValue = true;
            btn.HeaderText = "";
            //btn.Text = "Del";
            btn.Image = imageList1.Images[2];
            btn.Name = "btnDel";
            dtgv.Columns.Add(btn);
        }
        void addActive()
        {
            DataGridViewImageColumn btn = new DataGridViewImageColumn();
            btn.HeaderText = "Active";
            btn.Image = imageList1.Images[0];
            btn.Name = "btnActive";
            dtgv.Columns.Add(btn);
        }
        void addDeactive()
        {
            DataGridViewImageColumn btn = new DataGridViewImageColumn();
            btn.HeaderText = "Deactive";
            btn.Image = imageList1.Images[1];
            btn.Name = "btnDeactive";
            dtgv.Columns.Add(btn);
        }
        void addAdmin()
        {
            DataGridViewImageColumn btn = new DataGridViewImageColumn();
            btn.HeaderText = "Authorize";
            btn.Image = imageList1.Images[3];
            btn.Name = "btnAdmin";
            dtgv.Columns.Add(btn);
        }
        

        void loadData()
        {
            dtgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            using (ChatBotEntities db = new ChatBotEntities())
            {
                if (btnAnswer.BackColor == Color.FromArgb(21, 64, 197))
                {
                    dtgv.Columns.Clear();
                    var result = from c in db.Answer
                                 select new { Num = c.stt, Me = c.Me, Bot = c.Bot, Type = c.Topic.tenloai };
                    
                    dtgv.DataSource = result.ToList();
                    addDel();
                }
                if(btnAcc.BackColor == Color.FromArgb(21, 64, 197))
                {
                    dtgv.Columns.Clear();
                    var result = from c in db.Account
                                 select new {  Username = c.username, Password = c.password,Administration = c.administration,
                                     FullName = c.fullname, Age = c.age, PhoneNum = c.phone, Size = c.size, Style = c.style  };
                    dtgv.DataSource = result.ToList();
                    addAdmin();
                    addDel();
                }
                if (btnType.BackColor == Color.FromArgb(21, 64, 197))
                {
                    dtgv.Columns.Clear();
                    var result = from c in db.Topic
                                 select new { Num = c.maloai, Type = c.tenloai};
                    dtgv.DataSource = result.ToList();
                    addDel();
                }
            }

            

        }

        private void fData_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form f = new fHome();
            f.Show();
            this.Hide();
        }

        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgv.CurrentRow.Index;
            string id = dtgv.Rows[i].Cells[0].Value.ToString();
            if (dtgv.Columns[e.ColumnIndex].Name == "btnDel")
            {
                if (MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (ChatBotEntities db = new ChatBotEntities())
                    {
                        if (btnAnswer.BackColor == Color.FromArgb(21, 64, 197))
                        {
                            Answer ans = db.Answer.Where(p => p.stt.ToString().Equals(id)).SingleOrDefault();
                            db.Answer.Remove(ans);
                            db.SaveChanges();
                            MessageBox.Show("Delete successfully!", "Message");
                            loadData();
                        }
                        if (btnType.BackColor == Color.FromArgb(21, 64, 197))
                        {
                            Topic ans = db.Topic.Where(p => p.maloai.ToString().Equals(id)).SingleOrDefault();
                            db.Topic.Remove(ans);
                            db.SaveChanges();
                            MessageBox.Show("Delete successfully!", "Message");
                            loadData();
                        }
                        if (btnAcc.BackColor == Color.FromArgb(21, 64, 197))
                        {
                            Account acc = db.Account.Find(id);
                            Account ans = db.Account.Where(p => p.username.ToString().Equals(id)).SingleOrDefault();
                            db.Account.Remove(ans);                            
                            db.SaveChanges();
                            MessageBox.Show("Delete successfully!", "Message");
                            loadData();
                        }


                    }
                }
            }
            if (dtgv.Columns[e.ColumnIndex].Name == "btnActive")
            {
                i = dtgv.CurrentRow.Index;
                string username = dtgv.Rows[i].Cells[0].Value.ToString();
                if (MessageBox.Show("Are you sure to deactivate this account?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using(ChatBotEntities db = new ChatBotEntities())
                    {
                        Account acc = db.Account.Find(username);
                        acc.active = false;
                        db.SaveChanges();
                    }
                    Utils.loadActive(dtgv);
                    addActive();
                }
            }
            if (dtgv.Columns[e.ColumnIndex].Name == "btnDeactive")
            {
                i = dtgv.CurrentRow.Index;
                string username = dtgv.Rows[i].Cells[0].Value.ToString();
                if (MessageBox.Show("Are you sure to active this account?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (ChatBotEntities db = new ChatBotEntities())
                    {
                        Account acc = db.Account.Find(username);
                        acc.active = true;
                        db.SaveChanges();
                    }
                    Utils.loadDeactive(dtgv);
                    addDeactive();
                }
            }
            if(dtgv.Columns[e.ColumnIndex].Name == "btnAdmin")
            {
                //loadData();
                i = dtgv.CurrentRow.Index;
                string username = dtgv.Rows[i].Cells[0].Value.ToString();
                using (ChatBotEntities db = new ChatBotEntities())
                {
                    //Account acc = db.Account.Where(p => p.username.ToString().Equals(id)).SingleOrDefault();
                    Account acc = db.Account.Find(username);
                    if (acc.administration == true)
                    {
                        if (MessageBox.Show("Are you sure to unauthorize this account?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            acc.administration = false;
                            db.SaveChanges();


                        }
                    }
                    if (acc.administration == false)
                    {
                        if (MessageBox.Show("Are you sure to authorize this account?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            acc.administration = true;
                            db.SaveChanges();
                        }
                    }

                }
                loadData();
            }
            
        }

        void resetColor(Panel pnl)
        {
            pnl.BackColor = Color.FromArgb(8, 26, 89);
        }
        void setColor(Panel pnl)
        {
            pnl.BackColor = Color.FromArgb(21, 64, 197);
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            resetColor(btnType);
            resetColor(btnAnswer);
            setColor(btnAcc);
            loadData();
            grb.Text = "Account";
            setVison();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            resetColor(btnType);
            resetColor(btnAcc);
            setColor(btnAnswer);
            loadData();
            grb.Text = "Answer";
            setVison();
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            resetColor(btnAcc);
            resetColor(btnAnswer);
            setColor(btnType);
            loadData();
            grb.Text = "Type";
            setVison();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            resetColor(btnType);
            resetColor(btnAnswer);
            resetColor(btnAcc);
            setColor(btnExit);
            this.Close();
        }

        private void sortAll_Click(object sender, EventArgs e)
        {
            loadData();    
        }

        private void sortActive_Click(object sender, EventArgs e)
        {
                    Utils.loadActive(dtgv);
                    addActive();
        }

        private void sortDeactive_Click(object sender, EventArgs e)
        {
                    Utils.loadDeactive(dtgv);
                    addDeactive();
        }
        void setVison()
        {
            if (grb.Text == "Account")
            {
                sortActive.Visible = true;
                sortDeactive.Visible = true;
                sortAll.Visible = true;
            }
            else
            {
                sortActive.Visible = false;
                sortDeactive.Visible = false;
                sortAll.Visible = false;
            }
        }
    }
}
