///************************************************
/// Generated by: HuyTD
/// Date: 29/06/2014 09:01:40
/// Goal: Create Form for V_TONG_HOP_BILL_THEO_PHONG_BAN
///************************************************


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

using BCTKUS;
using BCTKDS;
using BCTKDS.CDBNames;

using C1.Win.C1FlexGrid;
using IP.Core.IPExcelReport;

namespace BCTKApp
{



	public class f411_V_TONG_HOP_CHI_PHI_THEO_PHONG_BAN_VA_PHAP_NHAN : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
		private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
		internal SIS.Controls.Button.SiSButton m_cmd_delete;
		internal SIS.Controls.Button.SiSButton m_cmd_update;
		internal SIS.Controls.Button.SiSButton m_cmd_insert;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private Label m_lbl_header;
        private Label m_lbl_tu_ngay;
        private Label m_lbl_den_ngay;
        private ComboBox m_cbo_trang_thai;
        private Label m_lbl_trang_thai;
        private Label m_lbl_tu_khoa;
        private TextBox m_txt_tim_kiem;
        private Label m_lbl_chu_thich;
        internal SIS.Controls.Button.SiSButton m_cmd_tim_kiem;
        private Label label2;
        private Label m_lbl_ten_phap_nhan;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label m_lbl_tong_bill;
        private Label label6;
        private Label m_lbl_tong_chi_phi;
        internal SIS.Controls.Button.SiSButton m_cmd_xuat_excel;
		private System.ComponentModel.IContainer components;

        public f411_V_TONG_HOP_CHI_PHI_THEO_PHONG_BAN_VA_PHAP_NHAN()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f411_V_TONG_HOP_CHI_PHI_THEO_PHONG_BAN_VA_PHAP_NHAN));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_xuat_excel = new SIS.Controls.Button.SiSButton();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.m_lbl_tu_ngay = new System.Windows.Forms.Label();
            this.m_lbl_den_ngay = new System.Windows.Forms.Label();
            this.m_cbo_trang_thai = new System.Windows.Forms.ComboBox();
            this.m_lbl_trang_thai = new System.Windows.Forms.Label();
            this.m_lbl_tu_khoa = new System.Windows.Forms.Label();
            this.m_txt_tim_kiem = new System.Windows.Forms.TextBox();
            this.m_lbl_chu_thich = new System.Windows.Forms.Label();
            this.m_cmd_tim_kiem = new SIS.Controls.Button.SiSButton();
            this.label2 = new System.Windows.Forms.Label();
            this.m_lbl_ten_phap_nhan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_lbl_tong_bill = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.m_lbl_tong_chi_phi = new System.Windows.Forms.Label();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.SuspendLayout();
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
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_xuat_excel);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 525);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(940, 36);
            this.m_pnl_out_place_dm.TabIndex = 19;
            // 
            // m_cmd_xuat_excel
            // 
            this.m_cmd_xuat_excel.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_xuat_excel.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_xuat_excel.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_xuat_excel.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_xuat_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_xuat_excel.ImageIndex = 19;
            this.m_cmd_xuat_excel.ImageList = this.ImageList;
            this.m_cmd_xuat_excel.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_xuat_excel.Name = "m_cmd_xuat_excel";
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_xuat_excel.TabIndex = 26;
            this.m_cmd_xuat_excel.Text = "Xuất Excel";
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_insert.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_insert.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_insert.ImageIndex = 2;
            this.m_cmd_insert.ImageList = this.ImageList;
            this.m_cmd_insert.Location = new System.Drawing.Point(584, 4);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_insert.TabIndex = 12;
            this.m_cmd_insert.Text = "&Thêm";
            this.m_cmd_insert.Visible = false;
            // 
            // m_cmd_update
            // 
            this.m_cmd_update.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_update.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_update.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_update.ImageIndex = 3;
            this.m_cmd_update.ImageList = this.ImageList;
            this.m_cmd_update.Location = new System.Drawing.Point(672, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_update.TabIndex = 13;
            this.m_cmd_update.Text = "&Sửa";
            this.m_cmd_update.Visible = false;
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_delete.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_delete.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_delete.ImageIndex = 4;
            this.m_cmd_delete.ImageList = this.ImageList;
            this.m_cmd_delete.Location = new System.Drawing.Point(760, 4);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_delete.TabIndex = 14;
            this.m_cmd_delete.Text = "&Xoá";
            this.m_cmd_delete.Visible = false;
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 12;
            this.m_cmd_exit.ImageList = this.ImageList;
            this.m_cmd_exit.Location = new System.Drawing.Point(848, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_fg
            // 
            this.m_fg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Location = new System.Drawing.Point(0, 220);
            this.m_fg.Name = "m_fg";
            this.m_fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.m_fg.Size = new System.Drawing.Size(940, 305);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 16;
            this.m_fg.DoubleClick += new System.EventHandler(this.m_fg_DoubleClick);
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.AutoSize = true;
            this.m_lbl_header.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(397, 9);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(516, 22);
            this.m_lbl_header.TabIndex = 0;
            this.m_lbl_header.Text = "TỔNG HỢP CHI PHÍ THEO PHÒNG BAN VÀ PHÁP NHÂN";
            // 
            // m_lbl_tu_ngay
            // 
            this.m_lbl_tu_ngay.AutoSize = true;
            this.m_lbl_tu_ngay.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_tu_ngay.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_tu_ngay.Location = new System.Drawing.Point(397, 54);
            this.m_lbl_tu_ngay.Name = "m_lbl_tu_ngay";
            this.m_lbl_tu_ngay.Size = new System.Drawing.Size(63, 15);
            this.m_lbl_tu_ngay.TabIndex = 2;
            this.m_lbl_tu_ngay.Text = "01/01/2001";
            // 
            // m_lbl_den_ngay
            // 
            this.m_lbl_den_ngay.AutoSize = true;
            this.m_lbl_den_ngay.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_den_ngay.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_den_ngay.Location = new System.Drawing.Point(602, 54);
            this.m_lbl_den_ngay.Name = "m_lbl_den_ngay";
            this.m_lbl_den_ngay.Size = new System.Drawing.Size(63, 15);
            this.m_lbl_den_ngay.TabIndex = 4;
            this.m_lbl_den_ngay.Text = "01/01/2050";
            // 
            // m_cbo_trang_thai
            // 
            this.m_cbo_trang_thai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.m_cbo_trang_thai.Enabled = false;
            this.m_cbo_trang_thai.FormattingEnabled = true;
            this.m_cbo_trang_thai.Location = new System.Drawing.Point(400, 90);
            this.m_cbo_trang_thai.Name = "m_cbo_trang_thai";
            this.m_cbo_trang_thai.Size = new System.Drawing.Size(176, 21);
            this.m_cbo_trang_thai.TabIndex = 6;
            this.m_cbo_trang_thai.SelectedIndexChanged += new System.EventHandler(this.m_cbo_trang_thai_SelectedIndexChanged);
            // 
            // m_lbl_trang_thai
            // 
            this.m_lbl_trang_thai.AutoSize = true;
            this.m_lbl_trang_thai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_trang_thai.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_trang_thai.Location = new System.Drawing.Point(320, 90);
            this.m_lbl_trang_thai.Name = "m_lbl_trang_thai";
            this.m_lbl_trang_thai.Size = new System.Drawing.Size(65, 15);
            this.m_lbl_trang_thai.TabIndex = 5;
            this.m_lbl_trang_thai.Text = "Trạng thái:";
            // 
            // m_lbl_tu_khoa
            // 
            this.m_lbl_tu_khoa.AutoSize = true;
            this.m_lbl_tu_khoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_tu_khoa.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_tu_khoa.Location = new System.Drawing.Point(320, 129);
            this.m_lbl_tu_khoa.Name = "m_lbl_tu_khoa";
            this.m_lbl_tu_khoa.Size = new System.Drawing.Size(54, 15);
            this.m_lbl_tu_khoa.TabIndex = 7;
            this.m_lbl_tu_khoa.Text = "Từ khóa:";
            // 
            // m_txt_tim_kiem
            // 
            this.m_txt_tim_kiem.Location = new System.Drawing.Point(401, 124);
            this.m_txt_tim_kiem.Name = "m_txt_tim_kiem";
            this.m_txt_tim_kiem.Size = new System.Drawing.Size(276, 20);
            this.m_txt_tim_kiem.TabIndex = 8;
            this.m_txt_tim_kiem.TextChanged += new System.EventHandler(this.m_txt_tim_kiem_TextChanged);
            // 
            // m_lbl_chu_thich
            // 
            this.m_lbl_chu_thich.AutoSize = true;
            this.m_lbl_chu_thich.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_chu_thich.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_chu_thich.Location = new System.Drawing.Point(398, 147);
            this.m_lbl_chu_thich.Name = "m_lbl_chu_thich";
            this.m_lbl_chu_thich.Size = new System.Drawing.Size(181, 14);
            this.m_lbl_chu_thich.TabIndex = 17;
            this.m_lbl_chu_thich.Text = "* Nhập mã phòng ban, tên phòng ban";
            // 
            // m_cmd_tim_kiem
            // 
            this.m_cmd_tim_kiem.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_tim_kiem.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_tim_kiem.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_tim_kiem.ForeColor = System.Drawing.Color.Maroon;
            this.m_cmd_tim_kiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_tim_kiem.ImageIndex = 18;
            this.m_cmd_tim_kiem.ImageList = this.ImageList;
            this.m_cmd_tim_kiem.Location = new System.Drawing.Point(707, 119);
            this.m_cmd_tim_kiem.Name = "m_cmd_tim_kiem";
            this.m_cmd_tim_kiem.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_tim_kiem.TabIndex = 9;
            this.m_cmd_tim_kiem.Text = "Tìm kiếm";
            this.m_cmd_tim_kiem.Click += new System.EventHandler(this.m_cmd_tim_kiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(28, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pháp nhân:";
            // 
            // m_lbl_ten_phap_nhan
            // 
            this.m_lbl_ten_phap_nhan.AutoSize = true;
            this.m_lbl_ten_phap_nhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_ten_phap_nhan.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_ten_phap_nhan.Location = new System.Drawing.Point(122, 183);
            this.m_lbl_ten_phap_nhan.Name = "m_lbl_ten_phap_nhan";
            this.m_lbl_ten_phap_nhan.Size = new System.Drawing.Size(21, 19);
            this.m_lbl_ten_phap_nhan.TabIndex = 11;
            this.m_lbl_ten_phap_nhan.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(320, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(514, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đến ngày:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(396, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tổng số Bill:";
            // 
            // m_lbl_tong_bill
            // 
            this.m_lbl_tong_bill.AutoSize = true;
            this.m_lbl_tong_bill.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_tong_bill.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_tong_bill.Location = new System.Drawing.Point(508, 183);
            this.m_lbl_tong_bill.Name = "m_lbl_tong_bill";
            this.m_lbl_tong_bill.Size = new System.Drawing.Size(17, 19);
            this.m_lbl_tong_bill.TabIndex = 13;
            this.m_lbl_tong_bill.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(680, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tổng chi phí:";
            // 
            // m_lbl_tong_chi_phi
            // 
            this.m_lbl_tong_chi_phi.AutoSize = true;
            this.m_lbl_tong_chi_phi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_tong_chi_phi.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_tong_chi_phi.Location = new System.Drawing.Point(794, 183);
            this.m_lbl_tong_chi_phi.Name = "m_lbl_tong_chi_phi";
            this.m_lbl_tong_chi_phi.Size = new System.Drawing.Size(17, 19);
            this.m_lbl_tong_chi_phi.TabIndex = 15;
            this.m_lbl_tong_chi_phi.Text = "0";
            // 
            // f411_V_TONG_HOP_CHI_PHI_THEO_PHONG_BAN_VA_PHAP_NHAN
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(940, 561);
            this.Controls.Add(this.m_cmd_tim_kiem);
            this.Controls.Add(this.m_txt_tim_kiem);
            this.Controls.Add(this.m_cbo_trang_thai);
            this.Controls.Add(this.m_lbl_chu_thich);
            this.Controls.Add(this.m_lbl_ten_phap_nhan);
            this.Controls.Add(this.m_lbl_tong_chi_phi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.m_lbl_tong_bill);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_lbl_tu_khoa);
            this.Controls.Add(this.m_lbl_trang_thai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_lbl_den_ngay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_lbl_tu_ngay);
            this.Controls.Add(this.m_lbl_header);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f411_V_TONG_HOP_CHI_PHI_THEO_PHONG_BAN_VA_PHAP_NHAN";
            this.Text = "F411- Tổng hợp chi phí theo phòng ban và pháp nhân";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.f411_V_TONG_HOP_CHI_PHI_THEO_PHONG_BAN_VA_PHAP_NHAN_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		#region Public Interface

        public void Display_for_chi_tiet(decimal v_id_phap_nhan, decimal v_id_trang_thai, DateTime v_dt_tu_ngay, DateTime v_dt_den_ngay, decimal v_tong_bill, decimal v_tong_chi_phi)
        {
            m_obj_trans = get_trans_object(m_fg);
            format_controls();
            m_dt_tu_ngay = v_dt_tu_ngay;
            m_dt_den_ngay = v_dt_den_ngay;
            m_id_trang_thai = v_id_trang_thai;
            load_txt_cbo_trang_thai();
            BCTKUS.US_CM_DM_TU_DIEN v_us_td = new BCTKUS.US_CM_DM_TU_DIEN();
            BCTKDS.DS_CM_DM_TU_DIEN v_ds_td = new BCTKDS.DS_CM_DM_TU_DIEN();
            US_V_TONG_TIEN_BILL_THEO_PHONG_BAN v_us_tong_hop = new US_V_TONG_TIEN_BILL_THEO_PHONG_BAN();
            DS_V_TONG_TIEN_BILL_THEO_PHONG_BAN v_ds_tong_hop = new DS_V_TONG_TIEN_BILL_THEO_PHONG_BAN();
            v_us_td.FillDataset(v_ds_td, "where ID =" + v_id_phap_nhan);
            m_lbl_ten_phap_nhan.Text = v_ds_td.Tables[0].Rows[0][4].ToString();
            m_lbl_tu_ngay.Text = v_dt_tu_ngay.Date.ToShortDateString();
            m_lbl_den_ngay.Text = v_dt_den_ngay.Date.ToShortDateString();
            m_lbl_tong_bill.Text = CIPConvert.ToStr(v_tong_bill, "#,###");
            m_lbl_tong_chi_phi.Text = CIPConvert.ToStr(v_tong_chi_phi, "#,###") + "   (VNĐ)";
            v_us_tong_hop.FillDataset_chi_phi_theo_phong_ban(v_ds_tong_hop, v_id_phap_nhan, v_id_trang_thai, v_dt_tu_ngay, v_dt_den_ngay);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(v_ds_tong_hop, m_fg, m_obj_trans);
            CGridUtils.MakeSoTT(0, m_fg);
            m_fg.Redraw = true;
            this.ShowDialog();
        }

		#endregion

		#region Data Structure
		private enum e_col_Number{
			TEN_PHONG_BAN = 3
,ID_PHONG_BAN = 1
,TONG_SO_BILL = 4
,MA_PHONG_BAN = 2
,TONG_SO_TIEN = 5
,VAT = 6
,TONG_TIEN_THANH_TOAN = 7

		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_V_TONG_TIEN_BILL_THEO_PHONG_BAN m_ds = new DS_V_TONG_TIEN_BILL_THEO_PHONG_BAN();
		US_V_TONG_TIEN_BILL_THEO_PHONG_BAN m_us = new US_V_TONG_TIEN_BILL_THEO_PHONG_BAN();
        DateTime m_dt_tu_ngay, m_dt_den_ngay;
        decimal m_id_trang_thai;
        bool m_trang_thai = false;
		#endregion

		#region Private Methods
		private void format_controls(){
            //CControlFormat.setFormStyle(this, new CAppContext_201());
			CControlFormat.setC1FlexFormat(m_fg);
			CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            m_fg.Cols[0].Caption = "STT";
			set_define_events();
			this.KeyPreview = true;
            load_cbo_trang_thai();
           
		}

        private void load_txt_cbo_trang_thai()
        {
            BCTKUS.US_CM_DM_TU_DIEN v_us = new BCTKUS.US_CM_DM_TU_DIEN();
            BCTKDS.DS_CM_DM_TU_DIEN v_ds = new BCTKDS.DS_CM_DM_TU_DIEN();
            if (m_id_trang_thai != -1)
            {
                v_us.FillDataset(v_ds, "where id = " + m_id_trang_thai);
                m_cbo_trang_thai.Text = v_ds.Tables[0].Rows[0][4].ToString();
            }
            else
            {
                m_cbo_trang_thai.Text = "Tất cả";
            }
        }
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_fg);
			load_data_2_grid();		
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(V_TONG_TIEN_BILL_THEO_PHONG_BAN.TEN_PHONG_BAN, e_col_Number.TEN_PHONG_BAN);
			v_htb.Add(V_TONG_TIEN_BILL_THEO_PHONG_BAN.ID_PHONG_BAN, e_col_Number.ID_PHONG_BAN);
			v_htb.Add(V_TONG_TIEN_BILL_THEO_PHONG_BAN.TONG_SO_BILL, e_col_Number.TONG_SO_BILL);
			v_htb.Add(V_TONG_TIEN_BILL_THEO_PHONG_BAN.MA_PHONG_BAN, e_col_Number.MA_PHONG_BAN);
			v_htb.Add(V_TONG_TIEN_BILL_THEO_PHONG_BAN.TONG_SO_TIEN, e_col_Number.TONG_SO_TIEN);
            v_htb.Add(V_TONG_TIEN_BILL_THEO_PHONG_BAN.VAT, e_col_Number.VAT);
            v_htb.Add(V_TONG_TIEN_BILL_THEO_PHONG_BAN.TONG_TIEN_THANH_TOAN, e_col_Number.TONG_TIEN_THANH_TOAN);			
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.V_TONG_TIEN_BILL_THEO_PHONG_BAN.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){						
			m_ds = new DS_V_TONG_TIEN_BILL_THEO_PHONG_BAN();			
			m_us.FillDataset(m_ds);
			m_fg.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            CGridUtils.MakeSoTT(0, m_fg);
			m_fg.Redraw = true;
		}
		private void grid2us_object(US_V_TONG_TIEN_BILL_THEO_PHONG_BAN i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

	
		private void us_object2grid(US_V_TONG_TIEN_BILL_THEO_PHONG_BAN i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}

        private void export_2_excel()
        {
            CExcelReport v_obj_excel_report = new CExcelReport("f411_bc_chi_phi_theo_phong_ban_va_phap_nhan.xlsx", 5, 1);
            v_obj_excel_report.AddFindAndReplaceItem("<tu_ngay>", m_lbl_tu_ngay.Text);
            v_obj_excel_report.AddFindAndReplaceItem("<den_ngay>", m_lbl_den_ngay.Text);
            v_obj_excel_report.AddFindAndReplaceItem("<trang_thai>", m_cbo_trang_thai.Text);
            v_obj_excel_report.AddFindAndReplaceItem("<phap_nhan>", m_lbl_ten_phap_nhan.Text);
            v_obj_excel_report.AddFindAndReplaceItem("<tong_bill>", m_lbl_tong_bill.Text);
            v_obj_excel_report.AddFindAndReplaceItem("<tong_chi_phi>", m_lbl_tong_chi_phi.Text);
            v_obj_excel_report.FindAndReplace(false);
            v_obj_excel_report.Export2ExcelWithoutFixedRows(m_fg, 0, m_fg.Cols.Count - 1, true);
        }
        private void load_cbo_trang_thai()
        {
            m_trang_thai = false;
            BCTKUS.US_CM_DM_TU_DIEN v_us = new BCTKUS.US_CM_DM_TU_DIEN();
            BCTKDS.DS_CM_DM_TU_DIEN v_ds = new BCTKDS.DS_CM_DM_TU_DIEN();
            v_us.FillDataset(v_ds, "where id_loai_tu_dien = " + 12);
            m_cbo_trang_thai.DataSource = v_ds.CM_DM_TU_DIEN;
            m_cbo_trang_thai.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_trang_thai.DisplayMember = CM_DM_TU_DIEN.TEN;
            DataRow v_dr = v_ds.CM_DM_TU_DIEN.NewRow();
            v_dr[CM_DM_TU_DIEN.ID] = -1;
            v_dr[CM_DM_TU_DIEN.ID_LOAI_TU_DIEN] = 12;
            v_dr[CM_DM_TU_DIEN.TEN] = "Tất cả";
            v_dr[CM_DM_TU_DIEN.TEN_NGAN] = "Tất cả";
            v_dr[CM_DM_TU_DIEN.MA_TU_DIEN] = "TRANG_THAI_THU";
            v_dr[CM_DM_TU_DIEN.GHI_CHU] = " ";
            v_ds.CM_DM_TU_DIEN.Rows.InsertAt(v_dr, 0);
            m_trang_thai = true;
        }
        private void tim_kiem()
        {
            string v_id_tu_khoa = m_txt_tim_kiem.Text;
            decimal v_id_trang_thai = CIPConvert.ToDecimal(m_cbo_trang_thai.SelectedValue);
            DateTime v_dt_tu_ngay = m_dt_tu_ngay;
            DateTime v_dt_den_ngay = m_dt_den_ngay;
            US_V_TONG_TIEN_BILL_THEO_PHONG_BAN v_us = new US_V_TONG_TIEN_BILL_THEO_PHONG_BAN();
            DS_V_TONG_TIEN_BILL_THEO_PHONG_BAN v_ds = new DS_V_TONG_TIEN_BILL_THEO_PHONG_BAN();
            v_us.FillDatasetSearch(v_ds, v_dt_tu_ngay, v_dt_den_ngay, v_id_trang_thai, v_id_tu_khoa);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(v_ds, m_fg, m_obj_trans);
            CGridUtils.MakeSoTT(0, m_fg);
            m_fg.Redraw = true;
        }
		private void insert_v_tong_hop_bill_theo_phong_ban(){			
		//	f411_V_TONG_HOP_CHI_PHI_THEO_PHONG_BAN_VA_PHAP_NHAN_DE v_fDE = new  f411_V_TONG_HOP_CHI_PHI_THEO_PHONG_BAN_VA_PHAP_NHAN_DE();								
		//	v_fDE.display();
			load_data_2_grid();
		}

		private void update_v_tong_hop_bill_theo_phong_ban(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;			
			grid2us_object(m_us, m_fg.Row);
		//	f411_V_TONG_HOP_CHI_PHI_THEO_PHONG_BAN_VA_PHAP_NHAN_DE v_fDE = new f411_V_TONG_HOP_CHI_PHI_THEO_PHONG_BAN_VA_PHAP_NHAN_DE();
		//	v_fDE.display(m_us);
			load_data_2_grid();
		}
				
		private void delete_v_tong_hop_bill_theo_phong_ban(){
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted)  return;
			US_V_TONG_TIEN_BILL_THEO_PHONG_BAN v_us = new US_V_TONG_TIEN_BILL_THEO_PHONG_BAN();
			grid2us_object(v_us, m_fg.Row);
			try {			
				v_us.BeginTransaction();    											
				v_us.Delete();                      								
				v_us.CommitTransaction();
				m_fg.Rows.Remove(m_fg.Row);				
			}
			catch (Exception v_e) {
				v_us.Rollback();
				CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
					new CDBClientDBExceptionInterpret());
				v_objErrHandler.showErrorMessage();
			}
		}

		private void view_v_tong_hop_bill_theo_phong_ban(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			grid2us_object(m_us, m_fg.Row);
		//	f411_V_TONG_HOP_CHI_PHI_THEO_PHONG_BAN_VA_PHAP_NHAN_DE v_fDE = new f411_V_TONG_HOP_CHI_PHI_THEO_PHONG_BAN_VA_PHAP_NHAN_DE();			
		//	v_fDE.display(m_us);
		}
		private void set_define_events(){
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
			m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
			m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
			m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            m_cmd_xuat_excel.Click += new System.EventHandler(this.m_cmd_xuat_excel_Click);
		}
		#endregion

        #region Event
        private void f411_V_TONG_HOP_CHI_PHI_THEO_PHONG_BAN_VA_PHAP_NHAN_Load(object sender, System.EventArgs e) {
			try{
				set_initial_form_load();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		
		}

		private void m_cmd_exit_Click(object sender, EventArgs e) {
			try{
				this.Close();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_insert_Click(object sender, EventArgs e) {
			try{
				insert_v_tong_hop_bill_theo_phong_ban();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_update_Click(object sender, EventArgs e) {
			try{
				update_v_tong_hop_bill_theo_phong_ban();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_delete_Click(object sender, EventArgs e) {
			try{
				delete_v_tong_hop_bill_theo_phong_ban();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_view_Click(object sender, EventArgs e) {
			try{
				view_v_tong_hop_bill_theo_phong_ban();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

        private void m_cbo_trang_thai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_trang_thai == true)
            {
                tim_kiem();
            }
        }

        private void m_dt_tu_ngay_ValueChanged(object sender, EventArgs e)
        {
            tim_kiem();
        }

        private void m_dt_den_ngay_ValueChanged(object sender, EventArgs e)
        {
            tim_kiem();
        }

        private void m_cmd_tim_kiem_Click(object sender, EventArgs e)
        {
            tim_kiem();
        }

        private void m_txt_tim_kiem_TextChanged(object sender, EventArgs e)
        {
            tim_kiem();
        }

        private void m_fg_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                decimal v_id_phong_ban;
                decimal v_tong_bill;
                decimal v_tong_tien;
                decimal v_id_trang_thai = CIPConvert.ToDecimal(m_cbo_trang_thai.SelectedValue);
                DateTime v_dt_tu_ngay = m_dt_tu_ngay;
                DateTime v_dt_den_ngay = m_dt_den_ngay;
                int i_grid_row = m_fg.Selection.TopRow;
                DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
                v_id_phong_ban = CIPConvert.ToDecimal(v_dr[0]);
                if (v_dr[3].ToString() != "")
                    v_tong_bill = CIPConvert.ToDecimal(v_dr[3]);
                else
                    v_tong_bill = 0;
                if (v_dr[4].ToString() != "")
                    v_tong_tien = CIPConvert.ToDecimal(v_dr[4]);
                else
                    v_tong_tien = 0;
                f407_V_TONG_HOP_BILL_THEO_PHONG_BAN_DE frm = new f407_V_TONG_HOP_BILL_THEO_PHONG_BAN_DE();
                frm.Display_for_chi_tiet(v_id_phong_ban, v_id_trang_thai, v_dt_tu_ngay, v_dt_den_ngay, v_tong_bill, v_tong_tien);
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                export_2_excel();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
#endregion

     

    }
}

