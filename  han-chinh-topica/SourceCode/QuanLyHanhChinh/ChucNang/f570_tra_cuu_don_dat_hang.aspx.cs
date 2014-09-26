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
using System.Windows.Forms;
using System.Data;

public partial class ChucNang_f570_tra_cuu_don_dat_hang : System.Web.UI.Page
{
    #region Public Interfaces
    public string get_so_tien_thanh_toan(string ip_str_so_luong, string ip_str_don_gia)
    {
        string v_str_result = "";
        if (ip_str_so_luong.Equals("")) return "0";
        if (ip_str_don_gia.Equals("")) return "0";
        v_str_result = CIPConvert.ToStr(CIPConvert.ToDecimal(ip_str_so_luong.Replace(",", "")) * CIPConvert.ToDecimal(ip_str_don_gia.Replace(",", "")), "#,###,##");
        return v_str_result;
    }
    #endregion
    #region Member
    US_GD_DON_DAT_HANG m_us = new US_GD_DON_DAT_HANG();
    DS_GD_DON_DAT_HANG m_ds = new DS_GD_DON_DAT_HANG();
    #endregion
    #region Private Method
    private void set_inital_form_mode()
    {
        load_title();
        m_txt_thang.Text = DateTime.Now.Date.ToString("MM/yyyy");
        load_data_2_grid();

    }
    private void view_detail_grv(bool ip_visible)
    {
        mtv_detail.SetActiveView(View_detail);
        m_pnl_detail_grv.Visible = ip_visible;
    }
    private void load_data_2_grid()
    {
        DateTime v_dat_thang = CIPConvert.ToDatetime("01/" + m_txt_thang.Text);
        decimal v_id_trung_tam = CIPConvert.ToDecimal(m_hdf_id_trung_tam.Value);
        string v_str_tu_khoa=m_txt_tim_kiem.Text;
        m_ds = new DS_GD_DON_DAT_HANG();
        m_us.FillDatasetSearch_Web(m_ds, v_dat_thang, v_id_trung_tam, CONST_ID_TRANG_THAI_DON_HANG.DA_DUYET,v_str_tu_khoa);
        m_grv_don_hang.DataSource = m_ds.GD_DON_DAT_HANG;
        m_grv_don_hang.DataBind();
    }
    private void load_data_2_grid_detail(decimal ip_dc_id_don_hang)
    {
        US_V_GD_DON_DAT_HANG_DETAIL v_us = new US_V_GD_DON_DAT_HANG_DETAIL();
        DS_V_GD_DON_DAT_HANG_DETAIL v_ds = new DS_V_GD_DON_DAT_HANG_DETAIL();
        v_us.FillDataset(v_ds, "where id_don_dat_hang=" + ip_dc_id_don_hang);
        m_grv_detail.DataSource = v_ds.V_GD_DON_DAT_HANG_DETAIL;
        m_grv_detail.DataBind();
        string v_str_thong_tin = "Danh sách Có " + v_ds.V_GD_DON_DAT_HANG_DETAIL.Rows.Count + " mặt hàng";
        m_lbl_grv_detail.Text = v_str_thong_tin;
        m_lbl_ten_detail.Text = "Chi tiết hóa đơn đặt hàng";
        view_detail_grv(true);
    }
    private void load_title()
    {
        decimal v_id_trung_tam = CIPConvert.ToDecimal(m_hdf_id_trung_tam.Value);
        US_DM_PHONG_BAN v_us = new US_DM_PHONG_BAN();
        DS_DM_PHONG_BAN v_ds = new DS_DM_PHONG_BAN();
        v_us.FillDataset(v_ds, "where id=" + v_id_trung_tam);
        m_lbl_ten_trung_tam.Text = v_ds.DM_PHONG_BAN.Rows[0]["TEN_PHONG_BAN"].ToString();
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
                if (!Person.check_user_have_menu())
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "<script type = 'text/javascript'>alert('Bạn không có quyền sử dụng chức năng này!');window.location.replace('/TraCuuKeToan/')</script>");
                }
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
                    set_inital_form_mode();
                    view_detail_grv(false);
                }
                else
                {
                    Response.Redirect("../Default.aspx", false);
                    HttpContext.Current.ApplicationInstance.CompleteRequest();
                }

            }
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_grv_dm_don_hang_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            m_grv_don_hang.PageIndex = e.NewPageIndex;
            m_grv_don_hang.DataBind();
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
    protected void m_grv_don_hang_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            switch (e.CommandName)
            {
                case "Detail":
                    if (e.CommandArgument.Equals("")) return;
                    decimal v_dc_id_don_hang = CIPConvert.ToDecimal(e.CommandArgument);
                    m_hdf_id_don_hang_detail.Value = CIPConvert.ToDecimal(e.CommandArgument).ToString();
                    load_data_2_grid_detail(v_dc_id_don_hang);
                    break;


            }
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_cmd_detail_exit_Click(object sender, EventArgs e)
    {
        try
        {
            view_detail_grv(false);
        }
        catch (System.Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_grv_detail_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            m_grv_detail.PageIndex = e.NewPageIndex;
            if (m_hdf_id_don_hang_detail.Value == "") return;
            decimal v_dc_id_don_hang = CIPConvert.ToDecimal(m_hdf_id_don_hang_detail.Value);
            load_data_2_grid_detail(v_dc_id_don_hang);
            m_grv_detail.DataBind();

        }
        catch (Exception v_e)
        {

            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    #endregion
    

}