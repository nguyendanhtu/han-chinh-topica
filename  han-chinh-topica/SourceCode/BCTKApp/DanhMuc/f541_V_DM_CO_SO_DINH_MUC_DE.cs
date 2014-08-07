using BCTKDS;
using BCTKUS;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BCTKDS.CDBNames;

namespace BCTKApp.DanhMuc
{
    public partial class f541_V_DM_CO_SO_DINH_MUC_DE : Form
    {
        public f541_V_DM_CO_SO_DINH_MUC_DE()
        {
            InitializeComponent();
            format_control();
            load_data_2_cbo();
        }
        #region Public Interfaces
        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }
        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        US_DM_CO_SO_DINH_MUC m_us_dm_co_so_dinh_muc = new US_DM_CO_SO_DINH_MUC();
        #endregion

        #region Private Methods
        private void format_control()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            set_define_events();
        }
        private void load_data_2_cbo()
        {
            DS_CM_DM_TU_DIEN v_ds_cm_dm_tu_dien = new DS_CM_DM_TU_DIEN();
            US_CM_DM_TU_DIEN v_us_cm_dm_tu_dien = new US_CM_DM_TU_DIEN();
            v_us_cm_dm_tu_dien.FillDataset(v_ds_cm_dm_tu_dien, "where id_loai_tu_dien = "+ CONST_ID_CM_DM_LOAI_TD.ID_LOAI_DINH_MUC);

            m_cbo_loai_dinh_muc.DataSource = v_ds_cm_dm_tu_dien.CM_DM_TU_DIEN;
            m_cbo_loai_dinh_muc.DisplayMember = CM_DM_TU_DIEN.TEN_NGAN;
            m_cbo_loai_dinh_muc.ValueMember = CM_DM_TU_DIEN.ID;
        }
        private bool validate_ma_update(string ip_str_ma, decimal ip_dc_id)
        {
            US_DM_CO_SO_DINH_MUC v_us = new US_DM_CO_SO_DINH_MUC();
            DS_DM_CO_SO_DINH_MUC v_ds = new DS_DM_CO_SO_DINH_MUC();
            v_us.FillDataset(v_ds, "where ma_co_so_dinh_muc='" + ip_str_ma + "' or id=" + ip_dc_id);
            if (v_ds.DM_CO_SO_DINH_MUC.Count != 1) return false;
            return true;
        }
        private void save_data()
        {
            if (!validate_data_is_ok())
                return;
            if (!validate_ma_insert(m_txt_ma_co_so.Text.Trim()))
            {
                BaseMessages.MsgBox_Infor("Mã cơ sở đã tồn tại");
                xoa_trang();
                return;
            }
            form_2_us_obj();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_dm_co_so_dinh_muc.Insert();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    if (!validate_ma_update(m_txt_ma_co_so.Text.Trim(), m_us_dm_co_so_dinh_muc.dcID))
                    {
                        BaseMessages.MsgBox_Infor("Mã cơ sở đã tồn tại");
                        m_txt_ma_co_so.Focus();
                        return;
                    }
                    m_us_dm_co_so_dinh_muc.Update();
                    break;
            }
            BaseMessages.MsgBox_Infor("Đã lưu thành công!");
            if (m_chk_close_form.Checked == true)
            {
                xoa_trang();
            }
            else
            {
                this.Close();
            }
        }

        private bool validate_ma_insert(string ip_str_ma)
        {
            US_DM_CO_SO_DINH_MUC v_us = new US_DM_CO_SO_DINH_MUC();
            DS_DM_CO_SO_DINH_MUC v_ds = new DS_DM_CO_SO_DINH_MUC();
            v_us.FillDataset(v_ds, "where ma_co_so_dinh_muc='" + ip_str_ma + "'");
            if (v_ds.DM_CO_SO_DINH_MUC.Count != 0 && m_e_form_mode == DataEntryFormMode.InsertDataState) return false;
            return true;
        }

        private void form_2_us_obj()
        {
            string v_ap_dung_tu_ngay = "";
            m_us_dm_co_so_dinh_muc.strMA_CO_SO_DINH_MUC = m_txt_ma_co_so.Text;
            m_us_dm_co_so_dinh_muc.strTEN_CO_SO_DINH_MUC = m_txt_ten_co_so.Text;
            m_us_dm_co_so_dinh_muc.dcID_LOAI_DINH_MUC = CIPConvert.ToDecimal(m_cbo_loai_dinh_muc.SelectedValue);
            m_us_dm_co_so_dinh_muc.dcDON_GIA_DINH_MUC = CIPConvert.ToDecimal(m_txt_don_gia_dinh_muc.Text.Replace(",", "").Replace(".", ""));
            v_ap_dung_tu_ngay = m_dat_ap_dung_tu_ngay.Value.ToString();
            v_ap_dung_tu_ngay = v_ap_dung_tu_ngay.Substring(0, v_ap_dung_tu_ngay.IndexOf(" "));
            m_us_dm_co_so_dinh_muc.datAP_DUNG_TU_NGAY = CIPConvert.ToDatetime(v_ap_dung_tu_ngay);
        }
        private void xoa_trang()
        {
            m_txt_ma_co_so.Clear();
            m_txt_ten_co_so.Clear();
            m_cbo_loai_dinh_muc.SelectedIndex = 1;
            m_txt_don_gia_dinh_muc.Clear();
            m_dat_ap_dung_tu_ngay.Value = DateTime.Now.Date;
            m_e_form_mode = DataEntryFormMode.InsertDataState;
        }

        private bool validate_data_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_ma_co_so, DataType.StringType, allowNull.NO, true))
            {
                BaseMessages.MsgBox_Error("Bạn chưa nhập Mã cơ sở rồi!");
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_ten_co_so, DataType.StringType, allowNull.NO, true))
            {
                BaseMessages.MsgBox_Error("Bạn chưa nhập Tên cơ sở rồi!");
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_don_gia_dinh_muc, DataType.StringType, allowNull.NO, true))
            {
                BaseMessages.MsgBox_Error("Bạn chưa nhập Đơn giá định mức rồi!");
                return false;
            }
            return true;
        }

        public void display_for_update(US_V_DM_CO_SO_DINH_MUC ip_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_dm_co_so_dinh_muc.dcID = ip_us.dcID;
            us_obj_2_form(ip_us);
            this.ShowDialog();
        }

        private void us_obj_2_form(US_V_DM_CO_SO_DINH_MUC ip_us)
        {
            m_txt_ma_co_so.Text = ip_us.strMA_CO_SO_DINH_MUC;
            m_txt_ten_co_so.Text = ip_us.strTEN_CO_SO_DINH_MUC;
            m_cbo_loai_dinh_muc.SelectedValue = ip_us.dcID_LOAI_DINH_MUC;
            m_txt_don_gia_dinh_muc.Text = CIPConvert.ToStr(ip_us.dcDON_GIA_DINH_MUC);
            m_dat_ap_dung_tu_ngay.Value = ip_us.datAP_DUNG_TU_NGAY;
        }
        private void set_define_events()
        {
            m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_txt_don_gia_dinh_muc.TextChanged+=new EventHandler(m_txt_don_gia_dinh_muc_Click);
        }

        #endregion

        ///
        ///Events Handle
        ///
        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                save_data();
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
        private void m_txt_don_gia_dinh_muc_Click(object sender, EventArgs e)
        {
            if (m_txt_don_gia_dinh_muc.Text == "")
            {
                m_txt_don_gia_dinh_muc.SelectionStart = m_txt_don_gia_dinh_muc.Text.Length + 1;
            }
            else
            {
                m_txt_don_gia_dinh_muc.Text = string.Format("{0:#,###}", CIPConvert.ToDecimal(m_txt_don_gia_dinh_muc.Text.Trim()));
                m_txt_don_gia_dinh_muc.SelectionStart = m_txt_don_gia_dinh_muc.Text.Length + 1;
            }

        }
    }
}
