using BCTKDS;
using BCTKDS.CDBNames;
using BCTKUS;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;
using System.Collections;

namespace BCTKApp.DanhMuc
{
    public partial class f801_DM_PHONG_BAN_DE : Form
    {
        public f801_DM_PHONG_BAN_DE()
        {
            InitializeComponent();
            format_control();
        }
        #region Data Structure
        private enum e_col_Number
        {
            TY_TRONG = 3
,
            TEN_PHONG_BAN = 2
                , TEN_PHAP_NHAN = 1

        }
        #endregion
     
        #region Members
        DataEntryFormMode m_e_form_mode = new DataEntryFormMode();
        US_DM_PHONG_BAN m_us_dm_phong_ban = new US_DM_PHONG_BAN();
        DS_V_DM_PHONG_BAN_PHAP_NHAN m_ds_v = new DS_V_DM_PHONG_BAN_PHAP_NHAN();
        US_V_DM_PHONG_BAN_PHAP_NHAN m_us_v = new US_V_DM_PHONG_BAN_PHAP_NHAN();
        ITransferDataRow m_obj_trans;	
        #endregion

        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }
        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }
        public void display_for_update(US_DM_PHONG_BAN ip_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_dm_phong_ban = ip_us;
            us_obj_2_form();
            this.ShowDialog();
        }

        #endregion


        #region Private Methods
        private void format_control()
        {   
            CControlFormat.setFormStyle(this, new CAppContext_201());
            m_lbl_tieu_de.Font = new System.Drawing.Font("Tahoma", 15, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            m_chk_close_form.Font = new System.Drawing.Font("Tahoma", 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CControlFormat.setC1FlexFormat(m_grv_ty_trong);
            CGridUtils.AddSave_Excel_Handlers(m_grv_ty_trong);
            CGridUtils.AddSearch_Handlers(m_grv_ty_trong);
            m_chk_close_form.ForeColor = Color.Maroon;
            set_define_events();
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_DM_PHONG_BAN_PHAP_NHAN.TY_TRONG, e_col_Number.TY_TRONG);
            v_htb.Add(V_DM_PHONG_BAN_PHAP_NHAN.TEN_PHONG_BAN, e_col_Number.TEN_PHONG_BAN);
            v_htb.Add(V_DM_PHONG_BAN_PHAP_NHAN.TEN_PHAP_NHAN, e_col_Number.TEN_PHAP_NHAN);
            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds_v.v_DM_PHONG_BAN_PHAP_NHAN.NewRow());
            return v_obj_trans;
        }
        private bool validate_data_is_ok()
        {
            if(!CValidateTextBox.IsValid(m_txt_ma_phong_ban, DataType.StringType, allowNull.NO, true))
                return false;
            if (!CValidateTextBox.IsValid(m_txt_ten_phong_ban, DataType.StringType, allowNull.NO, true))
                return false;
            return true;
        }
        private void form_2_us_obj()
        {         
            m_us_dm_phong_ban.strMA_PHONG_BAN = m_txt_ma_phong_ban.Text;
            m_us_dm_phong_ban.strTEN_PHONG_BAN = m_txt_ten_phong_ban.Text;
            
        }
        private void us_obj_2_form()
        {
            m_txt_ma_phong_ban.Text = m_us_dm_phong_ban.strMA_PHONG_BAN;
            m_txt_ten_phong_ban.Text = m_us_dm_phong_ban.strTEN_PHONG_BAN;
           
        }
        private void grid2us_object(US_V_DM_PHONG_BAN_PHAP_NHAN i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_grv_ty_trong.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }
        private void dm_grid2us_object(US_DM_PHONG_BAN_PHAP_NHAN i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_grv_ty_trong.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }
        private void insert_grid_2_bd(decimal ip_phong_ban)
        {  
            for (int i = 1; i < m_grv_ty_trong.Rows.Count; i++) 
            {
                if (m_grv_ty_trong.Rows[i][(int)e_col_Number.TEN_PHAP_NHAN] == null) break;
                US_DM_PHONG_BAN_PHAP_NHAN v_us_pb_phap_nhan = new US_DM_PHONG_BAN_PHAP_NHAN();
                v_us_pb_phap_nhan.dcID_PHAP_NHAN = CIPConvert.ToDecimal(m_grv_ty_trong.Rows[i][(int)e_col_Number.TEN_PHAP_NHAN]);
                v_us_pb_phap_nhan.dcID_PHONG_BAN = ip_phong_ban;
                v_us_pb_phap_nhan.dcTY_TRONG = CIPConvert.ToDecimal(m_grv_ty_trong.Rows[i][(int)e_col_Number.TY_TRONG]);
                v_us_pb_phap_nhan.Insert();
            }

        }
        private void us_object2grid(US_V_DM_PHONG_BAN_PHAP_NHAN i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_grv_ty_trong.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }
        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_grv_ty_trong);
            if (m_e_form_mode == DataEntryFormMode.UpdateDataState) load_data_2_grid(m_us_dm_phong_ban.dcID);
            else
            {
                load_cbo_phong_ban_2_grid();
                m_grv_ty_trong.AllowEditing = true;
                m_grv_ty_trong.Cols[(int)e_col_Number.TEN_PHAP_NHAN].DataType = typeof(decimal);
            }
        }
        private IDictionary get_mapping_col_ten_phong_ban()
        {
            Hashtable v_hst = new Hashtable();

            US_DM_PHAP_NHAN v_us_dm_phap_nhan = new US_DM_PHAP_NHAN();
            DS_DM_PHAP_NHAN v_ds_dm_phap_nhan = new DS_DM_PHAP_NHAN();

            v_us_dm_phap_nhan.FillDataset(v_ds_dm_phap_nhan);


            foreach (DataRow v_dr in v_ds_dm_phap_nhan.DM_PHAP_NHAN.Rows)
            {
                v_hst.Add(v_dr[DM_PHAP_NHAN.ID], v_dr[DM_PHAP_NHAN.TEN_PHAP_NHAN]);
            }
            return v_hst;
        }
        private void load_cbo_phong_ban_2_grid()
        {
            m_grv_ty_trong.Cols[(int)e_col_Number.TEN_PHAP_NHAN].DataMap = get_mapping_col_ten_phong_ban();
        }
        private void load_data_2_grid(decimal ip_id_phong_ban)
        {
            m_ds_v = new DS_V_DM_PHONG_BAN_PHAP_NHAN();
            m_us_v.FillDataset(m_ds_v,"where id_phong_ban="+ip_id_phong_ban);
            m_grv_ty_trong.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds_v, m_grv_ty_trong, m_obj_trans);
            CGridUtils.MakeSoTT(0, m_grv_ty_trong);
            m_grv_ty_trong.Redraw = true;
        }
        private bool validate_ma_insert(string v_str_ma)
        {
            US_DM_PHONG_BAN v_us = new US_DM_PHONG_BAN();
            DS_DM_PHONG_BAN v_ds = new DS_DM_PHONG_BAN();
            v_us.FillDataset(v_ds, "where ma_phong_ban='" + v_str_ma+"'");
            if (v_ds.DM_PHONG_BAN.Count != 0 && m_e_form_mode==DataEntryFormMode.InsertDataState) return false;
             return true;
        }
        private bool validate_ma_update(string ip_str_ma,decimal ip_dc_id)
        {
            US_DM_PHONG_BAN v_us = new US_DM_PHONG_BAN();
            DS_DM_PHONG_BAN v_ds = new DS_DM_PHONG_BAN();
            v_us.FillDataset(v_ds, "where ma_phong_ban='" + ip_str_ma + "' or id="+ip_dc_id);
            if (v_ds.DM_PHONG_BAN.Count != 1) return false;
            return true;
        }
        private void save_data()
        {
            if (!validate_data_is_ok())
                return;
            if (!validate_ma_insert(m_txt_ma_phong_ban.Text.Trim()))
            {
                BaseMessages.MsgBox_Infor("Mã trung tâm đã tồn tại");
                xoa_trang();
                return;
            }
            form_2_us_obj();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                         m_us_dm_phong_ban.Insert();
                         insert_grid_2_bd(m_us_dm_phong_ban.dcID);
                        break;
                case DataEntryFormMode.UpdateDataState:
                        if (!validate_ma_update(m_txt_ma_phong_ban.Text.Trim(), m_us_dm_phong_ban.dcID))
                        {
                            BaseMessages.MsgBox_Infor("Mã trung tâm đã tồn tại");
                            m_txt_ma_phong_ban.Focus();
                            return;
                        }
                    m_us_dm_phong_ban.Update();
                    break;
            }
            BaseMessages.MsgBox_Infor("Đã lưu thành công!");
            if (m_chk_close_form.Checked == true)
            {
                xoa_trang();
            }
            else
            {
                this.Close();
            }
        }
        private void xoa_trang()
        {
            m_txt_ma_phong_ban.Clear();
            m_txt_ten_phong_ban.Clear();
            m_e_form_mode = DataEntryFormMode.InsertDataState;
        }
        private void set_define_events()
        {
            m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            this.KeyDown+=new KeyEventHandler(f801_DM_PHONG_BAN_DE_KeyDown);
            this.Load+=new EventHandler(f801_DM_PHONG_BAN_DE_Load);
        }
        #endregion

        #region Events
        private void f801_DM_PHONG_BAN_DE_Load(object sender, System.EventArgs e)
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
        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            //Buoc 1: Save data
            save_data();
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void f801_DM_PHONG_BAN_DE_KeyDown(object sender, KeyEventArgs e)
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

        #endregion

    }
}
