using System;
using System.Collections.Generic;
using System.Text;

namespace BCTKUS
{
	public class VanThu
	{
		public bool ghi_lich_su_hanh_dong(
			decimal ip_dc_id_nguoi_su_dung
			, DateTime ip_dat_thoi_diem
			, string ip_str_hanh_dong)
		{
			try
			{
				US_HT_VAN_THU_HISTORY v_us = new US_HT_VAN_THU_HISTORY();
				v_us.dcID_NGUOI_SU_DUNG = ip_dc_id_nguoi_su_dung;
				v_us.datTHOI_DIEM = ip_dat_thoi_diem;
				v_us.strHANH_DONG = ip_str_hanh_dong;
				v_us.Insert();
			}
			catch (Exception)
			{
				return false;
			}
			return true;
		}

		public decimal ban_hanh_van_ban(
			decimal ip_dc_id_van_ban
			, DateTime ip_dat_ngay_ban_hanh
			, string ip_str_email_ban_hanh)
		{
			try
			{
				US_GD_BAN_HANH_VAN_BAN v_us = new US_GD_BAN_HANH_VAN_BAN();
				v_us.dcID_VAN_BAN = ip_dc_id_van_ban;
				v_us.datNGAY_BAN_HANH = ip_dat_ngay_ban_hanh;
				v_us.strGHI_CHU = ip_str_email_ban_hanh;
				v_us.Insert();
				return v_us.dcID;
			}
			catch (Exception)
			{
				return -1;
			}
		}

		public bool nhan_van_ban(
			decimal ip_dc_id_gd_ban_hanh
			, DateTime ip_dat_ngay_nhan)
		{
			try
			{
				US_GD_BAN_HANH_VAN_BAN v_us = new US_GD_BAN_HANH_VAN_BAN(ip_dc_id_gd_ban_hanh);
				v_us.datNGAY_NHAN = ip_dat_ngay_nhan;
				v_us.Update();
			}
			catch (Exception)
			{
				return false;
			}
			return true;
		}



	}
}
