using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bashgah
{
    public partial class Frmuseredite : Form
    {
       public DbBashgahEntities db = new DbBashgahEntities();
       public int code = 0;
        Boolean picischange = false;
        public Frmuseredite()
        {
            InitializeComponent();
        }

        private void Picdelete_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    var query = (from a in db.TblUsers where a.ID == code select a).SingleOrDefault();

                    query.Name = TBName.Text;
                    query.BirthDate = CBbirthyear.Text + "/" + CBbirthmonth.Text + "/" + CBbirthday.Text;
                    query.OzviatDate = CBozviatyear.Text + "/" + CBozviatmonth.Text + "/" + CBozviatday.Text;
                    query.EtebarDate = CBetebaryear.Text + "/" + CBetebarmonth.Text + "/" + CBetebarday.Text;
                    if (picischange == true)
                    {

                        PicUserimage.Image.Save(Application.StartupPath + "\\Pics\\" + code.ToString() + ".jpg");



                    }


                    db.SaveChanges();


                    MessageBox.Show("ثبت با مووفقیت انجام شد");
                    this.Close();

                }
                

            }
            catch
            {
                MessageBox.Show("خطا در بارگزاری عکس لطفا دوباره امتحان کنید");
            }
           
            }

        private void PicBrows_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "(*.*)|*.*";
                op.Title = "تصویر را انتخاب کنید";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    //                    if (op.FileName== Application.StartupPath + "\\Pics\\" + code.ToString() + ".jpg")
                    //                    {
                    //                        MessageBox.Show("فایل تکراری است");
                    //                    }
                    //                    else
                    //                    {
                    //PicUserimage.Load(op.FileName);
                    //                        picischange = true;
                    //                    }
                    PicUserimage.Load(op.FileName);
                    picischange = true;

                  
                    
                }
            }
            catch
            {
                MessageBox.Show("فایل غیر مجاز است");
            }
        }
    }
}
