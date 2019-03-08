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
    public partial class AddManager : Form
    {
        CMS_DBEntities cmd = new CMS_DBEntities();
        AdminService ad = new AdminService();
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


        public AddManager(Manager_details obj)
        {
            InitializeComponent();

            if (obj == null)
            {
                btnUpdate.Enabled = false;
            }
            else
            {
                btnSave.Enabled = false;
                managerdetailsBindingSource.DataSource = obj;
                pbM.Image = ci.ConvertByteToImage(obj.Image);
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
                pbM.ImageLocation = ofd.FileName;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            pbM.ImageLocation = null;
            pbM.Image = null;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            pbM.ImageLocation = null;
            txtMName.Clear();
            txtMAddress.Clear();
            cmbMCity.Refresh();
            txtMPostalCode.Clear();
            txtMMobile.Clear();
            txtMEmail.Clear();
            txtMCommission.Clear();
            txtMRemarks.Clear();
        }


        private void AddManager_Load(object sender, EventArgs e)
        {
            //var city = from d in cmd.Cities
            //           select d;
            cmbMCity.DataSource = ad.GetAllCities();
            cmbMCity.DisplayMember = "Name";
        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            btnNew.PerformClick();
            this.Visible = false;
            ManagerDetails m = new ManagerDetails();
            m.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool check=false;
            try
            {
                check = ad.AddManager(txtMName.Text, txtMAddress.Text, cmbMCity.Text, int.Parse(txtMPostalCode.Text),
                    txtMMobile.Text, txtMEmail.Text, int.Parse(txtMCommission.Text), txtMRemarks.Text,
                    pbM.ImageLocation);
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill the fields properly");
            }

            if (check)
            {
                var data = from d in cmd.Manager_details
                    where d.Email.ToString().Equals(txtMEmail.Text)
                    select d;

                AddUser au=new AddUser(data.Single().MId, data.Single().MName.ToString(), null, null, 2, null, pbM.ImageLocation );
                au.Visible = true;
                this.Visible = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnNew.PerformClick();
            this.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (pbM.Image != null)
            {
                (managerdetailsBindingSource.Current as Manager_details).Image = ci.ImageToByteArray(pbM.Image);
                cmd.Entry(managerdetailsBindingSource.Current as Manager_details).State = EntityState.Modified;
                cmd.SaveChanges();
                //btnNew.PerformClick();
                this.Visible = false;
            }
            else
                MessageBox.Show("Please Enter a Picture");
        }
    }
}
