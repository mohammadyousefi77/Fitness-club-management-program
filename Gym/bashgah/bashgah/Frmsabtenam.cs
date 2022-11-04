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
    public partial class Frmsabtenam : Form
    {
        DbBashgahEntities db = new DbBashgahEntities();
        public Frmsabtenam()
        {
            InitializeComponent();
        }

        private void Frmsabtenam_Load(object sender, EventArgs e)
        {
           for(int i = 1; i <= 31; i++)
            {
                CBbirthday.Items.Add(i.ToString());
            }


            for (int i = 1; i <= 12; i++)
            {
                CBbirthmonth.Items.Add(i.ToString());
            }


            for (int i =1310; i <= 1420; i++)
            {
                CBbirthyear.Items.Add(i.ToString());
            }


            //---------------------------------------

            for (int i = 1; i <= 31; i++)
            {
                CBozviatday.Items.Add(i.ToString());
            }


            for (int i = 1; i <= 12; i++)
            {
                CBozviatmonth.Items.Add(i.ToString());
            }


            for (int i = 1310; i <= 1420; i++)
            {
                CBozviatyear.Items.Add(i.ToString());
            }

            //--------------------------------------------

            for (int i = 1; i <= 31; i++)
            {
                CBetebarday.Items.Add(i.ToString());
            }


            for (int i = 1; i <= 12; i++)
            {
                CBetebarmonth.Items.Add(i.ToString());
            }


            for (int i = 1310; i <= 1420; i++)
            {
                CBetebaryear.Items.Add(i.ToString());
            }
            //--------------------------------
            CBbirthday.SelectedIndex=0;
            CBbirthmonth.SelectedIndex = 0;
            CBbirthyear.SelectedIndex = 0;

            //--------------------------
            CBozviatday.SelectedIndex = 0;
            CBozviatmonth.SelectedIndex = 0;
            CBozviatyear.SelectedIndex = 0;

            //--------------------------------

            CBetebarday.SelectedIndex = 0;
            CBetebarmonth.SelectedIndex = 0;
            CBetebaryear.SelectedIndex = 0;
        }

        private void PicNew_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Today;
            PersianCalendar pc = new PersianCalendar();

            int day = pc.GetDayOfMonth(date);
            CBozviatday.SelectedIndex = day - 1;

            int month = pc.GetMonth(date);
            CBozviatmonth.SelectedIndex = month - 1;

            int year = pc.GetYear(date);
            CBozviatyear.SelectedIndex = year - 1310;


            //--------------------------


            PicUserimage.Load(Application.StartupPath+ "\\Pics\\NoPic.png");
            Groucontent.Enabled = true;
            Grouppanellpic.Enabled = true;
            PicNew.Visible = false;
            PicAdd2.Visible = true;

         


            Picsave.Visible = true;
            Picsave2.Visible = false;

            Picdelete.Visible= true;
            Picenseraf2.Visible = false;

            TBName.Text = " ";
            TBName.Focus();
        }

        private void Picsave_Click(object sender, EventArgs e)
        {
            try {
                if (TBName.Text == " ")
                {
                    MessageBox.Show("لطفا نام و نام خانودگی را وارد کنید");
                }
                else
                {
                    TblUser tb = new TblUser();
                    tb.Name = TBName.Text;
                    tb.BirthDate = CBbirthyear.Text + "/" + CBbirthmonth.Text + "/" + CBbirthday.Text;
                    tb.OzviatDate = CBozviatyear.Text + "/" + CBozviatmonth.Text + "/" + CBozviatday.Text;
                    tb.EtebarDate = CBetebaryear.Text + "/" + CBetebarmonth.Text + "/" + CBetebarday.Text;
                    tb.Komod = "ندارد";

                    db.TblUsers.Add(tb);
                    db.SaveChanges();

                    PicUserimage.Image.Save(Application.StartupPath + "\\Pics\\" + tb.ID.ToString() + ".jpg");

                    barCodeCtrl1.BarCode = tb.ID.ToString();
                    barCodeCtrl1.SaveImage(Application.StartupPath + "\\Pics\\" + tb.ID.ToString() + "_Barcode.jpg");

                    MessageBox.Show("ثبت با مووفقیت انجام شد");


                    Grouppanellpic.Enabled = false;
                    Groucontent.Enabled = false;
                    PicNew.Visible = true;
                    PicAdd2.Visible = false;




                    Picsave.Visible = false;
                    Picsave2.Visible = true;

                    Picdelete.Visible = false;
                    Picenseraf2.Visible = true;


                }
            }
            catch
            {
                MessageBox.Show("خطا در عملیات لطفا دوباره امتحان کنید");
            }
           
        }

        private void Picdelete_Click(object sender, EventArgs e)
        {
            Grouppanellpic.Enabled = false;
            Groucontent.Enabled = false;
            PicNew.Visible = true;
            PicAdd2.Visible = false;




            Picsave.Visible = false;
            Picsave2.Visible = true;

            Picdelete.Visible = false;
            Picenseraf2.Visible = true;

           
        }

        private void setetebar()
        {
            CBetebarday.SelectedIndex = CBozviatday.SelectedIndex;

            if (CBozviatmonth.SelectedIndex==11)
            {
               
                CBetebarmonth.SelectedIndex = 0;
                CBetebaryear.SelectedIndex = CBozviatyear.SelectedIndex+1;
              
            }
            else
            {
                CBetebarmonth.SelectedIndex = CBozviatmonth.SelectedIndex+1;
                CBetebaryear.SelectedIndex = CBozviatyear.SelectedIndex ;
            }
            

        }
        private void CBozviatday_SelectedIndexChanged(object sender, EventArgs e)
        {
            setetebar();
        }

        private void CBozviatmonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            setetebar();
        }

        private void CBozviatyear_SelectedIndexChanged(object sender, EventArgs e)
        {
            setetebar();
        }

        private void Groucontent_Click(object sender, EventArgs e)
        {

        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void labelX3_Click(object sender, EventArgs e)
        {

        }

        private void labelX4_Click(object sender, EventArgs e)
        {

        }

        private void PicBrows_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "(*.*)|*.*";
                op.Title = "تصویر را انتخاب کنید";
                if (op.ShowDialog()==DialogResult.OK)
                {
                    PicUserimage.Load(op.FileName);
                }
            }
            catch
            {
                MessageBox.Show("فایل غیر مجاز است");
            }
        }
    }
}
