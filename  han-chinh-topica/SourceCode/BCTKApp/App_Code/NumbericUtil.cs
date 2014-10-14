using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BCTKApp.App_Code
{
    public class NumbericUtil
    {
        public static bool IsNumberic(string v_ip_str_number)
        {
            if (string.IsNullOrEmpty(v_ip_str_number))
                return false;

            double v_d_ob_value = 0;
            return double.TryParse(v_ip_str_number, out v_d_ob_value);
        }
    }
}
