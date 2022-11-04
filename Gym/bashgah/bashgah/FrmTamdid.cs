using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace bashgah
{
    public partial class FrmTamdid : Form
    {
        public DbBashgahEntities db = new DbBashgahEntities();
        public int code = 0;
        public string Sname = "";
        public FrmTamdid()
        {
            InitializeComponent();
        }

        private void BTpayshahrieh_Click(object sender, EventArgs e)
        {
            var query = (from a in db.TblUsers where a.ID == code select a).SingleOrDefault();
            query.EtebarDate = CBetebaryear.Text + "/" + CBetebarmonth.Text + "/" + CBetebarday.Text;
           
            db.SaveChanges();

            //======================
            tarakoneshTBl tb =  new tarakoneshTBl();
            DateTime today = DateTime.Now;

            PersianCalendar pc = new PersianCalendar();

            string dat = pc.GetYear(today).ToString("0000")+"/" + pc.GetMonth(today).ToString("00") + "/" + pc.GetDayOfMonth(today).ToString("00");
            tb.Tarakoneshdate = dat;
            tb.TarakoneshKind = "پرداخت";
            tb.Price = TBmablagh.Text;
            tb.CustomerID = code.ToString();
            tb.CustomerName = Sname;
            db.tarakoneshTBls.Add(tb);
            db.SaveChanges();

            MessageBox.Show("پرداخت شهریه با مووفقیت انجام شد");

            



            //--------------------------------
            Properties.Settings.Default.Shahrieh = TBmablagh.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void FrmTamdid_Load(object sender, EventArgs e)
        {
            TBmablagh.Text = Properties.Settings.Default.Shahrieh.ToString();
        }

        private void TBmablagh_KeyPress(object sender, KeyPressEventArgs e)
        {
        


            if (Convert.ToInt32(e.KeyChar) >= 48 && Convert.ToInt32(e.KeyChar) <= 57 || Convert.ToInt32(e.KeyChar) >= 1776 && Convert.ToInt32(e.KeyChar) <= 1785 || Convert.ToInt32(e.KeyChar) == 8)
            {
                
            }
            else
            {
                e.KeyChar = Convert.ToChar(Keys.None);
            }
        }

        private void TBmablagh_TextChanged(object sender, EventArgs e)
        {
        
            Class1.ChangeName(TBmablagh);
           
        }
    }
}
