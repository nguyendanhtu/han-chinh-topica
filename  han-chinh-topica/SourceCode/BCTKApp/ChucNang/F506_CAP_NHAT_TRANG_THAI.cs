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
            CControlFormat.setC1FlexFormat(m_grv_trang_thai_cu);
            m_lbl_tieu_de.Font = new System.Drawing.Font("Tahoma", 15, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CControlFormat.setC1FlexFormat(m_grv_trang_thai_moi);
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
        private void load_data_2_grid_trang_thai_cu()
        {
            DateTime v_dat_ngay = m_dtp_tu_ngay.Value.Date;
            decimal v_dc_id_trung_tam = CIPConvert.ToDecimal(m_cbo_trung_tam.SelectedValue);
            decimal v_dc_id_trang_thai = CONST_ID_TRANG_THAI_THU.ID_DA_NHAN_NOI_BO; //CIPConvert.ToDecimal(m_cbo_trang_thai_cu.SelectedValue);
            string v_str_key_word = m_txt_key_word.Text;
            if (v_str_key_word == m_str_goi_y_so_bill) v_str_key_word = "";
            m_ds = new DS_V_DM_BILL();
            if (m_dtp_tu_ngay.Checked == true)
            {
                m_us.FillDatasetSearch_grid_ngay(m_ds, v_dat_ngay, v_dc_id_trung_tam, v_dc_id_trang_thai, v_str_key_word);
            }
            else
            {
                m_us.FillDatasetSearch_grid(m_ds, v_dc_id_trung_tam, v_dc_id_trang_thai, v_str_key_word);
            }
            m_grv_trang_thai_cu.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_grv_trang_thai_cu, m_obj_trans_1);
            CGridUtils.MakeSoTT(0, m_grv_trang_thai_cu);
            m_grv_trang_thai_cu.Redraw = true;
            set_textbox_keyword_format_before();

        }
        private void load_data_2_grid_trang_thai_moi()
        {
            DateTime v_dat_ngay = m_dtp_tu_ngay.Value.Date;
            decimal v_dc_id_trung_tam = CIPConvert.ToDecimal(m_cbo_trung_tam.SelectedValue);
            decimal v_dc_id_trang_thai = CONST_ID_TRANG_THAI_THU.ID_DA_CHUYEN_CPN; // CIPConvert.ToDecimal(m_cbo_trang_thai_moi.SelectedValue);
            string v_str_key_word = m_txt_key_word.Text;
            if (v_str_key_word == m_str_goi_y_so_bill) v_str_key_word = "";
            m_ds = new DS_V_DM_BILL();
            if (m_dtp_tu_ngay.Checked == true)
            {
                m_us.FillDatasetSearch_grid_ngay(m_ds, v_dat_ngay, v_dc_id_trung_tam, v_dc_id_trang_thai, v_str_key_word);
            }
            else
            {
                m_us.FillDatasetSearch_grid(m_ds, v_dc_id_trung_tam, v_dc_id_trang_thai, v_str_key_word);
            }
            m_grv_trang_thai_moi.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_grv_trang_thai_moi, m_obj_trans_2);
            CGridUtils.MakeSoTT(0, m_grv_trang_thai_moi);
            m_grv_trang_thai_moi.Redraw = true;
            set_textbox_keyword_format_before();
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
            i_us.DataRow2Me(v_dr);
            m_obj_trans_2.GridRow2DataRow(i_grid_row, v_dr);
        }


        private void us_object2grid_trang_thai_moi(US_V_DM_BILL i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_grv_trang_thai_moi.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans_2.DataRow2GridRow(v_dr, i_grid_row);
        }
        private void set_data_left_2_right()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_trang_thai_cu)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_trang_thai_cu, m_grv_trang_thai_cu.Row)) return;
            grid_trang_thai_cu_2us_object(m_us, m_grv_trang_thai_cu.Row);
            //chuyen tu trang thai 1-Da nhan noi bo -> 2-Da chuyen cho CPN
            change_state_of_bill(m_us.dcID, CONST_ID_TRANG_THAI_THU.ID_DA_CHUYEN_CPN);
            load_data_2_grid_trang_thai_moi();
            load_data_2_grid_trang_thai_cu();
            BaseMessages.MsgBox_Infor("Bill đã được chuyển cho CPN!");

        }
        private void set_data_right_2_left()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_trang_thai_moi)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_trang_thai_moi, m_grv_trang_thai_moi.Row)) return;
            grid_trang_thai_moi_2us_object(m_us, m_grv_trang_thai_moi.Row);
            //chuyen tu trang thai 2-Da chuyen cho CPN -> 1-Da nhan noi bo
            change_state_of_bill(m_us.dcID, CONST_ID_TRANG_THAI_THU.ID_DA_NHAN_NOI_BO);
            load_data_2_grid_trang_thai_cu();
            load_data_2_grid_trang_thai_moi();

        }
        private void set_data_left_2_right_all()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_trang_thai_cu)) return;
            for (int i = 1; i < m_grv_trang_thai_cu.Rows.Count; i++)
            {
                if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_trang_thai_cu)) return;
                if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_trang_thai_cu, i)) return;
                grid_trang_thai_cu_2us_object(m_us, i);
                //chuyen tu trang thai 1-Da nhan noi bo -> 2-Da chuyen cho CPN
                change_state_of_bill(m_us.dcID, CONST_ID_TRANG_THAI_THU.ID_DA_CHUYEN_CPN);
            }
            BaseMessages.MsgBox_Infor("Tất cả Bill đã được chuyển cho CPN!");
            load_data_2_grid_trang_thai_moi();
            load_data_2_grid_trang_thai_cu();

        }
        private void set_data_right_2_left_all()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_trang_thai_moi)) return;
            for (int i = 1; i < m_grv_trang_thai_moi.Rows.Count; i++)
            {
                if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_trang_thai_moi)) return;
                if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_trang_thai_moi, i)) return;
                grid_trang_thai_moi_2us_object(m_us, i);
                //chuyen tu trang thai 2-Da chuyen cho CPN -> 1-Da nhan noi bo
                change_state_of_bill(m_us.dcID, CONST_ID_TRANG_THAI_THU.ID_DA_NHAN_NOI_BO);
            }
            load_data_2_grid_trang_thai_moi();
            load_data_2_grid_trang_thai_cu();
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
            m_obj_trans_1 = get_trans_object(m_grv_trang_thai_cu);
            load_data_2_grid_trang_thai_cu();
            m_obj_trans_2 = get_trans_object(m_grv_trang_thai_moi);
            load_data_2_grid_trang_thai_moi();
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
            this.m_dtp_tu_ngay.ValueChanged += new System.EventHandler(this.m_dtp_tu_ngay_ValueChanged);
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
                set_data_left_2_right();
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
                set_data_right_2_left();
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
                m_grv_trang_thai_cu.Focus();
                set_data_left_2_right_all();
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
                m_grv_trang_thai_moi.Focus();
                set_data_right_2_left_all();
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
                    load_data_2_grid_trang_thai_cu();
                    load_data_2_grid_trang_thai_moi();
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
                load_data_2_grid_trang_thai_moi();
                load_data_2_grid_trang_thai_cu();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

        private void m_dtp_tu_ngay_ValueChanged(object sender, EventArgs e)
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

    }
}
