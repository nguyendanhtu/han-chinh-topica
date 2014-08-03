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

public partial class ChucNang_f460_Nhap_don_hang_le : System.Web.UI.Page
{
    #region public methods
    #endregion

    #region Members
    US_GD_DON_DAT_HANG_DETAIL m_us_gd_don_dat_hang_de = new US_GD_DON_DAT_HANG_DETAIL();
    DS_GD_DON_DAT_HANG_DETAIL m_ds_gd_don_dat_hang_de = new DS_GD_DON_DAT_HANG_DETAIL();
    US_GD_DON_DAT_HANG m_us_gd_don_dat_hang = new US_GD_DON_DAT_HANG();
    DS_GD_DON_DAT_HANG m_ds_gd_don_dat_hang = new DS_GD_DON_DAT_HANG();
    #endregion

    #region Data Struct
    public class LOAI_FORM
    {
        public const string THEM = "THEM";
        public const string SUA = "SUA";
        public const string XOA = "XOA";
    }
    #endregion

    #region Private Methods
    private void thong_bao(string ip_str_mess, bool ip_panel_thong_bao_visible)
    {
        m_mtv_1.SetActiveView(m_view_confirm);
        m_lbl_popup_mess.Text = ip_str_mess;
        m_pnl_confirm_tg.Visible = ip_panel_thong_bao_visible;
        m_cmd_ok.Visible = ip_panel_thong_bao_visible;
    }
    private string get_form_mode(HiddenField ip_hdf_form_mode)
    {
        if (ip_hdf_form_mode.Value.Equals("0"))
        {
            return LOAI_FORM.THEM;
        }
        if (ip_hdf_form_mode.Value.Equals("1"))
        {
            return LOAI_FORM.SUA;
        }
        if (ip_hdf_form_mode.Value.Equals("2"))
        {
            return LOAI_FORM.XOA;
        }
        return LOAI_FORM.THEM;
    }
    private void set_form_mode(string ip_loai_form)
    {
        if (ip_loai_form.Equals(LOAI_FORM.THEM))
        {
            m_hdf_form_mode.Value = "0";
        }
        if (ip_loai_form.Equals(LOAI_FORM.SUA))
        {
            m_hdf_form_mode.Value = "1";
        }
        if (ip_loai_form.Equals(LOAI_FORM.XOA))
        {
            m_hdf_form_mode.Value = "2";
        }
        thong_bao("", false);
    }
    private void form_to_us_object_don_hang_de()
    {
        switch (get_form_mode(m_hdf_form_mode))
        {
            case LOAI_FORM.SUA:
                m_us_gd_don_dat_hang_de.dcID= CIPConvert.ToDecimal(m_hdf_ID_GD_DON_DAT_HANG_DE.Value);
                break;
            default:
                m_us_gd_don_dat_hang_de = new US_GD_DON_DAT_HANG_DETAIL();
                break;
        }
        //insert đơn đặt hàng detail:
        m_us_gd_don_dat_hang_de.dcID_VPP = CIPConvert.ToDecimal(m_cbo_vpp.SelectedValue);
        m_us_gd_don_dat_hang_de.dcID_TRANG_THAI_HANG = 209;
        m_us_gd_don_dat_hang_de.dcID_DON_DAT_HANG = CIPConvert.ToDecimal(m_hdf_id_don_hang.Value);
        m_us_gd_don_dat_hang_de.dcSO_LUONG = CIPConvert.ToDecimal(m_txt_so_luong.Text);
        m_us_gd_don_dat_hang_de.dcDON_GIA_CHUA_VAT =CIPConvert.ToDecimal(m_hdf_don_gia.Value);
        m_us_gd_don_dat_hang_de.dcDON_GIA_GOM_VAT = CIPConvert.ToDecimal(m_hdf_don_gia.Value) * CIPConvert.ToDecimal(1.1);
    }
    private void form_to_us_object_don_hang()
    {
        switch (get_form_mode(m_hdf_form_mode))
        {
            case LOAI_FORM.SUA:
                m_us_gd_don_dat_hang.dcID = CIPConvert.ToDecimal(m_hdf_id_don_hang.Value);
                break;
            default:
                m_us_gd_don_dat_hang = new US_GD_DON_DAT_HANG();
                //insert đơn hàng mới:
                break;
        }
        m_us_gd_don_dat_hang.datNGAY_DAT_HANG = m_dat_ngay_gui.SelectedDate;
        m_us_gd_don_dat_hang.dcID_PHONG_BAN = CIPConvert.ToDecimal(m_hdf_id_trung_tam.Value);
        m_us_gd_don_dat_hang.dcLAN = CIPConvert.ToDecimal(m_txt_so_lan.Text);
        m_us_gd_don_dat_hang.dcID_TRANG_THAI = 209;
        m_us_gd_don_dat_hang.strMA = m_txt_ma_don_hang.Text;
    }
    private void us_object_to_form_don_hang()
    {
        US_GD_DON_DAT_HANG v_us = new US_GD_DON_DAT_HANG(CIPConvert.ToDecimal(m_hdf_id_don_hang.Value));
        m_txt_ma_don_hang.Text = v_us.strMA.ToString();
        m_txt_so_lan.Text = v_us.dcLAN.ToString();
        m_dat_ngay_gui.SelectedValue = v_us.datNGAY_DAT_HANG;
    }
    private void us_object_to_form_don_hang_de()
    {
        US_GD_DON_DAT_HANG_DETAIL v_us = new US_GD_DON_DAT_HANG_DETAIL(CIPConvert.ToDecimal(m_hdf_ID_GD_DON_DAT_HANG_DE.Value));
        m_txt_so_luong.Text = v_us.dcSO_LUONG.ToString();
        m_cbo_vpp.SelectedValue = v_us.dcID_VPP.ToString();
        load_don_vi_tinh_don_gia();
    }
    private void save_don_hang_de()
    {
        //if (!check_validate_is_ok()) return;
        //if (!check_tien_bill()) return;
        //if (!check_so_bill()) return;
        form_to_us_object_don_hang_de();
        switch (get_form_mode(m_hdf_form_mode))
        {
            case LOAI_FORM.THEM:
                m_us_gd_don_dat_hang_de.Insert();
                thong_bao("Đã thêm vào phiếu",true);
                break;
            case LOAI_FORM.SUA:
                m_us_gd_don_dat_hang_de.Update();
                m_cmd_them_don_hang_de.Visible = false;
                m_cmd_cap_nhat_don_hang_de.Visible = true;
                set_form_mode(LOAI_FORM.THEM);
                thong_bao("Đã cập nhật lại vào phiếu",true);
                break;
        }
        Huy_thao_tac_don_hang_de();
    }
    private void save_don_hang()
    {
        form_to_us_object_don_hang();
        switch (get_form_mode(m_hdf_form_mode))
        {
            case LOAI_FORM.THEM:
                m_us_gd_don_dat_hang.Insert();
                thong_bao("Đã thêm đơn hàng mới",true);
                break;
            case LOAI_FORM.SUA:
                m_us_gd_don_dat_hang.Update();
                m_cmd_them_don_hang.Visible = false;
                m_cmd_cap_nhat_don_hang.Visible = true;
                set_form_mode(LOAI_FORM.THEM);
                thong_bao("Đã cập nhật lại đơn hàng",true);
                break;
        }
    }
    private void delete_data_don_hang()
    {
        //if (!check_validate_is_ok()) return;
        m_us_gd_don_dat_hang.DeleteByID(CIPConvert.ToDecimal(m_hdf_id_don_hang.Value));
        load_data_to_grid_don_hang();
        thong_bao("Đã xóa đơn hàng thành công!", true);
    }
    private void delete_data_don_hang_de()
    {
        //if (!check_validate_is_ok()) return;
        m_us_gd_don_dat_hang_de.DeleteByID(CIPConvert.ToDecimal(m_hdf_ID_GD_DON_DAT_HANG_DE.Value));
        load_data_to_grid_don_hang_de();
        thong_bao("Đã xóa mặt hàng vừa chọn ra khỏi phiếu!", true);
    }
    private void Huy_thao_tac_don_hang()
    {
        m_txt_ma_don_hang.Text = "";
        m_txt_so_lan.Text = "";
        m_dat_ngay_gui.SelectedValue = DateTime.Now.Date;
        m_txt_ma_don_hang.Focus();
    }
    private void Huy_thao_tac_don_hang_de()
    {
        m_txt_so_luong.Text = "";
        m_cbo_vpp.Focus();
    }

    private void set_inital_form_mode()
    {
        load_ma_ten_trung_tam();
        load_cbo_VPP();
        load_don_vi_tinh_don_gia();
        m_cmd_cap_nhat_don_hang.Visible = false;
        m_cmd_cap_nhat_don_hang_de.Visible = false;
        load_data_to_grid_don_hang();
        thong_bao("", false);
        //m_txt_so_tien.Text = "0";
    }

    private void load_don_vi_tinh_don_gia()
    {
        US_V_DM_VPP v_us = new US_V_DM_VPP();
        DS_V_DM_VPP v_ds = new DS_V_DM_VPP();
        v_us.FillDataset(v_ds, "where id_vpp="+m_cbo_vpp.SelectedValue);
        m_lbl_don_vi_tinh.Text = v_ds.Tables[0].Rows[0]["DON_VI_TINH"].ToString();
        m_lbl_don_gia.Text = CIPConvert.ToStr(v_ds.Tables[0].Rows[0]["DON_GIA_CHUA_VAT"], "#,###") + " (VNĐ)";
        m_hdf_don_gia.Value = CIPConvert.ToStr(v_ds.Tables[0].Rows[0]["DON_GIA_CHUA_VAT"]);
    }

    private void load_cbo_VPP()
    {
        US_V_DM_VPP v_us = new US_V_DM_VPP();
        DS_V_DM_VPP v_ds = new DS_V_DM_VPP();
        v_us.FillDataset(v_ds);
        m_cbo_vpp.DataSource = v_ds.V_DM_VPP;
        m_cbo_vpp.DataValueField = V_DM_VPP.ID_VPP;
        m_cbo_vpp.DataTextField = V_DM_VPP.TEN_VPP;
        m_cbo_vpp.DataBind();
    }
    private void load_ma_ten_trung_tam()
    {
        
        decimal v_id_trung_tam = CIPConvert.ToDecimal(m_hdf_id_trung_tam.Value);
        US_DM_PHONG_BAN v_us = new US_DM_PHONG_BAN();
        DS_DM_PHONG_BAN v_ds = new DS_DM_PHONG_BAN();
        v_us.FillDataset(v_ds, "where id=" + v_id_trung_tam);
        m_lbl_title.Text = "Trung tâm - ban: " + v_ds.DM_PHONG_BAN.Rows[0]["TEN_PHONG_BAN"].ToString();
        // lấy mã trung tâm
        m_hdf_ma_trung_tam.Value = v_ds.DM_PHONG_BAN.Rows[0]["MA_PHONG_BAN"].ToString();   
    }
    private void load_data_to_grid_don_hang()
    {
        //load grid đơn hàng:
        US_GD_DON_DAT_HANG v_us_don_hang = new US_GD_DON_DAT_HANG();
        DS_GD_DON_DAT_HANG v_ds_don_hang = new DS_GD_DON_DAT_HANG();
        v_us_don_hang.FillDataset(v_ds_don_hang,"where ID_TRANG_THAI =" +209);
        m_grv_don_hang_nhap.DataSource = v_ds_don_hang.GD_DON_DAT_HANG;
        m_grv_don_hang_nhap.DataBind();
        string v_str_thong_tin_don_hang = " (Có " + v_ds_don_hang.GD_DON_DAT_HANG.Rows.Count + " đơn hàng)";
        m_lbl_thong_tin_don_hang.Text = v_str_thong_tin_don_hang;  
    }
    private void load_data_to_grid_don_hang_de()
    {
        //load grid đơn hàng detail:
        US_V_GD_DON_DAT_HANG_DETAIL v_us_don_hang_de = new US_V_GD_DON_DAT_HANG_DETAIL();
        DS_V_GD_DON_DAT_HANG_DETAIL v_ds_don_hang_de = new DS_V_GD_DON_DAT_HANG_DETAIL();
        v_us_don_hang_de.FillDataset(v_ds_don_hang_de,"Where id_don_dat_hang="+ CIPConvert.ToDecimal(m_hdf_id_don_hang.Value));
        m_grv_don_hang_de.DataSource = v_ds_don_hang_de.V_GD_DON_DAT_HANG_DETAIL;
        m_grv_don_hang_de.DataBind();
        string v_str_thong_tin_don_hang_de = " (Có " + v_ds_don_hang_de.V_GD_DON_DAT_HANG_DETAIL.Rows.Count + " mặt hàng)";
        m_lbl_thong_tim_grv_don_hang_de.Text = v_str_thong_tin_don_hang_de;

        if (!m_hdf_ID_GD_DON_DAT_HANG_DE.Value.Equals(""))
        {
            m_grv_don_hang_de.SelectedIndex = -1;
            for (int i = 0; i < m_grv_don_hang_de.Rows.Count; i++)
                if (CIPConvert.ToDecimal(m_grv_don_hang_de.DataKeys[i].Value) == CIPConvert.ToDecimal(m_hdf_ID_GD_DON_DAT_HANG_DE.Value)) m_grv_don_hang_de.SelectedIndex = i;
        }
    }
    //private bool check_tien_bill()
    //{
    //    decimal num;
    //    bool isNumberic = decimal.TryParse(m_txt_so_tien.Text, out num);
    //    if (!isNumberic)
    //    {
    //        thong_bao("Số tiền phải là kiểu số!");
    //        return false;
    //    }
    //    else return true;
    //}
    //private bool check_so_bill()
    //{
    //    decimal num;
    //    bool isNumberic = decimal.TryParse(m_txt_so_tien.Text, out num);
    //    if (!isNumberic)
    //    {
    //        thong_bao("Số bill phải là kiểu số!");
    //        return false;
    //    }
    //    else return true;
    //}
    //private bool check_validate_is_ok()
    //{
    //    string v_form_mode = get_form_mode(m_hdf_form_mode);
    //    if (v_form_mode.Equals(LOAI_FORM.THEM) || v_form_mode.Equals(LOAI_FORM.SUA))
    //    {
    //        if (m_txt_so_bill.Text.Trim().Length != 8)
    //        {
    //            thong_bao("Số Bill gồm 8 chữ số!");
    //            m_txt_so_bill.Focus();
    //            return false;
    //        }
    //    }

    //    //Kiểm tra nhập trùng số Bill
    //    if (v_form_mode.Equals(LOAI_FORM.THEM))
    //    {
    //        if (m_us_dm_bill.check_is_having_so_bill(m_txt_so_bill.Text))
    //        {
    //            thong_bao("Số Bill đã tồn tại! ");
    //            return false;
    //        }
    //    }
    //    if (v_form_mode.Equals(LOAI_FORM.SUA))
    //    {
    //        US_DM_BILL v_us_dm_bill = new US_DM_BILL(CIPConvert.ToDecimal(m_hdf_id_bill.Value));
    //        if (!m_txt_so_bill.Text.Equals(v_us_dm_bill.strSO_BILL))
    //        {
    //            if (m_us_dm_bill.check_is_having_so_bill(m_txt_so_bill.Text))
    //            {
    //                thong_bao("Số Bill đã tồn tại! ");
    //                return false;
    //            }
    //        }
    //    }
    //    if (m_txt_nguoi_gui.Text == null || m_txt_nguoi_gui.Text == "") { thong_bao("Chưa nhập người gửi! "); m_txt_nguoi_gui.Focus(); return false; }
    //    if (m_txt_nguoi_nhan.Text == null || m_txt_nguoi_nhan.Text == "") { thong_bao("Chưa nhập người nhận! "); m_txt_nguoi_nhan.Focus(); return false; }
    //    if (m_txt_noi_nhan.Text == null || m_txt_noi_nhan.Text == "") { thong_bao("Chưa nhập nơi nhận! "); m_txt_noi_nhan.Focus(); return false; }
    //    return true;
    //}

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
    private void load_ma_don_hang_title()
    {
        US_GD_DON_DAT_HANG v_us = new US_GD_DON_DAT_HANG();
        DS_GD_DON_DAT_HANG v_ds = new DS_GD_DON_DAT_HANG();
        v_us.FillDataset(v_ds, "where id=" + CIPConvert.ToDecimal(m_hdf_id_don_hang.Value));
        m_lbl_title_ma_don_hang.Text = "Nhập chi tiết đơn hàng " + v_ds.Tables[0].Rows[0]["MA"].ToString();
        m_lbl_ma_don_hang_de.Text = v_ds.Tables[0].Rows[0]["MA"].ToString();
    }
    #endregion

    #region Events
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
                }
                else
                {
                    Response.Redirect("../Default.aspx", false);
                    HttpContext.Current.ApplicationInstance.CompleteRequest();
                }
                thong_bao("", false);
                
                
            }
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    //đơn hàng
    protected void m_cmd_them_don_hang_Click(object sender, EventArgs e)
    {
        try
        {
            save_don_hang();
            load_data_to_grid_don_hang();
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_cmd_cap_nhat_don_hang_Click(object sender, EventArgs e)
    {
        try
        {
            //m_lbl_mess.Text = "";
            save_don_hang();
            load_data_to_grid_don_hang();
            m_cmd_cap_nhat_don_hang.Visible = false;
            m_cmd_them_don_hang.Visible = true;
            Huy_thao_tac_don_hang();
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_grv_don_hang_nhap_RowEditing(object sender, GridViewEditEventArgs e)
    {
        try
        {
            m_grv_don_hang_nhap.SelectedIndex = e.NewEditIndex;
            //m_lbl_mess.Text = "";
            m_cmd_them_don_hang.Visible = false;
            m_cmd_cap_nhat_don_hang.Visible = true;
            set_form_mode(LOAI_FORM.SUA);
            m_hdf_id_don_hang.Value = CIPConvert.ToStr(m_grv_don_hang_nhap.DataKeys[e.NewEditIndex].Value);
            //load_ma_don_hang_title();
            //load_data_to_grid_don_hang_detail();
            us_object_to_form_don_hang();
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_grv_don_hang_nhap_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            Huy_thao_tac_don_hang();
            m_grv_don_hang_nhap.SelectedIndex = e.RowIndex;
            set_form_mode(LOAI_FORM.XOA);
            m_hdf_id_don_hang.Value = CIPConvert.ToStr(m_grv_don_hang_nhap.DataKeys[e.RowIndex].Value);
            delete_data_don_hang();
            load_data_to_grid_don_hang();
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_grv_don_hang_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            m_grv_don_hang_nhap.PageIndex = e.NewPageIndex;
            m_grv_don_hang_nhap.DataBind();
            load_data_to_grid_don_hang();
        }
        catch (Exception v_e)
        {

            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    //đơn hàng detail
    protected void m_lbt_detail_OnClick(object sender, EventArgs e)
    {
        try
        {
            //Get the button that raised the event
            LinkButton btn = (LinkButton)sender;
            //Get the row that contains this button
            GridViewRow gvr = (GridViewRow)btn.NamingContainer;
            //Get rowindex
            int rowindex = gvr.RowIndex;
            m_hdf_id_don_hang.Value = CIPConvert.ToStr(m_grv_don_hang_nhap.DataKeys[rowindex].Value);
            load_ma_don_hang_title();
            load_data_to_grid_don_hang_de();
        }
        catch (Exception v_e)
        {
            
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    
    }
    protected void m_cmd_them_don_hang_de_Click(object sender, EventArgs e)
    {
        try
        {
            save_don_hang_de();
            load_data_to_grid_don_hang_de();
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_cmd_cap_nhat_don_hang_de_Click(object sender, EventArgs e)
    {
        try
        {
            save_don_hang_de();
            load_data_to_grid_don_hang();
            m_cmd_cap_nhat_don_hang_de.Visible = false;
            m_cmd_them_don_hang_de.Visible = true;
            Huy_thao_tac_don_hang_de();
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_grv_don_hang_de_RowEditing(object sender, GridViewEditEventArgs e)
    {
        try
        {
            m_grv_don_hang_de.SelectedIndex = e.NewEditIndex;
            //m_lbl_mess.Text = "";
            m_cmd_them_don_hang_de.Visible = false;
            m_cmd_cap_nhat_don_hang_de.Visible = true;
            set_form_mode(LOAI_FORM.SUA);
            m_hdf_ID_GD_DON_DAT_HANG_DE.Value = CIPConvert.ToStr(m_grv_don_hang_nhap.DataKeys[e.NewEditIndex].Value);
            us_object_to_form_don_hang_de();
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_grv_don_hang_de_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            Huy_thao_tac_don_hang_de();
            m_grv_don_hang_de.SelectedIndex = e.RowIndex;
            set_form_mode(LOAI_FORM.XOA);
            m_hdf_ID_GD_DON_DAT_HANG_DE.Value = CIPConvert.ToStr(m_grv_don_hang_de.DataKeys[e.RowIndex].Value);
            delete_data_don_hang_de();
            load_data_to_grid_don_hang_de();
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_grv_don_hang_de_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        m_grv_don_hang_de.PageIndex = e.NewPageIndex;
        m_grv_don_hang_de.DataBind();
        load_data_to_grid_don_hang_de();
    }
    //khác
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
    protected void m_cbo_vpp_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            US_V_DM_VPP v_us = new US_V_DM_VPP();
            DS_V_DM_VPP v_ds = new DS_V_DM_VPP();
            v_us.FillDataset(v_ds, "where id_vpp="+m_cbo_vpp.SelectedValue);
            m_lbl_don_vi_tinh.Text = v_ds.Tables[0].Rows[0]["DON_VI_TINH"].ToString();
            m_lbl_don_gia.Text = CIPConvert.ToStr(v_ds.Tables[0].Rows[0]["DON_GIA_CHUA_VAT"],"#,###")+ " (VNĐ)";
            m_hdf_don_gia.Value = CIPConvert.ToStr(v_ds.Tables[0].Rows[0]["DON_GIA_CHUA_VAT"]);
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    #endregion
}