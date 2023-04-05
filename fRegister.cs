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
    public partial class fResign : Form 
    {
        public fResign()
        {
            InitializeComponent();
        }
        ChatBotEntities con = new ChatBotEntities();
        void removeError()
        {
            errorProvider1.SetError(txtUsername, null);
            errorProvider1.SetError(txtName, null);
            errorProvider1.SetError(txtPwd, null);
        }
        void setError()
        {
            if (string.IsNullOrEmpty(txtUsername.Text)|| con.Account.Where(p => p.username == txtUsername.Text).Count() > 0   || string.IsNullOrEmpty(txtName.Text) ||  string.IsNullOrEmpty(txtPwd.Text) || string.IsNullOrEmpty(txtRepwd.Text) || txtRepwd.Text.CompareTo(txtPwd.Text) != 0)
            {
                if (con.Account.Where(p => p.username == txtUsername.Text).Count() > 0 || string.IsNullOrEmpty(txtUsername.Text))
                {
                    if (string.IsNullOrEmpty(txtUsername.Text))
                    {
                        errorProvider1.SetError(txtUsername, "Không được để trống");
                    }
                    else
                    {
                        errorProvider1.SetError(txtUsername, "Already exist");
                    }
                }
                else
                {
                    errorProvider1.SetError(txtUsername, null);
                }                
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    errorProvider1.SetError(txtName, "Vui lòng nhập tên.");
                }
                else
                {
                    errorProvider1.SetError(txtName, null);
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

                MessageBox.Show("Register successful!");
                using (ChatBotEntities db = new ChatBotEntities())
                {
                    db.Account.Add(new Account() { username = txtUsername.Text, fullname = txtName.Text, password = txtPwd.Text, active = true, administration = false  });
                    db.SaveChanges();
                    this.Close();
                    removeError();
                }
            }
            
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {           
            setError();
        }
        private void txtMSSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Wrong character", "Message");
            }
        }
    }

}