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
    public partial class fChangePass : Form
    {
        public fChangePass()
        {
            InitializeComponent();
        }
        ChatBotEntities con = new ChatBotEntities();
        private void btnRegister_Click(object sender, EventArgs e)
        {
            removeError();
            setError();
            
        }
        void removeError()
        {
            errorProvider1.SetError(txtUsername, null);
            errorProvider1.SetError(txtRepwd, null);
            errorProvider1.SetError(txtPwd, null);
            errorProvider1.SetError(txtPass, null);
        }
        void load()
        {
            txtPass.Clear();
            txtPwd.Clear();
            txtRepwd.Clear();
            txtUsername.Clear();
        }
        
        void setError()
        {
            if (string.IsNullOrEmpty(txtUsername.Text)  || string.IsNullOrEmpty(txtPwd.Text) || string.IsNullOrEmpty(txtPass.Text) || string.IsNullOrEmpty(txtRepwd.Text) || txtRepwd.Text.CompareTo(txtPwd.Text) != 0)
            {
                if (con.Account.Where(p => p.username == txtUsername.Text).Count() > 0 || string.IsNullOrEmpty(txtUsername.Text))
                {
                    if (string.IsNullOrEmpty(txtUsername.Text))
                    {
                        errorProvider1.SetError(txtUsername, "Không được để trống");
                    }

                }
                else
                {
                    errorProvider1.SetError(txtUsername, null);
                }
                if (string.IsNullOrEmpty(txtPass.Text))
                {
                    errorProvider1.SetError(txtPass, "Vui lòng nhập tên.");
                }
                else
                {
                    errorProvider1.SetError(txtPass, null);
                }
                if (string.IsNullOrEmpty(txtPwd.Text))
                {
                    errorProvider1.SetError(txtPwd, "Vui lòng nhập mật khẩu.");
                }
                else
                {
                    errorProvider1.SetError(txtPwd, null);
                }
                if (string.IsNullOrEmpty(txtRepwd.Text))
                {
                    errorProvider1.SetError(txtRepwd, "Vui lòng nhập lại mật khẩu.");
                }
                else
                {
                    errorProvider1.SetError(txtRepwd, null);
                }
                if (txtRepwd.Text.CompareTo(txtPwd.Text) != 0)
                {
                    errorProvider1.SetError(txtRepwd, "Không giống mật khẩu đã nhập.");
                }
                else
                {
                    errorProvider1.SetError(txtRepwd, null);
                }
            }
            else
            {
                string username = txtUsername.Text;
                
                using (ChatBotEntities db = new ChatBotEntities())
                {
                    Account acc = db.Account.Find(username);
                    if(db.Account.Where(p=>p.username == acc.username && p.password == txtPass.Text).Count()>0)
                    {
                        acc.password = txtPwd.Text;
                        db.SaveChanges();
                        this.Close();
                        removeError();
                        MessageBox.Show("Change password successful!");
                    }
                    else
                    {
                        MessageBox.Show("Wrong password", "Message");
                        load();                    }
                    
                }
            }

        }
    }
}
