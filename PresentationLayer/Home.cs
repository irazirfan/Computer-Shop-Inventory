using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMS.Data;
using CMS.ServiceLayer;
using SplashScreen;

namespace PresentationLayer
{
    public partial class Home : MetroForm
    {
        ConvertImage ci = new ConvertImage();
        byte flag = 0;
        AdminService add = new  AdminService();
        CMS_DBEntities cmd=new  CMS_DBEntities();
        SplashForm sf = new SplashForm();
        public Home(byte flag)
        {
            InitializeComponent();
            this.flag = flag;
            if ( flag == 0)
            {
               Thread();
            }
        }

        void Thread()
        {
            Thread t = new Thread(new ThreadStart(Splash));
            t.Start();
            //Load data
            string str = string.Empty;
            for (int i = 0; i < 350; i++)
            {
                System.Threading.Thread.Sleep(1);
                str += i.ToString();
            }
            //complete
            t.Abort();
        }
        void Splash()
        {
                //SplashForm sf = new SplashForm();
                sf.AppName = "Computer Shop Managment System";
                sf.Icon = Properties.Resources.app;
                sf.ShowIcon = true;
            try
            {
                Application.Run(sf);
            }
            catch (Exception)
            {}
                
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlMenu.Hide();
            pnlCurrentUser.Hide();
            DisableAll();
            //lblWelcome.Text = "Welcome, " + LoginHelper.UserProfile.Name + "(" + LoginHelper.UserProfile.UserName + ")";
            FocusMe();
        }

        private void btnProMenu_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show();
            contextMenuStrip1.Location = Cursor.Position;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CMS_DBEntities context = new CMS_DBEntities();
            var obj = context.User_Details.FirstOrDefault(u=>u.Username.Equals(txtUsername.Text) && u.Password.Equals(txtPassword.Text));
            if (obj == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Invalid username or password!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }

            var up = new UserProfile()
            {
                ID = obj.U_ID,
                Name = obj.U_Name,
                UserName = obj.Username,
                Password = obj.Password,
                User_Type = obj.User_Type,
                UImage = ci.ConvertByteToImage(obj.Image)
            };

            LoginHelper.UserProfile = up;
            lblWelcome.Text = LoginHelper.UserProfile.Name;
            lblDate.Text = DateTime.Now.ToString();
            if(LoginHelper.UserProfile.UImage!=null)
                pbProfile.Image = LoginHelper.UserProfile.UImage;
            pnlMenu.Show();
            pnlCurrentUser.Show();
            pnlMain.Controls.Clear();

            switch (obj.User_Type)
            {
                case (int)EnumCollection.UserTypeEnum.Admin:
                    lblUDetails.Text = "Admin";
                    pbAdmin.Enabled = true;
                    pbManagers.Enabled = true;
                    break;
                case (int)EnumCollection.UserTypeEnum.SalesManager:
                    lblUDetails.Text = "Manager";
                    pbPEntry.Enabled = true;
                    pbPOrder.Enabled = true;
                    pbPReturn.Enabled = true;
                    pbSalesmen.Enabled = true;
                    pbSuppliers.Enabled = true;
                    break;
                case (int)EnumCollection.UserTypeEnum.Salesman:
                    lblUDetails.Text = "Salesman";
                    pbPEntry.Enabled = true;
                    pbPReturn.Enabled = true;
                    pbProducts.Enabled = true;
                    break;
                default:
                    break;

            }

        }

        private void DisableAll()
        {
            pbPEntry.Enabled = false;
            pbManagers.Enabled = false;
            pbPOrder.Enabled = false;
            pbPReturn.Enabled = false;
            pbProducts.Enabled = false;
            pbAdmin.Enabled = false;
            pbSalesmen.Enabled = false;
            pbSuppliers.Enabled = false;
        }
        
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            //logOutToolStripMenuItem_Click(this, e);
            Application.Exit();
            Logs("With Close Button");
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            Logs(DateTime.Now.ToString());
            Home hf = new Home(1);
            this.Hide();
            hf.Show();
        }

        private void Logs(string a)
        {
            var data = from d in cmd.User_Details
                where d.Username.ToString().Equals(lblWelcome.Text)
                select d;
            //string type="Admin";
            try
            {
                add.AddLogs(data.Single().U_ID, data.Single().U_Name, data.Single().User_Type.ToString(), lblDate.Text, a);
            }
            catch (Exception)
            { }

        }

        private void pbManagers_click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ManagerDetails md = new ManagerDetails();
            md.TopLevel = false;
            md.Dock = DockStyle.Fill;
            md.FormBorderStyle = FormBorderStyle.None;
            pnlMain.Controls.Add(md);
            md.Show();
        }

        private void pbSuppliers_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            SupplierManager supm = new SupplierManager();
            supm.TopLevel = false;
            supm.Dock = DockStyle.Fill;
            supm.FormBorderStyle = FormBorderStyle.None;
            pnlMain.Controls.Add(supm);
            supm.Show();
        }

        private void pbSalesmen_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            SalesmanManager salm = new SalesmanManager();
            salm.TopLevel = false;
            salm.Dock = DockStyle.Fill;
            salm.FormBorderStyle = FormBorderStyle.None;
            pnlMain.Controls.Add(salm);
            salm.Show();
        }

        private void pbPOrder_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            DetailsProductOrder dp = new DetailsProductOrder();
            dp.TopLevel = false;
            dp.Dock = DockStyle.Fill;
            dp.FormBorderStyle = FormBorderStyle.None;
            pnlMain.Controls.Add(dp);
            dp.Show();
        }

        private void pbPEntry_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            PurchaseEntry pe = new PurchaseEntry();
            pe.TopLevel = false;
            pe.Dock = DockStyle.Fill;
            pe.FormBorderStyle = FormBorderStyle.None;
            pnlMain.Controls.Add(pe);
            pe.Show();
        }

        private void pbPReturn_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            PurchaseReturn pr = new PurchaseReturn();
            pr.TopLevel = false;
            pr.Dock = DockStyle.Fill;
            pr.FormBorderStyle = FormBorderStyle.None;
            pnlMain.Controls.Add(pr);
            pr.Show();
        }

        private void pbProducts_Click(object sender, EventArgs e)
        {
            salesmenMenu.Show();
            salesmenMenu.Location = Cursor.Position;
        }

        private void pbAdmin_Click(object sender, EventArgs e)
        {
            adminMenu.Show();
            adminMenu.Location = Cursor.Position;
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = LoginHelper.UserProfile.ID;
            string name = LoginHelper.UserProfile.Name;
            string uName = LoginHelper.UserProfile.UserName;
            string pass = LoginHelper.UserProfile.Password;
            int uType = LoginHelper.UserProfile.User_Type;
            Image image = LoginHelper.UserProfile.UImage;

            AddUser au = new AddUser(id, name, uName, pass, uType, image, null);
            au.Visible = true;
        }

        private void accountsLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            AdminForm af = new AdminForm();
            af.TopLevel = false;
            af.Dock = DockStyle.Fill;
            af.FormBorderStyle = FormBorderStyle.None;
            pnlMain.Controls.Add(af);
            af.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            SalesManager sm = new SalesManager();
            sm.TopLevel = false;
            sm.Dock = DockStyle.Fill;
            sm.FormBorderStyle = FormBorderStyle.None;
            pnlMain.Controls.Add(sm);
            sm.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ProductManager pm = new ProductManager();
            pm.TopLevel = false;
            pm.Dock = DockStyle.Fill;
            pm.FormBorderStyle = FormBorderStyle.None;
            pnlMain.Controls.Add(pm);
            pm.Show();
        }

        private void pointOfSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            PointOfSale p = new PointOfSale();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            p.FormBorderStyle = FormBorderStyle.None;
            pnlMain.Controls.Add(p);
            p.Show();
        }
    }
}
