using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using BCTKApp.ChucNang;

namespace BCTKApp
{
    public partial class f400_menu_main : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public f400_menu_main()
        {
            InitializeComponent();
            format_controls();
        }


        public void display(ref IPConstants.HowUserWantTo_Exit_MainForm o_exitMode)
        {
            this.ShowDialog();
        }
        #region Private Methods
        private void format_controls()
        {
            set_define_event();
        }
        private void set_define_event()
        {
            m_cmd_dm_trung_tam.Click += new EventHandler(m_cmd_dm_trung_tam_Click);
            m_cmd_tk_nhan_su.Click += new EventHandler(m_cmd_tk_nhan_su_Click);
            m_cmd_tk_hv_dang_hoc.Click+=new EventHandler(m_cmd_tk_hv_dang_hoc_Click);
            m_cmd_hv_tuyen_moi.Click+=new EventHandler(m_cmd_hv_tuyen_moi_Click);
            m_cmd_theo_tung_bill.Click += new EventHandler(m_cmd_theo_tung_bill_Click);
        }

        
        #endregion
        #region Event
        private void m_cmd_dm_trung_tam_Click(object sender, EventArgs e)
        {
            f800_DM_PHONG_BAN v_frm = new f800_DM_PHONG_BAN();
            v_frm.display();
        }
        private void m_cmd_tk_nhan_su_Click(object sender, EventArgs e)
        {
            f501_THONG_KE_NHAN_SU v_frm = new f501_THONG_KE_NHAN_SU();
            v_frm.ShowDialog();
        }
        private void m_cmd_tk_hv_dang_hoc_Click(object sender, EventArgs e)
        {
            f502_THONG_KE_HV_DANG_HOC v_frm = new f502_THONG_KE_HV_DANG_HOC();
            v_frm.ShowDialog();
        }
        private void m_cmd_hv_tuyen_moi_Click(object sender, EventArgs e)
        {
            f503_THONG_KE_HV_TUYEN_MOI v_frm = new f503_THONG_KE_HV_TUYEN_MOI();
            v_frm.ShowDialog();
        }
        void m_cmd_theo_tung_bill_Click(object sender, EventArgs e)
        {
            f810_DANG_KY_GUI_THEO_BUU v_frm = new f810_DANG_KY_GUI_THEO_BUU();
            v_frm.display();
        }
        #endregion

        private void m_cmd_don_gia_dinh_muc_Click(object sender, EventArgs e)
        {
            try
            {
                f401_DON_GIA_DINH_MUC frm = new f401_DON_GIA_DINH_MUC();
                frm.ShowDialog();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_tong_hop_CPN_theo_phong_ban_Click(object sender, EventArgs e)
        {
            try
            {
                //f402_TONG_HOP_CPN_THEO_PHONG_BAN frm = new  f402_TONG_HOP_CPN_THEO_PHONG_BAN();
                //frm.ShowDialog();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }


    }
}
