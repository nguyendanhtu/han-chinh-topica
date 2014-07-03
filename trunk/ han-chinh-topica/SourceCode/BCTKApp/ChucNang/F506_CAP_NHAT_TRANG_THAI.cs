using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using BCTKUS;
using BCTKDS.CDBNames;
using BCTKDS;
using IP.Core.IPSystemAdmin;
using System.Collections;

namespace BCTKApp
{
    public partial class F506_CAP_NHAT_TRANG_THAI : Form
    {
        public F506_CAP_NHAT_TRANG_THAI()
        {
            InitializeComponent();
            format_controls();
        }
        #region Member
        US_V_DM_BILL m_us = new US_V_DM_BILL();
        DS_V_DM_BILL m_ds = new DS_V_DM_BILL();
        ITransferDataRow m_obj_trans_1;
        ITransferDataRow m_obj_trans_2;
        private const String m_str_goi_y_so_bill = "Nhập Số bill...";
        #endregion
        private enum e_col_Number
        {
            TRANG_THAI_THU = 1
,
            TEN_PHONG_BAN = 2
                ,
            NGAY_GUI = 3
                ,
            NGUOI_NHAN = 5
                ,
            NGUOI_GUI = 6
                , SO_BILL = 4

        }	
        #region Private Method
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            CControlFormat.setC1FlexFormat(m_grv_trang_thai_cu);
            m_lbl_tieu_de.Font = new System.Drawing.Font("Tahoma", 15, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CControlFormat.setC1FlexFormat(m_grv_trang_thai_moi);
            load_data_2_cbo_cu();
            load_data_2_cbo_moi();
            load_data_2_cbo_trung_tam();
            set_difine_event();
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_DM_BILL.TRANG_THAI_THU, e_col_Number.TRANG_THAI_THU);
            v_htb.Add(V_DM_BILL.TEN_PHONG_BAN, e_col_Number.TEN_PHONG_BAN);
            v_htb.Add(V_DM_BILL.NGAY_GUI, e_col_Number.NGAY_GUI);
            v_htb.Add(V_DM_BILL.NGUOI_NHAN, e_col_Number.NGUOI_NHAN);
            v_htb.Add(V_DM_BILL.NGUOI_GUI, e_col_Number.NGUOI_GUI);
            v_htb.Add(V_DM_BILL.SO_BILL, e_col_Number.SO_BILL);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_DM_BILL.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid_trang_thai_cu()
        {
            DateTime v_dat_ngay = m_dtp_tu_ngay.Value.Date;
            decimal v_dc_id_trung_tam = CIPConvert.ToDecimal(m_cbo_trung_tam.SelectedValue);
            decimal v_dc_id_trang_thai = CIPConvert.ToDecimal(m_cbo_trang_thai_cu.SelectedValue);
            string v_str_so_bill = m_txt_so_bill.Text;
            if (v_str_so_bill == m_str_goi_y_so_bill) v_str_so_bill = "";
            m_ds = new DS_V_DM_BILL();
            m_us.FillDatasetSearch_grid(m_ds, v_dat_ngay, v_dc_id_trung_tam, v_dc_id_trang_thai,v_str_so_bill);
            m_grv_trang_thai_cu.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_grv_trang_thai_cu, m_obj_trans_1);
            CGridUtils.MakeSoTT(0, m_grv_trang_thai_cu);
            m_grv_trang_thai_cu.Redraw = true;
            set_search_so_bill_format_before();
        }
        private void load_data_2_grid_trang_thai_moi()
        {
            DateTime v_dat_ngay = m_dtp_tu_ngay.Value.Date;
            decimal v_dc_id_trung_tam = CIPConvert.ToDecimal(m_cbo_trung_tam.SelectedValue);
            decimal v_dc_id_trang_thai = CIPConvert.ToDecimal(m_cbo_trang_thai_moi.SelectedValue);
            string v_str_so_bill = m_txt_so_bill.Text;
            if (v_str_so_bill == m_str_goi_y_so_bill) v_str_so_bill = "";
            m_ds = new DS_V_DM_BILL();
            m_us.FillDatasetSearch_grid(m_ds, v_dat_ngay, v_dc_id_trung_tam, v_dc_id_trang_thai,v_str_so_bill);
            m_grv_trang_thai_moi.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_grv_trang_thai_moi, m_obj_trans_2);
            CGridUtils.MakeSoTT(0, m_grv_trang_thai_moi);
            m_grv_trang_thai_moi.Redraw = true;
            set_search_so_bill_format_before();
        }

        private void load_data_2_cbo_cu()
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            v_us.FillDataset(v_ds, "Where id_loai_tu_dien = 12");
            m_cbo_trang_thai_cu.DataSource = v_ds.CM_DM_TU_DIEN;
            m_cbo_trang_thai_cu.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_trang_thai_cu.DisplayMember = CM_DM_TU_DIEN.TEN;

            DataRow v_dr = v_ds.CM_DM_TU_DIEN.NewRow();
            v_dr[CM_DM_TU_DIEN.ID] = -1;
            v_dr[CM_DM_TU_DIEN.ID_LOAI_TU_DIEN] = -1;
            v_dr[CM_DM_TU_DIEN.MA_TU_DIEN] = "TAT_CA";
            v_dr[CM_DM_TU_DIEN.TEN] = "-------Tất cả------";
            v_dr[CM_DM_TU_DIEN.TEN_NGAN] = "-------Tất cả------";
            v_dr[CM_DM_TU_DIEN.GHI_CHU] = "";
            v_ds.CM_DM_TU_DIEN.Rows.InsertAt(v_dr, 0);
            m_cbo_trang_thai_cu.SelectedIndex = 0;

        }
        private void load_data_2_cbo_moi()
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            v_us.FillDataset(v_ds, "Where id_loai_tu_dien = 12");
            m_cbo_trang_thai_moi.DataSource = v_ds.CM_DM_TU_DIEN;
            m_cbo_trang_thai_moi.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_trang_thai_moi.DisplayMember = CM_DM_TU_DIEN.TEN;

            DataRow v_dr = v_ds.CM_DM_TU_DIEN.NewRow();
            v_dr[CM_DM_TU_DIEN.ID] = -1;
            v_dr[CM_DM_TU_DIEN.ID_LOAI_TU_DIEN] = -1;
            v_dr[CM_DM_TU_DIEN.MA_TU_DIEN] = "TAT_CA";
            v_dr[CM_DM_TU_DIEN.TEN] = "-------Tất cả------";
            v_dr[CM_DM_TU_DIEN.TEN_NGAN] = "-------Tất cả------";
            v_dr[CM_DM_TU_DIEN.GHI_CHU] = "";
            v_ds.CM_DM_TU_DIEN.Rows.InsertAt(v_dr, 0);
            m_cbo_trang_thai_moi.SelectedIndex = 0;

        }
        private void grid_trang_thai_cu_2us_object(US_V_DM_BILL i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_grv_trang_thai_cu.Rows[i_grid_row].UserData;
            m_obj_trans_1.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid_trang_thai_cu(US_V_DM_BILL i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_grv_trang_thai_cu.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans_1.DataRow2GridRow(v_dr, i_grid_row);
        }
        private void grid_trang_thai_moi_2us_object(US_V_DM_BILL i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_grv_trang_thai_moi.Rows[i_grid_row].UserData;
            m_obj_trans_2.GridRow2DataRow(1, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid_trang_thai_moi(US_V_DM_BILL i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_grv_trang_thai_moi.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans_2.DataRow2GridRow(v_dr, i_grid_row);
        }
        private void get_data_left_2_right()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_trang_thai_cu)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_trang_thai_cu, m_grv_trang_thai_cu.Row)) return;
            //grid_trang_thai_cu_2us_object(m_us, m_grv_trang_thai_cu.Row);
            //decimal v_dc_id_trang_thai = CIPConvert.ToDecimal(m_cbo_trang_thai_moi.SelectedValue);
            //load_data_grid_2_us(m_us, v_dc_id_trang_thai);
            //load_data_2_grid_trang_thai_moi();
            //load_data_2_grid_trang_thai_cu();
            int v_i_grid_row = m_grv_trang_thai_cu.Row;
            DataRow v_dr = (DataRow)m_grv_trang_thai_cu.Rows[v_i_grid_row].UserData;
            m_grv_trang_thai_moi.Rows.Add();
            v_dr.BeginEdit();
            v_dr.ItemArray.SetValue(m_cbo_trang_thai_moi.Text.Trim(), 14);
            v_dr.EndEdit();
            m_obj_trans_2.DataRow2GridRow(v_dr, m_grv_trang_thai_moi.Rows.Count-1);
            m_grv_trang_thai_cu.Rows.Remove(m_grv_trang_thai_cu.Rows[m_grv_trang_thai_cu.Row]);
            CGridUtils.MakeSoTT(0, m_grv_trang_thai_cu);
            CGridUtils.MakeSoTT(0, m_grv_trang_thai_moi);
            
        }
        private void get_data_right_2_left()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_trang_thai_moi)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_trang_thai_moi, m_grv_trang_thai_cu.Row)) return;
            //grid_trang_thai_cu_2us_object(m_us, m_grv_trang_thai_cu.Row);
            //decimal v_dc_id_trang_thai = CIPConvert.ToDecimal(m_cbo_trang_thai_moi.SelectedValue);
            //load_data_grid_2_us(m_us, v_dc_id_trang_thai);
            //load_data_2_grid_trang_thai_moi();
            //load_data_2_grid_trang_thai_cu();
            int v_i_grid_row = m_grv_trang_thai_moi.Row;
            DataRow v_dr = (DataRow)m_grv_trang_thai_moi.Rows[v_i_grid_row].UserData;
            m_grv_trang_thai_cu.Rows.Add();
            //v_dr.BeginEdit();
            //v_dr.ItemArray.SetValue(m_cbo_trang_thai_moi.Text.Trim(), 14);
            //v_dr.EndEdit();
            m_obj_trans_1.DataRow2GridRow(v_dr, m_grv_trang_thai_cu.Rows.Count - 1);
            m_grv_trang_thai_moi.Rows.Remove(v_i_grid_row);
            CGridUtils.MakeSoTT(0, m_grv_trang_thai_cu);
            CGridUtils.MakeSoTT(0, m_grv_trang_thai_moi);

        }
        private void get_data_left_2_right_all()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_trang_thai_cu)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_trang_thai_cu, m_grv_trang_thai_cu.Row)) return;
            for (int i = 1; i < m_grv_trang_thai_cu.Rows.Count; i++) 
                {
                    DataRow v_dr = (DataRow)m_grv_trang_thai_cu.Rows[i].UserData;
                    m_grv_trang_thai_moi.Rows.Add();
                    //v_dr.BeginEdit();
                    //v_dr.ItemArray.SetValue(m_cbo_trang_thai_moi.Text.Trim(), 14);
                    //v_dr.EndEdit();
                    m_obj_trans_2.DataRow2GridRow(v_dr, m_grv_trang_thai_moi.Rows.Count - 1);
                    CGridUtils.MakeSoTT(0, m_grv_trang_thai_cu);
                    CGridUtils.MakeSoTT(0, m_grv_trang_thai_moi);
                }
            for (int i = 1; i <= m_grv_trang_thai_cu.Rows.Count; i++) { m_grv_trang_thai_cu.Rows.Remove(1); }
            {
                
            }

        }
        private void load_data_grid_2_us(US_V_DM_BILL ip_us, decimal ip_dc_id_trang_thai) 
        {
           
            decimal v_dc_id = ip_us.dcID;
            decimal v_dc_id_phong_ban = ip_us.dcID_PHONG_BAN;
            decimal v_dc_so_tien=ip_us.dcSO_TIEN;
            string v_str_ghi_chu=ip_us.strGHI_CHU;
            string v_str_nguoi_gui=ip_us.strNGUOI_GUI;
            string v_str_nguoi_nhan=ip_us.strNGUOI_NHAN;
            string v_str_noi_dung=ip_us.strNOI_DUNG;
            string v_str_noi_nhan=ip_us.strNOI_NHAN;
            string v_str_nuoc_ngoai=ip_us.strNUOC_NGOAI;
            string v_str_so_bill=ip_us.strSO_BILL;
            string v_str_trong_nuoc=ip_us.strTRONG_NUOC;
            DateTime v_dat_ngay_gui=ip_us.datNGAY_GUI;
            US_DM_BILL v_us_dm_bill = new US_DM_BILL();
            v_us_dm_bill.dcID =v_dc_id;
            v_us_dm_bill.dcID_PHONG_BAN = v_dc_id_phong_ban;
            v_us_dm_bill.dcID_TRANG_THAI = ip_dc_id_trang_thai;
            v_us_dm_bill.dcSO_TIEN = v_dc_so_tien;
            v_us_dm_bill.datNGAY_GUI = v_dat_ngay_gui;
            v_us_dm_bill.strGHI_CHU = v_str_ghi_chu;
            v_us_dm_bill.strNGUOI_GUI = v_str_nguoi_gui;
            v_us_dm_bill.strNGUOI_NHAN = v_str_nguoi_nhan;
            v_us_dm_bill.strNOI_DUNG = v_str_noi_dung;
            v_us_dm_bill.strNOI_NHAN = v_str_noi_nhan;
            v_us_dm_bill.strNUOC_NGOAI = v_str_nuoc_ngoai;
            v_us_dm_bill.strTRONG_NUOC = v_str_trong_nuoc;
            v_us_dm_bill.strSO_BILL = v_str_so_bill;
            v_us_dm_bill.Update();
        }
        private void load_data_2_cbo_trung_tam()
        {
            US_DM_PHONG_BAN v_us = new US_DM_PHONG_BAN();
            DS_DM_PHONG_BAN v_ds = new DS_DM_PHONG_BAN();
            v_us.FillDataset(v_ds);
            m_cbo_trung_tam.DataSource = v_ds.DM_PHONG_BAN;
            m_cbo_trung_tam.ValueMember = DM_PHONG_BAN.ID;
            m_cbo_trung_tam.DisplayMember =DM_PHONG_BAN.TEN_PHONG_BAN;

            DataRow v_dr = v_ds.DM_PHONG_BAN.NewRow();
            v_dr[DM_PHONG_BAN.ID] = -1;
            v_dr[DM_PHONG_BAN.MA_PHONG_BAN]="";
            v_dr[DM_PHONG_BAN.TEN_PHONG_BAN]="-----Tất cả-----";
            
            v_ds.DM_PHONG_BAN.Rows.InsertAt(v_dr, 0);
            m_cbo_trung_tam.SelectedIndex = 0;

        }
        private void set_initial_form_load()
        {
            m_obj_trans_1 = get_trans_object(m_grv_trang_thai_cu);
            load_data_2_grid_trang_thai_cu();
            m_obj_trans_2 = get_trans_object(m_grv_trang_thai_moi);
            load_data_2_grid_trang_thai_cu();
        }
        private void set_search_so_bill_format_before()
        {
            if (m_txt_so_bill.Text == "")
            {
                m_txt_so_bill.Text = m_str_goi_y_so_bill;
                m_txt_so_bill.ForeColor = Color.Gray;
            }
        }
        private void set_search_so_bill_format_after()
        {
            if (m_txt_so_bill.Text == m_str_goi_y_so_bill)
            {
                m_txt_so_bill.Text = "";
            }
            m_txt_so_bill.ForeColor = Color.Black;
        }
        private void set_difine_event()
        {
            m_cmd_search.Click += new EventHandler(m_cmd_search_Click);
            this.Load+=new EventHandler(Form1_test_Load);
            m_cbo_trang_thai_cu.SelectedIndexChanged += new EventHandler(m_cbo_trang_thai_cu_SelectedIndexChanged);
            m_cbo_trang_thai_moi.SelectedIndexChanged += new EventHandler(m_cbo_trang_thai_moi_SelectedIndexChanged);
            m_cmd_exit.Click+=new EventHandler(m_cmd_exit_Click);
            m_txt_so_bill.KeyDown += new KeyEventHandler(m_txt_so_bill_KeyDown);
            m_txt_so_bill.Leave += new EventHandler(m_txt_so_bill_Leave);
            m_txt_so_bill.MouseClick += new MouseEventHandler(m_txt_so_bill_MouseClick);
            m_cmd_left_2_right.Click+=new EventHandler(m_cmd_left_2_right_Click);
            m_cmd_right_2_left.Click+=new EventHandler(m_cmd_right_2_left_Click);
            m_cmd_left_2_right_all.Click+=new EventHandler(m_cmd_left_2_right_all_Click);
        }
        #endregion
        #region Event

        private void Form1_test_Load(object sender, EventArgs e)
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
        private void m_cmd_search_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid_trang_thai_cu();
                load_data_2_grid_trang_thai_moi();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_left_2_right_Click(object sender, EventArgs e)
        {
            try
            {
                get_data_left_2_right();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_right_2_left_Click(object sender, EventArgs e)
        {
            try
            {
                get_data_right_2_left();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_left_2_right_all_Click(object sender, EventArgs e) 
        {
            try
            {
                get_data_left_2_right_all();
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
        private void m_cbo_trang_thai_cu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid_trang_thai_cu();
                m_grb_trang_thai_cu.Text = m_cbo_trang_thai_cu.Text;
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cbo_trang_thai_moi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid_trang_thai_moi();
                m_grb_trang_thai_moi.Text = m_cbo_trang_thai_moi.Text;
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_txt_so_bill_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    load_data_2_grid_trang_thai_cu();
                    load_data_2_grid_trang_thai_moi();
                }
                else
                {
                    set_search_so_bill_format_after();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_txt_so_bill_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                set_search_so_bill_format_after();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_txt_so_bill_Leave(object sender, EventArgs e)
        {
            try
            {
                set_search_so_bill_format_before();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

        
    }
}
