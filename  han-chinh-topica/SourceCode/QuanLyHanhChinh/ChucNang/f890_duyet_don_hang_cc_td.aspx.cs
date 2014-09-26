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

public partial class ChucNang_f890_duyet_don_hang_cc_td : System.Web.UI.Page
{
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
        v_us_gd_don_dat_hang.load_ddh_xin_td_duyet(v_ds_gd_don_dat_hang, v_id_trung_tam, m_dat_dau_thang, m_dat_cuoi_thang);
        m_grv_don_hang_nhap.DataSource = v_ds_gd_don_dat_hang.GD_DON_DAT_HANG;
        m_grv_don_hang_nhap.DataBind();
        //Lay tong tien dinh muc
        m_lbl_tong_tien_dm.Text = CIPConvert.ToStr(v_us_gd_don_dat_hang.get_tong_tien_dinh_muc_hang_thang(v_id_trung_tam, 173, m_dat_dau_thang, m_dat_cuoi_thang).ToString(), "#,###,##");
        m_lbl_tong_tien_da_chi.Text = CIPConvert.ToStr(v_us_gd_don_dat_hang.get_tong_tien_da_chi_hang_thang(v_id_trung_tam, m_dat_dau_thang), "#,###");
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
            switch (e.CommandName)
            {
                case "KhongDuyet":
                    v_us_gd_don_hang.dcID_TRANG_THAI = CONST_ID_TRANG_THAI_DON_HANG.TD_KHONG_DUYET;
                    break;
                case "Duyet":
                    v_us_gd_don_hang.dcID_TRANG_THAI = CONST_ID_TRANG_THAI_DON_HANG.DA_DUYET;
                    v_us_gd_don_hang.Update();
                    m_lbl_tong_tien_da_chi.Text = CIPConvert.ToStr(v_us_gd_don_hang.get_tong_tien_da_chi_hang_thang(v_us_gd_don_hang.dcID_PHONG_BAN, m_dat_dau_thang), "#,###");
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
}

