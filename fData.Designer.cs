
namespace WinFormChatBot
{
    partial class fData
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fData));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnType = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAnswer = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Avt = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btnAcc = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.grb = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.sortActive = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.sortDeactive = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.sortAll = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dtgvHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.btnType.SuspendLayout();
            this.btnAnswer.SuspendLayout();
            this.btnExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avt)).BeginInit();
            this.btnAcc.SuspendLayout();
            this.grb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToDeleteRows = false;
            this.dtgv.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(8)))), ((int)(((byte)(48)))));
            this.dtgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(8)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(8)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(8)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv.Location = new System.Drawing.Point(255, 178);
            this.dtgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(8)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgv.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(8)))), ((int)(((byte)(48)))));
            this.dtgv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgv.RowTemplate.Height = 24;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(931, 415);
            this.dtgv.TabIndex = 0;
            this.dtgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellContentClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "acti.png");
            this.imageList1.Images.SetKeyName(1, "deactive.png");
            this.imageList1.Images.SetKeyName(2, "trash.png");
            this.imageList1.Images.SetKeyName(3, "admin.png");
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLeft.BackgroundImage")));
            this.pnlLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlLeft.Controls.Add(this.label5);
            this.pnlLeft.Controls.Add(this.btnType);
            this.pnlLeft.Controls.Add(this.btnAnswer);
            this.pnlLeft.Controls.Add(this.btnExit);
            this.pnlLeft.Controls.Add(this.Avt);
            this.pnlLeft.Controls.Add(this.btnAcc);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(193, 598);
            this.pnlLeft.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(42, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "YuMi-chan";
            // 
            // btnType
            // 
            this.btnType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(26)))), ((int)(((byte)(89)))));
            this.btnType.Controls.Add(this.label4);
            this.btnType.Location = new System.Drawing.Point(4, 300);
            this.btnType.Margin = new System.Windows.Forms.Padding(4);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(185, 60);
            this.btnType.TabIndex = 7;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(53, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Type";
            // 
            // btnAnswer
            // 
            this.btnAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(26)))), ((int)(((byte)(89)))));
            this.btnAnswer.Controls.Add(this.label3);
            this.btnAnswer.Location = new System.Drawing.Point(4, 239);
            this.btnAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(185, 60);
            this.btnAnswer.TabIndex = 6;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(53, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Q and A";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(26)))), ((int)(((byte)(89)))));
            this.btnExit.Controls.Add(this.label2);
            this.btnExit.Location = new System.Drawing.Point(4, 361);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(185, 60);
            this.btnExit.TabIndex = 5;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(53, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Exit";
            // 
            // Avt
            // 
            this.Avt.AllowFocused = false;
            this.Avt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Avt.AutoSizeHeight = true;
            this.Avt.BorderRadius = 62;
            this.Avt.Image = ((System.Drawing.Image)(resources.GetObject("Avt.Image")));
            this.Avt.IsCircle = true;
            this.Avt.Location = new System.Drawing.Point(29, 3);
            this.Avt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Avt.Name = "Avt";
            this.Avt.Size = new System.Drawing.Size(125, 125);
            this.Avt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Avt.TabIndex = 4;
            this.Avt.TabStop = false;
            this.Avt.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // btnAcc
            // 
            this.btnAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(64)))), ((int)(((byte)(197)))));
            this.btnAcc.Controls.Add(this.label1);
            this.btnAcc.Location = new System.Drawing.Point(4, 178);
            this.btnAcc.Margin = new System.Windows.Forms.Padding(4);
            this.btnAcc.Name = "btnAcc";
            this.btnAcc.Size = new System.Drawing.Size(185, 60);
            this.btnAcc.TabIndex = 0;
            this.btnAcc.Click += new System.EventHandler(this.btnAcc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(53, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account";
            // 
            // grb
            // 
            this.grb.BorderColor = System.Drawing.Color.LightGray;
            this.grb.BorderRadius = 1;
            this.grb.BorderThickness = 1;
            this.grb.Controls.Add(this.dtgvHistory);
            this.grb.Controls.Add(this.sortActive);
            this.grb.Controls.Add(this.sortDeactive);
            this.grb.Controls.Add(this.sortAll);
            this.grb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grb.ForeColor = System.Drawing.Color.White;
            this.grb.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.grb.LabelIndent = 10;
            this.grb.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.grb.Location = new System.Drawing.Point(211, 12);
            this.grb.Name = "grb";
            this.grb.Size = new System.Drawing.Size(1012, 586);
            this.grb.TabIndex = 3;
            this.grb.TabStop = false;
            this.grb.Text = "Account";
            // 
            // sortActive
            // 
            this.sortActive.AllowAnimations = true;
            this.sortActive.AllowMouseEffects = true;
            this.sortActive.AllowToggling = false;
            this.sortActive.AnimationSpeed = 200;
            this.sortActive.AutoGenerateColors = false;
            this.sortActive.AutoRoundBorders = false;
            this.sortActive.AutoSizeLeftIcon = true;
            this.sortActive.AutoSizeRightIcon = true;
            this.sortActive.BackColor = System.Drawing.Color.Transparent;
            this.sortActive.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(8)))), ((int)(((byte)(48)))));
            this.sortActive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sortActive.BackgroundImage")));
            this.sortActive.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.sortActive.ButtonText = "Active";
            this.sortActive.ButtonTextMarginLeft = 0;
            this.sortActive.ColorContrastOnClick = 45;
            this.sortActive.ColorContrastOnHover = 45;
            this.sortActive.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = false;
            borderEdges1.BottomRight = false;
            borderEdges1.TopLeft = false;
            borderEdges1.TopRight = false;
            this.sortActive.CustomizableEdges = borderEdges1;
            this.sortActive.DialogResult = System.Windows.Forms.DialogResult.None;
            this.sortActive.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.sortActive.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.sortActive.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.sortActive.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.sortActive.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sortActive.ForeColor = System.Drawing.Color.White;
            this.sortActive.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sortActive.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.sortActive.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.sortActive.IconMarginLeft = 11;
            this.sortActive.IconPadding = 10;
            this.sortActive.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sortActive.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.sortActive.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.sortActive.IconSize = 25;
            this.sortActive.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(64)))), ((int)(((byte)(197)))));
            this.sortActive.IdleBorderRadius = 40;
            this.sortActive.IdleBorderThickness = 1;
            this.sortActive.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(8)))), ((int)(((byte)(48)))));
            this.sortActive.IdleIconLeftImage = null;
            this.sortActive.IdleIconRightImage = null;
            this.sortActive.IndicateFocus = false;
            this.sortActive.Location = new System.Drawing.Point(817, 98);
            this.sortActive.Name = "sortActive";
            this.sortActive.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.sortActive.OnDisabledState.BorderRadius = 40;
            this.sortActive.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.sortActive.OnDisabledState.BorderThickness = 1;
            this.sortActive.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.sortActive.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.sortActive.OnDisabledState.IconLeftImage = null;
            this.sortActive.OnDisabledState.IconRightImage = null;
            this.sortActive.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.sortActive.onHoverState.BorderRadius = 40;
            this.sortActive.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.sortActive.onHoverState.BorderThickness = 1;
            this.sortActive.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.sortActive.onHoverState.ForeColor = System.Drawing.Color.White;
            this.sortActive.onHoverState.IconLeftImage = null;
            this.sortActive.onHoverState.IconRightImage = null;
            this.sortActive.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(64)))), ((int)(((byte)(197)))));
            this.sortActive.OnIdleState.BorderRadius = 40;
            this.sortActive.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.sortActive.OnIdleState.BorderThickness = 1;
            this.sortActive.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(8)))), ((int)(((byte)(48)))));
            this.sortActive.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.sortActive.OnIdleState.IconLeftImage = null;
            this.sortActive.OnIdleState.IconRightImage = null;
            this.sortActive.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.sortActive.OnPressedState.BorderRadius = 40;
            this.sortActive.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.sortActive.OnPressedState.BorderThickness = 1;
            this.sortActive.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.sortActive.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.sortActive.OnPressedState.IconLeftImage = null;
            this.sortActive.OnPressedState.IconRightImage = null;
            this.sortActive.Size = new System.Drawing.Size(81, 39);
            this.sortActive.TabIndex = 4;
            this.sortActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sortActive.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.sortActive.TextMarginLeft = 0;
            this.sortActive.TextPadding = new System.Windows.Forms.Padding(0);
            this.sortActive.UseDefaultRadiusAndThickness = true;
            this.sortActive.Click += new System.EventHandler(this.sortActive_Click);
            // 
            // sortDeactive
            // 
            this.sortDeactive.AllowAnimations = true;
            this.sortDeactive.AllowMouseEffects = true;
            this.sortDeactive.AllowToggling = false;
            this.sortDeactive.AnimationSpeed = 200;
            this.sortDeactive.AutoGenerateColors = false;
            this.sortDeactive.AutoRoundBorders = false;
            this.sortDeactive.AutoSizeLeftIcon = true;
            this.sortDeactive.AutoSizeRightIcon = true;
            this.sortDeactive.BackColor = System.Drawing.Color.Transparent;
            this.sortDeactive.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(8)))), ((int)(((byte)(48)))));
            this.sortDeactive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sortDeactive.BackgroundImage")));
            this.sortDeactive.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.sortDeactive.ButtonText = "Deactive";
            this.sortDeactive.ButtonTextMarginLeft = 0;
            this.sortDeactive.ColorContrastOnClick = 45;
            this.sortDeactive.ColorContrastOnHover = 45;
            this.sortDeactive.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = false;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = false;
            borderEdges2.TopRight = true;
            this.sortDeactive.CustomizableEdges = borderEdges2;
            this.sortDeactive.DialogResult = System.Windows.Forms.DialogResult.None;
            this.sortDeactive.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.sortDeactive.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.sortDeactive.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.sortDeactive.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.sortDeactive.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sortDeactive.ForeColor = System.Drawing.Color.White;
            this.sortDeactive.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sortDeactive.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.sortDeactive.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.sortDeactive.IconMarginLeft = 11;
            this.sortDeactive.IconPadding = 10;
            this.sortDeactive.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sortDeactive.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.sortDeactive.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.sortDeactive.IconSize = 25;
            this.sortDeactive.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(64)))), ((int)(((byte)(197)))));
            this.sortDeactive.IdleBorderRadius = 40;
            this.sortDeactive.IdleBorderThickness = 1;
            this.sortDeactive.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(8)))), ((int)(((byte)(48)))));
            this.sortDeactive.IdleIconLeftImage = null;
            this.sortDeactive.IdleIconRightImage = null;
            this.sortDeactive.IndicateFocus = false;
            this.sortDeactive.Location = new System.Drawing.Point(894, 98);
            this.sortDeactive.Name = "sortDeactive";
            this.sortDeactive.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.sortDeactive.OnDisabledState.BorderRadius = 40;
            this.sortDeactive.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.sortDeactive.OnDisabledState.BorderThickness = 1;
            this.sortDeactive.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.sortDeactive.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.sortDeactive.OnDisabledState.IconLeftImage = null;
            this.sortDeactive.OnDisabledState.IconRightImage = null;
            this.sortDeactive.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.sortDeactive.onHoverState.BorderRadius = 40;
            this.sortDeactive.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.sortDeactive.onHoverState.BorderThickness = 1;
            this.sortDeactive.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.sortDeactive.onHoverState.ForeColor = System.Drawing.Color.White;
            this.sortDeactive.onHoverState.IconLeftImage = null;
            this.sortDeactive.onHoverState.IconRightImage = null;
            this.sortDeactive.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(64)))), ((int)(((byte)(197)))));
            this.sortDeactive.OnIdleState.BorderRadius = 40;
            this.sortDeactive.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.sortDeactive.OnIdleState.BorderThickness = 1;
            this.sortDeactive.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(8)))), ((int)(((byte)(48)))));
            this.sortDeactive.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.sortDeactive.OnIdleState.IconLeftImage = null;
            this.sortDeactive.OnIdleState.IconRightImage = null;
            this.sortDeactive.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.sortDeactive.OnPressedState.BorderRadius = 40;
            this.sortDeactive.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.sortDeactive.OnPressedState.BorderThickness = 1;
            this.sortDeactive.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.sortDeactive.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.sortDeactive.OnPressedState.IconLeftImage = null;
            this.sortDeactive.OnPressedState.IconRightImage = null;
            this.sortDeactive.Size = new System.Drawing.Size(81, 39);
            this.sortDeactive.TabIndex = 4;
            this.sortDeactive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sortDeactive.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.sortDeactive.TextMarginLeft = 0;
            this.sortDeactive.TextPadding = new System.Windows.Forms.Padding(0);
            this.sortDeactive.UseDefaultRadiusAndThickness = true;
            this.sortDeactive.Click += new System.EventHandler(this.sortDeactive_Click);
            // 
            // sortAll
            // 
            this.sortAll.AllowAnimations = true;
            this.sortAll.AllowMouseEffects = true;
            this.sortAll.AllowToggling = false;
            this.sortAll.AnimationSpeed = 200;
            this.sortAll.AutoGenerateColors = false;
            this.sortAll.AutoRoundBorders = false;
            this.sortAll.AutoSizeLeftIcon = true;
            this.sortAll.AutoSizeRightIcon = true;
            this.sortAll.BackColor = System.Drawing.Color.Transparent;
            this.sortAll.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(8)))), ((int)(((byte)(48)))));
            this.sortAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sortAll.BackgroundImage")));
            this.sortAll.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.sortAll.ButtonText = "All";
            this.sortAll.ButtonTextMarginLeft = 0;
            this.sortAll.ColorContrastOnClick = 45;
            this.sortAll.ColorContrastOnHover = 45;
            this.sortAll.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = false;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = false;
            this.sortAll.CustomizableEdges = borderEdges3;
            this.sortAll.DialogResult = System.Windows.Forms.DialogResult.None;
            this.sortAll.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.sortAll.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.sortAll.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.sortAll.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.sortAll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sortAll.ForeColor = System.Drawing.Color.White;
            this.sortAll.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sortAll.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.sortAll.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.sortAll.IconMarginLeft = 11;
            this.sortAll.IconPadding = 10;
            this.sortAll.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sortAll.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.sortAll.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.sortAll.IconSize = 25;
            this.sortAll.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(64)))), ((int)(((byte)(197)))));
            this.sortAll.IdleBorderRadius = 40;
            this.sortAll.IdleBorderThickness = 1;
            this.sortAll.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(8)))), ((int)(((byte)(48)))));
            this.sortAll.IdleIconLeftImage = null;
            this.sortAll.IdleIconRightImage = null;
            this.sortAll.IndicateFocus = false;
            this.sortAll.Location = new System.Drawing.Point(743, 98);
            this.sortAll.Name = "sortAll";
            this.sortAll.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.sortAll.OnDisabledState.BorderRadius = 40;
            this.sortAll.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.sortAll.OnDisabledState.BorderThickness = 1;
            this.sortAll.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.sortAll.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.sortAll.OnDisabledState.IconLeftImage = null;
            this.sortAll.OnDisabledState.IconRightImage = null;
            this.sortAll.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.sortAll.onHoverState.BorderRadius = 40;
            this.sortAll.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.sortAll.onHoverState.BorderThickness = 1;
            this.sortAll.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.sortAll.onHoverState.ForeColor = System.Drawing.Color.White;
            this.sortAll.onHoverState.IconLeftImage = null;
            this.sortAll.onHoverState.IconRightImage = null;
            this.sortAll.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(64)))), ((int)(((byte)(197)))));
            this.sortAll.OnIdleState.BorderRadius = 40;
            this.sortAll.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.sortAll.OnIdleState.BorderThickness = 1;
            this.sortAll.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(8)))), ((int)(((byte)(48)))));
            this.sortAll.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.sortAll.OnIdleState.IconLeftImage = null;
            this.sortAll.OnIdleState.IconRightImage = null;
            this.sortAll.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.sortAll.OnPressedState.BorderRadius = 40;
            this.sortAll.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.sortAll.OnPressedState.BorderThickness = 1;
            this.sortAll.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.sortAll.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.sortAll.OnPressedState.IconLeftImage = null;
            this.sortAll.OnPressedState.IconRightImage = null;
            this.sortAll.Size = new System.Drawing.Size(81, 39);
            this.sortAll.TabIndex = 4;
            this.sortAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sortAll.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.sortAll.TextMarginLeft = 0;
            this.sortAll.TextPadding = new System.Windows.Forms.Padding(0);
            this.sortAll.UseDefaultRadiusAndThickness = true;
            this.sortAll.Click += new System.EventHandler(this.sortAll_Click);
            // 
            // dtgvHistory
            // 
            this.dtgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHistory.Location = new System.Drawing.Point(140, 68);
            this.dtgvHistory.Name = "dtgvHistory";
            this.dtgvHistory.RowHeadersWidth = 51;
            this.dtgvHistory.RowTemplate.Height = 24;
            this.dtgvHistory.Size = new System.Drawing.Size(1, 1);
            this.dtgvHistory.TabIndex = 5;
            // 
            // fData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(8)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1255, 598);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.grb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fData";
            this.Text = "fData";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fData_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.btnType.ResumeLayout(false);
            this.btnType.PerformLayout();
            this.btnAnswer.ResumeLayout(false);
            this.btnAnswer.PerformLayout();
            this.btnExit.ResumeLayout(false);
            this.btnExit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avt)).EndInit();
            this.btnAcc.ResumeLayout(false);
            this.btnAcc.PerformLayout();
            this.grb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel btnExit;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuPictureBox Avt;
        private System.Windows.Forms.Panel btnAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel btnType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel btnAnswer;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuGroupBox grb;
        private System.Windows.Forms.Label label5;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton sortAll;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton sortDeactive;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton sortActive;
        private System.Windows.Forms.DataGridView dtgvHistory;
    }
}