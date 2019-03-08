using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace CMS.ServiceLayer
{
    public class ConvertImage
    {
        public byte[] ConvertFileToByte(string path)
        {
            byte[] data = null;
            FileInfo info = new FileInfo(path);
            long bytes = info.Length;
            FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(stream);
            data = br.ReadBytes((int)bytes);
            return data;
        }

        public Image ConvertByteToImage(byte[] photo)
        {
            Image newImage=null;
            if(photo!=null)
            {
                using (MemoryStream ms = new MemoryStream(photo, 0, photo.Length))
                 {
                      ms.Write(photo, 0, photo.Length);
                      newImage = Image.FromStream(ms, true);
                }
                return newImage;
            }

            return newImage;
        }

        public byte[] ImageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

    }
}
