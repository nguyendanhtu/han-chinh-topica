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
			m_lbl_danh_sach_mail_da_ban_hanh.Text = v_us.strDANH_SACH_EMAIL_BAN_HANH;
			m_lbl_danh_sach_mail_da_xac_nhan.Text = v_us.strDANH_SACH_EMAIL_XAC_NHAN;
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

		void m_cmd_save_Click(object sender, EventArgs e)
		{

			if (m_txt_email.Text.Trim().Equals(""))
			{
				MessageBox.Show("Bạn phải nhập Danh sách email ban hành!", "Thông báo");
				m_txt_email.Focus();
				return;
			}
			US_GD_VAN_THU v_us = new US_GD_VAN_THU(m_dc_id_van_thu);
			string[] v_arr_email = m_txt_email.Text.Split(';');
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
						string v_str_web_url = get_html_contain(ConfigurationSettings.AppSettings["WEB_URL"] + "/ChucNang/f604_xac_nhan_cong_van.aspx?mail="+v_str_send_to+"&id_cong_van=" + v_us.dcID, v_us.strTEN_LOAI_VA_TRICH_YEU_ND);
						HelpUtils.SendEmailWithHtmlContent(v_str_send_to, "[QuanLyVanThu] Ban hanh van ban"
						, v_str_web_url
						, v_us.strLINK_SCAN);
					}

					if (!v_us.strDANH_SACH_EMAIL_BAN_HANH.Contains(v_arr_email[i]) && !v_arr_email[i].Trim().Equals(""))
					{
						v_us.strDANH_SACH_EMAIL_BAN_HANH += ";" + v_arr_email[i];
					}
				}
				v_us.Update();
			}
			catch (Exception v_e)
			{
				//CSystemLog_301.ExceptionHandle(v_e);
				MessageBox.Show("Đã có lỗi trong quá trình thực hiện, bạn vui lòng thực hiện lại thao tác!", "Thông báo");
				return;
			}
			
			MessageBox.Show("Đã gửi email ban hành văn bản thành công!", "Thông báo");
			this.Close();

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
		#endregion
	}
}
