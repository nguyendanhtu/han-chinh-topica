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
        ITransferDataRow m_obj_trans;
        private const String m_str_goi_y_so_bill = "Nhập Số bill, tên người nhận hoặc tên người gửi!";
        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            TEN_PHONG_BAN = 1
          ,
            //TRANG_THAI_THU = 1
            //   ,
            NGAY_GUI = 2
                ,
            NGUOI_NHAN = 4
                ,
            NGUOI_GUI = 5
                , SO_BILL = 3

        }

     
        #endregion

        #region Private Method
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            CControlFormat.setC1FlexFormat(m_grv_da_nhan);
            m_lbl_tieu_de.Font = new System.Drawing.Font("Tahoma", 15, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CControlFormat.setC1FlexFormat(m_grv_da_chuyen);
            CControlFormat.setC1FlexFormat(m_grv_bi_tra_lai);
            CControlFormat.setC1FlexFormat(m_grv_noi_bo_nhan_tra_lai);
            m_dtp_tu_ngay.Value = DateTime.Now.Date;
            //load_data_2_cbo_cu()é
            //load_data_2_cbo_moi();
            load_data_2_cbo_trung_tam();
            set_difine_event();
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_DM_BILL.TEN_PHONG_BAN, e_col_Number.TEN_PHONG_BAN);
            //v_htb.Add(V_DM_BILL.TRANG_THAI_THU, e_col_Number.TRANG_THAI_THU);
            v_htb.Add(V_DM_BILL.NGAY_GUI, e_col_Number.NGAY_GUI);
            v_htb.Add(V_DM_BILL.NGUOI_NHAN, e_col_Number.NGUOI_NHAN);
            v_htb.Add(V_DM_BILL.NGUOI_GUI, e_col_Number.NGUOI_GUI);
            v_htb.Add(V_DM_BILL.SO_BILL, e_col_Number.SO_BILL);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_DM_BILL.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid(decimal ip_dc_trang_thai, C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            DateTime v_dat_tu_ngay = m_dtp_tu_ngay.Value.Date;
            DateTime v_dat_den_ngay = m_dtp_den_ngay.Value.Date;
            decimal v_dc_id_trung_tam = CIPConvert.ToDecimal(m_cbo_trung_tam.SelectedValue);
            decimal v_dc_id_trang_thai = ip_dc_trang_thai; //CIPConvert.ToDecimal(m_cbo_trang_thai_cu.SelectedValue);
            string v_str_key_word = m_txt_key_word.Text;
            if (v_str_key_word == m_str_goi_y_so_bill) v_str_key_word = "";
            m_ds = new DS_V_DM_BILL();
            if (m_rdb_tat_ca.Checked == true)
            {
                m_us.FillDatasetSearch_grid_ngay(m_ds, v_dat_tu_ngay, v_dat_den_ngay, v_dc_id_trung_tam, v_dc_id_trang_thai, v_str_key_word);
            }
            if (m_rdb_chon_ngay.Checked == true)
            {
                v_dat_den_ngay = v_dat_tu_ngay;
                m_us.FillDatasetSearch_grid_ngay(m_ds, v_dat_tu_ngay, v_dat_den_ngay, v_dc_id_trung_tam, v_dc_id_trang_thai, v_str_key_word);
            }
            if (m_rdb_chon_thang.Checked == true)
            {
                v_dat_tu_ngay = m_dtp_tu_ngay.Value.Date.AddDays(-m_dtp_tu_ngay.Value.Date.Day + 1);
                DateTime temp = m_dtp_tu_ngay.Value.Date;
                temp = temp.AddMonths(1);
                temp = temp.AddDays(-(temp.Day));
                v_dat_den_ngay = temp;
                m_us.FillDatasetSearch_grid_ngay(m_ds, v_dat_tu_ngay, v_dat_den_ngay, v_dc_id_trung_tam, v_dc_id_trang_thai, v_str_key_word);
            }
            i_fg.Redraw = false;
            m_obj_trans = get_trans_object(i_fg);
            CGridUtils.Dataset2C1Grid(m_ds, i_fg, m_obj_trans);
            CGridUtils.MakeSoTT(0, i_fg);
            i_fg.Redraw = true;
            set_textbox_keyword_format_before();

        }

        private void grid_2us_object(US_V_DM_BILL i_us
            , int i_grid_row,C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            DataRow v_dr;
            v_dr = (DataRow)i_fg.Rows[i_grid_row].UserData;
            m_obj_trans = get_trans_object(i_fg);
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_V_DM_BILL i_us
            , int i_grid_row,C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            DataRow v_dr = (DataRow)i_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans = get_trans_object(i_fg);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }
       
        
        private void change_state_only_1(decimal ip_id_trang_thai_cu,decimal ip_id_trang_thai_moi, C1.Win.C1FlexGrid.C1FlexGrid i_fg_left, C1.Win.C1FlexGrid.C1FlexGrid i_fg_right, string ip_str_message)
        {
            int v_i = i_fg_left.Rows.Count;
            if (!CGridUtils.IsThere_Any_NonFixed_Row(i_fg_left)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(i_fg_left, i_fg_left.Row)) return;
            grid_2us_object(m_us, i_fg_left.Row,i_fg_left);
            //chuyen tu trang thai 1-Da nhan noi bo -> 2-Da chuyen cho CPN
            change_state_of_bill(m_us.dcID, ip_id_trang_thai_moi);
            load_data_2_grid(ip_id_trang_thai_cu, i_fg_left);
            load_data_2_grid(ip_id_trang_thai_moi, i_fg_right);            
            BaseMessages.MsgBox_Infor(ip_str_message);

        }

        private void change_state_all(decimal ip_id_trang_thai_cu, decimal ip_id_trang_thai_moi, C1.Win.C1FlexGrid.C1FlexGrid i_fg_left, C1.Win.C1FlexGrid.C1FlexGrid i_fg_right, string ip_str_message)
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(i_fg_left)) return;
            for (int i = 1; i < i_fg_left.Rows.Count; i++)
            {
                if (!CGridUtils.IsThere_Any_NonFixed_Row(i_fg_left)) return;
                if (!CGridUtils.isValid_NonFixed_RowIndex(i_fg_left, i_fg_left.Row)) return;
                m_obj_trans = get_trans_object(i_fg_left);
                m_us = new US_V_DM_BILL();
                grid_2us_object(m_us, i,i_fg_left);
                //chuyen tu trang thai 1-Da nhan noi bo -> 2-Da chuyen cho CPN
                change_state_of_bill(m_us.dcID, ip_id_trang_thai_moi);
            }
            load_data_2_grid(ip_id_trang_thai_cu, i_fg_left);
            load_data_2_grid(ip_id_trang_thai_moi, i_fg_right);
            BaseMessages.MsgBox_Infor(ip_str_message);

        }

        private void change_state_of_bill(decimal ip_dc_id_bill, decimal ip_dc_id_trang_thai)
        {
            US_DM_BILL v_us_dm_bill = new US_DM_BILL(ip_dc_id_bill);
            v_us_dm_bill.dcID_TRANG_THAI = ip_dc_id_trang_thai;
            v_us_dm_bill.Update();
        }
        private void load_data_2_cbo_trung_tam()
        {
            US_DM_PHONG_BAN v_us = new US_DM_PHONG_BAN();
            DS_DM_PHONG_BAN v_ds = new DS_DM_PHONG_BAN();
            v_us.FillDataset(v_ds, "order by ten_phong_ban");
            m_cbo_trung_tam.DataSource = v_ds.DM_PHONG_BAN;
            m_cbo_trung_tam.ValueMember = DM_PHONG_BAN.ID;
            m_cbo_trung_tam.DisplayMember = DM_PHONG_BAN.TEN_PHONG_BAN;

            DataRow v_dr = v_ds.DM_PHONG_BAN.NewRow();
            v_dr[DM_PHONG_BAN.ID] = -1;
            v_dr[DM_PHONG_BAN.MA_PHONG_BAN] = "";
            v_dr[DM_PHONG_BAN.TEN_PHONG_BAN] = "------------Tất cả------------";


            v_ds.DM_PHONG_BAN.Rows.InsertAt(v_dr, 0);
            m_cbo_trung_tam.SelectedIndex = 0;

        }
        private void set_initial_form_load()
        {
            //m_dtp_tu_ngay.Value = DateTime.Now.Date;
            m_dtp_tu_ngay.Visible = false;
            m_lbl_tu_ngay.Visible = false;
            m_dtp_den_ngay.Visible = false;
            m_lbl_den_ngay.Visible = false;
            m_dtp_den_ngay.Value = DateTime.Now.Date;
            this.m_dtp_tu_ngay.Value = new System.DateTime(2010, 1, 14, 0, 0, 0, 0);
            load_data_2_grid(CONST_ID_TRANG_THAI_THU.ID_DA_NHAN_NOI_BO,m_grv_da_nhan);
            load_data_2_grid(CONST_ID_TRANG_THAI_THU.ID_DA_CHUYEN_CPN,m_grv_da_chuyen);
            load_data_2_grid(CONST_ID_TRANG_THAI_THU.ID_BI_TRA_LAI,m_grv_bi_tra_lai);
            load_data_2_grid(CONST_ID_TRANG_THAI_THU.ID_NOI_BO_NHAN_TRA_LAI, m_grv_noi_bo_nhan_tra_lai);
        }
        private void set_textbox_keyword_format_before()
        {
            if (m_txt_key_word.Text == "")
            {
                m_txt_key_word.Text = m_str_goi_y_so_bill;
                m_txt_key_word.ForeColor = Color.Gray;
            }
        }
        private void set_textbox_keyword_format_after()
        {
            if (m_txt_key_word.Text == m_str_goi_y_so_bill)
            {
                m_txt_key_word.Text = "";
            }
            m_txt_key_word.ForeColor = Color.Black;
        }

        private void set_difine_event()
        {
            m_cmd_search.Click += new EventHandler(m_cmd_search_Click);
            this.Load += new EventHandler(F506_CAP_NHAT_TRANG_THAI_Load);
            m_cmd_xem_bill_da_chuyen_cpn.Click += m_cmd_xem_bill_da_chuyen_cpn_Click;
            m_cmd_xem_ds_bill_da_nhan.Click += m_cmd_xem_ds_bill_da_nhan_Click;
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_txt_key_word.KeyDown += new KeyEventHandler(m_txt_so_bill_KeyDown);
            m_txt_key_word.Leave += new EventHandler(m_txt_so_bill_Leave);
            m_txt_key_word.MouseClick += new MouseEventHandler(m_txt_so_bill_MouseClick);
            m_cmd_left_2_right.Click += new EventHandler(m_cmd_left_2_right_Click);
            m_cmd_right_2_left.Click += new EventHandler(m_cmd_right_2_left_Click);
            m_cmd_left_2_right_all.Click += new EventHandler(m_cmd_left_2_right_all_Click);
            m_cmd_right_2_left_all.Click += new EventHandler(m_cmd_right_2_left_all_Click);
            m_cbo_trung_tam.SelectedIndexChanged += new EventHandler(m_cbo_trung_tam_SelectedIndexChanged);
            //this.m_dtp_tu_ngay.ValueChanged += new System.EventHandler(this.m_dtp_tu_ngay_ValueChanged);
            m_cmd_da_chuyen_2_tra_lai.Click+=new EventHandler(m_cmd_da_chuyen_2_tra_lai_Click);
            m_cmd_tra_lai_2_noi_bo_nhan_tl.Click+=new EventHandler(m_cmd_tra_lai_2_noi_bo_nhan_tl_Click);
            m_cmd_tra_lai_2_da_chuyen.Click+=new EventHandler(m_cmd_tra_lai_2_da_chuyen_Click);
            m_cmd_nhan_tra_lai_2_tra_lai.Click+=new EventHandler(m_cmd_nhan_tra_lai_2_tra_lai_Click);
            m_cmd_tra_lai_2_noi_bo_nhan_tl_all.Click+=new EventHandler(m_cmd_tra_lai_2_noi_bo_nhan_tl_all_Click);
            m_rdb_tat_ca.CheckedChanged+=new EventHandler(m_rdb_tat_ca_CheckedChanged);
            m_rdb_chon_ngay.CheckedChanged+=new EventHandler(m_rdb_chon_ngay_CheckedChanged);
            m_rdb_chon_thang.CheckedChanged+=new EventHandler(m_rdb_chon_thang_CheckedChanged);
            this.KeyDown+=new KeyEventHandler(F506_CAP_NHAT_TRANG_THAI_KeyDown);
        }

        private void m_cmd_xem_ds_bill_da_nhan_Click(object sender, EventArgs e)
        {
            try
            {
                m_tab_main.SelectedTab = m_tm_bill_da_nhan;
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
           
        }

        private void m_cmd_xem_bill_da_chuyen_cpn_Click(object sender, EventArgs e)
        {
            try
            {
                m_tab_main.SelectedTab = m_tm_bill_da_chuyen_cho_cpn;
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

        #region Event

        private void F506_CAP_NHAT_TRANG_THAI_Load(object sender, EventArgs e)
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
                load_data_2_grid(CONST_ID_TRANG_THAI_THU.ID_DA_NHAN_NOI_BO,m_grv_da_nhan);
                load_data_2_grid(CONST_ID_TRANG_THAI_THU.ID_DA_CHUYEN_CPN,m_grv_da_chuyen);
                load_data_2_grid(CONST_ID_TRANG_THAI_THU.ID_BI_TRA_LAI,m_grv_bi_tra_lai);
                load_data_2_grid(CONST_ID_TRANG_THAI_THU.ID_NOI_BO_NHAN_TRA_LAI, m_grv_noi_bo_nhan_tra_lai);
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
                change_state_only_1(CONST_ID_TRANG_THAI_THU.ID_DA_NHAN_NOI_BO,CONST_ID_TRANG_THAI_THU.ID_DA_CHUYEN_CPN,m_grv_da_nhan,m_grv_da_chuyen,"Bill đã được chuyển cho CPN!");
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
                change_state_only_1(CONST_ID_TRANG_THAI_THU.ID_DA_CHUYEN_CPN, CONST_ID_TRANG_THAI_THU.ID_DA_NHAN_NOI_BO, m_grv_da_chuyen, m_grv_da_nhan, "Bill đã được chuyển về trạng thái đã nhận nội bộ!");
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
                m_grv_da_nhan.Focus();
                change_state_all(CONST_ID_TRANG_THAI_THU.ID_DA_NHAN_NOI_BO, CONST_ID_TRANG_THAI_THU.ID_DA_CHUYEN_CPN, m_grv_da_nhan, m_grv_da_chuyen, "Tất cả Bill đã được chuyển cho CPN!");
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
                
            }
        }
        private void m_cmd_right_2_left_all_Click(object sender, EventArgs e)
        {
            try
            {
                m_grv_da_chuyen.Focus();
                change_state_all(CONST_ID_TRANG_THAI_THU.ID_DA_CHUYEN_CPN, CONST_ID_TRANG_THAI_THU.ID_DA_NHAN_NOI_BO, m_grv_da_chuyen, m_grv_da_nhan, "tất cả Bill đã được chuyển về trạng thái đã nhận nội bộ!");

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
        
        private void m_txt_so_bill_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    load_data_2_grid(CONST_ID_TRANG_THAI_THU.ID_DA_NHAN_NOI_BO, m_grv_da_nhan);
                    load_data_2_grid(CONST_ID_TRANG_THAI_THU.ID_DA_CHUYEN_CPN, m_grv_da_chuyen);
                    load_data_2_grid(CONST_ID_TRANG_THAI_THU.ID_BI_TRA_LAI, m_grv_bi_tra_lai);
                    load_data_2_grid(CONST_ID_TRANG_THAI_THU.ID_NOI_BO_NHAN_TRA_LAI, m_grv_noi_bo_nhan_tra_lai);
                }
                else
                {
                    set_textbox_keyword_format_after();
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
                set_textbox_keyword_format_after();
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
                set_textbox_keyword_format_before();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        

       
        private void m_cbo_trung_tam_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid(CONST_ID_TRANG_THAI_THU.ID_DA_NHAN_NOI_BO, m_grv_da_nhan);
                load_data_2_grid(CONST_ID_TRANG_THAI_THU.ID_DA_CHUYEN_CPN, m_grv_da_chuyen);
                load_data_2_grid(CONST_ID_TRANG_THAI_THU.ID_BI_TRA_LAI, m_grv_bi_tra_lai);
                load_data_2_grid(CONST_ID_TRANG_THAI_THU.ID_NOI_BO_NHAN_TRA_LAI, m_grv_noi_bo_nhan_tra_lai);
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_dtp_tu_ngay_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid(CONST_ID_TRANG_THAI_THU.ID_DA_NHAN_NOI_BO, m_grv_da_nhan);
                load_data_2_grid(CONST_ID_TRANG_THAI_THU.ID_DA_CHUYEN_CPN, m_grv_da_chuyen);
                load_data_2_grid(CONST_ID_TRANG_THAI_THU.ID_BI_TRA_LAI, m_grv_bi_tra_lai);
                load_data_2_grid(CONST_ID_TRANG_THAI_THU.ID_NOI_BO_NHAN_TRA_LAI, m_grv_noi_bo_nhan_tra_lai);
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_da_chuyen_2_tra_lai_Click(object sender, EventArgs e)
        {
            try
            {
                change_state_only_1(CONST_ID_TRANG_THAI_THU.ID_DA_CHUYEN_CPN, CONST_ID_TRANG_THAI_THU.ID_BI_TRA_LAI, m_grv_da_chuyen, m_grv_bi_tra_lai, "Bạn đã cập nhật trạng thái thành công!");
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_tra_lai_2_noi_bo_nhan_tl_Click(object sender, EventArgs e)
        {
            try
            {
                change_state_only_1(CONST_ID_TRANG_THAI_THU.ID_BI_TRA_LAI, CONST_ID_TRANG_THAI_THU.ID_NOI_BO_NHAN_TRA_LAI, m_grv_bi_tra_lai, m_grv_noi_bo_nhan_tra_lai, "Bạn đã cập nhật trạng thái thành công!");
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_tra_lai_2_da_chuyen_Click(object sender, EventArgs e)
        {
            try
            {
                change_state_only_1(CONST_ID_TRANG_THAI_THU.ID_BI_TRA_LAI, CONST_ID_TRANG_THAI_THU.ID_DA_CHUYEN_CPN, m_grv_bi_tra_lai, m_grv_da_chuyen, "Bạn đã cập nhật trạng thái thành công!");
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_nhan_tra_lai_2_tra_lai_Click(object sender, EventArgs e)
        {
            try
            {
                change_state_only_1(CONST_ID_TRANG_THAI_THU.ID_NOI_BO_NHAN_TRA_LAI, CONST_ID_TRANG_THAI_THU.ID_BI_TRA_LAI, m_grv_noi_bo_nhan_tra_lai, m_grv_bi_tra_lai, "Bạn đã cập nhật trạng thái thành công!");
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_tra_lai_2_noi_bo_nhan_tl_all_Click(object sender, EventArgs e)
        {
            try
            {
                m_grv_bi_tra_lai.Focus();
                change_state_all(CONST_ID_TRANG_THAI_THU.ID_BI_TRA_LAI, CONST_ID_TRANG_THAI_THU.ID_NOI_BO_NHAN_TRA_LAI, m_grv_bi_tra_lai, m_grv_noi_bo_nhan_tra_lai, "Tất cả bill đã cập nhật trạng thái thành công!");
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void F506_CAP_NHAT_TRANG_THAI_KeyDown(object sender, KeyEventArgs e)
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
        private void m_rdb_tat_ca_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_rdb_tat_ca.Checked == true)
                {
                    m_dtp_tu_ngay.Visible = false;
                    m_lbl_tu_ngay.Visible = false;
                    m_dtp_den_ngay.Visible = false;
                    m_lbl_den_ngay.Visible = false;
                    m_dtp_den_ngay.Value = DateTime.Now.Date;
                    this.m_dtp_tu_ngay.Value = new System.DateTime(2010, 1, 14, 0, 0, 0, 0);
                }
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_rdb_chon_ngay_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_rdb_chon_ngay.Checked == true)
                {
                    m_dtp_tu_ngay.Visible = true;
                    m_lbl_tu_ngay.Visible = true;
                    m_lbl_tu_ngay.Text = "Ngày";
                    m_dtp_tu_ngay.CustomFormat = "dd/MM/yyyy";
                    m_dtp_tu_ngay.Value = DateTime.Now.Date;
                    m_dtp_den_ngay.Visible = false;
                    m_lbl_den_ngay.Visible = false;
                }
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_rdb_chon_thang_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_rdb_chon_thang.Checked == true)
                {
                    m_dtp_tu_ngay.Visible = true;
                    m_lbl_tu_ngay.Visible = true;
                    m_lbl_tu_ngay.Text = "Tháng";
                    m_dtp_tu_ngay.CustomFormat = "MM/yyyy";
                    m_dtp_tu_ngay.Value = DateTime.Now.Date;
                    m_dtp_den_ngay.Visible = false;
                    m_lbl_den_ngay.Visible = false;
                }
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

        
    }
}
