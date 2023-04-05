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
    public partial class fMessage : Form
    {
        public fMessage()
        {
            InitializeComponent();
            Avt.Image = Properties.Resources.train;

        }
        int web = 0;
        int hint = 0; //0:default---1:shopee----2:auto---------3:search
        int voice = 0;//0:default---1:love
        int type = 0;//0:default----1:add
        int size = 0;//0:default-----1:table
        int tag = 0; //0:default-----1:admin-----2:exit---------3:addType-------4:size------5:shopee-----tag:6
        void Send()
        {
            if (txtSend.Text.Trim().Length == 0) return;
            AddOut(txtSend.Text);
            lblStatus.Text = "Typing...";
            timer1.Start();
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            string username = Utils.getUsername(dtgvHistory);
            if (type == 3)
            {
                AddOut(txtSend.Text);
                Utils.addType(txtSend.Text);
                txtSend.Text = string.Empty;
                txt = "Add successfully!";
                AddSend(txt);
                type = 0;
            }
            if (size == 1)
            {
                AddOut(txtSend.Text);
                string s = txtSend.Text;
                txtSend.Text = string.Empty;
                Utils.addSize(dtgvHistory, s);

                AddSend("Bạn có muốn tham khảo thử vài mẫu quần áo không?[Yes/No]");
                Send();
                hint = 1;

                size = 0;
            }
            if (hint == 1)
            {
                if (txtSend.Text.Trim().Length == 0) return;
                else
                {
                    AddOut(txtSend.Text);
                    string ans = txtSend.Text;
                    txtSend.Text = string.Empty;
                    {
                        if (ans.ToLower() == "yes")
                        {
                            AddSend("Shopee đang mở");
                            Shopee();
                            hint = 0;
                        }
                        if (ans.ToLower() == "no")
                        {
                            AddSend("Vâng ạ!");
                            hint = 0;
                        }
                        else
                        {
                            AddSend("Xin lỗi tui chưa hiểu");
                            hint = 0;
                        }

                    }

                }
            }
            if (hint == 2)
            {
                if (txtSend.Text.Trim().Length == 0) return;
                else
                {
                    AddOut(txtSend.Text);
                    string ans = txtSend.Text;
                    txtSend.Clear();
                    {

                        if (ans.ToLower() == "yes")
                        {
                            AddSend("Shopee đang mở");
                            Utils.webbrowser("https://shopee.vn/search?keyword=" + t.Replace(" ", ""));
                            hint = 0;
                        }
                        if (ans.ToLower() == "no")
                        {
                            AddSend("Vâng ạ!");
                            hint = 0;
                        }
                        else if (ans.ToLower() != "yes" || ans.ToLower() != "no")
                        {
                            AddSend("Xin lỗi tui chưa hiểu");
                            hint = 0;
                        }

                    }

                }
            }
            if (hint == 3)
            {

                using (ChatBotEntities db = new ChatBotEntities())
                {
                    if (txtSend.Text.Trim().Length == 0) return;
                    else
                    {
                        AddOut(txtSend.Text);
                        string search = txtSend.Text;
                        //MessageBox.Show(search);
                        Answer ans = con.Answer.Where(p => p.Me == search.ToLower()).SingleOrDefault();

                        {

                            if (db.Topic.Where(p => p.maloai == ans.maloai && p.tenloai == "Clothes").Count() > 0)
                            {
                                AddSend("Một vài mẫu đây nhôn");
                                hint = 2;
                                t = ans.Me;
                                timer1.Start();
                            }

                        }

                    }
                }

            }
            if (web == 1)
            {
                LinkLabel llb = new LinkLabel();
                pnlContainer.Controls.Add(llb);

                llb.Text = "https://www.google.com/search?q=th%E1%BB%9Di+trang+hi%E1%BB%87n+nay";
                AddSend(llb.Text);
            }
            else
            {
                Answer();
                Send();
            }

        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileImg = new OpenFileDialog();
            if (fileImg.ShowDialog() == DialogResult.OK)
            {

                var bubble = new res.theme.ImgOut();
                pnlContainer.Controls.Add(bubble);
                bubble.BringToFront();
                bubble.Dock = DockStyle.Top;
                Image image = new Bitmap(fileImg.FileName);
                Bitmap img = new Bitmap(255, 255);
                Graphics graphic = Graphics.FromImage(img);
                graphic.DrawImage(image, 250, 250);
                graphic.Dispose();

                bubble.BackgroundImage = image;
                lblStatus.Text = "Typing...";
            }
        }

        void reSize(Image image, int w, int h)
        {
            Bitmap img = new Bitmap(w, h);
            Graphics graphic = Graphics.FromImage(img);
            graphic.DrawImage(image, 0, 0, w, h);
            graphic.Dispose();
        }
        void AddSend(String mess)
        {
            var bubble = new res.theme.Incomming();
            pnlContainer.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;

            bubble.Message = mess;
        }
        void AddOut(String mess)
        {
            var bubble = new res.theme.OutGoing();
            pnlContainer.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.Message = mess;
      
        }
        void AddVoice()
        {
            var bubble = new res.theme.voiceIncomming();
            pnlContainer.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;

        }
        private void txtSend_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (type == 3)
                {
                    AddOut(txtSend.Text);
                    Utils.addType(txtSend.Text);
                    txtSend.Text = string.Empty;
                    txt = "Add successfully!";
                    AddSend(txt);
                    type = 0;
                }
                if (size == 1)
                {
                    AddOut(txtSend.Text);
                    string s = txtSend.Text;
                    txtSend.Text = string.Empty;
                    Utils.addSize(dtgvHistory, s);

                    AddSend("Bạn có muốn tham khảo thử vài mẫu quần áo không?[Yes/No]");
                    Send();
                    hint = 1;

                    size = 0;
                }
                if (hint == 1)
                {
                    if (txtSend.Text.Trim().Length == 0) return;
                    else {
                        AddOut(txtSend.Text);
                        string ans = txtSend.Text;
                        txtSend.Text = string.Empty;{
                            if (ans.ToLower() == "yes")
                            {
                                AddSend("Shopee đang mở");
                                Shopee();
                                hint = 0;
                            }
                            if (ans.ToLower() == "no")
                            {
                                AddSend("Vâng ạ!");
                                hint = 0;
                            }
                            else
                            {
                                AddSend("Xin lỗi tui chưa hiểu");
                                hint = 0;
                            }

                        }

                    }
                }
                if (hint == 2)
                {
                    if (txtSend.Text.Trim().Length == 0) return;
                    else
                    {
                        AddOut(txtSend.Text);
                        string ans = txtSend.Text;
                        txtSend.Clear();
                        {

                            if (ans.ToLower() == "yes")
                            {
                                AddSend("Shopee đang mở");
                                Utils.webbrowser("https://shopee.vn/search?keyword="+t.Replace(" ",""));
                                hint = 0;
                            }
                            if (ans.ToLower() == "no")
                            {
                                AddSend("Vâng ạ!");
                                hint = 0;
                            }
                            else if(ans.ToLower() != "yes"|| ans.ToLower() != "no")
                            {
                                AddSend("Xin lỗi tui chưa hiểu");
                                hint = 0;
                            }

                        }

                    }
                }
                if (hint == 3)
                {
                    
                    using (ChatBotEntities db = new ChatBotEntities())
                    {
                        if (txtSend.Text.Trim().Length == 0) return;
                        else
                        {
                            AddOut(txtSend.Text);
                            string search = txtSend.Text;
                            Answer ans = con.Answer.Where(p => p.Me == search.ToLower()).SingleOrDefault();
                            
                            {

                                if (db.Topic.Where(p => p.maloai == ans.maloai && p.tenloai == "Clothes").Count() > 0)
                                {
                                    AddSend("Một vài mẫu đây nhôn");
                                    hint = 2;
                                    t = ans.Me;
                                    timer1.Start();
                                }

                            }

                        }
                    }
                        
                }
                if (web == 1)
                {
                    LinkLabel llb = new LinkLabel();
                    pnlContainer.Controls.Add(llb);

                    llb.Text = "https://www.google.com/search?q=th%E1%BB%9Di+trang+hi%E1%BB%87n+nay";
                    AddSend(llb.Text);
                }
                else
                {
                    Answer();
                    Send();
                }
            }
        }
        void Shopee() {
            var rs = new ProcessStartInfo("chrome.exe");
            rs.Arguments = "https://shopee.vn";         //txt.Replace(" ","")
            Process.Start(rs);
        }
        string txt = null;
        string t = null;
        string clothe = null;
        ChatBotEntities con = new ChatBotEntities();
        string Answer()
        {

            string admin = Utils.getAdmin(dtgvHistory);
            string search = txtSend.Text;

            using (ChatBotEntities db = new ChatBotEntities())
            {

                Answer ans = con.Answer.Where(p => p.Me == search.ToLower()).SingleOrDefault();
                if (con.Answer.Where(p => p.Me==search.ToLower()||search.ToLower().Contains(p.Me)).Count() > 0)
                {

                    /*if (ans.)
                    {
                        txt = null;
                        tag = 0;
                    }*/
                    if (db.Topic.Where(p => p.maloai == ans.maloai && p.tenloai == "Clothes").Count() > 0)
                    {
                        txt = "Một vài mẫu đây nhôn";
                        hint = 2;
                        t = ans.Me;
                        tag = 0;
                        return txt;
                    }
                    if (db.Topic.Where(p => p.maloai == ans.maloai && p.tenloai == "Date").Count() > 0)
                    {
                        txt = "Hôm nay là " + DateTime.Now.ToString("dddd, dd MMMM yyyy");
                        tag = 0;
                        return txt;
                    }
                    if (db.Topic.Where(p => p.maloai == ans.maloai && p.tenloai == "Size").Count() > 0)
                    {
                        txt = "Bạn tham khảo nhé";
                        size = 1;
                        return txt;
                    }
                    if (db.Topic.Where(p => p.maloai == ans.maloai && p.tenloai == "FashionNow").Count() > 0)
                    {

                        txt = "Bạn tham khảo nhé";
                        
                        if(ans.Me == "fashion")
                        {
                            Utils.webbrowser("https://www.google.com/search?q=th%E1%BB%9Di+trang+hi%E1%BB%87n+nay");
                        }
                        else
                        {
                            string link = "https://www.google.com/search?q=" + "thời trang " + ans.Me;
                            Utils.webbrowser(link.Replace(" ", ""));
                        }
                        return txt;
                    }
                    else
                    {
                        txt = Utils.randAns(dtgv, search, txt, tag);
                    }





                }
                if (search.ToLower() == "shopee")
                {
                    txt = "Shopee đã được mở";
                    tag = 5;
                }
                if (search.ToLower() == "kết thúc" || search.ToLower() == "exit")
                {
                    txt = "See ya!";
                    tag = 2;
                }
                if (search.ToLower().Equals("//admin") && admin == "True")
                {
                    txt = "Chủ nhân đã về ;))";
                    tag = 1;
                }
                if (search.ToLower().Equals("//admin") && admin == "False")
                {
                    txt = "Hơ cái gì, hông nhớ, hông có biết nữa..";
                    tag = 0;
                }
                if (search.ToLower() == "//add type" || search.ToLower() == "//addtype" && admin == "True")
                {
                    txt = "Xin nhập tên loại:";
                    type = 1;
                }
                if (search.ToLower() == "//add type" && admin == "False" || search.ToLower() == "//addtype" && admin == "False")
                {
                    txt = "Hơ cái gì, hông nhớ, hông có biết nữa..";
                    type = 0;
                }
                if (search.ToLower() == "i love you" || search.ToLower() == "love" || search.ToLower() == "anh yêu em")
                {
                    txt = "Qao, anh gất đập lọ nhưng em có câu này muốn nói với anh..";
                    voice = 1;
                }
                if (txt == null)
                {
                    txt = "Xin lỗi, tôi chưa rõ! 😟😢😭";
                    tag = 0;
                }
                if (search.ToLower() == "search")
                {
                    txt = "Tên quần áo bạn muốn";
                    hint = 3;
                }
                return txt;
            }
        }
            private void timer1_Tick(object sender, EventArgs e)
            {

                timer1.Stop();
                lblStatus.Text = "Online";
                string t = txtSend.Text;
                txtSend.Text = string.Empty;
                AddSend(Answer());
                if (tag == 1)
                {
                    Form f = new fHome();
                    f.Show();
                }
                if (tag == 2)
                {
                    /*int time = 2000;
                    Task.Delay(time).Wait(); 
                    this.Close();
                    Application.Exit();*/
                    Form f = new fLogin();
                    f.Show();
                    this.Hide();
                }
                if (tag == 5)
                {
                    Shopee();
                    tag = 0;
                }

                if (voice == 1)
                {
                    AddVoice();
                    voice = 0;
                }
                if (size == 1)
                {
                    using (ChatBotEntities db = new ChatBotEntities())
                    {
                        Utils.size_img(pnlContainer);
                        AddSend("Thế bạn mặc size gì ấy nhỉ?");

                        size = 1;
                    }

                }
                if(hint == 2)
                {
                PictureBox pic = new PictureBox();
                using (ChatBotEntities db = new ChatBotEntities())
                    {
                    if(t.ToLower()=="sơ mi"|| t.ToLower() == "áo sơ mi" )
                    {
                        int index = 0;
                        Utils.getImg(pic, pnlContainer, imageList1, index);
                        index = 1;
                        Utils.getImg(pic, pnlContainer, imageList1, index);
                    }
                    if(t.ToLower() =="quần tây")
                    {
                        int index = 2;
                        Utils.getImg(pic, pnlContainer, imageList1, index);
                        index = 3;
                        Utils.getImg(pic, pnlContainer, imageList1, index);
                    }
                        
                        
                        AddSend("Bạn có muốn tham khảo sản phầm này?[Yes/no]");
                        hint = 2;
                }
            }
                txt = null;
            }
            private void fMessage_Shown(object sender, EventArgs e)
            {
            AddSend("Hi, chào cậu! Tui là " + Username.Text + ", Vui lòng chọn một việc bạn muốn! 😊");   //Enviroment.Username
            AddSend("1. Nhấn 'size' để xem thông tin kích cỡ quần áo\n2.Nhấn 'search' để tra cứu quần áo\n3.Nhấn 'Shopee' để truy cập Shopee\n" +
                "");
        }
        }
    }


