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
using System.Data.Entity;
using CMS.ServiceLayer;

namespace PresentationLayer
{
    public partial class PurchaseOrder : Form
    {
        CMS_DBEntities cmd = new CMS_DBEntities();
        Product_Order p = new Product_Order();
        ManagerService ms = new ManagerService();

        public PurchaseOrder(Product_Order obj)
        {
            InitializeComponent();
            if (obj == null)
            {
                btnUpdate.Enabled = false;
                txtPoID.Text = "Auto Generate";
            }
            else
            {
                btnNew.Enabled = false;
                btnSave.Enabled = false;
                productOrderBindingSource.DataSource = obj;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DetailsProductOrder d = new DetailsProductOrder();
            d.Visible = true;
            this.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ms.AddPo(datePo.Text, int.Parse(cmbSupId.Text), txtPName.Text, int.Parse(txtPQuantity.Text), float.Parse(txtPPriceUnit.Text), int.Parse(txtPDiscount.Text));
        }

        private void PurchaseOrder_Load(object sender, EventArgs e)
        {
            var id = from d in cmd.Supplier_Details
                       select d;
            cmbSupId.DataSource = id.ToList();
            cmbSupId.DisplayMember = "S_ID";
        }

        private void cmbSupId_TextChanged(object sender, EventArgs e)
        {
            var data = from d in cmd.Supplier_Details
                     where d.S_ID.ToString().Equals(cmbSupId.Text)
                     select d;
            try
            {
                txtSupName.Text = data.Single().S_Name;
                txtSupMobile.Text = data.Single().Contact;
                txtSupAddress.Text = data.Single().Address;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(datePo.Text);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Entry(productOrderBindingSource.Current as Product_Order).State = EntityState.Modified;
            }
            catch (Exception ex)
            {
                cmd.SaveChanges();
            }
            btnNew.PerformClick();
            this.Visible = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            datePo.Refresh();
            txtPName.ResetText();
            txtPQuantity.ResetText();
            txtPPriceUnit.ResetText();
            txtPDiscount.ResetText();
        }

        double value;

        private void txtPPriceUnit_TextChanged(object sender, EventArgs e)
        {
            try
            {
                value = 0;
                lblTotal.Text = "Total : ";
                value = double.Parse(txtPPriceUnit.Text) * double.Parse(txtPQuantity.Text);
                lblTotal.Text = lblTotal.Text + value;
            }
            catch(Exception ex) { }
        }

        private void txtPDiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblDiscont.Text = "Discount : ";
                lblFinal.Text = "Final : ";
                lblDiscont.Text = lblDiscont.Text + txtPDiscount.Text;
                value = value - ((double.Parse(txtPDiscount.Text) * value) / 100);
                lblFinal.Text = lblFinal.Text + value;
            }
            catch(Exception ex){ }
        }

    }
}
