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
    public partial class Frmselectcustomer2 : Form
    {
       public int id = 0;
      public  DbBashgahEntities db = new DbBashgahEntities();

        public Frmselectcustomer2()
        {
            InitializeComponent();
        }

        private void Frmselectcustomer_Load(object sender, EventArgs e)
        {
            DGCustomer.DataSource = db.TblUsers.ToList();
        }

        private void Picdelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Picsave_Click(object sender, EventArgs e)
        {
            
            if (DGCustomer.RowCount == 0)
            {
                MessageBox.Show("رکوردی برای انتخاب  وجود ندارد");
            }
            else
            {
                int y = Convert.ToInt32(DGCustomer.CurrentRow.Cells[0].Value.ToString());
                FrmDetails dt = new FrmDetails();
                var k = db.TBkomods.Where(a => a.ID == id).First();
               var ku = db.TblUsers.Where(a => a.ID == y).First();
                //   k.ID = id;

             //   MessageBox.Show(y.ToString());
                k.KomodNum = KK.Text;
                k.Customer = DGCustomer.CurrentRow.Cells["FName"].Value.ToString();
                k.State = "پــر";
                ku.Komod = "دارد";
                db.SaveChanges();
                MessageBox.Show("عملیات با موفقیت انجام شد");
              


               this.Close();
            }
           
           
        }
    }
}
