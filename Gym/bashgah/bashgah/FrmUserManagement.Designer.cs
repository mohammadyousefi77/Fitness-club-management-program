namespace bashgah
{
    partial class FrmUserManagement
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
            this.DGlist = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etebar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OzviatDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Komod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.TBsearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.BTprintcard = new DevComponents.DotNetBar.ButtonX();
            this.BTpay = new DevComponents.DotNetBar.ButtonX();
            this.BTdelete = new DevComponents.DotNetBar.ButtonX();
            this.BTedite = new DevComponents.DotNetBar.ButtonX();
            this.BTcontent = new DevComponents.DotNetBar.ButtonX();
            this.stiReport1 = new Stimulsoft.Report.StiReport();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGlist)).BeginInit();
            this.groupPanel2.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.DGlist);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(9, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(357, 239);
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
            // DGlist
            // 
            this.DGlist.AllowUserToAddRows = false;
            this.DGlist.AllowUserToDeleteRows = false;
            this.DGlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.username,
            this.etebar,
            this.BirthDate,
            this.OzviatDate,
            this.Komod});
            this.DGlist.Location = new System.Drawing.Point(3, 3);
            this.DGlist.Name = "DGlist";
            this.DGlist.ReadOnly = true;
            this.DGlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGlist.Size = new System.Drawing.Size(345, 194);
            this.DGlist.TabIndex = 8;
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "کد عضوبت ";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // username
            // 
            this.username.DataPropertyName = "Name";
            this.username.HeaderText = "نام و نام خانوادگی";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // etebar
            // 
            this.etebar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.etebar.DataPropertyName = "EtebarDate";
            this.etebar.HeaderText = "تاریخ اعتبار عضویت";
            this.etebar.Name = "etebar";
            this.etebar.ReadOnly = true;
            // 
            // BirthDate
            // 
            this.BirthDate.DataPropertyName = "BirthDate";
            this.BirthDate.HeaderText = "Column1";
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.ReadOnly = true;
            this.BirthDate.Visible = false;
            // 
            // OzviatDate
            // 
            this.OzviatDate.DataPropertyName = "OzviatDate";
            this.OzviatDate.HeaderText = "Column2";
            this.OzviatDate.Name = "OzviatDate";
            this.OzviatDate.ReadOnly = true;
            this.OzviatDate.Visible = false;
            // 
            // Komod
            // 
            this.Komod.DataPropertyName = "Komod";
            this.Komod.HeaderText = "Column3";
            this.Komod.Name = "Komod";
            this.Komod.ReadOnly = true;
            this.Komod.Visible = false;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.TBsearch);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(9, 245);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(357, 48);
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
            this.groupPanel2.Click += new System.EventHandler(this.groupPanel2_Click);
            // 
            // TBsearch
            // 
            // 
            // 
            // 
            this.TBsearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TBsearch.Location = new System.Drawing.Point(3, 11);
            this.TBsearch.Name = "TBsearch";
            this.TBsearch.PreventEnterBeep = true;
            this.TBsearch.Size = new System.Drawing.Size(348, 18);
            this.TBsearch.TabIndex = 0;
            this.TBsearch.WatermarkText = "جست و جو براساس نام و نام خانوادگی";
            this.TBsearch.TextChanged += new System.EventHandler(this.TBsearch_TextChanged);
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.BTprintcard);
            this.groupPanel3.Controls.Add(this.BTpay);
            this.groupPanel3.Controls.Add(this.BTdelete);
            this.groupPanel3.Controls.Add(this.BTedite);
            this.groupPanel3.Controls.Add(this.BTcontent);
            this.groupPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel3.Location = new System.Drawing.Point(9, 299);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(357, 68);
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
            this.groupPanel3.TabIndex = 2;
            // 
            // BTprintcard
            // 
            this.BTprintcard.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTprintcard.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTprintcard.Location = new System.Drawing.Point(3, 32);
            this.BTprintcard.Name = "BTprintcard";
            this.BTprintcard.Size = new System.Drawing.Size(345, 23);
            this.BTprintcard.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTprintcard.TabIndex = 5;
            this.BTprintcard.Text = "چاپ کارت عضویت";
            this.BTprintcard.Click += new System.EventHandler(this.BTprintcard_Click);
            // 
            // BTpay
            // 
            this.BTpay.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTpay.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTpay.Location = new System.Drawing.Point(3, 3);
            this.BTpay.Name = "BTpay";
            this.BTpay.Size = new System.Drawing.Size(75, 23);
            this.BTpay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTpay.TabIndex = 4;
            this.BTpay.Text = "پرداخت شهریه";
            this.BTpay.Click += new System.EventHandler(this.BTpay_Click);
            // 
            // BTdelete
            // 
            this.BTdelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTdelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTdelete.Location = new System.Drawing.Point(84, 3);
            this.BTdelete.Name = "BTdelete";
            this.BTdelete.Size = new System.Drawing.Size(75, 23);
            this.BTdelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTdelete.TabIndex = 3;
            this.BTdelete.Text = "حذف عضو";
            this.BTdelete.Click += new System.EventHandler(this.BTdelete_Click);
            // 
            // BTedite
            // 
            this.BTedite.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTedite.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTedite.Location = new System.Drawing.Point(165, 3);
            this.BTedite.Name = "BTedite";
            this.BTedite.Size = new System.Drawing.Size(75, 23);
            this.BTedite.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTedite.TabIndex = 2;
            this.BTedite.Text = "ویرایش عضو";
            this.BTedite.Click += new System.EventHandler(this.BTedite_Click);
            // 
            // BTcontent
            // 
            this.BTcontent.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTcontent.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTcontent.Location = new System.Drawing.Point(246, 3);
            this.BTcontent.Name = "BTcontent";
            this.BTcontent.Size = new System.Drawing.Size(105, 23);
            this.BTcontent.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTcontent.TabIndex = 1;
            this.BTcontent.Text = "مشاهده مشحصات کامل";
            this.BTcontent.Click += new System.EventHandler(this.BTcontent_Click);
            // 
            // stiReport1
            // 
            this.stiReport1.CookieContainer = null;
            this.stiReport1.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport1.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReport1.ReportAlias = "Report";
            this.stiReport1.ReportGuid = "776c1bc449a24c2aa77921c5e1d7342b";
            this.stiReport1.ReportName = "Report";
            this.stiReport1.ReportSource = null;
            this.stiReport1.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.stiReport1.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport1.UseProgressInThread = false;
            // 
            // FrmUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(371, 372);
            this.Controls.Add(this.groupPanel3);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.Font = new System.Drawing.Font("B Yekan", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUserManagement";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت اعضای باشگاه";
            this.Load += new System.EventHandler(this.FrmUserManagement_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGlist)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.DataGridView DGlist;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.TextBoxX TBsearch;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.ButtonX BTpay;
        private DevComponents.DotNetBar.ButtonX BTdelete;
        private DevComponents.DotNetBar.ButtonX BTedite;
        private DevComponents.DotNetBar.ButtonX BTcontent;
        private DevComponents.DotNetBar.ButtonX BTprintcard;
        private System.Windows.Forms.DataGridViewTextBoxColumn OzviatDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Komod;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn etebar;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private Stimulsoft.Report.StiReport stiReport1;
    }
}