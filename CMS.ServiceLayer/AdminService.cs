using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using  System.Drawing;
using  CMS.Data;

namespace CMS.ServiceLayer
{
    public class AdminService
    {
        CMS_DBEntities cmd = new CMS_DBEntities();
        Manager_details md = new Manager_details();
        User_Details ud=new  User_Details();
        Logging_Details lo=new Logging_Details();
        ConvertImage ci = new ConvertImage();
        ExportPdf pdf;

        public bool AddManager(string name, string address, string city, int code, string contact, string email, int commission, string remarks, string path)
        {
            try
            {
                md.MName = name;
                md.Address = address;
                md.City = city;
                md.Postal_code = code;
                md.Contact = "+88" + contact;
                md.Email = email;
                md.Commission = commission;
                md.Remarks = remarks;
                md.Image = ci.ConvertFileToByte(path);

                cmd.Manager_details.Add(md);
                cmd.SaveChanges();

                MessageBox.Show("Manager Added succesfully");
                return true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("OOPs something went wrong !!!");
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void AddUser(int id, string name, string uname, string pass, int utype, string path)
        {
            try
            {
                ud.U_ID = id;
                ud.U_Name = name;
                ud.Username = uname;
                ud.Password = pass;
                ud.User_Type = utype;
                ud.Image = ci.ConvertFileToByte(path);

                cmd.User_Details.Add(ud);
                cmd.SaveChanges();

                MessageBox.Show("User Added succesfully");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("OOPs something went wrong !!!");
                MessageBox.Show(ex.Message);
            }
        }

        public void AddLogs(int id, string name, string utype, string sitime, string sotime)
        {
            try
            {
                lo.User_Id = id;
                lo.User_Name = name;
                lo.User_Type = utype;
                lo.Sign_In_Time = sitime;
                lo.Sign_Out_Type = sotime;

                cmd.Logging_Details.Add(lo);
                cmd.SaveChanges();

                //MessageBox.Show("User Added succesfully");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("OOPs something went wrong !!!");
                MessageBox.Show(ex.Message);
            }
        }

        public void CreatePDF(DataGridView dg, string filename)
        {
            pdf = new ExportPdf();
            pdf.Convert(dg, filename);
        }
        
        public List<Data.Manager_details> GetAllManager()
        {

            return cmd.Manager_details.ToList();
        }

        public List<Data.City> GetAllCities()
        {

            return cmd.Cities.ToList();
        }

    }
}
