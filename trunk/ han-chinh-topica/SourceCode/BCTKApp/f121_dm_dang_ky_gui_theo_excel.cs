using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using IP.Core.IPExcelReport;

using BCTKDS;
using BCTKUS;
using System.Collections;
using BCTKDS.CDBNames;
using IP.Core.IPSystemAdmin;
using IP.Core.IPException;
using System.Globalization;

namespace BCTKApp
{
    public partial class f121_dm_dang_ky_gui_theo_excel : Form
    {
        public f121_dm_dang_ky_gui_theo_excel()
        {
            InitializeComponent();
            format_controls();
        }
        #region Public Method
        public void Display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            NGUOI_GUI = 8
                ,
            NUOC_NGOAI = 6
                ,
            NGUOI_NHAN = 4
                ,
            NOI_NHAN = 3
                ,
            STT = 1
                ,
            TRONG_NUOC = 5
                ,
            GHI_CHU = 10
                ,
            NOI_DUNG = 2
                ,
            SO_BILL = 7
                ,
            MA_PHONG_BAN = 11
                , NGAY_GUI = 9,
            TRANG_THAI = 12

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_CM_DM_DANG_KY_GUI_DANH_SACH_TUNG_PHONG m_ds = new DS_CM_DM_DANG_KY_GUI_DANH_SACH_TUNG_PHONG();
        US_CM_DM_DANG_KY_GUI_DANH_SACH_TUNG_PHONG m_us = new US_CM_DM_DANG_KY_GUI_DANH_SACH_TUNG_PHONG();
        US_CM_DM_DANG_KY_GUI m_us_dm_dang_ky_gui = new US_CM_DM_DANG_KY_GUI();
        US_V_HT_LOG_TRUY_CAP m_us_v_ht_log_truy_cap = new US_V_HT_LOG_TRUY_CAP();
        int m_i_flag = 0;
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
            CControlFormat.setC1FlexFormat(m_fg_load_file);
            m_lbl_loading.Visible = false;
            CGridUtils.AddSave_Excel_Handlers(m_fg_load_file);
            set_define_event();
            this.KeyPreview = true;
            m_lbl_title.Font = new Font("Arial", 16);
            m_lbl_title.ForeColor = Color.DarkRed;
            m_lbl_title.TextAlign = ContentAlignment.MiddleCenter;
            this.m_cmd_load_ds.Focus();
        }
        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object();
        }
        private void ghi_log_he_thong()
        {
            /* Thông tin chung*/
            m_us_v_ht_log_truy_cap.dcID_DANG_NHAP = CAppContext_201.getCurrentUserID();
            m_us_v_ht_log_truy_cap.datTHOI_GIAN = DateTime.Now;
            //m_us_v_ht_log_truy_cap.strDOI_TUONG_THAO_TAC = LOG_DOI_TUONG_TAC_DONG.DM_TRAI_CHU;
            m_us_v_ht_log_truy_cap.dcID_LOAI_HANH_DONG = LOG_TRUY_CAP.IMPORT;
            //m_us_v_ht_log_truy_cap.strMO_TA = "Import " + LOG_DOI_TUONG_TAC_DONG.DM_TRAI_CHU;

            // ghi log hệ thống
            try
            {
                m_us_v_ht_log_truy_cap.Insert();
            }
            catch
            {
                BaseMessages.MsgBox_Infor("Đã xảy ra lỗi trong quá trình ghi log hệ thống");
            }
        }
        private ITransferDataRow get_trans_object()
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(CM_DM_DANG_KY_GUI_DANH_SACH_TUNG_PHONG.NGUOI_GUI, e_col_Number.NGUOI_GUI);
            v_htb.Add(CM_DM_DANG_KY_GUI_DANH_SACH_TUNG_PHONG.NUOC_NGOAI, e_col_Number.NUOC_NGOAI);
            v_htb.Add(CM_DM_DANG_KY_GUI_DANH_SACH_TUNG_PHONG.NGUOI_NHAN, e_col_Number.NGUOI_NHAN);
            v_htb.Add(CM_DM_DANG_KY_GUI_DANH_SACH_TUNG_PHONG.NOI_NHAN, e_col_Number.NOI_NHAN);
            v_htb.Add(CM_DM_DANG_KY_GUI_DANH_SACH_TUNG_PHONG.STT, e_col_Number.STT);
            v_htb.Add(CM_DM_DANG_KY_GUI_DANH_SACH_TUNG_PHONG.TRONG_NUOC, e_col_Number.TRONG_NUOC);
            v_htb.Add(CM_DM_DANG_KY_GUI_DANH_SACH_TUNG_PHONG.GHI_CHU, e_col_Number.GHI_CHU);
            v_htb.Add(CM_DM_DANG_KY_GUI_DANH_SACH_TUNG_PHONG.NOI_DUNG, e_col_Number.NOI_DUNG);
            v_htb.Add(CM_DM_DANG_KY_GUI_DANH_SACH_TUNG_PHONG.SO_BILL, e_col_Number.SO_BILL);
            v_htb.Add(CM_DM_DANG_KY_GUI_DANH_SACH_TUNG_PHONG.MA_PHONG_BAN, e_col_Number.MA_PHONG_BAN);
            v_htb.Add(CM_DM_DANG_KY_GUI_DANH_SACH_TUNG_PHONG.NGAY_GUI, e_col_Number.NGAY_GUI);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(m_fg_load_file, v_htb, m_ds.CM_DM_DANG_KY_GUI_DANH_SACH_TUNG_PHONG.NewCM_DM_DANG_KY_GUI_DANH_SACH_TUNG_PHONGRow());
            return v_obj_trans;
        }
        private void load_danh_sach_excel()
        {
            if (m_dgl_open_file.ShowDialog() == DialogResult.OK)
            {
                string v_str_path_and_file_name = m_dgl_open_file.FileName;
                string v_str_file_name = v_str_path_and_file_name.Substring(v_str_path_and_file_name.LastIndexOf("\\") + 1, v_str_path_and_file_name.Length - v_str_path_and_file_name.LastIndexOf("\\") - 1);
                CExcelReport v_xls_file = new CExcelReport(v_str_path_and_file_name);
                DS_CM_DM_DANG_KY_GUI_DANH_SACH_TUNG_PHONG v_ds_cm_dm_dang_ky_gui_danh_sach_tung_phong = new DS_CM_DM_DANG_KY_GUI_DANH_SACH_TUNG_PHONG();
                try
                {
                    m_lbl_loading.Visible = true;
                    v_ds_cm_dm_dang_ky_gui_danh_sach_tung_phong.EnforceConstraints = false;
                    v_xls_file.Export2DatasetDSPhongThi(v_ds_cm_dm_dang_ky_gui_danh_sach_tung_phong, v_ds_cm_dm_dang_ky_gui_danh_sach_tung_phong.CM_DM_DANG_KY_GUI_DANH_SACH_TUNG_PHONG.TableName, 2);

                    //DataSet v_ds_cm_dm_bang_modify = ModifyDateToUSFormat(v_ds_cm_dm_bang_chi_tiet_cuoi_thang);
                    CGridUtils.Dataset2C1Grid(v_ds_cm_dm_dang_ky_gui_danh_sach_tung_phong, m_fg_load_file, m_obj_trans);
                    m_i_flag = 0;
                    m_lbl_tong_so_luong.Text = CIPConvert.ToStr(m_fg_load_file.Rows.Count - 1);
                    m_lbl_loading.Visible = false;
                }
                catch (Exception v_e)
                {
                    if (v_e.Message.ToString() == "Cannot set Column 'STT' to be null. Please use DBNull instead.")
                        BaseMessages.MsgBox_Error(THONG_BAO.ER_COT_STT_DE_TRONG);
                    else CSystemLog_301.ExceptionHandle(v_e);
                }
            }
        }
        private bool chua_load_file_excel()
        {
            if (m_dgl_open_file.FileName != "") return false;
            return true;
        }
        private void kiem_tra_data_tren_luoi()
        {
            // kiem tra so luong hoc vien
            if (m_fg_load_file.Rows.Count <= 1) return;
            // kiem tra du lieu tren luoi
            try
            {

                C1.Win.C1FlexGrid.CellStyle v_cell_style_err = this.m_fg_load_file.Styles.Add("RowColorErr");
                v_cell_style_err.BackColor = Color.Red;
                C1.Win.C1FlexGrid.CellStyle v_cell_style = this.m_fg_load_file.Styles.Add("RowColor");
                v_cell_style.BackColor = Color.White;

                C1.Win.C1FlexGrid.CellStyle v_cell_style_ok = this.m_fg_load_file.Styles.Add("RowColorOk");
                v_cell_style_ok.BackColor = Color.White;
                C1.Win.C1FlexGrid.CellStyle v_cell_style_chu_ok = this.m_fg_load_file.Styles.Add("RowColor");
                v_cell_style_chu_ok.BackColor = Color.Black;

                C1.Win.C1FlexGrid.CellStyle v_cell_style_notOK_in_data = this.m_fg_load_file.Styles.Add("RowColorNotOk");
                v_cell_style_notOK_in_data.BackColor = Color.Green;

                C1.Win.C1FlexGrid.CellStyle v_cell_style_hai_o_trung_nhau = this.m_fg_load_file.Styles.Add("RowColor");
                v_cell_style_hai_o_trung_nhau.BackColor = Color.Yellow;

                for (int i_stt = 1; i_stt <= m_fg_load_file.Rows.Count - 1; i_stt++)
                {
                    string v_dien_giai = "";

                    // 1. kiểm tra thông tin 
                    if (m_fg_load_file[i_stt, (int)e_col_Number.SO_BILL] != null)
                    {
                        v_dien_giai = "";
                        m_fg_load_file.SetCellStyle(i_stt, (int)e_col_Number.SO_BILL, v_cell_style_ok);

                    }
                    else
                    {
                        v_dien_giai = "Số bưu không được để trống ";
                        m_fg_load_file.SetCellStyle(i_stt, (int)e_col_Number.SO_BILL, v_cell_style_err);
                    }
                    
                    // gan gia tri cho cot kiem tra
                    if (v_dien_giai != "")
                    {
                        m_fg_load_file[i_stt, (int)e_col_Number.TRANG_THAI] = "Không đạt";
                        m_fg_load_file.SetCellStyle(i_stt, (int)e_col_Number.STT, v_cell_style_notOK_in_data);
                    }
                    else m_fg_load_file[i_stt, (int)e_col_Number.TRANG_THAI] = "Đạt";
                }
                //Kiểm tra xem có đạt toàn bộ không
                decimal v_count_ = 0;
                for (int i_stt = 1; i_stt <= m_fg_load_file.Rows.Count - 1; i_stt++)
                {
                    if (m_fg_load_file[i_stt, (int)e_col_Number.TRANG_THAI] != null)
                    {
                        if (CIPConvert.ToStr(m_fg_load_file[i_stt, (int)e_col_Number.TRANG_THAI]) == "Đạt")
                        {
                            v_count_ = v_count_ + 1;
                        }
                    }
                }
                // 
                if (v_count_ == m_fg_load_file.Rows.Count - 1)
                {
                    m_i_flag = 1; // là đạt toàn bộ
                }
                else
                {
                    m_i_flag = 0;//không đạt toàn bộ
                    BaseMessages.MsgBox_Infor("Dữ liệu chưa hợp lý. Ô có màu xanh cho biết dòng nào chưa hợp lý, ô màu đỏ biểu thị dữ liệu tại ô đó trong file excel là trống .Hãy kiểm tra lại");
                }
                //Kiểm tra xem trong excel có 2 bản nào có bill trùng nhau không
                decimal v_trung = 0;
                for (int i_stt = 1; i_stt <= m_fg_load_file.Rows.Count - 1; i_stt++)
                {
                    if (CIPConvert.ToStr(m_fg_load_file[i_stt, (int)e_col_Number.TRANG_THAI]) == "Đạt")
                    {
                        for (int i_in_stt = i_stt + 1; i_in_stt <= m_fg_load_file.Rows.Count - 1; i_in_stt++)
                        {
                            if (CIPConvert.ToStr(m_fg_load_file[i_in_stt, (int)e_col_Number.TRANG_THAI]) == "Đạt")
                            {
                                if (nullToString((string)m_fg_load_file[i_stt, (int)e_col_Number.SO_BILL].ToString()) == nullToString((string)m_fg_load_file[i_in_stt, (int)e_col_Number.SO_BILL].ToString()))
                                {
                                    m_fg_load_file.SetCellStyle(i_stt, (int)e_col_Number.SO_BILL, v_cell_style_hai_o_trung_nhau);
                                    m_fg_load_file.SetCellStyle(i_in_stt, (int)e_col_Number.SO_BILL, v_cell_style_hai_o_trung_nhau);
                                    v_trung++;
                                }
                            }
                        }
                    }
                }
                if (v_trung >= 1)
                {
                    m_i_flag = 0;
                    BaseMessages.MsgBox_Infor("Có 2 ô có số bill bị trùng nhau.Hãy sửa lại file excel cho");
                }
            }
            catch (Exception v_e)
            {
                throw v_e;
            }

        }
        private bool kiem_tra_su_ton_tai_trong_co_so_du_lieu(string ip_str_ma_so)
        {
            if (dem_so_dong_bang_lay_boi_ma_so_bill(ip_str_ma_so) >= 1) return true;
            return false;
        }
        private int dem_so_dong_bang_lay_boi_ma_so_bill(string ip_str_ma_so)
        {
            int v_int_count = 0;
            DS_CM_DM_DANG_KY_GUI v_ds_cm_dm_dang_ky_gui = new DS_CM_DM_DANG_KY_GUI();
            m_us_dm_dang_ky_gui = new US_CM_DM_DANG_KY_GUI();
            m_us_dm_dang_ky_gui.load_dm_by_so_bill(v_ds_cm_dm_dang_ky_gui, nullToString(ip_str_ma_so));
            DataTable v_dt = v_ds_cm_dm_dang_ky_gui.Tables[0];
            v_int_count = v_dt.Rows.Count;
            return v_int_count;
        }
        public string nullToString(string value)
        {
            return value == null ? string.Empty : value;
        }
        private bool kiem_tra_su_ton_tai_mot_dong_tren_luoi_trong_du_lieu()
        {
            C1.Win.C1FlexGrid.CellStyle v_cell_style_exist = this.m_fg_load_file.Styles.Add("RowColorErr");
            v_cell_style_exist.BackColor = Color.Pink;
            decimal v_count_ = 0;
            for (int i_stt = 1; i_stt <= m_fg_load_file.Rows.Count - 1; i_stt++)
            {
                if (kiem_tra_su_ton_tai_trong_co_so_du_lieu((string)m_fg_load_file[i_stt, (int)e_col_Number.SO_BILL]))
                {
                    v_count_ = v_count_ + 1;
                    m_fg_load_file.SetCellStyle(i_stt, (int)e_col_Number.SO_BILL, v_cell_style_exist);
                }
            }
            // 
            if (v_count_ >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        private void add_danh_sach_du_lieu()
        {
            try
            {
                m_lbl_loading.Visible = true;
                m_us.BeginTransaction();
                for (int v_int_row = m_fg_load_file.Rows.Fixed; v_int_row <= m_fg_load_file.Rows.Count - 1; v_int_row++)
                {
                    //IFormatProvider theCultureInfo = new System.Globalization.CultureInfo("en-GB", true);

                    //DateTime theDateTime = DateTime.ParseExact(abc, "mm-dd-yyyy", theCultureInfo);

                    DS_CM_DM_DANG_KY_GUI v_ds_dm_dang_ky_gui = new DS_CM_DM_DANG_KY_GUI();
                    US_CM_DM_DANG_KY_GUI v_us_dm_dang_ky_gui = new US_CM_DM_DANG_KY_GUI();
                    v_us_dm_dang_ky_gui.strNOI_DUNG = nullToString((string)m_fg_load_file[v_int_row, (int)e_col_Number.NOI_DUNG]);
                    v_us_dm_dang_ky_gui.strNOI_NHAN = nullToString((string)m_fg_load_file[v_int_row, (int)e_col_Number.NOI_NHAN]);
                    v_us_dm_dang_ky_gui.strNGUOI_NHAN = nullToString((string)m_fg_load_file[v_int_row, (int)e_col_Number.NGUOI_NHAN]);
                    v_us_dm_dang_ky_gui.strTRONG_NUOC = nullToString((string)m_fg_load_file[v_int_row, (int)e_col_Number.TRONG_NUOC]);
                    v_us_dm_dang_ky_gui.strNUOC_NGOAI = nullToString((string)m_fg_load_file[v_int_row, (int)e_col_Number.NUOC_NGOAI]);
                    v_us_dm_dang_ky_gui.strSO_BILL = CIPConvert.ToStr(m_fg_load_file[v_int_row, (int)e_col_Number.SO_BILL]);
                    v_us_dm_dang_ky_gui.strNGUOI_GUI = nullToString((string)m_fg_load_file[v_int_row, (int)e_col_Number.NGUOI_GUI]);
                    v_us_dm_dang_ky_gui.datNGAY_GUI = Convert.ToDateTime(m_fg_load_file[v_int_row, (int)e_col_Number.NGAY_GUI].ToString());
                    v_us_dm_dang_ky_gui.strGHI_CHU = nullToString((string)m_fg_load_file[v_int_row, (int)e_col_Number.GHI_CHU]);
                    v_us_dm_dang_ky_gui.dcPHONG_BAN_ID = CIPConvert.ToDecimal(m_cbo_phong_ban.SelectedValue.ToString());
                    v_us_dm_dang_ky_gui.Insert();
                }
                m_us.CommitTransaction();
                m_lbl_loading.Visible = false;
                ghi_log_he_thong();
                BaseMessages.MsgBox_Infor("Đã import dữ liệu nhận từ Bưu cục thành công");
            }
            catch (Exception v_e)
            {

                m_us.Rollback();
                CDBExceptionHandler v_exceptionHander = new CDBExceptionHandler(v_e,
                    new CDBClientDBExceptionInterpret());
                v_exceptionHander.showErrorMessage();
            }
        }
        private void load_data_2_cbo_phong_ban()
        {
            DS_CM_DM_TU_DIEN v_ds_cm_dm_tu_dien = new DS_CM_DM_TU_DIEN();
            US_CM_DM_TU_DIEN v_us_cm_dm_tu_dien = new US_CM_DM_TU_DIEN();
            v_us_cm_dm_tu_dien.FillDataset(v_ds_cm_dm_tu_dien, "WHERE ID_LOAI_TU_DIEN = 11 ORDER BY MA_TU_DIEN");
            DataRow v_dr_all = v_ds_cm_dm_tu_dien.CM_DM_TU_DIEN.NewCM_DM_TU_DIENRow();
            v_dr_all[CM_DM_TU_DIEN.ID] = 0;
            v_dr_all[CM_DM_TU_DIEN.MA_TU_DIEN] = "TAT_CA";
            v_dr_all[CM_DM_TU_DIEN.ID_LOAI_TU_DIEN] = 11;
            v_dr_all[CM_DM_TU_DIEN.TEN_NGAN] = "";
            v_dr_all[CM_DM_TU_DIEN.TEN] = "Hãy chọn 1 phòng ban";
            v_ds_cm_dm_tu_dien.CM_DM_TU_DIEN.Rows.InsertAt(v_dr_all, 0);
            m_cbo_phong_ban.ValueMember = v_ds_cm_dm_tu_dien.CM_DM_TU_DIEN.IDColumn.ToString();
            m_cbo_phong_ban.DisplayMember = v_ds_cm_dm_tu_dien.CM_DM_TU_DIEN.TENColumn.ToString();
            m_cbo_phong_ban.DataSource = v_ds_cm_dm_tu_dien.CM_DM_TU_DIEN;

        }	
        #endregion

        //
        // Event Handlers
        //
        private void set_define_event()
        {
            m_cmd_thoat.Click += new EventHandler(m_cmd_thoat_Click);
            m_cmd_luu.Click += new EventHandler(m_cmd_luu_Click);
            m_cmd_kiem_tra.Click += new EventHandler(m_cmd_kiem_tra_Click);
            m_cmd_load_ds.Click += new EventHandler(m_cmd_load_ds_Click);
            this.Load += new EventHandler(f121_dm_dang_ky_gui_theo_excel_Load);
        }
        void f121_dm_dang_ky_gui_theo_excel_Load(object sender, EventArgs e)
        {
            try
            {
                set_initial_form_load();
                load_data_2_cbo_phong_ban();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void m_cmd_load_ds_Click(object sender, EventArgs e)
        {
            try
            {
                load_danh_sach_excel();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void m_cmd_kiem_tra_Click(object sender, EventArgs e)
        {
            try
            {
                if (chua_load_file_excel())
                {
                    BaseMessages.MsgBox_Infor("Bạn chưa load file Excel");
                    return;
                }
                kiem_tra_data_tren_luoi();
                if (m_i_flag == 1) BaseMessages.MsgBox_Infor("Dữ liệu đã được kiểm tra");
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void m_cmd_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (chua_load_file_excel())
                {
                    BaseMessages.MsgBox_Infor("Bạn chưa load file Exel dữ liệu !");
                    return;
                }
                if (CIPConvert.ToDecimal(m_cbo_phong_ban.SelectedValue.ToString()) == 0)
                {
                    BaseMessages.MsgBox_Infor("Bạn hãy chọn 1 phòng ban");
                    return;
                }
                if (m_i_flag == 0) return;
                if (kiem_tra_su_ton_tai_mot_dong_tren_luoi_trong_du_lieu())
                {
                    BaseMessages.MsgBox_Infor("Dữ liệu đã tồn tại trong kho dữ liệu.Ô có màu hồng biểu thị dòng dữ liệu đã tồn tại trong kho dữ liệu.");
                    return;
                }
                add_danh_sach_du_lieu();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void m_cmd_thoat_Click(object sender, EventArgs e)
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
    }
}
