namespace bashgah
{
    partial class Frmselectcustomer2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.KK = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.DGCustomer = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OzviatDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EtebarDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Komod2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Picdelete = new System.Windows.Forms.PictureBox();
            this.Picsave = new System.Windows.Forms.PictureBox();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picdelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picsave)).BeginInit();
            this.groupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(317, 28);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(53, 33);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "شماره کمد :";
            // 
            // KK
            // 
            // 
            // 
            // 
            this.KK.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.KK.Location = new System.Drawing.Point(225, 28);
            this.KK.Name = "KK";
            this.KK.Size = new System.Drawing.Size(96, 33);
            this.KK.TabIndex = 1;
            this.KK.Text = "11";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.DGCustomer);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(4, 67);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(366, 232);
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
            this.groupPanel1.TabIndex = 2;
            this.groupPanel1.Text = "اعضای باشگاه";
            // 
            // DGCustomer
            // 
            this.DGCustomer.AllowUserToAddRows = false;
            this.DGCustomer.AllowUserToDeleteRows = false;
            this.DGCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FName,
            this.BirthDate,
            this.OzviatDate,
            this.EtebarDate,
            this.Komod2});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGCustomer.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGCustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DGCustomer.Location = new System.Drawing.Point(3, 3);
            this.DGCustomer.Name = "DGCustomer";
            this.DGCustomer.ReadOnly = true;
            this.DGCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGCustomer.Size = new System.Drawing.Size(354, 205);
            this.DGCustomer.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ردیف";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 50;
            // 
            // FName
            // 
            this.FName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FName.DataPropertyName = "Name";
            this.FName.HeaderText = "نام و نام خانوادگی";
            this.FName.Name = "FName";
            this.FName.ReadOnly = true;
            // 
            // BirthDate
            // 
            this.BirthDate.DataPropertyName = "BirthDate";
            this.BirthDate.HeaderText = "تاریخ";
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.ReadOnly = true;
            this.BirthDate.Visible = false;
            this.BirthDate.Width = 50;
            // 
            // OzviatDate
            // 
            this.OzviatDate.DataPropertyName = "OzviatDate";
            this.OzviatDate.HeaderText = "عضویت";
            this.OzviatDate.Name = "OzviatDate";
            this.OzviatDate.ReadOnly = true;
            this.OzviatDate.Width = 70;
            // 
            // EtebarDate
            // 
            this.EtebarDate.DataPropertyName = "EtebarDate";
            this.EtebarDate.HeaderText = "اعتبار";
            this.EtebarDate.Name = "EtebarDate";
            this.EtebarDate.ReadOnly = true;
            this.EtebarDate.Width = 70;
            // 
            // Komod2
            // 
            this.Komod2.DataPropertyName = "Komod";
            this.Komod2.HeaderText = "Komod";
            this.Komod2.Name = "Komod2";
            this.Komod2.ReadOnly = true;
            this.Komod2.Visible = false;
            this.Komod2.Width = 50;
            // 
            // Picdelete
            // 
            this.Picdelete.BackColor = System.Drawing.Color.Transparent;
            this.Picdelete.Image = global::bashgah.Properties.Resources._1147;
            this.Picdelete.Location = new System.Drawing.Point(3, 3);
            this.Picdelete.Name = "Picdelete";
            this.Picdelete.Size = new System.Drawing.Size(41, 34);
            this.Picdelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picdelete.TabIndex = 2;
            this.Picdelete.TabStop = false;
            this.Picdelete.Click += new System.EventHandler(this.Picdelete_Click);
            // 
            // Picsave
            // 
            this.Picsave.BackColor = System.Drawing.Color.Transparent;
            this.Picsave.Image = global::bashgah.Properties.Resources._0457;
            this.Picsave.Location = new System.Drawing.Point(50, 3);
            this.Picsave.Name = "Picsave";
            this.Picsave.Size = new System.Drawing.Size(41, 34);
            this.Picsave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picsave.TabIndex = 1;
            this.Picsave.TabStop = false;
            this.Picsave.Click += new System.EventHandler(this.Picsave_Click);
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.Picdelete);
            this.groupPanel2.Controls.Add(this.Picsave);
            this.groupPanel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(269, 305);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(101, 49);
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
            this.groupPanel2.TabIndex = 5;
            // 
            // Frmselectcustomer2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(376, 363);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.KK);
            this.Controls.Add(this.labelX1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmselectcustomer2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "انتخاب مشتری";
            this.Load += new System.EventHandler(this.Frmselectcustomer_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picdelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picsave)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX DGCustomer;
        private System.Windows.Forms.PictureBox Picdelete;
        private System.Windows.Forms.PictureBox Picsave;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Komod2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EtebarDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OzviatDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        public DevComponents.DotNetBar.LabelX KK;
    }
}