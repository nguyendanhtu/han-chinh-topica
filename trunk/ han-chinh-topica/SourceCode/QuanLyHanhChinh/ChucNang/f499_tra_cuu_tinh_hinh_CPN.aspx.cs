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

public partial class ChucNang_f499_tra_cuu_tinh_hinh_CPN : System.Web.UI.Page
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
        //decimal v_dc_id_trang_thai = CIPConvert.ToDecimal(m_cbo_trang_thai.SelectedValue);
        //string v_str_tu_khoa = m_txt_tim_kiem.Text.Trim();
        US_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN v_us = new US_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN();
        DS_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN v_ds = new DS_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN();
        v_ds.Clear();
        v_us.FillDataset(v_ds, v_id_trung_tam, m_dat_tu_ngay.SelectedDate, m_dat_den_ngay.SelectedDate);
        m_grv_v_bc_tinh_hinh_CPN.DataSource = v_ds.V_BC_TINH_HINH_CPN_THEO_PHONG_BAN;
        //string v_str_thong_tin = " (Có " + v_ds.V_BC_TINH_HINH_CPN_THEO_PHONG_BAN.Rows.Count + " bản ghi)";
        //m_lbl_thong_tim_grv_dm_bill.Text = v_str_thong_tin;
        m_grv_v_bc_tinh_hinh_CPN.DataBind();
        if (!m_hdf_id_bill.Value.Equals(""))
        {
            m_grv_v_bc_tinh_hinh_CPN.SelectedIndex = -1;
            for (int i = 0; i < m_grv_v_bc_tinh_hinh_CPN.Rows.Count; i++)
                if (CIPConvert.ToDecimal(m_grv_v_bc_tinh_hinh_CPN.DataKeys[i].Value) == CIPConvert.ToDecimal(m_hdf_id_bill.Value)) m_grv_v_bc_tinh_hinh_CPN.SelectedIndex = i;
        }
        load_data_tra_lai_mat_phi();
        load_data_tra_lai_khong_mat_phi();
        load_data_bill_gui_thanh_cong();
        load_data_bill_chua_gui_CPN();

    }
    private void load_data_bill_chua_gui_CPN()
    {
        decimal v_id_trung_tam = CIPConvert.ToDecimal(m_hdf_id_trung_tam.Value);
        US_V_BC_TONG_HOP_BILL_BI_TRA_LAI_WEB v_us = new US_V_BC_TONG_HOP_BILL_BI_TRA_LAI_WEB();
        DS_V_BC_TONG_HOP_BILL_BI_TRA_LAI_WEB v_ds = new DS_V_BC_TONG_HOP_BILL_BI_TRA_LAI_WEB();
        v_us.Fill_TONG_HOP_BILL_CHUA_GUI_CHO_CPN(v_ds, v_id_trung_tam, m_dat_tu_ngay.SelectedDate, m_dat_den_ngay.SelectedDate);
        if (v_ds.V_BC_TONG_HOP_BILL_BI_TRA_LAI_WEB.Rows.Count == 0)
            m_lbl_so_bill_bi_tra_lai_khong_mat_phi.Text = "0";
        else
        {
            m_lbl_bill_chua_gui_cho_CPN.Text = CIPConvert.ToStr(v_ds.V_BC_TONG_HOP_BILL_BI_TRA_LAI_WEB.Rows[0][0], "#,###");
        }
    }
    private void load_data_bill_gui_thanh_cong()
    {
        decimal v_id_trung_tam = CIPConvert.ToDecimal(m_hdf_id_trung_tam.Value);
        US_V_BC_TONG_HOP_BILL_BI_TRA_LAI_WEB v_us = new US_V_BC_TONG_HOP_BILL_BI_TRA_LAI_WEB();
        DS_V_BC_TONG_HOP_BILL_BI_TRA_LAI_WEB v_ds = new DS_V_BC_TONG_HOP_BILL_BI_TRA_LAI_WEB();
        v_us.Fill_TONG_HOP_BILL_DA_GUI_THANH_CONG(v_ds, v_id_trung_tam, m_dat_tu_ngay.SelectedDate, m_dat_den_ngay.SelectedDate);
        if (v_ds.V_BC_TONG_HOP_BILL_BI_TRA_LAI_WEB.Rows.Count == 0)
        {
            m_lbl_so_bill_da_gui_thanh_cong.Text = "0";
            m_lbl_tong_tien_da_gui_thanh_cong.Text = "0";
        }
        else
        {
            m_lbl_so_bill_da_gui_thanh_cong.Text = CIPConvert.ToStr(v_ds.V_BC_TONG_HOP_BILL_BI_TRA_LAI_WEB.Rows[0][0], "#,###");
            if (v_ds.V_BC_TONG_HOP_BILL_BI_TRA_LAI_WEB.Rows[0][1].ToString() != "")
                m_lbl_tong_tien_da_gui_thanh_cong.Text = CIPConvert.ToStr(v_ds.V_BC_TONG_HOP_BILL_BI_TRA_LAI_WEB.Rows[0][1], "#,###");
            else
                m_lbl_tong_tien_da_gui_thanh_cong.Text = "0";
        }
    }

    private void load_data_tra_lai_mat_phi()
    {
        decimal v_id_trung_tam = CIPConvert.ToDecimal(m_hdf_id_trung_tam.Value);
        US_V_BC_TONG_HOP_BILL_BI_TRA_LAI_WEB v_us = new US_V_BC_TONG_HOP_BILL_BI_TRA_LAI_WEB();
        DS_V_BC_TONG_HOP_BILL_BI_TRA_LAI_WEB v_ds = new DS_V_BC_TONG_HOP_BILL_BI_TRA_LAI_WEB();
        v_us.Fill_TONG_HOP_BILL_MAT_PHI(v_ds, v_id_trung_tam, m_dat_tu_ngay.SelectedDate, m_dat_den_ngay.SelectedDate);
        if (v_ds.V_BC_TONG_HOP_BILL_BI_TRA_LAI_WEB.Rows.Count == 0)
        {
            m_lbl_so_bill_bi_tra_lai_mat_phi.Text = "0";
            m_lbl_so_tien_bill_bi_tra_lai_mat_phi.Text = "0";
        }
        else
        {
            m_lbl_so_bill_bi_tra_lai_mat_phi.Text = CIPConvert.ToStr(v_ds.V_BC_TONG_HOP_BILL_BI_TRA_LAI_WEB.Rows[0][0],"#,###");
            if (v_ds.V_BC_TONG_HOP_BILL_BI_TRA_LAI_WEB.Rows[0][1].ToString() == "")
                m_lbl_so_tien_bill_bi_tra_lai_mat_phi.Text = "0";
            else
                m_lbl_so_tien_bill_bi_tra_lai_mat_phi.Text = CIPConvert.ToStr(v_ds.V_BC_TONG_HOP_BILL_BI_TRA_LAI_WEB.Rows[0][1], "#,###");
        }
    }
    private void load_data_tra_lai_khong_mat_phi()
    {
        decimal v_id_trung_tam = CIPConvert.ToDecimal(m_hdf_id_trung_tam.Value);
        US_V_BC_TONG_HOP_BILL_BI_TRA_LAI_WEB v_us = new US_V_BC_TONG_HOP_BILL_BI_TRA_LAI_WEB();
        DS_V_BC_TONG_HOP_BILL_BI_TRA_LAI_WEB v_ds = new DS_V_BC_TONG_HOP_BILL_BI_TRA_LAI_WEB();
        v_us.Fill_TONG_HOP_BILL_KHONG_MAT_PHI(v_ds, v_id_trung_tam, m_dat_tu_ngay.SelectedDate, m_dat_den_ngay.SelectedDate);
        if (v_ds.V_BC_TONG_HOP_BILL_BI_TRA_LAI_WEB.Rows.Count == 0)
            m_lbl_so_bill_bi_tra_lai_khong_mat_phi.Text = "0";
        else
        {
            m_lbl_so_bill_bi_tra_lai_khong_mat_phi.Text = CIPConvert.ToStr(v_ds.V_BC_TONG_HOP_BILL_BI_TRA_LAI_WEB.Rows[0][0], "#,###");
        }
    }

    private void thong_bao(string ip_str_mess)
    {
        m_mtv_1.SetActiveView(m_view_confirm);
        m_lbl_popup_mess.Text = ip_str_mess;
        m_pnl_confirm_tg.Visible = true;
        m_cmd_ok.Visible = true;
    }
    private void thong_bao(string ip_str_mess, bool ip_panel_thong_bao_visible)
    {
        m_mtv_1.SetActiveView(m_view_confirm);
        m_lbl_popup_mess.Text = ip_str_mess;
        m_pnl_confirm_tg.Visible = ip_panel_thong_bao_visible;
        m_cmd_ok.Visible = ip_panel_thong_bao_visible;
    }
    private void set_time_set_ten_trung_tam()
    {
        m_dat_tu_ngay.SelectedDate = DateTime.Now.Date.AddDays(-DateTime.Now.Date.Day + 1);
        decimal v_id_trung_tam = CIPConvert.ToDecimal(m_hdf_id_trung_tam.Value);
        US_DM_PHONG_BAN v_us = new US_DM_PHONG_BAN();
        DS_DM_PHONG_BAN v_ds = new DS_DM_PHONG_BAN();
        v_us.FillDataset(v_ds, "where id=" + v_id_trung_tam);
        m_lbl_ten_trung_tam.Text = "Tình hình CPN "+ v_ds.DM_PHONG_BAN.Rows[0]["TEN_PHONG_BAN"].ToString();
    }
    #endregion

    #region Events
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
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

                }
                else
                {
                    Response.Redirect("../Default.aspx", false);
                    HttpContext.Current.ApplicationInstance.CompleteRequest();
                }
                thong_bao("", false);
                set_time_set_ten_trung_tam();
                load_data_to_grid();
                thong_bao("", false);
            }
        }

        catch (System.Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_grv_v_bc_tinh_hinh_CPN_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            m_grv_v_bc_tinh_hinh_CPN.PageIndex = e.NewPageIndex;
            m_grv_v_bc_tinh_hinh_CPN.DataBind();
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
    //protected void m_dat_tu_ngay_DateChanged(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        load_data_to_grid();
    //    }
    //    catch (Exception v_e)
    //    {
    //        CSystemLog_301.ExceptionHandle(this, v_e);
    //    }
    //}
    //protected void m_dat_den_ngay_DateChanged(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        load_data_to_grid();
    //    }
    //    catch (Exception v_e)
    //    {
    //        CSystemLog_301.ExceptionHandle(this, v_e);
    //    }
    //}
    protected void m_cmd_ok_Click(object sender, EventArgs e)
    {
        try
        {
            thong_bao("", false);
        }
        catch (System.Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_cmd_bill_chua_gui_cho_CPN_Click(object sender, EventArgs e)
    { 
    
    }
    #endregion
   
}