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

using IP.Core.IPExcelReport;
using NExcel;

namespace BCTKApp.ChucNang
{
    public partial class f461_So_sanh_chi_phi_cuoi_thang_NCC : Form
    {
        public f461_So_sanh_chi_phi_cuoi_thang_NCC()
        {
            InitializeComponent();
            set_initial_form_load();
            format_controls();
        }

        #region Public interface
        #endregion

        #region Data structure
        private enum e_col_Number
        {
            NGAY = 1,
            MA_PHIEU = 2,
            MA_HD = 3,
            TEN_VPP = 4,
            DVT = 5,
            SO_LUONG = 6,
            GIA_BAN = 7,
            DOANH_THU = 8
        }		
        #endregion

        #region Members
        US_RPT_BANG_CHI_PHI_CUOI_THANG_NCC m_us = new US_RPT_BANG_CHI_PHI_CUOI_THANG_NCC();
        DS_RPT_BANG_CHI_PHI_CUOI_THANG_NCC m_ds = new DS_RPT_BANG_CHI_PHI_CUOI_THANG_NCC();
        ITransferDataRow m_obj_trans_xls;
        #endregion

        #region Private method
        private void set_initial_form_load()
        {
            m_obj_trans_xls = get_2_us_obj_xls();
        }
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
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            //Tree view
            //m_fg.Tree.Column = (int)e_col_Number.NGAY;
            //m_fg.Cols[(int)e_col_Number.NGAY].Visible = false;
            //m_fg.Cols[(int)e_col_Number.NGAY_GUI].Visible = false;
            //m_fg.Tree.Style = C1.Win.C1FlexGrid.TreeStyleFlags.ButtonBar;
            //m_fg.AutoResize = false;
            //progressBar1.Visible = false;
            set_define_event();
            m_lbl_loading.Visible = false;
            progressBar1.Visible = false;
            m_lbl_thong_bao_cap_nhat.Visible = false;
            this.KeyPreview = true;
        }
        private ITransferDataRow get_2_us_obj_xls()
        {
            Hashtable v_hst = new Hashtable();
            v_hst.Add(RPT_BANG_CHI_PHI_CUOI_THANG_NCC.NGAY, e_col_Number.NGAY);
            v_hst.Add(RPT_BANG_CHI_PHI_CUOI_THANG_NCC.MA_PHIEU, e_col_Number.MA_PHIEU);
            v_hst.Add(RPT_BANG_CHI_PHI_CUOI_THANG_NCC.MA_HD, e_col_Number.MA_HD);
            v_hst.Add(RPT_BANG_CHI_PHI_CUOI_THANG_NCC.TEN_VPP, e_col_Number.TEN_VPP);
            v_hst.Add(RPT_BANG_CHI_PHI_CUOI_THANG_NCC.SO_LUONG, e_col_Number.SO_LUONG);
            v_hst.Add(RPT_BANG_CHI_PHI_CUOI_THANG_NCC.DVT, e_col_Number.DVT);
            v_hst.Add(RPT_BANG_CHI_PHI_CUOI_THANG_NCC.GIA_BAN, e_col_Number.GIA_BAN);
            v_hst.Add(RPT_BANG_CHI_PHI_CUOI_THANG_NCC.DOANH_THU, e_col_Number.DOANH_THU);
            CC1TransferDataRow v_obj = new CC1TransferDataRow(m_fg, v_hst, m_ds.RPT_BANG_CHI_PHI_CUOI_THANG_NCC.NewRPT_BANG_CHI_PHI_CUOI_THANG_NCCRow());
            return v_obj;
        }
        //private void Export2Dataset_BangChiPhiCuoiThangNCC(string ip_path_and_file_name, System.Data.DataSet i_DataSet, int i_iSheetStartRow)
        //{
        //    // khởi tạo đường dẫn InitPath()
        //    string m_strOutputPath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Reports\\Templates\\";
        //    string m_strTemplatesPath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Reports\\Output\\";
        //    //Khởi tạo đối tượng Excel
        //    Excel.Application v_objExcelApp;
        //    Excel.Worksheet v_objExcelWorksheet;
        //    v_objExcelApp = new Excel.Application();
        //    try
        //    {
        //        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
        //        v_objExcelApp.Workbooks.Open(ip_path_and_file_name);
        //        v_objExcelApp.Workbooks[1].Worksheets.Select(1);
        //        v_objExcelWorksheet = (Excel.Worksheet)v_objExcelApp.Workbooks[1].Worksheets[1];
        //        int i_iExcelRow = 0;
        //        int i_iExcelCol = 0;
        //        bool v_bol_stop = false;
        //        while (!v_bol_stop)
        //        {
        //            System.Data.DataRow v_iDataRow;
        //            v_iDataRow = i_DataSet.Tables[0].NewRow();
        //            v_iDataRow[i_iExcelCol] = i_iExcelCol + 1;
        //            for (i_iExcelCol = 0; i_iExcelCol <= i_DataSet.Tables[0].Columns.Count - 2; i_iExcelCol++)
        //            {
        //                if (!object.ReferenceEquals(v_objExcelWorksheet.Cells[i_iExcelRow + i_iSheetStartRow, 3], null))
        //                {
        //                    if (!(v_objExcelWorksheet.Cells[i_iExcelRow + i_iSheetStartRow, i_iExcelCol + 1] == null))
        //                    {
        //                        v_iDataRow[i_iExcelCol + 1] = v_objExcelWorksheet.Cells[i_iExcelRow + i_iSheetStartRow, i_iExcelCol + 1];
        //                    }
        //                }
        //                else
        //                {
        //                    v_bol_stop = true;
        //                }
        //            }
        //            if (!v_bol_stop)
        //            {
        //                i_DataSet.Tables[0].Rows.InsertAt(v_iDataRow, i_iExcelRow);
        //                i_iExcelRow += 1;
        //            }
        //        }
        //        v_objExcelApp.Workbooks.Close();
        //        v_objExcelApp.Quit();
        //        //Unmount
        //        v_objExcelWorksheet = null;
        //        v_objExcelApp = null;
        //    }
        //    catch (Exception v_e)
        //    {
        //        v_objExcelApp.Workbooks.Close();
        //        //Unmount
        //        v_objExcelWorksheet = null;
        //        v_objExcelApp = null;
        //        throw v_e;
        //    }
        //}
        private void load_danh_sach_excel()
        {
            if (m_OpenFile_dlg.ShowDialog() == DialogResult.OK)
            {
                string v_str_path_and_file_name = m_OpenFile_dlg.FileName;
                string v_str_file_name = v_str_path_and_file_name.Substring(v_str_path_and_file_name.LastIndexOf("\\") + 1, v_str_path_and_file_name.Length - v_str_path_and_file_name.LastIndexOf("\\") - 1);
                CExcelReport v_xls_file = new CExcelReport(v_str_path_and_file_name);
                try
                {
                    m_lbl_thong_bao_cap_nhat.Visible = false;
                    m_lbl_loading.Visible = true;
                    m_ds.EnforceConstraints = false;
                    //Export2Dataset_BangChiPhiCuoiThangNCC(v_str_path_and_file_name, v_ds, 14);
                    v_xls_file.Export2DatasetDSPhongThi(m_ds, m_ds.RPT_BANG_CHI_PHI_CUOI_THANG_NCC.TableName, 14);

                    //set MA_HD_NCC cho từng bản ghi
                    //int v_i_row_fg = 0;
                    //string v_str_ma_don_hang_ncc = "";

                    //for (v_i_row_fg = 0; v_i_row_fg < m_ds.RPT_BANG_CHI_PHI_CUOI_THANG_NCC.Count; v_i_row_fg++)
                    //{
                    //    if (m_ds.RPT_BANG_CHI_PHI_CUOI_THANG_NCC.Rows[v_i_row_fg][2].ToString() != "")
                    //    {
                    //        v_str_ma_don_hang_ncc = m_ds.RPT_BANG_CHI_PHI_CUOI_THANG_NCC.Rows[v_i_row_fg][2].ToString();
                    //    }
                    //    else
                    //    {
                    //        m_ds.RPT_BANG_CHI_PHI_CUOI_THANG_NCC.Rows[v_i_row_fg][2] = v_str_ma_don_hang_ncc;
                    //    }
                    //}

                    //set NGAY cho từng hóa đơn
                    //v_i_row_fg = 0;
                    //DateTime v_dat_ngay = DateTime.Parse(m_ds.RPT_BANG_CHI_PHI_CUOI_THANG_NCC.Rows[v_i_row_fg][1].ToString());
                    //for (v_i_row_fg = 0; v_i_row_fg < m_ds.RPT_BANG_CHI_PHI_CUOI_THANG_NCC.Count; v_i_row_fg++)
                    //{
                    //    if (m_ds.RPT_BANG_CHI_PHI_CUOI_THANG_NCC.Rows[v_i_row_fg][1].ToString() != "")
                    //    {
                    //        v_dat_ngay = DateTime.Parse(m_ds.RPT_BANG_CHI_PHI_CUOI_THANG_NCC.Rows[v_i_row_fg][1].ToString());
                    //    }
                    //    else
                    //    {
                    //        m_ds.RPT_BANG_CHI_PHI_CUOI_THANG_NCC.Rows[v_i_row_fg][1] = v_dat_ngay;
                    //    }
                    //}

                    // Đưa dữ liệu lên lưới:
                    CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans_xls);
                    
                    //CGridUtils.MakeSoTT(0, m_fg);
                    //m_fg.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Count // chỗ này dùng hàm count tức là để đếm, có thể dùng các hàm khác thay thế
                    //    , 0
                    //    , (int)e_col_Number.NGAY // chỗ này là tên trường mà mình nhóm
                    //    , (int)e_col_Number.TEN_VPP // chỗ này là tên trường mà mình Count
                    //     , "{0}"
                    //     );
                    //m_fg.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum
                    //    , 0
                    //    , (int)e_col_Number.NGAY
                    //    , (int)e_col_Number.DOANH_THU
                    //    , "{0}"
                    //    );
                    //m_fg.Redraw = true;
                    //m_fg.Tree.Show(1);
        
                    //m_lbl_tong_so_luong.Text = CIPConvert.ToStr(m_fg_load_file.Rows.Count - 1);
                    
                    //set mã hóa đơn MA_HD cho từng bản ghi
                    //int v_i_row_fg = 0;
                    //string v_str_ma_don_hang_ncc = "";
                    //for (v_i_row_fg = 0; v_i_row_fg < m_ds.RPT_BANG_CHI_PHI_CUOI_THANG_NCC.Count; v_i_row_fg++)
                    //{
                    //    if (m_ds.RPT_BANG_CHI_PHI_CUOI_THANG_NCC.Rows[v_i_row_fg][(int)e_col_Number.MA_HD].ToString() != "")
                    //    {
                    //        v_str_ma_don_hang_ncc = m_ds.RPT_BANG_CHI_PHI_CUOI_THANG_NCC.Rows[v_i_row_fg][(int)e_col_Number.MA_HD].ToString();
                    //    }
                    //    else
                    //    {
                    //        m_ds.RPT_BANG_CHI_PHI_CUOI_THANG_NCC.Rows[v_i_row_fg][(int)e_col_Number.MA_HD] = v_str_ma_don_hang_ncc;
                    //    }
                    //}
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
        private void so_sanh_chi_phi_voi_don_hang()
        {
            US_V_GD_DON_DAT_HANG_DETAIL v_us_v_don_dat_hang_de = new US_V_GD_DON_DAT_HANG_DETAIL();
            DS_V_GD_DON_DAT_HANG_DETAIL v_ds_v_don_dat_hang_de = new DS_V_GD_DON_DAT_HANG_DETAIL();
            int v_i_row_fg = 0;
            int v_i_ds = 0;

            //set Style cell
             C1.Win.C1FlexGrid.CellStyle v_cell_style_err = this.m_fg.Styles.Add("RowColorErr");
                v_cell_style_err.BackColor = Color.Red;
                C1.Win.C1FlexGrid.CellStyle v_cell_style_err2 = this.m_fg.Styles.Add("RowColorErr2");
                v_cell_style_err2.BackColor = Color.Yellow;
                v_cell_style_err2.ForeColor = Color.DarkRed;

                C1.Win.C1FlexGrid.CellStyle v_cell_style_ok = this.m_fg.Styles.Add("RowColorOk");
                v_cell_style_ok.BackColor = Color.White;
                C1.Win.C1FlexGrid.CellStyle v_cell_style_chu_ok = this.m_fg.Styles.Add("RowColor");
                v_cell_style_chu_ok.BackColor = Color.Black;

                C1.Win.C1FlexGrid.CellStyle v_cell_style_notOK_in_data = this.m_fg.Styles.Add("RowColorNotOk");
                v_cell_style_notOK_in_data.BackColor = Color.Green;
          
           //so sánh từng hóa đơn với MA_PHIEU trong cơ sở dữ liệu
                for (v_i_row_fg = 1, v_i_ds = 0; v_i_ds < m_ds.RPT_BANG_CHI_PHI_CUOI_THANG_NCC.Count; v_i_row_fg++, v_i_ds++)
            {
                m_lbl_loading.Visible = true;
                progressBar1.Visible = true;
                progressBar1.Minimum = 0;
                progressBar1.Maximum = m_ds.RPT_BANG_CHI_PHI_CUOI_THANG_NCC.Count;
                progressBar1.Value = v_i_row_fg;
                v_us_v_don_dat_hang_de.So_sanh_hoa_don_theo_ma_NCC(v_ds_v_don_dat_hang_de, m_ds.RPT_BANG_CHI_PHI_CUOI_THANG_NCC.Rows[v_i_ds][(int)e_col_Number.MA_PHIEU].ToString(), m_ds.RPT_BANG_CHI_PHI_CUOI_THANG_NCC.Rows[v_i_ds][(int)e_col_Number.TEN_VPP].ToString());
                if (v_ds_v_don_dat_hang_de.V_GD_DON_DAT_HANG_DETAIL.Rows.Count > 0)
                {
                    if (CIPConvert.ToDecimal(m_ds.RPT_BANG_CHI_PHI_CUOI_THANG_NCC.Rows[v_i_ds][(int)e_col_Number.SO_LUONG]) != CIPConvert.ToDecimal(v_ds_v_don_dat_hang_de.V_GD_DON_DAT_HANG_DETAIL.Rows[0]["SO_LUONG"]))
                    {
                        m_fg.SetCellStyle(v_i_row_fg, (int)e_col_Number.SO_LUONG, v_cell_style_err2);
                    }
                    if (CIPConvert.ToDecimal(m_ds.RPT_BANG_CHI_PHI_CUOI_THANG_NCC.Rows[v_i_ds][(int)e_col_Number.GIA_BAN]) != CIPConvert.ToDecimal(v_ds_v_don_dat_hang_de.V_GD_DON_DAT_HANG_DETAIL.Rows[0]["DON_GIA_CHUA_VAT"]))
                    {
                        m_fg.SetCellStyle(v_i_row_fg, (int)e_col_Number.GIA_BAN, v_cell_style_err2);
                    }
                    if (CIPConvert.ToDecimal(m_ds.RPT_BANG_CHI_PHI_CUOI_THANG_NCC.Rows[v_i_ds][(int)e_col_Number.DOANH_THU]) != (CIPConvert.ToDecimal(v_ds_v_don_dat_hang_de.V_GD_DON_DAT_HANG_DETAIL.Rows[0]["DON_GIA_CHUA_VAT"]) * CIPConvert.ToDecimal(v_ds_v_don_dat_hang_de.V_GD_DON_DAT_HANG_DETAIL.Rows[0]["SO_LUONG"])))
                    {
                        m_fg.SetCellStyle(v_i_row_fg, (int)e_col_Number.DOANH_THU, v_cell_style_err2);
                    }
                }
                else
                {
                    m_fg.SetCellStyle(v_i_row_fg, (int)e_col_Number.TEN_VPP, v_cell_style_err);
                    //m_fg.Rows[v_i_row_fg].StyleDisplay.ForeColor = Color.White;
                }
                v_ds_v_don_dat_hang_de.Clear();
            }
            m_lbl_loading.Visible = false;
            progressBar1.Visible = false;
        }
        private void export_2_excel()
        {
            CExcelReport v_obj_excel_report = new CExcelReport("F461_Bao_cao_so_sanh_chi_phi_cuoi_thang.xls", 8, 1);
            v_obj_excel_report.AddFindAndReplaceItem("<ngay>", DateTime.Now.ToShortDateString());
            v_obj_excel_report.FindAndReplace(false);
            v_obj_excel_report.Export2ExcelWithoutFixedRows(m_fg, 0, m_fg.Cols.Count - 1, true);
        }

        private void cap_nhat_gridview()
        {
            C1.Win.C1FlexGrid.CellStyle v_cell_style_err = this.m_fg.Styles.Add("RowColorErr");
            v_cell_style_err.BackColor = Color.Red;
            US_V_GD_DON_DAT_HANG_DETAIL v_us_v_don_dat_hang_de = new US_V_GD_DON_DAT_HANG_DETAIL();
            DS_V_GD_DON_DAT_HANG_DETAIL v_ds_v_don_dat_hang_de = new DS_V_GD_DON_DAT_HANG_DETAIL();
            int v_i_row_fg = 0;
            int v_i_m_ds = 0;
            for (v_i_row_fg = 1, v_i_m_ds=0 ; v_i_row_fg < m_fg.Rows.Count; v_i_row_fg++, v_i_m_ds++)
            {
                m_lbl_loading.Visible = true;
                progressBar1.Visible = true;
                progressBar1.Minimum = 0;
                progressBar1.Maximum = m_ds.RPT_BANG_CHI_PHI_CUOI_THANG_NCC.Count;
                progressBar1.Value = v_i_row_fg;
                v_us_v_don_dat_hang_de.So_sanh_hoa_don_theo_ma_NCC(v_ds_v_don_dat_hang_de, m_ds.RPT_BANG_CHI_PHI_CUOI_THANG_NCC.Rows[v_i_m_ds][(int)e_col_Number.MA_PHIEU].ToString(), m_ds.RPT_BANG_CHI_PHI_CUOI_THANG_NCC.Rows[v_i_m_ds][(int)e_col_Number.TEN_VPP].ToString());
                    if (v_ds_v_don_dat_hang_de.V_GD_DON_DAT_HANG_DETAIL.Rows.Count > 0)
                    {
                        decimal test = CIPConvert.ToDecimal(m_fg.Rows[v_i_row_fg][(int)e_col_Number.SO_LUONG]);
                        decimal don_gia = CIPConvert.ToDecimal(m_fg.Rows[v_i_row_fg][(int)e_col_Number.GIA_BAN]);
                        decimal doanh_thu = CIPConvert.ToDecimal(m_fg.Rows[v_i_row_fg][(int)e_col_Number.DOANH_THU]);
                        if (CIPConvert.ToDecimal(m_fg.Rows[v_i_row_fg][(int)e_col_Number.SO_LUONG]) == CIPConvert.ToDecimal(v_ds_v_don_dat_hang_de.V_GD_DON_DAT_HANG_DETAIL.Rows[0]["SO_LUONG"]) && CIPConvert.ToDecimal(m_fg.Rows[v_i_row_fg][(int)e_col_Number.GIA_BAN]) == CIPConvert.ToDecimal(v_ds_v_don_dat_hang_de.V_GD_DON_DAT_HANG_DETAIL.Rows[0]["DON_GIA_CHUA_VAT"]) && CIPConvert.ToDecimal(m_fg.Rows[v_i_row_fg][(int)e_col_Number.DOANH_THU]) == (CIPConvert.ToDecimal(v_ds_v_don_dat_hang_de.V_GD_DON_DAT_HANG_DETAIL.Rows[0]["DON_GIA_CHUA_VAT"]) * CIPConvert.ToDecimal(v_ds_v_don_dat_hang_de.V_GD_DON_DAT_HANG_DETAIL.Rows[0]["SO_LUONG"])))
                        {
                            m_fg.RemoveItem(v_i_row_fg);
                            v_i_row_fg--;
                        }
                    }
                v_ds_v_don_dat_hang_de.Clear();
            }
            m_lbl_loading.Visible = false;
            progressBar1.Visible = false;
            m_lbl_thong_bao_cap_nhat.Visible = true;
        }

        private void set_define_event()
        {
            m_cmd_thoat.Click += new EventHandler(m_cmd_thoat_Click);
            m_cmd_nhap_excel.Click += new EventHandler(m_cmd_nhap_excel_Click);
            m_cmd_so_sanh_chi_phi.Click += new EventHandler(m_cmd_so_sanh_chi_phi_Click);
            m_cmd_xuat_excel.Click += new EventHandler(m_cmd_xuat_excel_Click);
            m_cmd_cap_nhat.Click += new EventHandler(m_cmd_cap_nhat_Click);
        }

        #endregion

        #region Event
        private void m_cmd_nhap_excel_Click(object sender, EventArgs e)
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
        private void m_cmd_so_sanh_chi_phi_Click(object sender, EventArgs e)
        {
            try
            {
                so_sanh_chi_phi_voi_don_hang();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_thoat_Click(object sender, EventArgs e)
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
        private void m_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                export_2_excel();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void f461_So_sanh_chi_phi_cuoi_thang_NCC_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Escape)
                {
                    this.Close();
                }
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_cap_nhat_Click(object sender, EventArgs e)
        {
            try
            {
                cap_nhat_gridview();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
}
