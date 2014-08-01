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
//using IP.Core.IPData;
//using IP.Core.IPData.DBNames;

namespace BCTKApp.HeThong
{
    public partial class f308_DOI_MAT_KHAU_NGUOI_SD : Form
    {
        public f308_DOI_MAT_KHAU_NGUOI_SD()
        {
            InitializeComponent();
            format_control();
        }
        #region Public Interfaces
        public void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region  Members
        US_HT_NGUOI_SU_DUNG m_us_ht_nguoi_su_dung = new US_HT_NGUOI_SU_DUNG();
        US_HT_NGUOI_SU_DUNG.LogonResult v_logonresult;
        #endregion

        #region  Private Methods
        private void format_control()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            set_define_events();
        }
        private bool check_validate_data_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_mat_khau_cu
                , DataType.StringType
                , allowNull.NO
                , true))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_mat_khau_moi
                , DataType.StringType
                , allowNull.NO
                , true))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_nhap_lai_mat_khau_moi
                , DataType.StringType
                , allowNull.NO
                , true))
                return false;
            return true;
        }
        private void save_data()
        {
            //Buoc 1: Check validate du lieu khong duoc de trong
            if (!check_validate_data_is_ok())
                return;

            //Buoc 2: Check với CSDL
            //Khong dung thi hien thong bao

            //Bước 2.1 Check xem tài khoản đã tồn tại hay chưa
            US_HT_NGUOI_SU_DUNG v_us_check = new US_HT_NGUOI_SU_DUNG();
            v_us_check.InitByTenTruyCap(m_txt_tai_khoan.Text);
            //Bước 2.2 Check mat khau cu co dung voi ten tai khoan khong?
            v_us_check.check_user(m_txt_tai_khoan.Text, CIPConvert.Encoding(m_txt_mat_khau_cu.Text), ref v_logonresult);
            switch (v_logonresult)
            {
                case US_HT_NGUOI_SU_DUNG.LogonResult.User_Is_Locked: return;
                case US_HT_NGUOI_SU_DUNG.LogonResult.WrongPassword_OR_Name: BaseMessages.MsgBox_Error("Sai tên tài khoản hoặc mật khẩu!");
                    return;
                default: break;
            }
            //Buoc 2.3: Check mat khau moi nhap vao co trung nhau hay khong?
            if (m_txt_mat_khau_moi.Text != m_txt_nhap_lai_mat_khau_moi.Text)
            {
                BaseMessages.MsgBox_Error("Việc nhập lại mật khẩu mới chưa đúng!");
                return;
            }
            
            
            //Buoc 4: Luu
                v_us_check.strMAT_KHAU = CIPConvert.Encoding(m_txt_mat_khau_moi.Text);

                v_us_check.Update();
           
            //Buoc 5: Hien thong bao
            BaseMessages.MsgBox_Infor("Đã đổi mật khẩu thành công!");
            this.Close();
        }

        private void set_define_events()
        {
            m_cmd_exit.Click += m_cmd_exit_Click;
            m_cmd_save.Click += m_cmd_save_Click;
        }
        #endregion

        #region  Events
        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (System.Exception v_e)
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
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
}
