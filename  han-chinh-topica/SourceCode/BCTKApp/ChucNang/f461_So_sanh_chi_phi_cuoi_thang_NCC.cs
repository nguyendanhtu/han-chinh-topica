using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using IP.Core.IPExcelReport;
using NExcel;

namespace BCTKApp.ChucNang
{
    public partial class f461_So_sanh_chi_phi_cuoi_thang_NCC : Form
    {
        public f461_So_sanh_chi_phi_cuoi_thang_NCC()
        {
            InitializeComponent();
        }

        #region Public interface
        #endregion

        #region Data structure
        #endregion

        #region Members
        #endregion

        #region Private method
        private void format_controls()
        {
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
        private void load_danh_sach_excel()
        {
            //Chọn đường dẫn tới file excel
            var m_obj_dialog = new System.Windows.Forms.OpenFileDialog();
            m_obj_dialog.ShowDialog();

            //Mở sheet đầu tiên
            Workbook wb = null;
            wb = Workbook.getWorkbook(m_obj_dialog.FileName);
            Sheet sheet = wb.getSheet(0);
            //->Cái này để thêm hàng vào grid, cho tới khi row ở cột barcode rỗng
            int v_count_row = 1;
            while (sheet.getCell(3, v_count_row).Contents != "")
            {
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
            for (int v_i_cur_col = m_fg.Cols.Fixed; v_i_cur_col < m_fg.Cols.Count; v_i_cur_col++)
            {
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
            m_fg.Select(0, 0);
        }
        private void set_define_event()
        {
            //m_cmd_thoat.Click += new EventHandler(m_cmd_thoat_Click);
            m_cmd_nhap_excel.Click += new EventHandler(m_cmd_nhap_excel_Click);
            //m_cmd_so_sanh.Click += new EventHandler(m_cmd_so_sanh_Click);
            //m_cmd_kiem_tra_dl.Click += new EventHandler(m_cmd_kiem_tra_dl_Click);
            //m_lbox_ds_loi_bill.Click += new EventHandler(m_lbox_ds_loi_Click);
            //m_cmd_del.Click += new EventHandler(m_cmd_del_Click);
            //m_cmd_insert_row.Click += m_cmd_insert_row_Click;
        }
        #endregion

        #region Event
        private void m_cmd_nhap_excel_Click(object sender, EventArgs e)
        {
            try
            {
                //if (m_status == (int)status.begin)
                //{
                load_danh_sach_excel();
                //    m_lbl_tong_so_bill.Text = CIPConvert.ToStr(count_record_in_grid(m_fg));
                //    m_status = (int)status.ok_import;
                //    hien_thi_tong_tien();
                //    make_stt(m_fg);
                //}
                //else
                //{
                //    if (BaseMessages.MsgBox_Confirm("Bạn có muốn nhập lại từ file Excel?"))
                //    {
                //        remove_row_after_nhap_lai();
                //        m_lbox_ds_loi_bill.DataSource = null;
                //        load_danh_sach_excel();
                //        m_lbl_tong_so_bill.Text = CIPConvert.ToStr(count_record_in_grid(m_fg));
                //        m_status = (int)status.ok_import;
                //        hien_thi_tong_tien();
                //        make_stt(m_fg);
                //    }
                //}
            }
            catch (Exception v_e)
            {
                //m_status = (int)status.fail_import;
                //BaseMessages.MsgBox_Error("Bạn không chọn file Excel /hoặc file Excel không đúng mẫu/ hoặc file Excel đang được mở!");
                //m_lbox_ds_loi_bill.DataSource = null;
                //CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

    }
}
