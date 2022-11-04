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
    public partial class Frmmodiriatfroosh : Form
    {
       DbBashgahEntities db = new DbBashgahEntities();
        public Frmmodiriatfroosh()
        {
            InitializeComponent();
        }

        private void Frmmodiriatfroosh_Load(object sender, EventArgs e)
        {
            
            DGfroshgah.DataSource = db.Tblfrooshgahs.ToList();
        }
        private void search()
        {
            //int id = Convert.ToInt32(textBoxX1.Text);
            var sr = db.Tblfrooshgahs.Where(n => n.KalaName.Contains(TBsearch2.Text));

            DGfroshgah.DataSource = sr.ToList();
        }
        private void TBsearch_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(TBsearch2.Text);
            search();
        }

        private void BTndelete_Click(object sender, EventArgs e)
        {

            if (DGfroshgah.RowCount == 0)
            {
                MessageBox.Show("رکوردی برای حذف   وجود ندارد");
                return;
            }

            try
            {
                int a = Convert.ToInt32(DGfroshgah.CurrentRow.Cells[0].Value);
                var sr2 = db.Tblfrooshgahs.Where(n => n.ID == a).First();
                DialogResult result;
                result = MessageBox.Show(" ایا از حذف اطمینان دارید؟ ", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {



                    //var sr = db.TblUsers.Where(x => x.ID == a).First();
                    db.Tblfrooshgahs.Remove(sr2);
                    db.SaveChanges();


                  
                    MessageBox.Show("عملیات حذف با مووفقیت انجام شد");


                    DGfroshgah.DataSource = db.Tblfrooshgahs.ToList();
                }


            }
            catch
            {
                MessageBox.Show("خطا درحذف اطلاعات");
            }


        }

        private void Btnedit_Click(object sender, EventArgs e)
        {
            if (DGfroshgah.RowCount == 0)
            {
                MessageBox.Show("رکوردی برای حذف ویرایش  وجود ندارد");
                return;
            }


            FrmFrooshgah fr = new FrmFrooshgah();

            fr.code = Convert.ToInt32(DGfroshgah.CurrentRow.Cells[0].Value);


         
            fr.Text = "ویرایش کالا";
            fr.Picsave.Visible = false;
            fr.BtnEditekala.Visible = true;
            //Tblfrooshgah tb = new Tblfrooshgah();
          
            fr.TBName.Text = DGfroshgah.CurrentRow.Cells["KalaName"].Value.ToString();
            fr.TBprice.Text = DGfroshgah.CurrentRow.Cells["Price"].Value.ToString();
            fr.TBtedad.Text = DGfroshgah.CurrentRow.Cells["Mujodi"].Value.ToString();
            fr.ShowDialog();
            db = fr.db;
            DGfroshgah.DataSource = db.Tblfrooshgahs.ToList();

        }

        private void DGfroshgah_DoubleClick(object sender, EventArgs e)
        {
            Btnedit_Click(null,null);
        }
    }
}
