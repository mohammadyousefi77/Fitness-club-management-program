using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bashgah
{
    public partial class FrmUserManagement : Form
    {
        DbBashgahEntities db = new DbBashgahEntities();
        public FrmUserManagement()
        {
            InitializeComponent();
        }

        private void search()
        {
            //int id = Convert.ToInt32(textBoxX1.Text);
            var sr = db.TblUsers.Where(n => n.Name.Contains(TBsearch.Text) );
           
            DGlist.DataSource = sr.ToList();
        }
        private void FrmUserManagement_Load(object sender, EventArgs e)
        {
            DGlist.DataSource = db.TblUsers.ToList();
           
        }

        

        private void TBsearch_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void BTcontent_Click(object sender, EventArgs e)
        {

            if (DGlist.RowCount == 0)
            {
                MessageBox.Show("رکوردی برای نمایش اطلاعات  وجود ندارد");
                return;
            }

            try
            {
                FrmDetails dt = new FrmDetails();
                dt.LBOzviat.Text = DGlist.CurrentRow.Cells[0].Value.ToString();
                dt.LBlName.Text = DGlist.CurrentRow.Cells[1].Value.ToString();
                dt.LblTE.Text = DGlist.CurrentRow.Cells["etebar"].Value.ToString();
                dt.LBltt.Text = DGlist.CurrentRow.Cells["BirthDate"].Value.ToString();
                dt.LBlTo.Text = DGlist.CurrentRow.Cells["OzviatDate"].Value.ToString();
                dt.Lblkomod.Text = DGlist.CurrentRow.Cells["Komod"].Value.ToString();
                dt.pictureBox1.Load(Application.StartupPath + "\\Pics\\" + DGlist.CurrentRow.Cells[0].Value.ToString() + ".jpg");
                dt.ShowDialog();
            }
            catch
            {
                MessageBox.Show("خطا در نمایش اطاعات");
            }
        }

        private void BTedite_Click(object sender, EventArgs e)
        {
            string sindex = "";

            if (DGlist.RowCount == 0)
            {
                MessageBox.Show("رکوردی برای ویرایش  وجود ندارد");
                return;
            }
            Frmuseredite ed = new Frmuseredite();


            for (int i = 1; i <= 31; i++)
            {
               ed. CBbirthday.Items.Add(i.ToString());
            }


            for (int i = 1; i <= 12; i++)
            {
             ed.   CBbirthmonth.Items.Add(i.ToString());
            }


            for (int i = 1310; i <= 1420; i++)
            {
                ed.CBbirthyear.Items.Add(i.ToString());
            }


            //---------------------------------------

            for (int i = 1; i <= 31; i++)
            {
                ed.CBozviatday.Items.Add(i.ToString());
            }


            for (int i = 1; i <= 12; i++)
            {
                ed.CBozviatmonth.Items.Add(i.ToString());
            }


            for (int i = 1310; i <= 1420; i++)
            {
                ed.CBozviatyear.Items.Add(i.ToString());
            }

            //--------------------------------------------

            for (int i = 1; i <= 31; i++)
            {
                ed.CBetebarday.Items.Add(i.ToString());
            }


            for (int i = 1; i <= 12; i++)
            {
                ed.CBetebarmonth.Items.Add(i.ToString());
            }


            for (int i = 1310; i <= 1420; i++)
            {
                ed.CBetebaryear.Items.Add(i.ToString());
            }
            //--------------------------------
            ed.CBbirthday.SelectedIndex = 0;
            ed.CBbirthmonth.SelectedIndex = 0;
            ed.CBbirthyear.SelectedIndex = 0;

            //--------------------------
            ed.CBozviatday.SelectedIndex = 0;
            ed.CBozviatmonth.SelectedIndex = 0;
            ed.CBozviatyear.SelectedIndex = 0;

            //--------------------------------

            ed.CBetebarday.SelectedIndex = 0;
            ed.CBetebarmonth.SelectedIndex = 0;
            ed.CBetebaryear.SelectedIndex = 0;



           // ed.code = Convert.ToInt32(DGlist.CurrentRow.Cells[0].Value.ToString());
            //================================ birthday

            // name lable
            ed.TBName.Text= DGlist.CurrentRow.Cells[1].Value.ToString();


            //years index

            sindex = DGlist.CurrentRow.Cells["BirthDate"].Value.ToString().Substring(0,4);
            ed.CBbirthyear.SelectedIndex = Convert.ToInt32(sindex) - 1310;


            //month index

            sindex = DGlist.CurrentRow.Cells["BirthDate"].Value.ToString().Substring(5, 2);
            sindex = sindex.Replace("/", "");
            ed.CBbirthmonth.SelectedIndex = Convert.ToInt32(sindex) - 1;

            //day index

            sindex = DGlist.CurrentRow.Cells["BirthDate"].Value.ToString().Substring(DGlist.CurrentRow.Cells["BirthDate"].Value.ToString().Length-2, 2);
            sindex = sindex.Replace("/", "");
            ed.CBbirthday.SelectedIndex = Convert.ToInt32(sindex) - 1;

            //================================ ozviat 


            sindex = DGlist.CurrentRow.Cells["OzviatDate"].Value.ToString().Substring(0, 4);
            ed.CBozviatyear.SelectedIndex = Convert.ToInt32(sindex) - 1310;


            //month index

            sindex = DGlist.CurrentRow.Cells["OzviatDate"].Value.ToString().Substring(5, 2);
            sindex = sindex.Replace("/", "");
            ed.CBozviatmonth.SelectedIndex = Convert.ToInt32(sindex) - 1;

            //day index

            sindex = DGlist.CurrentRow.Cells["OzviatDate"].Value.ToString().Substring(DGlist.CurrentRow.Cells["OzviatDate"].Value.ToString().Length - 2, 2);
            sindex = sindex.Replace("/", "");
            ed.CBozviatday.SelectedIndex = Convert.ToInt32(sindex) - 1;

            //====================etebar

            sindex = DGlist.CurrentRow.Cells["etebar"].Value.ToString().Substring(0, 4);
            ed.CBetebaryear.SelectedIndex = Convert.ToInt32(sindex) - 1310;


            //month index

            sindex = DGlist.CurrentRow.Cells["etebar"].Value.ToString().Substring(5, 2);
            sindex = sindex.Replace("/", "");
            ed.CBetebarmonth.SelectedIndex = Convert.ToInt32(sindex) - 1;

            //day index

            sindex = DGlist.CurrentRow.Cells["etebar"].Value.ToString().Substring(DGlist.CurrentRow.Cells["etebar"].Value.ToString().Length - 2, 2);
            sindex = sindex.Replace("/", "");
            ed.CBetebarday.SelectedIndex = Convert.ToInt32(sindex) - 1;

            //=========================================================



             ed.PicUserimage.Load(Application.StartupPath + "\\Pics\\" + DGlist.CurrentRow.Cells[0].Value.ToString() + ".jpg");
            ed.code =Convert.ToInt32( DGlist.CurrentRow.Cells[0].Value);

         


             ed.ShowDialog();

            db = ed.db;
            DGlist.DataSource = db.TblUsers.ToList();
        }

        private void BTdelete_Click(object sender, EventArgs e)
        {
            if (DGlist.RowCount==0)
            {
MessageBox.Show("رکوردی برای حذف وجود ندارد");
                return;
            }


            try{
                int a = Convert.ToInt32(DGlist.CurrentRow.Cells[0].Value);
                var sr2 = db.TblUsers.Where(n => n.ID==a).First();
                DialogResult result;
                result = MessageBox.Show(" ایا از حذف اطمینان دارید؟ ", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {


                   
                    var sr = db.TblUsers.Where(x => x.ID == a).First();
                    

                    var TBkomod = db.TBkomods.Where(n=> n.Customer==sr.Name).First();
                    TBkomod.State = "خالی";
                    TBkomod.Customer = "";
                    db.TblUsers.Remove(sr);
                    db.SaveChanges();


                    File.Delete(Application.StartupPath + "\\Pics\\" + DGlist.CurrentRow.Cells[0].Value.ToString() + ".jpg");

                    MessageBox.Show("عملیات حذف با مووفقیت انجام شد");


                    DGlist.DataSource = db.TblUsers.ToList();
                }


            }
            catch
            {
                MessageBox.Show("خطا درحذف اطلاعات");
            }




        }

        private void BTpay_Click(object sender, EventArgs e)
        {

            if (DGlist.RowCount == 0)
            {
                MessageBox.Show("رکوردی برای پرداخت شهریه وجود ندارد");
                return;
            }

            string sindex = "";
            FrmTamdid td = new FrmTamdid();
            for (int i = 1; i <= 31; i++)
            {
                td.CBetebarday.Items.Add(i.ToString());
            }


            for (int i = 1; i <= 12; i++)
            {
                td.CBetebarmonth.Items.Add(i.ToString());
            }


            for (int i = 1310; i <= 1420; i++)
            {
                td.CBetebaryear.Items.Add(i.ToString());
            }

            td.CBetebarday.SelectedIndex = 0;
            td.CBetebarmonth.SelectedIndex = 0;
            td.CBetebaryear.SelectedIndex = 0;


            //====================etebar

            sindex = DGlist.CurrentRow.Cells["etebar"].Value.ToString().Substring(0, 4);
            td.CBetebaryear.SelectedIndex = Convert.ToInt32(sindex) - 1310;


            //month index

            sindex = DGlist.CurrentRow.Cells["etebar"].Value.ToString().Substring(5, 2);
            sindex = sindex.Replace("/", "");
            td.CBetebarmonth.SelectedIndex = Convert.ToInt32(sindex) - 1;

            //day index

            sindex = DGlist.CurrentRow.Cells["etebar"].Value.ToString().Substring(DGlist.CurrentRow.Cells["etebar"].Value.ToString().Length - 2, 2);
            sindex = sindex.Replace("/", "");
            td.CBetebarday.SelectedIndex = Convert.ToInt32(sindex) - 1;

            //=========================================================
            td.code = Convert.ToInt32(DGlist.CurrentRow.Cells["id"].Value.ToString());
            td.Sname = DGlist.CurrentRow.Cells["username"].Value.ToString();

            td.ShowDialog();

            db = td.db;
            DGlist.DataSource = db.TblUsers.ToList();
        }



        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }

        private void BTprintcard_Click(object sender, EventArgs e)
        {
            if (DGlist.RowCount == 0)
            {
                MessageBox.Show("رکوردی برای نمایش کارت عضویت  وجود ندارد");
                return;
            }

            try
            {

                int a = Convert.ToInt32(DGlist.CurrentRow.Cells[0].Value);
                var sr2 = db.TblUsers.Where(n => n.ID == a);
                DataTable dtm = new DataTable();
                dtm = ConvertToDataTable(sr2.ToList());

                DataTable dtp = new DataTable();
                dtp.Columns.Add("Pic");
                dtp.Columns.Add("BarCode");
                dtp.Rows.Add();
                dtp.Rows[0][0] = Application.StartupPath + "\\Pics\\" + DGlist.CurrentRow.Cells[0].Value.ToString() + ".jpg";
                dtp.Rows[0][1] = Application.StartupPath + "\\Pics\\" + DGlist.CurrentRow.Cells[0].Value.ToString() + "_Barcode.jpg";


                DataSet ds = new DataSet();
                ds.Merge(dtm);
                ds.Tables[0].TableName = "dtm";

                ds.Merge(dtp);
                ds.Tables[1].TableName = "dtp";

                stiReport1.RegData(ds);
                stiReport1.Load("stiReport1.mrt");
                stiReport1.Show();

            }
            catch
            {
                MessageBox.Show("خطای نمایش کارت");
            }

        }

        private void groupPanel2_Click(object sender, EventArgs e)
        {

        }
    }
}
