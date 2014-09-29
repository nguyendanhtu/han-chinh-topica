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
            m_lbl_loai_van_ban.Text = v_us.strLOAI_CONG_BAN_ML;
            m_lbl_so_va_ky_hieu.Text = v_us.strSO_CV_DEN + " " + v_us.strSO_VA_KY_HIEU;
            m_lbl_ten_loai_va_trich_yeu_noi_dung.Text = v_us.strTEN_LOAI_VA_TRICH_YEU_ND;
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
        }


        private void format_control()
        {
            m_lbl_loai_van_ban.Text = "";
            m_lbl_so_va_ky_hieu.Text = "";
            m_lbl_ten_loai_va_trich_yeu_noi_dung.Text = "";
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
                        <p>Gửi các Thầy, Cô</p>
                        <p>Xin gửi Thầy, Cô văn bản: "+ip_str_ten_loai_va_trich_yeu_noi_dung+@"</p>
                        <p>Xin click vào link dưới đây để xác nhận đã nhận email này, và Thầy Cô có thể tra cứu văn bản trong website</p>
                        <a href='" + ip_str_url + @"'>Xác nhận, tôi đã nhận được email này</a>
                    </body>
                </html>";
        }

        void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_txt_email.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Bạn phải nhập Danh sách email ban hành!", "Thông báo");
                    m_txt_email.Focus();
                    return;
                }
                US_GD_VAN_THU v_us = new US_GD_VAN_THU(m_dc_id_van_thu);
                string[] v_arr_email = m_txt_email.Text.Split(';');
                string v_str_mess="";
                for (int i = 0; i < v_arr_email.Length; i++)
                {
                    HelpUtils.SendEmailWithHtmlContent("dmt.20102514@gmail.com","[QuanLyVanThu] Ban hanh van ban"
                        ,get_html_contain(ConfigurationSettings.AppSettings["WEB_URL"]+ "/ChucNang/f604_xac_nhan_cong_van.aspx?mail=dmt.20102514&id_cong_van="+v_us.dcID,v_us.strTEN_LOAI_VA_TRICH_YEU_ND));
                    if (!v_us.strDANH_SACH_EMAIL_BAN_HANH.Contains(v_arr_email[i]))
                    {
                        v_us.strDANH_SACH_EMAIL_BAN_HANH += ";" + v_arr_email[i];
                    }
                }
                v_us.Update();
                MessageBox.Show("Đã gửi email ban hành văn bản thành công!", "Thông báo");
                this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        #endregion
    }
}
