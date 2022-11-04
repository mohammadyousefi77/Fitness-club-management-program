namespace bashgah
{
    partial class FrmTamdid
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
            this.BTpayshahrieh = new DevComponents.DotNetBar.ButtonX();
            this.TBmablagh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.CBetebaryear = new System.Windows.Forms.ComboBox();
            this.CBetebarmonth = new System.Windows.Forms.ComboBox();
            this.CBetebarday = new System.Windows.Forms.ComboBox();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // BTpayshahrieh
            // 
            this.BTpayshahrieh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTpayshahrieh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTpayshahrieh.Location = new System.Drawing.Point(12, 103);
            this.BTpayshahrieh.Name = "BTpayshahrieh";
            this.BTpayshahrieh.Size = new System.Drawing.Size(152, 21);
            this.BTpayshahrieh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTpayshahrieh.TabIndex = 5;
            this.BTpayshahrieh.Text = "پرداخت شهریه";
            this.BTpayshahrieh.Click += new System.EventHandler(this.BTpayshahrieh_Click);
            // 
            // TBmablagh
            // 
            // 
            // 
            // 
            this.TBmablagh.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TBmablagh.Location = new System.Drawing.Point(12, 12);
            this.TBmablagh.Name = "TBmablagh";
            this.TBmablagh.PreventEnterBeep = true;
            this.TBmablagh.Size = new System.Drawing.Size(152, 20);
            this.TBmablagh.TabIndex = 6;
            this.TBmablagh.Text = "0";
            this.TBmablagh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBmablagh.WatermarkText = "مبلغ شهریه";
            this.TBmablagh.TextChanged += new System.EventHandler(this.TBmablagh_TextChanged);
            this.TBmablagh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBmablagh_KeyPress);
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX7.Location = new System.Drawing.Point(170, 12);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(53, 20);
            this.labelX7.TabIndex = 7;
            this.labelX7.Text = "مبلغ :";
            this.labelX7.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // CBetebaryear
            // 
            this.CBetebaryear.FormattingEnabled = true;
            this.CBetebaryear.Location = new System.Drawing.Point(11, 56);
            this.CBetebaryear.Margin = new System.Windows.Forms.Padding(2);
            this.CBetebaryear.Name = "CBetebaryear";
            this.CBetebaryear.Size = new System.Drawing.Size(59, 26);
            this.CBetebaryear.TabIndex = 17;
            // 
            // CBetebarmonth
            // 
            this.CBetebarmonth.FormattingEnabled = true;
            this.CBetebarmonth.Location = new System.Drawing.Point(74, 56);
            this.CBetebarmonth.Margin = new System.Windows.Forms.Padding(2);
            this.CBetebarmonth.Name = "CBetebarmonth";
            this.CBetebarmonth.Size = new System.Drawing.Size(41, 26);
            this.CBetebarmonth.TabIndex = 16;
            // 
            // CBetebarday
            // 
            this.CBetebarday.FormattingEnabled = true;
            this.CBetebarday.Location = new System.Drawing.Point(119, 56);
            this.CBetebarday.Margin = new System.Windows.Forms.Padding(2);
            this.CBetebarday.Name = "CBetebarday";
            this.CBetebarday.Size = new System.Drawing.Size(45, 26);
            this.CBetebarday.TabIndex = 15;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(158, 59);
            this.labelX4.Margin = new System.Windows.Forms.Padding(2);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(65, 23);
            this.labelX4.TabIndex = 14;
            this.labelX4.Text = "تاریخ اعتبار :";
            // 
            // FrmTamdid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 133);
            this.Controls.Add(this.CBetebaryear);
            this.Controls.Add(this.CBetebarmonth);
            this.Controls.Add(this.CBetebarday);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.TBmablagh);
            this.Controls.Add(this.BTpayshahrieh);
            this.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTamdid";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پرداخت شهریه";
            this.Load += new System.EventHandler(this.FrmTamdid_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX BTpayshahrieh;
        public DevComponents.DotNetBar.Controls.TextBoxX TBmablagh;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX4;
        public System.Windows.Forms.ComboBox CBetebarday;
        public System.Windows.Forms.ComboBox CBetebarmonth;
        public System.Windows.Forms.ComboBox CBetebaryear;
    }
}