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
        #region Members
        DataEntryFormMode m_e_form_mode = new DataEntryFormMode();
        US_DM_PHONG_BAN m_us_dm_phong_ban = new US_DM_PHONG_BAN();
        #endregion
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
        public void display_for_update(US_DM_PHONG_BAN ip_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_dm_phong_ban = ip_us;
            us_obj_2_form();
            this.ShowDialog();
        }

        #endregion

        

        #region Private Methods
        private void format_control()
        {
            
            CControlFormat.setFormStyle(this, new CAppContext_201());
            m_lbl_tieu_de.Font = new System.Drawing.Font("Tahoma", 15, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            m_chk_close_form.Font = new System.Drawing.Font("Tahoma", 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            m_chk_close_form.ForeColor = Color.Maroon;
            set_define_events();
        }
        
        private bool validate_data_is_ok()
        {
            if(!CValidateTextBox.IsValid(m_txt_ma_phong_ban, DataType.StringType, allowNull.NO, true))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_ten_phong_ban, DataType.StringType, allowNull.NO, true))
                return false;
            return true;
        }
        private void form_2_us_obj()
        {         
            m_us_dm_phong_ban.strMA_PHONG_BAN = m_txt_ma_phong_ban.Text;
            m_us_dm_phong_ban.strTEN_PHONG_BAN = m_txt_ten_phong_ban.Text;
            
        }
        private void us_obj_2_form()
        {
            m_txt_ma_phong_ban.Text = m_us_dm_phong_ban.strMA_PHONG_BAN;
            m_txt_ten_phong_ban.Text = m_us_dm_phong_ban.strTEN_PHONG_BAN;
           
        }
        private bool validate_ma_insert(string v_str_ma)
        {
            US_DM_PHONG_BAN v_us = new US_DM_PHONG_BAN();
            DS_DM_PHONG_BAN v_ds = new DS_DM_PHONG_BAN();
            v_us.FillDataset(v_ds, "where ma_phong_ban='" + v_str_ma+"'");
            if (v_ds.DM_PHONG_BAN.Count != 0 && m_e_form_mode==DataEntryFormMode.InsertDataState) return false;
             return true;
        }
        private bool validate_ma_update(string ip_str_ma,decimal ip_dc_id)
        {
            US_DM_PHONG_BAN v_us = new US_DM_PHONG_BAN();
            DS_DM_PHONG_BAN v_ds = new DS_DM_PHONG_BAN();
            v_us.FillDataset(v_ds, "where ma_phong_ban='" + ip_str_ma + "' or id="+ip_dc_id);
            if (v_ds.DM_PHONG_BAN.Count != 1) return false;
            return true;
        }
        private void save_data()
        {
            if (!validate_data_is_ok())
                return;
            if (!validate_ma_insert(m_txt_ma_phong_ban.Text.Trim()))
            {
                BaseMessages.MsgBox_Infor("Mã trung tâm đã tồn tại");
                xoa_trang();
                return;
            }
            form_2_us_obj();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                         m_us_dm_phong_ban.Insert(); 
                        break;
                case DataEntryFormMode.UpdateDataState:
                        if (!validate_ma_update(m_txt_ma_phong_ban.Text.Trim(), m_us_dm_phong_ban.dcID))
                        {
                            BaseMessages.MsgBox_Infor("Mã trung tâm đã tồn tại");
                            m_txt_ma_phong_ban.Focus();
                            return;
                        }
                    m_us_dm_phong_ban.Update();
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
            m_txt_ma_phong_ban.Clear();
            m_txt_ten_phong_ban.Clear();
            m_e_form_mode = DataEntryFormMode.InsertDataState;
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
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}
