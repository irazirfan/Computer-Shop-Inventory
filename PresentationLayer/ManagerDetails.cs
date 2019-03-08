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
    public partial class ManagerDetails : Form
    {
        CMS_DBEntities cmd = new CMS_DBEntities();
        AdminService ad = new AdminService();
        ConvertImage ci=new  ConvertImage();

        public ManagerDetails()
        {
            InitializeComponent();
        }

        private void ManagerDetails_Load(object sender, EventArgs e)
        {
            managerdetailsBindingSource.DataSource = cmd.Manager_details.ToList();
            cmbCities.DataSource = ad.GetAllCities();
            cmbCities.DisplayMember = "Name";

            for (int i = 0; i <= dgMDetails.Rows.Count - 1; i++)
            {
                dgMDetails.Rows[i].Height = 80;
            }
        }

        private void ProductManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (managerdetailsBindingSource.Current == null)
                return;

            using (AddManager am = new AddManager(managerdetailsBindingSource.Current as Manager_details))
            {
                if (am.ShowDialog() == DialogResult.OK)
                    managerdetailsBindingSource.DataSource = cmd.Manager_details.ToList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(managerdetailsBindingSource.Current !=null)
            {
                if(MessageBox.Show("Are you sure ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    int id = ((Manager_details)managerdetailsBindingSource.Current).MId;
                    cmd.Manager_details.Remove(managerdetailsBindingSource.Current as Manager_details);
                    managerdetailsBindingSource.RemoveCurrent();
                    cmd.SaveChanges();

                    //MessageBox.Show(id.ToString());

                    User_Details u = new User_Details();
                    u = cmd.User_Details.First(x => x.U_ID == id);
                    cmd.User_Details.Remove(u);
                    cmd.SaveChanges();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddManager a = new AddManager(null);
            a.Visible = true;
            //this.Visible = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (cmbOption.Text == "MId")
                dgMDetails.DataSource = cmd.Manager_details.Where(x => x.MId.ToString().Contains(txtSearch.Text)).ToList();
               
            else if (cmbOption.Text == "City")
                dgMDetails.DataSource = cmd.Manager_details.Where(x => x.MName.Contains(txtSearch.Text) 
                                            && x.City.Contains(cmbCities.Text)).ToList();
            else
            {
                dgMDetails.DataSource = cmd.Manager_details.Where(x => x.MName.Contains(txtSearch.Text)).ToList();
            }

            for (int i = 0; i <= dgMDetails.Rows.Count - 1; i++)
            {
                dgMDetails.Rows[i].Height = 80;
            }
        }

        private void cmbOption_TextChanged(object sender, EventArgs e)
        {
            if (cmbOption.Text == "City")
            {
                cmbCities.Visible = true;
            }
            else
                cmbCities.Visible = false;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objB = new Bitmap(dgMDetails.Width, dgMDetails.Height);
            dgMDetails.DrawToBitmap(objB, new Rectangle(0, 0, dgMDetails.Width, dgMDetails.Height));

            e.Graphics.DrawImage(objB, 25, 120);

            e.Graphics.DrawString(metroLabel1.Text, new Font("Verdana", 20, FontStyle.Italic), Brushes.Black, new Point(280, 30));
            e.Graphics.DrawString("Printed : "+DateTime.Now.ToString(), new Font("Verdana", 10, FontStyle.Italic), Brushes.Black, new Point(600, 50));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            ad.CreatePDF(dgMDetails, "Manager Details");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            managerdetailsBindingSource.DataSource = cmd.Manager_details.ToList();
            for (int i = 0; i <= dgMDetails.Rows.Count - 1; i++)
            {
                dgMDetails.Rows[i].Height = 80;
            }
        }
    }
}
