using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BCTKDS;
using BCTKDS.CDBNames;
using BCTKUS;

using IP.Core.IPCommon;
using IP.Core.IPUserService;

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
        decimal v_id_trung_tam = CIPConvert.ToDecimal(m_hdf_id_trung_tam.Value);
        decimal v_dc_id_trang_thai = CIPConvert.ToDecimal(m_cbo_trang_thai.SelectedValue);
        string v_str_tu_khoa = m_txt_tim_kiem.Text.Trim();
        US_V_DM_BILL v_us_v_dm_bill = new US_V_DM_BILL();
        DS_V_DM_BILL v_ds_v_dm_bill = new DS_V_DM_BILL();
        v_us_v_dm_bill.FillDataset(v_ds_v_dm_bill, v_id_trung_tam, m_dat_tu_ngay.SelectedDate, m_dat_den_ngay.SelectedDate, v_dc_id_trang_thai, v_str_tu_khoa);
        m_grv_v_dm_bill.DataSource = v_ds_v_dm_bill.V_DM_BILL;
        m_grv_v_dm_bill.DataBind();
    }
    private void set_time()
    {
        m_dat_tu_ngay.SelectedDate = new DateTime(2013, 01, 01);
    }
    private void load_cbo_trang_thai()
    {
        BCTKUS.US_CM_DM_TU_DIEN v_us = new BCTKUS.US_CM_DM_TU_DIEN();
        DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
        v_us.FillDataset(v_ds, "where ID_LOAI_TU_DIEN=" + 12);
        m_cbo_trang_thai.DataSource = v_ds.CM_DM_TU_DIEN;
        m_cbo_trang_thai.DataValueField = CM_DM_TU_DIEN.ID;
        m_cbo_trang_thai.DataTextField = CM_DM_TU_DIEN.TEN;
        m_cbo_trang_thai.DataBind();
    }
    #endregion

    #region Events
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                US_HT_NGUOI_SU_DUNG v_us_nguoi_su_dung = new US_HT_NGUOI_SU_DUNG();
                if (Session[SESSION.AccounLoginYN] == "Y")
                {
                    decimal v_id_user = CIPConvert.ToDecimal(Session[SESSION.UserID]);
                    US_HT_NGUOI_SU_DUNG v_us_ht_nguoi_su_dung = new US_HT_NGUOI_SU_DUNG();
                    IP.Core.IPData.DS_HT_NGUOI_SU_DUNG v_ds_ht_nguoi_su_dung = new IP.Core.IPData.DS_HT_NGUOI_SU_DUNG();
                    v_us_ht_nguoi_su_dung.FillDataset(v_ds_ht_nguoi_su_dung, " WHERE ID =" + v_id_user);
                    decimal v_id_user_group = CIPConvert.ToDecimal(v_ds_ht_nguoi_su_dung.HT_NGUOI_SU_DUNG.Rows[0]["ID_USER_GROUP"]);
                    US_HT_QUAN_HE_SU_DUNG_DU_LIEU v_us_ht_qh_sd_dl = new US_HT_QUAN_HE_SU_DUNG_DU_LIEU();
                    DS_HT_QUAN_HE_SU_DUNG_DU_LIEU v_ds_ht_qh_sd_dl = new DS_HT_QUAN_HE_SU_DUNG_DU_LIEU();
                    v_us_ht_qh_sd_dl.FillDataset(v_ds_ht_qh_sd_dl, "where ID_USER_GROUP =" + v_id_user_group);
                    m_hdf_id_trung_tam.Value = v_ds_ht_qh_sd_dl.HT_QUAN_HE_SU_DUNG_DU_LIEU.Rows[0]["ID_PHONG_BAN"].ToString();

                }
                else
                {
                    Response.Redirect("../Default.aspx", false);
                    HttpContext.Current.ApplicationInstance.CompleteRequest();
                }
                set_time();
                load_cbo_trang_thai();
                load_data_to_grid();
            }
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
    protected void m_cmd_tim_kiem_Click(object sender, EventArgs e)
    {
        try
        {
            load_data_to_grid();
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_dat_tu_ngay_DateChanged(object sender, EventArgs e)
    {
        try
        {
            load_data_to_grid();
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_dat_den_ngay_DateChanged(object sender, EventArgs e)
    {
        try
        {
            load_data_to_grid();
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
}