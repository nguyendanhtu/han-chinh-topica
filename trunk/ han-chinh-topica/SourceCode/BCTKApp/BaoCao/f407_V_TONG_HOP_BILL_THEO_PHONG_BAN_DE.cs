///************************************************
/// Generated by: HuyTD
/// Date: 29/06/2014 11:10:32
/// Goal: Create Form for V_TONG_HOP_CPN_THEO_PHONG_BAN
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
using BCTKApp.BaoCao;
using IP.Core.IPExcelReport;

namespace BCTKApp
{



	public class f407_V_TONG_HOP_BILL_THEO_PHONG_BAN_DE : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
		private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
		internal SIS.Controls.Button.SiSButton m_cmd_delete;
		internal SIS.Controls.Button.SiSButton m_cmd_update;
		internal SIS.Controls.Button.SiSButton m_cmd_insert;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private Label m_lbl_ten_phong_ban;
        private Label label1;
        private Label label2;
        private Label m_lbl_tu_ngay;
        private Label m_lbl_den_ngay;
        private Label m_lbl_tong_bill;
        private Label m_lbl_tong_tien;
        private Label m_lbl_td_tong_bill;
        private Label m_lbl_td_tong_tien;
        internal SIS.Controls.Button.SiSButton m_cmd_xuat_excel;
        private Label m_lbl_chua_tinh_vat;
        private Label label5;
		private System.ComponentModel.IContainer components;

		public f407_V_TONG_HOP_BILL_THEO_PHONG_BAN_DE()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f407_V_TONG_HOP_BILL_THEO_PHONG_BAN_DE));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_xuat_excel = new SIS.Controls.Button.SiSButton();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_lbl_ten_phong_ban = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_lbl_tu_ngay = new System.Windows.Forms.Label();
            this.m_lbl_den_ngay = new System.Windows.Forms.Label();
            this.m_lbl_tong_bill = new System.Windows.Forms.Label();
            this.m_lbl_tong_tien = new System.Windows.Forms.Label();
            this.m_lbl_td_tong_bill = new System.Windows.Forms.Label();
            this.m_lbl_td_tong_tien = new System.Windows.Forms.Label();
            this.m_lbl_chua_tinh_vat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 623);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(1068, 36);
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
            this.m_cmd_xuat_excel.TabIndex = 24;
            this.m_cmd_xuat_excel.Text = "Xuất &Excel";
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
            this.m_cmd_insert.Location = new System.Drawing.Point(712, 4);
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
            this.m_cmd_update.Location = new System.Drawing.Point(800, 4);
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
            this.m_cmd_delete.Location = new System.Drawing.Point(888, 4);
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
            this.m_cmd_exit.Location = new System.Drawing.Point(976, 4);
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
            this.m_fg.Location = new System.Drawing.Point(0, 119);
            this.m_fg.Name = "m_fg";
            this.m_fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.m_fg.Size = new System.Drawing.Size(1068, 504);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 20;
            this.m_fg.DoubleClick += new System.EventHandler(this.m_fg_DoubleClick);
            // 
            // m_lbl_ten_phong_ban
            // 
            this.m_lbl_ten_phong_ban.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_ten_phong_ban.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.m_lbl_ten_phong_ban.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_ten_phong_ban.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_ten_phong_ban.Name = "m_lbl_ten_phong_ban";
            this.m_lbl_ten_phong_ban.Size = new System.Drawing.Size(1068, 22);
            this.m_lbl_ten_phong_ban.TabIndex = 21;
            this.m_lbl_ten_phong_ban.Text = "CHI TIẾT BILL THEO TRUNG TÂM";
            this.m_lbl_ten_phong_ban.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(351, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Từ ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(545, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Đến ngày:";
            // 
            // m_lbl_tu_ngay
            // 
            this.m_lbl_tu_ngay.AutoSize = true;
            this.m_lbl_tu_ngay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_tu_ngay.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_tu_ngay.Location = new System.Drawing.Point(435, 36);
            this.m_lbl_tu_ngay.Name = "m_lbl_tu_ngay";
            this.m_lbl_tu_ngay.Size = new System.Drawing.Size(81, 19);
            this.m_lbl_tu_ngay.TabIndex = 25;
            this.m_lbl_tu_ngay.Text = "01/01/2001";
            // 
            // m_lbl_den_ngay
            // 
            this.m_lbl_den_ngay.AutoSize = true;
            this.m_lbl_den_ngay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_den_ngay.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_den_ngay.Location = new System.Drawing.Point(641, 36);
            this.m_lbl_den_ngay.Name = "m_lbl_den_ngay";
            this.m_lbl_den_ngay.Size = new System.Drawing.Size(81, 19);
            this.m_lbl_den_ngay.TabIndex = 25;
            this.m_lbl_den_ngay.Text = "29/06/2014";
            // 
            // m_lbl_tong_bill
            // 
            this.m_lbl_tong_bill.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_tong_bill.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_tong_bill.Location = new System.Drawing.Point(167, 89);
            this.m_lbl_tong_bill.Name = "m_lbl_tong_bill";
            this.m_lbl_tong_bill.Size = new System.Drawing.Size(80, 15);
            this.m_lbl_tong_bill.TabIndex = 25;
            this.m_lbl_tong_bill.Text = "...";
            this.m_lbl_tong_bill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // m_lbl_tong_tien
            // 
            this.m_lbl_tong_tien.AutoSize = true;
            this.m_lbl_tong_tien.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_tong_tien.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_tong_tien.Location = new System.Drawing.Point(741, 91);
            this.m_lbl_tong_tien.Name = "m_lbl_tong_tien";
            this.m_lbl_tong_tien.Size = new System.Drawing.Size(16, 13);
            this.m_lbl_tong_tien.TabIndex = 25;
            this.m_lbl_tong_tien.Text = "...";
            // 
            // m_lbl_td_tong_bill
            // 
            this.m_lbl_td_tong_bill.AutoSize = true;
            this.m_lbl_td_tong_bill.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_td_tong_bill.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_td_tong_bill.Location = new System.Drawing.Point(102, 90);
            this.m_lbl_td_tong_bill.Name = "m_lbl_td_tong_bill";
            this.m_lbl_td_tong_bill.Size = new System.Drawing.Size(59, 13);
            this.m_lbl_td_tong_bill.TabIndex = 25;
            this.m_lbl_td_tong_bill.Text = "Tổng Bill:";
            // 
            // m_lbl_td_tong_tien
            // 
            this.m_lbl_td_tong_tien.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_td_tong_tien.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_td_tong_tien.Location = new System.Drawing.Point(572, 90);
            this.m_lbl_td_tong_tien.Name = "m_lbl_td_tong_tien";
            this.m_lbl_td_tong_tien.Size = new System.Drawing.Size(150, 13);
            this.m_lbl_td_tong_tien.TabIndex = 25;
            this.m_lbl_td_tong_tien.Text = "Tổng tiền ( đã tính VAT):";
            // 
            // m_lbl_chua_tinh_vat
            // 
            this.m_lbl_chua_tinh_vat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_chua_tinh_vat.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_chua_tinh_vat.Location = new System.Drawing.Point(425, 90);
            this.m_lbl_chua_tinh_vat.Name = "m_lbl_chua_tinh_vat";
            this.m_lbl_chua_tinh_vat.Size = new System.Drawing.Size(91, 13);
            this.m_lbl_chua_tinh_vat.TabIndex = 26;
            this.m_lbl_chua_tinh_vat.Text = "...";
            this.m_lbl_chua_tinh_vat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(279, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 14);
            this.label5.TabIndex = 27;
            this.label5.Text = "Tổng tiền( chưa tính VAT):";
            // 
            // f407_V_TONG_HOP_BILL_THEO_PHONG_BAN_DE
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(1068, 659);
            this.Controls.Add(this.m_lbl_chua_tinh_vat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.m_lbl_den_ngay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_lbl_tu_ngay);
            this.Controls.Add(this.m_lbl_tong_tien);
            this.Controls.Add(this.m_lbl_td_tong_tien);
            this.Controls.Add(this.m_lbl_td_tong_bill);
            this.Controls.Add(this.m_lbl_tong_bill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_lbl_ten_phong_ban);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "f407_V_TONG_HOP_BILL_THEO_PHONG_BAN_DE";
            this.Text = "F407 - Chi tiết Bill của phòng ban";
            this.Load += new System.EventHandler(this.f407_V_TONG_HOP_BILL_THEO_PHONG_BAN_DE_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f407_V_TONG_HOP_BILL_THEO_PHONG_BAN_DE_KeyDown);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		#region Public Interface
        public void Display_for_chi_tiet(decimal ip_v_id_phong_ban, decimal ip_v_id_trang_thai, DateTime ip_v_dt_tu_ngay, DateTime ip_v_dt_den_ngay, decimal ip_v_tong_bill, decimal ip_v_tong_tien)
        {
            m_obj_trans = get_trans_object(m_fg);
            format_controls();
            US_DM_PHONG_BAN v_us_dm_pb = new US_DM_PHONG_BAN();
            DS_DM_PHONG_BAN v_ds_dm_pb = new DS_DM_PHONG_BAN();
            US_V_TONG_HOP_CPN_THEO_PHONG_BAN v_us_tong_hop_CPN = new US_V_TONG_HOP_CPN_THEO_PHONG_BAN();
            DS_V_TONG_HOP_CPN_THEO_PHONG_BAN v_ds_tong_hop_CPN = new DS_V_TONG_HOP_CPN_THEO_PHONG_BAN();
            v_us_dm_pb.FillDataset(v_ds_dm_pb, "where ID =" + ip_v_id_phong_ban);
            m_lbl_ten_phong_ban.Text = "CHI TIẾT CÁC BILL CỦA " + v_ds_dm_pb.Tables[0].Rows[0][2].ToString().ToUpper();
            m_lbl_tu_ngay.Text = ip_v_dt_tu_ngay.Date.ToShortDateString();
            m_lbl_den_ngay.Text = ip_v_dt_den_ngay.Date.ToShortDateString();
            m_lbl_tong_bill.Text = CIPConvert.ToStr(ip_v_tong_bill, "#,###");
            m_lbl_tong_tien.Text = CIPConvert.ToStr(ip_v_tong_tien, "#,###") + "   (VNĐ)";
            v_us_tong_hop_CPN.FillDataset_chi_tiet_Bill(v_ds_tong_hop_CPN, ip_v_id_phong_ban, ip_v_id_trang_thai, ip_v_dt_tu_ngay, ip_v_dt_den_ngay);
            m_fg.Redraw = true;
            CGridUtils.Dataset2C1Grid(v_ds_tong_hop_CPN, m_fg, m_obj_trans);
            CGridUtils.MakeSoTT(0, m_fg);
            decimal v_dc_tong_doanh_thu = 0;
            //m_v_us.get_tong_doanh_thu(v_dc_tong_doanh_thu);
            for (int i = 1; i <= v_ds_tong_hop_CPN.V_TONG_HOP_CPN_THEO_PHONG_BAN.Count; i++)
            {
                if (m_fg[i, (int)e_col_Number.SO_TIEN] == null) { }
                else
                     v_dc_tong_doanh_thu += CIPConvert.ToDecimal((m_fg[i, (int)e_col_Number.SO_TIEN]));
            }
            if (v_dc_tong_doanh_thu == 0) m_lbl_chua_tinh_vat.Text = "0 VNĐ";
            else m_lbl_chua_tinh_vat.Text = CIPConvert.ToStr(v_dc_tong_doanh_thu, "#,###.##") + "   VNĐ";
            m_fg.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Count // chỗ này dùng hàm count tức là để đếm, có thể dùng các hàm khác thay thế
                       , 0
                       , -1// chỗ này là tên trường mà mình nhóm
                       , (int)e_col_Number.TRANG_THAI // chỗ này là tên trường mà mình Count
                       , "Tổng"
                       );
            m_fg.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum
                , 0
                , -1
                , (int)e_col_Number.SO_TIEN
                , "Tổng"
                );

            m_fg.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Count // chỗ này dùng hàm count tức là để đếm, có thể dùng các hàm khác thay thế
             , 1
             , (int)e_col_Number.NGAY_GUI // chỗ này là tên trường mà mình nhóm
             , (int)e_col_Number.TRANG_THAI // chỗ này là tên trường mà mình Count
             , "{0}"
             );
            m_fg.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum
                , 1
                , (int)e_col_Number.NGAY_GUI
                , (int)e_col_Number.SO_TIEN
                , "{0}"
                );
            m_fg.Redraw = true;
            m_fg.Tree.Show(1);
            this.ShowDialog();
        }
		#endregion

		#region Data Structure
		private enum e_col_Number{
			NUOC_NGOAI = 12
,TEN_PHONG_BAN = 2
,SO_BILL = 4
,GHI_CHU = 13
,NOI_NHAN = 9
,NGUOI_NHAN = 8
,SO_TIEN = 5
,TRONG_NUOC = 11
,NOI_DUNG = 10
,NGUOI_GUI = 7
,TRANG_THAI = 6
,ID_PHONG_BAN = 1
,NGAY_GUI = 3
,ID = 13

		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_V_TONG_HOP_CPN_THEO_PHONG_BAN m_ds = new DS_V_TONG_HOP_CPN_THEO_PHONG_BAN();
		US_V_TONG_HOP_CPN_THEO_PHONG_BAN m_us = new US_V_TONG_HOP_CPN_THEO_PHONG_BAN();
        bool m_trang_thai = false;
		#endregion

		#region Private Methods
		private void format_controls(){
            CControlFormat.setFormStyle(this, new CAppContext_201());
            this.MinimizeBox = true;
            this.m_lbl_ten_phong_ban.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_den_ngay.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_tu_ngay.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.m_lbl_ten_phong_ban.Text = "CHI TIẾT CÁC BILL CỦA PHÒNG BAN";
            CControlFormat.setC1FlexFormat(m_fg);
			CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            //m_fg.Tree.Column = (int)e_col_Number.TEN_THUOC;
            m_fg.Tree.Column = (int)e_col_Number.NGAY_GUI;
            m_fg.Tree.Column = (int)e_col_Number.SO_BILL;
            m_fg.Cols[(int)e_col_Number.TEN_PHONG_BAN].Visible = false;
            m_fg.Cols[(int)e_col_Number.NGAY_GUI].Visible = false;
            m_fg.Cols[0].Caption = "STT";
            m_fg.Tree.Style = C1.Win.C1FlexGrid.TreeStyleFlags.ButtonBar;
            m_fg.AutoResize = false;
			set_define_events();
			this.KeyPreview = true;
		}
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_fg);
            //load_data_2_grid();		
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(V_TONG_HOP_CPN_THEO_PHONG_BAN.NUOC_NGOAI, e_col_Number.NUOC_NGOAI);
			v_htb.Add(V_TONG_HOP_CPN_THEO_PHONG_BAN.TEN_PHONG_BAN, e_col_Number.TEN_PHONG_BAN);
			v_htb.Add(V_TONG_HOP_CPN_THEO_PHONG_BAN.SO_BILL, e_col_Number.SO_BILL);
			v_htb.Add(V_TONG_HOP_CPN_THEO_PHONG_BAN.GHI_CHU, e_col_Number.GHI_CHU);
			v_htb.Add(V_TONG_HOP_CPN_THEO_PHONG_BAN.NOI_NHAN, e_col_Number.NOI_NHAN);
			v_htb.Add(V_TONG_HOP_CPN_THEO_PHONG_BAN.NGUOI_NHAN, e_col_Number.NGUOI_NHAN);
			v_htb.Add(V_TONG_HOP_CPN_THEO_PHONG_BAN.SO_TIEN, e_col_Number.SO_TIEN);
			v_htb.Add(V_TONG_HOP_CPN_THEO_PHONG_BAN.TRONG_NUOC, e_col_Number.TRONG_NUOC);
			v_htb.Add(V_TONG_HOP_CPN_THEO_PHONG_BAN.NOI_DUNG, e_col_Number.NOI_DUNG);
			v_htb.Add(V_TONG_HOP_CPN_THEO_PHONG_BAN.NGUOI_GUI, e_col_Number.NGUOI_GUI);
			v_htb.Add(V_TONG_HOP_CPN_THEO_PHONG_BAN.TRANG_THAI, e_col_Number.TRANG_THAI);
			v_htb.Add(V_TONG_HOP_CPN_THEO_PHONG_BAN.ID_PHONG_BAN, e_col_Number.ID_PHONG_BAN);
			v_htb.Add(V_TONG_HOP_CPN_THEO_PHONG_BAN.NGAY_GUI, e_col_Number.NGAY_GUI);
            v_htb.Add(V_TONG_HOP_CPN_THEO_PHONG_BAN.ID, e_col_Number.ID);
									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.V_TONG_HOP_CPN_THEO_PHONG_BAN.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){						
			m_ds = new DS_V_TONG_HOP_CPN_THEO_PHONG_BAN();			
			m_us.FillDataset(m_ds);
			m_fg.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            m_fg.Tree.Show(0);
			m_fg.Redraw = true;
		}
		private void grid2us_object(US_V_TONG_HOP_CPN_THEO_PHONG_BAN i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

	
		private void us_object2grid(US_V_TONG_HOP_CPN_THEO_PHONG_BAN i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}

        private void export_2_excel()
        {
            CExcelReport v_obj_excel_report = new CExcelReport("f407_bc_chi_tiet_bill_cua_phong_ban.xlsx", 6, 1);
            v_obj_excel_report.AddFindAndReplaceItem("<tu_ngay>", m_lbl_tu_ngay.Text);
            v_obj_excel_report.AddFindAndReplaceItem("<den_ngay>", m_lbl_den_ngay.Text);
            v_obj_excel_report.AddFindAndReplaceItem("<phong_ban>", m_lbl_ten_phong_ban.Text);
            v_obj_excel_report.AddFindAndReplaceItem("<tong_bill>", m_lbl_tong_bill.Text);
            v_obj_excel_report.AddFindAndReplaceItem("<tong_tien>", m_lbl_tong_tien.Text);
            v_obj_excel_report.FindAndReplace(false);
            v_obj_excel_report.Export2ExcelWithoutFixedRows(m_fg, 0, m_fg.Cols.Count - 1, true);
        }
		private void insert_v_tong_hop_cpn_theo_phong_ban(){			
		//	f407_V_TONG_HOP_BILL_THEO_PHONG_BAN_DE_DE v_fDE = new  f407_V_TONG_HOP_BILL_THEO_PHONG_BAN_DE_DE();								
		//	v_fDE.display();
			load_data_2_grid();
		}

		private void update_v_tong_hop_cpn_theo_phong_ban(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;			
			grid2us_object(m_us, m_fg.Row);
		//	f407_V_TONG_HOP_BILL_THEO_PHONG_BAN_DE_DE v_fDE = new f407_V_TONG_HOP_BILL_THEO_PHONG_BAN_DE_DE();
		//	v_fDE.display(m_us);
			load_data_2_grid();
		}
				
		private void delete_v_tong_hop_cpn_theo_phong_ban(){
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted)  return;
			US_V_TONG_HOP_CPN_THEO_PHONG_BAN v_us = new US_V_TONG_HOP_CPN_THEO_PHONG_BAN();
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

		private void view_v_tong_hop_cpn_theo_phong_ban(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			grid2us_object(m_us, m_fg.Row);
		//	f407_V_TONG_HOP_BILL_THEO_PHONG_BAN_DE_DE v_fDE = new f407_V_TONG_HOP_BILL_THEO_PHONG_BAN_DE_DE();			
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
        private void f407_V_TONG_HOP_BILL_THEO_PHONG_BAN_DE_Load(object sender, System.EventArgs e) {
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
				insert_v_tong_hop_cpn_theo_phong_ban();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_update_Click(object sender, EventArgs e) {
			try{
				update_v_tong_hop_cpn_theo_phong_ban();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_delete_Click(object sender, EventArgs e) {
			try{
				delete_v_tong_hop_cpn_theo_phong_ban();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_view_Click(object sender, EventArgs e) {
			try{
				view_v_tong_hop_cpn_theo_phong_ban();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

        private void Load_data()
        { }
        private void m_fg_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if(m_fg.Rows[m_fg.Row].IsNode) {
                    return;
                }
                decimal v_id;
                int i_grid_row = m_fg.Selection.TopRow;
                DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
                v_id = CIPConvert.ToDecimal(v_dr[0]);
                f404_CHI_TIET_BILL frm = new f404_CHI_TIET_BILL();
                frm.Display_for_chi_tiet(v_id);
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

        private void f407_V_TONG_HOP_BILL_THEO_PHONG_BAN_DE_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Escape)
                {
                    this.Close();
                }
                if (e.KeyData == Keys.E)
                {
                    export_2_excel();
                }
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

       
       
    }
}

