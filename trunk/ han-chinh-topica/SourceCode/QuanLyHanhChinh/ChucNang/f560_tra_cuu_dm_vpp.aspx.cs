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
//using System.Windows.Forms;
using System.Data;

public partial class ChucNang_f560_tra_cuu_dm_vpp : System.Web.UI.Page
{

    #region Members
    US_V_DM_VPP m_us = new US_V_DM_VPP();
    DS_V_DM_VPP m_ds = new DS_V_DM_VPP();
    #endregion

    #region Data structure

    #endregion

    #region Private Method
    private void load_data_2_grid()
    {
        decimal v_dc_tu_khoa = CIPConvert.ToDecimal(m_cbo_tim_kiem.SelectedValue);
        decimal v_id_nha_cc = CIPConvert.ToDecimal(m_cbo_nha_cc.SelectedValue);
        DS_V_DM_VPP v_ds = new DS_V_DM_VPP();
        US_V_DM_VPP v_us = new US_V_DM_VPP();
        v_us.FillDatasetsearch(v_ds, v_id_nha_cc, v_dc_tu_khoa);
        m_grv_dm_vpp.DataSource = v_ds.V_DM_VPP;
        string v_str_thong_tin = " (Có " + v_ds.V_DM_VPP.Rows.Count + " mặt hàng)";
        m_lbl_thong_tim_grv_dm_vpp.Text = v_str_thong_tin;
        m_grv_dm_vpp.DataBind();
    }
    private void set_inital_form_mode()
    {
        load_data_2_cbo();
        load_m_cbo_tim_kiem();
        load_data_2_grid();
        
    }
    private void load_data_2_cbo() 
    {
        US_DM_NHA_CUNG_CAP v_us = new US_DM_NHA_CUNG_CAP();
        DS_DM_NHA_CUNG_CAP v_ds = new DS_DM_NHA_CUNG_CAP();
        v_us.FillDataset(v_ds);
        m_cbo_nha_cc.DataSource = v_ds.DM_NHA_CUNG_CAP;
        m_cbo_nha_cc.DataValueField = DM_NHA_CUNG_CAP.ID;
        m_cbo_nha_cc.DataTextField = DM_NHA_CUNG_CAP.TEN;
        DataRow v_dr = v_ds.DM_NHA_CUNG_CAP.NewRow();
        v_dr[DM_NHA_CUNG_CAP.ID] = -1;
        v_dr[DM_NHA_CUNG_CAP.TEN] = "-----------------------------------------Tất cả----------------------------------------";
        v_dr[DM_NHA_CUNG_CAP.WEB] = "";
        v_dr[DM_NHA_CUNG_CAP.DIA_CHI] = "";
        v_dr[DM_NHA_CUNG_CAP.DIEN_THOAI] = "";
        v_dr[DM_NHA_CUNG_CAP.EMAIL] = " ";
        v_dr[DM_NHA_CUNG_CAP.FAX] = " ";
        v_ds.DM_NHA_CUNG_CAP.Rows.InsertAt(v_dr, 0);
        m_cbo_nha_cc.SelectedIndex = 0;
        m_cbo_nha_cc.DataBind();
    }
    private void load_m_cbo_tim_kiem()
    { 
        US_DM_VPP v_us = new US_DM_VPP();
        DS_DM_VPP v_ds = new DS_DM_VPP();
        v_us.FillDataset(v_ds);
        m_cbo_tim_kiem.DataSource = v_ds.DM_VPP;
        m_cbo_tim_kiem.DataValueField = DM_VPP.ID;
        m_cbo_tim_kiem.DataTextField = DM_VPP.TEN;
        DataRow v_dr = v_ds.DM_VPP.NewRow();
        v_dr[DM_VPP.ID] = -1;
        v_dr[DM_VPP.TEN] = "------------Tất cả----------";
        v_dr[DM_VPP.ID_NHA_CUNG_CAP] = -1;
        v_dr[DM_VPP.DON_VI_TINH] = "";
        v_dr[DM_VPP.MA] = "10001";
        //v_dr[DM_VPP.DON_GIA_CHUA_VAT] = 0;
        //v_dr[DM_VPP.DON_GIA_GOM_VAT] = 0;
        v_ds.DM_VPP.Rows.InsertAt(v_dr, 0);
        m_cbo_tim_kiem.SelectedIndex = 0;
        m_cbo_tim_kiem.DataBind();
    }
    #endregion

    #region Event
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            //this.Form.DefaultButton = m_cmd_tim_kiem.UniqueID;
            if (!IsPostBack)
            {
                set_inital_form_mode();
            }
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_grv_dm_vpp_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            m_grv_dm_vpp.PageIndex = e.NewPageIndex;
            m_grv_dm_vpp.DataBind();
            load_data_2_grid();
        }
        catch (Exception v_e)
        {

            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_cmd_tim_kiem_Click(object sender, EventArgs e)
    {
        try
        {
            load_data_2_grid();
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }


    #endregion
}

