using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.Data;
using System.Windows.Forms;

namespace CMS.ServiceLayer
{
    public class ManagerService
    {
        CMS_DBEntities cmd = new CMS_DBEntities();
        Product_Order po = new Product_Order();
        Purchase_Entry pe = new Purchase_Entry();
        Purchase_Return pr = new Purchase_Return();

        public void AddPo(string date, int id, string name, int q, float ppu, int dis)
        {
            try
            {
                po.PODate = date;
                po.SupplierId = id;
                po.PName = name;
                po.Quabtity = q;
                po.PPU = ppu;
                po.Discount = dis;
                cmd.Product_Order.Add(po);

                cmd.SaveChanges();
                MessageBox.Show("Product Added succesfully");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("OOPs something went wrong !!!");
                MessageBox.Show(ex.Message);
            }
        }

        public void AddPE(int poid, int supid, string pay)
        {
            try
            {
                pe.PONo = poid;
                pe.SupplierId = supid;
                pe.Paymet = pay;

                cmd.Purchase_Entry.Add(pe);
                cmd.SaveChanges();
                MessageBox.Show("Purchase Entry Added succesfully");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("OOPs something went wrong !!!");
                MessageBox.Show(ex.Message);
            }
        }

        public void AddPR(int peid, int quantity)
        {
            try
            {
                pr.PEId = peid;
                pr.ReturnQuantity = quantity;

                cmd.Purchase_Return.Add(pr);
                cmd.SaveChanges();
                MessageBox.Show("Purchase Entry Added succesfully");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("OOPs something went wrong !!!");
                MessageBox.Show(ex.Message);
            }
        }

        public void POPdf(DataGridView dg, string fileName)
        {
            ExportPdf p = new ExportPdf();
            p.Convert(dg, fileName);
        }
    }
}
