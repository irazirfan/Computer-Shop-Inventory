using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.ServiceLayer
{
    public class ValidationHelper
    {
        public static bool IsIntValid(string value)
        {
            int id;
            return Int32.TryParse(value, out id);
        }

        public static bool IsStringValid(string value)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                return false;

            return true;
        }

        public static bool IsValidFloat(string value)
        {
            try
            {
                float.Parse(value);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
