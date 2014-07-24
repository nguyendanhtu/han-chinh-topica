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
    public partial class f529_DM_NHA_CC_DE : Form
    {
        public f529_DM_NHA_CC_DE()
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
        public void display_for_update()
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            us_obj_2_form();
            this.ShowDialog();
        }
        #endregion

        #region Member
        DataEntryFormMode m_e_form_mode = new DataEntryFormMode();
        US_DM_NHA_CUNG_CAP m_us = new US_DM_NHA_CUNG_CAP();
        DS_DM_NHA_CUNG_CAP m_ds = new DS_DM_NHA_CUNG_CAP();
        #endregion

        #region Private method
        private void format_control()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            m_lbl_tieu_de.Font = new System.Drawing.Font("Tahoma", 15, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            m_chk_close_form.Font = new System.Drawing.Font("Tahoma", 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            m_chk_close_form.ForeColor = Color.Maroon;
            set_define_event();
        }
        private void form_2_us_obj()
        {

        }
        private void us_obj_2_form()
        {

        }
        private void save_data()
        {
            if (!validate_data_is_ok())
                return;
            form_2_us_obj();
        }
        private bool validate_data_is_ok() 
        {
            if (!CValidateTextBox.IsValid(m_txt_ten_nha_cc, DataType.StringType, allowNull.NO, true))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_dia_chi, DataType.StringType, allowNull.NO, true))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_dien_thoai, DataType.StringType, allowNull.NO, true))
                return false;
            return true;
        }
        private void set_define_event()
        {
           m_cmd_save.Click+=new EventHandler(m_cmd_save_Click);
           m_cmd_exit.Click+=new EventHandler(m_cmd_exit_Click);
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
        #endregion

    }
}
