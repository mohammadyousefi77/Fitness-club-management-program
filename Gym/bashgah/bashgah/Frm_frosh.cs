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
    public partial class Frm_frosh : Form
    {
        DbBashgahEntities db1 = new DbBashgahEntities();
        int tedad = 0;
        public Frm_frosh()
        {
            InitializeComponent();
        }


        private void Frm_frosh_Load(object sender, EventArgs e)
        {
            DGaza.DataSource = db1.tarakoneshTBls.ToList();
            DGkala.DataSource = db1.Tblfrooshgahs.ToList();


            DateTime today = DateTime.Now;

            PersianCalendar pc = new PersianCalendar();

            string datyear = pc.GetYear(today).ToString("0000");
            string datmonth =     pc.GetMonth(today).ToString("00");
               string datday = pc.GetDayOfMonth(today).ToString("00");

            for (int i = 1; i <= 31; i++)
            {
                CBbirthday.Items.Add(i.ToString());
            }


            for (int i = 1; i <= 12; i++)
            {
                CBbirthmonth.Items.Add(i.ToString());
            }


            for (int i = 1400; i <= 1520; i++)
            {
                CBbirthyear.Items.Add(i.ToString());
            }
            CBbirthyear.SelectedIndex = Convert.ToInt32(datyear) - 1400;
            CBbirthmonth.SelectedIndex = Convert.ToInt32(datmonth) - 1;
            CBbirthday.SelectedIndex = Convert.ToInt32(datday) - 1;

        }

        private void search()
        {
            //int id = Convert.ToInt32(textBoxX1.Text);
            var sr = db1.tarakoneshTBls.Where(n => n.CustomerName.Contains(TBsearchname.Text));

            DGaza.DataSource = sr.ToList();
        }
        private void search2()
        {
            //int id = Convert.ToInt32(textBoxX1.Text);
            var sr = db1.Tblfrooshgahs.Where(n => n.KalaName.Contains(TBsearch.Text));

            DGkala.DataSource = sr.ToList();
        }


        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            search();

        }

        private void TBsearch_TextChanged(object sender, EventArgs e)
        {
            search2();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (DGkala.RowCount == 0)
            {
                MessageBox.Show("کالایی انتخاب نشده");
                return;
            }

            int m2 = 0;
            int m = Convert.ToInt32(DGkala.CurrentRow.Cells["Mujodi"].Value.ToString());

            if (tedad >= m || m == 0)
            {
                MessageBox.Show("  تعداد کالای انتخاب شده بیشتر از موجودی انبار است");
                numberkala.Text = "";
                tedad = 0;
            }
            else
            {
                if (numberkala.Text == "")
                {
                    tedad = tedad + 1;
                    numberkala.Text = tedad.ToString();
                    // numberkala.Text = "1";//   اینم خط هم ب تنهایی کار میکنه و میتونه به جای دو خط کد بالا استفاده شه
                }
                else
                {
                    m2 = Convert.ToInt32(numberkala.Text);
                    tedad = m2;
                    tedad = tedad + 1;
                    numberkala.Text = tedad.ToString();
                }
            }
        }

        private void kamBtn_Click(object sender, EventArgs e)
        {
            int m = Convert.ToInt32(DGkala.CurrentRow.Cells["Mujodi"].Value.ToString());
            if (DGkala.RowCount == 0)
            {
                MessageBox.Show("کالایی انتخاب نشده");
                return;
            }
          
            if (m == 0)
            {
                MessageBox.Show("کالا موردنظر موجود نمی باشد");
                return;
            }
            if (tedad == 0)
            {

            }

            else
            {
                
               
                    tedad = tedad - 1;

                    numberkala.Text = tedad.ToString();
                
               
            }


        }

        private void numberkala_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (DGkala.CurrentRow.Cells["Mujodi"].Value.ToString()=="0")
            //{
               
            //}
            //else {
            //    if (Convert.ToInt32(e.KeyChar) >= 48 && Convert.ToInt32(e.KeyChar) <= 57 || Convert.ToInt32(e.KeyChar) >= 1776 && Convert.ToInt32(e.KeyChar) <= 1785 || Convert.ToInt32(e.KeyChar) == 8)
            //    {

            //    }
            //    else
            //    {
            //        e.KeyChar = Convert.ToChar(Keys.None);
            //    }

            //}


        }

        private void DGkala_MouseClick(object sender, MouseEventArgs e)
        {
            //if (DGkala.RowCount !=0)
            //{

            //}
            numberkala.Text = "";
            tedad = 0;
        }

        private void BTnsabt_Click(object sender, EventArgs e)
        {
            frosh fr = new frosh();
            //if (numberkala.Text=="0"||tedad==0)
            //{

            //}

            if (DGkala.RowCount == 0 || DGaza.RowCount==0 )
            {
                MessageBox.Show("رکوردی جهت ثبت وجود ندارد");
                return;
            }
            else
            {
                if (DGkala.CurrentRow.Cells["Mujodi"].Value.ToString()=="0")
                {
                    MessageBox.Show("موجودی کالا در انبار خالی است");
                    return;

                }
                else
                {
                    if (numberkala.Text != "" && numberkala.Text != "0")
                    {


                        fr.OzveCode = DGaza.CurrentRow.Cells["CustomerID"].Value.ToString();

                        fr.OzvName = DGaza.CurrentRow.Cells["CustomerName"].Value.ToString();
                        fr.kalaname = DGkala.CurrentRow.Cells["KalaName"].Value.ToString();
                        fr.PriceKala = DGkala.CurrentRow.Cells["Price2"].Value.ToString();
                        fr.tedadkala = numberkala.Text;
                        fr.Datatarakonesh = CBbirthyear.Text + "/" + CBbirthmonth.Text + "/" + CBbirthday.Text;

                        db1.froshes.Add(fr);
                        db1.SaveChanges();
                        MessageBox.Show("عملیات ثبت با مووفقیت انجام شد");
                        //=========================================================
                        int p = Convert.ToInt32(DGkala.CurrentRow.Cells[0].Value.ToString());
                        var m = (from a in db1.Tblfrooshgahs where a.ID == p select a).First();
                        m.ID = Convert.ToInt32(DGkala.CurrentRow.Cells[0].Value.ToString());
                        m.KalaName = DGkala.CurrentRow.Cells["KalaName"].Value.ToString();
                        m.Price = DGkala.CurrentRow.Cells["Price2"].Value.ToString();
                        int adad = Convert.ToInt32(m.Mujodi);
                        int adad2 = Convert.ToInt32(numberkala.Text);
                        int adad3 = adad - adad2;
                        m.Mujodi = adad3.ToString();
                        db1.SaveChanges();
                        DGkala.DataSource = db1.Tblfrooshgahs.ToList();
                        numberkala.Text = "";
                        tedad = 0;

                    }
                    else
                    {
                        MessageBox.Show("تعداد کالا وارد نشده است");
                    }
                }
               
            }
            
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            _ّFrmsaystate frm = new _ّFrmsaystate();
            frm.ShowDialog();
        }

        private void numberkala_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
