using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.Drawing;

namespace CMS.ServiceLayer
{
    public class UserProfile
    {
        public int ID { get; set; }
        public string Name { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public int User_Type { set; get; }
        public Image UImage { set; get; }
    }
}
