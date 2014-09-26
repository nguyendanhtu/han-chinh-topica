using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;
using BCTKUS;
using BCTKDS;
using BCTKDS.CDBNames;
using System.Collections;
using IP.Core.IPExcelReport;
using System.Data.OleDb;
using NExcel;

namespace BCTKApp.ChucNang {
    public partial class f810_DANG_KY_GUI_THEO_BUU : Form {
        public f810_DANG_KY_GUI_THEO_BUU() {
            InitializeComponent();
            format_control();
            set_initial_form_load();
        }

        #region Public Interface
        public void display() {
            this.ShowDialog();
        }
        #endregion

        #region Data structure
        private enum e_col_Number {
            SO_BILL = 1,
            MA_PHONG_BAN = 2,
            TEN_PHONG_BAN = 3,
            NGUOI_GUI = 4,
            NGUOI_NHAN = 5,
            NOI_NHAN = 6,
            LOAI_THU = 7,
            NOI_DUNG = 8,
            GHI_CHU = 9
        }
        private enum e_col_Excel {
            SO_BILL = 2,
            MA_PHONG_BAN = 12,
            TEN_PHONG_BAN = 12,
            NGUOI_GUI = 5,
            NGUOI_NHAN = 6,
            NOI_NHAN = 7,
            LOAI_THU = 8,
            NOI_DUNG = 9,
            GHI_CHU = 10
        }
        #endregion

        #region Members

        #endregion

        #region Private Methods
        private void format_control() {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            this.m_lbl_tieu_de.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            m_fg.AllowAddNew = true;
            m_fg.AllowEditing = true;
            m_fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            m_fg.AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.None;
            m_fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcrossOut;
            m_fg.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcrossOut;
            progressBar1.Visible = false;
            m_lbl_loading.Visible = false;
            set_define_events();
            this.KeyPreview = true;
        }

        private System.Collections.IDictionary get_mapping_col_ma_phong_ban() {
            Hashtable v_hst = new Hashtable();

            US_DM_PHONG_BAN v_us_dm_phong_ban = new US_DM_PHONG_BAN();
            DS_DM_PHONG_BAN v_ds_dm_phong_ban = new DS_DM_PHONG_BAN();

            v_us_dm_phong_ban.FillDataset(v_ds_dm_phong_ban);


            foreach(DataRow v_dr in v_ds_dm_phong_ban.DM_PHONG_BAN.Rows) {
                v_hst.Add(v_dr[DM_PHONG_BAN.ID], v_dr[DM_PHONG_BAN.MA_PHONG_BAN]);
            }
            return v_hst;
        }
        private void load_cbo_phong_ban_2_grid() {
            m_fg.Cols[(int)e_col_Number.MA_PHONG_BAN].DataMap = get_mapping_col_ma_phong_ban();
        }

        private IDictionary get_mapping_col_ten_phong_ban() {
            Hashtable v_hst = new Hashtable();

            US_DM_PHONG_BAN v_us_dm_phong_ban = new US_DM_PHONG_BAN();
            DS_DM_PHONG_BAN v_ds_dm_phong_ban = new DS_DM_PHONG_BAN();

            v_us_dm_phong_ban.FillDataset(v_ds_dm_phong_ban);


            foreach(DataRow v_dr in v_ds_dm_phong_ban.DM_PHONG_BAN.Rows) {
                v_hst.Add(v_dr[DM_PHONG_BAN.ID], v_dr[DM_PHONG_BAN.TEN_PHONG_BAN]);
            }
            return v_hst;
        }
        private void load_ten_phong_ban_tuong_ung_2_grid() {
            m_fg.Cols[(int)e_col_Number.TEN_PHONG_BAN].DataMap = get_mapping_col_ten_phong_ban();
        }

        private void load_cbo_loai_thu_2_grid() {
            Hashtable v_hst = new Hashtable();
            v_hst.Add("Trong nước", "Trong nước");
            v_hst.Add("Ngoài nước", "Ngoài nước");

            m_fg.Cols[(int)e_col_Number.LOAI_THU].DataMap = v_hst;
        }

        private void set_initial_form_load() {
            m_dat_ngay_gui.Text = CIPConvert.ToStr(DateTime.Now.Date, "dd/MM/yyyy");
            load_cbo_phong_ban_2_grid();
            load_cbo_loai_thu_2_grid();
            load_ten_phong_ban_tuong_ung_2_grid();
        }

        private Hashtable get_mapping_col_excel_grid() {
            Hashtable v_hst = new Hashtable();
            v_hst.Add((int)e_col_Number.SO_BILL, (int)e_col_Excel.SO_BILL);
            v_hst.Add((int)e_col_Number.MA_PHONG_BAN, (int)e_col_Excel.MA_PHONG_BAN);
            v_hst.Add((int)e_col_Number.TEN_PHONG_BAN, (int)e_col_Excel.TEN_PHONG_BAN);
            v_hst.Add((int)e_col_Number.NGUOI_GUI, (int)e_col_Excel.NGUOI_GUI);
            v_hst.Add((int)e_col_Number.NGUOI_NHAN, (int)e_col_Excel.NGUOI_NHAN);
            v_hst.Add((int)e_col_Number.NOI_NHAN, (int)e_col_Excel.NOI_NHAN);
            v_hst.Add((int)e_col_Number.LOAI_THU, (int)e_col_Excel.LOAI_THU);
            v_hst.Add((int)e_col_Number.NOI_DUNG, (int)e_col_Excel.NOI_DUNG);
            v_hst.Add((int)e_col_Number.GHI_CHU, (int)e_col_Excel.GHI_CHU);

            return v_hst;
        }
        private void load_excel_2_grid(C1.Win.C1FlexGrid.C1FlexGrid m_fg) {
            var m_obj_dialog = new System.Windows.Forms.OpenFileDialog();
            DialogResult v_result = new DialogResult();
            v_result = m_obj_dialog.ShowDialog();

            if(v_result == DialogResult.Cancel) {
                BaseMessages.MsgBox_Infor("Bạn chưa chọn file Excel!");
                m_obj_dialog.Dispose();
                return;
            }
            Workbook wb = null;
            wb = Workbook.getWorkbook(m_obj_dialog.FileName);
            Sheet sheet = wb.getSheet(0);
            //Cái này để thêm hàng vào grid
            int v_count_row = 7;
            while(sheet.getCell(2, v_count_row).Contents != "") {
                v_count_row = v_count_row + 1;
                m_fg.Rows.Add();
            }
            wb.close();

            Hashtable v_hst_excel_col = get_mapping_col_excel_grid();
            CExcelReport v_obj_excel_rpt = new CExcelReport(m_obj_dialog.FileName);
            int v_i_start_excel_row = 7;

            for(int v_i_cur_col = m_fg.Cols.Fixed; v_i_cur_col < m_fg.Cols.Count; v_i_cur_col++) {
                m_lbl_loading.Visible = true;
                progressBar1.Visible = true;
                progressBar1.Minimum = m_fg.Cols.Fixed;
                progressBar1.Maximum = m_fg.Cols.Count;
                progressBar1.Value = v_i_cur_col;
                v_obj_excel_rpt.Export2Grid(m_fg,
                    v_i_start_excel_row
                    , (int)v_hst_excel_col[v_i_cur_col]
                    , v_i_cur_col);
            }
            m_lbl_tong_so_bill.Text = CIPConvert.ToStr(count_record_in_grid(m_fg));
            make_stt(m_fg);
            m_lbl_loading.Visible = false;
            progressBar1.Visible = false;
            m_fg.Select(0, 0);
        }

        private bool check_validate_grid_is_ok() {
            //Check nội dung các ô xem có null hay không
            for(int v_i_cur_row = m_fg.Rows.Fixed; v_i_cur_row < m_fg.Rows.Count - 1; v_i_cur_row++) {
                if(m_fg[v_i_cur_row, (int)e_col_Number.SO_BILL] == null /*|| CIPConvert.ToStr(m_fg[v_i_cur_row, (int)e_col_Number.SO_BILL]) == ""*/) {
                    BaseMessages.MsgBox_Infor("Bạn chưa nhập SỐ BILL");
                    m_fg.Select(v_i_cur_row, (int)e_col_Number.SO_BILL);
                    return false;
                }
                if(m_fg[v_i_cur_row, (int)e_col_Number.MA_PHONG_BAN] == null || CIPConvert.ToStr(m_fg[v_i_cur_row, (int)e_col_Number.MA_PHONG_BAN]) == "") {
                    BaseMessages.MsgBox_Infor("Bạn chưa nhập MÃ PHÒNG BAN");
                    m_fg.Select(v_i_cur_row, (int)e_col_Number.MA_PHONG_BAN);
                    return false;
                }
                if(m_fg[v_i_cur_row, (int)e_col_Number.NGUOI_GUI] == null || CIPConvert.ToStr(m_fg[v_i_cur_row, (int)e_col_Number.NGUOI_GUI]) == "") {
                    BaseMessages.MsgBox_Infor("Bạn chưa nhập NGƯỜI GỬI THƯ");
                    m_fg.Select(v_i_cur_row, (int)e_col_Number.NGUOI_GUI);
                    return false;
                }
                if(m_fg[v_i_cur_row, (int)e_col_Number.NGUOI_NHAN] == null || CIPConvert.ToStr(m_fg[v_i_cur_row, (int)e_col_Number.NGUOI_NHAN]) == "") {
                    BaseMessages.MsgBox_Infor("Bạn chưa nhập NGƯỜI NHẬN THƯ");
                    m_fg.Select(v_i_cur_row, (int)e_col_Number.NGUOI_NHAN);
                    return false;
                }
                if(m_fg[v_i_cur_row, (int)e_col_Number.NOI_NHAN] == null || CIPConvert.ToStr(m_fg[v_i_cur_row, (int)e_col_Number.NOI_NHAN]) == "") {
                    BaseMessages.MsgBox_Infor("Bạn chưa nhập NƠI NHẬN THƯ");
                    m_fg.Select(v_i_cur_row, (int)e_col_Number.NOI_NHAN);
                    return false;
                }
                if(m_fg[v_i_cur_row, (int)e_col_Number.LOAI_THU] == null || CIPConvert.ToStr(m_fg[v_i_cur_row, (int)e_col_Number.LOAI_THU]) == "") {
                    BaseMessages.MsgBox_Infor("Bạn chưa chọn LOẠI THƯ");
                    m_fg.Select(v_i_cur_row, (int)e_col_Number.LOAI_THU);
                    return false;
                }
            }
            return true;
        }
        private bool check_validate_is_ok() {
            if(!check_validate_grid_is_ok())
                return false;
            return true;
        }

        private void make_stt(C1.Win.C1FlexGrid.C1FlexGrid i_fg) {
            CGridUtils.MakeSoTT(0, i_fg);
            i_fg.Rows[i_fg.Rows.Count - 1].Clear(C1.Win.C1FlexGrid.ClearFlags.All);
        }
        private bool is_exist_bill_in_db(string ip_so_bill) {
            US_DM_BILL v_us_dm_bill = new US_DM_BILL();
            if(v_us_dm_bill.is_existed_bill(v_us_dm_bill, ip_so_bill)) {
                return true;
            }
            return false;
        }
        private void set_color_ma_bill_da_ton_tai(int ip_row_exist) {
            C1.Win.C1FlexGrid.CellStyle v_cell_style_notOK_in_data = this.m_fg.Styles.Add("RowColorNotOk");
            v_cell_style_notOK_in_data.BackColor = Color.Red;
            m_fg.SetCellStyle(ip_row_exist, (int)e_col_Number.SO_BILL, v_cell_style_notOK_in_data);
        }
        private Int64 count_record_in_grid(C1.Win.C1FlexGrid.C1FlexGrid i_fg) {
            Int64 v_count = 0;
            for(int v_row = m_fg.Rows.Fixed; v_row < m_fg.Rows.Count - 1; v_row++) {
                if(i_fg.Rows[v_row][(int)e_col_Number.SO_BILL] != null && i_fg.Rows[v_row][(int)e_col_Number.SO_BILL].ToString() != "")
                    v_count = v_count + 1;
            }
            return v_count;
        }

        private void grid_row_2_us_v_dm_bill(int ip_grid_row, US_V_DM_BILL iop_us_v_dm_bill) {
            iop_us_v_dm_bill.datNGAY_GUI
               = CIPConvert.ToDatetime(m_dat_ngay_gui.Text.Trim(), "dd/MM/yyyy");

            iop_us_v_dm_bill.strSO_BILL
                = CIPConvert.ToStr(m_fg[ip_grid_row, (int)e_col_Number.SO_BILL]);

            iop_us_v_dm_bill.dcID_PHONG_BAN
                = CIPConvert.ToDecimal(m_fg[ip_grid_row, (int)e_col_Number.MA_PHONG_BAN]);

            iop_us_v_dm_bill.strNGUOI_GUI
                = CIPConvert.ToStr(m_fg[ip_grid_row, (int)e_col_Number.NGUOI_GUI]);

            iop_us_v_dm_bill.strNGUOI_NHAN
                = CIPConvert.ToStr(m_fg[ip_grid_row, (int)e_col_Number.NGUOI_NHAN]);

            iop_us_v_dm_bill.strNOI_NHAN
                = CIPConvert.ToStr(m_fg[ip_grid_row, (int)e_col_Number.NOI_NHAN]);

            if(m_fg[ip_grid_row, (int)e_col_Number.NOI_DUNG] != null)
                iop_us_v_dm_bill.strNOI_DUNG
                    = CIPConvert.ToStr(m_fg[ip_grid_row, (int)e_col_Number.NOI_DUNG]);
            else iop_us_v_dm_bill.SetNOI_DUNGNull();

            if(m_fg[ip_grid_row, (int)e_col_Number.GHI_CHU] != null)
                iop_us_v_dm_bill.strGHI_CHU
                = CIPConvert.ToStr(m_fg[ip_grid_row, (int)e_col_Number.GHI_CHU]);
            else iop_us_v_dm_bill.SetGHI_CHUNull();

            iop_us_v_dm_bill.dcID_TRANG_THAI
                = CONST_ID_TRANG_THAI_THU.ID_DA_NHAN_NOI_BO;

            if(CIPConvert.ToStr(m_fg[ip_grid_row, (int)e_col_Number.LOAI_THU]) == "Trong nước")
                iop_us_v_dm_bill.strTRONG_NUOC = "x";
            else
                iop_us_v_dm_bill.strNUOC_NGOAI = "x";

            iop_us_v_dm_bill.SetSO_TIENNull();
            iop_us_v_dm_bill.SetTRANG_THAI_THUNull();
            iop_us_v_dm_bill.SetTEN_PHONG_BANNull();
            iop_us_v_dm_bill.SetTEN_PHONG_BANNull();
        }
        private void save_data() {
            //set_color_ma_bill_da_ton_tai();
            //Các bước:
            //B1. Kiểm tra dữ liệu trên grid, nếu sai thì không làm gì hết
            if(!check_validate_grid_is_ok())
                return;
            //B2. Nếu đúng rồi thì lưu thôi
            // Insert vào dm bill, cột số tiền để null
            DS_V_DM_BILL v_ds_v_dm_bill = new DS_V_DM_BILL();
            US_V_DM_BILL v_us_v_dm_bill = new US_V_DM_BILL();
            
            Int64 v_dem_bill = 0;
            for(int v_i_cur_row = m_fg.Rows.Fixed; v_i_cur_row < m_fg.Rows.Count - 1; v_i_cur_row++) {
                //Check xem tồn tại số bill trong CSDL chưa? Nếu có rồi tô màu đỏ
                if(is_exist_bill_in_db(CIPConvert.ToStr(m_fg.Rows[v_i_cur_row][(int)e_col_Number.SO_BILL]))) {
                    BaseMessages.MsgBox_Error("Đã tồn tại số bill " + CIPConvert.ToStr(m_fg.Rows[v_i_cur_row][(int)e_col_Number.SO_BILL]) + "này trong phần mềm!");
                    set_color_ma_bill_da_ton_tai(v_i_cur_row);
                    return;
                }
                //Đổ dữ liệu từ lưới lên us
                grid_row_2_us_v_dm_bill(v_i_cur_row, v_us_v_dm_bill);
                //Insert
                v_us_v_dm_bill.Insert();
                //Xóa hàng nếu insert thành công cho dễ nhìn
                if(m_fg.Rows.Count > 3) {
                    m_fg.Rows.Remove(v_i_cur_row);
                    v_i_cur_row = v_i_cur_row - 1;
                }
                else {
                    m_fg.Rows[v_i_cur_row].Clear(C1.Win.C1FlexGrid.ClearFlags.All);
                    
                }
                v_dem_bill++;
            }
            BaseMessages.MsgBox_Infor("Đã nhập thành công " + v_dem_bill + " Bill!");
        }

        private void set_define_events() {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
            m_fg.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(m_fg_AfterEdit);
            m_cmd_del.Click += new EventHandler(m_cmd_del_Click);
            m_fg.AfterAddRow += new C1.Win.C1FlexGrid.RowColEventHandler(m_fg_AfterAddRow);
            m_cmd_nhap_excel.Click += new EventHandler(m_cmd_nhap_excel_Click);
            //m_cmd_xem_thu_gui.Click += new EventHandler(m_cmd_xem_thu_gui_Click);
            m_cmd_danh_sach_bill.Click += new EventHandler(m_cmd_danh_sach_bill_Click);
        }
        #endregion

        #region Events
        private void m_cmd_danh_sach_bill_Click(object sender, EventArgs e) {
            try {
                f516_V_DM_BILL v_frm = new f516_V_DM_BILL();
                v_frm.display();
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
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
                m_lbl_tong_so_bill.Text =""+ count_record_in_grid(m_fg);
            }
            catch(System.Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_fg_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e) {
            if(m_fg.Col == (int)e_col_Number.MA_PHONG_BAN)
                m_fg.Rows[m_fg.Row][m_fg.Col + 1] = m_fg.Rows[m_fg.Row][m_fg.Col];
            if(m_fg.Col == (int)e_col_Number.TEN_PHONG_BAN)
                m_fg.Rows[m_fg.Row][m_fg.Col - 1] = m_fg.Rows[m_fg.Row][m_fg.Col];
            m_lbl_tong_so_bill.Text = CIPConvert.ToStr(count_record_in_grid(m_fg));

            if(m_fg.Col == (int)e_col_Number.SO_BILL)
            make_stt(m_fg);
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
                //set_color_ma_bill_da_ton_tai();
            }
            catch(System.Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_fg_AfterAddRow(object sender, C1.Win.C1FlexGrid.RowColEventArgs e) {
            try {
                m_lbl_tong_so_bill.Text = CIPConvert.ToStr(count_record_in_grid(m_fg));
                make_stt(m_fg);
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_nhap_excel_Click(object sender, EventArgs e) {
            try {
                load_excel_2_grid(m_fg);
            }
            catch(Exception v_e) {
                BaseMessages.MsgBox_Error("File Excel chưa đúng mẫu hoặc đang bị mở!");
                //CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
}
