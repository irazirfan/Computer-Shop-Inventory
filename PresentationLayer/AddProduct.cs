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
using MetroFramework;
using MetroFramework.Forms;


namespace PresentationLayer
{
    public partial class AddProduct : Form
    {
        bool mouseDown;
        Point lastLocation;

        private void Mouse_Down(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Mouse_Up(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Mouse_Move(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        public AddProduct()
        {
            InitializeComponent();
        }
        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        CMS_DBEntities cmd = new CMS_DBEntities();
        ProductService ad = new ProductService();
        ConvertImage ci = new ConvertImage();

        public AddProduct(CMS.Data.Product_Details obj)
        {
            InitializeComponent();

            if (obj == null)
            {
                btnUpdate.Enabled = false;
            }
            else
            {
                txtPStock.ReadOnly = true;
                btnSave.Enabled = false;
                productDetailsBindingSource.DataSource = obj;
                pbP.Image = ci.ConvertByteToImage(obj.Image);
            }
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Photo Select";
            ofd.Filter = "JPG|*.jpg|PNG|*.png|GIF|*.gif";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbP.ImageLocation = ofd.FileName;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            pbP.ImageLocation = null;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            pbP.ImageLocation = null;
            txtPName.Clear();
            txtPPRate.Clear();
            txtPPurchaseU.Clear();
            txtPReorder.Clear();
            txtPStock.Clear();
            txtPDesc.Clear();
            txtPSRate.Clear();
            cmbPCategory.Text = "";
        }


        private void AddManager_Load(object sender, EventArgs e)
        {

            //cmbPCategory.DataSource = ad.GetAllCategories();
        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ProductManager m = new ProductManager();
            m.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ad.AddProduct(txtPName.Text, txtPDesc.Text, cmbPCategory.Text, pbP.ImageLocation, int.Parse(txtPPurchaseU.Text), int.Parse(txtPSRate.Text), int.Parse(txtPStock.Text), int.Parse(txtPReorder.Text), int.Parse(txtPPRate.Text));
            }
            catch (Exception exception)
            {
                MessageBox.Show("Please enter all the fields properly");
            }
            btnNew.PerformClick();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnNew.PerformClick();
            this.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (pbP.Image != null)
            {
                int stock = (productDetailsBindingSource.Current as Product_Details).Stock;
                try
                {
                    stock = stock + int.Parse(txtPPurchaseU.Text);
                    (productDetailsBindingSource.Current as Product_Details).Stock = stock;
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Enter valid input");
                    txtPPurchaseU.Focus();
                }
                (productDetailsBindingSource.Current as Product_Details).Image = ci.ImageToByteArray(pbP.Image);
                cmd.Entry(productDetailsBindingSource.Current as Product_Details).State = EntityState.Modified;
                cmd.SaveChanges();
                //btnNew.PerformClick();
                this.Visible = false;
            }
            else
                MessageBox.Show("Please Enter a Picture");
        }

        private void btnBrowse_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Photo Select";
            ofd.Filter = "JPG|*.jpg|PNG|*.png|GIF|*.gif";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbP.ImageLocation = ofd.FileName;
            }
        }

        private void btnCatInsert_Click(object sender, EventArgs e)
        {
            cmbPCategory.Items.Add(txtInsertCategory.Text);
            txtInsertCategory.Text = "";
            MessageBox.Show("Category List Has Been Updated");
        }

        private void btnCatRemove_Click(object sender, EventArgs e)
        {
            cmbPCategory.Items.Remove(txtInsertCategory.Text);
            txtInsertCategory.Text = "";
            MessageBox.Show("Category List Has Been Updated");
        }
    }
}
