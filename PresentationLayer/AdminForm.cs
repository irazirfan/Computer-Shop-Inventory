using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  CMS.Data;

namespace PresentationLayer
{
    public partial class AdminForm : Form
    {
        CMS_DBEntities cmd=new  CMS_DBEntities();
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnUDetails_Click(object sender, EventArgs e)
        {
            btnRemove.Enabled = true;
            txtSearch.Visible = false;
            dgUDetails.Visible = true;
            dgUDetails.BringToFront();
            dgUDetails.Dock = DockStyle.Fill;
            userDetailsBindingSource.DataSource = cmd.User_Details.ToList();
            for (int i = 0; i <= dgUDetails.Rows.Count - 1; i++)
            {
                dgUDetails.Rows[i].Height = 80;
            }
        }

        private void btnLDetails_Click(object sender, EventArgs e)
        {
            btnRemove.Enabled = false;
            dgLDetails.Visible = true;
            dgLDetails.BringToFront();
            dgLDetails.Dock = DockStyle.Fill;
            loggingDetailsBindingSource.DataSource = cmd.Logging_Details.ToList();
            txtSearch.Visible = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (userDetailsBindingSource.Current != null)
            {
                User_Details u=new User_Details();
                u = userDetailsBindingSource.Current as User_Details;
                if (u.User_Type != 1)
                {
                    if (MessageBox.Show("Are you sure ?", "Message", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cmd.User_Details.Remove(userDetailsBindingSource.Current as User_Details);
                        userDetailsBindingSource.RemoveCurrent();
                        cmd.SaveChanges();
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loggingDetailsBindingSource.DataSource = cmd.Logging_Details.Where(x => x.User_Name.Contains(txtSearch.Text)).ToList();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            btnRemove.Enabled = false;
        }
    }
}
