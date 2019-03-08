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
    public partial class PurchaseReturn : Form
    {
        CMS_DBEntities cmd = new CMS_DBEntities();
        ManagerService ms = new ManagerService();
        public PurchaseReturn()
        {
            InitializeComponent();
        }


        private void load()
        {
            try
            {
                var result = (from a in cmd.Product_Order
                              join b in cmd.Purchase_Entry on a.PONo equals b.PONo

                              select new OrderAndEntry
                              {
                                  PONo = a.PONo,
                                  SupplierId = (int)a.SupplierId,
                                  Quabtity = (int)a.Quabtity,
                                  PEId = b.PEId
                              }).ToList();
                dgPE.DataSource = result;
                purchaseReturnBindingSource.DataSource = cmd.Purchase_Return.ToList();
            }
            catch (Exception ex) { }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgPE_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow row = dgPE.Rows[index];
                txtPONo.Text = row.Cells[0].Value.ToString();
                txtSupId.Text = row.Cells[1].Value.ToString();
                txtPEId.Text = row.Cells[3].Value.ToString();

                var result = from a in cmd.Supplier_Details
                             where a.S_ID.ToString().Equals(txtSupId.Text)
                             select a;
                txtSupName.Text = result.Single().S_Name.ToString();
                txtSupMobile.Text = result.Single().Contact.ToString();
                txtSupAddress.Text = result.Single().Address.ToString();

                var r = from a in cmd.Product_Order
                        where a.PONo.ToString().Equals(txtPONo.Text)
                        select a;
                txtPODate.Text = r.Single().PODate.ToString();
            }
            catch (Exception ex) { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ms.AddPR(int.Parse(txtPEId.Text), int.Parse(txtQuantity.Text));
            purchaseReturnBindingSource.DataSource = cmd.Purchase_Return.ToList();

            Product_Order p = new Product_Order();
            using (cmd)
            {
                p = cmd.Product_Order.Where(x => x.PONo.ToString().Equals(txtPONo.Text)).FirstOrDefault();
                p.Quabtity = p.Quabtity - (int.Parse(txtQuantity.Text));
                cmd.Entry(p).State = EntityState.Modified;
                cmd.SaveChanges();
            }
            MessageBox.Show("Succesfully Return");
            txtQuantity.Clear();
            load();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (purchaseReturnBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd.Purchase_Return.Remove(purchaseReturnBindingSource.Current as Purchase_Return);
                    purchaseReturnBindingSource.RemoveCurrent();
                    cmd.SaveChanges();
                }
            }
        }

        private void PurchaseReturn_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}