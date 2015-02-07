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
			DS_GD_BAN_HANH_VAN_BAN v_ds_gd_ban_hanh = new DS_GD_BAN_HANH_VAN_BAN();
			US_GD_BAN_HANH_VAN_BAN v_us_gd_ban_hanh = new US_GD_BAN_HANH_VAN_BAN();
			v_us_gd_ban_hanh.FillDataset(v_ds_gd_ban_hanh, "where id=" + v_dc_id_cong_van);
			if (v_ds_gd_ban_hanh.GD_BAN_HANH_VAN_BAN.Count > 0)
			{
				// update lai danh sach email xac nhan
				VanThu v_van_thu = new VanThu();
				v_van_thu.nhan_van_ban(v_dc_id_cong_van, DateTime.Now);
				//Ghi lich su
				v_us_gd_ban_hanh = new US_GD_BAN_HANH_VAN_BAN(v_dc_id_cong_van);
				string v_str_van_ban_so = "";
				US_GD_VAN_THU v_us_gd_van_thu = new US_GD_VAN_THU(v_us_gd_ban_hanh.dcID_VAN_BAN);
				if (v_us_gd_van_thu.dcID_LOAI_CONG_VAN == ID_LOAI_VAN_THU.CONG_VAN_DEN)
				{
					v_str_van_ban_so = v_us_gd_van_thu.strSO_CV_DEN;
				}
				else v_str_van_ban_so = v_us_gd_van_thu.strSO_VA_KY_HIEU;
				//v_van_thu.ghi_lich_su_hanh_dong(Person.get_user_id(), DateTime.Now, "Nhận văn bản số: " + v_str_van_ban_so);
				m_lbl_thong_bao.Text = "Cám ơn bạn đã xác nhận công văn! Từ bây giờ, bạn có thể tra cứu công văn này trong chức năng!";
				m_hpl_chuc_nang.NavigateUrl = "f603_tra_cuu_van_ban.aspx";
				m_hpl_chuc_nang.Text = "Tra cứu văn thư";
			}
			else Response.Redirect("../../QuanLyHanhChinh");

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