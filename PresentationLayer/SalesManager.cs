using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMS.Data;
using CMS.ServiceLayer;

namespace PresentationLayer
{
    public partial class SalesManager : Form
    {
        public SalesManager()
        {
            InitializeComponent();
        }

        CMS_DBEntities cmd = new CMS_DBEntities();
        SalesService sm = new SalesService();

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SalesManager_Load(this, e);
        }

        private void SalesManager_Load(object sender, EventArgs e)
        {
            double t1 = 0, t2 = 0, t3 = 0;
            salesDetailsBindingSource.DataSource = cmd.Sales_Details.ToList();
            productDetailsBindingSource.DataSource = cmd.Product_Details.ToList();

            for (int i = dgvSales.RowCount - 1; i >= 0; i--)
            {
                DataGridViewRow r = dgvSales.Rows[i];
                t1 = t1 + double.Parse(r.Cells["totalDataGridViewTextBoxColumn"].Value.ToString());
            }
            for (int i = dgvProduct.RowCount - 1; i >= 0; i--)
            {
                DataGridViewRow r = dgvProduct.Rows[i];
                int s = int.Parse(r.Cells["stockDataGridViewTextBoxColumn"].Value.ToString());
                double p= double.Parse(r.Cells["purchaseRateDataGridViewTextBoxColumn"].Value.ToString());
                double t = s * p;
                t2 = t2 + t;
            }
            lblTotalSales.Text = t1 +"";
            lblTotalCost.Text = t2 + "";
            dgvSales.BringToFront();
            dgvSales.Dock = DockStyle.Fill;

            if (t1<t2)
            {
                lblStatus.Text = "Loss";
                t3 = t2 - t1;
                t3 = (t3 * 100) / t2;
            }
            else
            {
                lblStatus.Text = "Profit";
                t3 = t1 - t2;
                t3 = (t3 * 100) / t1;
            }

            t3 = Math.Round(t3, 2);
            lblPerent.Text = t3 + " %";
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            sm.CreatePDF(dgvSales, "Sales Details");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
                dgvSales.DataSource = cmd.Sales_Details.Where(x => x.Invoice_No.ToString().Contains(txtSearch.Text)).ToList();
        }
    }
}
