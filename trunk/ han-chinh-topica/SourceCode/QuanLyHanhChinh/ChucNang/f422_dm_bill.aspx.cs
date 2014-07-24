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
public partial class ChucNang_f422_dm_bill : System.Web.UI.Page
{
    #region public methods
    #endregion

    #region Members
    US_DM_BILL m_us_dm_bill = new US_DM_BILL();
    DS_DM_BILL m_ds_dm_bill = new DS_DM_BILL();
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
    private void form_to_us_object()
    {
        switch (get_form_mode(m_hdf_form_mode))
        {
            case LOAI_FORM.SUA:
                m_us_dm_bill.dcID = CIPConvert.ToDecimal(m_hdf_id_bill.Value);
                break;
            default:
                m_us_dm_bill = new US_DM_BILL();
                break;
        }
        m_us_dm_bill.strSO_BILL = m_txt_so_bill.Text.Trim();
        m_us_dm_bill.strNGUOI_NHAN = m_txt_nguoi_nhan.Text.Trim();
        m_us_dm_bill.strNOI_NHAN = m_txt_noi_nhan.Text.Trim();
        m_us_dm_bill.strNGUOI_GUI = m_txt_nguoi_gui.Text.Trim();
        m_us_dm_bill.strNOI_DUNG = m_txt_noi_dung.Text.Trim();
        m_us_dm_bill.strGHI_CHU = m_txt_ghi_chu.Text.Trim();
        if (m_txt_so_tien.Text.Trim() != "")
            m_us_dm_bill.dcSO_TIEN = CIPConvert.ToDecimal(m_txt_so_tien.Text.Trim());
        else
            m_us_dm_bill.dcSO_TIEN = 0;
        m_us_dm_bill.datNGAY_GUI = m_dat_ngay_gui.SelectedDate;
        m_us_dm_bill.dcID_PHONG_BAN = 128;
        m_us_dm_bill.dcID_TRANG_THAI = CONST_ID_TRANG_THAI_THU.ID_DA_NHAN_NOI_BO;
        if (m_rdb_trong_nuoc.Checked == true)
        {
            m_us_dm_bill.strTRONG_NUOC = "x";
        }
        if (m_rdb_nuoc_ngoai.Checked == true)
        {
            m_us_dm_bill.strNUOC_NGOAI = "x";
        }
       
    }
    private void us_object_to_form()
    {
        US_DM_BILL v_us_dm_bill = new US_DM_BILL(CIPConvert.ToDecimal(m_hdf_id_bill.Value));
        m_txt_so_bill.Text = v_us_dm_bill.strSO_BILL.Trim();
        m_txt_nguoi_nhan.Text = v_us_dm_bill.strNGUOI_NHAN.Trim();
        m_txt_noi_nhan.Text = v_us_dm_bill.strNOI_NHAN.Trim();
        m_txt_nguoi_gui.Text = v_us_dm_bill.strNGUOI_GUI.Trim();
        m_txt_noi_dung.Text = v_us_dm_bill.strNOI_DUNG.Trim();
        m_txt_ghi_chu.Text = v_us_dm_bill.strGHI_CHU.Trim();
        m_txt_so_tien.Text = v_us_dm_bill.dcSO_TIEN.ToString();
        m_dat_ngay_gui.Text = v_us_dm_bill.datNGAY_GUI.ToString();
        if (v_us_dm_bill.strTRONG_NUOC == "x")
        {
            m_rdb_trong_nuoc.Checked = true;
        }
        if (v_us_dm_bill.strNUOC_NGOAI == "x")
        {
            m_rdb_nuoc_ngoai.Checked = false;
        }
    }
    private void save_data()
    {
        if (!check_validate_is_ok()) return;
        if (!check_tien_bill()) return;
        if (!check_so_bill()) return;
        form_to_us_object();
        switch (get_form_mode(m_hdf_form_mode))
        {
            case LOAI_FORM.THEM:
                m_us_dm_bill.Insert();
                thong_bao("Đã gửi đăng kí Bill cho TAD!");
                break;
            case LOAI_FORM.SUA:
                m_us_dm_bill.Update();
                thong_bao("Đã cập nhật và gửi đăng kí lại cho TAD!");
                m_cmd_them.Visible = false;
                m_cmd_sua.Visible = true;
                set_form_mode(LOAI_FORM.THEM);
                break;
        }
        Huy_thao_tac();
    }
    private void delete_data()
    {
        //if (!check_validate_is_ok()) return;
        m_us_dm_bill.DeleteByID(CIPConvert.ToDecimal(m_hdf_id_bill.Value));
        load_data_to_grid();
        thong_bao("Đã hủy đăng ký gửi BIll cho TAD", true);
    }
    private void Huy_thao_tac()
    {
        m_txt_so_bill.Text = "";
        m_txt_nguoi_nhan.Text = "";
        m_txt_noi_nhan.Text = "";
        m_txt_noi_dung.Text = "";
        m_txt_ghi_chu.Text = "";
        m_txt_nguoi_gui.Text = "";
        m_txt_so_tien.Text = "";
        m_rdb_trong_nuoc.Checked = true;
        m_dat_ngay_gui.Text = DateTime.Now.ToShortDateString();
        this.m_hdf_id_bill.Value = "0";
        set_form_mode(LOAI_FORM.THEM);
        m_grv_dm_bill.SelectedIndex = -1;
    }
    private void set_inital_form_mode()
    {
        load_title();
        //load_data_to_cbo_don_vi_cap_tren(m_rdb_cong_ty, m_rdb_cong_ty_con, m_rdb_chi_nhanh);
        m_cmd_sua.Visible = false;
        m_cmd_them.Visible = true;
        load_data_to_grid();
        thong_bao("", false);
        m_txt_so_tien.Text = "0";
        m_txt_so_tien.Visible = false;
        m_lbl_so_tien.Visible = false;
        m_lbl_vnd.Visible = false;
    }
    private void load_title()
    {
        m_lbl_title.Text = "Nhập thông tin Bill";
        decimal v_id_trung_tam = CIPConvert.ToDecimal(m_hdf_id_trung_tam.Value);
        US_DM_PHONG_BAN v_us = new US_DM_PHONG_BAN();
        DS_DM_PHONG_BAN v_ds = new DS_DM_PHONG_BAN();
        v_us.FillDataset(v_ds,"where id="+v_id_trung_tam);
        m_lbl_ten_trung_tam.Text = v_ds.DM_PHONG_BAN.Rows[0]["TEN_PHONG_BAN"].ToString();
    }
    private void load_data_to_grid()
    {
        US_DM_BILL m_us_dm_bill = new US_DM_BILL();
        DS_DM_BILL m_ds_dm_bill = new DS_DM_BILL();
        string v_so_bill = m_txt_tim_kiem.Text.Trim();
        string v_nguoi_gui = m_txt_tim_kiem.Text.Trim();
        string v_nguoi_nhan = m_txt_tim_kiem.Text.Trim();
        string v_noi_nhan = m_txt_tim_kiem.Text.Trim();
        decimal v_id_trung_tam = CIPConvert.ToDecimal(m_hdf_id_trung_tam.Value);
        m_ds_dm_bill.Clear();
        m_us_dm_bill.FillDataset(m_ds_dm_bill, v_id_trung_tam, v_so_bill,v_nguoi_gui,v_nguoi_nhan, v_noi_nhan);
        m_grv_dm_bill.DataSource = m_ds_dm_bill.DM_BILL;
        load_title();
        string v_str_thong_tin = " (Có " + m_ds_dm_bill.DM_BILL.Rows.Count + " bản ghi)";
        m_lbl_thong_tim_grv_dm_bill.Text = v_str_thong_tin;
        m_grv_dm_bill.DataBind();
        if (!m_hdf_id_bill.Value.Equals(""))
        {
            m_grv_dm_bill.SelectedIndex = -1;
            for (int i = 0; i < m_grv_dm_bill.Rows.Count; i++)
                if (CIPConvert.ToDecimal(m_grv_dm_bill.DataKeys[i].Value) == CIPConvert.ToDecimal(m_hdf_id_bill.Value)) m_grv_dm_bill.SelectedIndex = i;
        }
        if (m_ds_dm_bill.DM_BILL.Count == 0)
            thong_bao("Không tìm thấy Bill.", true);
    }
    private bool check_tien_bill()
    {
        decimal num;
        bool isNumberic = decimal.TryParse(m_txt_so_tien.Text, out num);
        if (!isNumberic)
        {
            thong_bao("Số tiền phải là kiểu số!");
            return false;
        }
        else return true;
    }
    private bool check_so_bill()
    {
        decimal num;
        bool isNumberic = decimal.TryParse(m_txt_so_tien.Text, out num);
        if (!isNumberic)
        {
            thong_bao("Số bill phải là kiểu số!");
            return false;
        }
        else return true;
    }
    private bool check_validate_is_ok()
    {
        string v_form_mode = get_form_mode(m_hdf_form_mode);
        if (v_form_mode.Equals(LOAI_FORM.THEM) || v_form_mode.Equals(LOAI_FORM.SUA))
        {
            if (m_txt_so_bill.Text.Trim().Length != 8)
            {
                thong_bao("Số Bill gồm 8 chữ số!");
                m_txt_so_bill.Focus();
                return false;
            }
        }

        //Kiểm tra nhập trùng số Bill
        if (v_form_mode.Equals(LOAI_FORM.THEM))
        {
            if (m_us_dm_bill.check_is_having_so_bill(m_txt_so_bill.Text))
            {
                thong_bao("Số Bill đã tồn tại! ");
                return false;
            }
        }
        if (v_form_mode.Equals(LOAI_FORM.SUA))
        {
            US_DM_BILL v_us_dm_bill = new US_DM_BILL(CIPConvert.ToDecimal(m_hdf_id_bill.Value));
            if (!m_txt_so_bill.Text.Equals(v_us_dm_bill.strSO_BILL))
            {
                if (m_us_dm_bill.check_is_having_so_bill(m_txt_so_bill.Text))
                {
                    thong_bao("Số Bill đã tồn tại! ");
                    return false;
                }
            }
        }
        if (m_txt_nguoi_gui.Text == null || m_txt_nguoi_gui.Text == "") { thong_bao("Chưa nhập người gửi! "); m_txt_nguoi_gui.Focus(); return false; }
        if (m_txt_nguoi_nhan.Text == null || m_txt_nguoi_nhan.Text == "") { thong_bao("Chưa nhập người nhận! "); m_txt_nguoi_nhan.Focus(); return false; }
        if (m_txt_noi_nhan.Text == null || m_txt_noi_nhan.Text == "") { thong_bao("Chưa nhập nơi nhận! "); m_txt_noi_nhan.Focus(); return false; }
        return true;
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

                }
                else
                {
                    Response.Redirect("../Default.aspx", false);
                    HttpContext.Current.ApplicationInstance.CompleteRequest();
                }
               set_inital_form_mode();
            }
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
    protected void m_cmd_them_Click(object sender, EventArgs e)
    {
        try
        {
            //m_lbl_mess.Text = "";
            save_data();
            load_data_to_grid();
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_cmd_sua_Click(object sender, EventArgs e)
    {
        try
        {
            //m_lbl_mess.Text = "";
            save_data();
            load_data_to_grid();
            m_cmd_sua.Visible = false;
            m_cmd_them.Visible = true;
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_cmd_huy_Click(object sender, EventArgs e)
    {
        try
        {
            //m_lbl_mess.Text = "";
            Huy_thao_tac();
            m_cmd_sua.Visible = false;
            m_cmd_them.Visible = true;
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_grv_dm_bill_RowEditing(object sender, GridViewEditEventArgs e)
    {
        try
        {
            m_grv_dm_bill.SelectedIndex = e.NewEditIndex;
            //m_lbl_mess.Text = "";
            m_cmd_them.Visible = false;
            m_cmd_sua.Visible = true;
            set_form_mode(LOAI_FORM.SUA);
            m_hdf_id_bill.Value = CIPConvert.ToStr(m_grv_dm_bill.DataKeys[e.NewEditIndex].Value);
            us_object_to_form();
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_grv_dm_bill_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            Huy_thao_tac();
            m_grv_dm_bill.SelectedIndex = e.RowIndex;
            set_form_mode(LOAI_FORM.XOA);
            m_hdf_id_bill.Value = CIPConvert.ToStr(m_grv_dm_bill.DataKeys[e.RowIndex].Value);
            delete_data();
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
    protected void m_grv_v_dm_bill_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            m_grv_dm_bill.PageIndex = e.NewPageIndex;
            load_data_to_grid();
            m_grv_dm_bill.DataBind();
        }
        catch (Exception v_e)
        {

            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    
    #endregion
    
}