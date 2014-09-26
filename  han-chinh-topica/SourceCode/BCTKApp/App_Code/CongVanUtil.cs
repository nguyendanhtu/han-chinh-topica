using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace BCTKApp.App_Code
{
    public class CongVanUtil
    {
        public static List<String> get_list_ky_hieu_cong_van()
        {
            var v_lst_ky_hieu = new List<String>();
            var v_array_properties = typeof(KyHieuCongVanConstant).GetFields();

            foreach (var v_prop_info in v_array_properties)
            {
                v_lst_ky_hieu.Add((v_prop_info as FieldInfo).GetValue(v_prop_info.DeclaringType).ToString());
            }

            return v_lst_ky_hieu;
        }
    }
}
