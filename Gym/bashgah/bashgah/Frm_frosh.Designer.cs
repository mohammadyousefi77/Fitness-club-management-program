namespace bashgah
{
    partial class Frm_frosh
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
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.DGaza = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarakoneshdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TarakoneshKind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.DGkala = new System.Windows.Forms.DataGridView();
            this.ID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KalaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mujodi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addBtn = new DevComponents.DotNetBar.ButtonX();
            this.kamBtn = new DevComponents.DotNetBar.ButtonX();
            this.numberkala = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.CBbirthyear = new System.Windows.Forms.ComboBox();
            this.CBbirthmonth = new System.Windows.Forms.ComboBox();
            this.CBbirthday = new System.Windows.Forms.ComboBox();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.BTnsabt = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.TBsearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TBsearchname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel4 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGaza)).BeginInit();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGkala)).BeginInit();
            this.groupPanel3.SuspendLayout();
            this.groupPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.DGaza);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(0, 37);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(308, 163);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "لیست اعضا";
            // 
            // DGaza
            // 
            this.DGaza.AllowUserToAddRows = false;
            this.DGaza.AllowUserToDeleteRows = false;
            this.DGaza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGaza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Tarakoneshdate,
            this.TarakoneshKind,
            this.CustomerID,
            this.CustomerName,
            this.Price});
            this.DGaza.Location = new System.Drawing.Point(3, 3);
            this.DGaza.Name = "DGaza";
            this.DGaza.ReadOnly = true;
            this.DGaza.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGaza.Size = new System.Drawing.Size(296, 136);
            this.DGaza.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ردیف";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Tarakoneshdate
            // 
            this.Tarakoneshdate.DataPropertyName = "Tarakoneshdate";
            this.Tarakoneshdate.HeaderText = "تاریخ تراکنش";
            this.Tarakoneshdate.Name = "Tarakoneshdate";
            this.Tarakoneshdate.ReadOnly = true;
            this.Tarakoneshdate.Visible = false;
            // 
            // TarakoneshKind
            // 
            this.TarakoneshKind.DataPropertyName = "TarakoneshKind";
            this.TarakoneshKind.HeaderText = "نوع تراکنش";
            this.TarakoneshKind.Name = "TarakoneshKind";
            this.TarakoneshKind.ReadOnly = true;
            this.TarakoneshKind.Visible = false;
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "کد عضویت";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "نام عضو";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "قیمت ";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Visible = false;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.DGkala);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(0, 242);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(308, 163);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 1;
            this.groupPanel2.Text = "لیست کالا ها";
            // 
            // DGkala
            // 
            this.DGkala.AllowUserToAddRows = false;
            this.DGkala.AllowUserToDeleteRows = false;
            this.DGkala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGkala.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID2,
            this.KalaName,
            this.Price2,
            this.Mujodi});
            this.DGkala.Location = new System.Drawing.Point(3, 3);
            this.DGkala.Name = "DGkala";
            this.DGkala.ReadOnly = true;
            this.DGkala.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGkala.Size = new System.Drawing.Size(296, 136);
            this.DGkala.TabIndex = 1;
            this.DGkala.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DGkala_MouseClick);
            // 
            // ID2
            // 
            this.ID2.DataPropertyName = "ID";
            this.ID2.HeaderText = "ردیف";
            this.ID2.Name = "ID2";
            this.ID2.ReadOnly = true;
            this.ID2.Visible = false;
            // 
            // KalaName
            // 
            this.KalaName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KalaName.DataPropertyName = "KalaName";
            this.KalaName.HeaderText = "نام کالا";
            this.KalaName.Name = "KalaName";
            this.KalaName.ReadOnly = true;
            // 
            // Price2
            // 
            this.Price2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price2.DataPropertyName = "Price";
            this.Price2.HeaderText = "قیمت کالا";
            this.Price2.Name = "Price2";
            this.Price2.ReadOnly = true;
            // 
            // Mujodi
            // 
            this.Mujodi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mujodi.DataPropertyName = "Mujodi";
            this.Mujodi.HeaderText = "موجودی";
            this.Mujodi.Name = "Mujodi";
            this.Mujodi.ReadOnly = true;
            // 
            // addBtn
            // 
            this.addBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.addBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.addBtn.Image = global::bashgah.Properties.Resources.Actions_list_add_icon;
            this.addBtn.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.addBtn.Location = new System.Drawing.Point(282, 443);
            this.addBtn.Name = "addBtn";
            this.addBtn.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(11);
            this.addBtn.Size = new System.Drawing.Size(25, 29);
            this.addBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.addBtn.TabIndex = 2;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // kamBtn
            // 
            this.kamBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.kamBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.kamBtn.Image = global::bashgah.Properties.Resources._10751;
            this.kamBtn.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.kamBtn.Location = new System.Drawing.Point(252, 443);
            this.kamBtn.Name = "kamBtn";
            this.kamBtn.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(11);
            this.kamBtn.Size = new System.Drawing.Size(24, 29);
            this.kamBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.kamBtn.TabIndex = 3;
            this.kamBtn.Click += new System.EventHandler(this.kamBtn_Click);
            // 
            // numberkala
            // 
            // 
            // 
            // 
            this.numberkala.Border.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.numberkala.Border.Class = "TextBoxBorder";
            this.numberkala.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.numberkala.Location = new System.Drawing.Point(195, 447);
            this.numberkala.Name = "numberkala";
            this.numberkala.PreventEnterBeep = true;
            this.numberkala.Size = new System.Drawing.Size(51, 20);
            this.numberkala.TabIndex = 4;
            this.numberkala.TextChanged += new System.EventHandler(this.numberkala_TextChanged);
            this.numberkala.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberkala_KeyPress);
            // 
            // CBbirthyear
            // 
            this.CBbirthyear.FormattingEnabled = true;
            this.CBbirthyear.Location = new System.Drawing.Point(5, 447);
            this.CBbirthyear.Margin = new System.Windows.Forms.Padding(2);
            this.CBbirthyear.Name = "CBbirthyear";
            this.CBbirthyear.Size = new System.Drawing.Size(59, 21);
            this.CBbirthyear.TabIndex = 9;
            // 
            // CBbirthmonth
            // 
            this.CBbirthmonth.FormattingEnabled = true;
            this.CBbirthmonth.Location = new System.Drawing.Point(68, 447);
            this.CBbirthmonth.Margin = new System.Windows.Forms.Padding(2);
            this.CBbirthmonth.Name = "CBbirthmonth";
            this.CBbirthmonth.Size = new System.Drawing.Size(41, 21);
            this.CBbirthmonth.TabIndex = 8;
            // 
            // CBbirthday
            // 
            this.CBbirthday.FormattingEnabled = true;
            this.CBbirthday.Location = new System.Drawing.Point(113, 447);
            this.CBbirthday.Margin = new System.Windows.Forms.Padding(2);
            this.CBbirthday.Name = "CBbirthday";
            this.CBbirthday.Size = new System.Drawing.Size(35, 21);
            this.CBbirthday.TabIndex = 7;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(152, 449);
            this.labelX2.Margin = new System.Windows.Forms.Padding(2);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(33, 16);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "تاریخ ";
            // 
            // BTnsabt
            // 
            this.BTnsabt.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTnsabt.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTnsabt.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.BTnsabt.Location = new System.Drawing.Point(121, 480);
            this.BTnsabt.Name = "BTnsabt";
            this.BTnsabt.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(11);
            this.BTnsabt.Size = new System.Drawing.Size(54, 29);
            this.BTnsabt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTnsabt.TabIndex = 10;
            this.BTnsabt.Text = "ثبت سفارش";
            this.BTnsabt.Click += new System.EventHandler(this.BTnsabt_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.buttonX1.Location = new System.Drawing.Point(5, 480);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(11);
            this.buttonX1.Size = new System.Drawing.Size(110, 29);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 11;
            this.buttonX1.Text = "مشاهده وضعیت فروش";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.TBsearch);
            this.groupPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel3.Location = new System.Drawing.Point(0, 206);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(308, 30);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel3.TabIndex = 12;
            // 
            // TBsearch
            // 
            // 
            // 
            // 
            this.TBsearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TBsearch.Location = new System.Drawing.Point(-3, 3);
            this.TBsearch.Name = "TBsearch";
            this.TBsearch.PreventEnterBeep = true;
            this.TBsearch.Size = new System.Drawing.Size(293, 14);
            this.TBsearch.TabIndex = 1;
            this.TBsearch.WatermarkText = "جست و جو براساس نام کالا";
            this.TBsearch.TextChanged += new System.EventHandler(this.TBsearch_TextChanged);
            // 
            // TBsearchname
            // 
            // 
            // 
            // 
            this.TBsearchname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TBsearchname.Location = new System.Drawing.Point(-3, 3);
            this.TBsearchname.Name = "TBsearchname";
            this.TBsearchname.PreventEnterBeep = true;
            this.TBsearchname.Size = new System.Drawing.Size(304, 14);
            this.TBsearchname.TabIndex = 1;
            this.TBsearchname.WatermarkText = "جست و جو براساس نام  ونام خانوادگی";
            this.TBsearchname.TextChanged += new System.EventHandler(this.textBoxX1_TextChanged);
            // 
            // groupPanel4
            // 
            this.groupPanel4.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel4.Controls.Add(this.TBsearchname);
            this.groupPanel4.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel4.Location = new System.Drawing.Point(0, 1);
            this.groupPanel4.Name = "groupPanel4";
            this.groupPanel4.Size = new System.Drawing.Size(311, 30);
            // 
            // 
            // 
            this.groupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel4.Style.BackColorGradientAngle = 90;
            this.groupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderBottomWidth = 1;
            this.groupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderLeftWidth = 1;
            this.groupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderRightWidth = 1;
            this.groupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderTopWidth = 1;
            this.groupPanel4.Style.CornerDiameter = 4;
            this.groupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel4.TabIndex = 13;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(237, 422);
            this.labelX1.Margin = new System.Windows.Forms.Padding(2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(67, 16);
            this.labelX1.TabIndex = 14;
            this.labelX1.Text = "تعداد کالا :";
            // 
            // Frm_frosh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 519);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.groupPanel4);
            this.Controls.Add(this.groupPanel3);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.BTnsabt);
            this.Controls.Add(this.CBbirthyear);
            this.Controls.Add(this.CBbirthmonth);
            this.Controls.Add(this.CBbirthday);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.numberkala);
            this.Controls.Add(this.kamBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_frosh";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت فروش";
            this.Load += new System.EventHandler(this.Frm_frosh_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGaza)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGkala)).EndInit();
            this.groupPanel3.ResumeLayout(false);
            this.groupPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.DataGridView DGaza;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarakoneshdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TarakoneshKind;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private System.Windows.Forms.DataGridView DGkala;
        private DevComponents.DotNetBar.ButtonX addBtn;
        private DevComponents.DotNetBar.ButtonX kamBtn;
        private DevComponents.DotNetBar.Controls.TextBoxX numberkala;
        private System.Windows.Forms.ComboBox CBbirthyear;
        private System.Windows.Forms.ComboBox CBbirthmonth;
        private System.Windows.Forms.ComboBox CBbirthday;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX BTnsabt;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.Controls.TextBoxX TBsearch;
        private DevComponents.DotNetBar.Controls.TextBoxX TBsearchname;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mujodi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price2;
        private System.Windows.Forms.DataGridViewTextBoxColumn KalaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID2;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}