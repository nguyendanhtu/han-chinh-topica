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

        public void display_for_insert()
        {
            m_e = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }

        public void display_for_update(BCTKUS.US_V_GD_PHONG_BAN_DINH_MUC ip_v_m_us)
        {
            m_e = DataEntryFormMode.UpdateDataState;
            m_us_v_gd_pbdm = ip_v_m_us;
            m_us_obj_to_form();
            m_id = ip_v_m_us.dcID;
            this.ShowDialog();
        }
        #endregion

        #region Members
        US_GD_PHONG_BAN_DINH_MUC m_us_gd_pbdm = new US_GD_PHONG_BAN_DINH_MUC();
        DS_GD_PHONG_BAN_DINH_MUC m_ds_gd_pbdm = new DS_GD_PHONG_BAN_DINH_MUC();
        DS_V_GD_PHONG_BAN_DINH_MUC m_ds_v_gd_pbdm = new DS_V_GD_PHONG_BAN_DINH_MUC();
        US_V_GD_PHONG_BAN_DINH_MUC m_us_v_gd_pbdm = new US_V_GD_PHONG_BAN_DINH_MUC();
        decimal m_id;
        DataEntryFormMode m_e = new DataEntryFormMode();
        bool flag_loai_dm = false;
        bool flag_loai_co_so_dm = true;
        #endregion

        #region Private method
        private void format_control()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            // m_lbl_header
            // 
            this.m_lbl_header.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //
            m_cbo_co_so_tinh_dm.DropDownStyle = ComboBoxStyle.DropDownList;
            m_cbo_loai_dm.DropDownStyle = ComboBoxStyle.DropDownList;
            m_cbo_tinh_theo_co_so.DropDownStyle = ComboBoxStyle.DropDownList;
            m_cbo_trung_tam.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void m_us_obj_to_form()
        {
            m_cbo_loai_dm.Text = m_us_v_gd_pbdm.strTEN_LOAI_DINH_MUC;
            m_cbo_trung_tam.Text = m_us_v_gd_pbdm.strTEN_PHONG_BAN;
            m_cbo_co_so_tinh_dm.Text = m_us_v_gd_pbdm.strTEN_CO_SO_DINH_MUC;
            m_cbo_tinh_theo_co_so.Text = m_us_v_gd_pbdm.strMA_CO_SO;
        }
        private void m_form_to_us_obj()
        {
            if (m_cbo_co_so_tinh_dm.SelectedValue != null)
            {
                m_us_gd_pbdm.dcID_CO_SO_DINH_MUC = CIPConvert.ToDecimal(m_cbo_co_so_tinh_dm.SelectedValue);
                flag_loai_co_so_dm = true;
            }
            else
            {
                flag_loai_co_so_dm = false;
                return;
            }
            m_us_gd_pbdm.dcID_PHONG_BAN = CIPConvert.ToDecimal(m_cbo_trung_tam.SelectedValue);
            m_us_gd_pbdm.dcID_DM_CO_SO = CIPConvert.ToDecimal(m_cbo_tinh_theo_co_so.SelectedValue);
            //m_us_gd_pbdm.dcID_LOAI_DINH_MUC = CIPConvert.ToDecimal(m_cbo_loai_dm.SelectedValue);
        }
        private void load_cbo_dm_co_co()
        {
            US_DM_CO_SO v_us = new US_DM_CO_SO();
            DS_DM_CO_SO v_ds = new DS_DM_CO_SO();
            v_us.FillDataset(v_ds);
            m_cbo_tinh_theo_co_so.DataSource = v_ds.DM_CO_SO;
            m_cbo_tinh_theo_co_so.ValueMember = DM_CO_SO.ID;
            m_cbo_tinh_theo_co_so.DisplayMember = DM_CO_SO.MA;
            //DataRow v_dr = v_ds.DM_CO_SO.NewRow();
            //v_dr[DM_CO_SO.ID] = -1;
            //v_dr[DM_CO_SO.MA] = "Tất cả";
            //v_dr[DM_CO_SO.ID_LOAI_CO_SO] = -1;
            //v_ds.DM_CO_SO.Rows.InsertAt(v_dr, 0);
            m_cbo_tinh_theo_co_so.SelectedIndex = 0;
        }
        private void load_cbo_co_tinh_dinh_muc(decimal ip_id_loai_dinh_muc)
        {
            m_cbo_co_so_tinh_dm.ResetText();
            US_DM_CO_SO_DINH_MUC v_us = new US_DM_CO_SO_DINH_MUC();
            DS_DM_CO_SO_DINH_MUC v_ds = new DS_DM_CO_SO_DINH_MUC();
            v_us.FillDataset(v_ds, "where id_loai_dinh_muc= " + ip_id_loai_dinh_muc);

            m_cbo_co_so_tinh_dm.DataSource = v_ds.DM_CO_SO_DINH_MUC;
            m_cbo_co_so_tinh_dm.ValueMember = DM_CO_SO_DINH_MUC.ID;
            m_cbo_co_so_tinh_dm.DisplayMember = DM_CO_SO_DINH_MUC.TEN_CO_SO_DINH_MUC;
            //DataRow v_dr = v_ds.DM_CO_SO_DINH_MUC.NewRow();
            //v_dr[DM_CO_SO_DINH_MUC.ID] = -1;
            //v_dr[DM_CO_SO_DINH_MUC.TEN_CO_SO_DINH_MUC] = "Tất cả";
            //v_dr[DM_CO_SO_DINH_MUC.MA_CO_SO_DINH_MUC] = "";
            //v_dr[DM_CO_SO_DINH_MUC.ID_LOAI_CO_SO_DINH_MUC] = -1;
            //v_ds.DM_CO_SO_DINH_MUC.Rows.InsertAt(v_dr, 0);
            //m_cbo_co_so_tinh_dm.SelectedIndex = 0;
        }
        private void load_cbo_trung_tam()
        {
            US_DM_PHONG_BAN v_us = new US_DM_PHONG_BAN();
            DS_DM_PHONG_BAN v_ds = new DS_DM_PHONG_BAN();
            v_us.FillDataset(v_ds);
            m_cbo_trung_tam.DataSource = v_ds.DM_PHONG_BAN;
            m_cbo_trung_tam.ValueMember = DM_PHONG_BAN.ID;
            m_cbo_trung_tam.DisplayMember = DM_PHONG_BAN.TEN_PHONG_BAN;
            //DataRow v_dr = v_ds.DM_PHONG_BAN.NewRow();
            //v_dr[DM_PHONG_BAN.ID] = -1;
            //v_dr[DM_PHONG_BAN.MA_PHONG_BAN] = "Tất cả";
            //v_dr[DM_PHONG_BAN.TEN_PHONG_BAN] = "Tất cả";
            //v_ds.DM_PHONG_BAN.Rows.InsertAt(v_dr, 0);
            m_cbo_trung_tam.SelectedIndex = 0;

        }
        private void load_cbo_loai_dinh_muc()
        {
            BCTKUS.US_CM_DM_TU_DIEN v_us = new BCTKUS.US_CM_DM_TU_DIEN();
            BCTKDS.DS_CM_DM_TU_DIEN v_ds = new BCTKDS.DS_CM_DM_TU_DIEN();
            v_us.FillDataset(v_ds, "where id_loai_tu_dien =" + 17);
            m_cbo_loai_dm.DataSource = v_ds.CM_DM_TU_DIEN;
            m_cbo_loai_dm.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_loai_dm.DisplayMember = CM_DM_TU_DIEN.TEN_NGAN;
            //DataRow v_dr = v_ds.CM_DM_TU_DIEN.NewRow();
            //v_dr[CM_DM_TU_DIEN.ID] = -1;
            //v_dr[CM_DM_TU_DIEN.ID_LOAI_TU_DIEN] = 17;
            //v_dr[CM_DM_TU_DIEN.MA_TU_DIEN] = " ";
            //v_dr[CM_DM_TU_DIEN.TEN] = "Tất cả";
            //v_dr[CM_DM_TU_DIEN.TEN_NGAN] = "Tất cả";
            //v_ds.CM_DM_TU_DIEN.Rows.InsertAt(v_dr, 0);
            //m_cbo_loai_dm.SelectedIndex = 0;
            flag_loai_dm = true;
        }
        private bool check_trung_tam(decimal ip_id_trung_tam, decimal ip_loai_dm)
        {
            US_V_GD_PHONG_BAN_DINH_MUC v_us = new US_V_GD_PHONG_BAN_DINH_MUC();
            DS_V_GD_PHONG_BAN_DINH_MUC v_ds = new DS_V_GD_PHONG_BAN_DINH_MUC();
            v_us.FillDataset(v_ds, "where id_phong_ban=" + ip_id_trung_tam + "and id_loai_dinh_muc =" + ip_loai_dm);
            if (v_ds.Tables[0].Rows.Count != 0)
                return false;
            else
                return true;
        }
        private void save_data()
        {
            m_form_to_us_obj();
            switch (m_e)
            {
                case DataEntryFormMode.InsertDataState:
                    if (flag_loai_co_so_dm == false)
                    {
                        BaseMessages.MsgBox_Infor("Chưa có cách tính định mức với loại định mức này!");
                        return;
                    }
                    if (!check_trung_tam(CIPConvert.ToDecimal(m_cbo_trung_tam.SelectedValue), CIPConvert.ToDecimal(m_cbo_loai_dm.SelectedValue)))
                    {
                        BaseMessages.MsgBox_Error("Đã tồn tại cơ sở định mức của trung tâm này!");
                        return;
                    }
                    m_us_gd_pbdm.Insert();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_gd_pbdm.dcID = m_id;
                    m_us_gd_pbdm.Update();
                    break;
            }
            BaseMessages.MsgBox_Infor("Cập nhật thành công!");
            this.Close();
        }
        private void set_define_event()
        {
            m_cmd_save.Click += new System.EventHandler(m_cmd_save_Click);
            m_cmd_exit.Click += new System.EventHandler(m_cmd_exit_Click);
            KeyDown += new System.Windows.Forms.KeyEventHandler(f448_DM_V_GD_PHONG_BAN_DINH_MUC_DE_KeyDown);
            m_cbo_loai_dm.SelectedValueChanged += new EventHandler(m_cbo_loai_dm_SelectedValueChanged);
        }
        #endregion

        #region Event
        private void m_cbo_loai_dm_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (flag_loai_dm == true)
                {
                    load_cbo_co_tinh_dinh_muc(CIPConvert.ToDecimal(m_cbo_loai_dm.SelectedValue));
                }
            }
            catch (System.Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);
            }
        }
        public f448_DM_V_GD_PHONG_BAN_DINH_MUC_DE()
        {
            InitializeComponent();
            format_control();
            set_define_event();
            //load_cbo_co_tinh_dinh_muc();
            load_cbo_dm_co_co();
            load_cbo_trung_tam();
            load_cbo_loai_dinh_muc();
            load_cbo_co_tinh_dinh_muc(CIPConvert.ToDecimal(m_cbo_loai_dm.SelectedValue));
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
        private void f448_DM_V_GD_PHONG_BAN_DINH_MUC_DE_KeyDown(object sender, KeyEventArgs e)
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
        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                save_data();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

    }
}
