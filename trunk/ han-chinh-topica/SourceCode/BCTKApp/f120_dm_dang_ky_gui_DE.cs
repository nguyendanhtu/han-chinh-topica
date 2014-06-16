using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using BCTKUS;
using IP.Core.IPCommon;
using System.Globalization;
using BCTKDS;

namespace BCTKApp
{
    public partial class f120_dm_dang_ky_gui_DE : Form
    {
        public f120_dm_dang_ky_gui_DE()
        {
            InitializeComponent();
            format_controls();
        }
        #region Public Method
        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }
        public void display_for_update(US_V_CM_DM_DANG_KY_GUI ip_us_v_cm_dm_dang_ky_gui)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_v_dm_dang_ky_gui = ip_us_v_cm_dm_dang_ky_gui;
            this.ShowDialog();
        }
        #endregion
        #region Data Structures
        #endregion

        #region Members
        US_V_CM_DM_DANG_KY_GUI m_us_v_dm_dang_ky_gui = new US_V_CM_DM_DANG_KY_GUI();
        DS_V_CM_DM_DANG_KY_GUI m_ds_v_dm_dang_ky_gui = new DS_V_CM_DM_DANG_KY_GUI();
        DataEntryFormMode m_e_form_mode;
        string m_txt_trong_nuoc, m_txt_nuoc_ngoai;
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
            m_lbl_so_tien.Visible = false;
            m_txt_so_tien.Visible = false;
            m_chkb_trong_nuoc.Checked = true;
            set_define_events();
        }
        private void load_data_2_cbo_phong_ban()
        {
            DS_CM_DM_TU_DIEN v_ds_cm_dm_tu_dien = new DS_CM_DM_TU_DIEN();
            US_CM_DM_TU_DIEN v_us_cm_dm_tu_dien = new US_CM_DM_TU_DIEN();
            v_us_cm_dm_tu_dien.FillDataset(v_ds_cm_dm_tu_dien, "WHERE ID_LOAI_TU_DIEN = 11 ORDER BY MA_TU_DIEN");
            m_cbo_phong_ban.ValueMember = v_ds_cm_dm_tu_dien.CM_DM_TU_DIEN.IDColumn.ToString();
            m_cbo_phong_ban.DisplayMember = v_ds_cm_dm_tu_dien.CM_DM_TU_DIEN.TENColumn.ToString();
            m_cbo_phong_ban.DataSource = v_ds_cm_dm_tu_dien.CM_DM_TU_DIEN;
            
        }		
        private void us_object_2_form()
        {
            IFormatProvider culture = new CultureInfo("de-DE", true);//dung de doi kieu mm.dd.yyyy thanh dd.mm.yyyy

            m_txt_noi_dung.Text = m_us_v_dm_dang_ky_gui.strNOI_DUNG;
            m_txt_noi_nhan.Text = m_us_v_dm_dang_ky_gui.strNOI_NHAN;
            m_txt_nguoi_nhan.Text = m_us_v_dm_dang_ky_gui.strNGUOI_NHAN;
            if (m_us_v_dm_dang_ky_gui.strTRONG_NUOC == "x") m_chkb_trong_nuoc.Checked = true;
            else m_chkb_trong_nuoc.Checked = false;
            if (m_us_v_dm_dang_ky_gui.strNUOC_NGOAI == "x") m_chkb_nuoc_ngoai.Checked = true;
            else m_chkb_nuoc_ngoai.Checked = false;
            //m_txt_trong_nuoc.Text = m_us_v_dm_dang_ky_gui.strTRONG_NUOC;
            //m_txt_nuoc_ngoai.Text = m_us_v_dm_dang_ky_gui.strNUOC_NGOAI;
            m_txt_so_bill.Text = m_us_v_dm_dang_ky_gui.strSO_BILL;
            m_txt_nguoi_gui.Text = m_us_v_dm_dang_ky_gui.strNGUOI_GUI;
            m_tdp_ngay_gui.Text = DateTime.Parse(CIPConvert.ToStr(m_us_v_dm_dang_ky_gui.datNGAY_GUI.Date), culture).ToString();
            m_txt_ghi_chu.Text = m_us_v_dm_dang_ky_gui.strGHI_CHU;
            //m_cbo_phong_ban.Text = CIPConvert.ToStr(m_us_v_dm_dang_ky_gui.dcPHONG_BAN_ID);
            m_cbo_phong_ban.SelectedValue = m_us_v_dm_dang_ky_gui.dcPHONG_BAN_ID;
            m_txt_so_tien.Text = CIPConvert.ToStr(m_us_v_dm_dang_ky_gui.dcSO_TIEN);
        }
        private void form_2_us_object()
        {
            m_us_v_dm_dang_ky_gui.strNOI_DUNG = m_txt_noi_dung.Text.Trim().ToString();
            m_us_v_dm_dang_ky_gui.strNOI_NHAN = m_txt_noi_nhan.Text.Trim().ToString();
            m_us_v_dm_dang_ky_gui.strNGUOI_NHAN = m_txt_nguoi_nhan.Text.Trim().ToString();
            if (m_chkb_trong_nuoc.Checked == true) m_txt_trong_nuoc = "x";
            else m_txt_trong_nuoc = "";
            if (m_chkb_nuoc_ngoai.Checked == true) m_txt_nuoc_ngoai = "x";
            else m_txt_nuoc_ngoai = "";
            m_us_v_dm_dang_ky_gui.strTRONG_NUOC = m_txt_trong_nuoc;
            m_us_v_dm_dang_ky_gui.strNUOC_NGOAI = m_txt_nuoc_ngoai;
            m_us_v_dm_dang_ky_gui.strSO_BILL = m_txt_so_bill.Text.Trim().ToString();
            m_us_v_dm_dang_ky_gui.strNGUOI_GUI = m_txt_nguoi_gui.Text.Trim().ToString();
            m_us_v_dm_dang_ky_gui.datNGAY_GUI = CIPConvert.ToDatetime(m_tdp_ngay_gui.Text.ToString());
            m_us_v_dm_dang_ky_gui.strGHI_CHU = m_txt_ghi_chu.Text.Trim().ToString();
            m_us_v_dm_dang_ky_gui.dcPHONG_BAN_ID = CIPConvert.ToDecimal(m_cbo_phong_ban.SelectedValue.ToString());
            //m_us_v_dm_dang_ky_gui.dcSO_TIEN = CIPConvert.ToDecimal(m_txt_so_tien.Text.Trim().ToString());
        }
        private bool check_validate()
        {
            if (!CValidateTextBox.IsValid(m_txt_noi_dung, DataType.StringType, allowNull.YES, true)) return false;
            if (!CValidateTextBox.IsValid(m_txt_noi_nhan, DataType.StringType, allowNull.YES, true)) return false;
            if (!CValidateTextBox.IsValid(m_txt_nguoi_nhan, DataType.StringType, allowNull.YES, true)) return false;
            //if (!CValidateTextBox.IsValid(m_txt_trong_nuoc, DataType.StringType, allowNull.YES, true)) return false;
            //if (!CValidateTextBox.IsValid(m_txt_nuoc_ngoai, DataType.StringType, allowNull.YES, true)) return false;
            if (!CValidateTextBox.IsValid(m_txt_so_bill, DataType.StringType, allowNull.NO, true)) return false;
            if (!CValidateTextBox.IsValid(m_txt_nguoi_gui, DataType.StringType, allowNull.YES, true)) return false;
            if (!CValidateTextBox.IsValid(m_txt_ghi_chu, DataType.StringType, allowNull.YES, true)) return false;
            return true;
        }
        private void save_data()
        {
            if (!check_validate()) return;
            form_2_us_object();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    if (check_so_bill_ton_tai(m_us_v_dm_dang_ky_gui.strSO_BILL) == 1)
                    {
                        BaseMessages.MsgBox_Infor("Dữ liệu đã tồn tại.");
                        return;
                    }
                    else
                    {
                        m_us_v_dm_dang_ky_gui.Insert();
                        break;
                    }
                case DataEntryFormMode.UpdateDataState:
                    m_us_v_dm_dang_ky_gui.Update();
                    break;
            }
            BaseMessages.MsgBox_Infor("Đã cập nhật thành công!");
            if (m_chk_luu.Checked == false)
            {
                this.Close();
            }
            else
            {
                m_txt_noi_dung.Text = "";
                m_txt_noi_nhan.Text = "";
                m_txt_nguoi_nhan.Text = "";
                //m_txt_trong_nuoc.Text = "";
                m_chkb_trong_nuoc.Checked = true;
                //m_txt_nuoc_ngoai.Text = "";
                m_chkb_nuoc_ngoai.Checked = false;
                m_txt_so_bill.Text = "";
                m_txt_nguoi_gui.Text = "";
                m_tdp_ngay_gui.ResetText(); 
                m_txt_ghi_chu.Text = "";
                load_data_2_cbo_phong_ban();
            }

        }
        private int check_so_bill_ton_tai(string so_bill)
        {
            
            m_us_v_dm_dang_ky_gui.FillDataset(m_ds_v_dm_dang_ky_gui," WHERE SO_BILL = " + so_bill);
            DataTable v_dt = m_ds_v_dm_dang_ky_gui.Tables[0];
            int v_count_number = v_dt.Rows.Count;
            if (v_count_number >= 1) return 1;
            else return 0;
            
        }
        private void set_define_events()
        {
            this.m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            this.m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
            this.Load += new EventHandler(f121_thao_tac_du_lieu_gui_DE_Load);
            this.m_chkb_nuoc_ngoai.Click += new System.EventHandler(this.m_chkb_nuoc_ngoai_Click);
            this.m_chkb_trong_nuoc.Click += new System.EventHandler(this.m_chkb_trong_nuoc_Click);
        }
        #endregion
        //
        //Event Handlers
        //
        private void f121_thao_tac_du_lieu_gui_DE_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_2_cbo_phong_ban();
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:

                        break;
                    case DataEntryFormMode.UpdateDataState:
                        us_object_2_form();
                        break;
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
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

        private void m_chkb_trong_nuoc_Click(object sender, EventArgs e)
        {
            try
            {
                m_chkb_trong_nuoc.Checked = true;
                m_chkb_nuoc_ngoai.Checked = false;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void m_chkb_nuoc_ngoai_Click(object sender, EventArgs e)
        {
            try
            {
                m_chkb_trong_nuoc.Checked = false;
                m_chkb_nuoc_ngoai.Checked = true;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

    }
}
