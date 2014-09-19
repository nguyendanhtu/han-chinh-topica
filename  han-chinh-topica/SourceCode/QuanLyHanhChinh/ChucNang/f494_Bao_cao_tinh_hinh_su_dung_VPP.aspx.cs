﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BCTKDS;
using BCTKDS.CDBNames;
using BCTKUS;

using IP.Core.IPCommon;
using IP.Core.IPUserService;

public partial class ChucNang_f494_Bao_cao_tinh_hinh_su_dung_VPP : System.Web.UI.Page
{
    #region Public Interfaces
    #endregion

    #region Members
    decimal m_id_trung_tam;
    #endregion

    #region Data Structure
    #endregion

    #region Private Methods
    private void view_detail_grv(bool ip_visible)
    {
        mtv_detail.SetActiveView(View_detail);
        m_pnl_detail_grv.Visible = ip_visible;
    }

    private void load_data_to_grid()
    {
        decimal v_id_trung_tam = CIPConvert.ToDecimal(m_hdf_id_trung_tam.Value);
        //decimal v_dc_id_trang_thai = CIPConvert.ToDecimal(m_cbo_trang_thai.SelectedValue);
        //string v_str_tu_khoa = m_txt_tim_kiem.Text.Trim();
        US_V_BC_TINH_HINH_VPP_THEO_PHONG_BAN v_us = new US_V_BC_TINH_HINH_VPP_THEO_PHONG_BAN();
        DS_V_BC_TINH_HINH_VPP_THEO_PHONG_BAN v_ds = new DS_V_BC_TINH_HINH_VPP_THEO_PHONG_BAN();
        v_ds.Clear();
        v_us.FillDataset(v_ds, v_id_trung_tam, CIPConvert.ToDatetime(m_txt_tu_ngay.Text), CIPConvert.ToDatetime(m_txt_den_ngay.Text));
        m_grv_v_bc_tinh_hinh_VPP.DataSource = v_ds.V_BC_TINH_HINH_VPP_THEO_PHONG_BAN;
        //string v_str_thong_tin = " (Có " + v_ds.V_BC_TINH_HINH_CPN_THEO_PHONG_BAN.Rows.Count + " bản ghi)";
        //m_lbl_thong_tim_grv_dm_bill.Text = v_str_thong_tin;
        m_grv_v_bc_tinh_hinh_VPP.DataBind();
        if (!m_hdf_id_bill.Value.Equals(""))
        {
            m_grv_v_bc_tinh_hinh_VPP.SelectedIndex = -1;
            for (int i = 0; i < m_grv_v_bc_tinh_hinh_VPP.Rows.Count; i++)
                if (CIPConvert.ToDecimal(m_grv_v_bc_tinh_hinh_VPP.DataKeys[i].Value) == CIPConvert.ToDecimal(m_hdf_id_bill.Value)) m_grv_v_bc_tinh_hinh_VPP.SelectedIndex = i;
        }
        load_data_to_chi_tiet_grid();
    }
    private void load_data_to_chi_tiet_grid()
    {
        decimal v_id_trung_tam = CIPConvert.ToDecimal(m_hdf_id_trung_tam.Value);
        US_V_GD_DON_DAT_HANG v_us = new US_V_GD_DON_DAT_HANG();
        DS_V_GD_DON_DAT_HANG v_ds = new DS_V_GD_DON_DAT_HANG();
        v_us.FillDataset(v_ds, v_id_trung_tam, CIPConvert.ToDatetime(m_txt_tu_ngay.Text), CIPConvert.ToDatetime(m_txt_den_ngay.Text));
        m_grv_chi_tiet_bc.DataSource = v_ds.V_GD_DON_DAT_HANG;
        m_grv_chi_tiet_bc.DataBind();
    }
    private void load_data_grv_detail(decimal ip_id_trang_thai)
    {
        decimal v_id_trung_tam = CIPConvert.ToDecimal(m_hdf_id_trung_tam.Value);
        US_V_DM_BILL v_us_v_dm_bill = new US_V_DM_BILL();
        DS_V_DM_BILL v_ds_v_dm_bill = new DS_V_DM_BILL();
        v_ds_v_dm_bill.Clear();
        if (ip_id_trang_thai == CONST_ID_TRANG_THAI_THU.ID_DA_NHAN_NOI_BO || ip_id_trang_thai == CONST_ID_TRANG_THAI_THU.ID_DA_CHUYEN_CPN)
        {
            v_us_v_dm_bill.FillDataset(v_ds_v_dm_bill, v_id_trung_tam, CIPConvert.ToDatetime(m_txt_tu_ngay.Text), CIPConvert.ToDatetime(m_txt_den_ngay.Text), ip_id_trang_thai, "");
        }
        if (ip_id_trang_thai == CONST_ID_TRANG_THAI_THU.ID_BI_TRA_LAI_MAT_PHI)
        {
            v_us_v_dm_bill.Fill_DS_BAO_CAO_TONG_HOP_BILL_BI_TRA_LAI_MAT_PHI_WEB_DETAIL(v_ds_v_dm_bill, v_id_trung_tam, CIPConvert.ToDatetime(m_txt_tu_ngay.Text), CIPConvert.ToDatetime(m_txt_den_ngay.Text));
        }
        if (ip_id_trang_thai == CONST_ID_TRANG_THAI_THU.ID_BI_TRA_LAI_KHONG_MAT_PHI)
        {
            v_us_v_dm_bill.Fill_DS_BAO_CAO_TONG_HOP_BILL_BI_TRA_LAI_KHONG_MAT_PHI_WEB_DETAIL(v_ds_v_dm_bill, v_id_trung_tam, CIPConvert.ToDatetime(m_txt_tu_ngay.Text), CIPConvert.ToDatetime(m_txt_den_ngay.Text));
        }
        m_grv_detail.DataSource = v_ds_v_dm_bill.V_DM_BILL;
        string v_str_thong_tin = "Danh sách Có " + v_ds_v_dm_bill.V_DM_BILL.Rows.Count + " Bill";
        m_lbl_grv_detail.Text = v_str_thong_tin;
        m_grv_detail.DataBind();
        if (!m_hdf_id_bill.Value.Equals(""))
        {
            m_grv_detail.SelectedIndex = -1;
            for (int i = 0; i < m_grv_detail.Rows.Count; i++)
                if (CIPConvert.ToDecimal(m_grv_detail.DataKeys[i].Value) == CIPConvert.ToDecimal(m_hdf_id_bill.Value)) m_grv_detail.SelectedIndex = i;
        }
        if (v_ds_v_dm_bill.V_DM_BILL.Count == 0)
            thong_bao("Không tìm thấy Bill!", true);
    }

    private void display_pop_up_detail(string v_ma_don_hang)
    {
        US_V_GD_DON_DAT_HANG_DETAIL v_us = new US_V_GD_DON_DAT_HANG_DETAIL();
        DS_V_GD_DON_DAT_HANG_DETAIL v_ds = new DS_V_GD_DON_DAT_HANG_DETAIL();
        v_us.FillDataset(v_ds, v_ma_don_hang, CIPConvert.ToDatetime(m_txt_tu_ngay.Text), CIPConvert.ToDatetime(m_txt_den_ngay.Text));
        m_grv_detail.DataSource = v_ds.V_GD_DON_DAT_HANG_DETAIL;
        m_grv_detail.DataBind();
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
        DateTime today = DateTime.Today;
        int numberOfDaysInMonth = DateTime.DaysInMonth(today.Year, today.Month);
        m_txt_tu_ngay.Text = DateTime.Now.Date.AddDays(-DateTime.Now.Date.Day + 1).ToString("dd/MM/yyyy");
        DateTime v_dat_den_ngay = new DateTime(today.Year, today.Month, numberOfDaysInMonth);
        m_txt_den_ngay.Text = v_dat_den_ngay.ToString("dd/MM/yyyy");
        decimal v_id_trung_tam = CIPConvert.ToDecimal(m_hdf_id_trung_tam.Value);
        US_DM_PHONG_BAN v_us = new US_DM_PHONG_BAN();
        DS_DM_PHONG_BAN v_ds = new DS_DM_PHONG_BAN();
        v_us.FillDataset(v_ds, "where id=" + v_id_trung_tam);
        m_lbl_ten_trung_tam.Text = v_ds.DM_PHONG_BAN.Rows[0]["TEN_PHONG_BAN"].ToString();
    }

    private bool check_thoi_gian()
    {
        if (CIPConvert.ToDatetime(m_txt_tu_ngay.Text) > CIPConvert.ToDatetime(m_txt_den_ngay.Text))
        {
            thong_bao("Bạn đã chọn khoảng thời gian không hợp lệ!", true);
            DateTime today = DateTime.Today;
            int numberOfDaysInMonth = DateTime.DaysInMonth(today.Year, today.Month);
            m_txt_tu_ngay.Text = DateTime.Now.Date.AddDays(-DateTime.Now.Date.Day + 1).ToString("dd/MM/yyyy");
            DateTime v_dat_den_ngay = new DateTime(today.Year, today.Month, numberOfDaysInMonth);
            m_txt_den_ngay.Text = v_dat_den_ngay.ToString("dd/MM/yyyy");
            return false;
        }
        else
            return true;
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
                    set_time_set_ten_trung_tam();
                    load_data_to_grid();
                    thong_bao("", false);
                    view_detail_grv(false);
                }
                else
                {
                    Response.Redirect("../Default.aspx", false);
                    HttpContext.Current.ApplicationInstance.CompleteRequest();
                }
          
            }
        }

        catch (System.Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }

    protected void m_grv_v_bc_tinh_hinh_VPP_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            m_grv_v_bc_tinh_hinh_VPP.PageIndex = e.NewPageIndex;
            m_grv_v_bc_tinh_hinh_VPP.DataBind();
        }
        catch (Exception v_e)
        {

            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_grv_chi_tiet_bc_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            m_grv_v_bc_tinh_hinh_VPP.PageIndex = e.NewPageIndex;
            m_grv_v_bc_tinh_hinh_VPP.DataBind();
        }
        catch (Exception v_e)
        {

            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_cmd_xem_bao_cao_Click(object sender, EventArgs e)
    {
        try
        {
            if (!check_thoi_gian())
                return;
            load_data_to_grid();
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }

    protected void Tu_ngay_OnTextChanged(object sender, EventArgs e)
    {
        try
        {
            DateTime v_tu_ngay, v_ngay_chon;
            v_ngay_chon = CIPConvert.ToDatetime(m_txt_tu_ngay.Text);
            v_tu_ngay = new DateTime(v_ngay_chon.Year, v_ngay_chon.Month, 1);
            m_txt_tu_ngay.Text = v_tu_ngay.ToString("dd/MM/yyyy");
            load_data_to_grid();
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void Den_ngay_OnTextChanged(object sender, EventArgs e)
    {
        try
        {
            DateTime v_den_ngay, v_ngay_chon;
            v_ngay_chon = CIPConvert.ToDatetime(m_txt_den_ngay.Text);
            int numberOfDaysInMonth = DateTime.DaysInMonth(v_ngay_chon.Year, v_ngay_chon.Month);
            v_den_ngay = new DateTime(v_ngay_chon.Year, v_ngay_chon.Month, numberOfDaysInMonth);
            m_txt_den_ngay.Text = v_den_ngay.ToString("dd/MM/yyyy");
            load_data_to_grid();
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
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
            //if (m_hdf_trang_thai_thu.Value == CONST_ID_TRANG_THAI_THU.ID_DA_NHAN_NOI_BO.ToString())
            //{
            //    load_data_grv_detail(CONST_ID_TRANG_THAI_THU.ID_DA_NHAN_NOI_BO);
            //}
            //if (m_hdf_trang_thai_thu.Value == CONST_ID_TRANG_THAI_THU.ID_DA_CHUYEN_CPN.ToString())
            //{
            //    load_data_grv_detail(CONST_ID_TRANG_THAI_THU.ID_DA_CHUYEN_CPN);
            //}
            //if (m_hdf_trang_thai_thu.Value == CONST_ID_TRANG_THAI_THU.ID_BI_TRA_LAI_KHONG_MAT_PHI.ToString())
            //{
            //    load_data_grv_detail(CONST_ID_TRANG_THAI_THU.ID_BI_TRA_LAI_KHONG_MAT_PHI);
            //}
            //if (m_hdf_trang_thai_thu.Value == CONST_ID_TRANG_THAI_THU.ID_BI_TRA_LAI_MAT_PHI.ToString())
            //{
            //    load_data_grv_detail(CONST_ID_TRANG_THAI_THU.ID_BI_TRA_LAI_MAT_PHI);
            //}
            m_grv_detail.DataBind();
        }
        catch (Exception v_e)
        {

            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_lbt_detail_OnClick(object sender, EventArgs e)
    {
        try
        {
            LinkButton lbt = (LinkButton)sender;
            GridViewRow row = (GridViewRow)lbt.NamingContainer;
            string v_ma_don_hang = row.Cells[3].Text;
            view_detail_grv(true);
            display_pop_up_detail(v_ma_don_hang);
        }
        catch (System.Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_grv_chi_tiet_bc_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            string v_ma_don_hang = m_grv_chi_tiet_bc.SelectedRow.Cells[3].ToString(); 
        }
        catch (Exception v_e)
        {

            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    #endregion
}