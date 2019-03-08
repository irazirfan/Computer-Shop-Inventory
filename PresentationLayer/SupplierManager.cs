using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMS.Data;
using CMS.ServiceLayer;

namespace PresentationLayer
{
    public partial class SupplierManager : Form
    {
        CMS_DBEntities cmd = new CMS_DBEntities();
        SupplierService ss = new SupplierService();
        AdminService ad=new AdminService();

        public SupplierManager()
        {
            InitializeComponent();
        }

        private void SupplierManager_Load(object sender, EventArgs e)
        {
            supplierDetailsBindingSource.DataSource = cmd.Supplier_Details.ToList();
            cmbCities.DataSource = ad.GetAllCities();
            cmbCities.DisplayMember = "Name";

            for (int i = 0; i <= dgSDetails.Rows.Count - 1; i++)
            {
                dgSDetails.Rows[i].Height = 80;
            }
        }

        private void SupplierManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (supplierDetailsBindingSource.Current == null)
                return;

            using (AddSupplier am = new AddSupplier(supplierDetailsBindingSource.Current as Supplier_Details))
            {
                if (am.ShowDialog() == DialogResult.OK)
                    supplierDetailsBindingSource.DataSource = cmd.Supplier_Details.ToList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (supplierDetailsBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd.Supplier_Details.Remove(supplierDetailsBindingSource.Current as Supplier_Details);
                    supplierDetailsBindingSource.RemoveCurrent();
                    cmd.SaveChanges();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddSupplier a = new AddSupplier(null);
            a.Visible = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (cmbOption.Text == "SId")
                supplierDetailsBindingSource.DataSource = cmd.Supplier_Details.Where(x => x.S_ID.ToString().Contains(txtSearch.Text)).ToList();

            else if (cmbOption.Text == "City")
                supplierDetailsBindingSource.DataSource = cmd.Supplier_Details.Where(x => x.S_Name.Contains(txtSearch.Text)
                                                                       && x.City.Contains(cmbCities.Text)).ToList();
            else
            {
                supplierDetailsBindingSource.DataSource = cmd.Supplier_Details.Where(x => x.S_Name.Contains(txtSearch.Text)).ToList();
            }

            for (int i = 0; i <= dgSDetails.Rows.Count - 1; i++)
            {
                dgSDetails.Rows[i].Height = 120;
            }
        }

        private void cmbOption_TextChanged(object sender, EventArgs e)
        {
            if (cmbOption.Text == "City")
            {
                cmbCities.Visible = true;
            }
            else
                cmbCities.Visible = false;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objB = new Bitmap(dgSDetails.Width, dgSDetails.Height);
            dgSDetails.DrawToBitmap(objB, new Rectangle(0, 0, dgSDetails.Width, dgSDetails.Height));

            e.Graphics.DrawImage(objB, 25, 120);

            e.Graphics.DrawString(metroLabel1.Text, new Font("Verdana", 20, FontStyle.Italic), Brushes.Black, new Point(280, 30));
            e.Graphics.DrawString("Printed : " + DateTime.Now.ToString(), new Font("Verdana", 10, FontStyle.Italic), Brushes.Black, new Point(600, 50));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            ss.CreatePDF(dgSDetails, "Manager Details");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            supplierDetailsBindingSource.DataSource = cmd.Supplier_Details.ToList();
        }
    }
}
