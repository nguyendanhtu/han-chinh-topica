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
            set_define_event();
        }

        #region Public interface
        #endregion

        #region Data structure
        private enum e_col_Number
        {
            NGAY = 1,
            MA_HD = 2,
            TEN_VPP = 3,
            DVT = 4,
            SO_LUONG = 5,
            GIA_BAN = 6,
            DOANH_THU = 7
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
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.MakeSoTT(0, m_fg);
            progressBar1.Visible = false;
            set_define_event();
            this.KeyPreview = true;
        }
        private ITransferDataRow get_2_us_obj_xls()
        {
            Hashtable v_hst = new Hashtable();
            v_hst.Add(RPT_BANG_CHI_PHI_CUOI_THANG_NCC.NGAY, e_col_Number.NGAY);
            v_hst.Add(RPT_BANG_CHI_PHI_CUOI_THANG_NCC.MA_HD, e_col_Number.MA_HD);
            v_hst.Add(RPT_BANG_CHI_PHI_CUOI_THANG_NCC.TEN_VPP, e_col_Number.TEN_VPP);
            v_hst.Add(RPT_BANG_CHI_PHI_CUOI_THANG_NCC.SO_LUONG, e_col_Number.SO_LUONG);
            v_hst.Add(RPT_BANG_CHI_PHI_CUOI_THANG_NCC.DVT, e_col_Number.DVT);
            v_hst.Add(RPT_BANG_CHI_PHI_CUOI_THANG_NCC.GIA_BAN, e_col_Number.GIA_BAN);
            v_hst.Add(RPT_BANG_CHI_PHI_CUOI_THANG_NCC.DOANH_THU, e_col_Number.DOANH_THU);
            CC1TransferDataRow v_obj = new CC1TransferDataRow(m_fg, v_hst, m_ds.RPT_BANG_CHI_PHI_CUOI_THANG_NCC.NewRPT_BANG_CHI_PHI_CUOI_THANG_NCCRow());
            return v_obj;
        }
        private void load_danh_sach_excel()
        {
            if (m_OpenFile_dlg.ShowDialog() == DialogResult.OK)
            {
                string v_str_path_and_file_name = m_OpenFile_dlg.FileName;
                string v_str_file_name = v_str_path_and_file_name.Substring(v_str_path_and_file_name.LastIndexOf("\\") + 1, v_str_path_and_file_name.Length - v_str_path_and_file_name.LastIndexOf("\\") - 1);
                CExcelReport v_xls_file = new CExcelReport(v_str_path_and_file_name);
                DS_RPT_BANG_CHI_PHI_CUOI_THANG_NCC v_ds = new DS_RPT_BANG_CHI_PHI_CUOI_THANG_NCC();
                try
                {
                    m_lbl_loading.Visible = true;
                    v_ds.EnforceConstraints = false;
                    v_xls_file.Export2DatasetDSPhongThi(v_ds, v_ds.RPT_BANG_CHI_PHI_CUOI_THANG_NCC.TableName, 14);

                    CGridUtils.Dataset2C1Grid(v_ds, m_fg, m_obj_trans_xls);
                    //m_i_flag = 0;
                    //m_lbl_tong_so_luong.Text = CIPConvert.ToStr(m_fg_load_file.Rows.Count - 1);
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
