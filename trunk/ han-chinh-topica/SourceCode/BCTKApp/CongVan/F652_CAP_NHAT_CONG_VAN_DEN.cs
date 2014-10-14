using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BCTKDS;
using BCTKDS.CDBNames;
using BCTKUS;
using BCTKApp.App_Code;
using IP.Core.IPCommon;
using System.Configuration;

namespace BCTKApp.CongVan
{
    public partial class F652_CAP_NHAT_CONG_VAN_DEN : Form
    {
        public F652_CAP_NHAT_CONG_VAN_DEN()
        {
            InitializeComponent();
            load_form_data();
            set_define_events();
        }

        #region Public Interfaces
        public void display()
        {
            m_lbl_title.Text = "THÊM MỚI VĂN BẢN ĐẾN";
            load_data_trang_thai();
            this.ShowDialog();
        }
        public void display_for_update(decimal ip_dc_id_van_ban)
        {
            m_lbl_title.Text = "CẬP NHẬT VĂN BẢN ĐẾN";
            m_dc_id_van_thu = ip_dc_id_van_ban;
            us_object_to_form();
            load_data_trang_thai();
            this.ShowDialog();
        }
        #endregion

        #region Data Structures
        #endregion

        #region Members
        private decimal m_dc_id_van_thu = 0;
        #endregion

        #region Private Methods
        private void load_form_data()
        {
            load_data_trang_thai();
            load_data_nguoi_nhan_ban_luu();
            //m_tcd_ngay_nhap.Text = CIPConvert.ToStr(DateTime.Now, "dd/MM/yyyy");
            //m_tcd_ngay_tren_cv.Text = CIPConvert.ToStr(DateTime.Now, "dd/MM/yyyy");
            load_thong_tin_so_va_ky_hieu_van_ban();
            m_dc_id_van_thu = 0;
            m_txt_nguoi_nhap.Text = "SamPT";
            m_txt_so_cv_den.LoaiCongVan = "CV_DEN";
        }
        private bool check_data_is_ok()
        {
            bool v_b_result = true;
            if (!CValidateTextBox.IsValid(m_txt_so_cv_den, DataType.StringType, allowNull.NO, false))
            {
                MessageBox.Show("Bạn phải nhập Số công văn đến!");
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_noi_gui, DataType.StringType, allowNull.NO, false))
            {
                MessageBox.Show("Bạn phải nhập Nơi gửi!");
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_ten_loai, DataType.StringType, allowNull.NO, false))
            {
                MessageBox.Show("Bạn phải nhập Tên loại và trích yếu nội dung!");
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_nguoi_nhap, DataType.StringType, allowNull.NO, false))
            {
                MessageBox.Show("Bạn phải nhập Người nhập!");
                return false;
            }
            return v_b_result;
        }
        private void us_object_to_form()
        {
            if (m_dc_id_van_thu == 0) return;
            else
            {
                US_GD_VAN_THU v_us = new US_GD_VAN_THU(m_dc_id_van_thu);
                m_txt_file_upload.Text = v_us.strLINK_SCAN;
                m_txt_ghi_chu.Text = v_us.strGHI_CHU;
                m_txt_nguoi_nhap.Text = v_us.strNGUOI_LAP;
                m_txt_noi_gui.Text = v_us.strNOI_GUI;
                m_txt_so_va_ky_hieu.Text = v_us.strSO_VA_KY_HIEU;
                m_txt_so_cv_den.Text = v_us.strSO_CV_DEN;
                m_txt_ten_loai.Text = "";
            }
        }
        private void load_data_trang_thai()
        {
            try
            {
                US_CM_DM_TU_DIEN v_us_cm_dm_tu_dien = new US_CM_DM_TU_DIEN();
                DS_CM_DM_TU_DIEN v_ds_cm_dm_tu_dien = new DS_CM_DM_TU_DIEN();
                v_us_cm_dm_tu_dien.FillDataset(v_ds_cm_dm_tu_dien, "where ma_tu_dien in ('CHO_SO_VAO_SO_DONG_DAU','DA_LUU','DA_CHUYEN_DEN_NGUOI_NHAN','NGUOI_NHAN_DA_NHAN_DUOC') order by ten_ngan");

                m_cbx_trang_thai.DataSource = v_ds_cm_dm_tu_dien.CM_DM_TU_DIEN;
                m_cbx_trang_thai.DisplayMember = CM_DM_TU_DIEN.TEN;
                m_cbx_trang_thai.ValueMember = CM_DM_TU_DIEN.ID;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void load_thong_tin_so_va_ky_hieu_van_ban()
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            v_us.FillDataset(v_ds, "where ma_tu_dien='CV_DEN'");
            if (v_ds.CM_DM_TU_DIEN.Count > 0)
            {
                string v_str_so = v_ds.Tables[0].Rows[0][CM_DM_TU_DIEN.TEN_NGAN].ToString();
                string v_str_nam = v_ds.Tables[0].Rows[0][CM_DM_TU_DIEN.TEN].ToString();
                m_txt_so_cv_den.Text = v_str_so + "/" + v_str_nam;
            }
        }
        private void load_data_nguoi_nhan_ban_luu()
        {
            try
            {
                US_DM_PHONG_BAN v_us_dm_phong_ban = new US_DM_PHONG_BAN();
                DS_DM_PHONG_BAN v_ds_dm_phong_ban = new DS_DM_PHONG_BAN();
                v_us_dm_phong_ban.FillDataset(v_ds_dm_phong_ban, " order by ma_phong_ban");

                m_cbx_ban_luu.DataSource = v_ds_dm_phong_ban.DM_PHONG_BAN;
                m_cbx_ban_luu.DisplayMember = DM_PHONG_BAN.MA_PHONG_BAN;
                m_cbx_ban_luu.ValueMember = DM_PHONG_BAN.ID;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void clear_form_data()
        {
            load_form_data();
            m_txt_so_va_ky_hieu.Text = string.Empty;
            m_txt_ten_loai.Text = string.Empty;
            m_txt_ghi_chu.Text = string.Empty;
            m_txt_nguoi_nhap.Text = string.Empty;
            m_txt_file_upload.Text = string.Empty;
            m_txt_noi_gui.Text = string.Empty;
        }

        private bool insert_data()
        {
            try
            {
                string v_str_file_name = m_txt_file_upload.Text.Split('\\')[m_txt_file_upload.Text.Split('\\').Length - 1];
                string v_str_save_file = ConfigurationSettings.AppSettings["DOMAIN"] + "/" + "FileUpload_Vanthu" + "/" + v_str_file_name;
                if (!m_txt_file_upload.Text.Trim().Equals("") && !m_txt_file_upload.Text.Contains(ConfigurationSettings.AppSettings["DOMAIN"]))
                {
                    if (!HelpUtils.ftpTransfer(m_txt_file_upload.Text.Replace(v_str_file_name, ""), v_str_file_name)) return false;
                }

                US_GD_VAN_THU v_us_gd_van_thu = new US_GD_VAN_THU();
                if (m_dc_id_van_thu != 0) v_us_gd_van_thu = new US_GD_VAN_THU(m_dc_id_van_thu);

                if (m_tcd_ngay_tren_cv.getValue() == null) v_us_gd_van_thu.SetNGAY_THANG_TREN_CONG_VANNull();
                else
                    v_us_gd_van_thu.datNGAY_THANG_TREN_CONG_VAN = CIPConvert.ToDatetime(m_tcd_ngay_tren_cv.Text, "dd/MM/yyyy");

                if (m_tcd_ngay_nhap.getValue() == null) v_us_gd_van_thu.SetNGAY_LAPNull();
                else
                    v_us_gd_van_thu.datNGAY_LAP = CIPConvert.ToDatetime(m_tcd_ngay_nhap.Text, "dd/MM/yyyy");

                v_us_gd_van_thu.strSO_VA_KY_HIEU = m_txt_so_va_ky_hieu.Text.Trim();
                v_us_gd_van_thu.strTEN_LOAI_VA_TRICH_YEU_ND = m_txt_ten_loai.Text.Trim();

                US_DM_PHONG_BAN_PHAP_NHAN v_us_dm_phong_ban = new US_DM_PHONG_BAN_PHAP_NHAN();
                DS_DM_PHONG_BAN_PHAP_NHAN v_ds_dm_phong_ban = new DS_DM_PHONG_BAN_PHAP_NHAN();

                if (m_cbx_ban_luu.SelectedValue != null)
                {
                    v_us_dm_phong_ban.FillDataset(v_ds_dm_phong_ban,
                                                  " where id_phong_ban = " + m_cbx_ban_luu.SelectedValue);
                    v_us_gd_van_thu.dcID_NGUOI_NHAN_BAN_LUU = CIPConvert.ToDecimal(m_cbx_ban_luu.SelectedValue);
                    v_us_gd_van_thu.dcID_NOI_NGUOI_NHAN = CIPConvert.ToDecimal(m_cbx_ban_luu.SelectedValue);
                }
                else
                {
                    v_us_gd_van_thu.SetID_NGUOI_NHAN_BAN_LUUNull();
                    v_us_gd_van_thu.SetID_NOI_NGUOI_NHANNull();
                }

                if (v_ds_dm_phong_ban.Tables[0].Rows.Count > 0)
                    v_us_gd_van_thu.dcID_PHAP_NHAN = CIPConvert.ToDecimal(v_ds_dm_phong_ban.Tables[0].Rows[0][DM_PHONG_BAN_PHAP_NHAN.ID_PHAP_NHAN]);
                else v_us_gd_van_thu.SetID_PHAP_NHANNull();

                v_us_gd_van_thu.strGHI_CHU = m_txt_ghi_chu.Text.Trim();
                v_us_gd_van_thu.dcID_TRANG_THAI = CIPConvert.ToDecimal(m_cbx_trang_thai.SelectedValue);
                v_us_gd_van_thu.strNGUOI_LAP = m_txt_nguoi_nhap.Text.Trim();
                if (!m_txt_file_upload.Text.Trim().Equals(string.Empty))
                    v_us_gd_van_thu.strLINK_SCAN = v_str_save_file;
                else v_us_gd_van_thu.strLINK_SCAN = string.Empty;
                v_us_gd_van_thu.strSO_CV_DEN = m_txt_so_cv_den.Text.Trim();
                v_us_gd_van_thu.strNOI_GUI = m_txt_noi_gui.Text.Trim();
                v_us_gd_van_thu.dcID_LOAI_CONG_VAN = ID_LOAI_VAN_THU.CONG_VAN_DEN;
                v_us_gd_van_thu.strNOI_NHAN = m_cbx_ban_luu.Text.Trim();
                if (v_us_dm_phong_ban.dcID == -1)
                {
                    v_us_gd_van_thu.Insert();
                    US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
                    DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
                    v_us.FillDataset(v_ds, "where ma_tu_dien='CV_DEN'");
                    if (v_ds.CM_DM_TU_DIEN.Count > 0)
                    {
                        v_us.DataRow2Me(v_ds.Tables[0].Rows[0]);
                        string v_str_so = v_ds.Tables[0].Rows[0][CM_DM_TU_DIEN.TEN_NGAN].ToString();
                        string v_str_nam = v_ds.Tables[0].Rows[0][CM_DM_TU_DIEN.TEN].ToString();
                        v_str_so = CIPConvert.ToStr(CIPConvert.ToDecimal(v_str_so) + 1, "0#");
                        m_txt_so_cv_den.Text = v_str_so + "/" + v_str_nam;
                        v_us.strTEN = v_str_nam;
                        v_us.strTEN_NGAN = v_str_so;
                        v_us.Update();
                    }
                }
                else
                {
                    v_us_dm_phong_ban.Update();
                }
                return true;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
                return false;
            }
        }

        private void set_define_events()
        {
            m_cmd_exit.Click += m_cmd_exit_Click;
            m_cmd_save.Click += m_cmd_save_Click;
        }


        #endregion

        #region Events
        private void m_btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog v_ofd_file_upload = new OpenFileDialog();
            v_ofd_file_upload.Filter = CongVanConstant.F651_FILE_UPLOAD_FILTER;
            v_ofd_file_upload.Title = "Lựa chọn file công văn đã scan";
            v_ofd_file_upload.Multiselect = false;
            if (v_ofd_file_upload.ShowDialog() == DialogResult.OK)
            {
                m_txt_file_upload.Text = v_ofd_file_upload.FileName;
            }
        }
        private void m_btn_luu_Click(object sender, EventArgs e)
        {

        }
        private void m_btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (!check_data_is_ok()) return;
                if (insert_data())
                {
                    MessageBox.Show("Đã cập nhật công văn thành công", "Thông báo");
                    clear_form_data();
                }
                else
                {
                    MessageBox.Show("Đã xảy lỗi trong quá trình xử lý!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_exit_Click(object sender, EventArgs e)
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
        #endregion
    }
}
