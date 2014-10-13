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
    public partial class F604_v_dm_vpp_de : Form
    {
        public F604_v_dm_vpp_de()
        {
            InitializeComponent();
            format_control();

        }
        #region Public Interface
        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }
        public void display_for_update(US_V_DM_VPP ip_us_v)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            us_obj_2_form(ip_us_v);
            this.ShowDialog();
        }
        #endregion

        #region Member
        US_DM_VPP m_us = new US_DM_VPP();
        DS_DM_VPP m_ds = new DS_DM_VPP();
        DataEntryFormMode m_e_form_mode = new DataEntryFormMode();
        #endregion

        #region Private Method
        private void format_control()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            m_lbl_tieu_de.Font = new System.Drawing.Font("Tahoma", 15, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            m_chk_close_form.Font = new System.Drawing.Font("Tahoma", 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            m_chk_close_form.ForeColor = Color.Maroon;
            load_data_2_cbo();
            m_cmd_save.Visible = true;
            m_cmd_save.Enabled = true;
            m_cmd_exit.Visible = true;
            m_cmd_exit.Enabled = true;
            set_define_events();
        }
        private void load_data_2_cbo()
        {
            US_DM_NHA_CUNG_CAP v_us = new US_DM_NHA_CUNG_CAP();
            DS_DM_NHA_CUNG_CAP v_ds = new DS_DM_NHA_CUNG_CAP();
            v_us.FillDataset(v_ds);
            m_cbo_nha_cc.DataSource = v_ds.DM_NHA_CUNG_CAP;
            m_cbo_nha_cc.ValueMember = DM_NHA_CUNG_CAP.ID;
            m_cbo_nha_cc.DisplayMember = DM_NHA_CUNG_CAP.TEN;
        }
        private void form_2_us_obj() 
        {
            m_us.strMA = m_txt_ma_mat_hang.Text;
            m_us.strTEN = m_txt_ten_mat_hang.Text;
            m_us.strDON_VI_TINH = m_txt_don_vi_tinh.Text;
            m_us.dcDON_GIA_CHUA_VAT = CIPConvert.ToDecimal(m_txt_don_gia.Text.Trim().Replace(",", "").Replace(".", ""));
            m_us.dcDON_GIA_GOM_VAT = CIPConvert.ToDecimal((float)m_us.dcDON_GIA_CHUA_VAT * 1.1);
            m_us.dcID_NHA_CUNG_CAP = CIPConvert.ToDecimal(m_cbo_nha_cc.SelectedValue);
            m_us.strGIOI_HAN_VPP = m_txt_gioi_han.Text;
        }
        private void us_obj_2_form(US_V_DM_VPP ip_v_us)
        {
            m_us.dcID = ip_v_us.dcID_VPP;
            m_txt_ma_mat_hang.Text = ip_v_us.strMA;
            m_txt_ten_mat_hang.Text = ip_v_us.strTEN_VPP;
            m_txt_don_vi_tinh.Text = ip_v_us.strDON_VI_TINH;
            m_txt_don_gia.Text = ip_v_us.dcDON_GIA_CHUA_VAT.ToString();
            m_cbo_nha_cc.SelectedValue = ip_v_us.dcID_NHA_CUNG_CAP;
            m_txt_gioi_han.Text = ip_v_us.strGIOI_HAN_VPP;
        }
        private void save_data()
        {
            if (!validate_data_is_ok())
                return;
            form_2_us_obj();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us.Insert();
                    break;
                case DataEntryFormMode.UpdateDataState:
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
        private void xoa_trang()
        {
            m_txt_ma_mat_hang.Clear();
            m_txt_ten_mat_hang.Clear();
            m_cbo_nha_cc.SelectedIndex = 1;
            m_txt_don_vi_tinh.Clear();
            m_txt_don_gia.Clear();
            m_e_form_mode = DataEntryFormMode.InsertDataState;
        }
        private bool validate_data_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_ma_mat_hang, DataType.StringType, allowNull.NO, true))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_ten_mat_hang, DataType.StringType, allowNull.NO, true))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_don_vi_tinh, DataType.StringType, allowNull.NO, true))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_don_gia, DataType.StringType, allowNull.NO, true))
                return false;
            return true;
        }
        private void set_define_events()
        {
            m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
            m_cmd_exit.Click+=new EventHandler(m_cmd_exit_Click);
            this.KeyDown += new KeyEventHandler(F604_v_dm_vpp_de_KeyDown);
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
        private void F604_v_dm_vpp_de_KeyDown(object sender, KeyEventArgs e)
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
