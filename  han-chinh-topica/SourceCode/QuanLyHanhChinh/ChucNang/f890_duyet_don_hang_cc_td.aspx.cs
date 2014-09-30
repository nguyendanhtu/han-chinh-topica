﻿using System;
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

public partial class ChucNang_f890_duyet_don_hang_cc_td : System.Web.UI.Page
{
    #region Public Interface
    public bool is_cc_duyet(string ip_str_id_don_hang, string ip_str_ti_le_vuot)
    {
        bool v_b_result = false;
        if (ip_str_id_don_hang.Equals("")) return false;
        if(ip_str_ti_le_vuot.Equals("")) return false;
        if (CIPConvert.ToDecimal(ip_str_ti_le_vuot) > 120)
            v_b_result = true;
        else v_b_result = false;
        return v_b_result;
    }
    public bool is_td_duyet(string ip_str_id_don_hang, string ip_str_ti_le_vuot)
    {
        bool v_b_result = false;
        if (ip_str_id_don_hang.Equals("")) return false;
        if (ip_str_ti_le_vuot.Equals("")) return false;
        if (CIPConvert.ToDecimal(ip_str_ti_le_vuot) <= 110)
            v_b_result = true;
        else v_b_result = false;
        return v_b_result;
    }
    public bool is_tad_duyet(string ip_str_id_don_hang, string ip_str_ti_le_vuot)
    {
        bool v_b_result = false;
        if (ip_str_id_don_hang.Equals("")) return false;
        if (ip_str_ti_le_vuot.Equals("")) return false;
        if (CIPConvert.ToDecimal(ip_str_ti_le_vuot) <= 120 && CIPConvert.ToDecimal(ip_str_ti_le_vuot) > 110)
            v_b_result = true;
        else v_b_result = false;
        return v_b_result;
    }
    #endregion

    #region Events

    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {

        try
        {
            //this.Form.DefaultButton = m_cmd_tim_kiem.UniqueID;
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
                    set_thang_hien_tai();
                    set_inital_form_mode();
                    view_detail_grv(false);
                }
                //thong_bao("", false);
            }
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }

    private void set_thang_hien_tai()
    {
        int this_month = DateTime.Now.Month;
        m_cbo_chon_thang.SelectedValue = this_month.ToString();
    }

    private void set_inital_form_mode()
    {
        load_data_to_grid();
    }

    private void load_data_to_grid()
    {
        decimal v_id_trung_tam = CIPConvert.ToDecimal(m_hdf_id_trung_tam.Value);
        US_DM_PHONG_BAN v_us = new US_DM_PHONG_BAN();
        DS_DM_PHONG_BAN v_ds = new DS_DM_PHONG_BAN();
        v_us.FillDataset(v_ds, "where id=" + v_id_trung_tam);
        m_lbl_title.Text = "Trung tâm - ban: " + v_ds.DM_PHONG_BAN.Rows[0]["TEN_PHONG_BAN"].ToString();
        // lấy mã trung tâm
        m_hdf_ma_trung_tam.Value = v_ds.DM_PHONG_BAN.Rows[0]["MA_PHONG_BAN"].ToString();

        DS_GD_DON_DAT_HANG v_ds_gd_don_dat_hang = new DS_GD_DON_DAT_HANG();
        US_GD_DON_DAT_HANG v_us_gd_don_dat_hang = new US_GD_DON_DAT_HANG();
        //string temp = "01/08/2014";
        int thisyear = DateTime.Now.Year;
        DateTime m_dat_dau_thang = new DateTime(thisyear, int.Parse(m_cbo_chon_thang.SelectedValue.ToString()), 1);
        DateTime m_dat_cuoi_thang = m_dat_dau_thang.AddMonths(1).AddDays(-1);
        v_us_gd_don_dat_hang.load_ddh_xin_td_duyet(v_ds_gd_don_dat_hang, v_id_trung_tam, m_dat_cuoi_thang);
        m_grv_don_hang_nhap.DataSource = v_ds_gd_don_dat_hang.GD_DON_DAT_HANG;
        m_grv_don_hang_nhap.DataBind();
        //Lay tong tien dinh muc
        m_lbl_tong_tien_dm.Text = CIPConvert.ToStr(v_us_gd_don_dat_hang.get_tong_tien_dinh_muc_hang_thang(v_id_trung_tam, 173, m_dat_dau_thang, m_dat_cuoi_thang).ToString(), "#,###,##");
        m_lbl_tong_tien_da_chi.Text = CIPConvert.ToStr(v_us_gd_don_dat_hang.get_tong_tien_da_chi_hang_thang(v_id_trung_tam, m_dat_cuoi_thang), "#,###");
        
        //check duyệt
        //if(m_grv_don_hang_nhap.Rows.Count>1)
            
        //for (int i = 0; i < v_ds_gd_don_dat_hang.GD_DON_DAT_HANG.Rows.Count; i++)
        //{
        //    if (CIPConvert.ToDecimal(v_ds_gd_don_dat_hang.GD_DON_DAT_HANG.Rows[i]["PHAN_TRAM_VUOT"]) >= 120)
        //    {
        //        m_grv_don_hang_nhap.
        //    }
        //    else
        //    { }
        //}
    }
    private void load_data_to_grid_don_hang_de()
    {
        //load grid đơn hàng detail:
        US_V_DON_DAT_HANG_DETAIL_NHAP_DON_HANG_LE v_us_don_hang_de = new US_V_DON_DAT_HANG_DETAIL_NHAP_DON_HANG_LE();
        DS_V_DON_DAT_HANG_DETAIL_NHAP_DON_HANG_LE v_ds_don_hang_de = new DS_V_DON_DAT_HANG_DETAIL_NHAP_DON_HANG_LE();
        v_us_don_hang_de.FillDataset(v_ds_don_hang_de, "Where id_don_dat_hang=" + CIPConvert.ToDecimal(m_hdf_id_don_hang.Value));
        m_grv_don_hang_de.DataSource = v_ds_don_hang_de.V_DON_DAT_HANG_DETAIL_NHAP_DON_HANG_LE;
        m_grv_don_hang_de.DataBind();
        string v_str_thong_tin_don_hang_de = " (Có " + v_ds_don_hang_de.V_DON_DAT_HANG_DETAIL_NHAP_DON_HANG_LE.Rows.Count + " mặt hàng)";
        m_lbl_thong_tim_grv_don_hang_de.Text = v_str_thong_tin_don_hang_de;

        if (!m_hdf_ID_GD_DON_DAT_HANG_DE.Value.Equals(""))
        {
            m_grv_don_hang_de.SelectedIndex = -1;
            for (int i = 0; i < m_grv_don_hang_de.Rows.Count; i++)
                if (CIPConvert.ToDecimal(m_grv_don_hang_de.DataKeys[i].Value) == CIPConvert.ToDecimal(m_hdf_ID_GD_DON_DAT_HANG_DE.Value)) m_grv_don_hang_de.SelectedIndex = i;
        }
        m_grv_don_hang_de.Visible = true;
    }
    private void view_detail_grv(bool ip_visible)
    {
        mtv_detail.SetActiveView(View_detail);
        m_pnl_detail_grv.Visible = ip_visible;
    }
    protected void m_grv_don_hang_nhap_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            if(e.CommandArgument.ToString().Equals("")) return;
            decimal v_dc_id_don_hang = CIPConvert.ToDecimal(e.CommandArgument);
            US_GD_DON_DAT_HANG v_us_gd_don_hang = new US_GD_DON_DAT_HANG(v_dc_id_don_hang);
            int thisyear = DateTime.Now.Year;
            DateTime m_dat_dau_thang = new DateTime(thisyear, int.Parse(m_cbo_chon_thang.SelectedValue.ToString()), 1);
            DateTime m_dat_cuoi_thang = m_dat_dau_thang.AddMonths(1).AddDays(-1);
            switch (e.CommandName)
            {
                case "KhongDuyet":
                    v_us_gd_don_hang.dcID_TRANG_THAI = CONST_ID_TRANG_THAI_DON_HANG.TD_KHONG_DUYET;
                    break;
                case "Duyet":
                    v_us_gd_don_hang.dcID_TRANG_THAI = CONST_ID_TRANG_THAI_DON_HANG.DA_DUYET;
                    v_us_gd_don_hang.Update();
                    m_lbl_tong_tien_da_chi.Text = CIPConvert.ToStr(v_us_gd_don_hang.get_tong_tien_da_chi_hang_thang(v_us_gd_don_hang.dcID_PHONG_BAN, m_dat_cuoi_thang), "#,###");
                    break;
                case "XinCCDuyet":
                    v_us_gd_don_hang.dcID_TRANG_THAI = CONST_ID_TRANG_THAI_DON_HANG.XIN_CC_DUYET;
                    v_us_gd_don_hang.Update();
                    break;
                case "XinTADDuyet":
                    v_us_gd_don_hang.dcID_TRANG_THAI = CONST_ID_TRANG_THAI_DON_HANG.XIN_TAD_DUYET;
                    v_us_gd_don_hang.Update();
                    break;
            }
            //v_us_gd_don_hang.Update();
            load_data_to_grid();
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_cbo_chon_thang_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        try {
            load_data_to_grid();
        }
        catch(Exception) {
            
            throw;
        }
      
    }
    protected void m_cmd_detail_exit_Click(object sender, EventArgs e)
    {
        try
        {
            view_detail_grv(false);
            m_lbl_thong_bao.Visible = false;
        }
        catch (System.Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_lbt_detail_OnClick(object sender, EventArgs e)
    {
        try
        {
            m_lbl_thong_bao.Visible = false;
            //Get the button that raised the event
            LinkButton btn = (LinkButton)sender;
            //Get the row that contains this button
            GridViewRow gvr = (GridViewRow)btn.NamingContainer;
            //Get rowindex
            LinkButton lbt = (LinkButton)sender;
            view_detail_grv(true);
            int rowindex = gvr.RowIndex;
            m_grv_don_hang_nhap.SelectedIndex = rowindex;
            m_hdf_id_don_hang.Value = CIPConvert.ToStr(m_grv_don_hang_nhap.DataKeys[rowindex].Value);
            m_lbl_ma_don_hang_de.Text = m_grv_don_hang_nhap.Rows[rowindex].Cells[6].Text;
            m_lbl_tong_tien.Text = m_grv_don_hang_nhap.Rows[rowindex].Cells[9].Text + "  (VNĐ)";
            if (m_grv_don_hang_nhap.Rows[rowindex].Cells[11].Text != null)
                m_lbl_ti_le_vuot.Text = m_grv_don_hang_nhap.Rows[rowindex].Cells[11].Text + "  %";
            else
                m_lbl_ti_le_vuot.Text ="-----";
            load_data_to_grid_don_hang_de();
        }
        catch (Exception v_e)
        {

            CSystemLog_301.ExceptionHandle(this, v_e);
        }

    }
}

