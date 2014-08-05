using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BCTKDS;
using BCTKUS;
using BCTKDS.CDBNames;
using IP.Core.IPUserService;
using IP.Core.IPData;
public partial class test : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        US_HT_NGUOI_SU_DUNG v_us = new US_HT_NGUOI_SU_DUNG();
        DS_HT_NGUOI_SU_DUNG v_ds = new DS_HT_NGUOI_SU_DUNG();
        v_us.FillDataset(v_ds);
        m_cbo_bill.DataSource = v_ds.HT_NGUOI_SU_DUNG;
        m_cbo_bill.DataValueField = HT_NGUOI_SU_DUNG.ID;
        m_cbo_bill.DataTextField=HT_NGUOI_SU_DUNG.TEN;
        m_cbo_bill.DataBind();
    }
}