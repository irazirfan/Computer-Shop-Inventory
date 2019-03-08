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
    public partial class ProductManager : Form
    {
        public ProductManager()
        {
            InitializeComponent();
        }

        CMS_DBEntities cmd = new CMS_DBEntities();
        ProductService ass = new ProductService();

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ProductManager_Load(this, e);
        }

        private void ProductManager_Load(object sender, EventArgs e)
        {
            productDetailsBindingSource3.DataSource = cmd.Product_Details.ToList();
            cmbCities.DataSource = cmd.Categories.ToList();
            cmbCities.DisplayMember = "Cat_Name";

            for (int i = 0; i <= dgvProduct.Rows.Count - 1; i++)
            {
                dgvProduct.Rows[i].Height = 80;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (productDetailsBindingSource3.Current == null)
                return;

            using (AddProduct am = new AddProduct(productDetailsBindingSource3.Current as Product_Details))
            {
                if (am.ShowDialog() == DialogResult.OK)
                    productDetailsBindingSource3.DataSource = cmd.Product_Details.ToList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (productDetailsBindingSource3.Current != null)
            {
                if (MessageBox.Show("Are you sure ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd.Product_Details.Remove(productDetailsBindingSource3.Current as Product_Details);
                    productDetailsBindingSource3.RemoveCurrent();
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
            AddProduct a = new AddProduct();
            //this.Visible = false;
            a.Visible = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (cmbOption.Text == "P_ID")
                dgvProduct.DataSource = cmd.Product_Details.Where(x => x.P_ID.ToString().Contains(txtSearch.Text)).ToList();
            else if (cmbOption.Text == "Category")
                dgvProduct.DataSource = cmd.Product_Details.Where(x =>x.P_Category.Contains(cmbCities.Text) && x.P_Name.Contains(txtSearch.Text)).ToList();
            else
                dgvProduct.DataSource = cmd.Product_Details.Where(x => x.P_Name.Contains(txtSearch.Text)).ToList();

            for (int i = 0; i <= dgvProduct.Rows.Count - 1; i++)
            {
                dgvProduct.Rows[i].Height = 80;
            }
        }

        private void cmbOption_TextChanged(object sender, EventArgs e)
        {
            if (cmbOption.Text == "Category")
            {
                cmbCities.Visible = true;
            }
            else
                cmbCities.Visible = false;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objB = new Bitmap(dgvProduct.Width, dgvProduct.Height);
            dgvProduct.DrawToBitmap(objB, new Rectangle(0, 0, dgvProduct.Width, dgvProduct.Height));

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
            ass.CreatePDF(dgvProduct, "Manager Details");
        }

        private void ProductManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
