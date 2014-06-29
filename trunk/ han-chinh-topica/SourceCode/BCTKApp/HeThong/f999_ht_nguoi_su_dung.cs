
using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;
using IP.Core.IPSystemAdmin;

using IP.Core.IPData.DBNames;

namespace BCTKApp.HeThong
{
    public partial class f999_ht_nguoi_su_dung : Form
    {
        public f999_ht_nguoi_su_dung()
        {
            InitializeComponent();
            format_controls();
        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            TRANG_THAI = 5
                ,
            NGUOI_TAO = 4
                ,
            TEN = 2
                ,
            TEN_TRUY_CAP = 1
                ,
            BUILT_IN_YN = 6
                , NGAY_TAO = 3

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_HT_NGUOI_SU_DUNG m_ds = new DS_HT_NGUOI_SU_DUNG();
        US_HT_NGUOI_SU_DUNG m_us = new US_HT_NGUOI_SU_DUNG();
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            CControlFormat.setC1FlexFormat(m_fg);
            m_fg.Cols[(int)e_col_Number.TRANG_THAI].DataMap = get_mapping_col_trang_thai();
            set_define_events();
            m_fg.AllowEditing = false;
            this.KeyPreview = true;

        }
        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_fg);
            load_data_2_grid();
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(HT_NGUOI_SU_DUNG.TRANG_THAI, e_col_Number.TRANG_THAI);
            v_htb.Add(HT_NGUOI_SU_DUNG.NGUOI_TAO, e_col_Number.NGUOI_TAO);
            v_htb.Add(HT_NGUOI_SU_DUNG.TEN, e_col_Number.TEN);
            v_htb.Add(HT_NGUOI_SU_DUNG.TEN_TRUY_CAP, e_col_Number.TEN_TRUY_CAP);
            v_htb.Add(HT_NGUOI_SU_DUNG.BUILT_IN_YN, e_col_Number.BUILT_IN_YN);
            v_htb.Add(HT_NGUOI_SU_DUNG.NGAY_TAO, e_col_Number.NGAY_TAO);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.HT_NGUOI_SU_DUNG.NewRow());
            return v_obj_trans;
        }
        private Hashtable get_mapping_col_trang_thai()
        {
            Hashtable v_hst = new Hashtable();
            v_hst.Add("0", "Đang sử dụng");
            v_hst.Add("1", "Đã đóng");
            return v_hst;
        }
        private void load_data_2_grid()
        {
            m_ds = new DS_HT_NGUOI_SU_DUNG();
            m_us.FillDataset(m_ds);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            m_fg.Redraw = true;
        }
        private void grid2us_object(US_HT_NGUOI_SU_DUNG i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_HT_NGUOI_SU_DUNG i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
        }


        private void insert_ht_nguoi_su_dung()
        {
            f998_ht_nguoi_su_dung_de v_fDE = new f998_ht_nguoi_su_dung_de();
            v_fDE.insert_new_user();
            load_data_2_grid();
        }

        private void update_ht_nguoi_su_dung()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            f998_ht_nguoi_su_dung_de v_fDE = new f998_ht_nguoi_su_dung_de();
            v_fDE.update_new_user(m_us);
            load_data_2_grid();
        }

        private void delete_ht_nguoi_su_dung()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_HT_NGUOI_SU_DUNG v_us = new US_HT_NGUOI_SU_DUNG();
            grid2us_object(v_us, m_fg.Row);
            try
            {
                v_us.BeginTransaction();
                v_us.Delete();
                v_us.CommitTransaction();
                m_fg.Rows.Remove(m_fg.Row);
            }
            catch (Exception v_e)
            {
                v_us.Rollback();
                CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
                    new CDBClientDBExceptionInterpret());
                v_objErrHandler.showErrorMessage();
            }
        }


        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            this.KeyDown += new KeyEventHandler(f999_ht_nguoi_su_dung_KeyDown);
            m_fg.DoubleClick += new EventHandler(m_fg_DoubleClick);
            this.Load +=new EventHandler(f999_ht_nguoi_su_dung_Load);
        }

        #endregion

        //
        //
        //		EVENT HANLDERS
        //
        //
        private void f999_ht_nguoi_su_dung_Load(object sender, System.EventArgs e)
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

        private void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                insert_ht_nguoi_su_dung();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {
                update_ht_nguoi_su_dung();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                delete_ht_nguoi_su_dung();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void f999_ht_nguoi_su_dung_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Escape:
                        this.Close();
                        break;
                    case Keys.Enter:
                        update_ht_nguoi_su_dung();
                        break;
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_fg_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                update_ht_nguoi_su_dung();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
