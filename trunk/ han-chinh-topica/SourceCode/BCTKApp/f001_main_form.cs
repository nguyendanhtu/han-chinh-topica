using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;

using System.Data;
using BCTKApp.HeThong;
using BCTKUS;
using BCTKDS.CDBNames;
using System.IO;
using TCPApp;
//using BCTKApp.DanhMuc;
//using BCTKApp.ChucNang;
//using BCTKApp.BaoCao;

namespace BCTKApp
{
	/// <summary>
	/// Summary description for f001_main_form.
	/// </summary>
	public class f001_main_form : System.Windows.Forms.Form
    {
        private IContainer components;

		public f001_main_form()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
            format_controls();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f001_main_form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanTriHêThôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhómNgườiDungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_user_management = new System.Windows.Forms.ToolStripMenuItem();
            this.lịchSửTruyCậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDanhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinHàngNgàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theoTừngBưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theoFileExcelTừngPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmPhòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpThôngTinTừExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bảngThôngTinCuốiThángToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tổngHợpTiềnChuyểnPhátNhanhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýDanhMụcToolStripMenuItem,
            this.báoCáoToolStripMenuItem,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanTriHêThôngToolStripMenuItem,
            this.toolStripMenuItem1,
            this.mnu_exit});
            this.hệThốngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.hệThốngToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.hệThốngToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // quanTriHêThôngToolStripMenuItem
            // 
            this.quanTriHêThôngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhómNgườiDungToolStripMenuItem,
            this.mnu_user_management,
            this.lịchSửTruyCậpToolStripMenuItem});
            this.quanTriHêThôngToolStripMenuItem.Name = "quanTriHêThôngToolStripMenuItem";
            this.quanTriHêThôngToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.quanTriHêThôngToolStripMenuItem.Text = "Quản trị hệ thống";
            // 
            // nhómNgườiDungToolStripMenuItem
            // 
            this.nhómNgườiDungToolStripMenuItem.Name = "nhómNgườiDungToolStripMenuItem";
            this.nhómNgườiDungToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.nhómNgườiDungToolStripMenuItem.Text = "Nhóm người dùng";
            this.nhómNgườiDungToolStripMenuItem.Click += new System.EventHandler(this.nhómNgườiDungToolStripMenuItem_Click);
            // 
            // mnu_user_management
            // 
            this.mnu_user_management.Name = "mnu_user_management";
            this.mnu_user_management.Size = new System.Drawing.Size(207, 24);
            this.mnu_user_management.Text = "Người sử dụng";
            this.mnu_user_management.Click += new System.EventHandler(this.mnu_user_management_Click);
            // 
            // lịchSửTruyCậpToolStripMenuItem
            // 
            this.lịchSửTruyCậpToolStripMenuItem.Name = "lịchSửTruyCậpToolStripMenuItem";
            this.lịchSửTruyCậpToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.lịchSửTruyCậpToolStripMenuItem.Text = "Lịch sử truy cập";
            this.lịchSửTruyCậpToolStripMenuItem.Click += new System.EventHandler(this.lịchSửTruyCậpToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(199, 6);
            // 
            // mnu_exit
            // 
            this.mnu_exit.Name = "mnu_exit";
            this.mnu_exit.Size = new System.Drawing.Size(202, 24);
            this.mnu_exit.Text = "Thoát";
            this.mnu_exit.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // quảnLýDanhMụcToolStripMenuItem
            // 
            this.quảnLýDanhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinHàngNgàyToolStripMenuItem,
            this.thêmPhòngBanToolStripMenuItem});
            this.quảnLýDanhMụcToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.quảnLýDanhMụcToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.quảnLýDanhMụcToolStripMenuItem.Name = "quảnLýDanhMụcToolStripMenuItem";
            this.quảnLýDanhMụcToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.quảnLýDanhMụcToolStripMenuItem.Text = "Nhập thông tin";
            // 
            // thôngTinHàngNgàyToolStripMenuItem
            // 
            this.thôngTinHàngNgàyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.theoTừngBưuToolStripMenuItem,
            this.theoFileExcelTừngPhòngToolStripMenuItem});
            this.thôngTinHàngNgàyToolStripMenuItem.Name = "thôngTinHàngNgàyToolStripMenuItem";
            this.thôngTinHàngNgàyToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            this.thôngTinHàngNgàyToolStripMenuItem.Text = "Thông tin hàng ngày";
            // 
            // theoTừngBưuToolStripMenuItem
            // 
            this.theoTừngBưuToolStripMenuItem.Name = "theoTừngBưuToolStripMenuItem";
            this.theoTừngBưuToolStripMenuItem.Size = new System.Drawing.Size(265, 24);
            this.theoTừngBưuToolStripMenuItem.Text = "Theo từng bưu";
            this.theoTừngBưuToolStripMenuItem.Click += new System.EventHandler(this.theoTừngBưuToolStripMenuItem_Click);
            // 
            // theoFileExcelTừngPhòngToolStripMenuItem
            // 
            this.theoFileExcelTừngPhòngToolStripMenuItem.Name = "theoFileExcelTừngPhòngToolStripMenuItem";
            this.theoFileExcelTừngPhòngToolStripMenuItem.Size = new System.Drawing.Size(265, 24);
            this.theoFileExcelTừngPhòngToolStripMenuItem.Text = "Theo file Excel từng phòng";
            this.theoFileExcelTừngPhòngToolStripMenuItem.Click += new System.EventHandler(this.theoFileExcelTừngPhòngToolStripMenuItem_Click);
            // 
            // thêmPhòngBanToolStripMenuItem
            // 
            this.thêmPhòngBanToolStripMenuItem.Name = "thêmPhòngBanToolStripMenuItem";
            this.thêmPhòngBanToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            this.thêmPhòngBanToolStripMenuItem.Text = "Thêm phòng ban";
            this.thêmPhòngBanToolStripMenuItem.Click += new System.EventHandler(this.thêmPhòngBanToolStripMenuItem_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpThôngTinTừExcelToolStripMenuItem,
            this.bảngThôngTinCuốiThángToolStripMenuItem});
            this.báoCáoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.báoCáoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.báoCáoToolStripMenuItem.Text = "Chức năng";
            // 
            // nhậpThôngTinTừExcelToolStripMenuItem
            // 
            this.nhậpThôngTinTừExcelToolStripMenuItem.Name = "nhậpThôngTinTừExcelToolStripMenuItem";
            this.nhậpThôngTinTừExcelToolStripMenuItem.Size = new System.Drawing.Size(322, 24);
            this.nhậpThôngTinTừExcelToolStripMenuItem.Text = "Nhập thông tin cuối tháng từ Excel";
            this.nhậpThôngTinTừExcelToolStripMenuItem.Click += new System.EventHandler(this.nhậpThôngTinTừExcelToolStripMenuItem_Click);
            // 
            // bảngThôngTinCuốiThángToolStripMenuItem
            // 
            this.bảngThôngTinCuốiThángToolStripMenuItem.Name = "bảngThôngTinCuốiThángToolStripMenuItem";
            this.bảngThôngTinCuốiThángToolStripMenuItem.Size = new System.Drawing.Size(322, 24);
            this.bảngThôngTinCuốiThángToolStripMenuItem.Text = "Bảng thông tin cuối tháng";
            this.bảngThôngTinCuốiThángToolStripMenuItem.Click += new System.EventHandler(this.bảngThôngTinCuốiThángToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tổngHợpTiềnChuyểnPhátNhanhToolStripMenuItem});
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(86, 24);
            this.toolStripMenuItem2.Text = "Thống kê";
            // 
            // tổngHợpTiềnChuyểnPhátNhanhToolStripMenuItem
            // 
            this.tổngHợpTiềnChuyểnPhátNhanhToolStripMenuItem.Name = "tổngHợpTiềnChuyểnPhátNhanhToolStripMenuItem";
            this.tổngHợpTiềnChuyểnPhátNhanhToolStripMenuItem.Size = new System.Drawing.Size(283, 24);
            this.tổngHợpTiềnChuyểnPhátNhanhToolStripMenuItem.Text = "Tổng hợp chuyển phát nhanh";
            this.tổngHợpTiềnChuyểnPhátNhanhToolStripMenuItem.Click += new System.EventHandler(this.tổngHợpTiềnChuyểnPhátNhanhToolStripMenuItem_Click);
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "");
            this.ImageList.Images.SetKeyName(1, "");
            this.ImageList.Images.SetKeyName(2, "");
            this.ImageList.Images.SetKeyName(3, "");
            this.ImageList.Images.SetKeyName(4, "");
            this.ImageList.Images.SetKeyName(5, "");
            this.ImageList.Images.SetKeyName(6, "");
            this.ImageList.Images.SetKeyName(7, "");
            this.ImageList.Images.SetKeyName(8, "");
            this.ImageList.Images.SetKeyName(9, "");
            this.ImageList.Images.SetKeyName(10, "");
            this.ImageList.Images.SetKeyName(11, "");
            this.ImageList.Images.SetKeyName(12, "");
            this.ImageList.Images.SetKeyName(13, "");
            this.ImageList.Images.SetKeyName(14, "");
            this.ImageList.Images.SetKeyName(15, "");
            this.ImageList.Images.SetKeyName(16, "");
            this.ImageList.Images.SetKeyName(17, "");
            this.ImageList.Images.SetKeyName(18, "");
            this.ImageList.Images.SetKeyName(19, "");
            this.ImageList.Images.SetKeyName(20, "");
            this.ImageList.Images.SetKeyName(21, "");
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 452);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 109);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 80);
            this.panel2.TabIndex = 5;
            // 
            // f001_main_form
            // 
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "f001_main_form";
            this.Text = "BCTK - Chương trình thống kê dữ liệu nhận từ bưu cục - version 2013.11.25";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem quảnLýDanhMụcToolStripMenuItem;
        internal ImageList ImageList;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem mnu_exit;
        private ToolStripMenuItem quanTriHêThôngToolStripMenuItem;
        private ToolStripMenuItem mnu_user_management;
        private ToolStripMenuItem lịchSửTruyCậpToolStripMenuItem;
        private ToolStripMenuItem nhómNgườiDungToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem báoCáoToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem nhậpThôngTinTừExcelToolStripMenuItem;
        private ToolStripMenuItem bảngThôngTinCuốiThángToolStripMenuItem;
        private ToolStripMenuItem thôngTinHàngNgàyToolStripMenuItem;
        private ToolStripMenuItem tổngHợpTiềnChuyểnPhátNhanhToolStripMenuItem;
        private ToolStripMenuItem thêmPhòngBanToolStripMenuItem;
        private ToolStripMenuItem theoTừngBưuToolStripMenuItem;
        private ToolStripMenuItem theoFileExcelTừngPhòngToolStripMenuItem;
        private Panel panel2;


        #region public Interface
        public void display(ref IPConstants.HowUserWantTo_Exit_MainForm o_exitMode)
        {
            this.ShowDialog();
            o_exitMode = m_exitMode;
        }

        #endregion

        #region Data Structures
      
        #endregion

        #region Members
        US_V_HT_LOG_TRUY_CAP m_us_log_truy_cap = new US_V_HT_LOG_TRUY_CAP();
        IPConstants.HowUserWantTo_Exit_MainForm m_exitMode = IPConstants.HowUserWantTo_Exit_MainForm.ExitFromSystem;
        #endregion
        
        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
            this.ShowInTaskbar = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            set_define_events();
        }
        private void form_2_us_obj_log_he_thong()
        {
            m_us_log_truy_cap.dcID_DANG_NHAP = CAppContext_201.getCurrentUserID();
            m_us_log_truy_cap.dcID_LOAI_HANH_DONG = LOG_TRUY_CAP.DANG_NHAP;
            m_us_log_truy_cap.datTHOI_GIAN = DateTime.Now;
            m_us_log_truy_cap.strDOI_TUONG_THAO_TAC = LOG_DOI_TUONG_TAC_DONG.DANG_NHAP_XUAT;
            m_us_log_truy_cap.strMO_TA = "Đăng nhập hệ thống";
            m_us_log_truy_cap.SetGHI_CHUNull();
        }
        private void show_manager_user()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.QLHT_NGUOI_SU_DUNG))
            {
                BaseMessages.MsgBox_Infor(THONG_BAO.ER_KHONG_CO_QUYEN_SU_DUNG);
                return;
            }
            f999_ht_nguoi_su_dung v_frm_999 = new f999_ht_nguoi_su_dung();
            v_frm_999.display();
        }
        private void show_introduction()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.GIOI_THIEU))
            {
                BaseMessages.MsgBox_Infor(THONG_BAO.ER_KHONG_CO_QUYEN_SU_DUNG);
                return;
            }
            f996_license_form v_frm996 = new f996_license_form();
            v_frm996.display();
        }

        private void show_tu_dien_phan_quyen()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.QLTD_TU_DIEN))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không có quyền truy nhập phần này ! ");
                return;
            }
            f100_TuDien v_frm = new f100_TuDien();
            v_frm.ShowDialog();
        }

        private void set_inital_form_load()
        {

            //f800_rpt_nhac_viec v_frm800 = new f800_rpt_nhac_viec();
            //v_frm800.display_in_container(m_pnp);

            // ghi log hệ thống
            form_2_us_obj_log_he_thong();
            try
            {
                m_us_log_truy_cap.Insert();
            }
            catch
            {
                BaseMessages.MsgBox_Infor(THONG_BAO.ER_GHI_LOG_HE_THONG);
            }
        }
        private void show_don_vi_cap_chung_chi()
        {
            //if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.QLDM_DON_VI_CAP_CC))
            //{
            //    BaseMessages.MsgBox_Infor(THONG_BAO.ER_KHONG_CO_QUYEN_SU_DUNG);
            //    return;
            //}
            //f110_dm_don_vi_cap_chung_chi v_frm110 = new f110_dm_don_vi_cap_chung_chi();
            //v_frm110.display();
        }

        private void show_loai_phoi_chung_chi()
        {
            //if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.QLDM_LOAI_PHOI))
            //{
            //    BaseMessages.MsgBox_Infor(THONG_BAO.ER_KHONG_CO_QUYEN_SU_DUNG);
            //    return;
            //}
            //f120_dm_loai_phoi_chung_chi v_f120 = new f120_dm_loai_phoi_chung_chi();
            //v_f120.display();
        }

        private void show_thong_tin_phoi_chung_chi()
        {
            //if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.QLDM_THONG_TIN_PHOI))
            //{
            //    BaseMessages.MsgBox_Infor(THONG_BAO.ER_KHONG_CO_QUYEN_SU_DUNG);
            //    return;
            //}

            //f140_dm_thong_tin_phoi_chung_chi v_f140 = new f140_dm_thong_tin_phoi_chung_chi();
            //v_f140.display();
        }
        private void show_duoi_so_vao_so()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.QLDM_DUOI_SO_VAO_SO))
            {
                BaseMessages.MsgBox_Infor(THONG_BAO.ER_KHONG_CO_QUYEN_SU_DUNG);
                return;
            }
            f100_TuDien v_f100_tu_dien_duoi_so_vao_so = new f100_TuDien();
            v_f100_tu_dien_duoi_so_vao_so.display_by_Loai_TD(LOAI_TU_DIEN_ID.DUOI_SO_VAO_SO);
        }
         private void show_lich_lam_viec()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.QLHT_NGAY_LAM_VIEC))
            {
                BaseMessages.MsgBox_Infor(THONG_BAO.ER_KHONG_CO_QUYEN_SU_DUNG);
                return;
            }
        }

        private void show_tham_so_he_thong()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.QLHT_THAM_SO_HE_THONG))
            {
                BaseMessages.MsgBox_Infor(THONG_BAO.ER_KHONG_CO_QUYEN_SU_DUNG);
                return;
            }
            f107_ht_tham_so_he_thong v_frm107 = new f107_ht_tham_so_he_thong();
            v_frm107.display();
        }

        private void show_lich_su_truy_cap()
        {
            //if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.QLHT_LICH_SU_TRUY_CAP))
            //{
            //    BaseMessages.MsgBox_Infor(THONG_BAO.ER_KHONG_CO_QUYEN_SU_DUNG);
            //    return;
            //}
            //f661_bao_cao_log_he_thong v_frm661 = new f661_bao_cao_log_he_thong();
            //v_frm661.display();
        }
        private void show_dm_nhom_nguoi_dung()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.QLHT_NHOM_NGUOI_DUNG))
            {
                BaseMessages.MsgBox_Infor(THONG_BAO.ER_KHONG_CO_QUYEN_SU_DUNG);
                return;
            }
            f997_ht_nhom_quyen v_frm997 = new f997_ht_nhom_quyen();
            v_frm997.display();
        }
        private void show_quy_trinh_cap_chung_chi()
        {
            //if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.QUY_TRINH_CAP_CC))
            //{
            //    BaseMessages.MsgBox_Infor(THONG_BAO.ER_KHONG_CO_QUYEN_SU_DUNG);
            //    return;
            //}
            //f997_quy_trinh_cap_chung_chi v_f997 = new f997_quy_trinh_cap_chung_chi();
            //v_f997.display();
        }
        private void show_dot_cap_chung_chi()
        {
            //if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.QLDM_DOT_CAP_CHUNG_CHI))
            //{
            //    BaseMessages.MsgBox_Infor(THONG_BAO.ER_KHONG_CO_QUYEN_SU_DUNG);
            //    return;
            //}
            //f150_dm_dot_cap_chung_chi v_f150 = new f150_dm_dot_cap_chung_chi();
            //v_f150.display();
        }
        private void show_phoi_chung_chi()
        {
            //if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.QLDM_PHOI_CHUNG_CHI))
            //{
            //    BaseMessages.MsgBox_Infor(THONG_BAO.ER_KHONG_CO_QUYEN_SU_DUNG);
            //    return;
            //}
            //f130_dm_phoi_chung_chi v_f130 = new f130_dm_phoi_chung_chi();
            //v_f130.display();
        }
        private void show_nhap_chung_chi()
        {
            //if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.QLNV_NHAP_TT_TUNG_CHUNG_CHI))
            //{
            //    BaseMessages.MsgBox_Infor(THONG_BAO.ER_KHONG_CO_QUYEN_SU_DUNG);
            //    return;
            //}
            //f200_lap_gd_chung_chi v_f200_lap_cc = new f200_lap_gd_chung_chi();
            //v_f200_lap_cc.display_de_them();
        }
        private void show_nhap_tt_chung_chung_chi()
        {
            //if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.QLNV_NHAP_THONG_TIN_CHUNG_CC))
            //{
            //    BaseMessages.MsgBox_Infor(THONG_BAO.ER_KHONG_CO_QUYEN_SU_DUNG);
            //    return;
            //}

            //f210_lap_thong_tin_chung_chung_chi v_f210_lap_thong_tin_chung_cc = new f210_lap_thong_tin_chung_chung_chi();
            //v_f210_lap_thong_tin_chung_cc.display_de_them();
        }
        private void show_import_chung_chi()
        {
            //if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.QLNV_IMPORT_CHUNG_CHI))
            //{
            //    BaseMessages.MsgBox_Infor(THONG_BAO.ER_KHONG_CO_QUYEN_SU_DUNG);
            //    return;
            //}
            //f220_import_excel_chung_chi v_f220_import = new f220_import_excel_chung_chi();
            //v_f220_import.display();
        }
        private void show_duyet_chung_chi()
        {
            //if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.QLNV_DUYET_CHUNG_CHI))
            //{
            //    BaseMessages.MsgBox_Infor(THONG_BAO.ER_KHONG_CO_QUYEN_SU_DUNG);
            //    return;
            //}
            //f300_bc_danh_sach_chung_chi v_f300_duyet_chung_chi = new f300_bc_danh_sach_chung_chi();
            //v_f300_duyet_chung_chi.display_de_duyet();
        }
        private void show_export_ban_mem_chung_chi()
        {
            //if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.QLNV_EXPORT_BAN_MEM_CC))
            //{
            //    BaseMessages.MsgBox_Infor(THONG_BAO.ER_KHONG_CO_QUYEN_SU_DUNG);
            //    return;
            //}
            //f300_bc_danh_sach_chung_chi v_f300_xuat_ra_ban_mem = new f300_bc_danh_sach_chung_chi();
            //v_f300_xuat_ra_ban_mem.display_de_xuat_ra_ban_mem();
        }
        private void show_danh_sach_chung_chi()
        {
            //if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.BC_DANH_SACH_CHUNG_CHI))
            //{
            //    BaseMessages.MsgBox_Infor(THONG_BAO.ER_KHONG_CO_QUYEN_SU_DUNG);
            //    return;
            //}
            //f310_bc_danh_sach_chung_chi v_f300_bc_ds_chung_chi = new f310_bc_danh_sach_chung_chi();
            //v_f300_bc_ds_chung_chi.display_bao_cao();
        }
        private void show_thao_tac_du_lieu()
        {
            f120_dm_dang_ky_gui v_form_thao_tac_du_lieu = new f120_dm_dang_ky_gui();
            v_form_thao_tac_du_lieu.display();
        }
        private void show_chuc_nang_nhap_thong_tin_tu_excel()
        {
            f130_chuc_nang v_form = new f130_chuc_nang();
            v_form.Display();
        }
        private void show_bang_thong_tin_cuoi_thang()
        {
            f140_thong_tin_cuoi_thang v_f = new f140_thong_tin_cuoi_thang();
            v_f.display();
        }
        private void show_bang_thong_ke_cuoi_thang()
        {
            f410_thong_ke_tong_hop_tien_chuyen_phat_nhanh v_f = new f410_thong_ke_tong_hop_tien_chuyen_phat_nhanh();
            v_f.display();
        }
        private void show_thao_tac_du_lieu_theo_file_excel()
        {
            f121_dm_dang_ky_gui_theo_excel v_form = new f121_dm_dang_ky_gui_theo_excel();
            v_form.Display();
        }
        #endregion

        #region Events

        private void set_define_events()
        {

            this.Load += new EventHandler(f001_main_form_Load);
        }

        void f001_main_form_Load(object sender, EventArgs e)
        {
            try
            {
                set_inital_form_load();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BaseMessages.MsgBox_Confirm("Bạn có thật sự muốn kết thúc chương trình không ? "))
                {
                    m_exitMode = IPConstants.HowUserWantTo_Exit_MainForm.ExitFromSystem;
                    this.Close();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void mnu_user_management_Click(object sender, EventArgs e)
        {
            try
            {
                show_manager_user();
                
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
            
        }

        private void mnu_license_Click(object sender, EventArgs e)
        {
            try
            {
                show_introduction();

            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        //private void mnu_directory_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        show_tu_dien_phan_quyen();
        //    }
        //    catch (Exception v_e)
        //    {

        //        CSystemLog_301.ExceptionHandle(v_e);
        //    }
        //}

        private void mnu_type_of_directory_Click(object sender, EventArgs e)
        {
            try
            {

                
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void mnu_category_Click(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void lịchSửTruyCậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                show_lich_su_truy_cap();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void nhómNgườiDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                show_dm_nhom_nguoi_dung();
            }
            catch (Exception v_e)
            {
                
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void quyTrìnhCấpPhátChứngChỉToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                show_quy_trinh_cap_chung_chi();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void phôiChứngChỉToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                show_phoi_chung_chi();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void đơnVịCấpChứngChỉToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                show_don_vi_cap_chung_chi();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void loạiPhôiChứngChỉToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                show_loai_phoi_chung_chi();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void thôngTinCủaChứngChỉToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                show_thong_tin_phoi_chung_chi();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                show_duoi_so_vao_so();
                
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_mnu_tao_dot_cap_Click(object sender, EventArgs e)
        {
            try
            {
                show_dot_cap_chung_chi();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_mnu_nhap_tt_chung_cc_Click(object sender, EventArgs e)
        {
            try
            {
                show_nhap_tt_chung_chung_chi();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_mnu_nhap_tt_tung_nguoi_Click(object sender, EventArgs e)
        {
            try
            {
                show_nhap_chung_chi();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_mnu_import_excel_Click(object sender, EventArgs e)
        {
            try
            {
                show_import_chung_chi();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_mnu_duyet_chung_chi_Click(object sender, EventArgs e)
        {
            try
            {
                show_duyet_chung_chi();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_mnu_export_ban_mem_cc_Click(object sender, EventArgs e)
        {
            try
            {
                show_export_ban_mem_chung_chi();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_mnu_ds_chung_chi_Click(object sender, EventArgs e)
        {
            try
            {
                show_danh_sach_chung_chi();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        
        #endregion

        //private void quảnLýDanhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        show_thao_tac_du_lieu();
        //    }
        //    catch (Exception v_e)
        //    {

        //        CSystemLog_301.ExceptionHandle(v_e);
        //    }
        //}

        private void nhậpThôngTinTừExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                show_chuc_nang_nhap_thong_tin_tu_excel(); 
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void bảngThôngTinCuốiThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                show_bang_thong_tin_cuoi_thang();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        //private void toolStripMenuItem2_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        show_bang_thong_ke_cuoi_thang();
        //    }
        //    catch (Exception v_e)
        //    {

        //        CSystemLog_301.ExceptionHandle(v_e);
        //    }
        //}

        //private void thôngTinHàngNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        show_thao_tac_du_lieu();
        //    }
        //    catch (Exception v_e)
        //    {

        //        CSystemLog_301.ExceptionHandle(v_e);
        //    }
        //}

        private void tổngHợpTiềnChuyểnPhátNhanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                show_bang_thong_ke_cuoi_thang();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void thêmPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                show_tu_dien_phan_quyen();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void theoTừngBưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                show_thao_tac_du_lieu();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void theoFileExcelTừngPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                show_thao_tac_du_lieu_theo_file_excel();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

    }
}
