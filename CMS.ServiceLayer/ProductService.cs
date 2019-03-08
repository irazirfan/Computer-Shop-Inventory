using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMS.Data;


namespace CMS.ServiceLayer
{
    public class ProductService
    {
        CMS_DBEntities cmd = new CMS_DBEntities();
        Product_Details md = new Product_Details();
        ConvertImage ci = new ConvertImage();

        public void AddProduct(string name, string desc, string cat, string path, int pu,int sr, int stock, int ro, int pr)
        {
            try
            {
                md.P_Name = name;
                md.Description = desc;
                md.P_Category = cat;
                md.Purchase_Rate = pr;
                md.Purchase_Unit = pu;
                md.Reorder_Point = ro;
                md.Sales_Rate = sr;
                md.Stock = stock;
                md.Image = ci.ConvertFileToByte(path);

                cmd.Product_Details.Add(md);
                cmd.SaveChanges();

                MessageBox.Show("Product Added succesfully");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("OOPs something went wrong !!!");
                MessageBox.Show(ex.Message);
            }
        }

        public void CreatePDF(DataGridView dg, string filename)
        {
            ExportPdf pdf= new ExportPdf();
            pdf.Convert(dg, filename);
        }

        public List<Data.Product_Details> GetAllManager()
        {

            return cmd.Product_Details.ToList();
        }

        public List<Data.City> GetAllCities()
        {

            return cmd.Cities.ToList();
        }
    }
}
