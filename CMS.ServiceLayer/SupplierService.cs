using CMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.ServiceLayer
{
    public class SupplierService
    {
        CMS_DBEntities cmd = new CMS_DBEntities();
        Supplier_Details md = new Supplier_Details();
        ConvertImage ci = new ConvertImage();
        ExportPdf pdf;

        public void AddSupplier(string name, string address, string city, string po, string contact, string email, string remarks, string accName, string accNo, string bName, string branch)
        {
            try
            {
                md.S_Name = name;
                md.Address = address;
                md.City = city;
                md.Postal_Code = po;
                md.Contact = contact;
                md.Email_ID = email;
                md.Remarks = remarks;
                md.Acc_Name = accName;
                md.Acc_No = accNo;
                md.Bank_Name = bName;
                md.Branch = branch;

                cmd.Supplier_Details.Add(md);
                cmd.SaveChanges();

                MessageBox.Show("Supplier Added succesfully");
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

        public List<Data.Supplier_Details> GetAllManager()
        {

            return cmd.Supplier_Details.ToList();
        }
    }
}
