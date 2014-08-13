﻿using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IP.Core.IPException;
using IP.Core.IPCommon;

public partial class MessageError : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try {

            if (Request.QueryString["mess"] != null)
            {
                lblErrorMessage.Text = Request.QueryString["mess"].ToString().Replace("%20", " ");
            }
        }
        catch (Exception v_e) {
            
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
}