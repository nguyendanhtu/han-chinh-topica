using BCTKDS;
using BCTKDS.CDBNames;
using BCTKUS;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BCTKApp
{
    public partial class f519_V_DM_CO_SO_DINH_MUC_DE : Form
    {
        public f519_V_DM_CO_SO_DINH_MUC_DE()
        {
            InitializeComponent();
            format_control();
        }
        #region Members
        US_DM_CO_SO_DINH_MUC m_us = new US_DM_CO_SO_DINH_MUC();
        DS_DM_CO_SO_DINH_MUC m_ds = new DS_DM_CO_SO_DINH_MUC();
        DataEntryFormMode m_e_form_mode = new DataEntryFormMode();
        #endregion

        #region Public interface
        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();

        }
        public void display_for_update(US_V_DM_CO_SO_DINH_MUC ip_us_v)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            us_obj_2_form(ip_us_v);
            this.ShowDialog();

        }
        #endregion

        #region Private Method
        private void format_control()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            m_lbl_tieu_de.Font = new System.Drawing.Font("Tahoma", 15, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            load_data_2_cbo();
            m_chk_close_form.Font = new System.Drawing.Font("Tahoma", 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            m_chk_close_form.ForeColor = Color.Maroon;
            set_define_events();          
        }
        private void form_2_us_obj()
        {
            m_us.strMA_CO_SO_DINH_MUC = m_txt_ma_co_so.Text;
            m_us.strTEN_CO_SO_DINH_MUC = m_txt_ten_co_so.Text;
            m_us.dcID_LOAI_CO_SO_DINH_MUC = CIPConvert.ToDecimal(m_cbo_loai_co_so.SelectedValue);
        }
        private void us_obj_2_form(US_V_DM_CO_SO_DINH_MUC ip_us)
        {
            m_us.dcID = ip_us.dcID;
            m_txt_ma_co_so.Text = ip_us.strMA_CO_SO_DINH_MUC;
            m_txt_ten_co_so.Text = ip_us.strTEN_CO_SO_DINH_MUC;
            m_cbo_loai_co_so.SelectedValue = ip_us.dcID_LOAI_CO_SO_DINH_MUC;
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
                    m_us.Insert();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    if (!validate_ma_update(m_txt_ma_co_so.Text.Trim(), m_us.dcID))
                    {
                        BaseMessages.MsgBox_Infor("Mã cơ sở đã tồn tại");
                        m_txt_ma_co_so.Focus();
                        return;
                    }
                    m_us.Update();
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
        private bool validate_ma_insert(string v_str_ma)
        {
            US_DM_CO_SO_DINH_MUC v_us= new US_DM_CO_SO_DINH_MUC();
            DS_DM_CO_SO_DINH_MUC v_ds = new DS_DM_CO_SO_DINH_MUC();
            v_us.FillDataset(v_ds, "where ma_co_so_dinh_muc='" + v_str_ma + "'");
            if (v_ds.DM_CO_SO_DINH_MUC.Count != 0 && m_e_form_mode == DataEntryFormMode.InsertDataState) return false;
            return true;
        }
        private bool validate_ma_update(string ip_str_ma, decimal ip_dc_id)
        {
            US_DM_CO_SO_DINH_MUC v_us = new US_DM_CO_SO_DINH_MUC();
            DS_DM_CO_SO_DINH_MUC v_ds = new DS_DM_CO_SO_DINH_MUC();
            v_us.FillDataset(v_ds, "where ma_co_so_dinh_muc='" + ip_str_ma + "' or id=" + ip_dc_id);
            if (v_ds.DM_CO_SO_DINH_MUC.Count != 1) return false;
            return true;
        }
        private void xoa_trang()
        {
            m_txt_ma_co_so.Clear();
            m_txt_ten_co_so.Clear();
            m_cbo_loai_co_so.SelectedIndex = 1;
            m_e_form_mode = DataEntryFormMode.InsertDataState;
        }
        private bool validate_data_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_ma_co_so, DataType.StringType, allowNull.NO, true))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_ten_co_so, DataType.StringType, allowNull.NO, true))
                return false;
            return true;
        }
        private void load_data_2_cbo()
        {
            US_CM_DM_TU_DIEN v_us_td = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_td = new DS_CM_DM_TU_DIEN();
            v_us_td.FillDataset(v_ds_td," where id_loai_tu_dien= 16 ");
            m_cbo_loai_co_so.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_loai_co_so.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_loai_co_so.DataSource = v_ds_td.CM_DM_TU_DIEN;
           
        }
        private void set_define_events()
        {
            m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            this.KeyDown+=new KeyEventHandler(f519_V_DM_CO_SO_DINH_MUC_DE_KeyDown);
        }
        #endregion

        #region Event
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
        private void f519_V_DM_CO_SO_DINH_MUC_DE_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Escape)
                {
                    this.Close();
                }
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
}
