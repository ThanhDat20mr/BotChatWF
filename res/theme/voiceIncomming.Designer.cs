
namespace WinFormChatBot.res.theme
{
    partial class voiceIncomming
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(voiceIncomming));
            this.lblTime = new System.Windows.Forms.Label();
            this.Avt = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.txtBot = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnPlay = new XanderUI.XUIButton();
            ((System.ComponentModel.ISupportInitialize)(this.Avt)).BeginInit();
            this.txtBot.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(219, 76);
            this.lblTime.MaximumSize = new System.Drawing.Size(300, 999);
            this.lblTime.MinimumSize = new System.Drawing.Size(0, 34);
            this.lblTime.Name = "lblTime";
            this.lblTime.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lblTime.Size = new System.Drawing.Size(50, 34);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Hello";
            // 
            // Avt
            // 
            this.Avt.AllowFocused = false;
            this.Avt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Avt.AutoSizeHeight = true;
            this.Avt.BorderRadius = 28;
            this.Avt.Image = ((System.Drawing.Image)(resources.GetObject("Avt.Image")));
            this.Avt.IsCircle = true;
            this.Avt.Location = new System.Drawing.Point(45, 26);
            this.Avt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Avt.Name = "Avt";
            this.Avt.Size = new System.Drawing.Size(56, 56);
            this.Avt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Avt.TabIndex = 7;
            this.Avt.TabStop = false;
            this.Avt.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // txtBot
            // 
            this.txtBot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtBot.BackgroundColor = System.Drawing.Color.Blue;
            this.txtBot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBot.BackgroundImage")));
            this.txtBot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBot.BorderColor = System.Drawing.Color.Transparent;
            this.txtBot.BorderRadius = 40;
            this.txtBot.BorderThickness = 1;
            this.txtBot.Controls.Add(this.btnPlay);
            this.txtBot.Location = new System.Drawing.Point(107, 38);
            this.txtBot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBot.MaximumSize = new System.Drawing.Size(400, 1231);
            this.txtBot.MinimumSize = new System.Drawing.Size(20, 46);
            this.txtBot.Name = "txtBot";
            this.txtBot.ShowBorders = true;
            this.txtBot.Size = new System.Drawing.Size(107, 46);
            this.txtBot.TabIndex = 6;
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnPlay.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.ButtonImage")));
            this.btnPlay.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnPlay.ButtonText = "";
            this.btnPlay.ClickBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.ClickTextColor = System.Drawing.Color.Transparent;
            this.btnPlay.CornerRadius = 40;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnPlay.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPlay.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnPlay.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnPlay.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnPlay.Location = new System.Drawing.Point(36, 7);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(49, 32);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btnPlay.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // voiceIncomming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.Avt);
            this.Controls.Add(this.txtBot);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "voiceIncomming";
            this.Size = new System.Drawing.Size(700, 154);
            ((System.ComponentModel.ISupportInitialize)(this.Avt)).EndInit();
            this.txtBot.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private Bunifu.UI.WinForms.BunifuPictureBox Avt;
        private Bunifu.UI.WinForms.BunifuPanel txtBot;
        private XanderUI.XUIButton btnPlay;
    }
}
