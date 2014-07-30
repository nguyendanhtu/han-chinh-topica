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
    public partial class f524_THONG_KE_HOC_VIEN_DE : Form
    {
        public f524_THONG_KE_HOC_VIEN_DE()
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
        public void display_for_update(US_V_GD_THONG_KE ip_us_v)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            us_obj_2_form(ip_us_v);
            m_cbo_co_so_dm.Enabled = false;
            this.ShowDialog();
        }
        #endregion

        #region Member
        US_GD_THONG_KE m_us_tk = new US_GD_THONG_KE();
        DS_GD_THONG_KE m_ds_tk = new DS_GD_THONG_KE();
        DataEntryFormMode m_e_form_mode = new DataEntryFormMode();
        #endregion

        #region Private Method
        private void format_control()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            m_lbl_tieu_de.Font = new System.Drawing.Font("Tahoma", 15, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            m_chk_close_form.Font = new System.Drawing.Font("Tahoma", 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            m_chk_close_form.ForeColor = Color.Maroon;
            load_data_2_cbo_truong();
            DateTime temp = m_dtp_ngay.Value.Date;
            temp = temp.AddMonths(1);
            temp = temp.AddDays(-(temp.Day));
            m_dtp_ngay.Value = temp;
            load_data_2_cbo_truong();
            this.m_cbo_loai_hv.Items.AddRange(new object[] { "Học viên đang học", "Học viên tuyển mới" });
            m_cbo_loai_hv.SelectedIndex = 0;
            load_data_2_co_so_dm();
            set_define_event();
        }
        private void form_2_us_obj() 
        {
            m_us_tk.dcID_CO_SO_DINH_MUC = CIPConvert.ToDecimal(m_cbo_co_so_dm.SelectedValue);
            m_us_tk.dcID_DM_CO_SO = CIPConvert.ToDecimal(m_cbo_truong.SelectedValue);
            m_us_tk.dcID_DON_VI_THONG_KE = CONST_ID_DON_VI_THONG_KE.HOC_VIEN;
            m_us_tk.dcID_LOAI_THOI_GIAN = CONST_ID_CM_DM_TU_DIEN.ID_PHAT_SINH_CUOi_KY;
            m_us_tk.dcGIA_TRI_THONG_KE = CIPConvert.ToDecimal(m_txt_so_luong.Text.Replace(",", "").Replace(",", ""));
            m_us_tk.strTEN_THONG_KE = m_txt_ten_thong_ke.Text;
            m_us_tk.strGHI_CHU_1 = m_txt_ghi_chu.Text;
            m_us_tk.datTU_NGAY = m_dtp_ngay.Value.Date.AddDays(-(m_dtp_ngay.Value.Day) + 1);
            m_us_tk.datDEN_NGAY = m_dtp_ngay.Value.Date;
        }
        private void us_obj_2_form(US_V_GD_THONG_KE ip_us_v)
        {
            m_us_tk.dcID = ip_us_v.dcID;
            m_cbo_truong.SelectedValue = ip_us_v.dcID_DM_CO_SO;
            m_txt_ten_thong_ke.Text = ip_us_v.strTEN_THONG_KE;
            m_txt_so_luong.Text = ip_us_v.dcGIA_TRI_THONG_KE.ToString();
            m_dtp_ngay.Value = ip_us_v.datDEN_NGAY.Date;
            m_txt_ghi_chu.Text = ip_us_v.strGHI_CHU_1;
            if (ip_us_v.dcID_CO_SO_DINH_MUC == CONST_ID_CO_SO_DINH_MUC.DANGHOC_TRUONG || ip_us_v.dcID_CO_SO_DINH_MUC == CONST_ID_CO_SO_DINH_MUC.DANGHOC_ALL)
            {
                m_cbo_loai_hv.SelectedIndex = 0;
            }
            else m_cbo_loai_hv.SelectedIndex = 1;
            m_cbo_co_so_dm.SelectedValue = ip_us_v.dcID_CO_SO_DINH_MUC;
        }
        private void load_data_2_cbo_truong()
        {
            US_V_DM_CO_SO v_us = new US_V_DM_CO_SO();
            DS_V_DM_CO_SO v_ds = new DS_V_DM_CO_SO();
            v_us.FillDataset(v_ds, "where id_loai_co_so=184 or id_loai_co_so=186");
            m_cbo_truong.DataSource = v_ds.V_DM_CO_SO;
            m_cbo_truong.ValueMember = V_DM_CO_SO.ID;
            m_cbo_truong.DisplayMember = V_DM_CO_SO.MO_TA;
        }

        private void load_data_2_co_so_dm()
        {
            US_DM_CO_SO_DINH_MUC v_us = new US_DM_CO_SO_DINH_MUC();
            DS_DM_CO_SO_DINH_MUC v_ds = new DS_DM_CO_SO_DINH_MUC();
            v_ds.Clear();
            if (m_cbo_loai_hv.SelectedIndex == 0)
            {
                v_us.FillDataset(v_ds, "Where TEN_CO_SO_DINH_MUC LIKE N'%học%'");
            }
            else
            {
                v_us.FillDataset(v_ds, "Where TEN_CO_SO_DINH_MUC LIKE N'%mới%'");
            }
            m_cbo_co_so_dm.DataSource = v_ds.DM_CO_SO_DINH_MUC;
            m_cbo_co_so_dm.ValueMember = DM_CO_SO_DINH_MUC.ID;
            m_cbo_co_so_dm.DisplayMember = DM_CO_SO_DINH_MUC.TEN_CO_SO_DINH_MUC;
        }
        private bool validate_data_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_ten_thong_ke, DataType.StringType, allowNull.NO, true))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_so_luong, DataType.StringType, allowNull.NO, true))
                return false;
            return true;
        }
        private void save_data()
        {
            if (!validate_data_is_ok())
                return;
            form_2_us_obj();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_tk.Insert();
                    break;
                case DataEntryFormMode.UpdateDataState:

                    m_us_tk.Update();
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
            m_txt_ten_thong_ke.Clear();
            m_txt_so_luong.Clear();
            m_txt_ghi_chu.Clear();
            m_e_form_mode = DataEntryFormMode.InsertDataState;
        }
        private void set_define_event()
        {
            m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_dtp_ngay.ValueChanged += new EventHandler(m_dtp_ngay_ValueChanged);
            m_txt_so_luong.TextChanged += new EventHandler(m_txt_so_luong_TextChanged);
            m_txt_so_luong.KeyPress += new KeyPressEventHandler(m_txt_so_luong_KeyPress);
            m_cbo_loai_hv.SelectedIndexChanged+=new EventHandler(m_cbo_loai_hv_SelectedIndexChanged);
            this.KeyDown+=new KeyEventHandler(f524_THONG_KE_HOC_VIEN_DE_KeyDown);
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
        private void m_cbo_loai_hv_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                m_cbo_co_so_dm.Enabled = true;
                load_data_2_co_so_dm();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_dtp_ngay_ValueChanged(object sender, EventArgs e)
        {
            DateTime temp = m_dtp_ngay.Value.Date;
            temp = temp.AddMonths(1);
            temp = temp.AddDays(-(temp.Day));
            DateTime v_dat_ngay = temp;
            m_dtp_ngay.Value = v_dat_ngay.Date;
        }
        private void m_txt_so_luong_TextChanged(object sender, EventArgs e)
        {
            if (m_txt_so_luong.Text == "")
            {
                m_txt_so_luong.SelectionStart = m_txt_so_luong.Text.Length + 1;
            }
            else
            {
                m_txt_so_luong.Text = string.Format("{0:#,###}", CIPConvert.ToDecimal(m_txt_so_luong.Text.Trim()));
                m_txt_so_luong.SelectionStart = m_txt_so_luong.Text.Length + 1;
            }
        }
        private void m_txt_so_luong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                if (e.KeyChar != (char)8)
                {
                    BaseMessages.MsgBox_Infor("Bạn đã nhập chữ '" + e.KeyChar + "'...Xin vui lòng chỉ nhập số");
                    e.KeyChar = (char)0;
                }
            }
        }
        private void f524_THONG_KE_HOC_VIEN_DE_KeyDown(object sender, KeyEventArgs e)
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
