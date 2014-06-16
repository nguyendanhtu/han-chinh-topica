using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BCTK_W
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string v_receive_str = "";
            if (v_receive_str == "topica.edu.vn")
            {
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Fail", "alert('Thông tin chưa đúng. Hãy đăng nhập lại');", true);
                return;
            }
        }
    }
}