using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using CMS.Data;
using CMS.ServiceLayer;

namespace PresentationLayer
{
    public partial class DetailsProductOrder : Form
    {
        CMS_DBEntities cmd = new CMS_DBEntities();
        ManagerService ms = new ManagerService();

        public DetailsProductOrder()
        {
            InitializeComponent();
        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PurchaseOrder a = new PurchaseOrder(null);
            a.Visible = true;
            this.Visible = false;
        }

        private void DetailsProductOrder_Load(object sender, EventArgs e)
        {
            productOrderBindingSource.DataSource = cmd.Product_Order.ToList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (productOrderBindingSource.Current == null)
                return;
            this.Visible = false;
            using (PurchaseOrder am = new PurchaseOrder(productOrderBindingSource.Current as Product_Order))
            {
                if (am.ShowDialog() == DialogResult.OK)
                    productOrderBindingSource.DataSource = cmd.Product_Order.ToList();
                cmd.SaveChanges();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (productOrderBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd.Product_Order.Remove(productOrderBindingSource1.Current as Product_Order);
                    productOrderBindingSource1.RemoveCurrent();
                    try
                    {
                        cmd.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("It Has a Purchase Entry.\n Please remove that to remove this.");
                        productOrderBindingSource1.DataSource = cmd.Product_Order.ToList();
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (cmbOption.Text == "SupplierId")
                dgPDetails.DataSource = cmd.Product_Order.Where(x => x.PONo.ToString().Contains(txtSearch.Text)).ToList();

            else if (cmbOption.Text == "Discount")
                dgPDetails.DataSource = cmd.Product_Order.Where(x => x.Discount.ToString().Contains(txtSearch.Text)).ToList();
            else 
                dgPDetails.DataSource = cmd.Product_Order.Where(x => x.PName.Contains(txtSearch.Text)).ToList();
        }

        private void cmbOption_TextChanged(object sender, EventArgs e)
        {
            if (cmbOption.Text == "Date")
            {
                //dgPDetails.DataSource = cmd.Product_Order.Where(x => ).ToList();
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            ms.POPdf(dgPDetails, "Product Order");
        }
    }
}
