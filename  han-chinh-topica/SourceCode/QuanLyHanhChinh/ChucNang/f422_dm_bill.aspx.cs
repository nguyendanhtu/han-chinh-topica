using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BCTKDS;
using BCTKDS.CDBNames;
using BCTKUS;
using IP.Core.IPCommon;
public partial class ChucNang_f422_dm_bill : System.Web.UI.Page
{
    #region Public Interfaces

    #endregion

    #region Member

    #endregion

    #region Data Structure

    #endregion

    #region Private Methods
    private void load_data_to_grid()
    {
        US_DM_BILL v_us_dm_bill = new US_DM_BILL();
        DS_DM_BILL v_ds_dm_bill = new DS_DM_BILL();
        v_us_dm_bill.FillDataset(v_ds_dm_bill);
        m_grv_dm_bill.DataSource = v_ds_dm_bill.DM_BILL;
        m_grv_dm_bill.DataBind();
    }
    #endregion

    #region Events
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            load_data_to_grid();
        }
        catch (System.Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    #endregion
}