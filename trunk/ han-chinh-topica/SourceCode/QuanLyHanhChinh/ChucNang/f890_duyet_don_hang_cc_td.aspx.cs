using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BCTKUS;
using BCTKDS;
using BCTKDS.CDBNames;

using IP.Core.IPCommon;
using IP.Core.WinFormControls;
using IP.Core.IPUserService;

public partial class ChucNang_f890_duyet_don_hang_cc_td : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e)
    {
        DS_GD_DON_DAT_HANG v_ds= new DS_GD_DON_DAT_HANG();
        US_GD_DON_DAT_HANG v_us= new US_GD_DON_DAT_HANG();
        string temp = "01/08/2014";
        v_us.load_ddh_xin_td_duyet(v_ds, 132, CIPConvert.ToDatetime(temp));
        m_lbl_title.Text = "Trung tâm TAD";
        m_grv_don_hang_nhap.DataSource = v_ds.GD_DON_DAT_HANG;
        m_grv_don_hang_nhap.DataBind();
    }
}