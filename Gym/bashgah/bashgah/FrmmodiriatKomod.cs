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
    public partial class FrmmodiriatKomod : Form
    {
       public DbBashgahEntities db = new DbBashgahEntities();
        public FrmmodiriatKomod()
        {
            InitializeComponent();
        }

       
        private void FrmmodiriatKomod_Load_1(object sender, EventArgs e)
        {
            

            DGkomod.DataSource = db.TBkomods.ToList();

        }

        private void addkomodBTN_Click(object sender, EventArgs e)
        {
       
            TBkomod tb = new TBkomod();
            int a = 0;
            if (DGkomod.RowCount==0)
            {
                a = 0;
            }

            else
            {
                var max = DGkomod.Rows.Cast<DataGridViewRow>().Max(r => Convert.ToInt32(r.Cells["KomodNum"].Value));

                a = max;
            }
            
            int b = a+1;
            //MessageBox.Show(b.ToString());
            tb.KomodNum = Convert.ToString(b);
            tb.State = "خالی";
            tb.Customer = "";

            db.TBkomods.Add(tb);
            db.SaveChanges();

            DGkomod.DataSource = db.TBkomods.ToList();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            //var k = db.TBkomods.Where(a => a.State == "خالی").ToList();
            if (DGkomod.RowCount==0)
            {
                MessageBox.Show("رکوردی برای حذف وجود ندارد");
            }
            else
            {
                if (DGkomod.CurrentRow.Cells["State"].Value.ToString()=="خالی")
                {

                    int id = Convert.ToInt32(DGkomod.CurrentRow.Cells["ID"].Value.ToString());
                    var k = db.TBkomods.Where(a => a.ID == id).First();

                    db.TBkomods.Remove(k);
                    db.SaveChanges();
                    DGkomod.DataSource = db.TBkomods.ToList();
                }
                else
                {
                    MessageBox.Show("کمد انتخابی پر است ");
                }
            }

        }
        private void search()
        {
            //int id = Convert.ToInt32(textBoxX1.Text);
            var sr = db.TBkomods.Where(n => n.KomodNum.Contains(TBsearch.Text) );

            DGkomod.DataSource = sr.ToList();
        }

        private void TBsearch_TextChanged(object sender, EventArgs e)
        {

            search();
        }

        private void TBsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) >= 48 && Convert.ToInt32(e.KeyChar) <= 57 || Convert.ToInt32(e.KeyChar) >= 1776 && Convert.ToInt32(e.KeyChar) <= 1785 || Convert.ToInt32(e.KeyChar) == 8)
            {

            }
            else
            {
                e.KeyChar = Convert.ToChar(Keys.None);
            }
        }

        private void addcustomerBTN_Click(object sender, EventArgs e)
        {
            if (DGkomod.CurrentRow.Cells["State"].Value.ToString() == "خالی")
            {
                Frmselectcustomer2 cu = new Frmselectcustomer2();
                cu.KK.Text = DGkomod.CurrentRow.Cells["KomodNum"].Value.ToString();
                cu.id = Convert.ToInt32(DGkomod.CurrentRow.Cells[0].Value.ToString());
                cu.ShowDialog();

                db = cu.db;
                DGkomod.DataSource = db.TBkomods.ToList();
            }
            else
            {
                MessageBox.Show("کمد انتخابی پر است");
                    
            }
               
        }
    }
}
