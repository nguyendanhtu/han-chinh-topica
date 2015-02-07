using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BCTKApp.App_Code;
using BCTKDS;
using BCTKDS.CDBNames;
using BCTKUS;
using IP.Core.IPCommon;
using System.Configuration;
using IP.Core.IPSystemAdmin;

namespace BCTKApp.CongVan
{
	public partial class f653_ban_hanh_van_ban : Form
	{
		public f653_ban_hanh_van_ban()
		{
			InitializeComponent();
			set_define_events();
		}

		#region Public Interfaces
		public void display(decimal ip_dc_id_van_ban)
		{
			m_dc_id_van_thu = ip_dc_id_van_ban;
			US_V_GD_VAN_THU_ALL v_us = new US_V_GD_VAN_THU_ALL(ip_dc_id_van_ban);
			US_CM_DM_TU_DIEN v_us_loai_van_ban = new US_CM_DM_TU_DIEN(v_us.dcID_LOAI_CONG_VAN);
			m_lbl_loai_van_ban.Text = v_us_loai_van_ban.strTEN;
			m_lbl_so_va_ky_hieu.Text = v_us.strSO_CV_DEN + " " + v_us.strSO_VA_KY_HIEU;
			m_lbl_ten_loai_va_trich_yeu_noi_dung.Text = v_us.strTEN_LOAI_VA_TRICH_YEU_ND;

			//Hien thi thong tin danh sach da ban hanh cua van ban nay
			US_GD_BAN_HANH_VAN_BAN v_us_ban_hanh = new US_GD_BAN_HANH_VAN_BAN();
			DS_GD_BAN_HANH_VAN_BAN v_ds_ban_hanh = new DS_GD_BAN_HANH_VAN_BAN();
			v_us_ban_hanh.FillDataset(v_ds_ban_hanh, "where " + GD_BAN_HANH_VAN_BAN.ID_VAN_BAN + " = " + ip_dc_id_van_ban);
			string v_str_danh_sach_email_da_ban_hanh = "";
			string v_str_danh_sach_email_da_xac_nhan = "";
			decimal v_dc_so_email_ban_hanh = 0;
			decimal v_dc_so_email_da_nhan_mail = 0;

			for (int i = 0; i < v_ds_ban_hanh.GD_BAN_HANH_VAN_BAN.Count; i++)
			{
				v_str_danh_sach_email_da_ban_hanh += v_ds_ban_hanh.Tables[0].Rows[i][GD_BAN_HANH_VAN_BAN.GHI_CHU];//GHi chu luu du lieu email
				v_dc_so_email_ban_hanh++;
				if (!v_ds_ban_hanh.Tables[0].Rows[i][GD_BAN_HANH_VAN_BAN.NGAY_NHAN].ToString().Equals(""))
				{
					v_str_danh_sach_email_da_xac_nhan += v_ds_ban_hanh.Tables[0].Rows[i][GD_BAN_HANH_VAN_BAN.GHI_CHU];
					v_dc_so_email_da_nhan_mail++;
				}
			}

			v_str_danh_sach_email_da_ban_hanh = v_dc_so_email_ban_hanh + " email";
			v_str_danh_sach_email_da_xac_nhan = v_dc_so_email_da_nhan_mail + " email";

			m_lbl_danh_sach_mail_da_ban_hanh.Text = v_str_danh_sach_email_da_ban_hanh;
			m_lbl_danh_sach_mail_da_xac_nhan.Text = v_str_danh_sach_email_da_xac_nhan;
			this.ShowDialog();
		}

		#endregion

		#region Members
		public decimal m_dc_id_van_thu = 0;
		#endregion

		#region Private Methods
		private void set_define_events()
		{
			m_cmd_save.Click += m_cmd_save_Click;
			m_cmd_exit.Click += m_cmd_exit_Click;
			m_cmd_xem_file.Click += m_cmd_xem_file_Click;

			m_cmd_xem_chi_tiet_ban_hanh.Click += m_cmd_xem_chi_tiet_ban_hanh_Click;
			m_cmd_xem_lich_su.Click += m_cmd_xem_lich_su_Click;
		}

		


		private void view_file_pdf()
		{
			if (m_dc_id_van_thu == 0) return;
			US_V_GD_VAN_THU_ALL v_us = new US_V_GD_VAN_THU_ALL(m_dc_id_van_thu);
			HelpUtils.openPDFFile(v_us.strLINK_SCAN);
		}

		private void format_control()
		{
			m_lbl_loai_van_ban.Text = "";
			m_lbl_so_va_ky_hieu.Text = "";
			m_lbl_ten_loai_va_trich_yeu_noi_dung.Text = "";
			m_lbl_danh_sach_mail_da_xac_nhan.Text = "";
			m_lbl_danh_sach_mail_da_ban_hanh.Text = "";
			m_txt_email.Text = "";
			m_txt_email.Focus();
		}

		private void ban_hanh_van_ban(
			string ip_str_danh_sach_email_ban_hanh
			, decimal ip_dc_id_van_thu)
		{
			US_GD_VAN_THU v_us = new US_GD_VAN_THU(ip_dc_id_van_thu);
			string[] v_arr_email = ip_str_danh_sach_email_ban_hanh.Split(';');
			string v_str_mess = "";
			try
			{
				for (int i = 0; i < v_arr_email.Length; i++)
				{
					if (!v_arr_email[i].Trim().Equals(""))
					{
						string v_str_send_to = v_arr_email[i];
						if (!v_str_send_to.Contains("@gmail.com")
							&& !v_str_send_to.Contains("@yahoo.com")
							&& !v_str_send_to.Contains("@topica.edu.vn")) v_str_send_to += "@topica.edu.vn";
						string v_str_web_url = get_html_contain(ConfigurationSettings.AppSettings["WEB_URL"] + "/ChucNang/f604_xac_nhan_cong_van.aspx?mail=" + v_str_send_to + "&id_cong_van=" + v_us.dcID, v_us.strTEN_LOAI_VA_TRICH_YEU_ND);
						if (!HelpUtils.SendEmailWithHtmlContent(v_str_send_to
							, "[QuanLyVanThu] Ban hanh van ban"
						, v_str_web_url
						, v_us.strLINK_SCAN))
						{
							MessageBox.Show("Đã có lỗi trong quá trình thực hiện, bạn vui lòng thực hiện lại thao tác!", "Thông báo");
							return;
						}
						//Ghi du lieu Ban hanh van ban
						VanThu v_van_thu = new VanThu();
						v_van_thu.ban_hanh_van_ban(v_us.dcID, DateTime.Now, v_str_send_to);
						//Ghi lich su Ban hanh van ban
						string v_str_van_ban_so = "";
						if (v_us.dcID_LOAI_CONG_VAN == ID_LOAI_VAN_THU.CONG_VAN_DEN)
						{
							v_str_van_ban_so = v_us.strSO_CV_DEN;
						}
						else v_str_van_ban_so = v_us.strSO_VA_KY_HIEU;
						v_van_thu.ghi_lich_su_hanh_dong(
							CAppContext_201.getCurrentUserID()
							, DateTime.Now
							, "Ban hành văn bản số: " + v_str_van_ban_so + " cho email: " + v_str_send_to);
					}
				}
				v_us.Update();
				MessageBox.Show("Đã gửi email ban hành văn bản thành công!", "Thông báo");
				this.Close();
			}
			catch (Exception v_e)
			{
				//CSystemLog_301.ExceptionHandle(v_e);
				MessageBox.Show("Đã có lỗi trong quá trình thực hiện, bạn vui lòng thực hiện lại thao tác!", "Thông báo");
				return;
			}
		}
		private string get_html_contain(string ip_str_url, string ip_str_ten_loai_va_trich_yeu_noi_dung)
		{
			return
				@"<html>
                     <head>
                     </head>
                    <body>
                        <p>Kính gửi các Thầy/Cô</p>
                        <p>TAD ban hành văn bản/tài liệu: " + ip_str_ten_loai_va_trich_yeu_noi_dung + @"</p>
                        <p>Chi tiết mời các Thầy/Cô xem file đính kèm bên dưới.</p>
                        <p>Xin click vào link dưới đây để xác nhận đã nhận email này, và Thầy Cô có thể tra cứu văn bản trong website</p>
                        <a href='" + ip_str_url + @"'>Xác nhận, tôi đã nhận được email này</a>
                        <p>Trân trọng!</p>
                    </body>
                </html>";
		}
		#endregion

		#region Events

		void m_cmd_exit_Click(object sender, EventArgs e)
		{
			try
			{
				this.Close();
			}
			catch (Exception v_e)
			{
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}
		

		void m_cmd_save_Click(object sender, EventArgs e)
		{

			if (m_txt_email.Text.Trim().Equals(""))
			{
				MessageBox.Show("Bạn phải nhập Danh sách email ban hành!", "Thông báo");
				m_txt_email.Focus();
				return;
			}
			this.ban_hanh_van_ban(m_txt_email.Text,m_dc_id_van_thu);
		}
		void m_cmd_xem_file_Click(object sender, EventArgs e)
		{
			try
			{
				view_file_pdf();
			}
			catch (Exception v_e)
			{

			}
		}
		void m_cmd_xem_lich_su_Click(object sender, EventArgs e)
		{
			try
			{
				F660_lich_su_van_thu v_frm = new F660_lich_su_van_thu();
				v_frm.display();
			}
			catch (Exception v_e)
			{
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		void m_cmd_xem_chi_tiet_ban_hanh_Click(object sender, EventArgs e)
		{
			try
			{
				F660_danh_sach_ban_hanh_van_ban v_frm = new F660_danh_sach_ban_hanh_van_ban();
				v_frm.display();
			}
			catch (Exception v_e)
			{
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}
		#endregion
	}
}
