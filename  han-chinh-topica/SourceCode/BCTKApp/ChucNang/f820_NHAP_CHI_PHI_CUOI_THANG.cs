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

namespace BCTKApp.ChucNang
{
    public partial class f820_NHAP_CHI_PHI_CUOI_THANG : Form
    {
        public f820_NHAP_CHI_PHI_CUOI_THANG()
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
            NOIDEN = 6
,
            ID = 1
                ,
            LOAI = 4
                ,
            TRLUONG = 7
                ,
            TIEN = 13
                ,
            STT = 2
                ,
            PHI = 9
                ,
            BARCODE = 5
                ,
            PHIXD = 10
                ,
            CUOC = 8
                ,
            NGAY = 3
                ,
            TIENCK = 11
                ,
            PHIHK = 12
                , GHICHU = 14,
            TRANG_THAI = 15,
            DIEN_GIAI = 16

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans_xls;
        DS_CM_DM_BANG_CHI_TIET_CUOI_THANG m_ds = new DS_CM_DM_BANG_CHI_TIET_CUOI_THANG();
        US_CM_DM_BANG_CHI_TIET_CUOI_THANG m_us = new US_CM_DM_BANG_CHI_TIET_CUOI_THANG();
        US_CM_DM_DANG_KY_GUI m_us_dm_dang_ky_gui = new US_CM_DM_DANG_KY_GUI();
        US_V_HT_LOG_TRUY_CAP m_us_v_ht_log_truy_cap = new US_V_HT_LOG_TRUY_CAP();
        // cờ dùng để xác định dữ liệu có ok hay ko? 0: ko ok; 1: ok
        int m_i_flag = 0;
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
            CControlFormat.setC1FlexFormat(m_fg_load_file);
            m_fg_load_file.Cols[(int)e_col_Number.ID].Visible = false;
            m_lbl_loading.Visible = false;
            CGridUtils.AddSave_Excel_Handlers(m_fg_load_file);
            set_define_event();
            this.KeyPreview = true;
        }
        private void set_initial_form_load()
        {
            m_obj_trans_xls = get_2_us_obj_xls();
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
        private ITransferDataRow get_2_us_obj_xls()
        {
            Hashtable v_hst = new Hashtable();
            v_hst.Add(CM_DM_BANG_CHI_TIET_CUOI_THANG.NOIDEN, e_col_Number.NOIDEN);
            //v_hst.Add(CM_DM_BANG_CHI_TIET_CUOI_THANG.ID, e_col_Number.ID);
            v_hst.Add(CM_DM_BANG_CHI_TIET_CUOI_THANG.LOAI, e_col_Number.LOAI);
            v_hst.Add(CM_DM_BANG_CHI_TIET_CUOI_THANG.TRLUONG, e_col_Number.TRLUONG);
            v_hst.Add(CM_DM_BANG_CHI_TIET_CUOI_THANG.TIEN, e_col_Number.TIEN);
            v_hst.Add(CM_DM_BANG_CHI_TIET_CUOI_THANG.STT, e_col_Number.STT);
            v_hst.Add(CM_DM_BANG_CHI_TIET_CUOI_THANG.PHI, e_col_Number.PHI);
            v_hst.Add(CM_DM_BANG_CHI_TIET_CUOI_THANG.BARCODE, e_col_Number.BARCODE);
            v_hst.Add(CM_DM_BANG_CHI_TIET_CUOI_THANG.PHIXD, e_col_Number.PHIXD);
            v_hst.Add(CM_DM_BANG_CHI_TIET_CUOI_THANG.CUOC, e_col_Number.CUOC);
            v_hst.Add(CM_DM_BANG_CHI_TIET_CUOI_THANG.NGAY, e_col_Number.NGAY);
            v_hst.Add(CM_DM_BANG_CHI_TIET_CUOI_THANG.TIENCK, e_col_Number.TIENCK);
            v_hst.Add(CM_DM_BANG_CHI_TIET_CUOI_THANG.PHIHK, e_col_Number.PHIHK);
            v_hst.Add(CM_DM_BANG_CHI_TIET_CUOI_THANG.GHICHU, e_col_Number.GHICHU);
            CC1TransferDataRow v_obj = new CC1TransferDataRow(m_fg_load_file, v_hst, m_ds.CM_DM_BANG_CHI_TIET_CUOI_THANG.NewCM_DM_BANG_CHI_TIET_CUOI_THANGRow());
            return v_obj;
        }
        private void load_danh_sach_excel()
        {
            if (m_dgl_open_file.ShowDialog() == DialogResult.OK)
            {
                string v_str_path_and_file_name = m_dgl_open_file.FileName;
                string v_str_file_name = v_str_path_and_file_name.Substring(v_str_path_and_file_name.LastIndexOf("\\") + 1, v_str_path_and_file_name.Length - v_str_path_and_file_name.LastIndexOf("\\") - 1);
                CExcelReport v_xls_file = new CExcelReport(v_str_path_and_file_name);
                DS_CM_DM_BANG_CHI_TIET_CUOI_THANG v_ds_cm_dm_bang_chi_tiet_cuoi_thang = new DS_CM_DM_BANG_CHI_TIET_CUOI_THANG();
                try
                {
                    m_lbl_loading.Visible = true;
                    v_ds_cm_dm_bang_chi_tiet_cuoi_thang.EnforceConstraints = false;
                    v_xls_file.Export2DatasetDSPhongThi(v_ds_cm_dm_bang_chi_tiet_cuoi_thang, v_ds_cm_dm_bang_chi_tiet_cuoi_thang.CM_DM_BANG_CHI_TIET_CUOI_THANG.TableName, 3);

                    //DataSet v_ds_cm_dm_bang_modify = ModifyDateToUSFormat(v_ds_cm_dm_bang_chi_tiet_cuoi_thang);
                    CGridUtils.Dataset2C1Grid(v_ds_cm_dm_bang_chi_tiet_cuoi_thang, m_fg_load_file, m_obj_trans_xls);
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
        /// <summary>
        /// Hàm này kiểm tra xem hàng trên lưới có trong dữ liệu đã nhập hay không
        /// nếu có trả về true , không có trả về false
        /// </summary>
        /// <returns></returns>
        private bool kiem_tra_su_ton_tai_trong_co_so_du_lieu(string ip_str_ma_so)
        {
            if (dem_so_dong_bang_lay_boi_ma_so_bill(ip_str_ma_so) >= 1) return true;
            return false;
        }
        public string nullToString(string value)
        {
            return value == null ? string.Empty : value;
        }
        private int dem_so_dong_bang_lay_boi_ma_so_bill(string ip_str_ma_so)
        {
            int v_int_count = 0;
            DS_CM_DM_DANG_KY_GUI v_ds = new DS_CM_DM_DANG_KY_GUI();
            m_us_dm_dang_ky_gui = new US_CM_DM_DANG_KY_GUI();
            m_us_dm_dang_ky_gui.load_dm_by_so_bill(v_ds, nullToString(ip_str_ma_so));
            DataTable v_dt = v_ds.Tables[0];
            v_int_count = v_dt.Rows.Count;
            return v_int_count;
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

                for (int i_stt = 1; i_stt <= m_fg_load_file.Rows.Count - 1; i_stt++)
                {
                    string v_dien_giai = "";

                    // 1. kiểm tra thông tin 
                    if (m_fg_load_file[i_stt, (int)e_col_Number.NGAY] != null)
                    {
                        v_dien_giai = "";
                        m_fg_load_file.SetCellStyle(i_stt, (int)e_col_Number.NGAY, v_cell_style_ok);

                    }
                    else
                    {
                        v_dien_giai = "Ngày không được để trống ";
                        m_fg_load_file.SetCellStyle(i_stt, (int)e_col_Number.NGAY, v_cell_style_err);
                    }

                    if (m_fg_load_file[i_stt, (int)e_col_Number.BARCODE] != null)
                    {
                        v_dien_giai = "";
                        m_fg_load_file.SetCellStyle(i_stt, (int)e_col_Number.BARCODE, v_cell_style_ok);

                    }
                    else
                    {
                        v_dien_giai = "Mã số không được để trống";
                        m_fg_load_file.SetCellStyle(i_stt, (int)e_col_Number.BARCODE, v_cell_style_err);
                    }

                    if (m_fg_load_file[i_stt, (int)e_col_Number.TIEN] != null)
                    {
                        v_dien_giai = "";
                        m_fg_load_file.SetCellStyle(i_stt, (int)e_col_Number.TIEN, v_cell_style_ok);

                    }
                    else
                    {
                        v_dien_giai = "Số tiền không được để trống";
                        m_fg_load_file.SetCellStyle(i_stt, (int)e_col_Number.TIEN, v_cell_style_err);
                    }
                    m_fg_load_file[i_stt, (int)e_col_Number.DIEN_GIAI] = v_dien_giai;
                    // gan gia tri cho cot kiem tra
                    if (v_dien_giai != "") m_fg_load_file[i_stt, (int)e_col_Number.TRANG_THAI] = "Không đạt";
                    else m_fg_load_file[i_stt, (int)e_col_Number.TRANG_THAI] = "Đạt";
                }
                // THONG BAO THANH CONG NEU LA Y
                //Kiem tra trong co so du lieu co ton tai so bill(ma so) do hay khong(truong hop nhap thieu)
                decimal v_count_ = 0;
                for (int i_stt = 1; i_stt <= m_fg_load_file.Rows.Count - 1; i_stt++)
                {
                    if (m_fg_load_file[i_stt, (int)e_col_Number.TRANG_THAI] != null)
                    {
                        if (CIPConvert.ToStr(m_fg_load_file[i_stt, (int)e_col_Number.TRANG_THAI]) == "Đạt")
                        {
                            //v_count_ = v_count_ + 1;
                            if (kiem_tra_su_ton_tai_trong_co_so_du_lieu((string)m_fg_load_file[i_stt, (int)e_col_Number.BARCODE]))
                            {
                                v_count_ = v_count_ + 1;
                            }
                            else
                            {
                                m_fg_load_file[i_stt, (int)e_col_Number.DIEN_GIAI] = "Không có trong dữ liệu đã nhập";
                                m_fg_load_file[i_stt, (int)e_col_Number.TRANG_THAI] = "Không đạt";
                                m_fg_load_file.SetCellStyle(i_stt, (int)e_col_Number.STT, v_cell_style_notOK_in_data);
                            }
                        }
                    }
                }
                // 
                if (v_count_ == m_fg_load_file.Rows.Count - 1)
                {
                    m_i_flag = 1;
                }
                else
                {
                    m_i_flag = 0;
                    BaseMessages.MsgBox_Infor("Dữ liệu chưa hợp lý. Ô có màu xanh biểu thị dữ liệu bưu nhận được chưa được nhập vào sổ, ô màu đỏ biểu thị dữ liệu tại ô đó trong file excel là trống .Hãy kiểm tra lại");
                }
            }
            catch (Exception v_e)
            {
                throw v_e;
            }

        }

        /// <summary>
        /// Hàm này chỉ load 2 thông tin là số bill (mã số) và số tiền vào database
        /// </summary>
        /// <param name="ip_us"></param>
        /// <param name="ip_int_row_in_grid"></param>
        //private void form_2_us_obj(US_CM_DM_DANG_KY_GUI ip_us, int ip_int_row_in_grid)
        //{
        //ip_us.dcSTT = CIPConvert.ToDecimal(m_fg_load_file[ip_int_row_in_grid,(int)e_col_Number.STT]);
        ////BaseMessages.MsgBox_Infor(m_fg_load_file[ip_int_row_in_grid, (int)e_col_Number.NGAY].ToString());
        //ip_us.datNGAY = Convert.ToDateTime(m_fg_load_file[ip_int_row_in_grid, (int)e_col_Number.NGAY].ToString());
        //ip_us.strLOAI = CIPConvert.ToStr(m_fg_load_file[ip_int_row_in_grid, (int)e_col_Number.LOAI]);
        //ip_us.strBARCODE = CIPConvert.ToStr(m_fg_load_file[ip_int_row_in_grid, (int)e_col_Number.BARCODE]);
        //ip_us.strNOIDEN = CIPConvert.ToStr(m_fg_load_file[ip_int_row_in_grid, (int)e_col_Number.NOIDEN]);
        //ip_us.dcTRLUONG = CIPConvert.ToDecimal(m_fg_load_file[ip_int_row_in_grid, (int)e_col_Number.TRLUONG]);
        //ip_us.dcCUOC = CIPConvert.ToDecimal(m_fg_load_file[ip_int_row_in_grid, (int)e_col_Number.CUOC]);
        //ip_us.dcPHI = CIPConvert.ToDecimal(m_fg_load_file[ip_int_row_in_grid, (int)e_col_Number.PHI]);
        //ip_us.dcPHIXD = CIPConvert.ToDecimal(m_fg_load_file[ip_int_row_in_grid, (int)e_col_Number.PHIXD]);
        //ip_us.dcTIENCK = CIPConvert.ToDecimal(m_fg_load_file[ip_int_row_in_grid, (int)e_col_Number.TIENCK]);
        //ip_us.dcPHIHK = CIPConvert.ToDecimal(m_fg_load_file[ip_int_row_in_grid, (int)e_col_Number.PHIHK]);
        //ip_us.dcTIEN = CIPConvert.ToDecimal(m_fg_load_file[ip_int_row_in_grid, (int)e_col_Number.TIEN]);
        //ip_us.strGHICHU = CIPConvert.ToStr(m_fg_load_file[ip_int_row_in_grid, (int)e_col_Number.GHICHU]);
        //ip_us.strTRANG_THAI = CIPConvert.ToStr(m_fg_load_file[ip_int_row_in_grid, (int)e_col_Number.TRANG_THAI]);
        //ip_us.strDIEN_GIAI = CIPConvert.ToStr(m_fg_load_file[ip_int_row_in_grid, (int)e_col_Number.DIEN_GIAI]);
        //    ip_us.strSO_BILL = CIPConvert.ToStr(m_fg_load_file[ip_int_row_in_grid, (int)e_col_Number.BARCODE]);
        //    ip_us.dcSO_TIEN = CIPConvert.ToDecimal(m_fg_load_file[ip_int_row_in_grid, (int)e_col_Number.TIEN]);
        //}
        private void add_danh_sach_du_lieu()
        {
            try
            {
                m_lbl_loading.Visible = true;
                m_us.BeginTransaction();
                for (int v_int_row = m_fg_load_file.Rows.Fixed; v_int_row <= m_fg_load_file.Rows.Count - 1; v_int_row++)
                {
                    string v_str_so_bill = CIPConvert.ToStr(m_fg_load_file[v_int_row, (int)e_col_Number.BARCODE]);
                    decimal v_dc_so_tien = CIPConvert.ToDecimal(m_fg_load_file[v_int_row, (int)e_col_Number.TIEN]);
                    m_us_dm_dang_ky_gui.update_diem_by_so_bill(v_str_so_bill, v_dc_so_tien);
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
        //private DataSet ModifyDateToUSFormat(DataSet ds)
        //{
        //    DataSet dsRes = new DataSet();
        //    DateTimeFormatInfo usDtfi = new CultureInfo("en-US", false).DateTimeFormat;

        //    //Convert from DateTime to String Type
        //    DataTable dtCloned = ds.Tables[0].Clone();
        //    foreach (DataColumn dc in ds.Tables[0].Columns)
        //    {
        //        if (dc.DataType == typeof(DateTime))
        //            dtCloned.Columns[dc.ColumnName].DataType = typeof(string);
        //    }

        //    foreach (DataRow row in ds.Tables[0].Rows)
        //        dtCloned.ImportRow(row);

        //    //Change the String format to US format. Since Database expects US Format Only.
        //    foreach (DataRow row in dtCloned.Rows)
        //    {
        //        foreach (DataColumn dc in ds.Tables[0].Columns)
        //        {
        //            if (dc.DataType == typeof(DateTime))
        //                row[dc.ColumnName] = DateTime.Parse(row[dc.ColumnName].ToString(), CultureInfo.CurrentCulture, DateTimeStyles.NoCurrentDateDefault).ToString(usDtfi.ShortDatePattern);
        //        }
        //    }

        //    dsRes.Tables.Add(dtCloned);
        //    return dsRes;
        //}
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
            m_xuat_excel.Click += new EventHandler(m_xuat_excel_Click);
            this.Load += new EventHandler(f130_chuc_nang_Load);
        }
        void f130_chuc_nang_Load(object sender, EventArgs e)
        {
            try
            {
                set_initial_form_load();
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
                if (m_i_flag == 0) return;
                add_danh_sach_du_lieu();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void m_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                CExcelReport v_excel = new CExcelReport("BCTK_Thong_tin_import_from_excel_can_kiem_tra.xlsx", 7, 1);

                v_excel.Export2ExcelWithoutFixedRows(m_fg_load_file, (int)e_col_Number.STT, (int)e_col_Number.DIEN_GIAI, false);
                v_excel.FindAndReplace(true);
                //v_excel.OpenExcelFile();
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
