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
using MetroFramework.Forms;

namespace PresentationLayer
{
    public partial class AddUser : Form
    {
        AdminService ad=new  AdminService();
        CMS_DBEntities cmd=new CMS_DBEntities();
        bool mouseDown;
        Point lastLocation;

        private void AddUser_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void AddUser_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void AddUser_Move(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        public AddUser(int uid, string name, string uname, string pass, int utype, Image image, string path)
        {
            InitializeComponent();
            txtId.Text = ""+uid;
            txtName.Text = name;
            txtUName.Text = uname;
            txtPass.Text = pass;
            txtUType.Text = "" + utype;
            if (image != null || uid == 1)
            {
                pbUPic.Image = image;
                btnSave.Enabled = false;
            }
            else
            {
                btnUpdate.Enabled = false;
                pbUPic.ImageLocation = path;
            }
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUName.Text))
                {
                    MessageBox.Show("Type Username First");
                    return;
                }
                if (txtPass.Text.Equals(txtCPass.Text))
                    ad.AddUser(int.Parse(txtId.Text), txtName.Text, txtUName.Text, txtPass.Text, int.Parse(txtUType.Text), pbUPic.ImageLocation);
                else
                {
                    MessageBox.Show("Passwords Do Not Match");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Please fill the fields properly");
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPass.Text.Equals(txtCPass.Text))
                {
                    int id = int.Parse(txtId.Text);
                    User_Details u = new User_Details();
                    u = cmd.User_Details.First(x => x.U_ID == id);
                    u.Password = txtPass.Text;

                    cmd.Entry(u).State = EntityState.Modified;
                    cmd.SaveChanges();
                    //btnNew.PerformClick();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Passwords Do Not Match");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Please fill the fields properly");
            }
        }
    }
}
