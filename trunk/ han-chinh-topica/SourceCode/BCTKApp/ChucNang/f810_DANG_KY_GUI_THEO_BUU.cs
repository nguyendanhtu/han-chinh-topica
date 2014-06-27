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

namespace BCTKApp.ChucNang
{
    public partial class f810_DANG_KY_GUI_THEO_BUU : Form
    {
        public f810_DANG_KY_GUI_THEO_BUU()
        {
            InitializeComponent();
            format_control();
            set_initial_form_load(); 
        }

        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Data structure
        private enum e_col_Number {
            NGAY_GUI = 1,
            SO_BILL = 2,
            MA_PHONG_BAN = 3,
            TEN_PHONG_BAN = 4,
            NGUOI_GUI = 5,
            NGUOI_NHAN = 6,
            NOI_NHAN = 7,
            LOAI_THU = 8,
            NOI_DUNG = 9,
            TRANG_THAI = 10 ,
            GHI_CHU = 11
        }
        #endregion

        #region Members

        #endregion

        #region Private Methods
        private void format_control()
        {
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

            set_define_events();
            this.KeyPreview = true;
        }
        private void set_initial_form_load()
        {
            load_cbo_phong_ban_2_grid();
            load_cbo_trang_thai_2_grid();
            load_cbo_loai_thu_2_grid();
            load_ten_phong_ban_tuong_ung_2_grid();
        }

        private void load_cbo_loai_thu_2_grid()
        {
            Hashtable v_hst = new Hashtable();
            v_hst.Add("Trong nước", "Trong nước");
            v_hst.Add("Ngoài nước", "Ngoài nước");

            m_fg.Cols[(int)e_col_Number.LOAI_THU].DataMap = v_hst;
        }

        private void load_cbo_trang_thai_2_grid()
        {
            m_fg.Cols[(int)e_col_Number.TRANG_THAI].DataMap = get_mapping_col_trang_thai();
        }
        private IDictionary get_mapping_col_trang_thai()
        {
            Hashtable v_hst = new Hashtable();
            v_hst.Add(CONST_ID_TRANG_THAI_THU.ID_DA_NHAN_NOI_BO, "Đã nhận nội bộ");
            v_hst.Add(CONST_ID_TRANG_THAI_THU.ID_DA_CHUYEN_CPN, "Đã chuyển CPN");
            v_hst.Add(CONST_ID_TRANG_THAI_THU.ID_DANG_TREN_DUONG, "Đang trên đường");
            v_hst.Add(CONST_ID_TRANG_THAI_THU.ID_BI_TRA_LAI, "Bị trả lại");
            v_hst.Add(CONST_ID_TRANG_THAI_THU.ID_NOI_BO_NHAN_TRA_LAI, "Nội bộ nhận trả lại");
            return v_hst;
        }
        private void load_ten_phong_ban_tuong_ung_2_grid()
        {
            m_fg.Cols[(int)e_col_Number.TEN_PHONG_BAN].DataMap = get_mapping_col_ten_phong_ban();
        }

        private IDictionary get_mapping_col_ten_phong_ban()
        {
            Hashtable v_hst = new Hashtable();

            US_DM_PHONG_BAN v_us_dm_phong_ban = new US_DM_PHONG_BAN();
            DS_DM_PHONG_BAN v_ds_dm_phong_ban = new DS_DM_PHONG_BAN();

            v_us_dm_phong_ban.FillDataset(v_ds_dm_phong_ban);


            foreach (DataRow v_dr in v_ds_dm_phong_ban.DM_PHONG_BAN.Rows)
            {
                v_hst.Add(v_dr[DM_PHONG_BAN.ID], v_dr[DM_PHONG_BAN.TEN_PHONG_BAN]);
            }
            return v_hst;
        }
        private void load_cbo_phong_ban_2_grid()
        {
            m_fg.Cols[(int)e_col_Number.MA_PHONG_BAN].DataMap = get_mapping_col_ma_phong_ban();         
        }

        private System.Collections.IDictionary get_mapping_col_ma_phong_ban()
        {
            Hashtable v_hst = new Hashtable();

            US_DM_PHONG_BAN v_us_dm_phong_ban = new US_DM_PHONG_BAN();
            DS_DM_PHONG_BAN v_ds_dm_phong_ban = new DS_DM_PHONG_BAN();

            v_us_dm_phong_ban.FillDataset(v_ds_dm_phong_ban);


            foreach (DataRow v_dr in v_ds_dm_phong_ban.DM_PHONG_BAN.Rows)
            {
                v_hst.Add(v_dr[DM_PHONG_BAN.ID], v_dr[DM_PHONG_BAN.MA_PHONG_BAN]);
            }
            return v_hst;
        }    
        private bool check_validate_is_ok()
        {
            if (!check_validate_grid_is_ok())
                return false;
            return true;
        }
        private bool check_validate_grid_is_ok()
        {
            //Check xem số bill đã tồn tại trong cơ sở dữ liệu hay chưa

            //Check nội dung các ô xem có null hay không
            for (int v_i_cur_row = m_fg.Rows.Fixed; v_i_cur_row < m_fg.Rows.Count - 1; v_i_cur_row++)
            {
                if (m_fg[v_i_cur_row, (int)e_col_Number.SO_BILL] == null)
                {
                    BaseMessages.MsgBox_Infor("Bạn chưa nhập SỐ BILL");
                    m_fg.Select(v_i_cur_row, (int)e_col_Number.SO_BILL);
                    return false;
                }
                if (m_fg[v_i_cur_row, (int)e_col_Number.MA_PHONG_BAN] == null)
                {
                    BaseMessages.MsgBox_Infor("Bạn chưa nhập MÃ PHÒNG BAN");
                    m_fg.Select(v_i_cur_row, (int)e_col_Number.MA_PHONG_BAN);
                    return false;
                }
                if (m_fg[v_i_cur_row, (int)e_col_Number.SO_BILL] == null)
                {
                    BaseMessages.MsgBox_Infor("Bạn chưa nhập SỐ BILL");
                    m_fg.Select(v_i_cur_row, (int)e_col_Number.SO_BILL);
                    return false;
                }
                if (m_fg[v_i_cur_row, (int)e_col_Number.NGUOI_GUI] == null)
                {
                    BaseMessages.MsgBox_Infor("Bạn chưa nhập NGƯỜI GỬI THƯ");
                    m_fg.Select(v_i_cur_row, (int)e_col_Number.NGUOI_GUI);
                    return false;
                }
                if (m_fg[v_i_cur_row, (int)e_col_Number.NGUOI_NHAN] == null)
                {
                    BaseMessages.MsgBox_Infor("Bạn chưa nhập NGƯỜI NHẬN THƯ");
                    m_fg.Select(v_i_cur_row, (int)e_col_Number.SO_BILL);
                    return false;
                }
                if (m_fg[v_i_cur_row, (int)e_col_Number.NOI_NHAN] == null)
                {
                    BaseMessages.MsgBox_Infor("Bạn chưa nhập NƠI NHẬN THƯ");
                    m_fg.Select(v_i_cur_row, (int)e_col_Number.NOI_NHAN);
                    return false;
                }
                          
            }
            return true;
        }
        private void save_data()
        {
            //Các bước:
            //B1. Kiểm tra dữ liệu trên grid, nếu sai thì không làm gì hết
            if (!check_validate_grid_is_ok())
                return;
            //B2. Nếu đúng rồi thì lưu thôi
            // Insert vào dm bill, cột số tiền để null
            DS_V_DM_BILL v_ds_v_dm_bill = new DS_V_DM_BILL();
            US_V_DM_BILL v_us_v_dm_bill = new US_V_DM_BILL();
            try
            {
                v_us_v_dm_bill.BeginTransaction();
                for (int v_i_cur_row = m_fg.Rows.Fixed; v_i_cur_row < m_fg.Rows.Count - 1; v_i_cur_row++)
                {
                    grid_row_2_us_v_dm_bill(v_i_cur_row, v_us_v_dm_bill);
                    v_us_v_dm_bill.Insert();
                }
                v_us_v_dm_bill.CommitTransaction();
                BaseMessages.MsgBox_Infor("Đã nhập thành công!");
            }
            catch (Exception v_e)
            {
                if (v_us_v_dm_bill.is_having_transaction())
                {
                    v_us_v_dm_bill.Rollback();
                }
                throw v_e;
            }
        }

        private void grid_row_2_us_v_dm_bill(int ip_grid_row, US_V_DM_BILL iop_us_v_dm_bill)
        {
            iop_us_v_dm_bill.datNGAY_GUI
               = m_dat_ngay_gui.Value;
            iop_us_v_dm_bill.strSO_BILL
                = CIPConvert.ToStr(m_fg[ip_grid_row, (int)e_col_Number.SO_BILL]);
            iop_us_v_dm_bill.dcID_PHONG_BAN
                = CIPConvert.ToDecimal(m_fg[ip_grid_row, (int)e_col_Number.MA_PHONG_BAN]);
            iop_us_v_dm_bill.strNGUOI_GUI
                = CIPConvert.ToStr(m_fg[ip_grid_row, (int)e_col_Number.NGUOI_GUI]);
            iop_us_v_dm_bill.strNGUOI_NHAN
                = CIPConvert.ToStr(m_fg[ip_grid_row, (int)e_col_Number.NGUOI_NHAN]);
            iop_us_v_dm_bill.strNOI_NHAN
                = CIPConvert.ToStr(m_fg[ip_grid_row, (int)e_col_Number.NGUOI_NHAN]);       
            iop_us_v_dm_bill.strNOI_DUNG
                = CIPConvert.ToStr(m_fg[ip_grid_row, (int)e_col_Number.NOI_DUNG]);
            iop_us_v_dm_bill.dcID_TRANG_THAI
                = CONST_ID_TRANG_THAI_THU.ID_DA_NHAN_NOI_BO;
            iop_us_v_dm_bill.strGHI_CHU
                = CIPConvert.ToStr(m_fg[ip_grid_row, (int)e_col_Number.GHI_CHU]);
            if (CIPConvert.ToStr(m_fg[ip_grid_row, (int)e_col_Number.LOAI_THU]) == "Trong nước")
                iop_us_v_dm_bill.strTRONG_NUOC = "x";
            else
                iop_us_v_dm_bill.strNUOC_NGOAI = "x";

            iop_us_v_dm_bill.SetSO_TIENNull();
            iop_us_v_dm_bill.SetTRANG_THAI_THUNull();
            iop_us_v_dm_bill.SetTEN_PHONG_BANNull();
            iop_us_v_dm_bill.SetTEN_PHONG_BANNull();
        }
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
            m_fg.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(m_fg_AfterEdit);
            m_cmd_del.Click += new EventHandler(m_cmd_del_Click);
            m_fg.AfterAddRow += new C1.Win.C1FlexGrid.RowColEventHandler(m_fg_AfterAddRow);
        }
    
        #endregion

        #region Events
        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                save_data();
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
       
        private void m_fg_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {         
            if (m_fg.Col == (int)e_col_Number.MA_PHONG_BAN)
                m_fg.Rows[m_fg.Row][m_fg.Col + 1] = m_fg.Rows[m_fg.Row][m_fg.Col];
            if (m_fg.Col == (int)e_col_Number.TEN_PHONG_BAN)
                m_fg.Rows[m_fg.Row][m_fg.Col - 1] = m_fg.Rows[m_fg.Row][m_fg.Col];          
        }
        private void m_cmd_del_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_fg.Rows.Count == 3)
                {
                    return;
                }
                m_fg.Rows.Remove(m_fg.Row);
                CGridUtils.MakeSoTT(0, m_fg);
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_fg_AfterAddRow(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            CGridUtils.MakeSoTT(0, m_fg);
        }

        #endregion
    }
}
