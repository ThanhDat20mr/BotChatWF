using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WinFormChatBot
{
    public partial class Utils : UserControl
    {

        public static int GetTextHeight(Label lbl)
        {
            using (Graphics g = lbl.CreateGraphics())
            {
                SizeF size = g.MeasureString(lbl.Text, lbl.Font, 495);
                return (int)Math.Ceiling(size.Height);
            }
        }
        public static int GetTextCount(Label lbl)
        {
            string txt = LocDau(lbl.Text);
            int count = txt.Length;
            return count;
        }
        public static string GetText(Label lbl)
        {
            string t = lbl.Text;
            return t;
        }

        public static string LocDau(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
        public static void load_cbxType(ComboBox cbx)
        {
            using (ChatBotEntities db = new ChatBotEntities())
            {
                var result = from c in db.Topic select c;
                cbx.DataSource = result.ToList();
                cbx.DisplayMember = "tenloai";
                cbx.ValueMember = "maloai";
            }
        }
        public static void addType(string name)
        {
            using (ChatBotEntities db = new ChatBotEntities())
            {
                db.Topic.Add(new Topic() { tenloai = name });
                db.SaveChanges();
            }

        }
        public static void addSize(DataGridView dtgv , string s)
        {
            string username = Utils.getUsername(dtgv);
            using (ChatBotEntities db = new ChatBotEntities())
            {
                Account acc = db.Account.Find(username);
                acc.size = s;
                db.SaveChanges();
            }

        }
        public static string getAdmin(DataGridView dtgv)
        {
            using (ChatBotEntities db = new ChatBotEntities())
            {
                var result = from c in db.History
                             select new { Num = c.num, Admin = c.administration, Username = c.username, Time = c.date };

                dtgv.DataSource = result.ToList();
                int i = dtgv.RowCount - 1;
                string h = dtgv.Rows[i].Cells[1].Value.ToString();
                return h;
            }
        }
        public static string getUsername(DataGridView dtgv)
        {
            using (ChatBotEntities db = new ChatBotEntities())
            {
                var result = from c in db.History
                             select new { Num = c.num, Admin = c.administration, Username = c.username, Time = c.date };

                dtgv.DataSource = result.ToList();
                int i = dtgv.RowCount - 1;
                string h = dtgv.Rows[i].Cells[2].Value.ToString();
                return h;
            }
        }
        public static void size_img(Panel pnl)
        {
            var bubble = new res.theme.ImgOut();
            pnl.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            Image image = Properties.Resources.size;
            bubble.BackgroundImage = image;
            

        }
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
        public static string randAns(DataGridView dtgv, string search, string txt, int tag)
        {

            using (ChatBotEntities db = new ChatBotEntities())
            {
                Answer ans = db.Answer.Where(p => p.Me == search.ToLower()).SingleOrDefault();
                var result = from c in db.Answer.Where(p => p.maloai == ans.maloai)
                             select c;
                ArrayList arr = new ArrayList();
                dtgv.DataSource = result.ToList();
                for (int i = 0; i < dtgv.Rows.Count; i++)
                {
                    string Bot = dtgv.Rows[i].Cells[2].Value.ToString();
                    arr.Add(Bot);
                }
                Random rand = new Random();
                int index = rand.Next(0, arr.Count);
                txt = arr[index].ToString();
                tag = 0;
            }
            return txt;

        }
        public static void loadActive(DataGridView dtgv)
        {
            dtgv.Columns.Clear();
            using (ChatBotEntities db = new ChatBotEntities())
            {
                var result = from c in db.Account where(c.active==true)
                             select new { Username = c.username, Password = c.password, Administration = c.administration,
                                 FullName = c.fullname, Age = c.age, PhoneNum = c.phone, Size = c.size, Style = c.style };
                    dtgv.DataSource = result.ToList();
            }
                
        }
        public static void loadDeactive(DataGridView dtgv)
        {
            dtgv.Columns.Clear();
            using (ChatBotEntities db = new ChatBotEntities())
            {
                var result = from c in db.Account where(c.active==false)
                             select new { Username = c.username, Password = c.password, Administration = c.administration,
                                 FullName = c.fullname, Age = c.age, PhoneNum = c.phone, Size = c.size, Style = c.style };
                    dtgv.DataSource = result.ToList();
            }
                
        }



        public static void webbrowser(string link )
        {
            var rs = new ProcessStartInfo("chrome.exe");
            rs.Arguments = link;         //txt.Replace(" ","")
            Process.Start(rs);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Utils
            // 
            this.Name = "Utils";
            this.Size = new System.Drawing.Size(832, 394);
            this.ResumeLayout(false);

        }
        public static void getImg(PictureBox pic,Panel pnlContainer,ImageList imageList1,int index)
        {
            pic = new PictureBox();
            pnlContainer.Controls.Add(pic);
            pic.Size = new Size(255, 255);
            pic.Dock = DockStyle.Top;
            pic.BringToFront();
            pic.Image = imageList1.Images[index];

        }

    }
}
