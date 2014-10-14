﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BCTKDS;
using BCTKUS;
using BCTKDS.CDBNames;
using BCTKApp.App_Code;
using IP.Core.IPCommon;
using System.Configuration;

namespace BCTKApp.CongVan
{
    public partial class F651_CAP_NHAT_CONG_VAN_DI : Form
    {
        public F651_CAP_NHAT_CONG_VAN_DI()
        {
            InitializeComponent();
            clear_form_data();
            set_define_events();
        }

        #region Public Intefaces
        public void display(eFormMode ip_e_form_mode)
        {
            m_e_form_mode = ip_e_form_mode;
            switch (m_e_form_mode)
            {
                case eFormMode.DI_KHONG_LUU:
                    m_lbl_title.Text = "CẬP NHẬT VĂN BẢN ĐI - KHÔNG LƯU";
                    break;

                case eFormMode.DI_LUU:
                    m_lbl_title.Text = "CẬP NHẬT VĂN BẢN ĐI - LƯU";
                    break;
            }
            load_data_trang_thai();
            this.ShowDialog();
        }
        public void display_for_insert()
        {
            m_dc_id_cong_van = 0;
            this.ShowDialog();
        }

        public void display_for_update(decimal ip_dc_id_cong_van, eFormMode ip_e_form_mode)
        {
            m_dc_id_cong_van = ip_dc_id_cong_van;
            m_e_form_mode = ip_e_form_mode;
            switch (m_e_form_mode)
            {
                case eFormMode.DI_KHONG_LUU:
                    m_lbl_title.Text = "CẬP NHẬT VĂN BẢN ĐI - KHÔNG LƯU";
                    break;

                case eFormMode.DI_LUU:
                    m_lbl_title.Text = "CẬP NHẬT VĂN BẢN ĐI - LƯU";
                    break;
            }
            load_data_trang_thai();
            us_object_to_form(m_dc_id_cong_van);
            this.ShowDialog();
        }
        #endregion

        #region Data Structures
        public enum eFormMode
        {
            DI_KHONG_LUU = 0,
            DI_LUU = 1
        }
        #endregion

        #region Members
        Decimal m_dc_id_cong_van=0;
        private eFormMode m_e_form_mode = eFormMode.DI_KHONG_LUU;
        #endregion

        #region Private methods
        private void xoa_trang()
        {
            m_txt_ghi_chu.Text = "";
            m_txt_file_upload.Text = "";
            m_txt_nguoi_ky.Text = "";
            m_txt_nguoi_nhap.Text = "";
            m_txt_so.Text = "";
            m_cbx_ky_hieu.Text = "";
            m_cbx_phap_nhan.SelectedIndex=0;
            m_cbx_trang_thai.SelectedIndex=0;
        }

        private void us_object_to_form(decimal ip_dc_id_cong_van)
        {
            if (ip_dc_id_cong_van == 0)
            {
                xoa_trang();
                return;
            }
            US_GD_VAN_THU v_us = new US_GD_VAN_THU(ip_dc_id_cong_van);
            string[] v_arr_i = v_us.strSO_VA_KY_HIEU.Split('/');
            m_txt_ghi_chu.Text = v_us.strGHI_CHU;
            m_txt_noi_nhan.Text = v_us.strNOI_NHAN;
            m_txt_file_upload.Text = v_us.strLINK_SCAN;
            m_txt_nguoi_ky.Text = v_us.strNGUOI_KY;
            m_txt_nguoi_nhap.Text = v_us.strNGUOI_LAP;
            m_txt_so.Text = v_arr_i[0] + "/" + v_arr_i[1];
            m_cbx_ky_hieu.Text = v_us.strSO_VA_KY_HIEU.Replace(m_txt_so.Text,"");
            m_cbx_phap_nhan.SelectedValue = v_us.dcID_PHAP_NHAN.ToString();
            m_cbx_trang_thai.SelectedValue = v_us.dcID_TRANG_THAI.ToString();
            m_tcd_ngay_nhap.Text = CIPConvert.ToStr(v_us.datNGAY_LAP, "dd/MM/yyyy");
            m_txt_ten_loai.Text = v_us.strTEN_LOAI_VA_TRICH_YEU_ND;
        }

        private void form_to_us_object(US_GD_VAN_THU op_us)
        {
            op_us.dcID = m_dc_id_cong_van;
            op_us.dcID_LOAI_CONG_VAN = ID_LOAI_VAN_THU.CONG_VAN_DEN;
            op_us.dcID_PHAP_NHAN=CIPConvert.ToDecimal(m_cbx_phap_nhan.SelectedValue);
            op_us.dcID_TRANG_THAI = CIPConvert.ToDecimal(m_cbx_trang_thai.SelectedValue);
            op_us.dcID_NOI_NGUOI_NHAN = CIPConvert.ToDecimal(m_cbx_ban_luu.SelectedValue);
            op_us.strGHI_CHU = m_txt_ghi_chu.Text;
            op_us.strLINK_SCAN = m_txt_file_upload.Text;
            op_us.strNGUOI_KY = m_txt_nguoi_ky.Text;
            op_us.strNGUOI_LAP = m_txt_nguoi_nhap.Text;
            op_us.strNOI_NHAN = m_txt_noi_nhan.Text;
            op_us.datNGAY_LAP = CIPConvert.ToDatetime(m_tcd_ngay_nhap.Text, "dd/MM/yyyy");
        }

        private bool check_data_is_ok()
        {
            bool v_b_result = true;
            if (!CValidateTextBox.IsValid(m_txt_so, DataType.StringType, allowNull.NO,false))
            {
                MessageBox.Show("Bạn phải nhập Số văn bản!");
                return false;
            }
            if (m_cbx_ky_hieu.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn phải nhập Ký hiệu văn bản!");
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_nguoi_ky, DataType.StringType, allowNull.NO, false))
            {
                MessageBox.Show("Bạn phải nhập Người ký!");
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_ten_loai, DataType.StringType, allowNull.NO, false))
            {
                MessageBox.Show("Bạn phải nhập Tên loại và trích yếu nội dung!");
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_noi_nhan, DataType.StringType, allowNull.NO, false))
            {
                MessageBox.Show("Bạn phải nhập Nơi nhận!");
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_nguoi_nhap, DataType.StringType, allowNull.NO,false))
            {
                MessageBox.Show("Bạn phải nhập Người nhập!");
                return false;
            }
            return v_b_result;
        }

        private void load_form_data()
        {
            load_data_phap_nhan();
            load_data_trang_thai();
            load_data_ky_hieu();

            load_data_nguoi_nhan_ban_luu();
            load_thong_tin_so_va_ky_hieu_van_ban();
            m_dc_id_cong_van = 0; ;
        }

        private void load_data_phap_nhan()
        {
            try
            {
                US_DM_PHAP_NHAN v_us_dm_phap_nhan = new US_DM_PHAP_NHAN();
                DS_DM_PHAP_NHAN v_ds_dm_phap_nhan = new DS_DM_PHAP_NHAN();
                v_us_dm_phap_nhan.FillDataset(v_ds_dm_phap_nhan," order by ma_phap_nhan");

                m_cbx_phap_nhan.DataSource = v_ds_dm_phap_nhan.DM_PHAP_NHAN;
                m_cbx_phap_nhan.DisplayMember = DM_PHAP_NHAN.MA_PHAP_NHAN;
                m_cbx_phap_nhan.ValueMember = DM_PHAP_NHAN.ID;
                m_cbx_phap_nhan.SelectedValue = "5";
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void load_data_ky_hieu()
        {
            m_cbx_ky_hieu.DataSource = CongVanUtil.get_list_ky_hieu_cong_van();
        }

        private void load_data_trang_thai()
        {
            try
            {
                US_CM_DM_TU_DIEN v_us_cm_dm_tu_dien = new US_CM_DM_TU_DIEN();
                DS_CM_DM_TU_DIEN v_ds_cm_dm_tu_dien = new DS_CM_DM_TU_DIEN();
                if (m_e_form_mode == eFormMode.DI_KHONG_LUU)
                    v_us_cm_dm_tu_dien.FillDataset(v_ds_cm_dm_tu_dien, "where ma_tu_dien in ('CHO_SO_VAO_SO_DONG_DAU','DA_CHUYEN_CHO_DON_VI_BAN_HANH') order by ten_ngan");
                else v_us_cm_dm_tu_dien.FillDataset(v_ds_cm_dm_tu_dien, "where ma_tu_dien in ('CHO_SO_VAO_SO_DONG_DAU','DA_LUU_TAI_TAD','DA_CHUYEN_DEN_NGUOI_NHAN','NGUOI_NHAN_DA_NHAN_DUOC') order by ten_ngan");

                m_cbx_trang_thai.DataSource = v_ds_cm_dm_tu_dien.CM_DM_TU_DIEN;
                m_cbx_trang_thai.DisplayMember = CM_DM_TU_DIEN.TEN;
                m_cbx_trang_thai.ValueMember = CM_DM_TU_DIEN.ID;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void set_define_events()
        {
            m_cmd_exit.Click += m_cmd_exit_Click;
            m_cmd_save.Click += m_cmd_save_Click;
            m_cbx_phap_nhan.SelectedIndexChanged += m_cbx_phap_nhan_SelectedIndexChanged;
        }

        private void load_data_nguoi_nhan_ban_luu()
        {
            try
            {
                US_V_DM_PHONG_BAN_PHAP_NHAN v_us_dm_phong_ban = new US_V_DM_PHONG_BAN_PHAP_NHAN();
                DS_V_DM_PHONG_BAN_PHAP_NHAN v_ds_dm_phong_ban = new DS_V_DM_PHONG_BAN_PHAP_NHAN();
                m_cbx_ban_luu.DisplayMember = V_DM_PHONG_BAN_PHAP_NHAN.MA_PHONG_BAN;
                m_cbx_ban_luu.ValueMember = V_DM_PHONG_BAN_PHAP_NHAN.ID_PHONG_BAN;

                US_DM_PHAP_NHAN v_us_dm_phap_nhan = new US_DM_PHAP_NHAN(CIPConvert.ToDecimal(m_cbx_phap_nhan.SelectedValue));
                if (v_us_dm_phap_nhan.strMA_PHAP_NHAN == "TPE" )
                {
                    v_us_dm_phong_ban.FillDataset(v_ds_dm_phong_ban, "where id_phap_nhan="+m_cbx_phap_nhan.SelectedValue+" order by ma_phong_ban");//5 la id EDT
                    m_cbx_ban_luu.DataSource = v_ds_dm_phong_ban.v_DM_PHONG_BAN_PHAP_NHAN;
                }
                else
                {
                    v_us_dm_phong_ban.FillDataset(v_ds_dm_phong_ban, "where id_phap_nhan=5 order by ma_phong_ban");//5 la id EDT
                    m_cbx_ban_luu.DataSource = v_ds_dm_phong_ban.v_DM_PHONG_BAN_PHAP_NHAN;
                }
                
                
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private bool save_data()
        {
            try
            {
                string v_str_file_name = m_txt_file_upload.Text.Split('\\')[m_txt_file_upload.Text.Split('\\').Length - 1];
                string v_str_save_file = ConfigurationSettings.AppSettings["DOMAIN"] + "/" + "FileUpload_Vanthu" + "/" + v_str_file_name;
                if (!m_txt_file_upload.Text.Trim().Equals("") && !m_txt_file_upload.Text.Contains(ConfigurationSettings.AppSettings["DOMAIN"]))
                {
                    if (!HelpUtils.ftpTransfer(m_txt_file_upload.Text.Replace(v_str_file_name, ""), v_str_file_name)) return false;
                }
                
                //HelpUtils.open_pdf_file(v_str_file_name, "..//Debug/FileScan");
                US_GD_VAN_THU v_us_gd_van_thu = new US_GD_VAN_THU();
                v_us_gd_van_thu.dcID = m_dc_id_cong_van;
                v_us_gd_van_thu.dcID_PHAP_NHAN = CIPConvert.ToDecimal(m_cbx_phap_nhan.SelectedValue);
                v_us_gd_van_thu.datNGAY_LAP = CIPConvert.ToDatetime(m_tcd_ngay_nhap.Text,"dd/MM/yyyy");
                v_us_gd_van_thu.strSO_VA_KY_HIEU =
                    new StringBuilder(m_txt_so.Text.Trim()).Append(m_cbx_ky_hieu.Text.Trim()).ToString();
                v_us_gd_van_thu.strNGUOI_KY = m_txt_nguoi_ky.Text;
                v_us_gd_van_thu.strTEN_LOAI_VA_TRICH_YEU_ND = m_txt_ten_loai.Text.Trim();
                v_us_gd_van_thu.strNOI_NHAN = m_txt_noi_nhan.Text.Trim();
                v_us_gd_van_thu.dcID_NGUOI_NHAN_BAN_LUU = CIPConvert.ToDecimal(m_cbx_ban_luu.SelectedValue);
                if (m_cbx_ban_luu.SelectedValue==null)
                {
                    MessageBox.Show("Bạn phải chọn Người nhận bản lưu", "Cảnh báo");
                    return false;
                }
                v_us_gd_van_thu.dcID_NOI_NGUOI_NHAN = CIPConvert.ToDecimal(m_cbx_ban_luu.SelectedValue);
                v_us_gd_van_thu.strGHI_CHU = m_txt_ghi_chu.Text.Trim();
                v_us_gd_van_thu.dcID_TRANG_THAI = CIPConvert.ToDecimal(m_cbx_trang_thai.SelectedValue);
                v_us_gd_van_thu.strNGUOI_LAP = m_txt_nguoi_nhap.Text.Trim();
                if (!m_txt_file_upload.Text.Trim().Equals(""))
                    v_us_gd_van_thu.strLINK_SCAN = v_str_save_file;
                else v_us_gd_van_thu.strLINK_SCAN = "";
                v_us_gd_van_thu.dcID_LOAI_CONG_VAN = ID_LOAI_VAN_THU.CONG_VAN_DI; ;
                v_us_gd_van_thu.dcID_PHAP_NHAN = CIPConvert.ToDecimal(m_cbx_phap_nhan.SelectedValue);

                if (m_dc_id_cong_van == 0)
                {
                    v_us_gd_van_thu.Insert();
                    US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
                    DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
                    v_us.FillDataset(v_ds, "where ma_tu_dien='" + m_cbx_phap_nhan.Text+"'");
                    if (v_ds.CM_DM_TU_DIEN.Count > 0)
                    {
                        string v_str_so = v_ds.Tables[0].Rows[0][CM_DM_TU_DIEN.TEN_NGAN].ToString();
                        string v_str_nam = v_ds.Tables[0].Rows[0][CM_DM_TU_DIEN.TEN].ToString();
                        v_str_so = CIPConvert.ToStr((CIPConvert.ToDecimal(v_str_so) + 1), "0#");
                        v_us.DataRow2Me(v_ds.Tables[0].Rows[0]);
                        v_us.strTEN = v_str_nam;
                        v_us.strTEN_NGAN = v_str_so;
                        v_us.Update();
                    }
                }
                else v_us_gd_van_thu.Update();
                return true;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
                return false;
            }
        }
        private void load_thong_tin_so_va_ky_hieu_van_ban()
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            v_us.FillDataset(v_ds, "where ma_tu_dien='" + m_cbx_phap_nhan.Text + "'");
            if (v_ds.CM_DM_TU_DIEN.Count > 0)
            {
                string v_str_so = v_ds.Tables[0].Rows[0][CM_DM_TU_DIEN.TEN_NGAN].ToString();
                string v_str_nam = v_ds.Tables[0].Rows[0][CM_DM_TU_DIEN.TEN].ToString();
                m_txt_so.Text = v_str_so + "/" + v_str_nam;
            }
        }
        private void clear_form_data()
        {
            m_txt_so.Text = string.Empty;
            load_form_data();
            m_dc_id_cong_van = 0;

            m_txt_nguoi_ky.Text = string.Empty;
            m_txt_ten_loai.Text = string.Empty;
            m_txt_noi_nhan.Text = string.Empty;
            m_txt_ghi_chu.Text = string.Empty;
            m_txt_nguoi_nhap.Text = string.Empty;
            m_txt_file_upload.Text = string.Empty;
            m_tcd_ngay_nhap.Text = CIPConvert.ToStr(DateTime.Now, "dd/MM/yyyy");
        }
        #endregion 

        #region Events handler
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

        private void m_btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                US_GD_VAN_THU v_us = new US_GD_VAN_THU();
                if (!check_data_is_ok()) return;
                if (save_data())
                {
                    MessageBox.Show("Đã cập nhật văn bản thành công", "Thông báo");
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
        void m_cbx_phap_nhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            //for (int i = 0; i < m_cbx_ky_hieu.Items.Count; i++)
            //{
            //    string[] v_arr_temp = m_cbx_ky_hieu.Items[i].ToString().Split('-');
            //    v_arr_temp[v_arr_temp.Length - 1] = m_cbx_phap_nhan.Text;
            //    string v_arr_result = "";
            //    for (int j = 0; j < v_arr_temp.Length; j++)
            //    {
            //        v_arr_result += v_arr_temp[j];
            //    }
            //    m_cbx_ky_hieu.Items[i] = v_arr_result;
            //}
            load_thong_tin_so_va_ky_hieu_van_ban();

            load_data_nguoi_nhan_ban_luu();
        }
        
        #endregion
    }
}