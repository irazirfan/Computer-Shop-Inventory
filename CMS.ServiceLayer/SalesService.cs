using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMS.Data;

namespace CMS.ServiceLayer
{
    public class SalesService
    {
        CMS_DBEntities cmd = new CMS_DBEntities();
        Sales_Details sd = new Sales_Details();

        public void CreatePDF(DataGridView dg, string filename)
        {
            ExportPdf pdf = new ExportPdf();
            pdf.Convert(dg, filename);
        }

        public List<Data.Sales_Details> GetAllManager()
        {

            return cmd.Sales_Details.ToList();
        }

        public void AddSales(string inNo, string date, string proId, int q, float price, float total)
        {
            try
            {
                sd.Invoice_No = inNo;
                sd.Date = date;
                sd.Pro_ID = proId;
                sd.Quantity = q;
                sd.Price = price;
                sd.Total = total;

                cmd.Sales_Details.Add(sd);
                cmd.SaveChanges();
                MessageBox.Show("Sales Added succesfully");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("OOPs something went wrong !!!");
                MessageBox.Show(ex.Message);
            }
        }
    }
}
