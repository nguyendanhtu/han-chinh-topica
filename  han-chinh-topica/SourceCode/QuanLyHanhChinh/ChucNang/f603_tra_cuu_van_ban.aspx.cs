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
        load_data_to_cbo_phong_ban();
        load_data_to_cbo_loai_cong_van();
        load_data_to_grid();
    }
    private void format_control(string ip_str_user)
    {
        string ip_str_ma_phong_ban = ip_str_user.ToUpper().Substring(3, ip_str_user.Length - 3);
        ListItem v_lsi = new ListItem(ip_str_ma_phong_ban);
        m_grv_dm_bill.Columns[2].Visible = false;
        m_grv_dm_bill.Columns[3].Visible = false;
        m_grv_dm_bill.Columns[3].Visible = false;
        m_grv_dm_bill.Columns[4].Visible = false;
        m_grv_dm_bill.Columns[5].Visible = false;
        m_grv_dm_bill.Columns[6].Visible = false;
        m_grv_dm_bill.Columns[7].Visible = false;
        m_grv_dm_bill.Columns[8].Visible = false;
        m_grv_dm_bill.Columns[9].Visible = false;
        if (m_cbo_loai_cong_van.SelectedValue.Equals("")) return;
        decimal v_dc_id_loai_cong_van = CIPConvert.ToDecimal(m_cbo_loai_cong_van.SelectedValue);
        if (v_dc_id_loai_cong_van == ID_LOAI_VAN_THU.CONG_VAN_DEN_KHONG_LUU)
        {
            m_grv_dm_bill.Columns[2].Visible = false;
            m_grv_dm_bill.Columns[3].Visible = true;
            m_grv_dm_bill.Columns[3].Visible = true;
            m_grv_dm_bill.Columns[4].Visible = true;
            m_grv_dm_bill.Columns[5].Visible = true;
            m_grv_dm_bill.Columns[6].Visible = true;
            m_grv_dm_bill.Columns[7].Visible = true;
            m_grv_dm_bill.Columns[8].Visible = false;
            m_grv_dm_bill.Columns[8].Visible = true;
        }
        else if (v_dc_id_loai_cong_van == ID_LOAI_VAN_THU.CONG_VAN_DEN_LUU)
        {
            m_grv_dm_bill.Columns[2].Visible = false;
            m_grv_dm_bill.Columns[3].Visible = true;
            m_grv_dm_bill.Columns[3].Visible = true;
            m_grv_dm_bill.Columns[4].Visible = true;
            m_grv_dm_bill.Columns[5].Visible = true;
            m_grv_dm_bill.Columns[6].Visible = true;
            m_grv_dm_bill.Columns[7].Visible = true;
            m_grv_dm_bill.Columns[8].Visible = false;
            m_grv_dm_bill.Columns[9].Visible = true;
        }
        else if (v_dc_id_loai_cong_van == ID_LOAI_VAN_THU.CONG_VAN_DI)
        {
            m_grv_dm_bill.Columns[2].Visible = true;
            m_grv_dm_bill.Columns[3].Visible = false;
            m_grv_dm_bill.Columns[3].Visible = false;
            m_grv_dm_bill.Columns[4].Visible = true;
            m_grv_dm_bill.Columns[5].Visible = true;
            m_grv_dm_bill.Columns[6].Visible = true;
            m_grv_dm_bill.Columns[7].Visible = false;
            m_grv_dm_bill.Columns[8].Visible = true;
            m_grv_dm_bill.Columns[9].Visible = true;
        }
        else if (v_dc_id_loai_cong_van == -1)
        {
            m_grv_dm_bill.Columns[2].Visible = true;
            m_grv_dm_bill.Columns[3].Visible = true;
            m_grv_dm_bill.Columns[3].Visible = true;
            m_grv_dm_bill.Columns[4].Visible = true;
            m_grv_dm_bill.Columns[5].Visible = true;
            m_grv_dm_bill.Columns[6].Visible = true;
            m_grv_dm_bill.Columns[7].Visible = true;
            m_grv_dm_bill.Columns[8].Visible = true;
            m_grv_dm_bill.Columns[9].Visible = true;
        }
        if (ip_str_user.ToLower().StartsWith("nv"))
        {
            m_grv_dm_bill.Columns[9].Visible = false;
            m_lbl_phong_ban.Visible = false;
        }
        if (ip_str_user.Contains("_"))
        {
            m_cbo_phong_ban.SelectedIndex = m_cbo_phong_ban.Items.IndexOf(m_cbo_phong_ban.Items.FindByText(ip_str_ma_phong_ban));
        }
        if (ip_str_user.ToLower().StartsWith("td") | ip_str_user == "admin")
        {
            m_grv_dm_bill.Columns[9].Visible = true;
            m_cbo_phong_ban.Visible = true;
            m_lbl_phong_ban.Visible = true;
        }
        else
        {
            m_cbo_phong_ban.Visible = false;
            m_lbl_phong_ban.Visible = false;
        }
        m_cbo_phong_ban.DataBind();
    }
    private void load_data_to_grid()
    {
        if (m_cbo_phong_ban.SelectedValue == null) return;
        if (Session[SESSION.UserID] == null) return;
        decimal v_dc_id_user = CIPConvert.ToDecimal(Session[SESSION.UserID]);
        US_HT_NGUOI_SU_DUNG v_us_ht_nguoi_su_dung = new US_HT_NGUOI_SU_DUNG(v_dc_id_user);
        format_control(v_us_ht_nguoi_su_dung.strTEN_TRUY_CAP);
        decimal v_dc_id_phong_ban = CIPConvert.ToDecimal(m_cbo_phong_ban.SelectedValue);
        decimal v_dc_id_loai_cong_van = CIPConvert.ToDecimal(m_cbo_loai_cong_van.SelectedValue);
        string v_str_command = "";
        v_str_command = "where  (id_nguoi_nhan_ban_luu=" + v_dc_id_phong_ban + " or id_noi_nguoi_nhan=" + v_dc_id_phong_ban;
        if (!v_us_ht_nguoi_su_dung.strMAIL.Equals(""))
            v_str_command += " or " + V_GD_VAN_THU_ALL.DANH_SACH_EMAIL_BAN_HANH + " like '%" + v_us_ht_nguoi_su_dung.strMAIL.Replace("@topica.edu.vn", "") + "%'" + ") ";
        else v_str_command += ") ";
        v_str_command += "and (id_loai_cong_van=" + v_dc_id_loai_cong_van + " or -1=" + v_dc_id_loai_cong_van + ")";
        if (!m_txt_tu_khoa.Text.Trim().Equals(""))
            v_str_command += " and (" + V_GD_VAN_THU_ALL.TEN_LOAI_VA_TRICH_YEU_ND + " like N'%" + m_txt_tu_khoa.Text.Trim() + "%'" +
                " or " + V_GD_VAN_THU_ALL.NGUOI_KY + " like N'%" + m_txt_tu_khoa.Text.Trim() + "%')";
        US_V_GD_VAN_THU_ALL v_us_gd_van_thu = new US_V_GD_VAN_THU_ALL();
        DS_V_GD_VAN_THU_ALL v_ds_gd_van_thu = new DS_V_GD_VAN_THU_ALL();
        v_us_gd_van_thu.FillDataset(v_ds_gd_van_thu, v_str_command);
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
        v_us_loai_cong_van.FillDataset(v_ds_loai_cong_van, "where id_loai_tu_dien=" + CONST_ID_CM_DM_LOAI_TD.ID_LOAI_CONG_VAN + " order by ten"/*id loai cong van*/);
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
