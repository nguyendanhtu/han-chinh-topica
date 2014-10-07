using System;
using System.Collections.Generic;
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

namespace BCTKApp
{
    public partial class F566_V_GD_DE_XUAT_VPP_DE : Form
    {
        public F566_V_GD_DE_XUAT_VPP_DE()
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
        public void display_for_update(US_V_GD_DE_XUAT_VPP ip_us_v)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            us_obj_2_form(ip_us_v);
            this.ShowDialog();
        }

        
        #endregion

        #region Member
        US_GD_DE_XUAT_VPP m_us = new US_GD_DE_XUAT_VPP();
        DS_GD_DE_XUAT_VPP m_ds = new DS_GD_DE_XUAT_VPP();
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        #endregion

        #region Private Method
        private void format_control()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            m_lbl_tieu_de.Font = new System.Drawing.Font("Tahoma", 15, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            m_chk_close_form.Font = new System.Drawing.Font("Tahoma", 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            m_chk_close_form.ForeColor = Color.Maroon;
            load_data_2_cbo();
            m_dtp_thang.Text = DateTime.Now.Date.ToString("MM/yyyy");
            m_cmd_exit.Visible = true;
            m_cmd_exit.Enabled = true;
            m_cmd_save.Visible = true;
            m_cmd_save.Enabled = true;
            set_define_event();
        }
        private void load_data_2_cbo()
        {
            US_DM_PHONG_BAN v_us = new US_DM_PHONG_BAN();
            DS_DM_PHONG_BAN v_ds = new DS_DM_PHONG_BAN();
            v_us.FillDataset(v_ds);
            m_cbo_trung_tam.DataSource = v_ds.DM_PHONG_BAN;
            m_cbo_trung_tam.ValueMember = DM_PHONG_BAN.ID;
            m_cbo_trung_tam.DisplayMember = DM_PHONG_BAN.TEN_PHONG_BAN;
        }
        private void us_obj_2_form(US_V_GD_DE_XUAT_VPP ip_us_v)
        {
            m_us.dcID = ip_us_v.dcID;
            m_cbo_trung_tam.SelectedValue = ip_us_v.dcID_PHONG_BAN;
            m_txt_so_tien.Text = CIPConvert.ToStr(ip_us_v.dcSO_TIEN, "#,##0");
            m_txt_ghi_chu.Text = ip_us_v.strGHI_CHU;
            m_dtp_thang.Text = ip_us_v.datTHANG_AP_DUNG.ToString("MM/yyyy");
        }
        private void form_2_us_obj()
        {
            m_us.dcID_PHONG_BAN = CIPConvert.ToDecimal(m_cbo_trung_tam.SelectedValue);
            m_us.dcSO_TIEN = CIPConvert.ToDecimal(m_txt_so_tien.Text.Trim().Replace(",", "").Replace(".", ""));
            m_us.strGHI_CHU = m_txt_ghi_chu.Text;
            m_us.datTHANG_AP_DUNG = CIPConvert.ToDatetime("01/" + m_dtp_thang.Text, "dd/MM/yyyy");
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
        private bool validate_data_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_so_tien, DataType.StringType, allowNull.NO, true))
                return false;
            return true;
        }
        private void xoa_trang()
        {
            m_cbo_trung_tam.SelectedIndex = 0;
            m_txt_so_tien.Clear();
            m_txt_ghi_chu.Clear();
            m_dtp_thang.Clear();
        }
        private void set_define_event()
        {
            m_cmd_exit.Click += m_cmd_exit_Click;
            m_cmd_save.Click += m_cmd_save_Click;
            m_txt_so_tien.TextChanged+=m_txt_so_tien_TextChanged;
        }

        

      
        #endregion

        #region Event
        private void m_cmd_exit_Click(object sender, System.EventArgs e)
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
        private void m_cmd_save_Click(object sender, System.EventArgs e)
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
        private void m_txt_so_tien_TextChanged(object sender, EventArgs e)
        {
            if (m_txt_so_tien.Text == "")
            {
                m_txt_so_tien.SelectionStart = m_txt_so_tien.Text.Length + 1;
            }
            else
            {
                m_txt_so_tien.Text = string.Format("{0:#,###}", CIPConvert.ToDecimal(m_txt_so_tien.Text.Trim()));
                m_txt_so_tien.SelectionStart = m_txt_so_tien.Text.Length + 1;
            }
        }
        #endregion  
    }
}
