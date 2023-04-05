
namespace WinFormChatBot
{
    partial class fMessage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMessage));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnImage = new XanderUI.XUIButton();
            this.btnSend = new XanderUI.XUIButton();
            this.txtSend = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pnlHeader = new Bunifu.UI.WinForms.BunifuPanel();
            this.dtgvHistory = new System.Windows.Forms.DataGridView();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.picStatus = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.Avt = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnImage);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.txtSend);
            this.panel1.Location = new System.Drawing.Point(-3, 574);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 100);
            this.panel1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormDropShadow = true;
            this.bunifuFormDock1.AllowFormResizing = false;
            this.bunifuFormDock1.AllowHidingBottomRegion = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = true;
            this.bunifuFormDock1.ShowDockingIndicators = true;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = false;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = this.pnlHeader;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.Location = new System.Drawing.Point(1, 106);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(627, 462);
            this.pnlContainer.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "somi1.jpg");
            this.imageList1.Images.SetKeyName(1, "somi2.jpg");
            this.imageList1.Images.SetKeyName(2, "quantay1.jpg");
            this.imageList1.Images.SetKeyName(3, "quantay2.jpg");
            // 
            // btnImage
            // 
            this.btnImage.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnImage.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnImage.ButtonImage")));
            this.btnImage.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnImage.ButtonText = "";
            this.btnImage.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnImage.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnImage.CornerRadius = 5;
            this.btnImage.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnImage.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnImage.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnImage.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnImage.Location = new System.Drawing.Point(480, 25);
            this.btnImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(55, 50);
            this.btnImage.TabIndex = 2;
            this.btnImage.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnImage.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSend.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnSend.ButtonImage")));
            this.btnSend.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSend.ButtonText = "";
            this.btnSend.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnSend.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSend.CornerRadius = 5;
            this.btnSend.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSend.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSend.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSend.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSend.Location = new System.Drawing.Point(555, 25);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(52, 50);
            this.btnSend.TabIndex = 1;
            this.btnSend.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnSend.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSend
            // 
            this.txtSend.AcceptsReturn = false;
            this.txtSend.AcceptsTab = false;
            this.txtSend.AnimationSpeed = 200;
            this.txtSend.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSend.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSend.BackColor = System.Drawing.Color.Transparent;
            this.txtSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSend.BackgroundImage")));
            this.txtSend.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtSend.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSend.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtSend.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSend.BorderRadius = 70;
            this.txtSend.BorderThickness = 1;
            this.txtSend.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSend.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSend.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtSend.DefaultText = "";
            this.txtSend.FillColor = System.Drawing.Color.White;
            this.txtSend.HideSelection = true;
            this.txtSend.IconLeft = null;
            this.txtSend.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSend.IconPadding = 10;
            this.txtSend.IconRight = null;
            this.txtSend.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSend.Lines = new string[0];
            this.txtSend.Location = new System.Drawing.Point(3, 2);
            this.txtSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSend.MaxLength = 32767;
            this.txtSend.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSend.Modified = false;
            this.txtSend.Multiline = false;
            this.txtSend.Name = "txtSend";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSend.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSend.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSend.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSend.OnIdleState = stateProperties4;
            this.txtSend.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSend.PasswordChar = '\0';
            this.txtSend.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSend.PlaceholderText = "Enter your message";
            this.txtSend.ReadOnly = false;
            this.txtSend.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSend.SelectedText = "";
            this.txtSend.SelectionLength = 0;
            this.txtSend.SelectionStart = 0;
            this.txtSend.ShortcutsEnabled = true;
            this.txtSend.Size = new System.Drawing.Size(457, 94);
            this.txtSend.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtSend.TabIndex = 0;
            this.txtSend.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSend.TextMarginBottom = 0;
            this.txtSend.TextMarginLeft = 3;
            this.txtSend.TextMarginTop = 0;
            this.txtSend.TextPlaceholder = "Enter your message";
            this.txtSend.UseSystemPasswordChar = false;
            this.txtSend.WordWrap = true;
            this.txtSend.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSend_KeyUp);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.pnlHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHeader.BackgroundImage")));
            this.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHeader.BorderColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BorderRadius = 3;
            this.pnlHeader.BorderThickness = 1;
            this.pnlHeader.Controls.Add(this.dtgvHistory);
            this.pnlHeader.Controls.Add(this.dtgv);
            this.pnlHeader.Controls.Add(this.picStatus);
            this.pnlHeader.Controls.Add(this.Avt);
            this.pnlHeader.Controls.Add(this.lblStatus);
            this.pnlHeader.Controls.Add(this.Username);
            this.pnlHeader.Location = new System.Drawing.Point(-3, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.ShowBorders = true;
            this.pnlHeader.Size = new System.Drawing.Size(629, 100);
            this.pnlHeader.TabIndex = 0;
            // 
            // dtgvHistory
            // 
            this.dtgvHistory.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dtgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHistory.Location = new System.Drawing.Point(4, 28);
            this.dtgvHistory.Name = "dtgvHistory";
            this.dtgvHistory.RowHeadersWidth = 51;
            this.dtgvHistory.RowTemplate.Height = 24;
            this.dtgvHistory.Size = new System.Drawing.Size(1, 1);
            this.dtgvHistory.TabIndex = 6;
            // 
            // dtgv
            // 
            this.dtgv.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Location = new System.Drawing.Point(4, 11);
            this.dtgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgv.Name = "dtgv";
            this.dtgv.RowHeadersWidth = 51;
            this.dtgv.RowTemplate.Height = 24;
            this.dtgv.Size = new System.Drawing.Size(1, 1);
            this.dtgv.TabIndex = 5;
            this.dtgv.Visible = false;
            // 
            // picStatus
            // 
            this.picStatus.AllowFocused = false;
            this.picStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picStatus.AutoSizeHeight = true;
            this.picStatus.BackColor = System.Drawing.Color.Transparent;
            this.picStatus.BorderRadius = 6;
            this.picStatus.Image = ((System.Drawing.Image)(resources.GetObject("picStatus.Image")));
            this.picStatus.IsCircle = true;
            this.picStatus.Location = new System.Drawing.Point(160, 60);
            this.picStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picStatus.Name = "picStatus";
            this.picStatus.Size = new System.Drawing.Size(13, 13);
            this.picStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStatus.TabIndex = 4;
            this.picStatus.TabStop = false;
            this.picStatus.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // Avt
            // 
            this.Avt.AllowFocused = false;
            this.Avt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Avt.AutoSizeHeight = true;
            this.Avt.BorderRadius = 40;
            this.Avt.Image = ((System.Drawing.Image)(resources.GetObject("Avt.Image")));
            this.Avt.IsCircle = true;
            this.Avt.Location = new System.Drawing.Point(40, 11);
            this.Avt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Avt.Name = "Avt";
            this.Avt.Size = new System.Drawing.Size(80, 80);
            this.Avt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Avt.TabIndex = 3;
            this.Avt.TabStop = false;
            this.Avt.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(173, 58);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 17);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Online";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.White;
            this.Username.Location = new System.Drawing.Point(155, 30);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(68, 29);
            this.Username.TabIndex = 1;
            this.Username.Text = "YuMi";
            // 
            // fMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 673);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fMessage";
            this.Text = "fMessage";
            this.Shown += new System.EventHandler(this.fMessage_Shown);
            this.panel1.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel pnlHeader;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUIButton btnSend;
        private Bunifu.UI.WinForms.BunifuTextBox txtSend;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private System.Windows.Forms.Panel pnlContainer;
        private Bunifu.UI.WinForms.BunifuPictureBox Avt;
        private Bunifu.UI.WinForms.BunifuPictureBox picStatus;
        private XanderUI.XUIButton btnImage;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.DataGridView dtgvHistory;
        private System.Windows.Forms.ImageList imageList1;
    }
}