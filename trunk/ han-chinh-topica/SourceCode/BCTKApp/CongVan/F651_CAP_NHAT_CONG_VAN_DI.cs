using System;
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

namespace BCTKApp.CongVan
{
    public partial class F651_CAP_NHAT_CONG_VAN_DI : Form
    {
        public F651_CAP_NHAT_CONG_VAN_DI()
        {
            InitializeComponent();
            load_form_data();
        }

        #region Private methods
        private void load_form_data()
        {
            load_data_phap_nhan();
            load_data_trang_thai();
            load_data_ky_hieu();
            load_data_nguoi_ky();
            load_data_nguoi_nhan_ban_luu();
        }

        private void load_data_phap_nhan()
        {
            try
            {
                US_DM_PHAP_NHAN v_us_dm_phap_nhan = new US_DM_PHAP_NHAN();
                DS_DM_PHAP_NHAN v_ds_dm_phap_nhan = new DS_DM_PHAP_NHAN();
                v_us_dm_phap_nhan.FillDataset(v_ds_dm_phap_nhan);

                m_cbx_phap_nhan.DataSource = v_ds_dm_phap_nhan.DM_PHAP_NHAN;
                m_cbx_phap_nhan.DisplayMember = DM_PHAP_NHAN.TEN_PHAP_NHAN;
                m_cbx_phap_nhan.ValueMember = DM_PHAP_NHAN.ID;
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
                v_us_cm_dm_tu_dien.FillDatasetByLoaiTuDienLoaiCongVan(v_ds_cm_dm_tu_dien);

                m_cbx_trang_thai.DataSource = v_ds_cm_dm_tu_dien.CM_DM_TU_DIEN;
                m_cbx_trang_thai.DisplayMember = CM_DM_TU_DIEN.TEN;
                m_cbx_trang_thai.ValueMember = CM_DM_TU_DIEN.ID;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void load_data_nguoi_ky()
        {
            try
            {
                IP.Core.IPUserService.US_HT_NGUOI_SU_DUNG v_us_ht_nguoi_sd = new IP.Core.IPUserService.US_HT_NGUOI_SU_DUNG();
                IP.Core.IPData.DS_HT_NGUOI_SU_DUNG v_ds_ht_nguoi_sd = new IP.Core.IPData.DS_HT_NGUOI_SU_DUNG();
                v_us_ht_nguoi_sd.FillDataset(v_ds_ht_nguoi_sd);

                m_cbx_nguoi_ky.DataSource = v_ds_ht_nguoi_sd.HT_NGUOI_SU_DUNG;
                m_cbx_nguoi_ky.DisplayMember = HT_NGUOI_SU_DUNG.TEN;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void load_data_nguoi_nhan_ban_luu()
        {
            try
            {
                US_DM_PHONG_BAN v_us_dm_phong_ban = new US_DM_PHONG_BAN();
                DS_DM_PHONG_BAN v_ds_dm_phong_ban = new DS_DM_PHONG_BAN();
                v_us_dm_phong_ban.FillDataset(v_ds_dm_phong_ban);

                m_cbx_ban_luu.DataSource = v_ds_dm_phong_ban.DM_PHONG_BAN;
                m_cbx_ban_luu.DisplayMember = DM_PHONG_BAN.MA_PHONG_BAN;
                m_cbx_ban_luu.ValueMember = DM_PHONG_BAN.ID;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private bool insert_data()
        {
            try
            {
                US_GD_VAN_THU v_us_gd_van_thu = new US_GD_VAN_THU();
                v_us_gd_van_thu.dcID_PHAP_NHAN = CIPConvert.ToDecimal(m_cbx_phap_nhan.SelectedValue);
                v_us_gd_van_thu.datNGAY_LAP = CIPConvert.ToDatetime(m_tcd_ngay_nhap.Text);
                v_us_gd_van_thu.strSO_VA_KY_HIEU =
                    new StringBuilder(m_txt_so.Text.Trim()).Append(m_cbx_ky_hieu.Text.Trim()).ToString();
                v_us_gd_van_thu.strNGUOI_KY = m_cbx_nguoi_ky.Text;
                v_us_gd_van_thu.strTEN_LOAI_VA_TRICH_YEU_ND = m_txt_ten_loai.Text.Trim();
                v_us_gd_van_thu.strNOI_NHAN = m_txt_noi_nhan.Text.Trim();
                v_us_gd_van_thu.dcID_NGUOI_NHAN_BAN_LUU = CIPConvert.ToDecimal(m_cbx_ban_luu.SelectedValue);
                v_us_gd_van_thu.dcID_NOI_NGUOI_NHAN = CIPConvert.ToDecimal(m_cbx_ban_luu.SelectedValue);
                v_us_gd_van_thu.strGHI_CHU = m_txt_ghi_chu.Text.Trim();
                v_us_gd_van_thu.dcID_TRANG_THAI = CIPConvert.ToDecimal(m_cbx_trang_thai.SelectedValue);
                v_us_gd_van_thu.strNGUOI_LAP = m_txt_nguoi_nhap.Text.Trim();
                v_us_gd_van_thu.strLINK_SCAN = m_txt_file_upload.Text.Trim();
                v_us_gd_van_thu.dcID_LOAI_CONG_VAN = CONST_ID_LOAI_CONG_VAN.CONG_VAN_DI;

                v_us_gd_van_thu.Insert();
                return true;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
                return false;
            }
        }

        private void clear_form_data()
        {
            load_form_data();
            m_txt_so.Text = string.Empty;
            m_txt_ten_loai.Text = string.Empty;
            m_txt_noi_nhan.Text = string.Empty;
            m_txt_ghi_chu.Text = string.Empty;
            m_txt_nguoi_nhap.Text = string.Empty;
            m_txt_file_upload.Text = string.Empty;
        }
        #endregion

        #region Public methods
        #endregion

        #region Events handler
        private void m_btn_luu_Click(object sender, EventArgs e)
        {
            if(insert_data())
            {
                MessageBox.Show("Đã thêm mới công văn thành công", "[FCCC651001] Thông báo");
                clear_form_data();
            }
            else
            {
                MessageBox.Show("Đã xảy lỗi trong quá trình xử lý!", "[FCCE651002] Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void m_btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog v_ofd_file_upload = new OpenFileDialog();
            v_ofd_file_upload.Filter = CongVanConstant.F651_FILE_UPLOAD_FILTER;
            v_ofd_file_upload.Title = "Lựa chọn file công văn đã scan";
            v_ofd_file_upload.Multiselect = false;
            if(v_ofd_file_upload.ShowDialog() == DialogResult.OK)
            {
                m_txt_file_upload.Text = v_ofd_file_upload.FileName;
            }
        }

        private void m_btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
