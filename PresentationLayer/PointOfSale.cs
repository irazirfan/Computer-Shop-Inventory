using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMS.Data;
using CMS.ServiceLayer;

namespace PresentationLayer
{
    public partial class PointOfSale : Form
    {
        CMS_DBEntities cmd = new CMS_DBEntities();
        SalesmanService ss = new SalesmanService();
        SalesService sal = new SalesService();

        public PointOfSale()
        {
            InitializeComponent();
        }

        private void POS_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnNew.PerformClick();
            Application.Exit();
        }

        private void POS_Load(object sender, EventArgs e)
        {
            productDetailsBindingSource.DataSource = cmd.Product_Details.ToList();
            pOSBindingSource.DataSource = cmd.POS.ToList();
            AllButton();
        }

        private string date;
        private void AllButton()
        {
            btnAdd.Enabled = false;
            btnNew.Enabled = false;
            btnTotal.Enabled = false;
            btnPay.Enabled = false;
            txtPayment.Visible = false;
            btnRemove.Enabled = false;
            txtDiscount.Visible = false;
            txtQuantity.Visible = false;
            txtSearch.Clear();
            txtPayment.Clear();
            txtQuantity.Clear();
            txtDiscount.Clear();
            lblDiscount.Text = "Discount : ";
            lblFinal.Text = "Final : ";
            lblPaid.Text = "Paid : ";
            lblReturn.Text = "Return : ";
            lblTotal.Text = "Total : ";
            f = d = t = da = 0;
            DateTime createDate = DateTime.Now;
            lblId.Text = "" + createDate.Day + createDate.Month + createDate.Year + createDate.Hour + createDate.Minute + createDate.Millisecond;
            date = createDate.Day + "-" + createDate.Month + "-" + createDate.Year;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int stock = ((Product_Details)productDetailsBindingSource.Current).Stock;
                int rPoint = ((Product_Details)productDetailsBindingSource.Current).Reorder_Point;

                int pid = ((Product_Details)productDetailsBindingSource.Current).P_ID;
                string pname = ((Product_Details)productDetailsBindingSource.Current).P_Name;
                float price = (float)((Product_Details)productDetailsBindingSource.Current).Sales_Rate;
                int quantity = int.Parse(txtQuantity.Text);
                float total = price * quantity;

                if (quantity > stock || quantity < 0)
                {
                    MessageBox.Show("Not Enough Stock");
                }
                else if ((stock - quantity) <= rPoint)
                {
                    MessageBox.Show("Stock will be at Re-order Point");
                    if ((stock - quantity) == 0)
                    {

                        if (MessageBox.Show("Stock will be empty. Are you sure ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (ss.AddPOS(pid, pname, price, quantity, total))
                            {
                                btnAdd.Enabled = false;
                                btnRemove.Enabled = true;
                                btnNew.Enabled = true;
                                btnTotal.Enabled = true;
                                txtQuantity.Clear();
                                pOSBindingSource.DataSource = cmd.POS.ToList();
                            }
                            else
                            {
                                MessageBox.Show("Something Wrong");
                            }
                        }
                    }
                    if (ss.AddPOS(pid, pname, price, quantity, total))
                    {
                        btnAdd.Enabled = false;
                        btnRemove.Enabled = true;
                        btnNew.Enabled = true;
                        btnTotal.Enabled = true;
                        txtQuantity.Clear();
                        pOSBindingSource.DataSource = cmd.POS.ToList();
                    }
                    else
                    {
                        MessageBox.Show("Something Wrong");
                    }
                }
                else
                {
                    if (ss.AddPOS(pid, pname, price, quantity, total))
                    {
                        btnAdd.Enabled = false;
                        btnRemove.Enabled = true;
                        btnNew.Enabled = true;
                        btnTotal.Enabled = true;
                        txtQuantity.Clear();
                        pOSBindingSource.DataSource = cmd.POS.ToList();
                    }
                    else
                    {
                        MessageBox.Show("Something Wrong");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void metroGrid1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtQuantity.Visible = true;
            txtQuantity.Focus();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            productDetailsBindingSource.DataSource = cmd.Product_Details.ToList();
            var all = from a in cmd.POS select a;
            cmd.POS.RemoveRange(all);
            try
            {
                cmd.SaveChanges();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            pOSBindingSource.DataSource = cmd.POS.ToList();
            AllButton();
        }

        double f = 0, d = 0, t=0, da=0;

        private void btnTotal_Click(object sender, EventArgs e)
        {
            txtDiscount.Visible = true;
            txtDiscount.Enabled = true;
            btnTotal.Enabled = false;
            for(int i=dgPos.RowCount-1; i>=0; i--)
            {
                DataGridViewRow r = dgPos.Rows[i];
                t = t + double.Parse(r.Cells["totalDataGridViewTextBoxColumn"].Value.ToString());
            }
            lblTotal.Text = lblTotal.Text + t;
        }

        private void txtPayment_TextChanged(object sender, EventArgs e)
        {
            btnPay.Enabled = true;
            d = double.Parse(txtDiscount.Text);
            try
            {
                da = ( (d * t) / 100);
                f = t - da;
                lblFinal.Text = "Final : ";  
                lblFinal.Text = lblFinal.Text + f;
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter values correctly");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            productDetailsBindingSource.DataSource = cmd.Product_Details.Where(x => x.P_Name.Contains(txtSearch.Text)).ToList();
        }

        private void txtPayment_Click(object sender, EventArgs e)
        {
            lblDiscount.Text = "Discount : ";
            lblDiscount.Text = lblDiscount.Text + txtDiscount.Text;
            txtDiscount.Enabled = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (pOSBindingSource.Current != null)
            {
                if (MessageBox.Show("Are you sure ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd.POS.Remove(pOSBindingSource.Current as POS);
                    pOSBindingSource.RemoveCurrent();
                    cmd.SaveChanges();
                }
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (double.Parse(txtPayment.Text) >= f)
            {
                txtPayment.Enabled = false;
                lblPaid.Text = lblPaid.Text + txtPayment.Text;

                lblReturn.Text = lblReturn.Text + (double.Parse(txtPayment.Text) - f);
                btnPay.Enabled = false;

                for (int i = dgPos.RowCount - 1; i >= 0; i--)
                {
                    DataGridViewRow r = dgPos.Rows[i];
                    //t = t + double.Parse(r.Cells["totalDataGridViewTextBoxColumn"].Value.ToString());
                    string p_id = r.Cells["pIdDataGridViewTextBoxColumn1"].Value.ToString();
                    int q = int.Parse(r.Cells["quantityDataGridViewTextBoxColumn"].Value.ToString());
                    float price = float.Parse(r.Cells["priceDataGridViewTextBoxColumn"].Value.ToString());
                    float total = float.Parse(r.Cells["totalDataGridViewTextBoxColumn"].Value.ToString());

                    sal.AddSales(lblId.Text, date, p_id, q, price, total);

                    int id = int.Parse(p_id);
                    Product_Details p = new Product_Details();
                    p = cmd.Product_Details.First(x => x.P_ID == id);
                    p.Stock = p.Stock - q;
                    cmd.Entry(p).State = EntityState.Modified;
                    cmd.SaveChanges();
                }
                btnNew.PerformClick();
            }
            else
            {
                MessageBox.Show("Insufficient Amount");
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            txtPayment.Visible = true;
            txtPayment.Enabled = true;
        }
    }
}
