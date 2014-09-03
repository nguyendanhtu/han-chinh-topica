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
        public void display_for_update(US_DM_NHA_CUNG_CAP ip_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us = ip_us;
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
            m_us.strTEN = m_txt_ten_nha_cc.Text;
            m_us.strDIA_CHI = m_txt_dia_chi.Text;
            m_us.strDIEN_THOAI = m_txt_dien_thoai.Text;
            m_us.strEMAIL = m_txt_email.Text;
            m_us.strFAX = m_txt_fax.Text;
            m_us.strWEB = m_txt_website.Text;
        }
        private void us_obj_2_form()
        {
            m_txt_ten_nha_cc.Text = m_us.strTEN;
            m_txt_dia_chi.Text = m_us.strDIA_CHI;
            m_txt_dien_thoai.Text = m_us.strDIEN_THOAI;
            m_txt_fax.Text = m_us.strFAX;
            m_txt_email.Text = m_us.strEMAIL;
            m_txt_website.Text = m_us.strWEB;
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
                default:
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
            m_txt_ten_nha_cc.Clear();
            m_txt_dia_chi.Clear();
            m_txt_dien_thoai.Clear();
            m_txt_email.Clear();
            m_txt_fax.Clear();
            m_txt_website.Clear();
            m_txt_website.Clear();
            m_e_form_mode = DataEntryFormMode.InsertDataState;
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
            this.KeyDown+=new KeyEventHandler(f529_DM_NHA_CC_DE_KeyDown);
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
        private void f529_DM_NHA_CC_DE_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
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
