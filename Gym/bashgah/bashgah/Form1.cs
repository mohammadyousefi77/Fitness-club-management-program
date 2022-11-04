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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ثبتنامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmsabtenam frm = new Frmsabtenam();
            frm.ShowDialog();
        }

        private void مدیریتاعضاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUserManagement fm = new FrmUserManagement();
            fm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            analogClockControl1.Value = System.DateTime.Now;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            analogClockControl1.Value = System.DateTime.Now;

            DateTime to= DateTime.Now;
            PersianCalendar pc = new PersianCalendar();

            LByears.Text = pc.GetYear(to).ToString("0000");

            LBmonth.Text = pc.GetMonth(to).ToString("00");
            day.Text = pc.GetDayOfMonth(to).ToString("00");

            switch (pc.GetDayOfWeek(to).ToString())
            {
                case "Saturday":
                    {
                        LBDay.Text = "شنبه";
                        break;
                    }
                case "Sunday":
                    {
                        LBDay.Text = "یکشنبه";
                        break;
                    }
                case "Monday":
                    {
                        LBDay.Text = "دو شنبه";
                        break;
                    }
                case "Tuesday":
                    LBDay.Text = "سه شنبه";
                    break;

                case "Wednesday":
                    {
                        LBDay.Text = "چهارشنبه";
                        break;
                    }
                case "Thursday":
                    {
                        LBDay.Text = "پنج شنبه";
                        break;
                    }

                case "Friday":
                    {
                        LBDay.Text = "جمعه";
                        break;
                    }
            }



        }

        private void بررسیسوابقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmsavabegh sv = new Frmsavabegh();
            sv.ShowDialog();
        }

        private void خروجازنرمافزارToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result=   MessageBox.Show(" میخواهید از برنامه خارج شوید؟","هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ثبتکالایجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFrooshgah fr = new FrmFrooshgah();
            fr.ShowDialog();
        }

        private void ویرایشوحذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmmodiriatfroosh md = new Frmmodiriatfroosh();
            md.ShowDialog();
        }

        private void فروشکالاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_frosh fm = new Frm_frosh();
            fm.ShowDialog();
        }

        private void مدیریتکمدهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmmodiriatKomod km = new FrmmodiriatKomod();
            km.ShowDialog();
        }

        private void دربارهبرنامهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmaboutprogram ab = new Frmaboutprogram();
            ab.ShowDialog();
        }

        private void مدیریتفروشگاهToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
