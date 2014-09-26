using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPExcelReport;
using BCTKUS;
using BCTKUS;
using BCTKDS.CDBNames;
using System.Collections;
using System.Globalization;
using IP.Core.IPException;
using IP.Core.IPSystemAdmin;
using BCTKDS;

namespace BCTKApp {
    public partial class f876_so_sanh_chi_phi_cuoi_thang : Form {
        public f876_so_sanh_chi_phi_cuoi_thang() {
            InitializeComponent();
            format_controls();
        }

        //#region Public Method
        //#endregion

        //#region Data Structure
        //#endregion

        //#region Members
        //#endregion

        //#region Private Methods
        //#endregion

        ////
        //// Event Handlers
        ////

        #region Public Method
        public void Display() {
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
        private enum e_col_Number {
            NOIDEN = 5
                ,
            LOAI = 3
                ,
            TRLUONG = 6
                ,
            TIEN = 11
                ,
            SOCT = 1
                ,
            PHI = 8
                ,
            BARCODE = 4
                ,
            PHIXD = 9
                ,
            CUOC = 7
                ,
            NGAY = 2
                ,
            TIENCK = 10

                , GHICHU = 12,
            TRANG_THAI = 13,
            DIEN_GIAI = 14

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans_xls;
        DS_CM_DM_BANG_CHI_TIET_CUOI_THANG m_ds = new DS_CM_DM_BANG_CHI_TIET_CUOI_THANG();
        US_CM_DM_BANG_CHI_TIET_CUOI_THANG m_us = new US_CM_DM_BANG_CHI_TIET_CUOI_THANG();
        US_DM_BILL m_us_dm_bill = new US_DM_BILL();
        US_V_HT_LOG_TRUY_CAP m_us_v_ht_log_truy_cap = new US_V_HT_LOG_TRUY_CAP();
        // cờ dùng để xác định dữ liệu có ok hay ko? 0: ko ok; 1: ok
        int m_i_flag = 0;
        DataSet m_ds_temp = new DataSet();
        DataTable m_dt_temp = new DataTable();
        #endregion

        #region Private Methods
        private void format_controls() {
            CControlFormat.setFormStyle(this);
            CControlFormat.setC1FlexFormat(m_fg_load_file);
            m_lbl_loading.Visible = false;
            CGridUtils.AddSave_Excel_Handlers(m_fg_load_file);
            m_fg_load_file.AllowEditing = true;
            m_fg_load_file.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            m_fg_load_file.AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.None;
            m_fg_load_file.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcrossOut;
            m_fg_load_file.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcrossOut;
            CGridUtils.AddSave_Excel_Handlers(m_fg_load_file);
            set_define_event();

            this.KeyPreview = true;
        }
        private void set_initial_form_load() {
            m_dat_thang.Text = CIPConvert.ToStr(DateTime.Now.Date, "MM/yyyy");
            m_obj_trans_xls = get_2_us_obj_xls();
        }
        private void ghi_log_he_thong() {
            /* Thông tin chung*/
            m_us_v_ht_log_truy_cap.dcID_DANG_NHAP = CAppContext_201.getCurrentUserID();
            m_us_v_ht_log_truy_cap.datTHOI_GIAN = DateTime.Now;
            //m_us_v_ht_log_truy_cap.strDOI_TUONG_THAO_TAC = LOG_DOI_TUONG_TAC_DONG.DM_TRAI_CHU;
            m_us_v_ht_log_truy_cap.dcID_LOAI_HANH_DONG = LOG_TRUY_CAP.IMPORT;
            //m_us_v_ht_log_truy_cap.strMO_TA = "Import " + LOG_DOI_TUONG_TAC_DONG.DM_TRAI_CHU;

            // ghi log hệ thống
            try {
                m_us_v_ht_log_truy_cap.Insert();
            }
            catch {
                BaseMessages.MsgBox_Infor("Đã xảy ra lỗi trong quá trình ghi log hệ thống");
            }
        }
        private ITransferDataRow get_2_us_obj_xls() {
            Hashtable v_hst = new Hashtable();
            v_hst.Add(CM_DM_BANG_CHI_TIET_CUOI_THANG.NOIDEN, e_col_Number.NOIDEN);
            v_hst.Add(CM_DM_BANG_CHI_TIET_CUOI_THANG.SOCT, e_col_Number.SOCT);
            v_hst.Add(CM_DM_BANG_CHI_TIET_CUOI_THANG.LOAI, e_col_Number.LOAI);
            v_hst.Add(CM_DM_BANG_CHI_TIET_CUOI_THANG.TRLUONG, e_col_Number.TRLUONG);
            v_hst.Add(CM_DM_BANG_CHI_TIET_CUOI_THANG.TIEN, e_col_Number.TIEN);
            v_hst.Add(CM_DM_BANG_CHI_TIET_CUOI_THANG.PHI, e_col_Number.PHI);
            v_hst.Add(CM_DM_BANG_CHI_TIET_CUOI_THANG.BARCODE, e_col_Number.BARCODE);
            v_hst.Add(CM_DM_BANG_CHI_TIET_CUOI_THANG.PHIXD, e_col_Number.PHIXD);
            v_hst.Add(CM_DM_BANG_CHI_TIET_CUOI_THANG.CUOC, e_col_Number.CUOC);
            v_hst.Add(CM_DM_BANG_CHI_TIET_CUOI_THANG.NGAY, e_col_Number.NGAY);
            v_hst.Add(CM_DM_BANG_CHI_TIET_CUOI_THANG.TIENCK, e_col_Number.TIENCK);
            v_hst.Add(CM_DM_BANG_CHI_TIET_CUOI_THANG.GHICHU, e_col_Number.GHICHU);
            CC1TransferDataRow v_obj = new CC1TransferDataRow(m_fg_load_file, v_hst, m_ds.CM_DM_BANG_CHI_TIET_CUOI_THANG.NewCM_DM_BANG_CHI_TIET_CUOI_THANGRow());
            return v_obj;
        }
        private void load_danh_sach_excel() {
            if(m_dgl_open_file.ShowDialog() == DialogResult.OK) {
                string v_str_path_and_file_name = m_dgl_open_file.FileName;
                string v_str_file_name = v_str_path_and_file_name.Substring(v_str_path_and_file_name.LastIndexOf("\\") + 1, v_str_path_and_file_name.Length - v_str_path_and_file_name.LastIndexOf("\\") - 1);
                CExcelReport v_xls_file = new CExcelReport(v_str_path_and_file_name);
                DS_CM_DM_BANG_CHI_TIET_CUOI_THANG v_ds_cm_dm_bang_chi_tiet_cuoi_thang = new DS_CM_DM_BANG_CHI_TIET_CUOI_THANG();
                try {
                    m_lbl_loading.Visible = true;
                    v_ds_cm_dm_bang_chi_tiet_cuoi_thang.EnforceConstraints = false;
                    v_xls_file.Export2DatasetDSPhongThi(v_ds_cm_dm_bang_chi_tiet_cuoi_thang, v_ds_cm_dm_bang_chi_tiet_cuoi_thang.CM_DM_BANG_CHI_TIET_CUOI_THANG.TableName, 2);

                    //DataSet v_ds_cm_dm_bang_modify = ModifyDateToUSFormat(v_ds_cm_dm_bang_chi_tiet_cuoi_thang);
                    CGridUtils.Dataset2C1Grid(v_ds_cm_dm_bang_chi_tiet_cuoi_thang, m_fg_load_file, m_obj_trans_xls);
                    m_i_flag = 0;
                    m_lbl_tong_so_luong.Text = CIPConvert.ToStr(m_fg_load_file.Rows.Count - 1);
                    m_lbl_loading.Visible = false;
                }
                catch(Exception v_e) {
                    if(v_e.Message.ToString() == "Cannot set Column 'STT' to be null. Please use DBNull instead.")
                        BaseMessages.MsgBox_Error(THONG_BAO.ER_COT_STT_DE_TRONG);
                    else CSystemLog_301.ExceptionHandle(v_e);
                }
            }
        }
        //private void excel_file_to_dataset(string ip_str_file_path) {
        //    CExcelReport v_cer = new CExcelReport(ip_str_file_path);
        //    //tao 1 dataset de luu du lieu tu file excel
        //    m_ds_temp = new DataSet();
        //    m_dt_temp = new DataTable();
        //    m_dt_temp.TableName = "CM_DM_BANG_CHI_TIET_CUOI_THANG";
        //    m_dt_temp.Columns.Add("SOCT");
        //    m_dt_temp.Columns.Add("NGAY");
        //    m_dt_temp.Columns.Add("LOAI");
        //    m_dt_temp.Columns.Add("DON_VI_TINH");
        //    m_dt_temp.Columns.Add("DON_GIA_CHUA_VAT");
        //    m_dt_temp.Columns.Add("DON_GIA_GOM_VAT");
        //    m_ds_temp.Tables.Add(m_dt_temp);
        //    //data from excel file to dataset and fill to grid
        //    v_cer.Export2DatasetDSPhongThi(m_ds_temp, m_ds_temp.Tables[0].TableName, 10);
        //    m_ds_temp.Tables[0].Columns.RemoveAt(0);//loai bo cot thua
        //    m_ds_temp.AcceptChanges();
        //    //format lai 2 cot don gia
        //    for(int i = 0; i < m_ds_temp.Tables[0].Rows.Count; i++) {
        //        m_ds.Tables[0].Rows[i][2] = CIPConvert.ToDecimal(m_ds.Tables[0].Rows[i][2]).ToString();
        //        m_ds.Tables[0].Rows[i][3] = CIPConvert.ToDecimal(m_ds.Tables[0].Rows[i][3]).ToString();
        //    }
        //    m_fg.DataSource = m_ds_temp.Tables[0];
        //}
        private bool chua_load_file_excel() {
            if(m_dgl_open_file.FileName != "") return false;
            return true;
        }
        /// <summary>
        /// Hàm này kiểm tra xem hàng trên lưới có trong dữ liệu đã nhập hay không
        /// nếu có trả về true , không có trả về false
        /// </summary>
        /// <returns></returns>
        private bool kiem_tra_su_ton_tai_trong_co_so_du_lieu(string ip_str_ma_so) {
            if(dem_so_dong_bang_lay_boi_ma_so_bill(ip_str_ma_so) >= 1) return true;
            return false;
        }
        public string nullToString(string value) {
            return value == null ? string.Empty : value;
        }
        private int dem_so_dong_bang_lay_boi_ma_so_bill(string ip_str_ma_so) {
            int v_int_count = 0;
            DS_DM_BILL v_ds = new DS_DM_BILL();
            m_us_dm_bill = new US_DM_BILL();
            m_us_dm_bill.load_dm_by_so_bill(v_ds, nullToString(ip_str_ma_so));
            DataTable v_dt = v_ds.Tables[0];
            v_int_count = v_dt.Rows.Count;
            return v_int_count;
        }
        private void kiem_tra_data_tren_luoi() {
            // kiem tra so luong hoc vien
            if(m_fg_load_file.Rows.Count <= 1) return;
            // kiem tra du lieu tren luoi

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

            for(int i_stt = 1; i_stt <= m_fg_load_file.Rows.Count - 1; i_stt++) {
                string v_dien_giai = "";

                // 1. kiểm tra thông tin 
                if(m_fg_load_file[i_stt, (int)e_col_Number.NGAY] != null) {
                    v_dien_giai = "";
                    m_fg_load_file.SetCellStyle(i_stt, (int)e_col_Number.NGAY, v_cell_style_ok);
                }
                else {
                    v_dien_giai = "Ngày không được để trống ";
                    m_fg_load_file.SetCellStyle(i_stt, (int)e_col_Number.NGAY, v_cell_style_err);
                }

                if(m_fg_load_file[i_stt, (int)e_col_Number.BARCODE] != null) {
                    v_dien_giai = "";
                    m_fg_load_file.SetCellStyle(i_stt, (int)e_col_Number.BARCODE, v_cell_style_ok);

                }
                else {
                    v_dien_giai = "Mã số không được để trống";
                    m_fg_load_file.SetCellStyle(i_stt, (int)e_col_Number.BARCODE, v_cell_style_err);
                }

                if(m_fg_load_file[i_stt, (int)e_col_Number.TIEN] != null) {
                    v_dien_giai = "";
                    m_fg_load_file.SetCellStyle(i_stt, (int)e_col_Number.TIEN, v_cell_style_ok);

                }
                else {
                    v_dien_giai = "Số tiền không được để trống";
                    m_fg_load_file.SetCellStyle(i_stt, (int)e_col_Number.TIEN, v_cell_style_err);
                }
                m_fg_load_file[i_stt, (int)e_col_Number.DIEN_GIAI] = v_dien_giai;
                // gan gia tri cho cot kiem tra
                if(v_dien_giai != "") m_fg_load_file[i_stt, (int)e_col_Number.TRANG_THAI] = "Không đạt";
                else m_fg_load_file[i_stt, (int)e_col_Number.TRANG_THAI] = "Đạt";
            }
            // THONG BAO THANH CONG NEU LA Y
            //Kiem tra trong co so du lieu co ton tai so bill(ma so) do hay khong(truong hop nhap thieu)
            //decimal v_count_ = 0;
            //for (int i_stt = 1; i_stt <= m_fg_load_file.Rows.Count - 1; i_stt++)
            //{
            //    if (m_fg_load_file[i_stt, (int)e_col_Number.TRANG_THAI] != null)
            //    {
            //        if (CIPConvert.ToStr(m_fg_load_file[i_stt, (int)e_col_Number.TRANG_THAI]) == "Đạt")
            //        {
            //            //v_count_ = v_count_ + 1;
            //            if (kiem_tra_su_ton_tai_trong_co_so_du_lieu((string)m_fg_load_file[i_stt, (int)e_col_Number.BARCODE]))
            //            {
            //                v_count_ = v_count_ + 1;
            //            }
            //            else
            //            {
            //                m_fg_load_file[i_stt, (int)e_col_Number.DIEN_GIAI] = "Không có trong dữ liệu đã nhập";
            //                m_fg_load_file[i_stt, (int)e_col_Number.TRANG_THAI] = "Không đạt";
            //                m_fg_load_file.SetCellStyle(i_stt, (int)e_col_Number.SOCT, v_cell_style_notOK_in_data);
            //            }
            //        }
            //    }
            //}
            //// 
            //if (v_count_ == m_fg_load_file.Rows.Count - 1)
            //{
            //    m_i_flag = 1;
            //}
            //else
            //{
            //    m_i_flag = 0;
            //    BaseMessages.MsgBox_Infor("Dữ liệu chưa hợp lý. Ô có màu xanh biểu thị dữ liệu bưu nhận được chưa được nhập vào sổ, ô màu đỏ biểu thị dữ liệu tại ô đó trong file excel là trống .Hãy kiểm tra lại");
            //}
        }

        private DataTable database_2_datatable(DateTime ip_dau_thang, DateTime ip_cuoi_thang) {
            DS_DM_BILL v_ds_dm_bill = new DS_DM_BILL();
            US_DM_BILL v_us_dm_bill = new US_DM_BILL();
            //v_us_dm_bill.FillDataset(v_ds_dm_bill, "where NGAY_GUI >='"+ip_dau_thang +"' and NGAY_GUI <= '"+ip_cuoi_thang+"'");
            v_us_dm_bill.get_dm_bill(ip_dau_thang, ip_cuoi_thang, v_ds_dm_bill);

            DataTable v_dt = v_ds_dm_bill.DM_BILL;
            return v_dt;
        }
        private void add_danh_sach_du_lieu() {
            try {
                //Tim ngay dau thang, cuoi thang
                DateTime v_dau_thang = CIPConvert.ToDatetime("01/" + m_dat_thang.Text, "dd/MM/yyyy");
                DateTime v_cuoi_thang = v_dau_thang.AddMonths(1).Date.AddDays(-1).Date;
                //Lay ra 1 DataTable chua danh sach bill da gui trong thang tu CSDL
                DataTable v_dt = null;
                //if(database_2_datatable(v_dau_thang, v_cuoi_thang)!= null) {
                v_dt = database_2_datatable(v_dau_thang, v_cuoi_thang);
                //}

                C1.Win.C1FlexGrid.CellStyle v_cell_style_err = this.m_fg_load_file.Styles.Add("RowColorErr");
                v_cell_style_err.BackColor = Color.Yellow;
                m_lbl_loading.Visible = true;
                /*So sanh:
                 * Neu so bill tren grv co trong CSDL thi update so tien, xoa hang tren grv
                 * Neu so bill tren grv khong co trong CSDL thi khong xoa hang tren grv
                */
                DataView v_dv = v_dt.DefaultView;
                v_dv.Sort= "SO_BILL";
                for(int v_int_row = m_fg_load_file.Rows.Fixed; v_int_row <= m_fg_load_file.Rows.Count - 1; v_int_row++) {
                    string v_str_so_bill = CIPConvert.ToStr(m_fg_load_file[v_int_row, (int)e_col_Number.BARCODE]);
                    int temp = v_dv.Find(v_str_so_bill);
                    if(temp >= 0) {
                        //Cap nhat so tien
                        m_us_dm_bill.update_diem_by_so_bill(v_str_so_bill, CIPConvert.ToDecimal(m_fg_load_file.Rows[v_int_row][(int)e_col_Number.TIEN]));
                        m_fg_load_file.RemoveItem(v_int_row);
                        v_int_row = v_int_row - 1;
                    }
                    else {
                        m_fg_load_file.Rows[v_int_row].Style = v_cell_style_err;
                        continue;
                    }
                }
                m_lbl_loading.Visible = false;
                ghi_log_he_thong();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        
        #endregion

        //
        // Event Handlers
        //
        private void set_define_event() {
            m_cmd_thoat.Click += new EventHandler(m_cmd_thoat_Click);
            m_cmd_luu.Click += new EventHandler(m_cmd_luu_Click);
            m_cmd_kiem_tra.Click += new EventHandler(m_cmd_kiem_tra_Click);
            m_cmd_load_ds.Click += new EventHandler(m_cmd_load_ds_Click);
            m_xuat_excel.Click += new EventHandler(m_xuat_excel_Click);
            this.Load += new EventHandler(f130_chuc_nang_Load);
            m_cmd_del.Click += new EventHandler(m_cmd_del_Click);
            m_cmd_insert_row.Click += new EventHandler(m_cmd_insert_row_Click);
        }
        private void m_cmd_insert_row_Click(object sender, EventArgs e) {
            try {
                m_fg_load_file.Rows.Insert(m_fg_load_file.Row);
                m_lbl_tong_so_luong.Text = CIPConvert.ToStr(m_fg_load_file.Rows.Count - 1);
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_del_Click(object sender, EventArgs e) {
            try {
                m_fg_load_file.RemoveItem(m_fg_load_file.Row);
                m_lbl_tong_so_luong.Text = CIPConvert.ToStr(m_fg_load_file.Rows.Count - 1);
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void f130_chuc_nang_Load(object sender, EventArgs e) {
            try {
                set_initial_form_load();
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void m_cmd_load_ds_Click(object sender, EventArgs e) {
            try {
                load_danh_sach_excel();
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void m_cmd_kiem_tra_Click(object sender, EventArgs e) {
            try {
                if(chua_load_file_excel()) {
                    BaseMessages.MsgBox_Infor("Bạn chưa load file Excel");
                    return;
                }
                kiem_tra_data_tren_luoi();
                if (m_i_flag == 1) BaseMessages.MsgBox_Infor("Dữ liệu đã được kiểm tra");
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void m_cmd_luu_Click(object sender, EventArgs e) {
            try {
                if(chua_load_file_excel()) {
                    BaseMessages.MsgBox_Infor("Bạn chưa load file Exel dữ liệu !");
                    return;
                }
                //if (m_i_flag == 0) return;
                add_danh_sach_du_lieu();
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void m_xuat_excel_Click(object sender, EventArgs e) {
            try {
                CExcelReport v_excel = new CExcelReport("f130_chuc_nang.xls", 6, 1);
                v_excel.FindAndReplace(false);
                v_excel.Export2ExcelWithoutFixedRows(m_fg_load_file, (int)e_col_Number.SOCT, (int)e_col_Number.GHICHU, true);
                //v_excel.OpenExcelFile();
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void m_cmd_thoat_Click(object sender, EventArgs e) {
            try {
                this.Close();
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
