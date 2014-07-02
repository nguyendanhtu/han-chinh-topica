﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using BCTKApp.ChucNang;
using BCTKApp.HeThong;

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
            this.m_cmd_trang_thai.Click += new System.EventHandler(this.m_cmd_trang_thai_Click);
            m_cmd_quan_ly_nguoi_su_dung.Click += new EventHandler(m_cmd_quan_ly_nguoi_su_dung_Click);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_nhom_nguoi_su_dung.Click += new EventHandler(m_cmd_nhom_nguoi_su_dung_Click);
            m_cmd_phan_quyen_cho_nhom.Click += new EventHandler(m_cmd_phan_quyen_cho_nhom_Click);
            m_cmd_doi_mat_khau.Click += new EventHandler(m_cmd_doi_mat_khau_Click);
            m_cmd_tra_cuu_trang_thai_CPN.Click+=new EventHandler(m_cmd_tra_cuu_trang_thai_CPN_Click);
        }
        #endregion
        #region Event
        void m_cmd_doi_mat_khau_Click(object sender, EventArgs e)
        {
            try
            {
                f308_DOI_MAT_KHAU_NGUOI_SD v_frm = new f308_DOI_MAT_KHAU_NGUOI_SD();
                v_frm.display();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void m_cmd_phan_quyen_cho_nhom_Click(object sender, EventArgs e)
        {
            try
            {
                f995_ht_phan_quyen_cho_nhom v_frm = new f995_ht_phan_quyen_cho_nhom();
                v_frm.display();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void m_cmd_nhom_nguoi_su_dung_Click(object sender, EventArgs e)
        {
            try
            {
                f306_HT_USER_GROUP v_frm = new f306_HT_USER_GROUP();
                v_frm.display();
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
        private void m_cmd_dm_trung_tam_Click(object sender, EventArgs e)
        {
            try
            {
                f800_DM_PHONG_BAN v_frm = new f800_DM_PHONG_BAN();
                v_frm.display();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
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
            try
            {
                f810_DANG_KY_GUI_THEO_BUU v_frm = new f810_DANG_KY_GUI_THEO_BUU();
                v_frm.display();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
           
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
                f405_V_TONG_HOP_CPN_THEO_PHONG_BAN frm = new f405_V_TONG_HOP_CPN_THEO_PHONG_BAN ();
                frm.ShowDialog();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_dinh_muc_tung_phong_ban_Click(object sender, EventArgs e)
        {
            try
            {
                f702_v_dinh_muc_cpn_tung_phong_ban frm = new f702_v_dinh_muc_cpn_tung_phong_ban();
                frm.ShowDialog();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_trang_thai_Click(object sender, EventArgs e)
        {
            try
            {
                f505_CAP_NHAT_TRANG_THAI_CPN v_frm = new f505_CAP_NHAT_TRANG_THAI_CPN();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_tong_hop_bill_theo_phong_ban_Click(object sender, EventArgs e)
        {
            try
            {
                f406_V_TONG_HOP_BILL_THEO_PHONG_BAN v_frm = new f406_V_TONG_HOP_BILL_THEO_PHONG_BAN();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_quan_ly_nguoi_su_dung_Click(object sender, EventArgs e)
        {
            try
            {
                f999_ht_nguoi_su_dung v_frm = new f999_ht_nguoi_su_dung();
                v_frm.display();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_tra_cuu_trang_thai_CPN_Click(object sender, EventArgs e)
        {
            try
            {
                f511_TRA_CUU_TRANG_THAI_CPN v_frm = new f511_TRA_CUU_TRANG_THAI_CPN();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_bc_tinh_hinh_CPN_Click(object sender, EventArgs e)
        {
            try
            {
                f704_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN v_frm = new f704_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        
    }
}
