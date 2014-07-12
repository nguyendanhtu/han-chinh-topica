using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BCTKDS;
using BCTKDS.CDBNames;
using BCTKUS;

using IP.Core.IPCommon;

public partial class ChucNang_f444_tra_cuu_trang_thai : System.Web.UI.Page
{
    #region Public Interfaces
    #endregion

    #region Members
    #endregion

    #region Data Structure
    #endregion

    #region Private Methods
    private void load_data_to_grid()
    {
        US_V_DM_BILL v_us_v_dm_bill = new US_V_DM_BILL();
        DS_V_DM_BILL v_ds_v_dm_bill = new DS_V_DM_BILL();
        v_us_v_dm_bill.FillDataset(v_ds_v_dm_bill);
        m_grv_v_dm_bill.DataSource = v_ds_v_dm_bill.V_DM_BILL;
        m_grv_v_dm_bill.DataBind();
    }
    private void load_cbo_trang_thai()
    {
        
    }
    #endregion

    #region Events
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            load_data_to_grid();
            load_cbo_trang_thai();
        }
        catch (System.Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    #endregion
    protected void m_grv_v_dm_bill_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            m_grv_v_dm_bill.PageIndex = e.NewPageIndex;
            m_grv_v_dm_bill.DataBind();
        }
        catch (Exception v_e)
        {
            
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
}