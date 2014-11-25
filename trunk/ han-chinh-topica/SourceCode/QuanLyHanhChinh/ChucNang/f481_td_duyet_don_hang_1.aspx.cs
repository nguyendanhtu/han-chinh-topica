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

public partial class ChucNang_f481_td_duyet_don_hang_1 : System.Web.UI.Page
{
    #region Public Interface
    public bool is_cc_duyet(string ip_str_id_don_hang, string ip_str_ti_le_vuot)
    {
        bool v_b_result = false;
        if (ip_str_id_don_hang.Equals("")) return false;
        if (ip_str_ti_le_vuot.Equals("")) return false;
        if (CIPConvert.ToDecimal(ip_str_ti_le_vuot) > 20)
            v_b_result = true;
        else v_b_result = false;
        return v_b_result;
    }
    public bool is_td_duyet(string ip_str_id_don_hang, string ip_str_ti_le_vuot)
    {
        bool v_b_result = false;
        if (ip_str_id_don_hang.Equals("")) return false;
        if (ip_str_ti_le_vuot.Equals("")) return false;
        if (CIPConvert.ToDecimal(ip_str_ti_le_vuot) <= 10)
            v_b_result = true;
        else v_b_result = false;
        return v_b_result;
    }
    public bool is_tad_duyet(string ip_str_id_don_hang, string ip_str_ti_le_vuot)
    {
        bool v_b_result = false;
        if (ip_str_id_don_hang.Equals("")) return false;
        if (ip_str_ti_le_vuot.Equals("")) return false;
        if (CIPConvert.ToDecimal(ip_str_ti_le_vuot) <= 20 && CIPConvert.ToDecimal(ip_str_ti_le_vuot) > 10)
            v_b_result = true;
        else v_b_result = false;
        return v_b_result;
    }
    #endregion


    #region Private Method

    private void set_thang_hien_tai()
    {
        int this_month = DateTime.Now.Month;
        m_cbo_chon_thang.SelectedValue = this_month.ToString();
    }
    private void set_inital_form_mode()
    {
        load_data_to_grid();
        get_thong_tin_don_hang();
    }
    private void get_thong_tin_don_hang()
    {
        US_V_GD_DON_DAT_HANG v_us = new US_V_GD_DON_DAT_HANG();
        DS_V_GD_DON_DAT_HANG v_ds = new DS_V_GD_DON_DAT_HANG();
        v_us.FillDataset(v_ds,"where id="+ CIPConvert.ToDecimal(m_hdf_id_don_hang.Value));
        m_hdf_ma_don_hang.Value = v_ds.V_GD_DON_DAT_HANG.Rows[0]["MA_HD"].ToString();
        DateTime v_ngay_dat_hang = (DateTime)v_ds.V_GD_DON_DAT_HANG.Rows[0]["NGAY_DAT_HANG"];
        m_hdf_ngay_dat.Value = v_ngay_dat_hang.ToString("dd/MM/yyyy");
        m_hdf_lan_dat.Value = v_ds.V_GD_DON_DAT_HANG.Rows[0]["LAN"].ToString();
    }
    private void load_thong_tin_chi_tiet()
    {
        if (CIPConvert.ToDecimal(m_grv_don_hang_nhap.Rows[0].Cells[7].Text) <= 10)
        {
            m_lbl_nhap_mail.Text = "Nhập mail TAD/CC: ";
        }
        else
        {
            if (CIPConvert.ToDecimal(m_grv_don_hang_nhap.Rows[0].Cells[7].Text) <= 20)
            {
                m_lbl_nhap_mail.Text = "Nhập mail TAD: ";
            }
            else
            {
                m_lbl_nhap_mail.Text = "Nhập mail CC: ";
            }
        }
        m_lbl_ngay_dat_hang.Text = m_hdf_ngay_gui.Value;
        m_hdf_id_don_hang.Value = CIPConvert.ToStr(m_grv_don_hang_nhap.DataKeys[0].Value);
        m_lbl_ma_don_hang_de.Text = m_grv_don_hang_nhap.Rows[0].Cells[6].Text;
        m_lbl_tong_tien.Text = m_grv_don_hang_nhap.Rows[0].Cells[9].Text + "  (VNĐ)";
        if (m_grv_don_hang_nhap.Rows[0].Cells[11].Text != null)
            m_lbl_ti_le_vuot.Text = m_grv_don_hang_nhap.Rows[0].Cells[11].Text;
        else
            m_lbl_ti_le_vuot.Text = "-----";
    }
    private void load_so_luong_nhan_su()
    {
        decimal v_tong_dinh_muc;
        US_V_GD_THONG_KE v_us = new US_V_GD_THONG_KE();
        DS_V_GD_THONG_KE v_ds = new DS_V_GD_THONG_KE();
        US_DM_CO_SO_DINH_MUC v_us_cs_dm = new US_DM_CO_SO_DINH_MUC();
        DS_DM_CO_SO_DINH_MUC v_ds_cs_dm = new DS_DM_CO_SO_DINH_MUC();
        v_us.FillDataset(v_ds,CIPConvert.ToDecimal(m_hdf_id_trung_tam.Value));
        if (v_ds.Tables[0].Rows.Count > 0)
        {
            m_lbl_tong_nhan_su.Text = v_ds.Tables[0].Rows[0]["GIA_TRI_THONG_KE"].ToString() +" ("+ v_ds.Tables[0].Rows[0]["TEN"].ToString() + ")";
            v_us_cs_dm.FillDataset(v_ds_cs_dm, "where ID =" + CIPConvert.ToDecimal(v_ds.Tables[0].Rows[0]["ID_CO_SO_DINH_MUC"]));
            m_lbl_dinh_muc_dau_nguoi.Text = CIPConvert.ToStr(v_ds_cs_dm.Tables[0].Rows[0]["DON_GIA_DINH_MUC"], "#,##0") +" (VNĐ)" + "/" + v_ds.Tables[0].Rows[0]["TEN"].ToString();
            v_tong_dinh_muc = (CIPConvert.ToDecimal(v_ds_cs_dm.Tables[0].Rows[0]["DON_GIA_DINH_MUC"])) * (CIPConvert.ToDecimal(v_ds.Tables[0].Rows[0]["GIA_TRI_THONG_KE"]));
            m_lbl_tong_dinh_muc.Text = v_tong_dinh_muc.ToString("#,##0") + " (VNĐ)";
        }
        else
        {
            m_lbl_tong_nhan_su.Text = "?";
            m_lbl_dinh_muc_dau_nguoi.Text = "?";
            m_lbl_tong_dinh_muc.Text = "?";
        }
    }
    private bool check_txt_mail()
    {
        US_HT_USER_GROUP v_us_user_group = new US_HT_USER_GROUP();
        DS_HT_USER_GROUP v_ds_user_group = new DS_HT_USER_GROUP();
        string v_ten_mail = m_txt_nhap_mail.Text.Trim() + "@topica.edu.vn";
        //string v_ten_mail = m_txt_nhap_mail.Text.Trim() + "@gmail.com";
        if (m_txt_nhap_mail.Text == "")
        {
            thong_bao("Bạn chưa nhập mail",true);
            m_txt_nhap_mail.Focus();
            return false;
        }
        else
        {
            v_us_user_group.Check_have_mail(v_ds_user_group, v_ten_mail);
            if (v_ds_user_group.HT_USER_GROUP.Rows.Count > 0)
                return true;
            else
            {
                thong_bao("Địa chỉ mail không hợp lệ hoặc chưa cung cấp cho TAD.\nVui lòng liên hệ với TAD để biết thêm chi tiết.");
                return false;
            }
        }
    }
    private void thong_bao(string ip_str_mess, bool ip_panel_thong_bao_visible)
    {
        m_mtv_1.SetActiveView(m_view_confirm);
        m_lbl_popup_mess.Text = ip_str_mess;
        m_pnl_confirm_tg.Visible = ip_panel_thong_bao_visible;
        m_cmd_ok.Visible = ip_panel_thong_bao_visible;
    }
    public void thong_bao(string ip_str_mess, bool ip_panel_thong_bao_visible, bool ip_button_ok_visible)
    {
        m_mtv_1.SetActiveView(m_view_confirm);
        m_lbl_popup_mess.Text = ip_str_mess;
        m_pnl_confirm_tg.Visible = ip_panel_thong_bao_visible;
        m_cmd_ok.Visible = ip_button_ok_visible;
    }
    public void thong_bao(string ip_str_mess)
    {
        m_mtv_1.SetActiveView(m_view_confirm);
        m_lbl_popup_mess.Text = ip_str_mess;
        m_pnl_confirm_tg.Visible = true;
        m_cmd_ok.Visible = true;
    }
    private void load_data_to_grid()
    {
        decimal v_id_trung_tam = CIPConvert.ToDecimal(m_hdf_id_trung_tam.Value);
        US_DM_PHONG_BAN v_us = new US_DM_PHONG_BAN();
        DS_DM_PHONG_BAN v_ds = new DS_DM_PHONG_BAN();
        v_us.FillDataset(v_ds, "where id=" + v_id_trung_tam);
        m_lbl_title.Text = "Trung tâm - ban: " + v_ds.DM_PHONG_BAN.Rows[0]["TEN_PHONG_BAN"].ToString();
        m_hdf_ten_trung_tam.Value = m_lbl_title.Text;
        m_hdf_ma_trung_tam.Value = v_ds.DM_PHONG_BAN[0]["MA_PHONG_BAN"].ToString();
        // lấy mã trung tâm
        m_hdf_ma_trung_tam.Value = v_ds.DM_PHONG_BAN.Rows[0]["MA_PHONG_BAN"].ToString();

        DS_GD_DON_DAT_HANG v_ds_gd_don_dat_hang = new DS_GD_DON_DAT_HANG();
        US_GD_DON_DAT_HANG v_us_gd_don_dat_hang = new US_GD_DON_DAT_HANG();
        //string temp = "01/08/2014";
        //int thisyear = DateTime.Now.Year;
        //DateTime m_dat_dau_thang = new DateTime(thisyear, int.Parse(m_cbo_chon_thang.SelectedValue.ToString()), 1);
        //DateTime m_dat_cuoi_thang = m_dat_dau_thang.AddMonths(1).AddDays(-1);
        DateTime v_ngay_dat_hang = CIPConvert.ToDatetime(m_hdf_ngay_gui.Value);
        DateTime m_dat_dau_thang = new DateTime(v_ngay_dat_hang.Year,v_ngay_dat_hang.Month,1);
        DateTime m_dat_cuoi_thang = m_dat_dau_thang.AddMonths(1).AddDays(-1);
        if (CIPConvert.ToDecimal(m_hdf_form_mode.Value) == CONST_ID_TRANG_THAI_DON_HANG.XIN_TD_DUYET)
            v_us_gd_don_dat_hang.load_ddh_xin_td_duyet(v_ds_gd_don_dat_hang, v_id_trung_tam, m_dat_cuoi_thang);
        if (CIPConvert.ToDecimal(m_hdf_form_mode.Value) == CONST_ID_TRANG_THAI_DON_HANG.XIN_CC_DUYET)
            v_us_gd_don_dat_hang.load_ddh_xin_cc_duyet(v_ds_gd_don_dat_hang, v_id_trung_tam, m_dat_cuoi_thang);
        //lay ti le vuot
        m_hdf_ti_le_vuot.Value = v_ds_gd_don_dat_hang.GD_DON_DAT_HANG.Rows[0]["PHAN_TRAM_VUOT"].ToString();
        m_grv_don_hang_nhap.DataSource = v_ds_gd_don_dat_hang.GD_DON_DAT_HANG;
        m_grv_don_hang_nhap.DataBind();
        if (v_ds_gd_don_dat_hang.GD_DON_DAT_HANG.Count > 0)
        {
            load_thong_tin_chi_tiet();
            load_data_to_grid_don_hang_de();
        }
        //Lay tong tien dinh muc
        m_lbl_tong_tien_dm.Text = CIPConvert.ToStr(v_us_gd_don_dat_hang.get_tong_tien_dinh_muc_hang_thang(v_id_trung_tam, 173, m_dat_dau_thang, m_dat_cuoi_thang).ToString(), "#,###,##");
        m_lbl_tong_tien_da_chi.Text = CIPConvert.ToStr(v_us_gd_don_dat_hang.get_tong_tien_da_chi_hang_thang(v_id_trung_tam, m_dat_cuoi_thang), "#,###") + " (VNĐ)";

        //check duyệt
        //if(m_grv_don_hang_nhap.Rows.Count>1)

        //for (int i = 0; i < v_ds_gd_don_dat_hang.GD_DON_DAT_HANG.Rows.Count; i++)
        //{
        //    if (CIPConvert.ToDecimal(v_ds_gd_don_dat_hang.GD_DON_DAT_HANG.Rows[i]["PHAN_TRAM_VUOT"]) >= 20)
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
    private bool check_td_duyet_don_hang()
    {

        DS_GD_DON_DAT_HANG v_ds_gd_don_dat_hang = new DS_GD_DON_DAT_HANG();
        US_GD_DON_DAT_HANG v_us_gd_don_dat_hang = new US_GD_DON_DAT_HANG();
        DateTime m_dat_cuoi_thang = DateTime.Now.AddMonths(1).AddDays(-1);
        v_us_gd_don_dat_hang.load_ddh_xin_td_duyet(v_ds_gd_don_dat_hang, CIPConvert.ToDecimal(m_hdf_id_trung_tam.Value), m_dat_cuoi_thang);
        if (v_ds_gd_don_dat_hang.GD_DON_DAT_HANG.Rows.Count > 0)
            return true;
        else
            return false;
    }
    private bool check_cc_duyet_don_hang()
    {

        DS_GD_DON_DAT_HANG v_ds_gd_don_dat_hang = new DS_GD_DON_DAT_HANG();
        US_GD_DON_DAT_HANG v_us_gd_don_dat_hang = new US_GD_DON_DAT_HANG();
        DateTime m_dat_cuoi_thang = DateTime.Now.AddMonths(1).AddDays(-1);
        v_us_gd_don_dat_hang.load_ddh_xin_cc_duyet(v_ds_gd_don_dat_hang, CIPConvert.ToDecimal(m_hdf_id_trung_tam.Value), m_dat_cuoi_thang);
        if (v_ds_gd_don_dat_hang.GD_DON_DAT_HANG.Rows.Count > 0)
            return true;
        else
            return false;
    }
    private bool check_quyen_duyet()
    {
        DS_GD_DON_DAT_HANG v_ds_gd_don_dat_hang = new DS_GD_DON_DAT_HANG();
        US_GD_DON_DAT_HANG v_us_gd_don_dat_hang = new US_GD_DON_DAT_HANG();
        DateTime v_ngay_dat_hang = CIPConvert.ToDatetime(m_hdf_ngay_gui.Value);
        DateTime m_dat_dau_thang = new DateTime(v_ngay_dat_hang.Year, v_ngay_dat_hang.Month, 1);
        DateTime m_dat_cuoi_thang = m_dat_dau_thang.AddMonths(1).AddDays(-1);
        if (CIPConvert.ToDecimal(m_hdf_form_mode.Value) == CONST_ID_TRANG_THAI_DON_HANG.XIN_TD_DUYET)
        {
            v_us_gd_don_dat_hang.load_ddh_xin_td_duyet(v_ds_gd_don_dat_hang, CIPConvert.ToDecimal(m_hdf_id_trung_tam.Value), m_dat_cuoi_thang);
            if (CIPConvert.ToDecimal(v_ds_gd_don_dat_hang.Tables[0].Rows[0]["PHAN_TRAM_VUOT"]) <= CIPConvert.ToDecimal(0.1))
            {
                return true;
            }
            else
            {
                if (CIPConvert.ToDecimal(v_ds_gd_don_dat_hang.Tables[0].Rows[0]["PHAN_TRAM_VUOT"]) <= CIPConvert.ToDecimal(0.2))
                {
                    thong_bao("Tỉ lệ vượt nằm trong quyền duyệt của TAD. Vui lòng gửi mail xin TAD duyệt!", true);
                    m_lbl_nhap_mail.Text = "Nhập mail xin TAD duyệt";
                    return false;
                }
                else { thong_bao("Tỉ lệ vượt nằm trong quyền duyệt của CC. Vui lòng gửi mail xin CC duyệt!"); m_lbl_nhap_mail.Text = "Nhập mail xin CC duyệt"; return false; }
            }
        }
        else
            return true;    
    }
    #endregion

    #region Event
    protected void Page_Load(object sender, EventArgs e)
    {

        try
        {
            if (!IsPostBack)
            {
                string id_phong_ban = Request.QueryString["id_phong_ban"];
                string form_mode = Request.QueryString["form_mode"];
                string id_user = Request.QueryString["id_user"];
                string nguoi_gui = Request.QueryString["nguoi_gui"];
                string ngay_gui = Request.QueryString["ngay_gui"];
                m_hdf_id_trung_tam.Value = id_phong_ban;
                m_hdf_form_mode.Value = form_mode;
                m_hdf_id_user.Value = id_user;
                m_hdf_nguoi_gui.Value = nguoi_gui;
                m_hdf_ngay_gui.Value = ngay_gui;
                set_thang_hien_tai();
                set_inital_form_mode();
                load_so_luong_nhan_su();
                view_detail_grv(false);
                thong_bao("", false);
            }
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_grv_don_hang_nhap_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            if (e.CommandArgument.ToString().Equals("")) return;
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
        try
        {
            load_data_to_grid();
        }
        catch (Exception)
        {

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
            if (CIPConvert.ToDecimal(m_grv_don_hang_nhap.Rows[0].Cells[7].Text) <= 20)
            {
                m_lbl_nhap_mail.Text = "Nhập mail TAD: ";
            }
            else
                m_lbl_nhap_mail.Text = "Nhập mail CC: ";
            m_lbl_thong_bao.Visible = false;
            //Get the button that raised the event
            LinkButton btn = (LinkButton)sender;
            //Get the row that contains this button
            GridViewRow gvr = (GridViewRow)btn.NamingContainer;
            //Get rowindex
            LinkButton lbt = (LinkButton)sender;
            view_detail_grv(true);
            int rowindex = gvr.RowIndex;
            //m_grv_don_hang_nhap.SelectedIndex = rowindex;
            m_hdf_id_don_hang.Value = CIPConvert.ToStr(m_grv_don_hang_nhap.DataKeys[rowindex].Value);
            m_lbl_ma_don_hang_de.Text = m_grv_don_hang_nhap.Rows[rowindex].Cells[6].Text;
            m_lbl_tong_tien.Text = m_grv_don_hang_nhap.Rows[rowindex].Cells[9].Text + "  (VNĐ)";
            if (m_grv_don_hang_nhap.Rows[rowindex].Cells[11].Text != null)
                m_lbl_ti_le_vuot.Text = m_grv_don_hang_nhap.Rows[rowindex].Cells[11].Text;
            else
                m_lbl_ti_le_vuot.Text = "-----";
            load_data_to_grid_don_hang_de();
        }
        catch (Exception v_e)
        {

            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_lbt_duyet_OnClick(object sender, EventArgs e)
    {
        try
        {
            if (check_quyen_duyet() == false) { return; }
            string v_mail;
            US_HT_NGUOI_SU_DUNG v_us_ht_nguoi_su_dung = new US_HT_NGUOI_SU_DUNG();
            IP.Core.IPData.DS_HT_NGUOI_SU_DUNG v_ds_ht_nguoi_su_dung = new IP.Core.IPData.DS_HT_NGUOI_SU_DUNG();
            v_us_ht_nguoi_su_dung.FillDataset(v_ds_ht_nguoi_su_dung, "where id= " + CIPConvert.ToDecimal(m_hdf_id_user.Value));
            if (v_ds_ht_nguoi_su_dung.HT_NGUOI_SU_DUNG.Count > 0)
                v_mail = v_ds_ht_nguoi_su_dung.HT_NGUOI_SU_DUNG.Rows[0]["MAIL"].ToString();
            else v_mail = "";
            US_GD_DON_DAT_HANG v_us_gd_don_hang = new US_GD_DON_DAT_HANG(CIPConvert.ToDecimal(m_hdf_id_don_hang.Value));
            int thisyear = DateTime.Now.Year;
            DateTime m_dat_dau_thang = new DateTime(thisyear, int.Parse(m_cbo_chon_thang.SelectedValue.ToString()), 1);
            DateTime m_dat_cuoi_thang = m_dat_dau_thang.AddMonths(1).AddDays(-1);
            v_us_gd_don_hang.dcID_TRANG_THAI = CONST_ID_TRANG_THAI_DON_HANG.DA_DUYET;
            v_us_gd_don_hang.Update();
            m_lbl_tong_tien_da_chi.Text = CIPConvert.ToStr(v_us_gd_don_hang.get_tong_tien_da_chi_hang_thang(v_us_gd_don_hang.dcID_PHONG_BAN, m_dat_cuoi_thang), "#,###");
            string v_str_noi_dung = "Dear " + m_hdf_nguoi_gui.Value + ",\n" 
                              +"Trung tâm- ban: " + m_hdf_ma_trung_tam.Value + "." + "\n"
                              + "Đơn hàng VPP Mã phiếu:"+ m_lbl_ma_don_hang_de.Text+ "  Lần: "+ m_hdf_lan_dat.Value+ "  Ngày đặt: "+ m_hdf_ngay_dat.Value+ " đã được duyệt thành công!"
                              + "\n"
                              + "Xin cám ơn!";

            if (!v_mail.Equals("")) { BCTKApp.App_Code.HelpUtils.SendEmailHanhChinhTopica(v_mail, "Thông báo đã duyệt", v_str_noi_dung); thong_bao("Duyệt thành công!", true); }
            else { thong_bao("Duyệt thành công!"); }
            m_grv_don_hang_nhap.Visible = false;
            m_grv_don_hang_de.Visible = false;
        }

        catch (System.Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_lbt_khong_duyet_OnClick(object sender, EventArgs e)
    {
        try
        {
            string v_mail;
            US_HT_NGUOI_SU_DUNG v_us_ht_nguoi_su_dung = new US_HT_NGUOI_SU_DUNG();
            IP.Core.IPData.DS_HT_NGUOI_SU_DUNG v_ds_ht_nguoi_su_dung = new IP.Core.IPData.DS_HT_NGUOI_SU_DUNG();
            v_us_ht_nguoi_su_dung.FillDataset(v_ds_ht_nguoi_su_dung, "where id= " + CIPConvert.ToDecimal(m_hdf_id_user.Value));
            if (v_ds_ht_nguoi_su_dung.HT_NGUOI_SU_DUNG.Count > 0)
                v_mail = v_ds_ht_nguoi_su_dung.HT_NGUOI_SU_DUNG.Rows[0]["MAIL"].ToString();
            else { v_mail = "";}
            US_GD_DON_DAT_HANG v_us_gd_don_hang = new US_GD_DON_DAT_HANG(CIPConvert.ToDecimal(m_hdf_id_don_hang.Value));
            DateTime v_ngay_dat_hang = CIPConvert.ToDatetime(m_hdf_ngay_gui.Value);
            DateTime m_dat_dau_thang = new DateTime(v_ngay_dat_hang.Year, v_ngay_dat_hang.Month, 1);
            DateTime m_dat_cuoi_thang = m_dat_dau_thang.AddMonths(1).AddDays(-1);
            if (CIPConvert.ToDecimal(m_hdf_form_mode.Value) == CONST_ID_TRANG_THAI_DON_HANG.XIN_TD_DUYET)
                v_us_gd_don_hang.dcID_TRANG_THAI = CONST_ID_TRANG_THAI_DON_HANG.TD_KHONG_DUYET;
            if (CIPConvert.ToDecimal(m_hdf_form_mode.Value) == CONST_ID_TRANG_THAI_DON_HANG.XIN_CC_DUYET)
                v_us_gd_don_hang.dcID_TRANG_THAI = CONST_ID_TRANG_THAI_DON_HANG.CC_KHONG_DUYET;
            v_us_gd_don_hang.Update();
            string v_str_noi_dung = "Dear " + m_hdf_nguoi_gui.Value + ",\n" 
                           +"Trung tâm- ban: " + m_hdf_ma_trung_tam.Value + "." + "\n"
                           + "Đơn hàng MP:" + m_lbl_ma_don_hang_de.Text + "  Lần: " + m_hdf_lan_dat.Value + "  Ngày đặt: " + m_hdf_ngay_dat.Value + " Không được duyệt!"
                           + "\n"
                           + "Xin cám ơn!";

            if (!v_mail.Equals("")) { BCTKApp.App_Code.HelpUtils.SendEmailHanhChinhTopica(v_mail, "Thông báo không duyệt", v_str_noi_dung); thong_bao("Đã gửi mail thông báo không duyệt cho người gửi đơn hàng này!",true); }
            else { thong_bao("Chưa gửi mail thông báo duyệt cho người gửi đơn hàng!"); }
            m_grv_don_hang_de.Visible = false;
            m_grv_don_hang_nhap.Visible = false;
        }
        catch (System.Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_cmd_gui_mail_Click(object sender, EventArgs e)
    {
        try
        {
            string v_mail = m_txt_nhap_mail.Text + "@topica.edu.vn";
            //string v_mail = m_txt_nhap_mail.Text + "@gmail.com";
            US_GD_DON_DAT_HANG v_us = new US_GD_DON_DAT_HANG();
            DS_GD_DON_DAT_HANG v_ds = new DS_GD_DON_DAT_HANG();
            if (check_txt_mail() == true)
            {
                if (CIPConvert.ToDecimal(m_hdf_form_mode.Value) == CONST_ID_TRANG_THAI_DON_HANG.XIN_TD_DUYET)
                {
                    v_us.get_so_don_hang_nhap_trung_tam(v_ds, CIPConvert.ToDecimal(m_hdf_id_trung_tam.Value), CONST_ID_TRANG_THAI_DON_HANG.XIN_TD_DUYET);
                    if ((CIPConvert.ToDecimal(m_hdf_ti_le_vuot.Value)*100) <= 20)
                    {
                        if (check_td_duyet_don_hang() == true) { thong_bao("Đang có một đơn hàng VPP đang chờ duyệt. Vui lòng chờ TAD duyệt", true); return; };
                        m_lbl_nhap_mail.Text = "Nhập mail TAD: ";
                        string v_str_noi_dung = "Kính gửi phòng TAD,"
                                          + "\n"
                                          + "Vui lòng xem xét duyệt đơn hàng cho trung tâm - ban " + m_hdf_ma_trung_tam.Value + "\n"
                                          + "Đơn hàng VPP Mã phiếu:" + m_lbl_ma_don_hang_de.Text + "  Lần: " + m_hdf_lan_dat.Value + "  Ngày đặt: " + m_hdf_ngay_dat.Value
                                          + "\n"
                                          + "Xin cám ơn!";

                        if (!v_mail.Equals("")) { BCTKApp.App_Code.HelpUtils.SendEmailHanhChinhTopica(v_mail, "[" + m_hdf_ma_trung_tam.Value + "]Xin TAD duyệt đơn hàng VPP", v_str_noi_dung); }
                        v_us = new US_GD_DON_DAT_HANG(CIPConvert.ToDecimal(m_hdf_id_don_hang.Value));
                        v_us.dcID_TRANG_THAI = CONST_ID_TRANG_THAI_DON_HANG.XIN_TAD_DUYET;
                        v_us.Update();
                        thong_bao("Đã gửi mail thành công cho TAD", true);
                    }
                    else
                    {
                        if (check_cc_duyet_don_hang() == true) { thong_bao("Đang có một đơn hàng đang VPP chờ duyệt. Vui lòng chờ CC duyệt", true); return; };
                        m_lbl_nhap_mail.Text = "Nhập mail CC: ";
                        string v_str_noi_dung = "Kính gửi CC,"
                                          + "\n"
                                          + "Vui lòng truy cập vào đường link bên dưới để duyệt đơn hàng VPP:"
                                          + "\n"
                                          + "Đơn hàng VPP Mã phiếu:" + m_lbl_ma_don_hang_de.Text + "  Lần: " + m_hdf_lan_dat.Value + "  Ngày đặt: " + m_hdf_ngay_dat.Value + "\n"
                                          + "http://trm.topica.edu.vn/QuanLyHanhChinh/ChucNang/f481_td_duyet_don_hang_1.aspx?id_phong_ban=" + m_hdf_id_trung_tam.Value + "&form_mode=" + CONST_ID_TRANG_THAI_DON_HANG.XIN_CC_DUYET + "&id_user=" + m_hdf_id_user.Value + "&nguoi_gui=" + m_hdf_nguoi_gui.Value + "&ngay_gui=" + m_hdf_ngay_gui.Value; ;
                        if (!v_mail.Equals("")) { BCTKApp.App_Code.HelpUtils.SendEmailHanhChinhTopica(v_mail, "[" + m_hdf_ma_trung_tam.Value + "]Xin CC duyệt đơn hàng VPP", v_str_noi_dung); }
                        v_us = new US_GD_DON_DAT_HANG(CIPConvert.ToDecimal(m_hdf_id_don_hang.Value));
                        v_us.dcID_TRANG_THAI = CONST_ID_TRANG_THAI_DON_HANG.XIN_CC_DUYET;
                        v_us.Update();
                        thong_bao("Đã gửi mail thành công cho CC", true);

                    }
                }
                if (CIPConvert.ToDecimal(m_hdf_form_mode.Value) == CONST_ID_TRANG_THAI_DON_HANG.XIN_CC_DUYET)
                {
                    //cc thì k cần chức năng xin duyệt nữa
                    //v_us.get_so_don_hang_nhap_trung_tam(v_ds, CIPConvert.ToDecimal(m_hdf_id_trung_tam.Value), CONST_ID_TRANG_THAI_DON_HANG.XIN_CC_DUYET);
                    //if (check_cc_duyet_don_hang() == true) { thong_bao("Đang có một đơn hàng VPP đang chờ duyệt. Vui lòng chờ CC duyệt", true); return; };
                    //m_lbl_nhap_mail.Text = "Nhập mail CC: ";
                    //string v_str_noi_dung = "Kính gửi CC,"
                    //                  + "\n"
                    //                  + "Vui lòng truy cập vào đường link bên dưới để duyệt đơn hàng VPP:"
                    //                  + "\n"
                    //                  + "Đơn hàng VPP Mã Phiếu:" + m_lbl_ma_don_hang_de.Text + "  Lần: " + m_hdf_lan_dat.Value + "  Ngày đặt: " + m_hdf_ngay_dat.Value
                    //                  + "\n"
                    //                  + "http://trm.topica.edu.vn/QuanLyHanhChinh/ChucNang/f481_td_duyet_don_hang_1.aspx?id_phong_ban=" + m_hdf_id_trung_tam.Value + "&form_mode=" + CONST_ID_TRANG_THAI_DON_HANG.XIN_CC_DUYET + "&id_user=" + m_hdf_id_user.Value + "&nguoi_gui=" + m_hdf_nguoi_gui.Value + "&ngay_gui=" + m_hdf_ngay_gui.Value;
                    //if (!v_mail.Equals("")) { BCTKApp.App_Code.HelpUtils.SendEmailHanhChinhTopica(v_mail, "[" + m_hdf_ma_trung_tam.Value + "]Xin CC duyệt đơn hàng VPP", v_str_noi_dung); }
                    //v_us = new US_GD_DON_DAT_HANG(CIPConvert.ToDecimal(v_ds.GD_DON_DAT_HANG.Rows[0]["ID"]));
                    //v_us.dcID_TRANG_THAI = CONST_ID_TRANG_THAI_DON_HANG.XIN_CC_DUYET;
                    //v_us.Update();
                    //thong_bao("Đã gửi mail thành công cho CC", true);
                    m_txt_nhap_mail.Enabled = false; 
                }
            }
            else
                return;
            load_data_to_grid_don_hang_de();
            m_hdf_id_don_hang.Value = null;
        }
        catch (System.Exception v_e)
        {
            thong_bao(v_e.ToString(), true);
            //CSystemLog_301.ExceptionHandle(this, v_e);
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
    protected void m_grv_don_hang_de_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            m_grv_don_hang_de.PageIndex = e.NewPageIndex;
            load_data_to_grid();
            m_grv_don_hang_de.DataBind();
        }
        catch (Exception v_e)
        {

            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    #endregion
}