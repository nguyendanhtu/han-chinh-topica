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

namespace BCTKApp.DanhMuc
{
    public partial class f801_DM_PHONG_BAN_DE : Form
    {
        public f801_DM_PHONG_BAN_DE()
        {
            InitializeComponent();
            format_control();
        }

        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }
        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }
        public void display_for_update(US_DM_PHONG_BAN m_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_dm_phong_ban = m_us;
            us_obi_2_form();
            this.ShowDialog();
        }

        
        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode = new DataEntryFormMode();
        DS_DM_PHONG_BAN m_ds_dm_phong_ban = new DS_DM_PHONG_BAN();
        US_DM_PHONG_BAN m_us_dm_phong_ban = new US_DM_PHONG_BAN();
        #endregion

        #region Private Methods
        private void format_control()
        {
            set_define_events();
            CControlFormat.setFormStyle(this, new CAppContext_201());
        }      
        private bool validate_data_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_ten_phong_ban, DataType.StringType, allowNull.NO, true))
                return false;
            return true;
        }
        private void form_2_us_obj()
        {         
            m_us_dm_phong_ban.strMA_PHONG_BAN = m_txt_ten_phong_ban.Text;
            m_us_dm_phong_ban.strTEN_PHONG_BAN = m_txt_ten_phong_ban.Text;
        }
        private void us_obi_2_form()
        {
            m_txt_ma_phong_ban.Text = m_us_dm_phong_ban.strMA_PHONG_BAN;
            m_txt_ten_phong_ban.Text = m_us_dm_phong_ban.strTEN_PHONG_BAN;
        }
        private void save_data()
        {
            if (!validate_data_is_ok())
                return;
            form_2_us_obj();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_dm_phong_ban.Insert();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_dm_phong_ban.Update();
                    break;
            }
            BaseMessages.MsgBox_Infor("Đã lưu thành công!");
            this.Close();
        }
        private void set_define_events()
        {
            m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
        }
        #endregion

        #region Events
        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            //Buoc 1: Save data
            save_data();
            //Buoc 2: Thong bao       
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}
