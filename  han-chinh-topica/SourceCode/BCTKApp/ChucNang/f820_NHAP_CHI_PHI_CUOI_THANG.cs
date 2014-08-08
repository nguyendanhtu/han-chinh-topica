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
        public class CError_ton_tai_bill {
            public string value { get; set; }
            public string name { get; set; }
        }
        public class CError_ton_tai_tien
        {
            public string value { get; set; }
            public string name { get; set; }
        }
        public f820_NHAP_CHI_PHI_CUOI_THANG() {
            InitializeComponent();
            format_controls();
            m_status = (int)status.begin;
            make_stt(m_fg);
            hien_thi_tong_tien();
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
        US_DM_BILL m_us_dm_bill = new US_DM_BILL();
        private int m_status;
        private int m_flag = 0;
        #endregion

        #region Private Methods
        private void format_controls() {
            CControlFormat.setFormStyle(this);
            CControlFormat.setC1FlexFormat(m_fg);
            //m_fg_load_file.Cols[(int)e_col_Number.ID].Visible = false;
            m_lbl_loading.Visible = false;
            //m_fg.AllowAddNew = true;
            m_fg.AllowEditing = true;
            m_fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            m_fg.AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.None;
            m_fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcrossOut;
            m_fg.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcrossOut;
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.MakeSoTT(0, m_fg);
            progressBar1.Visible = false;
            
            set_define_event();
            this.KeyPreview = true;
        }

        private void remove_row_after_nhap_lai() {
            CGridUtils.ClearDataInGrid(m_fg);
        }

        private void load_danh_sach_excel() {
            //Chọn đường dẫn tới file excel
            var m_obj_dialog = new System.Windows.Forms.OpenFileDialog();
            m_obj_dialog.ShowDialog();
  
            //Mở sheet đầu tiên
            Workbook wb = null;
            wb = Workbook.getWorkbook(m_obj_dialog.FileName);
            Sheet sheet = wb.getSheet(0);
            //->Cái này để thêm hàng vào grid, cho tới khi row ở cột barcode rỗng
            int v_count_row = 1;
            while(sheet.getCell(3, v_count_row).Contents != "") {
                v_count_row = v_count_row + 1;
                //m_fg.Rows.Add();
            }
            m_fg.Rows.Count = v_count_row + 1;

            wb.close();//Đóng connection khi sử dụng NExcel

            //Load dữ liệu lên lưới
            CExcelReport v_obj_excel_rpt = new CExcelReport(m_obj_dialog.FileName);
            m_lbl_loading.Visible = true;
            int v_i_start_excel_row = 2;
            int v_i_sheet_col = 1;
            for(int v_i_cur_col = m_fg.Cols.Fixed; v_i_cur_col < m_fg.Cols.Count; v_i_cur_col++) {
                progressBar1.Visible = true;
                progressBar1.Minimum = 1;
                progressBar1.Maximum = m_fg.Cols.Count;
                progressBar1.Value = v_i_cur_col;
                v_obj_excel_rpt.Export2Grid(m_fg,
                    v_i_start_excel_row
                    , v_i_sheet_col
                    , v_i_cur_col);
                v_i_sheet_col = v_i_sheet_col + 1;
            }
            //m_fg.Rows[m_fg.Rows.Count - 1].Clear(C1.Win.C1FlexGrid.ClearFlags.All);
            m_lbl_loading.Visible = false;
            progressBar1.Visible = false;
            m_fg.Select(0,0);
        }

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

        private void hien_thi_tong_tien() {
            decimal cuoc = 0, phi = 0, phixd = 0, tienck = 0, tien = 0;
            for(int v_row = m_fg.Rows.Fixed; v_row < m_fg.Rows.Count - 1; v_row++) {
                if(m_fg.Rows[v_row][(int)e_col_Number.cuoc] != null && m_fg.Rows[v_row][(int)e_col_Number.cuoc].ToString() != "") {
                    cuoc = cuoc + CIPConvert.ToDecimal(m_fg.Rows[v_row][(int) e_col_Number.cuoc]);
                }
                if(m_fg.Rows[v_row][(int)e_col_Number.phi] != null && m_fg.Rows[v_row][(int)e_col_Number.phi].ToString() != "") {
                    phi = phi + CIPConvert.ToDecimal(m_fg.Rows[v_row][(int)e_col_Number.phi]);
                }
                if(m_fg.Rows[v_row][(int)e_col_Number.phixd] != null && m_fg.Rows[v_row][(int)e_col_Number.phixd].ToString() != "") {
                    phixd = phixd + CIPConvert.ToDecimal(m_fg.Rows[v_row][(int)e_col_Number.phixd]);
                }
                if(m_fg.Rows[v_row][(int)e_col_Number.tienck] != null && m_fg.Rows[v_row][(int)e_col_Number.tienck].ToString() != "") {
                    tienck = tienck + CIPConvert.ToDecimal(m_fg.Rows[v_row][(int)e_col_Number.tienck]);
                }
                if(m_fg.Rows[v_row][(int)e_col_Number.tien] != null && m_fg.Rows[v_row][(int)e_col_Number.tien].ToString() != "") {
                    tien = tien + CIPConvert.ToDecimal(m_fg.Rows[v_row][(int)e_col_Number.tien]);
                }
            }
            //Hiển thị
            if(cuoc == 0) {
                m_lbl_cuoc.Text = "0";
            }
            else m_lbl_cuoc.Text = CIPConvert.ToStr(cuoc);
            if(phi == 0) {
                m_lbl_phi.Text = "0";
            }
            else m_lbl_phi.Text = CIPConvert.ToStr(phi, "#,###");
            if(phixd == 0) {
                m_lbl_phi_xd.Text = "0";
            }
            else m_lbl_phi_xd.Text = CIPConvert.ToStr(phixd, "#,###");
            if(tienck == 0) {
                m_lbl_tienck.Text = "0";
            }
            else m_lbl_tienck.Text = CIPConvert.ToStr(tienck, "#,###");
            if(tien == 0) {
                m_lbl_tien.Text = "0";
            }
            else {
                m_lbl_tien.Text = CIPConvert.ToStr(tien, "#,###");
                m_lbl_vat.Text = CIPConvert.ToStr(tien / 10, "#,###");
                m_lbl_tong_tien.Text = CIPConvert.ToStr(tien + tien / 10, "#,###");
            }
        }

        private void so_sanh() {
            //Concept: Kiểm tra từng số bill ở trong file excel của NCC, 
            //nếu tồn tại trong CSDL (bảng DM bill) thì update số tiền bằng mã bill
            //Bản ghi nào update xong thì trên lưới xóa bỏ hàng đó đi, cuối cùng còn chừa lại những mã bill của ncc chưa đc
            //update vào pm (do trên phần mềm ko có mã bill đó hoặc nhập sai)

            C1.Win.C1FlexGrid.CellStyle v_cell_style_not_in_db = this.m_fg.Styles.Add("RowColorNotInDb");
            v_cell_style_not_in_db.BackColor = Color.Red;
            C1.Win.C1FlexGrid.CellStyle v_cell_style_ton_tai_tien = this.m_fg.Styles.Add("RowColorTonTaiTien");
            v_cell_style_ton_tai_tien.BackColor = Color.Gold;
            C1.Win.C1FlexGrid.CellStyle v_cell_style_ok = this.m_fg.Styles.Add("RowColorOk");
            v_cell_style_ok.BackColor = Color.Yellow;

            List<CError_ton_tai_bill> v_listError_ton_tai_bill = new List<CError_ton_tai_bill>();
            List<CError_ton_tai_tien> v_listError_ton_tai_tien = new List<CError_ton_tai_tien>();

            int v_amount_row = m_fg.Rows.Count - 1;
            Int64 count_bill_update = 0;

            //Kiểm tra các tổng tiền đúng chưa?

            for(int v_row = m_fg.Rows.Fixed; v_row < v_amount_row; v_row++) {
                /* Kiểm tra xem số bill có trên csdl chưa. Nếu không có thì kệ trên lưới, xuất lỗi ra listbox*/
                if(m_fg[v_row, (int)e_col_Number.barcode] == null || m_fg[v_row, (int)e_col_Number.barcode].ToString() == "") {
                    return;
                }
                string v_so_bill = CIPConvert.ToStr(m_fg[v_row, (int)e_col_Number.barcode]);

                if(!check_so_bill_in_db(CIPConvert.ToStr(m_fg[v_row, (int)e_col_Number.barcode]))) {
                    CError_ton_tai_bill v_error_exist = new CError_ton_tai_bill();
                    v_error_exist.name = CIPConvert.ToStr(m_fg[v_row, (int)e_col_Number.barcode]);
                    v_error_exist.value = CIPConvert.ToStr(m_fg[v_row, (int)e_col_Number.barcode]);;
                    v_listError_ton_tai_bill.Add(v_error_exist);

                    m_fg.SetCellStyle(v_row, (int)e_col_Number.barcode, v_cell_style_not_in_db);
                    continue;
                }

                //Kiểm tra xem bill đã có tiền chưa?
                US_DM_BILL v_us_dm_bill = new US_DM_BILL();
                if(!check_so_tien_is_null(v_us_dm_bill, CIPConvert.ToStr(m_fg[v_row, (int)e_col_Number.barcode]))) {
                    CError_ton_tai_tien v_error_null = new CError_ton_tai_tien();
                    v_error_null.name = CIPConvert.ToStr(m_fg[v_row, (int)e_col_Number.barcode]);
                    v_error_null.value = CIPConvert.ToStr(m_fg[v_row, (int)e_col_Number.barcode]); ;
                    v_listError_ton_tai_tien.Add(v_error_null);

                    m_fg.SetCellStyle(v_row, (int)e_col_Number.barcode, v_cell_style_ton_tai_tien);
                    continue;
                }
                else {
                    m_fg.SetCellStyle(v_row, (int)e_col_Number.barcode, v_cell_style_ok);
                    v_us_dm_bill.update_tien_by_so_bill(CIPConvert.ToStr(m_fg[v_row, (int)e_col_Number.barcode]), CIPConvert.ToDecimal(m_fg[v_row, (int)e_col_Number.tien]));
                    count_bill_update = count_bill_update + 1;
                }
                if(m_fg.Rows.Count == 3)
                    m_fg.Rows[1].Clear(C1.Win.C1FlexGrid.ClearFlags.All);
                else {
                    m_fg.RemoveItem(v_row);
                    v_row = v_row - 1;
                }
            }
            MessageBox.Show("Đã cập nhật số tiền chi phí cho " + count_bill_update + " bill, " + (v_amount_row - 1 - count_bill_update) + " bill chưa cập nhật!");
            //Gán lôi không tồn tại bill
            m_lbox_ds_loi_bill.DataSource = v_listError_ton_tai_bill;
            m_lbox_ds_loi_bill.DisplayMember = "name";
            m_lbox_ds_loi_bill.ValueMember = "value";
            //Gán lỗi đã có số tiền
            m_lbox_ds_loi_tien.DataSource = v_listError_ton_tai_tien;
            m_lbox_ds_loi_tien.DisplayMember = "name";
            m_lbox_ds_loi_tien.ValueMember = "value";
        }

        private Int64 count_record_in_grid(C1.Win.C1FlexGrid.C1FlexGrid i_fg) {
            Int64 v_count = 0;
            for(int v_row = m_fg.Rows.Fixed; v_row < m_fg.Rows.Count - 1; v_row++) {
                if(i_fg.Rows[v_row][(int)e_col_Number.barcode] != null && i_fg.Rows[v_row][(int)e_col_Number.barcode].ToString() != "")
                    v_count = v_count + 1;
            }
            return v_count;
        }

        private void make_stt(C1.Win.C1FlexGrid.C1FlexGrid i_fg) {
            CGridUtils.MakeSoTT(0, i_fg);
            i_fg.Rows[i_fg.Rows.Count - 1].Clear(C1.Win.C1FlexGrid.ClearFlags.All);
        }

        private void set_define_event() {
            m_cmd_thoat.Click += new EventHandler(m_cmd_thoat_Click);
            m_cmd_nhap_excel.Click += new EventHandler(m_cmd_nhap_excel_Click);
            m_cmd_so_sanh.Click += new EventHandler(m_cmd_so_sanh_Click);
            //m_cmd_kiem_tra_dl.Click += new EventHandler(m_cmd_kiem_tra_dl_Click);
            m_lbox_ds_loi_bill.Click += new EventHandler(m_lbox_ds_loi_Click);
            m_cmd_del.Click += new EventHandler(m_cmd_del_Click);
            m_cmd_insert_row.Click += m_cmd_insert_row_Click;
        }

      

        #endregion
        //
        // Event Handlers
        //
        private void m_cmd_insert_row_Click(object sender, EventArgs e)
        {
            try
            {
                m_fg.Rows.Insert(m_fg.Row);
                m_lbl_tong_so_bill.Text = CIPConvert.ToStr(count_record_in_grid(m_fg));
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_del_Click(object sender, EventArgs e) {
            try {
                if(m_fg.Rows.Count == 3) {
                    if(m_fg.Row == 1) {
                        m_fg.Rows[m_fg.Rows.Fixed].Clear(C1.Win.C1FlexGrid.ClearFlags.All);
                    }
                    m_lbl_tong_so_bill.Text = CIPConvert.ToStr(count_record_in_grid(m_fg));
                    return;
                }
                m_fg.Rows.Remove(m_fg.Row);
                //CGridUtils.MakeSoTT(0, m_fg);
                m_lbl_tong_so_bill.Text = CIPConvert.ToStr(count_record_in_grid(m_fg));
                make_stt(m_fg);
                hien_thi_tong_tien();
                //set_color_ma_bill_da_ton_tai();
            }
            catch(System.Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_lbox_ds_loi_Click(object sender, EventArgs e) {
            if(m_lbox_ds_loi_bill.Items.Count == 0) {
                return;                
            }
            for(int v_row = m_fg.Rows.Fixed; v_row < m_fg.Rows.Count - 1; v_row++) {
                if(m_fg.Rows[v_row][(int)e_col_Number.barcode].ToString() != "" && m_fg.Rows[v_row][(int)e_col_Number.barcode] != null)
                    if(m_lbox_ds_loi_bill.SelectedValue.ToString() == m_fg.Rows[v_row][(int)e_col_Number.barcode].ToString())
                        m_fg.Select(v_row, (int)e_col_Number.barcode);
            }
        }
        private void m_cmd_so_sanh_Click(object sender, EventArgs e) {
            try {
                so_sanh();
                hien_thi_tong_tien();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_nhap_excel_Click(object sender, EventArgs e) {
            try {
                if(m_status == (int)status.begin) {
                    load_danh_sach_excel();
                    m_lbl_tong_so_bill.Text = CIPConvert.ToStr(count_record_in_grid(m_fg));
                    m_status = (int)status.ok_import;
                    hien_thi_tong_tien();
                    make_stt(m_fg);
                }
                else {
                    if(BaseMessages.MsgBox_Confirm("Bạn có muốn nhập lại từ file Excel?")) {
                        remove_row_after_nhap_lai();
                        m_lbox_ds_loi_bill.DataSource = null;
                        load_danh_sach_excel();
                        m_lbl_tong_so_bill.Text = CIPConvert.ToStr(count_record_in_grid(m_fg));
                        m_status = (int)status.ok_import;
                        hien_thi_tong_tien();
                        make_stt(m_fg);
                    }
                }
            }
            catch(Exception v_e) {
                m_status = (int)status.fail_import;
                BaseMessages.MsgBox_Error("Bạn không chọn file Excel /hoặc file Excel không đúng mẫu/ hoặc file Excel đang được mở!");
                m_lbox_ds_loi_bill.DataSource = null;
                //CSystemLog_301.ExceptionHandle(v_e);
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
