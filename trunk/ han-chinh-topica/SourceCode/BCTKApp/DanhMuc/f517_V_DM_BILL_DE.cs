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
    public partial class f517_V_DM_BILL_DE : Form
    {
        public f517_V_DM_BILL_DE()
        {
            InitializeComponent();
            format_control();
        }
        #region Members
        US_DM_BILL m_us = new US_DM_BILL();
        DS_DM_BILL m_ds = new DS_DM_BILL();
        DataEntryFormMode m_e_form_mode = new DataEntryFormMode();
        #endregion

        #region Public interface
        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();

        }
        public void display_for_update(US_V_DM_BILL ip_us_v)
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
            load_data_2_cbo_trung_tam();
            load_data_2_cbo_trang_thai();
            m_chk_close_form.Font = new System.Drawing.Font("Tahoma", 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            m_chk_close_form.ForeColor = Color.Maroon;
            set_define_events();
        }
        private void form_2_us_obj()
        {
            m_us.strSO_BILL = m_txt_so_bill.Text;
            m_us.strNOI_DUNG = m_txt_noi_dung.Text;
            m_us.strNGUOI_NHAN = m_txt_nguoi_nhan.Text;
            m_us.strNGUOI_GUI = m_txt_nguoi_gui.Text;
            m_us.strGHI_CHU = m_txt_ghi_chu.Text;
            m_us.strNOI_NHAN = m_txt_noi_nhan.Text;
            if (m_chk_nuoc_ngoai.Checked == true)m_us.strNUOC_NGOAI = "x";
            if (m_chk_trong_nuoc.Checked == true) m_us.strTRONG_NUOC = "x";
            m_us.dcID_PHONG_BAN = CIPConvert.ToDecimal(m_cbo_trung_tam.SelectedValue);
            m_us.dcID_TRANG_THAI = CIPConvert.ToDecimal(m_cbo_trang_thai.SelectedValue);
            m_us.dcSO_TIEN = CIPConvert.ToDecimal(m_txt_so_tien.Text);
            m_us.datNGAY_GUI = m_dtp_ngay_gui.Value.Date;
        }
        private void us_obj_2_form(US_V_DM_BILL ip_us)
        {
            m_us.dcID = ip_us.dcID;
            m_txt_so_bill.Text = ip_us.strSO_BILL ;
            m_txt_noi_dung.Text = ip_us.strNOI_DUNG;
            m_txt_nguoi_nhan.Text = ip_us.strNGUOI_NHAN ;
            m_txt_nguoi_gui.Text = ip_us.strNGUOI_GUI  ;
            m_txt_ghi_chu.Text = ip_us.strGHI_CHU ;
            m_txt_noi_nhan.Text = ip_us.strNOI_NHAN ;
            if (ip_us.strNUOC_NGOAI=="x")m_chk_nuoc_ngoai.Checked=true ;
            if (ip_us.strTRONG_NUOC == "x") m_chk_trong_nuoc.Checked = true;
            m_cbo_trang_thai.SelectedValue = ip_us.dcID_TRANG_THAI;
            m_cbo_trung_tam.SelectedValue = ip_us.dcID_PHONG_BAN;
            m_txt_so_tien.Text = ip_us.dcSO_TIEN.ToString();
            m_dtp_ngay_gui.Value = ip_us.datNGAY_GUI.Date;
            
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
            m_txt_so_bill.Clear();
            m_txt_nguoi_nhan.Clear();
            m_cbo_trung_tam.SelectedIndex = 1;
            m_cbo_trang_thai.SelectedIndex = 1;
            m_txt_so_tien.Clear();
            m_txt_ghi_chu.Clear();
            m_txt_nguoi_gui.Clear();
            m_txt_noi_dung.Clear();
            m_txt_noi_nhan.Clear();
            m_dtp_ngay_gui.Value = DateTime.Now.Date;
            m_e_form_mode = DataEntryFormMode.InsertDataState;
        }
        private bool validate_data_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_so_bill, DataType.StringType, allowNull.NO, true))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_nguoi_nhan, DataType.StringType, allowNull.NO, true))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_ghi_chu, DataType.StringType, allowNull.NO, true))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_nguoi_gui, DataType.StringType, allowNull.NO, true))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_noi_dung, DataType.StringType, allowNull.NO, true))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_so_tien, DataType.StringType, allowNull.NO, true))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_noi_nhan, DataType.StringType, allowNull.NO, true))
                return false;
            if (m_chk_nuoc_ngoai.Checked == true && m_chk_trong_nuoc.Checked == true) 
            {
                BaseMessages.MsgBox_Infor("Bạn chưa chọn trong nước hay ngoài nước");
                return false;
            }
            return true;
        }
        private void load_data_2_cbo_trung_tam()
        {
            US_DM_PHONG_BAN v_us = new US_DM_PHONG_BAN();
            DS_DM_PHONG_BAN v_ds = new DS_DM_PHONG_BAN();
            v_us.FillDataset(v_ds);
            m_cbo_trung_tam.DisplayMember = DM_PHONG_BAN.TEN_PHONG_BAN;
            m_cbo_trung_tam.ValueMember = DM_PHONG_BAN.ID;
            m_cbo_trung_tam.DataSource = v_ds.DM_PHONG_BAN;

        }
        private void load_data_2_cbo_trang_thai()
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            v_us.FillDataset(v_ds, "Where id_loai_tu_dien = 12");
            m_cbo_trang_thai.DataSource = v_ds.CM_DM_TU_DIEN;
            m_cbo_trang_thai.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_trang_thai.DisplayMember = CM_DM_TU_DIEN.TEN;
        }
        private void set_define_events()
        {
            m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            this.KeyDown+=new KeyEventHandler(f517_V_DM_BILL_DE_KeyDown);
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
        private void f517_V_DM_BILL_DE_KeyDown(object sender, KeyEventArgs e)
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
