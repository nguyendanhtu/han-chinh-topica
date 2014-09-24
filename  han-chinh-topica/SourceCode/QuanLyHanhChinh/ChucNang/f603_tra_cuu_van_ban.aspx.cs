using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using IP.Core.IPData;
using BCTKDS;
using BCTKUS;
using BCTKDS.CDBNames;
public partial class ChucNang_f603_tra_cuu_van_ban : System.Web.UI.Page
{
    #region Public Methods
    //public string get_ngay_thang_cong_vang(string ip_str_id_loai_cong_van, string ip_str_ngay_thang_tren_cong_van, string ip_str_ngay_lap)
    //{
    //    string v_str_result = "";
    //    decimal v_dc_id_loai_cong_van = CIPConvert.ToDecimal(ip_str_id_loai_cong_van);
    //    if (v_dc_id_loai_cong_van == 223)//id cong van di
    //        v_str_result = ip_str_ngay_lap;
    //    else v_str_result = ip_str_ngay_thang_tren_cong_van;
    //    return v_str_result;
    //}
    //public string get_so_va_ky_hieu_cong_van(string ip_str_id_loai_cong_van, string ip_str_so_cv_den, string ip_str_so_va_ky_hieu)
    //{
    //    string v_str_result = "";
    //    decimal v_dc_id_loai_cong_van = CIPConvert.ToDecimal(ip_str_id_loai_cong_van);
    //    if (v_dc_id_loai_cong_van == 223)//id cong van di
    //        v_str_result = ip_str_so_va_ky_hieu;
    //    else v_str_result = ip_str_so_cv_den+;
    //    return v_str_result;
    //}
    #endregion

    #region Private Methods
    private void set_inital_form_load()
    {
        format_control("");
        load_data_to_cbo_phong_ban();
        load_data_to_cbo_loai_cong_van();
        load_data_to_grid();
    }
    private void format_control(string ip_str_form_mode)
    {

    }
    private void load_data_to_grid()
    {
        if (m_cbo_phong_ban.SelectedValue == null) return;
        decimal v_dc_id_phong_ban = CIPConvert.ToDecimal(m_cbo_phong_ban.SelectedValue);
        decimal v_dc_id_loai_cong_van = CIPConvert.ToDecimal(m_cbo_loai_cong_van.SelectedValue);
        string v_str_command = "";
        v_str_command="where  (id_nguoi_nhan_ban_luu=" + v_dc_id_phong_ban + " or id_noi_nguoi_nhan=" + v_dc_id_phong_ban + ") and (id_loai_cong_van=" + v_dc_id_loai_cong_van + " or -1="+v_dc_id_loai_cong_van+")";
        US_V_GD_VAN_THU_ALL v_us_gd_van_thu = new US_V_GD_VAN_THU_ALL();
        DS_V_GD_VAN_THU_ALL v_ds_gd_van_thu = new DS_V_GD_VAN_THU_ALL();
        v_us_gd_van_thu.FillDataset(v_ds_gd_van_thu,v_str_command);
        m_grv_dm_bill.DataSource = v_ds_gd_van_thu.V_GD_VAN_THU_ALL;
        m_grv_dm_bill.DataBind();
    }
    private void load_data_to_cbo_phong_ban()
    {
        US_DM_PHONG_BAN v_us_dm_phong_ban = new US_DM_PHONG_BAN();
        DS_DM_PHONG_BAN v_ds_dm_phong_ban = new DS_DM_PHONG_BAN();
        v_us_dm_phong_ban.FillDataset(v_ds_dm_phong_ban, "order by ma_phong_ban");
        m_cbo_phong_ban.DataValueField = DM_PHONG_BAN.ID;
        m_cbo_phong_ban.DataTextField = DM_PHONG_BAN.MA_PHONG_BAN;
        m_cbo_phong_ban.DataSource = v_ds_dm_phong_ban.DM_PHONG_BAN;
        m_cbo_phong_ban.DataBind();
    }
    private void load_data_to_cbo_loai_cong_van()
    {
        BCTKUS.US_CM_DM_TU_DIEN v_us_loai_cong_van = new BCTKUS.US_CM_DM_TU_DIEN();
        BCTKDS.DS_CM_DM_TU_DIEN v_ds_loai_cong_van = new BCTKDS.DS_CM_DM_TU_DIEN();
        v_us_loai_cong_van.FillDataset(v_ds_loai_cong_van, "where id_loai_tu_dien=23"/*id loai cong van*/);
        m_cbo_loai_cong_van.DataTextField = CM_DM_TU_DIEN.TEN;
        m_cbo_loai_cong_van.DataValueField = CM_DM_TU_DIEN.ID;
        m_cbo_loai_cong_van.DataSource = v_ds_loai_cong_van.CM_DM_TU_DIEN;
        m_cbo_loai_cong_van.DataBind();
        m_cbo_loai_cong_van.Items.Insert(0, new ListItem("Tất cả", "-1"));
    }
    #endregion
   
    #region Events
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                set_inital_form_load();
            }
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
    #endregion
}