
namespace WinFormChatBot.res.theme
{
    partial class Incomming
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Incomming));
            this.txtBot = new Bunifu.UI.WinForms.BunifuPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.Avt = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.llb = new System.Windows.Forms.LinkLabel();
            this.txtBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avt)).BeginInit();
            this.SuspendLayout();
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
            this.txtBot.Controls.Add(this.llb);
            this.txtBot.Controls.Add(this.label1);
            this.txtBot.Location = new System.Drawing.Point(100, 36);
            this.txtBot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBot.MaximumSize = new System.Drawing.Size(400, 1231);
            this.txtBot.MinimumSize = new System.Drawing.Size(20, 46);
            this.txtBot.Name = "txtBot";
            this.txtBot.ShowBorders = true;
            this.txtBot.Size = new System.Drawing.Size(107, 46);
            this.txtBot.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.MaximumSize = new System.Drawing.Size(349, 999);
            this.label1.MinimumSize = new System.Drawing.Size(0, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(212, 74);
            this.lblTime.MaximumSize = new System.Drawing.Size(300, 999);
            this.lblTime.MinimumSize = new System.Drawing.Size(0, 34);
            this.lblTime.Name = "lblTime";
            this.lblTime.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lblTime.Size = new System.Drawing.Size(50, 34);
            this.lblTime.TabIndex = 5;
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
            this.Avt.Location = new System.Drawing.Point(16, 33);
            this.Avt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Avt.Name = "Avt";
            this.Avt.Size = new System.Drawing.Size(56, 56);
            this.Avt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Avt.TabIndex = 4;
            this.Avt.TabStop = false;
            this.Avt.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // llb
            // 
            this.llb.AutoSize = true;
            this.llb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb.LinkColor = System.Drawing.Color.White;
            this.llb.Location = new System.Drawing.Point(12, 15);
            this.llb.Name = "llb";
            this.llb.Size = new System.Drawing.Size(84, 20);
            this.llb.TabIndex = 6;
            this.llb.TabStop = true;
            this.llb.Text = "linkLabel1";
            this.llb.Visible = false;
            // 
            // Incomming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.Avt);
            this.Controls.Add(this.txtBot);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Incomming";
            this.Size = new System.Drawing.Size(845, 330);
            this.txtBot.ResumeLayout(false);
            this.txtBot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPanel txtBot;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuPictureBox Avt;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.LinkLabel llb;
    }
}
