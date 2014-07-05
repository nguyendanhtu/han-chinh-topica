using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NExcel;
using IP.Core.IPCommon;
using IP.Core.IPExcelReport;
using BCTKUS;
using BCTKDS.CDBNames;
using System.Collections;
using System.Globalization;
using IP.Core.IPException;
using IP.Core.IPSystemAdmin;
using BCTKDS;

namespace BCTKApp.ChucNang {
    public partial class f820_NHAP_CHI_PHI_CUOI_THANG : Form {
        public class CError {
            public string value { get; set; }
            public string name { get; set; }
        }
        public f820_NHAP_CHI_PHI_CUOI_THANG() {
            InitializeComponent();
            format_controls();
            m_status = (int)status.begin;
        }

        #region Public Method
        public void Display() {
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
        private enum e_col_Number {
            soct = 1,
            ngay = 2,
            loai = 3,
            barcode = 4,
            noiden = 5,
            trluong = 6,
            cuoc = 7,
            phi = 8,
            phixd = 9,
            tienck = 10,
            tien = 11,
            ghichu = 12
        }
        private int m_status;
        private enum status {
            begin = 0, // trạng thái ban đầu
            fail_import = -1, // trạng thái import file excel bị lỗi
            ok_import = 1, // trạng thái import ok 
            fail_check = -2, // trạng thái check dữ liệu lỗi
            ok_check = 2, // trạng thái check dữ liệu trên lưới ok
            comparing = 3 // đang so sánh
        }
        #endregion

        #region Members
        List<CError> m_listError = new List<CError>();
        US_DM_BILL m_us_dm_bill = new US_DM_BILL();
        #endregion

        #region Private Methods
        private void format_controls() {
            CControlFormat.setFormStyle(this);
            CControlFormat.setC1FlexFormat(m_fg);
            //m_fg_load_file.Cols[(int)e_col_Number.ID].Visible = false;
            m_lbl_loading.Visible = false;
            m_fg.AllowAddNew = true;
            //m_fg.AllowEditing = true;
            m_fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            m_fg.AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.None;
            m_fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcrossOut;
            m_fg.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcrossOut;
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.MakeSoTT(0, m_fg);
            set_define_event();
            this.KeyPreview = true;
        }
   
        private void load_danh_sach_excel() {
            if(m_status != (int) status.begin) {
                m_status = (int)status.begin;
                int v_amount = m_fg.Rows.Count;
                for(int i = v_amount - 1; i > m_fg.Rows.Fixed; i--) {
                    m_fg.RemoveItem(i);
                }
                m_fg.Rows[1].Clear(C1.Win.C1FlexGrid.ClearFlags.All);
            }

            //Chọn đường dẫn tới file excel
            var m_obj_dialog = new System.Windows.Forms.OpenFileDialog();
            m_obj_dialog.ShowDialog();

            //Mở sheet đầu tiên
            Workbook wb = null;
            wb = Workbook.getWorkbook(m_obj_dialog.FileName);
            Sheet sheet = wb.getSheet(0);
            //->Cái này để thêm hàng vào grid, cho tới khi row ở cột barcode rỗng
            int v_count_row = 2;
            while(sheet.getCell(3, v_count_row).Contents != "") {
                v_count_row = v_count_row + 1;
                m_fg.Rows.Add();
            }
            //m_fg.Rows.Add();
            //m_fg.Rows.Add();
            //m_fg.Rows.Add();

            wb.close();//Đóng connection khi sử dụng NExcel

            //Load dữ liệu lên lưới
            CExcelReport v_obj_excel_rpt = new CExcelReport(m_obj_dialog.FileName);
            m_lbl_loading.Visible = true;
            int v_i_start_excel_row = 2;
            int v_i_sheet_col = 1;
            for(int v_i_cur_col = m_fg.Cols.Fixed; v_i_cur_col < m_fg.Cols.Count; v_i_cur_col++) {
                v_obj_excel_rpt.Export2Grid(m_fg,
                    v_i_start_excel_row
                    , v_i_sheet_col
                    , v_i_cur_col);
                v_i_sheet_col = v_i_sheet_col + 1;
            }
            m_fg.Rows[m_fg.Rows.Count - 1].Clear(C1.Win.C1FlexGrid.ClearFlags.All);
            m_lbl_loading.Visible = false;
        }
        //private void grid_row_2_us_cm_dm_bang_chi_tiet_cuoi_thang(int ip_grid_row, US_CM_DM_BANG_CHI_TIET_CUOI_THANG iop_us_cm_dm_bang_chi_tiet_cuoi_thang) 
        //{
        //    iop_us_cm_dm_bang_chi_tiet_cuoi_thang.strSOCT = CIPConvert.ToStr(m_fg[ip_grid_row, (int)e_col_Number.soct]);
        //    string ngay = m_fg[ip_grid_row, (int)e_col_Number.ngay].ToString();
        //    //ngay = StringForngay.Substring(0, ngay.IndexOf(" "));
        //    iop_us_cm_dm_bang_chi_tiet_cuoi_thang.datNGAY = DateTime.Parse(ngay);
        //    iop_us_cm_dm_bang_chi_tiet_cuoi_thang.strLOAI = CIPConvert.ToStr(m_fg[ip_grid_row, (int) e_col_Number.loai]); 
        //    iop_us_cm_dm_bang_chi_tiet_cuoi_thang.strBARCODE = CIPConvert.ToStr(m_fg[ip_grid_row, (int) e_col_Number.barcode]);
        //    iop_us_cm_dm_bang_chi_tiet_cuoi_thang.strNOIDEN = CIPConvert.ToStr(m_fg[ip_grid_row, (int) e_col_Number.noiden]);
        //    iop_us_cm_dm_bang_chi_tiet_cuoi_thang.dcTRLUONG = CIPConvert.ToDecimal(m_fg[ip_grid_row, (int) e_col_Number.trluong]);
        //    iop_us_cm_dm_bang_chi_tiet_cuoi_thang.dcCUOC = CIPConvert.ToDecimal(m_fg[ip_grid_row, (int)e_col_Number.cuoc]);
        //    iop_us_cm_dm_bang_chi_tiet_cuoi_thang.dcPHI = CIPConvert.ToDecimal(m_fg[ip_grid_row, (int)e_col_Number.phi]);
        //    iop_us_cm_dm_bang_chi_tiet_cuoi_thang.dcPHIXD = CIPConvert.ToDecimal(m_fg[ip_grid_row, (int)e_col_Number.phixd]);
        //    iop_us_cm_dm_bang_chi_tiet_cuoi_thang.dcTIENCK = CIPConvert.ToDecimal(m_fg[ip_grid_row, (int) e_col_Number.trluong]);
        //    iop_us_cm_dm_bang_chi_tiet_cuoi_thang.dcTIEN = CIPConvert.ToDecimal(m_fg[ip_grid_row, (int) e_col_Number.tien]);

        //    iop_us_cm_dm_bang_chi_tiet_cuoi_thang.SetGHICHUNull();
        //}
        private bool kiem_tra_ds_excel() {
            //Kiểm tra xem đủ dữ liệu chưa, có cell nào trống không (cell cần thiết, cell không cần thiết thì kệ)
            //for(int v_i_cur_row = m_fg.Rows.Fixed; v_i_cur_row < m_fg.Rows.Count - 4; v_i_cur_row++) {
            //    if(m_fg[v_i_cur_row, (int)e_col_Number.soct] == null || CIPConvert.ToStr(m_fg[v_i_cur_row, (int)e_col_Number.soct]) == "") {
            //        //CError v_t = new CError();
            //        //v_t.name = "Ô không có dữ liệu";
            //        //v_t.value = m_fg[v_i_cur_row, (int) e_col_Number.soct];
            //        //m_list.Add(v_t);

            //        BaseMessages.MsgBox_Infor("Bạn chưa nhập dữ liệu");
            //        m_fg.Select(v_i_cur_row, (int)e_col_Number.soct);
            //        return false;
            //    }
            //}
            return true;
            ////Bước 2: Nếu ok thì ghi vào bảng trong CSDL CM_DM_BANG_CHI_TIET_CUOI_THANG
            //US_CM_DM_BANG_CHI_TIET_CUOI_THANG v_us_cm_dm_bang_chi_tiet_cuoi_thang = new US_CM_DM_BANG_CHI_TIET_CUOI_THANG();
            //try
            //{
            //    v_us_cm_dm_bang_chi_tiet_cuoi_thang.BeginTransaction();
            //    for (int v_i_cur_row = m_fg.Rows.Fixed; v_i_cur_row < m_fg.Rows.Count - 4; v_i_cur_row++)
            //    {
            //        grid_row_2_us_cm_dm_bang_chi_tiet_cuoi_thang(v_i_cur_row, v_us_cm_dm_bang_chi_tiet_cuoi_thang);
            //        v_us_cm_dm_bang_chi_tiet_cuoi_thang.Insert();
            //    }
            //    v_us_cm_dm_bang_chi_tiet_cuoi_thang.CommitTransaction();
            //    BaseMessages.MsgBox_Infor("Đã nhập thành công!");
            //}
            //catch (Exception v_e)
            //{
            //    if (v_us_cm_dm_bang_chi_tiet_cuoi_thang.is_having_transaction())
            //    {
            //        v_us_cm_dm_bang_chi_tiet_cuoi_thang.Rollback();
            //    }
            //    throw v_e;
            //}
        }
        private bool check_so_bill_in_db(string ip_so_bill) {
            US_DM_BILL v_us_dm_bill = new US_DM_BILL();

            return v_us_dm_bill.is_existed_bill(v_us_dm_bill, ip_so_bill);
        }
        private bool check_so_tien_is_null(US_DM_BILL ip_us_dm_bill, string ip_so_bill) {
            return ip_us_dm_bill.is_so_tien_null(ip_us_dm_bill, ip_so_bill);        
        }
        private void so_sanh() {
            //Concept: Kiểm tra từng số bill ở trong file excel của NCC, 
            //nếu tồn tại trong CSDL (bảng DM bill) thì update số tiền bằng mã bill
            //Bản ghi nào update xong thì trên lưới xóa bỏ hàng đó đi, cuối cùng còn chừa lại những mã bill của ncc chưa đc
            //update vào pm (do trên phần mềm ko có mã bill đó hoặc nhập sai)
            int v_amount_row = m_fg.Rows.Count - 1 - m_fg.Rows.Fixed;
            for(int v_row = m_fg.Rows.Fixed; v_row <= v_amount_row; v_row++) {
                /* Kiểm tra xem số bill có trên csdl chưa. Nếu không có thì kệ trên lưới, xuất lỗi ra listbox*/
                if(m_fg[v_row, (int)e_col_Number.barcode] == null || m_fg[v_row, (int)e_col_Number.barcode].ToString() == "") {
                    return;
                }
                string v_so_bill = CIPConvert.ToStr(m_fg[v_row, (int)e_col_Number.barcode]);

                if(!check_so_bill_in_db(v_so_bill)) {
                    CError v_error_exist = new CError();
                    v_error_exist.name = "Số bill " + v_so_bill + " từ nhà cung cấp không có trong phần mềm!";
                    v_error_exist.value = v_so_bill;
                    m_listError.Add(v_error_exist);
                    break;
                }

                US_DM_BILL v_us_dm_bill = new US_DM_BILL();
                if(!check_so_tien_is_null(v_us_dm_bill, v_so_bill)) {
                    CError v_error_null = new CError();
                    v_error_null.name = "Số bill " + v_so_bill + " này đã có số tiền trong phần mềm rồi!";
                    v_error_null.value = v_so_bill;
                    m_listError.Add(v_error_null);
                    continue;
                }
                else v_us_dm_bill.update_tien_by_so_bill(v_so_bill, CIPConvert.ToDecimal(m_fg[v_row, (int)e_col_Number.tien]));

                m_fg.RemoveItem(v_row);
                v_row = v_row - 1;
            }
            m_lbox_ds_loi.DataSource = m_listError;
            m_lbox_ds_loi.DisplayMember = "name";
            m_lbox_ds_loi.ValueMember = "value";
        }
        private void set_define_event() {
            m_cmd_thoat.Click += new EventHandler(m_cmd_thoat_Click);
            m_cmd_nhap_excel.Click += new EventHandler(m_cmd_nhap_excel_Click);
            m_cmd_so_sanh.Click += new EventHandler(m_cmd_so_sanh_Click);
            m_cmd_kiem_tra_dl.Click += new EventHandler(m_cmd_kiem_tra_dl_Click);
        }
        #endregion

        //
        // Event Handlers
        //
        private void m_cmd_kiem_tra_dl_Click(object sender, EventArgs e) {
            try {
                if(!kiem_tra_ds_excel()) return;

                m_status = (int)status.ok_check;
            }
            catch(Exception v_e) {
                m_status = (int)status.fail_check;
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_so_sanh_Click(object sender, EventArgs e) {
            try {
                so_sanh();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_nhap_excel_Click(object sender, EventArgs e) {
            try {
                load_danh_sach_excel();    
                m_status = (int)status.ok_import;
            }
            catch(Exception v_e) {
                m_status = (int)status.fail_import;
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_thoat_Click(object sender, EventArgs e) {
            try {
                this.Close();
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
