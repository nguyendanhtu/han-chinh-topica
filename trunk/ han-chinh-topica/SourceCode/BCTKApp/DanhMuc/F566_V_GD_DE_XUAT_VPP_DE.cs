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
using BCTKApp;
using System.Configuration;
using System.IO;

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
        public void display_for_update(US_V_GD_DE_XUAT ip_us_v)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            us_obj_2_form(ip_us_v);
            this.ShowDialog();
        }

        
        #endregion

        #region Member

        US_GD_DE_XUAT m_us = new US_GD_DE_XUAT();
        DS_GD_DE_XUAT m_ds = new DS_GD_DE_XUAT();
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;

        private DataEntryFileMode m_e_file_mode;
        private string m_str_domain = ConfigurationSettings.AppSettings["DOMAIN"];
        private string m_str_directory_to = ConfigurationSettings.AppSettings["DESTINATION_NAME"];
        private string m_str_user_name = ConfigurationSettings.AppSettings["USERNAME_SHARE"];
        private string m_str_password = ConfigurationSettings.AppSettings["PASSWORD_SHARE"];
        private string m_str_link_old;

        #endregion

        #region Private Method
        private void format_control()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            m_lbl_tieu_de.Font = new System.Drawing.Font("Tahoma", 15, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            m_chk_close_form.Font = new System.Drawing.Font("Tahoma", 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            m_chk_close_form.ForeColor = Color.Maroon;
            load_data_2_cbo();
            load_cbo_loai_de_xuat();
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
            v_us.FillDataset(v_ds,"order by ten_phong_ban ");
            m_cbo_trung_tam.DataSource = v_ds.DM_PHONG_BAN;
            m_cbo_trung_tam.ValueMember = DM_PHONG_BAN.ID;
            m_cbo_trung_tam.DisplayMember = DM_PHONG_BAN.TEN_PHONG_BAN;
        }
        private void load_cbo_loai_de_xuat()
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            v_us.FillDataset(v_ds,"where id_loai_tu_dien ="+17);
            m_cbo_loai_de_xuat.DataSource = v_ds.CM_DM_TU_DIEN;
            m_cbo_loai_de_xuat.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_loai_de_xuat.DisplayMember = CM_DM_TU_DIEN.TEN_NGAN;
        }
        private void us_obj_2_form(US_V_GD_DE_XUAT ip_us_v)
        {
            m_us.dcID = ip_us_v.dcID;
            m_cbo_trung_tam.SelectedValue = ip_us_v.dcID_PHONG_BAN;
            m_txt_so_tien.Text = CIPConvert.ToStr(ip_us_v.dcSO_TIEN, "#,##0");
            m_txt_ghi_chu.Text = ip_us_v.strGHI_CHU;
            m_cbo_loai_de_xuat.Text = ip_us_v.strLOAI_DE_XUAT;
            m_dtp_thang.Text = ip_us_v.datTHANG_AP_DUNG.ToString("MM/yyyy");
            if (ip_us_v.strLINK != null || ip_us_v.strLINK != "")
            {
                m_lbl_file_name.Text = ip_us_v.strLINK;
            }
            else
                m_lbl_file_name.Text = "Hiện tại chưa có file đính kèm";
        }
        private void form_2_us_obj()
        {
            m_us.dcID_PHONG_BAN = CIPConvert.ToDecimal(m_cbo_trung_tam.SelectedValue);
            m_us.dcSO_TIEN = CIPConvert.ToDecimal(m_txt_so_tien.Text.Trim().Replace(",", "").Replace(".", ""));
            m_us.strGHI_CHU = m_txt_ghi_chu.Text;
            m_us.datTHANG_AP_DUNG = CIPConvert.ToDatetime("01/" + m_dtp_thang.Text, "dd/MM/yyyy");
            m_us.dcID_LOAI_DE_XUAT = CIPConvert.ToDecimal(m_cbo_loai_de_xuat.SelectedValue);
        }
        private void save_data()
        {
            if (!validate_data_is_ok())
                return;
            form_2_us_obj();
            #region Xử lý file đính kèm
            switch (m_e_file_mode)
            {
                case DataEntryFileMode.UploadFile:
                    // Kiểm tra file đã tồn tại trên server hay chưa
                    if (FileExplorer.IsExistedFile(m_str_directory_to + FileExplorer.fileName))
                    {
                        BaseMessages.MsgBox_Infor("Tên file đã tồn tại. Vui lòng đổi tên khác");
                        return;
                    }

                    // Nếu đã chọn file 
                    if (m_lbl_file_name.Text != "")
                    {
                        // Upload server có sử dụng user và pass
                        if (m_str_user_name != "")
                            FileExplorer.UploadFile(m_str_domain, m_str_directory_to, m_str_user_name, m_str_password);
                        // Upload không sử dụng user và pass
                        else
                            FileExplorer.UploadFile(m_str_domain, m_str_directory_to);
                    }
                    break;
                case DataEntryFileMode.EditFile:
                    // Nếu ko up lên file mới sẽ bỏ qua bước này
                    if (m_str_link_old != m_lbl_file_name.Text)
                    {
                        // Kiểm tra file vừa upload đã tồn tại hay chưa
                        if (FileExplorer.IsExistedFile(m_str_directory_to + FileExplorer.fileName))
                        {
                            BaseMessages.MsgBox_Infor("Tên file đã tồn tại. Vui lòng đổi tên khác");
                            return;
                        }

                        // Xóa file cũ
                        if (FileExplorer.IsExistedFile(m_str_directory_to + m_str_link_old))
                            FileExplorer.DeleteFile(m_str_directory_to + m_str_link_old);

                        // Upload file mới lên
                        if (m_str_user_name != "")
                            FileExplorer.UploadFile(m_str_domain, m_str_directory_to, m_str_user_name, m_str_password);
                        else
                            FileExplorer.UploadFile(m_str_domain, m_str_directory_to);
                    }
                    break;
                case DataEntryFileMode.DeleteFile:
                    // Kiểm tra file có tồn tại hay không
                    if (FileExplorer.IsExistedFile(m_str_directory_to + m_str_link_old))
                        FileExplorer.DeleteFile(m_str_directory_to + m_str_link_old);
                    else
                        MessageBox.Show("Hiện tại không có file đính kèm nào.\n Bạn không thể xóa!");
                    break;
            }
            #endregion
            //insert vào cơ sở dữ liệu
            m_us.strLINK = m_lbl_file_name.Text;
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
            m_cmd_file_dinh_kem.Click +=m_cmd_file_dinh_kem_Click;
            m_cmd_xoa_file.Click +=m_cmd_xoa_file_Click;
            m_cmd_xem_file.Click +=m_cmd_xem_file_Click;
        }

        private void chon_file()
        {
            FileExplorer.SelectFile(m_ofd_chon_file,m_str_link_old);
            m_lbl_file_name.Text = FileExplorer.fileName;
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
        private void m_cmd_file_dinh_kem_Click(object sender, System.EventArgs e)
        {
            try
            {
                chon_file();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_xem_file_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (m_lbl_file_name.Text.Trim() != "")
                {
                    SaveFileDialog save_dlg = new SaveFileDialog();
                    save_dlg.InitialDirectory = Convert.ToString(Environment.SpecialFolder.MyDocuments);
                    save_dlg.Filter = "Your extension here (*.PDF)|*.pdf|(*.XLSX)|*.xlsx|(*.DOCX)|*.docx|All Files (*.*)|*.*";
                    save_dlg.FilterIndex = 1;
                    string oldPathAndName = "D:\\File_de_xuat\\" + m_lbl_file_name.Text.Trim();
                    if (save_dlg.ShowDialog() == DialogResult.OK)
                    {
                        string newPathAndName = save_dlg.FileName;
                        System.IO.File.Copy(oldPathAndName, newPathAndName);
                        MessageBox.Show("Bạn đã lưu file thành công","Thông báo");
                    }
                }
                else
                    MessageBox.Show("Chưa có file đính kèm\n Bạn không thể tải về","Thông báo");
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_xoa_file_Click(object sender, System.EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa file đính kèm không?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    m_e_file_mode = DataEntryFileMode.DeleteFile;
                    m_str_link_old = m_lbl_file_name.Text;
                    m_lbl_file_name.Text = "";
                    save_data();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            
            }
            catch (System.Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion  
    }
}
