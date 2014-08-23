﻿using System;
using System.Collections.Generic;
using System.Data;
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
        v_ds_v_dm_bill.Clear();
        v_us_v_dm_bill.FillDataset(v_ds_v_dm_bill, v_id_trung_tam, CIPConvert.ToDatetime(m_txt_tu_ngay.Text), CIPConvert.ToDatetime(m_txt_den_ngay.Text), v_dc_id_trang_thai, v_str_tu_khoa);
        m_grv_v_dm_bill.DataSource = v_ds_v_dm_bill.V_DM_BILL;
        string v_str_thong_tin = " (Có " + v_ds_v_dm_bill.V_DM_BILL.Rows.Count + " bản ghi)";
        m_lbl_thong_tim_grv_dm_bill.Text = v_str_thong_tin;
        m_grv_v_dm_bill.DataBind();
        if (!m_hdf_id_bill.Value.Equals(""))
        {
            m_grv_v_dm_bill.SelectedIndex = -1;
            for (int i = 0; i < m_grv_v_dm_bill.Rows.Count; i++)
                if (CIPConvert.ToDecimal(m_grv_v_dm_bill.DataKeys[i].Value) == CIPConvert.ToDecimal(m_hdf_id_bill.Value)) m_grv_v_dm_bill.SelectedIndex = i;
        }
        if (v_ds_v_dm_bill.V_DM_BILL.Count == 0)
            thong_bao("Không tìm thấy Bill!",true);
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
    private void set_time()
    {
        m_txt_tu_ngay.Text = (DateTime.Now.Date.AddDays(-DateTime.Now.Date.Day + 1).AddMonths(-6)).ToString("dd/MM/yyyy");
        m_txt_den_ngay.Text = DateTime.Now.ToString("dd/MM/yyyy");
        decimal v_id_trung_tam = CIPConvert.ToDecimal(m_hdf_id_trung_tam.Value);
        US_DM_PHONG_BAN v_us = new US_DM_PHONG_BAN();
        DS_DM_PHONG_BAN v_ds = new DS_DM_PHONG_BAN();
        v_us.FillDataset(v_ds, "where id=" + v_id_trung_tam);
        if(v_ds.DM_PHONG_BAN.Count>0)
        m_lbl_ten_trung_tam.Text = v_ds.DM_PHONG_BAN.Rows[0]["TEN_PHONG_BAN"].ToString();
    }
    private void load_cbo_trang_thai()
    {
        BCTKUS.US_CM_DM_TU_DIEN v_us = new BCTKUS.US_CM_DM_TU_DIEN();
        DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
        v_us.FillDataset(v_ds, "where ID_LOAI_TU_DIEN=" + 12);
        m_cbo_trang_thai.DataSource = v_ds.CM_DM_TU_DIEN;
        m_cbo_trang_thai.DataValueField = CM_DM_TU_DIEN.ID;
        m_cbo_trang_thai.DataTextField = CM_DM_TU_DIEN.TEN;
        DataRow v_dr = v_ds.CM_DM_TU_DIEN.NewRow();
        v_dr[CM_DM_TU_DIEN.ID] = -1;
        v_dr[CM_DM_TU_DIEN.ID_LOAI_TU_DIEN] = 12;
        v_dr[CM_DM_TU_DIEN.TEN] = "-----Tất cả-----";
        v_dr[CM_DM_TU_DIEN.TEN_NGAN] = "-----Tất cả-----";
        v_dr[CM_DM_TU_DIEN.MA_TU_DIEN] = "TRANG_THAI_THU";
        v_dr[CM_DM_TU_DIEN.GHI_CHU] = " ";
        v_ds.CM_DM_TU_DIEN.Rows.InsertAt(v_dr, 0);
        m_cbo_trang_thai.SelectedIndex = 0;
        m_cbo_trang_thai.DataBind();
    }
    private bool check_thoi_gian()
    {
        //if (CIPConvert.ToDatetime(m_txt_tu_ngay.Text) > CIPConvert.ToDatetime(m_txt_den_ngay.Text))
        //{
        //    thong_bao("Bạn đã chọn khoảng thời gian không hợp lệ!", true);
        //    m_txt_tu_ngay.Text = (DateTime.Now.Date.AddDays(-DateTime.Now.Date.Day + 1).AddMonths(-6)).ToString("dd/MM/yyyy");
        //    m_txt_den_ngay.Text = DateTime.Now.ToString("dd/MM/yyyy");
        //    return false;
        //}
        //else
            return true;
    }
    #endregion

    #region Events
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            //Test
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
                set_time();
                load_cbo_trang_thai();
                load_data_to_grid();
                thong_bao("", false);
            }
        }

        catch (System.Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_grv_v_dm_bill_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            m_grv_v_dm_bill.PageIndex = e.NewPageIndex;
            load_data_to_grid();
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
            if (!check_thoi_gian())
                return;
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
    #endregion

}