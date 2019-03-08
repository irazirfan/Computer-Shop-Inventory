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
    public partial class PurchaseEntry : Form
    {
        CMS_DBEntities cmd = new CMS_DBEntities();
        ManagerService ms = new ManagerService();
        public PurchaseEntry()
        {
            InitializeComponent();
        }

        private void PurchaseE_Load(object sender, EventArgs e)
        {
            productOrderBindingSource.DataSource = cmd.Product_Order.ToList();
            purchaseEntryBindingSource.DataSource = cmd.Purchase_Entry.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ms.AddPE(int.Parse(txtPoID.Text), int.Parse(txtSupId.Text), cmbPoTerms.Text);
            purchaseEntryBindingSource.DataSource = cmd.Purchase_Entry.ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (purchaseEntryBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd.Purchase_Entry.Remove(purchaseEntryBindingSource.Current as Purchase_Entry);
                    purchaseEntryBindingSource.RemoveCurrent();
                    try
                    {
                        cmd.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("It Has a Purchase Return Entry.\n Please remove that to remove this.");
                        purchaseEntryBindingSource.DataSource = cmd.Purchase_Entry.ToList();
                    }
                }
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            SalesmanService s = new SalesmanService();
            s.POPdf(dgPE, "Purchase Entry  " + DateTime.Today.ToString());
        }

        private void txtSupId_TextChanged(object sender, EventArgs e)
        {
            var data = from d in cmd.Supplier_Details
                where d.S_ID.ToString().Equals(txtSupId.Text)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
