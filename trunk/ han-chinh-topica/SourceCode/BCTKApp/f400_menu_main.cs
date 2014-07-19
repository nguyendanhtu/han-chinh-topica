using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using BCTKApp.ChucNang;
using BCTKApp.HeThong;
using BCTKApp.DanhMuc;

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
            //m_rib_bar_qldm_thong_ke.Visible = true;
        }
        private void set_define_event()
        {
            m_cmd_dm_trung_tam.Click += new EventHandler(m_cmd_dm_trung_tam_Click);
            m_cmd_tk_nhan_su.Click += new EventHandler(m_cmd_tk_nhan_su_Click);
            m_cmd_tk_hv.Click+=new EventHandler(m_cmd_tk_hv_Click);
            m_cmd_hv_tuyen_moi.Click+=new EventHandler(m_cmd_hv_tuyen_moi_Click);
            m_cmd_theo_tung_bill.Click += new EventHandler(m_cmd_theo_tung_bill_Click);
            this.m_cmd_trang_thai.Click += new System.EventHandler(this.m_cmd_trang_thai_Click);
            m_cmd_quan_ly_nguoi_su_dung.Click += new EventHandler(m_cmd_quan_ly_nguoi_su_dung_Click);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_nhom_nguoi_su_dung.Click += new EventHandler(m_cmd_nhom_nguoi_su_dung_Click);
            m_cmd_phan_quyen_cho_nhom.Click += new EventHandler(m_cmd_phan_quyen_cho_nhom_Click);
            m_cmd_doi_mat_khau.Click += new EventHandler(m_cmd_doi_mat_khau_Click);
            m_cmd_tra_cuu_trang_thai_CPN.Click+=new EventHandler(m_cmd_tra_cuu_trang_thai_CPN_Click);
            m_cmd_thong_tin_thang_excel.Click += new EventHandler(m_cmd_thong_tin_thang_excel_Click);
            m_cmd_tra_cuu_Bill.Click += new EventHandler(m_cmd_tra_cuu_Bill_Click);
            this.Load += new EventHandler(f400_menu_main_Load);
            m_cmd_dm_co_so.Click+=new EventHandler(m_cmd_dm_co_so_Click);
            m_cmd_co_dinh_muc_trung_tam.Click += new EventHandler(m_cmd_co_dinh_muc_trung_tam_Click);
            m_cmd_co_so_dinh_muc.Click+=new EventHandler(m_cmd_co_so_dinh_muc_Click);
            m_cmd_phong_ban_phap_nhan.Click += new System.EventHandler(this.m_cmd_phong_ban_phap_nhan_Click);
            m_cmd_bc_thu_tra_lai.Click+=new EventHandler(m_cmd_bc_thu_tra_lai_Click);
            m_cmd_dinh_muc_tung_phong_ban.Click += new EventHandler(m_cmd_dinh_muc_tung_phong_ban_Click);
            m_cmd_tong_hop_bill_theo_phong_ban.Click += new EventHandler(m_cmd_tong_hop_bill_theo_phong_ban_Click);
            m_cmd_bc_tinh_hinh_CPN.Click += new EventHandler(m_cmd_bc_tinh_hinh_CPN_Click);
            m_cmd_bc_chi_phi_theo_phap_nhan.Click += new EventHandler(m_cmd_bc_chi_phi_theo_phap_nhan_Click);
            m_cmd_dm_bill.Click+=new EventHandler(m_cmd_dm_bill_Click);
            m_cmd_don_gia_dinh_muc.Click += new EventHandler(m_cmd_don_gia_dinh_muc_Click);
        }

        void f400_menu_main_Load(object sender, EventArgs e)
        {
            //string ngay = "01-02-2014";
            //DateTime v_dat = new DateTime();
            //v_dat = CIPConvert.ToDatetime(ngay);
        }

     
        #endregion
        #region Event
        private void m_cmd_thong_tin_thang_excel_Click(object sender, EventArgs e)
        {
            try
            {
                f820_NHAP_CHI_PHI_CUOI_THANG v_frm = new f820_NHAP_CHI_PHI_CUOI_THANG();
                v_frm.Display();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
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
                f800_V_DM_PHONG_BAN v_frm = new f800_V_DM_PHONG_BAN();
                v_frm.display();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_tk_nhan_su_Click(object sender, EventArgs e)
        {
            f521_THONG_KE_NHAN_SU v_frm = new f521_THONG_KE_NHAN_SU();
            v_frm.ShowDialog();
        }
        private void m_cmd_tk_hv_Click(object sender, EventArgs e)
        {
            f523_V_GD_THONG_KE_HOC_VIEN v_frm = new f523_V_GD_THONG_KE_HOC_VIEN();
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
                f849_RPT_CO_SO_DINH_MUC v_frm = new f849_RPT_CO_SO_DINH_MUC();
                v_frm.ShowDialog();
                //f850_RPT_BANG_DINH_MUC v_frm = new f850_RPT_BANG_DINH_MUC();
                //v_frm.ShowDialog();
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
                f860_RPT_TONG_TIEN_DINH_MUC frm = new f860_RPT_TONG_TIEN_DINH_MUC();
                frm.display();
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
                F506_CAP_NHAT_TRANG_THAI v_frm = new F506_CAP_NHAT_TRANG_THAI();
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

        private void m_cmd_bc_chi_phi_theo_phap_nhan_Click(object sender, EventArgs e)
        {
            try
            {
                f870_RPT_CHI_PHI_THEO_PHAP_NHAN v_frm = new f870_RPT_CHI_PHI_THEO_PHAP_NHAN();
                v_frm.display(); ;
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_tra_cuu_Bill_Click(object sender, EventArgs e)
        {
            try
            {
                f405_V_TONG_HOP_CPN_THEO_PHONG_BAN v_frm = new f405_V_TONG_HOP_CPN_THEO_PHONG_BAN();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_dm_co_so_Click(object sender, EventArgs e)
        {
            try
            {
                f508_V_DM_CO_SO v_frm = new f508_V_DM_CO_SO();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_co_dinh_muc_trung_tam_Click (object sender, EventArgs e)
        {
            try
            {
                f446_DM_V_GD_PHONG_BAN_DINH_MUC v_frm = new f446_DM_V_GD_PHONG_BAN_DINH_MUC();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_co_so_dinh_muc_Click(object sender, EventArgs e)
        {
            try
            {
                f518_V_DM_CO_SO_DINH_MUC v_frm = new f518_V_DM_CO_SO_DINH_MUC();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_phong_ban_phap_nhan_Click(object sender, EventArgs e)
        {
            try
            {
                f488_V_GD_PHONG_BAN_PHAP_NHAN v_frm = new f488_V_GD_PHONG_BAN_PHAP_NHAN();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_bc_thu_tra_lai_Click(object sender, EventArgs e)
        {
            try
            {
                f512_BILL_BI_TRA_LAI v_frm = new f512_BILL_BI_TRA_LAI();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_dm_bill_Click(object sender, EventArgs e)
        {
            try
            {
                f516_V_DM_BILL v_frm = new f516_V_DM_BILL();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
