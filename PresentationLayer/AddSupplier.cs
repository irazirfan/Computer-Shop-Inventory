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
    public partial class AddSupplier : Form
    {
        CMS_DBEntities cmd = new CMS_DBEntities();
        SupplierService ss = new SupplierService();
        AdminService ad=new AdminService();
        ConvertImage ci = new ConvertImage();

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

        public AddSupplier(Supplier_Details obj)
        {
            InitializeComponent();

            if (obj == null)
            {
                btnUpdate.Enabled = false;
            }
            else
            {
                btnSave.Enabled = false;
                supplierDetailsBindingSource.DataSource = obj;

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtSupName.Clear();
            txtBankName.Clear();
            txtBranch.Clear();
            txtSupAddress.Clear();
            txtSupANo.Clear();
            txtSupEmail.Clear();
            txtSupPostalCode.Clear();
            txtSupRemarks.Clear();
            txtSupMobile.Clear();
            txtSupAName.Clear();
            cmbSupCity.Refresh();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ss.AddSupplier(txtSupName.Text, txtSupAddress.Text, cmbSupCity.Text, txtSupPostalCode.Text, txtSupMobile.Text, txtSupEmail.Text, txtSupRemarks.Text, txtSupAName.Text, txtSupANo.Text, txtBankName.Text, txtBranch.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Please fill the fields properly");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //btnNew.PerformClick();
            this.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cmd.Entry(supplierDetailsBindingSource.Current as Supplier_Details).State = EntityState.Modified;
            cmd.SaveChanges();
            //btnNew.PerformClick();
            this.Visible = false;
        }

        private void AddSupplier_Load(object sender, EventArgs e)
        {
            cmbSupCity.DataSource = ad.GetAllCities();
            cmbSupCity.DisplayMember = "Name";
        }
    }
}
