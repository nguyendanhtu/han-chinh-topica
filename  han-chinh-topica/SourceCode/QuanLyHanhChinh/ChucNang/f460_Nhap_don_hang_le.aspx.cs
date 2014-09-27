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

    private void set_inital_form_mode()
    {
        m_txt_ngay_nhap.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
        m_txt_so_lan.Text = "1";
        load_ma_ten_trung_tam();
        set_so_phieu();
        load_cbo_VPP();
        load_don_vi_tinh_don_gia();
        m_cmd_cap_nhat_don_hang.Visible = false;
        m_cmd_cap_nhat_don_hang_de.Visible = false;
        load_data_to_grid_don_hang();
        m_lbl_ma_don_hang_de.Visible = false;
        m_lbl_MP.Visible = false;
        m_lbl_thong_bao.Visible = false;
        m_hdf_id_don_hang.Value = null;
        //load_ma_don_hang_nhap_gan_nhat();
        //thong_bao("", false);
    }
    private void set_so_phieu()
    {
        m_lbl_hien_thi_so_phieu.Text = CIPConvert.ToStr(m_hdf_ma_trung_tam.Value) + "-" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second;
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
                m_us_gd_don_dat_hang_de.dcID = CIPConvert.ToDecimal(m_hdf_ID_GD_DON_DAT_HANG_DE.Value);
                break;
            default:
                m_us_gd_don_dat_hang_de = new US_GD_DON_DAT_HANG_DETAIL();
                break;
        }
        //insert đơn đặt hàng detail:
        m_us_gd_don_dat_hang_de.dcID_VPP = CIPConvert.ToDecimal(m_cbo_vpp.SelectedValue);
        m_us_gd_don_dat_hang_de.dcID_TRANG_THAI_HANG = CONST_ID_TRANG_THAI_DON_HANG_DE.TT_DANG_KI_DON_HANG;
        m_us_gd_don_dat_hang_de.dcID_DON_DAT_HANG = CIPConvert.ToDecimal(m_hdf_id_don_hang.Value);
        m_us_gd_don_dat_hang_de.dcSO_LUONG = CIPConvert.ToDecimal(m_txt_so_luong.Text);
        m_us_gd_don_dat_hang_de.dcDON_GIA_CHUA_VAT = CIPConvert.ToDecimal(m_hdf_don_gia.Value);
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
                break;
        }
        m_us_gd_don_dat_hang.datNGAY_DAT_HANG = CIPConvert.ToDatetime(m_txt_ngay_nhap.Text, "dd/MM/yyyy");
        m_us_gd_don_dat_hang.dcID_PHONG_BAN = CIPConvert.ToDecimal(m_hdf_id_trung_tam.Value);
        m_us_gd_don_dat_hang.dcLAN = CIPConvert.ToDecimal(m_txt_so_lan.Text);
        m_us_gd_don_dat_hang.dcID_TRANG_THAI = CONST_ID_TRANG_THAI_DON_HANG.NHAP;
        m_us_gd_don_dat_hang.strMA = m_lbl_hien_thi_so_phieu.Text;
        m_us_gd_don_dat_hang.strMA_HD_NCC = "";
        m_us_gd_don_dat_hang.dcGIA_TRI_DA_VAT = 0;
        m_us_gd_don_dat_hang.dcGIA_TRI_CHUA_VAT = 0;
    }

    private void us_object_to_form_don_hang()
    {
        US_GD_DON_DAT_HANG v_us = new US_GD_DON_DAT_HANG(CIPConvert.ToDecimal(m_hdf_id_don_hang.Value));
        m_lbl_hien_thi_so_phieu.Text = v_us.strMA.ToString();
        m_txt_so_lan.Text = v_us.dcLAN.ToString();
        m_txt_ngay_nhap.Text = v_us.datNGAY_DAT_HANG.ToShortDateString();
    }
    private void us_object_to_form_don_hang_de()
    {
        US_GD_DON_DAT_HANG_DETAIL v_us_son_hang_de = new US_GD_DON_DAT_HANG_DETAIL(CIPConvert.ToDecimal(m_hdf_ID_GD_DON_DAT_HANG_DE.Value));
        US_V_DM_VPP v_us = new US_V_DM_VPP();
        DS_V_DM_VPP v_ds = new DS_V_DM_VPP();
        v_us.FillDataset(v_ds, "where id_vpp =" + v_us_son_hang_de.dcID_VPP);
        m_txt_so_luong.Text = v_us_son_hang_de.dcSO_LUONG.ToString();
        m_cbo_vpp.DataTextField = v_ds.Tables[0].Rows[0]["TEN_VPP"].ToString();
        m_lbl_don_gia.Text = CIPConvert.ToStr(v_ds.Tables[0].Rows[0]["DON_GIA_CHUA_VAT"], "#,###") + " (VNĐ)";
    }

    private void save_don_hang_de()
    {

        if (!check_so_luong()) return;
        if (!check_vpp_da_ton_tai(CIPConvert.ToDecimal(m_txt_so_luong.Text))) return;
        form_to_us_object_don_hang_de();
        switch (get_form_mode(m_hdf_form_mode))
        {
            case LOAI_FORM.THEM:
                m_us_gd_don_dat_hang_de.Insert();
                //thong_bao("Đã thêm VPP mới vào phiếu",true);
                m_lbl_thong_bao.Visible = true;
                m_lbl_thong_bao.Text = "✓ Đã thêm thành công .";
                break;
            case LOAI_FORM.SUA:
                m_us_gd_don_dat_hang_de.Update();
                m_cmd_them_don_hang_de.Visible = false;
                m_cmd_cap_nhat_don_hang_de.Visible = true;
                set_form_mode(LOAI_FORM.THEM);
                //thong_bao("Đã cập nhật lại VPP vào phiếu",true);
                m_lbl_thong_bao.Visible = true;
                m_lbl_thong_bao.Text = "✓ Đã cập nhật thành công .";
                break;
        }
        update_tong_tien_don_hang(m_us_gd_don_dat_hang_de.dcID_DON_DAT_HANG);
        Huy_thao_tac_don_hang_de();
    }
    private void update_tong_tien_don_hang(decimal ip_id_don_dat_hang)
    {
        US_GD_DON_DAT_HANG v_us = new US_GD_DON_DAT_HANG();
        DS_GD_DON_DAT_HANG v_ds = new DS_GD_DON_DAT_HANG();
        v_us.Update_tong_tien_don_hang(v_ds, ip_id_don_dat_hang);
        load_data_to_grid_don_hang();
    }
    private void save_don_hang()
    {
        if (!check_validate_is_ok()) return;
        if (!check_so_lan()) return;
        form_to_us_object_don_hang();
        switch (get_form_mode(m_hdf_form_mode))
        {
            case LOAI_FORM.THEM:
                m_us_gd_don_dat_hang.Insert();
                thong_bao("Đã thêm đơn hàng mới", true);
                break;
            case LOAI_FORM.SUA:
                m_us_gd_don_dat_hang.Update();
                m_cmd_them_don_hang.Visible = false;
                m_cmd_cap_nhat_don_hang.Visible = true;
                set_form_mode(LOAI_FORM.THEM);
                thong_bao("Đã cập nhật lại đơn hàng", true);
                break;
        }
    }
    private void delete_data_don_hang()
    {
        //if (!check_validate_is_ok()) return;
        US_GD_DON_DAT_HANG_DETAIL v_us = new US_GD_DON_DAT_HANG_DETAIL();
        DS_GD_DON_DAT_HANG_DETAIL v_ds = new DS_GD_DON_DAT_HANG_DETAIL();
        v_us.Delete_don_hang_de(v_ds, CIPConvert.ToDecimal(m_hdf_id_don_hang.Value));
        m_us_gd_don_dat_hang.DeleteByID(CIPConvert.ToDecimal(m_hdf_id_don_hang.Value));
        m_grv_don_hang_nhap.SelectedIndex = -1;
        load_data_to_grid_don_hang();
        thong_bao("Đã xóa đơn hàng thành công!", true);
    }
    private void delete_data_don_hang_de()
    {
        //if (!check_validate_is_ok()) return;
        m_us_gd_don_dat_hang_de.DeleteByID(CIPConvert.ToDecimal(m_hdf_ID_GD_DON_DAT_HANG_DE.Value));
        m_grv_don_hang_de.SelectedIndex = -1;
        load_data_to_grid_don_hang_de();
        thong_bao("Đã xóa mặt hàng vừa chọn ra khỏi phiếu!", true);
    }
    private void Huy_thao_tac_don_hang()
    {
        m_lbl_hien_thi_so_phieu.Text = "";
        m_txt_so_lan.Text = "";
        m_txt_ngay_nhap.Text = DateTime.Now.Date.ToShortDateString();
        m_grv_don_hang_nhap.SelectedIndex = -1;
        m_hdf_id_don_hang.Value = "0";
    }
    private void Huy_thao_tac_don_hang_de()
    {
        m_txt_so_luong.Text = "";
        m_grv_don_hang_de.SelectedIndex = -1;
        m_hdf_ID_GD_DON_DAT_HANG_DE.Value = "0";
        m_cbo_vpp.Focus();
    }


    private void load_ma_don_hang_nhap_gan_nhat()
    {
        US_GD_DON_DAT_HANG v_us = new US_GD_DON_DAT_HANG();
        DS_GD_DON_DAT_HANG v_ds = new DS_GD_DON_DAT_HANG();
        v_us.FillDataset(v_ds, "SELECT TOP(1) * FROM GD_DON_DAT_HANG WHERE ID_TRANG_THAI= " + CONST_ID_TRANG_THAI_DON_HANG.NHAP + " ORDER BY NGAY_DAT_HANG DESC, LAN DESC");
        if (v_ds.Tables[0].Rows.Count != 0)
        {
            m_hdf_id_don_hang.Value = v_ds.Tables[0].Rows[0]["ID"].ToString();
            load_ma_don_hang_title();
            load_data_to_grid_don_hang_de();
        }
        else return;
    }
    private void load_don_vi_tinh_don_gia()
    {
        US_V_DM_VPP v_us = new US_V_DM_VPP();
        DS_V_DM_VPP v_ds = new DS_V_DM_VPP();
        v_us.FillDataset(v_ds, "where id_vpp=" + m_cbo_vpp.SelectedValue);
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
        //US_GD_DON_DAT_HANG v_us_don_hang = new US_GD_DON_DAT_HANG();
        //DS_GD_DON_DAT_HANG v_ds_don_hang = new DS_GD_DON_DAT_HANG();
        decimal v_id_phong_ban = CIPConvert.ToDecimal(m_hdf_id_trung_tam.Value);
        US_RPT_GD_DON_DAT_HANG_DINH_MUC v_us_don_hang = new US_RPT_GD_DON_DAT_HANG_DINH_MUC();
        DS_RPT_GD_DON_DAT_HANG_DINH_MUC v_ds_don_hang = new DS_RPT_GD_DON_DAT_HANG_DINH_MUC();
        v_us_don_hang.FillDataset(v_ds_don_hang, v_id_phong_ban);
        m_grv_don_hang_nhap.DataSource = v_ds_don_hang.RPT_GD_DON_DAT_HANG_DINH_MUC;
        m_grv_don_hang_nhap.DataBind();
        string v_str_thong_tin_don_hang = " (Có " + v_ds_don_hang.RPT_GD_DON_DAT_HANG_DINH_MUC.Rows.Count + " đơn hàng)";
        m_lbl_thong_tin_don_hang.Text = v_str_thong_tin_don_hang;
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
    private void load_ma_don_hang_title()
    {
        US_GD_DON_DAT_HANG v_us = new US_GD_DON_DAT_HANG();
        DS_GD_DON_DAT_HANG v_ds = new DS_GD_DON_DAT_HANG();
        v_us.FillDataset(v_ds, "where id=" + CIPConvert.ToDecimal(m_hdf_id_don_hang.Value));
        m_lbl_title_ma_don_hang.Text = "Nhập chi tiết đơn hàng ";
        m_lbl_ma_don_hang_de.Text = v_ds.Tables[0].Rows[0]["MA"].ToString();
        m_lbl_ma_don_hang_de.Visible = true;
        m_lbl_MP.Visible = true;
    }

    private bool chuyen_trang_thai_sang_gui_td()
    {
        bool v_flag = false;
        foreach (GridViewRow row in m_grv_don_hang_nhap.Rows)
        {
            if (row.RowType == DataControlRowType.DataRow)
            {
                System.Web.UI.WebControls.CheckBox chkRow = (row.Cells[0].FindControl("chkRow") as System.Web.UI.WebControls.CheckBox);
                if (chkRow.Checked)
                {
                    US_GD_DON_DAT_HANG v_us = new US_GD_DON_DAT_HANG();
                    DS_GD_DON_DAT_HANG v_ds = new DS_GD_DON_DAT_HANG();
                    string ma_don_hang = row.Cells[6].Text;
                    v_us.Chuyen_trang_thai_gui_cho_td(v_ds, ma_don_hang);
                    v_flag = true;
                }
            }
        }
        load_data_to_grid_don_hang();
        if (v_flag == false)
        {
            thong_bao("Chưa chọn đơn hàng để gửi", true);
            return false;
        }
        else return true;
    }
    private bool gui_mail_thong_bao_cho_td()
    {
        string v_user_group_name = "QL_" + m_hdf_ma_trung_tam.Value.ToUpper();
        US_HT_USER_GROUP v_us_user_group = new US_HT_USER_GROUP();
        DS_HT_USER_GROUP v_ds_user_group = new DS_HT_USER_GROUP();
        v_us_user_group.FillDataset(v_ds_user_group, "where USER_GROUP_NAME = '" + v_user_group_name + "' or USER_GROUP_NAME= '" + v_user_group_name + "-TU'");
        if (v_ds_user_group.HT_USER_GROUP.Rows.Count > 0)
        {
            decimal v_id_user_group = CIPConvert.ToDecimal(v_ds_user_group.HT_USER_GROUP.Rows[0]["ID"]);
            US_HT_NGUOI_SU_DUNG v_us_ht_nguoi_su_dung = new US_HT_NGUOI_SU_DUNG();
            IP.Core.IPData.DS_HT_NGUOI_SU_DUNG v_ds_ht_nguoi_su_dung = new IP.Core.IPData.DS_HT_NGUOI_SU_DUNG();
            v_us_ht_nguoi_su_dung.FillDataset(v_ds_ht_nguoi_su_dung, "where ID_USER_GROUP =" + v_id_user_group);
            string v_mail = v_ds_ht_nguoi_su_dung.HT_NGUOI_SU_DUNG.Rows[0]["MAIL"].ToString();
            string v_str_noi_dung = "Kính gửi: Trưởng phòng " + " " + m_hdf_ma_trung_tam.Value
                                    + "\n"
                                    + "Vui lòng truy cập vào đường link bên dưới để duyệt đơn hàng. Xin cám ơn!"
                                    + "\n"
                                    + "http://trm.topica.edu.vn/QuanLyHanhChinh/ChucNang/f890_duyet_don_hang_cc_td.aspx";
            if (!v_mail.Equals("")) { BCTKApp.App_Code.HelpUtils.SendEmailHanhChinhTopica(v_mail, "Xin TD duyệt đơn hàng", v_str_noi_dung); return true; }
            else { thong_bao("Chưa có địa chỉ mail của TD.", true); return false; }
        }
        else
        { thong_bao("Không tìm thấy user TD để gửi mail.", true); return false; }
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
    private void view_detail_grv(bool ip_visible)
    {
        mtv_detail.SetActiveView(View_detail);
        m_pnl_detail_grv.Visible = ip_visible;
    }
    private bool check_validate_is_ok()
    {
        string v_form_mode = get_form_mode(m_hdf_form_mode);

        //Kiểm tra nhập trùng mã đơn hàng
        if (v_form_mode.Equals(LOAI_FORM.THEM))
        {
            if (m_us_gd_don_dat_hang.check_is_having_ma_don_hang(m_lbl_hien_thi_so_phieu.Text.Trim()))
            {
                thong_bao("Mã đơn hàng này đã tồn tại! ", true);
                return false;
            }
        }
        if (v_form_mode.Equals(LOAI_FORM.SUA))
        {
            US_GD_DON_DAT_HANG v_us = new US_GD_DON_DAT_HANG(CIPConvert.ToDecimal(m_hdf_id_don_hang.Value));
            if (!m_lbl_hien_thi_so_phieu.Text.Equals(v_us.strMA))
            {
                if (v_us.check_is_having_ma_don_hang(m_lbl_hien_thi_so_phieu.Text))
                {
                    thong_bao("Mã đơn hàng này đã tồn tại! ", true);
                    return false;
                }
            }
        }
        if (m_lbl_hien_thi_so_phieu.Text == null || m_lbl_hien_thi_so_phieu.Text == "") { thong_bao("Chưa nhập mã đơn hàng! "); return false; }
        //if (m_txt_nguoi_nhan.Text == null || m_txt_nguoi_nhan.Text == "") { thong_bao("Chưa nhập người nhận! "); m_txt_nguoi_nhan.Focus(); return false; }
        //if (m_txt_noi_nhan.Text == null || m_txt_noi_nhan.Text == "") { thong_bao("Chưa nhập nơi nhận! "); m_txt_noi_nhan.Focus(); return false; }
        return true;
    }
    private bool check_so_luong()
    {
        decimal num;
        bool isNumberic = decimal.TryParse(m_txt_so_luong.Text, out num);
        if (!isNumberic)
        {
            thong_bao("Số lượng phải là kiểu số!");
            return false;
        }
        else return true;
    }
    private bool check_so_lan()
    {
        if (m_txt_so_lan.Text.Trim() != "")
        {
            decimal num;
            bool isNumberic = decimal.TryParse(m_txt_so_lan.Text, out num);
            if (!isNumberic)
            {
                thong_bao("Số lần phải là kiểu số!");
                return false;
            }
            else return true;
        }
        else
        {
            m_txt_so_lan.Text = "1";
            return true;
        }
    }
    private bool check_vpp_da_ton_tai(decimal ip_so_luong)
    {
        string v_form_mode = get_form_mode(m_hdf_form_mode);

        //Kiểm tra loại vpp đã tồn tại
        if (v_form_mode.Equals(LOAI_FORM.THEM))
        {
            if (m_us_gd_don_dat_hang_de.check_is_having_vpp_don_hang_de(CIPConvert.ToDecimal(m_cbo_vpp.SelectedValue), CIPConvert.ToDecimal(m_hdf_id_don_hang.Value)))
            {
                //thong_bao("Loại VPP này đã tồn tại!", true);
                m_us_gd_don_dat_hang_de.update_so_luong_VPP_da_ton_tai(m_ds_gd_don_dat_hang_de, CIPConvert.ToDecimal(m_cbo_vpp.SelectedValue), ip_so_luong);
                update_tong_tien_don_hang(CIPConvert.ToDecimal(m_hdf_id_don_hang.Value));
                Huy_thao_tac_don_hang_de();
                //thong_bao("Đã thêm số lượng mới vào loại VPP này!", true);
                m_lbl_thong_bao.Visible = true;
                m_lbl_thong_bao.Text = "✓ Đã thêm số lượng mới cho VPP .";
                return false;
            }
        }
        if (v_form_mode.Equals(LOAI_FORM.SUA))
        {
            US_GD_DON_DAT_HANG_DETAIL v_us = new US_GD_DON_DAT_HANG_DETAIL(CIPConvert.ToDecimal(m_hdf_ID_GD_DON_DAT_HANG_DE.Value));
            if (CIPConvert.ToDecimal(m_cbo_vpp.SelectedValue) == v_us.dcID_VPP)
            {
                if (v_us.check_is_having_vpp_don_hang_de(CIPConvert.ToDecimal(m_cbo_vpp.SelectedValue), CIPConvert.ToDecimal(m_hdf_id_don_hang.Value)))
                {
                    //thong_bao("Loại VPP này đã tồn tại!", true);
                    m_us_gd_don_dat_hang_de.update_so_luong_VPP_da_ton_tai(m_ds_gd_don_dat_hang_de, CIPConvert.ToDecimal(m_cbo_vpp.SelectedValue), ip_so_luong);
                    update_tong_tien_don_hang(CIPConvert.ToDecimal(m_hdf_id_don_hang.Value));
                    Huy_thao_tac_don_hang_de();
                    //thong_bao("Đã thêm số lượng mới vào loại VPP này!", true);
                    m_lbl_thong_bao.Visible = true;
                    m_lbl_thong_bao.Text = "✓ Đã thêm số lượng mới cho VPP .";
                    return false;
                }
            }
        }
        return true;
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
                //if (!Person.check_user_have_menu())
                //{
                //    ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "<script type = 'text/javascript'>alert('Bạn không có quyền sử dụng chức năng này!');window.location.replace('/TraCuuKeToan/')</script>");
                //}
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
                thong_bao("", false, false);
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
            m_lbl_thong_bao.Visible = false;
            set_form_mode(LOAI_FORM.THEM);
            set_so_phieu();
            save_don_hang();
            load_data_to_grid_don_hang();
        }
        catch (Exception v_e)
        {
            thong_bao("Lỗi: " + v_e.ToString());
            //CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_cmd_cap_nhat_don_hang_Click(object sender, EventArgs e)
    {
        try
        {
            m_lbl_thong_bao.Visible = false;
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
            m_lbl_thong_bao.Visible = false;
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
            m_lbl_thong_bao.Visible = false;
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
            m_lbl_thong_bao.Visible = false;
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
            m_lbl_thong_bao.Visible = false;
            if (m_hdf_id_don_hang.Value == "" || m_hdf_id_don_hang.Value == null)
            { thong_bao("Bạn chưa chọn chi tiết đơn hàng", true); return; }
            set_form_mode(LOAI_FORM.THEM);
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
            load_data_to_grid_don_hang_de();
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
            m_lbl_thong_bao.Visible = false;
            m_grv_don_hang_de.SelectedIndex = e.NewEditIndex;
            //m_lbl_mess.Text = "";
            m_cmd_them_don_hang_de.Visible = false;
            m_cmd_cap_nhat_don_hang_de.Visible = true;
            set_form_mode(LOAI_FORM.SUA);
            m_hdf_ID_GD_DON_DAT_HANG_DE.Value = CIPConvert.ToStr(m_grv_don_hang_de.DataKeys[e.NewEditIndex].Value);
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
            m_lbl_thong_bao.Visible = false;
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
        m_lbl_thong_bao.Visible = false;
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
    //protected void m_cmd_gui_td_Click(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        m_lbl_thong_bao.Visible = false;
    //        if (chuyen_trang_thai_sang_gui_td() == true)
    //        {
    //            if (gui_mail_thong_bao_cho_td() == true)
    //                thong_bao("Đã gửi cho TD duyệt. \nMail thông báo đã được gửi đi.", true);
    //            else
    //            { thong_bao("Đã gửi cho TD duyệt. \nMail thông báo chưa được gửi do chưa cập nhật địa chỉ mail.");}
    //        }
    //        else return; 
    //        m_grv_don_hang_de.Visible = false;
    //        m_lbl_ma_don_hang_de.Visible = false;
    //        m_lbl_MP.Visible = false;
    //        m_lbl_thong_tim_grv_don_hang_de.Text = "";
    //        m_hdf_id_don_hang.Value = null;
    //    }
    //    catch (System.Exception v_e)
    //    {
    //        thong_bao(v_e.ToString(),true);
    //        //CSystemLog_301.ExceptionHandle(this, v_e);
    //    }
    //}

    protected void m_cbo_vpp_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            m_lbl_thong_bao.Visible = false;
            US_V_DM_VPP v_us = new US_V_DM_VPP();
            DS_V_DM_VPP v_ds = new DS_V_DM_VPP();
            v_us.FillDataset(v_ds, "where id_vpp=" + m_cbo_vpp.SelectedValue);
            m_lbl_don_vi_tinh.Text = v_ds.Tables[0].Rows[0]["DON_VI_TINH"].ToString();
            m_lbl_don_gia.Text = CIPConvert.ToStr(v_ds.Tables[0].Rows[0]["DON_GIA_CHUA_VAT"], "#,###") + " (VNĐ)";
            m_hdf_don_gia.Value = CIPConvert.ToStr(v_ds.Tables[0].Rows[0]["DON_GIA_CHUA_VAT"]);
            m_txt_so_luong.Focus();
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void OnCheckedChanged_chkRow(object sender, EventArgs e)
    {
        try
        {
            m_lbl_thong_bao.Visible = false;
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
    protected void m_grv_don_hang_nhap_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            US_GD_DON_DAT_HANG v_us = new US_GD_DON_DAT_HANG();
            DS_GD_DON_DAT_HANG v_ds = new DS_GD_DON_DAT_HANG();
            if (e.CommandArgument.ToString().Equals("")) return;
            decimal v_dc_id_don_hang = CIPConvert.ToDecimal(e.CommandArgument);
            if (e.CommandName == "XinTDDuyet")
            {
                v_us.dcID_TRANG_THAI = CONST_ID_TRANG_THAI_DON_HANG.XIN_TAD_DUYET;
                v_us.Update();
                if (gui_mail_thong_bao_cho_td() == true)
                    thong_bao("Đã gửi cho TD duyệt. \nMail thông báo đã được gửi đi.", true);
                else
                { thong_bao("Đã gửi cho TD duyệt. \nMail thông báo chưa được gửi do chưa cập nhật địa chỉ mail."); }
            }
            load_data_to_grid_don_hang();
            m_hdf_id_don_hang.Value = null;
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    #endregion
}