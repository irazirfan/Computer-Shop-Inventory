using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.Data;
using System.Windows.Forms;

namespace CMS.ServiceLayer
{
    public class SalesmanService
    {
        CMS_DBEntities cmd = new CMS_DBEntities();
        Salesman_Details po = new Salesman_Details();
        ConvertImage ci = new ConvertImage();
        POS p = new POS();

        public bool AddSalesman(string name, string address, string city, string pc, string no, string email, int com, string remarks, string path)
        {
            try
            {
                po.Name = name;
                po.Address = address;
                po.City = city;
                po.Postal_Code = pc;
                po.Contact_No = no;
                po.Email_ID = email;
                po.Commission = com;
                po.Remarks = remarks;
                po.Image = ci.ConvertFileToByte(path);

                cmd.Salesman_Details.Add(po);
                cmd.SaveChanges();
                MessageBox.Show("Salesman Added succesfully");
                return true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("OOPs something went wrong !!!");
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void POPdf(DataGridView dg, string fileName)
        {
            ExportPdf pdf = new ExportPdf();
            pdf.Convert(dg, fileName);
        }

        public void CreatePDF(DataGridView dg, string filename)
        {
            ExportPdf pdf = new ExportPdf();
            pdf.Convert(dg, filename);
        }


        public bool AddPOS(int pId, string pName, float price, int q, float total)
        {
            try
            {
                p.P_Id = pId;
                p.P_Name= pName;
                p.Price = price;
                p.Quantity = q;
                p.Total = total;

                cmd.POS.Add(p);
                cmd.SaveChanges();
                MessageBox.Show("Product Added succesfully");
                return true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("OOPs something went wrong !!!");
                MessageBox.Show(ex.Message);
                return false;
            }
        }


    }
}
