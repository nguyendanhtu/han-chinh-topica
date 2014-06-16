using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;

using BCTKUS;
using BCTKDS.CDBNames;
using System.Globalization;
using IP.Core.IPExcelReport;
using System.Collections;
using BCTKDS;
namespace BCTKApp
{
    public partial class f140_thong_tin_cuoi_thang : Form
    {
        public f140_thong_tin_cuoi_thang()
        {
            InitializeComponent();
            format_controls();
        }
        #region Public Method
        public void display()
        {
            this.ShowDialog();
        }
        #endregion
        #region Data Structures
        private enum e_col_Number
        {
            STT = 0,
            SO_TIEN = 13
,
            NUOC_NGOAI = 6
                ,
            NGUOI_GUI = 8
                ,
            ID = 1
                ,
            SO_BILL = 7
                ,
            NOI_NHAN = 3
                ,
            NGUOI_NHAN = 4
                ,
            TEN_PHONG_BAN = 12
                ,
            TRONG_NUOC = 5
                ,
            GHI_CHU = 10
                ,
            NOI_DUNG = 2
                ,
            PHONG_BAN_ID = 14
                ,
            MA_PHONG_BAN = 11
                , NGAY_GUI = 9

        }		
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_V_CM_DM_DANG_KY_GUI m_ds = new DS_V_CM_DM_DANG_KY_GUI();
        US_V_CM_DM_DANG_KY_GUI m_us = new US_V_CM_DM_DANG_KY_GUI();
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            m_fg.Cols[(int)e_col_Number.ID].Visible = false;
            m_fg.Cols[(int)e_col_Number.PHONG_BAN_ID].Visible = false;
            set_define_events();
            this.KeyPreview = true;
            m_lbl_title.Font = new Font("Arial", 16);
            m_lbl_title.ForeColor = Color.DarkRed;
            m_lbl_title.TextAlign = ContentAlignment.MiddleCenter;
        }
        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_fg);
            load_cbo_phong_ban();
            //load_data_2_grid();		
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_CM_DM_DANG_KY_GUI.SO_TIEN, e_col_Number.SO_TIEN);
            v_htb.Add(V_CM_DM_DANG_KY_GUI.NUOC_NGOAI, e_col_Number.NUOC_NGOAI);
            v_htb.Add(V_CM_DM_DANG_KY_GUI.NGUOI_GUI, e_col_Number.NGUOI_GUI);
            v_htb.Add(V_CM_DM_DANG_KY_GUI.ID, e_col_Number.ID);
            v_htb.Add(V_CM_DM_DANG_KY_GUI.SO_BILL, e_col_Number.SO_BILL);
            v_htb.Add(V_CM_DM_DANG_KY_GUI.NOI_NHAN, e_col_Number.NOI_NHAN);
            v_htb.Add(V_CM_DM_DANG_KY_GUI.NGUOI_NHAN, e_col_Number.NGUOI_NHAN);
            v_htb.Add(V_CM_DM_DANG_KY_GUI.TEN_PHONG_BAN, e_col_Number.TEN_PHONG_BAN);
            v_htb.Add(V_CM_DM_DANG_KY_GUI.TRONG_NUOC, e_col_Number.TRONG_NUOC);
            v_htb.Add(V_CM_DM_DANG_KY_GUI.GHI_CHU, e_col_Number.GHI_CHU);
            v_htb.Add(V_CM_DM_DANG_KY_GUI.NOI_DUNG, e_col_Number.NOI_DUNG);
            v_htb.Add(V_CM_DM_DANG_KY_GUI.PHONG_BAN_ID, e_col_Number.PHONG_BAN_ID);
            v_htb.Add(V_CM_DM_DANG_KY_GUI.MA_PHONG_BAN, e_col_Number.MA_PHONG_BAN);
            v_htb.Add(V_CM_DM_DANG_KY_GUI.NGAY_GUI, e_col_Number.NGAY_GUI);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_CM_DM_DANG_KY_GUI.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            m_ds = new DS_V_CM_DM_DANG_KY_GUI();
            m_us.FillDataset(m_ds);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            CGridUtils.MakeSoTT((int)e_col_Number.STT, m_fg);
            m_fg.Redraw = true;
        }
        private void grid2us_object(US_V_CM_DM_DANG_KY_GUI i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            //m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_V_CM_DM_DANG_KY_GUI i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }
        private void load_du_lieu_loc()
        {
            string v_str_ma_so = m_txt_ma_so.Text.Trim();
            string v_str_noi_nhan = m_txt_noi_nhan.Text.Trim();
            DateTime v_dat_tu_ngay_gui;
            DateTime v_dat_den_ngay_gui;
            // tat ca trắng 
            if (v_str_ma_so.Equals("") && v_str_noi_nhan.Equals("")
               && m_txt_tu_ngay_gui.Text.Trim().ToString().Equals("") && m_txt_den_ngay_gui.Text.Trim().ToString().Equals("")) return;
            //Kiểm tra ngày nhập vào .Đưa dạng ngày nhập vào về dạng mm/dd/yyyy
            DateTime v_dat_temp;//bien tam thoi
            var formats = new[] { "dd/MM/yyyy", "yyyy-MM-dd" };//mau de kiem tra dinh dang
            if (DateTime.TryParseExact(m_txt_tu_ngay_gui.Text.Trim().ToString(), formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out v_dat_temp))
            {
                v_dat_tu_ngay_gui = v_dat_temp;// đã đưa về dạng mm/dd/yyyy
            }
            else v_dat_tu_ngay_gui = Convert.ToDateTime("1/1/1900");
            if (DateTime.TryParseExact(m_txt_den_ngay_gui.Text.Trim().ToString(), formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out v_dat_temp))
            {
                v_dat_den_ngay_gui = v_dat_temp;
            }
            else v_dat_den_ngay_gui = Convert.ToDateTime("1/1/1900");
            m_ds = new DS_V_CM_DM_DANG_KY_GUI();
            m_us.load_danh_sach_tim_kiem_cuoi_thang(m_ds, v_str_ma_so, v_str_noi_nhan, v_dat_tu_ngay_gui, v_dat_den_ngay_gui ,CIPConvert.ToStr(m_cbo_phong_ban.SelectedValue));
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            CGridUtils.MakeSoTT((int)e_col_Number.STT, m_fg);
            m_fg.Redraw = true;
            
        }
        private void load_cbo_phong_ban()
        {
            BCTKUS.US_CM_DM_TU_DIEN v_us_cm_dm_tu_dien = new BCTKUS.US_CM_DM_TU_DIEN();
            BCTKDS.DS_CM_DM_TU_DIEN v_ds_cm_dm_tu_dien = new BCTKDS.DS_CM_DM_TU_DIEN();
            v_us_cm_dm_tu_dien.FillDataset(v_ds_cm_dm_tu_dien, "WHERE ID_LOAI_TU_DIEN = 11");
            DataRow v_dr_all = v_ds_cm_dm_tu_dien.CM_DM_TU_DIEN.NewCM_DM_TU_DIENRow();
            v_dr_all[CM_DM_TU_DIEN.ID] = 0;
            v_dr_all[CM_DM_TU_DIEN.MA_TU_DIEN] = "TAT_CA";
            v_dr_all[CM_DM_TU_DIEN.ID_LOAI_TU_DIEN] = 11;
            v_dr_all[CM_DM_TU_DIEN.TEN_NGAN] = "Tất cả";
            v_dr_all[CM_DM_TU_DIEN.TEN] = "Tất cả";
            
            v_ds_cm_dm_tu_dien.CM_DM_TU_DIEN.Rows.InsertAt(v_dr_all, 0);
            m_cbo_phong_ban.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_phong_ban.ValueMember = CM_DM_TU_DIEN.MA_TU_DIEN;
            m_cbo_phong_ban.DataSource = v_ds_cm_dm_tu_dien.CM_DM_TU_DIEN;
        }

        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_xuat_excel.Click += new EventHandler(m_cmd_xuat_excel_Click);
            m_cmd_search.Click += new EventHandler(m_cmd_search_Click);
            m_cmd_xoa_trang_den_ngay.Click += new EventHandler(m_cmd_xoa_trang_den_ngay_Click);
            m_cmd_xoa_trang_tu_ngay.Click += new EventHandler(m_cmd_xoa_trang_tu_ngay_Click);
            this.Load += new EventHandler(f120_dm_dang_ky_gui_Load);
            m_dtp_tu_ngay_gui.ValueChanged += new EventHandler(m_dtp_tu_ngay_gui_ValueChanged);
            m_dtp_den_ngay_gui.ValueChanged += new EventHandler(m_dtp_den_ngay_gui_ValueChanged);
        }
        #endregion
        //
        //Event Handlers
        //
        private void f120_dm_dang_ky_gui_Load(object sender, System.EventArgs e)
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

        private void m_cmd_exit_Click(object sender, EventArgs e)
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
        private void m_cmd_search_Click(object sender, EventArgs e)
        {
            try
            {
                load_du_lieu_loc();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_dtp_tu_ngay_gui_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime v_dt = m_dtp_tu_ngay_gui.Value;
                m_txt_tu_ngay_gui.Text = v_dt.ToString("dd/MM/yyyy");
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }

        }
        private void m_dtp_den_ngay_gui_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime v_dt = m_dtp_den_ngay_gui.Value;
                m_txt_den_ngay_gui.Text = v_dt.ToString("dd/MM/yyyy");
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
                CExcelReport v_obj_excel = new CExcelReport("BCTK_Danh_sach_gui_cuoi_thang.xlsx", 11, 1);
                v_obj_excel.AddFindAndReplaceItem("<MA_SO>", CIPConvert.ToStr(m_txt_ma_so.Text.Trim().ToString()));
                v_obj_excel.AddFindAndReplaceItem("<NOI_NHAN>", CIPConvert.ToStr(m_txt_noi_nhan.Text.Trim().ToString()));
                v_obj_excel.AddFindAndReplaceItem("<TU_NGAY>", CIPConvert.ToStr(m_txt_tu_ngay_gui.Text.Trim().ToString()));
                v_obj_excel.AddFindAndReplaceItem("<DEN_NGAY>", CIPConvert.ToStr(m_txt_den_ngay_gui.Text.Trim().ToString()));
                v_obj_excel.FindAndReplace(false);

                v_obj_excel.Export2ExcelWithoutFixedRows(m_fg, (int)e_col_Number.STT, (int)e_col_Number.SO_TIEN, false);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void m_cmd_xoa_trang_den_ngay_Click(object sender, EventArgs e)
        {
            try
            {
                m_dtp_den_ngay_gui.ResetText();
                m_txt_den_ngay_gui.Text = "";
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void m_cmd_xoa_trang_tu_ngay_Click(object sender, EventArgs e)
        {
            try
            {
                m_dtp_tu_ngay_gui.ResetText();
                m_txt_tu_ngay_gui.Text = "";
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }

}
