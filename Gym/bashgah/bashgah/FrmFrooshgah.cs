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
    public partial class FrmFrooshgah : Form
    {
        public int code = 0;
       public DbBashgahEntities db = new DbBashgahEntities();
        public FrmFrooshgah()
        {
            InitializeComponent();
        }

        private void Picdelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TBprice_TextChanged(object sender, EventArgs e)
        {
            Class1.ChangeName(TBprice);
        }

        private void TBtedad_TextChanged(object sender, EventArgs e)
        {
            Class1.ChangeName(TBtedad);
        }

        private void TBprice_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Convert.ToInt32(e.KeyChar) >= 48 && Convert.ToInt32(e.KeyChar) <= 57 || Convert.ToInt32(e.KeyChar) >= 1776 && Convert.ToInt32(e.KeyChar) <= 1785 || Convert.ToInt32(e.KeyChar) == 8)
            {

            }
            else
            {
                e.KeyChar = Convert.ToChar(Keys.None);
            }
        }

        private void TBtedad_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Convert.ToInt32(e.KeyChar) >= 48 && Convert.ToInt32(e.KeyChar) <= 57 || Convert.ToInt32(e.KeyChar) >= 1776 && Convert.ToInt32(e.KeyChar) <= 1785 || Convert.ToInt32(e.KeyChar) == 8)
            {

            }
            else
            {
                e.KeyChar = Convert.ToChar(Keys.None);
            }
        }

        private void Picsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBName.Text)||string.IsNullOrEmpty(TBprice.Text)||string.IsNullOrEmpty(TBtedad.Text))
            {
                MessageBox.Show(" لطفا فیلد های خالی را پرکنید");
            }
            else
            {

                Tblfrooshgah fr = new Tblfrooshgah();
                fr.KalaName = TBName.Text;
                fr.Price = TBprice.Text;
                fr.Mujodi = TBtedad.Text;


                db.Tblfrooshgahs.Add(fr);
                db.SaveChanges();
                MessageBox.Show("ثبت با موفقیت انجام شد");

                this.Close();
            }
        }

        private void BtnEditekala_Click(object sender, EventArgs e)
        {
            Frmmodiriatfroosh fr = new Frmmodiriatfroosh();
            if (string.IsNullOrEmpty(TBName.Text) || string.IsNullOrEmpty(TBprice.Text) || string.IsNullOrEmpty(TBtedad.Text))
            {
                MessageBox.Show(" لطفا فیلد های خالی را پرکنید");
            }
            else
            {
                var query = (from a in db.Tblfrooshgahs where a.ID == code select a).SingleOrDefault();
                query.KalaName = TBName.Text;
                query.Price = TBprice.Text;
                query.Mujodi = TBtedad.Text;


                db.SaveChanges();
                MessageBox.Show("ثبت با موفقیت انجام شد");
                
                this.Close();
                
            }

        }
    }
}
