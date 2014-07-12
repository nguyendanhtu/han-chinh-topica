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
using IP.Core.IPExcelReport;

using BCTKUS;
using BCTKDS;
using BCTKDS.CDBNames;

using BCTKApp.DanhMuc;

namespace BCTKApp.DanhMuc
{
    public partial class f448_DM_V_GD_PHONG_BAN_DINH_MUC_DE : Form
    {
    
        #region Public interface
 
        public void Display()
        {
            m_e = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }

        public void display(BCTKUS.US_V_GD_PHONG_BAN_DINH_MUC ip_v_m_us)
        {
            m_e = DataEntryFormMode.UpdateDataState;
            m_us_v_gd_pbdm = ip_v_m_us;
            m_us_obj_to_form();
            this.ShowDialog();
        }
        #endregion

        #region Members
        US_GD_PHONG_BAN_DINH_MUC m_us_gd_pbdm = new US_GD_PHONG_BAN_DINH_MUC();
        DS_GD_PHONG_BAN_DINH_MUC m_ds_gd_pbdm = new DS_GD_PHONG_BAN_DINH_MUC();
        DS_V_GD_PHONG_BAN_DINH_MUC m_ds_v_gd_pbdm = new DS_V_GD_PHONG_BAN_DINH_MUC();
        US_V_GD_PHONG_BAN_DINH_MUC m_us_v_gd_pbdm = new US_V_GD_PHONG_BAN_DINH_MUC();
        DataEntryFormMode m_e = new DataEntryFormMode();
        #endregion

        #region Private method
        private void format_control()
        {

            CControlFormat.setFormStyle(this, new CAppContext_201());
        }
        private void m_us_obj_to_form()
        {
            m_cbo_loai_dm.Text = m_us_v_gd_pbdm.strTEN_LOAI_DINH_MUC;
            m_cbo_trung_tam.Text = m_us_v_gd_pbdm.strTEN_PHONG_BAN;
            m_cbo_co_so_tinh_dm.Text = m_us_v_gd_pbdm.strTEN_CO_SO_DINH_MUC;
            m_cbo_tinh_theo_co_so.Text = m_us_v_gd_pbdm.strMA;
        }
      
        private void m_form_to_us_obj()
        {
            m_us_gd_pbdm.dcID_CO_SO_DINH_MUC = CIPConvert.ToDecimal(m_cbo_co_so_tinh_dm.SelectedValue);
            m_us_gd_pbdm.dcID_PHONG_BAN = CIPConvert.ToDecimal(m_cbo_trung_tam.SelectedValue);
            m_us_gd_pbdm.dcID_DM_CO_SO = CIPConvert.ToDecimal(m_cbo_tinh_theo_co_so.SelectedValue);
            m_us_gd_pbdm.dcID_LOAI_DINH_MUC = CIPConvert.ToDecimal(m_cbo_loai_dm.SelectedValue);
        }
        private void load_cbo_dm_co_co()
        {
            US_DM_CO_SO v_us = new US_DM_CO_SO();
            DS_DM_CO_SO v_ds = new DS_DM_CO_SO();
            v_us.FillDataset(v_ds);
            m_cbo_trung_tam.DataSource = v_ds.DM_CO_SO;
            m_cbo_trung_tam.ValueMember = DM_CO_SO.ID;
            m_cbo_trung_tam.DisplayMember = DM_CO_SO.MA;
            DataRow v_dr = v_ds.DM_CO_SO.NewRow();
            v_dr[DM_CO_SO.ID] = -1;
            v_dr[DM_CO_SO.MA] = "Tất cả";
            v_dr[DM_CO_SO.ID_LOAI_CO_SO] = -1;
            v_ds.DM_CO_SO.Rows.InsertAt(v_dr, 0);
            m_cbo_trung_tam.SelectedIndex = 0;
        }
        private void load_cbo_co_tinh_dinh_muc()
        {
            US_DM_CO_SO_DINH_MUC v_us = new US_DM_CO_SO_DINH_MUC();
            DS_DM_CO_SO_DINH_MUC v_ds = new DS_DM_CO_SO_DINH_MUC();
            v_us.FillDataset(v_ds);
            m_cbo_trung_tam.DataSource = v_ds.DM_CO_SO_DINH_MUC;
            m_cbo_trung_tam.ValueMember = DM_CO_SO_DINH_MUC.ID;
            m_cbo_trung_tam.DisplayMember = DM_CO_SO_DINH_MUC.TEN_CO_SO_DINH_MUC;
            DataRow v_dr = v_ds.DM_CO_SO_DINH_MUC.NewRow();
            v_dr[DM_CO_SO_DINH_MUC.ID] = -1;
            v_dr[DM_CO_SO_DINH_MUC.TEN_CO_SO_DINH_MUC] = "Tất cả";
            v_dr[DM_CO_SO_DINH_MUC.MA_CO_SO_DINH_MUC] = "";
            v_dr[DM_CO_SO_DINH_MUC.ID_LOAI_CO_SO_DINH_MUC] = -1;
            v_ds.DM_CO_SO_DINH_MUC.Rows.InsertAt(v_dr, 0);
            m_cbo_trung_tam.SelectedIndex = 0;
        }
        private void load_cbo_trung_tam()
        {
            US_DM_PHONG_BAN v_us = new US_DM_PHONG_BAN();
            DS_DM_PHONG_BAN v_ds = new DS_DM_PHONG_BAN();
            v_us.FillDataset(v_ds);
            m_cbo_trung_tam.DataSource = v_ds.DM_PHONG_BAN;
            m_cbo_trung_tam.ValueMember = DM_PHONG_BAN.ID;
            m_cbo_trung_tam.DisplayMember = DM_PHONG_BAN.TEN_PHONG_BAN;
            DataRow v_dr = v_ds.DM_PHONG_BAN.NewRow();
            v_dr[DM_PHONG_BAN.ID] = -1;
            v_dr[DM_PHONG_BAN.MA_PHONG_BAN] = "Tất cả";
            v_dr[DM_PHONG_BAN.TEN_PHONG_BAN] = "Tất cả";
            v_ds.DM_PHONG_BAN.Rows.InsertAt(v_dr, 0);
            m_cbo_trung_tam.SelectedIndex = 0;
        
        }
        private void load_cbo_loai_dinh_muc()
        {
        
            BCTKUS.US_CM_DM_TU_DIEN v_us = new BCTKUS.US_CM_DM_TU_DIEN();
            BCTKDS.DS_CM_DM_TU_DIEN v_ds = new BCTKDS.DS_CM_DM_TU_DIEN();
            v_us.FillDataset(v_ds, "where id_loai_tu_dien =" + 17);
            m_cbo_loai_dm.DataSource = v_ds.CM_DM_TU_DIEN;
            m_cbo_loai_dm.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_loai_dm.DisplayMember = CM_DM_TU_DIEN.TEN;
            DataRow v_dr = v_ds.CM_DM_TU_DIEN.NewRow();
            v_dr[CM_DM_TU_DIEN.ID] = -1;
            v_dr[CM_DM_TU_DIEN.ID_LOAI_TU_DIEN] = 17;
            v_dr[CM_DM_TU_DIEN.MA_TU_DIEN] = " ";
            v_dr[CM_DM_TU_DIEN.TEN] = "Tất cả";
            v_dr[CM_DM_TU_DIEN.TEN_NGAN] = "Tất cả";
            v_ds.CM_DM_TU_DIEN.Rows.InsertAt(v_dr, 0);
            m_cbo_loai_dm.SelectedIndex = 0; 
        }
        //private bool check_validate()
        //{

        //    if (!CValidateTextBox.IsValid(m_txt_ho_ten, DataType.StringType, allowNull.NO, true)) return false;
        //    if (!CValidateTextBox.IsValid(m_txt_dia_chi, DataType.StringType, allowNull.NO, true)) return false;
        //    if (!CValidateTextBox.IsValid(m_txt_dien_thoai, DataType.StringType, allowNull.NO, true)) return false;
        //    return true;
        //}
        #endregion

        #region Event
        public f448_DM_V_GD_PHONG_BAN_DINH_MUC_DE()
        {
            InitializeComponent();
            load_cbo_co_tinh_dinh_muc();
            load_cbo_dm_co_co();
            load_cbo_trung_tam();
            load_cbo_loai_dinh_muc();
        } 
 
   
        #endregion

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

        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                m_form_to_us_obj();
                switch (m_e)
                {
                    case DataEntryFormMode.InsertDataState:
                        m_us_gd_pbdm.Insert();
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        m_us_gd_pbdm.Update();
                        break;
                    default: m_us_gd_pbdm.Insert();
                        break;
                }
                this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
