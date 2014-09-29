using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IP.Core.IPCommon;
using BCTKDS;
using BCTKDS.CDBNames;
using BCTKUS;
public partial class ChucNang_f604_xac_nhan_cong_van : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string v_str_email = "";
            decimal v_dc_id_cong_van = 0;
            if (Request.QueryString["mail"] != null)
            {
                v_str_email = Request.QueryString["mail"];
            }
            else
            {
                Response.Redirect("../../QuanLyHanhChinh");
            }
            if (Request.QueryString["id_cong_van"] != null)
            {
                v_dc_id_cong_van = CIPConvert.ToDecimal(Request.QueryString["id_cong_van"]);
            }
            else
            {
                Response.Redirect("../../QuanLyHanhChinh");
            }
            v_str_email = v_str_email.Replace("@topica.edu.vn", "").Replace("@gmail.com", "");
            DS_GD_VAN_THU v_ds_gd_van_thu = new DS_GD_VAN_THU();
            US_GD_VAN_THU v_us_gd_van_thu = new US_GD_VAN_THU();
            v_us_gd_van_thu.FillDataset(v_ds_gd_van_thu, "where id=" + v_dc_id_cong_van);
            if (v_ds_gd_van_thu.GD_VAN_THU.Count > 0) v_us_gd_van_thu = new US_GD_VAN_THU(v_dc_id_cong_van);
            else Response.Redirect("../../QuanLyHanhChinh");
            // update lai danh sach email xac nhan
            v_us_gd_van_thu.strDANH_SACH_EMAIL_XAC_NHAN = update_ds_xac_nhan(v_us_gd_van_thu.strDANH_SACH_EMAIL_XAC_NHAN, v_str_email);

            string[] v_lst_ban_hanh = v_us_gd_van_thu.strDANH_SACH_EMAIL_BAN_HANH.Split(';');
            string[] v_lst_xac_nhan = v_us_gd_van_thu.strDANH_SACH_EMAIL_XAC_NHAN.Split(';');

            bool v_b_xac_nhan_yn = false;
            foreach (string item in v_lst_ban_hanh)
            {
                int v_i_dem = 0;
                for (int i = 0; i < v_lst_xac_nhan.Length; i++)
                {
                    if (item.Trim().Equals(v_lst_xac_nhan[i].Trim()))
                    {
                        v_i_dem++;
                    }
                }
                if (v_i_dem == 0)
                {
                    v_b_xac_nhan_yn = false;
                    break;
                }
                else v_b_xac_nhan_yn = true;
            }
            if (v_b_xac_nhan_yn)
            {
                if (v_us_gd_van_thu.dcID_LOAI_CONG_VAN == ID_LOAI_VAN_THU.CONG_VAN_DI)
                {
                    v_us_gd_van_thu.dcID_TRANG_THAI = ID_TRANG_THAI_VAN_THU.NGUOI_NHAN_DA_NHAN_DUOC;
                }
                else v_us_gd_van_thu.dcID_TRANG_THAI = ID_TRANG_THAI_VAN_THU.DA_CHUYEN_CHO_DON_VI_BAN_HANH;
            }
            v_us_gd_van_thu.Update();
            m_lbl_thong_bao.Text = "Cám ơn bạn đã xác nhận công văn! Từ bây giờ, bạn có thể tra cứu công văn này trong chức năng!";
            m_hpl_chuc_nang.NavigateUrl = "f603_tra_cuu_van_ban.aspx";
            m_hpl_chuc_nang.Text = "Tra cứu văn thư";
        }
    }

    private string update_ds_xac_nhan(string ip_str_danh_sach_xac_nhan, string ip_str_email)
    {
        if (!ip_str_danh_sach_xac_nhan.Contains(ip_str_email))
            ip_str_danh_sach_xac_nhan += ";" + ip_str_email;
        string[] v_arr_ds_xn = ip_str_danh_sach_xac_nhan.Split(';');
        string v_str_result = "";
        for (int i = 0; i < v_arr_ds_xn.Length; i++)
        {
            if (!v_arr_ds_xn[i].Trim().Equals("")) v_str_result += v_arr_ds_xn[i] + ";";
        }
        return v_str_result;
    }
}