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
    public partial class _ّFrmsaystate : Form
    {
        DbBashgahEntities db = new DbBashgahEntities();
        public _ّFrmsaystate()
        {

            
            InitializeComponent();
        }

        private void _ّFrmsaystate_Load(object sender, EventArgs e)
        {
            DGvasiat.DataSource = db.froshes.ToList();
        }

        private void search()
        {
            //int id = Convert.ToInt32(textBoxX1.Text);
            var sr = db.froshes.Where(n => n.OzveCode.Contains(TBcustomert.Text)&& n.OzvName.Contains(TBsearch.Text));

            DGvasiat.DataSource = sr.ToList();
        }

        private void TBcustomert_TextChanged(object sender, EventArgs e)
        {
            search();

        }

        private void TBsearch_TextChanged(object sender, EventArgs e)
        {
            search();

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
