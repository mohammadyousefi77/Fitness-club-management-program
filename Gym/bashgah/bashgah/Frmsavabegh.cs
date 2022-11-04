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
    public partial class Frmsavabegh : Form
    {
        DbBashgahEntities db = new DbBashgahEntities();
        public Frmsavabegh()
        {
            InitializeComponent();
        }

        private void Frmsavabegh_Load(object sender, EventArgs e)
        {
            DGsavabegh.DataSource = db.tarakoneshTBls.ToList();

        }

        private void searching()
        {
            
            var namesearch = (from ozv in db.tarakoneshTBls where ozv.CustomerID.Contains(TBcustomert.Text) && ozv.CustomerName.Contains(TBsearch.Text) select ozv).ToList();
            DGsavabegh.DataSource = namesearch;

        }
        private void TBsearch_TextChanged(object sender, EventArgs e)
        {
            searching();
        }

        private void TBcustomert_TextChanged(object sender, EventArgs e)
        {

            Class1.ChangeName(TBcustomert);
            searching();
        }

        private void TBcustomert_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) >= 48 && Convert.ToInt32(e.KeyChar) <= 57 || Convert.ToInt32(e.KeyChar) >= 1776 && Convert.ToInt32(e.KeyChar) <= 1785 || Convert.ToInt32(e.KeyChar) == 8)
            {

            }
            else
            {
                e.KeyChar = Convert.ToChar(Keys.None);
            }
        }
    }
}
