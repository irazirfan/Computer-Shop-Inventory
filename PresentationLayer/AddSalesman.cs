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
    public partial class AddSalesman : MetroForm
    {
        CMS_DBEntities cmd = new CMS_DBEntities();
        SalesmanService ad = new SalesmanService();
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

        public AddSalesman(Salesman_Details obj)
        {
            InitializeComponent();

            if (obj == null)
            {
                btnUpdate.Enabled = false;
            }
            else
            {
                btnSave.Enabled = false;
                salesmanDetailsBindingSource.DataSource = obj;
                pbS.Image = ci.ConvertByteToImage(obj.Image);
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
                pbS.ImageLocation = ofd.FileName;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            pbS.ImageLocation = null;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            pbS.ImageLocation = null;
            txtSAddress.Clear();
            txtSCommission.Clear();
            txtSEmail.Refresh();
            txtSMobile.Clear();
            txtSName.Clear();
            txtSPostalCode.Clear();
            txtSRemarks.Clear();
            cmbSCity.Refresh();
        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            btnNew.PerformClick();
            this.Visible = false;
            SalesmanManager m = new SalesmanManager();
            m.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool check = false;
            try
            {
                check = ad.AddSalesman(txtSName.Text, txtSAddress.Text, cmbSCity.Text, txtSPostalCode.Text, txtSMobile.Text, txtSEmail.Text, int.Parse(txtSCommission.Text), txtSRemarks.Text, pbS.ImageLocation);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Please fill the fiels properly");
            }
            if (check)
            {
                var data = from d in cmd.Salesman_Details
                    where d.Email_ID.ToString().Equals(txtSEmail.Text)
                    select d;

                AddUser au = new AddUser(data.Single().Sal_ID, data.Single().Name, null, null, 3, null, pbS.ImageLocation);
                au.Visible = true;
                this.Visible = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnNew.PerformClick();
            this.Visible = false;
            SalesmanManager m = new SalesmanManager();
            m.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (pbS.Image != null)
            {
                (salesmanDetailsBindingSource.Current as Salesman_Details).Image = ci.ImageToByteArray(pbS.Image);
                cmd.Entry(salesmanDetailsBindingSource.Current as Salesman_Details).State = EntityState.Modified;
                cmd.SaveChanges();
                //btnNew.PerformClick();
                this.Visible = false;
            }
            else
                MessageBox.Show("Please Enter a Picture");
        }

        private void AddSalesman_Load(object sender, EventArgs e)
        {
            cmbSCity.DataSource = cmd.Cities.ToList();
            cmbSCity.DisplayMember = "Name";
        }
    }
}
