using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using IP.Core.IPSystemAdmin;
using BCTKUS;
using BCTKDS;
using BCTKDS.CDBNames;

namespace BCTKApp.HeThong
{
    public partial class f998_ht_nguoi_su_dung_de : Form
    {
        public f998_ht_nguoi_su_dung_de()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Interface
        public void insert_new_user()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }
        public void update_new_user(US_HT_NGUOI_SU_DUNG i_us_user)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_user = i_us_user;
            this.ShowDialog();

        }

        #endregion
        #region Members
        US_HT_NGUOI_SU_DUNG m_us_user = new US_HT_NGUOI_SU_DUNG();
        DataEntryFormMode m_e_form_mode;
        #endregion
        #region Data Structures
        #endregion
        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201(), IPFormStyle.DialogForm);
            m_cbo_trang_thai.SelectedIndex = 0;
            set_define_events();
        }
        private void load_data_2_cbo_nhom_nguoi_dung()
        {
            //US_HT_NHOM_NGUOI_SU_DUNG v_us_nhom_nguoi_dung = new US_HT_NHOM_NGUOI_SU_DUNG();
            //DS_HT_NHOM_NGUOI_SU_DUNG v_ds_nhom_nguoi_dung = new DS_HT_NHOM_NGUOI_SU_DUNG();
            //v_us_nhom_nguoi_dung.FillDataset(v_ds_nhom_nguoi_dung);
            //v_ds_nhom_nguoi_dung.EnforceConstraints = false;
            US_HT_USER_GROUP v_us_nhom_nguoi_dung = new US_HT_USER_GROUP();
            DS_HT_USER_GROUP v_ds_nhom_nguoi_dung = new DS_HT_USER_GROUP();
            v_us_nhom_nguoi_dung.FillDataset(v_ds_nhom_nguoi_dung);
            v_ds_nhom_nguoi_dung.EnforceConstraints = false;
            m_cbo_nhom_quyen.ValueMember = HT_USER_GROUP.ID;
            m_cbo_nhom_quyen.DisplayMember = HT_USER_GROUP.USER_GROUP_NAME;
            m_cbo_nhom_quyen.DataSource = v_ds_nhom_nguoi_dung.HT_USER_GROUP;
        }
        private void form_2_us_object()
        {
            m_us_user.strBUILT_IN_YN
                = CIPConvert.ToYNString(m_chk_is_admin.Checked);
            m_us_user.strTEN_TRUY_CAP = m_txt_ten_truy_cap.Text;
            m_us_user.strTEN = m_txt_ten.Text;
            //m_us_user.strMAT_KHAU = m_txt_mat_khau.Text;
            m_us_user.strMAT_KHAU = CIPConvert.Encoding(m_txt_mat_khau.Text);
            m_us_user.strTRANG_THAI =
                CIPConvert.ToStr(m_cbo_trang_thai.SelectedIndex);
            m_us_user.strNGUOI_TAO = IP.Core.IPSystemAdmin.CAppContext_201.getCurrentUser();
            m_us_user.dcID_USER_GROUP = CIPConvert.ToDecimal(m_cbo_nhom_quyen.SelectedValue);
            m_us_user.strMAIL = m_txt_email.Text.Trim();
        }
        private void us_object_2_form()
        {
            m_chk_is_admin.Checked = CIPConvert.ToBoolean(m_us_user.strBUILT_IN_YN);
            if (m_chk_is_admin.Checked)
            {
                m_chk_is_admin.Text = "có";
            }
            else
            {
                m_chk_is_admin.Text = "Không";
            }
            m_txt_ten_truy_cap.Text = m_us_user.strTEN_TRUY_CAP;
            m_txt_ten.Text = m_us_user.strTEN;
            //			m_txt_mat_khau.Text = m_us_user.strMAT_KHAU;
            //			m_txt_go_lai_mat_khau.Text = m_us_user.strMAT_KHAU;
            m_txt_mat_khau.Text = CIPConvert.Deciphering(m_us_user.strMAT_KHAU);
            m_txt_go_lai_mat_khau.Text = CIPConvert.Deciphering(m_us_user.strMAT_KHAU);
            m_cbo_trang_thai.SelectedIndex =
                (int)CIPConvert.ToDecimal(m_us_user.strTRANG_THAI);
            m_txt_email.Text = m_us_user.strMAIL;
            m_cbo_nhom_quyen.SelectedValue = m_us_user.dcID_USER_GROUP;
        }
        private bool check_validate()
        {
            if (!CValidateTextBox.IsValid(m_txt_ten_truy_cap, DataType.StringType, allowNull.NO, true)) return false;
            if (!CValidateTextBox.IsValid(m_txt_ten, DataType.StringType, allowNull.NO, true)) return false;
            if (!CValidateTextBox.IsValid(m_txt_mat_khau, DataType.StringType, allowNull.NO, true)) return false;
            if (m_txt_mat_khau.Text != m_txt_go_lai_mat_khau.Text)
            {
                BaseMessages.MsgBox_Infor("Mật khẩu gõ chưa chính xác!");
                return false;
            }
            if (!m_txt_email.Text.Contains("@gmail.com") &&!m_txt_email.Text.Contains("@topica.edu.vn"))
            {
                BaseMessages.MsgBox_Infor("Bạn hãy nhập mail của Topica!");
                return false;
            }
            return true;
        }
        private void save_data()
        {
            if (!check_validate()) return;
            form_2_us_object();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_user.Insert();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_user.Update();
                    break;
            }
            BaseMessages.MsgBox_Infor("Đã cập nhật thành công!");
            this.Close();

        }
        private void set_define_events()
        {
            this.m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            this.m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
            this.Load += new EventHandler(f998_ht_nguoi_su_dung_de_Load);
            this.m_chk_is_admin.Click += new EventHandler(m_chk_is_admin_Click);
            this.KeyDown += new KeyEventHandler(f998_ht_nguoi_su_dung_de_KeyDown);
        }
        #endregion
        //
        //
        //
        //
        //

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

        private void f998_ht_nguoi_su_dung_de_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_2_cbo_nhom_nguoi_dung();
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

        private void m_chk_is_admin_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_chk_is_admin.Checked)
                {
                    m_chk_is_admin.Text = "Có";
                }
                else
                {
                    m_chk_is_admin.Text = "Không";
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void f998_ht_nguoi_su_dung_de_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Escape:
                        this.Close();
                        break;
                    case Keys.S:
                        if (e.Control == true)
                        {
                            switch (m_e_form_mode)
                            {
                                case DataEntryFormMode.InsertDataState:
                                    save_data();
                                    break;
                                case DataEntryFormMode.UpdateDataState:
                                    save_data();
                                    break;
                                case DataEntryFormMode.ViewDataState:
                                    break;
                                case DataEntryFormMode.SelectDataState:
                                    break;
                            }
                        }
                        break;
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_chk_is_admin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
