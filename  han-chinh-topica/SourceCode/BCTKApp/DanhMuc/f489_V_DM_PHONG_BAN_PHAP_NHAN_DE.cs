using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;
using IP.Core.IPSystemAdmin;
using IP.Core.IPExcelReport;

using BCTKUS;
using BCTKDS;
using BCTKDS.CDBNames;

using BCTKApp.DanhMuc;
namespace BCTKApp.DanhMuc {
    public partial class f489_V_DM_PHONG_BAN_PHAP_NHAN_DE : Form {


        #region Public interface

        public void Display() {
            m_e = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }

        public void display(BCTKUS.US_V_DM_PHONG_BAN_PHAP_NHAN ip_v_m_us) {
            m_e = DataEntryFormMode.UpdateDataState;
            m_us_v = ip_v_m_us;
            m_us_obj_to_form();
            m_id = ip_v_m_us.dcID;
            m_cbo_phap_nhan.Enabled = true;
            this.ShowDialog();
        }
        #endregion

        #region Members
        US_DM_PHONG_BAN_PHAP_NHAN m_us = new US_DM_PHONG_BAN_PHAP_NHAN();
        DS_DM_PHONG_BAN_PHAP_NHAN m_ds = new DS_DM_PHONG_BAN_PHAP_NHAN();
        DS_V_DM_PHONG_BAN_PHAP_NHAN m_ds_v = new DS_V_DM_PHONG_BAN_PHAP_NHAN();
        US_V_DM_PHONG_BAN_PHAP_NHAN m_us_v = new US_V_DM_PHONG_BAN_PHAP_NHAN();
        decimal m_id;
        DataEntryFormMode m_e = new DataEntryFormMode();
        #endregion

        #region Private method
        private void format_control() {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            // m_lbl_header
            // 
            this.m_lbl_header.AutoSize = true;
            this.m_lbl_header.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(96, 9);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(175, 19);
            this.m_lbl_header.TabIndex = 0;
            this.m_lbl_header.Text = "CẬP NHẬT THÔNG TIN";
            // 
            // m_lbl_header2
            // 
            this.m_lbl_header2.AutoSize = true;
            this.m_lbl_header2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_header2.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header2.Location = new System.Drawing.Point(65, 28);
            this.m_lbl_header2.Name = "m_lbl_header2";
            this.m_lbl_header2.Size = new System.Drawing.Size(242, 19);
            this.m_lbl_header2.TabIndex = 0;
            this.m_lbl_header2.Text = " TRUNG TÂM THEO PHÁP NHÂN";
            // 
            load_cbo_phap_nhan();
            load_cbo_trung_tam();
        }
        private void m_us_obj_to_form() {
            m_cbo_phap_nhan.Text = m_us_v.strTEN_PHAP_NHAN;
            m_cbo_trung_tam.Text = m_us_v.strTEN_PHONG_BAN;
            m_txt_ty_trong.Text = CIPConvert.ToStr(m_us_v.dcTY_TRONG, "#,#");
        }

        private void m_form_to_us_obj() {
            m_us.dcID_PHAP_NHAN = CIPConvert.ToDecimal(m_cbo_phap_nhan.SelectedValue);
            m_us.dcID_PHONG_BAN = CIPConvert.ToDecimal(m_cbo_trung_tam.SelectedValue);
            m_us.dcTY_TRONG = CIPConvert.ToDecimal(m_txt_ty_trong.Text.Trim());
        }
        private void load_cbo_phap_nhan() {
            US_DM_PHAP_NHAN v_us = new US_DM_PHAP_NHAN();
            DS_DM_PHAP_NHAN v_ds = new DS_DM_PHAP_NHAN();
            v_us.FillDataset(v_ds);
            m_cbo_phap_nhan.DataSource = v_ds.DM_PHAP_NHAN;
            m_cbo_phap_nhan.ValueMember = DM_PHAP_NHAN.ID;
            m_cbo_phap_nhan.DisplayMember = DM_PHAP_NHAN.TEN_PHAP_NHAN;
            //DataRow v_dr = v_ds.Tables[0].NewRow();
            //v_dr[DM_PHAP_NHAN.ID] = -1;
            //v_dr[DM_PHAP_NHAN.MA_PHAP_NHAN] = "";
            //v_dr[DM_PHAP_NHAN.TEN_PHAP_NHAN] = "Tất cả";
            //v_ds.DM_PHAP_NHAN.Rows.InsertAt(v_dr, 0);
            m_cbo_phap_nhan.SelectedIndex = 0;
        }
        private void load_cbo_trung_tam() {
            US_DM_PHONG_BAN v_us = new US_DM_PHONG_BAN();
            DS_DM_PHONG_BAN v_ds = new DS_DM_PHONG_BAN();
            v_us.FillDataset(v_ds);
            m_cbo_trung_tam.DataSource = v_ds.DM_PHONG_BAN;
            m_cbo_trung_tam.ValueMember = DM_PHONG_BAN.ID;
            m_cbo_trung_tam.DisplayMember = DM_PHONG_BAN.TEN_PHONG_BAN;
            //DataRow v_dr = v_ds.DM_PHONG_BAN.NewRow();
            //v_dr[DM_PHONG_BAN.ID] = -1;
            //v_dr[DM_PHONG_BAN.MA_PHONG_BAN] = "Tất cả";
            //v_dr[DM_PHONG_BAN.TEN_PHONG_BAN] = "Tất cả";
            //v_ds.DM_PHONG_BAN.Rows.InsertAt(v_dr, 0);
            m_cbo_trung_tam.SelectedIndex = 0;
        }
        private void save_data() {
            if(!validate_data_is_ok()) { BaseMessages.MsgBox_Error("Bạn chưa nhập tỷ trọng!"); m_txt_ty_trong.Focus(); return; }
            m_form_to_us_obj();
            switch(m_e) {
                case DataEntryFormMode.InsertDataState:
                    if(!check_trung_tam(CIPConvert.ToDecimal(m_cbo_trung_tam.SelectedValue), CIPConvert.ToDecimal(m_cbo_phap_nhan.SelectedValue))) {
                        BaseMessages.MsgBox_Error("Đã tồn tại trung tâm của pháp nhân này!");
                        return;
                    }
                    if(!check_100_phan_tram_phap_nhan(CIPConvert.ToDecimal(m_cbo_trung_tam.SelectedValue), CIPConvert.ToDecimal(m_cbo_phap_nhan.SelectedValue))) {
                        BaseMessages.MsgBox_Error("Tổng tỷ trọng các trung tâm trong pháp nhân đã quá 100%, đề nghị sửa lại!");
                        return;
                    }
                    m_us.Insert();
                    BaseMessages.MsgBox_Infor("Thêm mới thành công!");
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us.dcID = m_id;
                    if(!check_100_phan_tram_phap_nhan(CIPConvert.ToDecimal(m_cbo_trung_tam.SelectedValue), CIPConvert.ToDecimal(m_cbo_phap_nhan.SelectedValue))) {
                        BaseMessages.MsgBox_Error("Tổng tỷ trọng các trung tâm trong pháp nhân đã quá 100%, đề nghị sửa lại!");
                        return;
                    }
                    m_us.Update();
                    BaseMessages.MsgBox_Infor("Cập nhật thành công!");
                    break;
                default: m_us.Insert();
                    break;
            }
            this.Close();
        }
        private bool check_trung_tam(decimal ip_id_trung_tam, decimal ip_id_phap_nhan) {
            US_V_DM_PHONG_BAN_PHAP_NHAN v_us = new US_V_DM_PHONG_BAN_PHAP_NHAN();
            DS_V_DM_PHONG_BAN_PHAP_NHAN v_ds = new DS_V_DM_PHONG_BAN_PHAP_NHAN();
            v_us.FillDataset(v_ds, "where id_phong_ban=" + ip_id_trung_tam + "and id_phap_nhan =" + ip_id_phap_nhan);
            if (v_ds.Tables[0].Rows.Count != 0)
                return false;
            else
            return true;
        }
        private bool check_100_phan_tram_phap_nhan(decimal ip_id_phong_ban, decimal ip_id_phap_nhan) {
            DS_DM_PHONG_BAN_PHAP_NHAN v_ds = new DS_DM_PHONG_BAN_PHAP_NHAN();
            US_DM_PHONG_BAN_PHAP_NHAN v_us = new US_DM_PHONG_BAN_PHAP_NHAN();
            v_us.FillDataset(v_ds, "where ID_PHONG_BAN = " + ip_id_phong_ban);
            switch(m_e) {
                case DataEntryFormMode.InsertDataState:
                    decimal tong_phan_tram_insert = CIPConvert.ToDecimal(m_txt_ty_trong.Text);
                    foreach(DataRow v_dr in v_ds.DM_PHONG_BAN_PHAP_NHAN.Rows) {
                        tong_phan_tram_insert = tong_phan_tram_insert + CIPConvert.ToDecimal(v_dr["TY_TRONG"].ToString());
                    }
                    if(tong_phan_tram_insert > 100) {
                        return false;
                    }
                    break;
                case DataEntryFormMode.UpdateDataState:
                    decimal tong_phan_tram_update = 0;
                    foreach(DataRow v_dr in v_ds.DM_PHONG_BAN_PHAP_NHAN.Rows) {
                        if(CIPConvert.ToDecimal(v_dr["ID_PHAP_NHAN"].ToString()) == ip_id_phap_nhan)
                            v_dr["TY_TRONG"] = m_txt_ty_trong.Text;
                        tong_phan_tram_update = tong_phan_tram_update + CIPConvert.ToDecimal(v_dr["TY_TRONG"].ToString());
                    }
                    if(tong_phan_tram_update > 100) {
                        return false;
                    }
                    break;
            }
            return true;
        }
        private bool check_ty_trong() {
            decimal num;
            bool isNumberic = decimal.TryParse(m_txt_ty_trong.Text, out num);

            if(!isNumberic) {
                return false;
            }
            else return true;
        }
        private bool validate_data_is_ok() {
            if(!CValidateTextBox.IsValid(m_txt_ty_trong, DataType.StringType, allowNull.NO, true))
                return false;
            return true;
        }
        #endregion

        #region Event
        public f489_V_DM_PHONG_BAN_PHAP_NHAN_DE() {
            InitializeComponent();
            format_control();
        }

        private void m_cmd_exit_Click(object sender, EventArgs e) {
            try {
                this.Close();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_save_Click(object sender, EventArgs e) {
            try {
                save_data();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_txt_ty_trong_KeyDown(object sender, KeyEventArgs e) {
            try {
                if(e.KeyData == Keys.Enter || e.KeyData == Keys.Tab) {
                    if(!check_ty_trong()) { BaseMessages.MsgBox_Error("Bạn phải nhập kiểu số"); m_txt_ty_trong.Text = "100"; m_txt_ty_trong.Focus(); return; }
                }
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_txt_ty_trong_Leave(object sender, EventArgs e) {
            try {
                if(!check_ty_trong()) { BaseMessages.MsgBox_Error("Bạn phải nhập kiểu số"); m_txt_ty_trong.Text = "100"; m_txt_ty_trong.Focus(); return; }
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void f489_V_DM_PHONG_BAN_PHAP_NHAN_DE_KeyDown(object sender, KeyEventArgs e){
            try {
                if(e.KeyData == Keys.Escape) {
                    this.Close();
                }
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion



    }
}
