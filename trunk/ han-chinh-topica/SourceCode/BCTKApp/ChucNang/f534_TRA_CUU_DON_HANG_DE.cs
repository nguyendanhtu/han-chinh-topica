///************************************************
/// Generated by: DungNT
/// Date: 12/08/2014 04:46:07
/// Goal: Create Form for V_GD_DON_DAT_HANG_DETAIL
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



	public class f534_TRA_CUU_DON_HANG_DE : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
		private C1.Win.C1FlexGrid.C1FlexGrid m_grv_don_hang_de;
		internal SIS.Controls.Button.SiSButton m_cmd_delete;
		internal SIS.Controls.Button.SiSButton m_cmd_update;
		internal SIS.Controls.Button.SiSButton m_cmd_insert;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private Panel panel1;
        private Label m_lbl_tieu_de;
        private Label m_lbl_trung_tam;
        private Label m_lbl_ma_hd;
        private Label m_lbl_ma_hoa_don;
        private Label m_lbl_tong_tien;
        private Label m_lbl_tong;
        private Label m_lbl_ten_trung_tam;
        internal SIS.Controls.Button.SiSButton m_cmd_xuat_excel;
		private System.ComponentModel.IContainer components;

		public f534_TRA_CUU_DON_HANG_DE()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f534_TRA_CUU_DON_HANG_DE));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_grv_don_hang_de = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_lbl_ma_hd = new System.Windows.Forms.Label();
            this.m_lbl_ma_hoa_don = new System.Windows.Forms.Label();
            this.m_lbl_tong_tien = new System.Windows.Forms.Label();
            this.m_lbl_tong = new System.Windows.Forms.Label();
            this.m_lbl_ten_trung_tam = new System.Windows.Forms.Label();
            this.m_lbl_trung_tam = new System.Windows.Forms.Label();
            this.m_lbl_tieu_de = new System.Windows.Forms.Label();
            this.m_cmd_xuat_excel = new SIS.Controls.Button.SiSButton();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_don_hang_de)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 418);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(752, 36);
            this.m_pnl_out_place_dm.TabIndex = 19;
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
            this.m_cmd_insert.Location = new System.Drawing.Point(396, 4);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_insert.TabIndex = 12;
            this.m_cmd_insert.Text = "&Thêm";
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
            this.m_cmd_update.Location = new System.Drawing.Point(484, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_update.TabIndex = 13;
            this.m_cmd_update.Text = "&Sửa";
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
            this.m_cmd_delete.Location = new System.Drawing.Point(572, 4);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_delete.TabIndex = 14;
            this.m_cmd_delete.Text = "&Xoá";
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
            this.m_cmd_exit.Location = new System.Drawing.Point(660, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_grv_don_hang_de
            // 
            this.m_grv_don_hang_de.ColumnInfo = resources.GetString("m_grv_don_hang_de.ColumnInfo");
            this.m_grv_don_hang_de.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_grv_don_hang_de.Location = new System.Drawing.Point(0, 150);
            this.m_grv_don_hang_de.Name = "m_grv_don_hang_de";
            this.m_grv_don_hang_de.Size = new System.Drawing.Size(752, 268);
            this.m_grv_don_hang_de.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_grv_don_hang_de.Styles"));
            this.m_grv_don_hang_de.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_lbl_ma_hd);
            this.panel1.Controls.Add(this.m_lbl_ma_hoa_don);
            this.panel1.Controls.Add(this.m_lbl_tong_tien);
            this.panel1.Controls.Add(this.m_lbl_tong);
            this.panel1.Controls.Add(this.m_lbl_ten_trung_tam);
            this.panel1.Controls.Add(this.m_lbl_trung_tam);
            this.panel1.Controls.Add(this.m_lbl_tieu_de);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 144);
            this.panel1.TabIndex = 22;
            // 
            // m_lbl_ma_hd
            // 
            this.m_lbl_ma_hd.AutoSize = true;
            this.m_lbl_ma_hd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_ma_hd.Location = new System.Drawing.Point(384, 74);
            this.m_lbl_ma_hd.Name = "m_lbl_ma_hd";
            this.m_lbl_ma_hd.Size = new System.Drawing.Size(68, 16);
            this.m_lbl_ma_hd.TabIndex = 34;
            this.m_lbl_ma_hd.Text = "...............";
            // 
            // m_lbl_ma_hoa_don
            // 
            this.m_lbl_ma_hoa_don.AutoSize = true;
            this.m_lbl_ma_hoa_don.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_ma_hoa_don.Location = new System.Drawing.Point(281, 74);
            this.m_lbl_ma_hoa_don.Name = "m_lbl_ma_hoa_don";
            this.m_lbl_ma_hoa_don.Size = new System.Drawing.Size(88, 16);
            this.m_lbl_ma_hoa_don.TabIndex = 33;
            this.m_lbl_ma_hoa_don.Text = "Mã hóa đơn : ";
            // 
            // m_lbl_tong_tien
            // 
            this.m_lbl_tong_tien.AutoSize = true;
            this.m_lbl_tong_tien.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_tong_tien.Location = new System.Drawing.Point(159, 112);
            this.m_lbl_tong_tien.Name = "m_lbl_tong_tien";
            this.m_lbl_tong_tien.Size = new System.Drawing.Size(68, 16);
            this.m_lbl_tong_tien.TabIndex = 32;
            this.m_lbl_tong_tien.Text = "...............";
            // 
            // m_lbl_tong
            // 
            this.m_lbl_tong.AutoSize = true;
            this.m_lbl_tong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_tong.Location = new System.Drawing.Point(23, 112);
            this.m_lbl_tong.Name = "m_lbl_tong";
            this.m_lbl_tong.Size = new System.Drawing.Size(130, 16);
            this.m_lbl_tong.TabIndex = 31;
            this.m_lbl_tong.Text = "Tổng tiền (có VAT ) :";
            // 
            // m_lbl_ten_trung_tam
            // 
            this.m_lbl_ten_trung_tam.AutoSize = true;
            this.m_lbl_ten_trung_tam.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_ten_trung_tam.Location = new System.Drawing.Point(384, 44);
            this.m_lbl_ten_trung_tam.Name = "m_lbl_ten_trung_tam";
            this.m_lbl_ten_trung_tam.Size = new System.Drawing.Size(68, 16);
            this.m_lbl_ten_trung_tam.TabIndex = 30;
            this.m_lbl_ten_trung_tam.Text = "...............";
            // 
            // m_lbl_trung_tam
            // 
            this.m_lbl_trung_tam.AutoSize = true;
            this.m_lbl_trung_tam.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_trung_tam.Location = new System.Drawing.Point(280, 44);
            this.m_lbl_trung_tam.Name = "m_lbl_trung_tam";
            this.m_lbl_trung_tam.Size = new System.Drawing.Size(91, 16);
            this.m_lbl_trung_tam.TabIndex = 29;
            this.m_lbl_trung_tam.Text = "TRUNG TÂM : ";
            // 
            // m_lbl_tieu_de
            // 
            this.m_lbl_tieu_de.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_tieu_de.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_tieu_de.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_tieu_de.Name = "m_lbl_tieu_de";
            this.m_lbl_tieu_de.Size = new System.Drawing.Size(752, 32);
            this.m_lbl_tieu_de.TabIndex = 28;
            this.m_lbl_tieu_de.Text = "CHI TIẾT ĐƠN ĐẶT HÀNG";
            this.m_lbl_tieu_de.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(102, 28);
            this.m_cmd_xuat_excel.TabIndex = 15;
            this.m_cmd_xuat_excel.Text = "Xuất &Excel";
            // 
            // f534_TRA_CUU_DON_HANG_DE
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(752, 454);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_grv_don_hang_de);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f534_TRA_CUU_DON_HANG_DE";
            this.Text = "F534- Chi tiết đơn đặt hàng";
            this.Load += new System.EventHandler(this.f534_TRA_CUU_DON_HANG_DE_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_don_hang_de)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		#region Public Interface
		public void display(){			
			this.ShowDialog();
		}
        public void display_for_chi_tiet(US_V_GD_DON_DAT_HANG ip_us_v) 
        {
            m_obj_trans = get_trans_object(m_grv_don_hang_de);
            format_controls();
            m_id_hoa_don = ip_us_v.dcID;
            m_lbl_ten_trung_tam.Text = ip_us_v.strTEN_PHONG_BAN;
            m_lbl_ma_hd.Text = ip_us_v.strMA_HD;
            m_lbl_tong_tien.Text = CIPConvert.ToStr(ip_us_v.dcGIA_TRI_DA_VAT, "#,##0") + "   (VNĐ)";
            //US_V_GD_DON_DAT_HANG_DETAIL v_us = new US_V_GD_DON_DAT_HANG_DETAIL();
            //DS_V_GD_DON_DAT_HANG_DETAIL v_ds = new DS_V_GD_DON_DAT_HANG_DETAIL();
            //m_ds.Clear();
            //v_us.FillDatasetSearch_hdchitiet(m_ds,v_dc_id_hoa_don);
            //m_grv_don_hang_de.Redraw = false;
            //CGridUtils.Dataset2C1Grid(m_ds, m_grv_don_hang_de, m_obj_trans);
            //CGridUtils.MakeSoTT(0, m_grv_don_hang_de);
            //m_grv_don_hang_de.Redraw = true;
            this.ShowDialog();
        }
		#endregion

		#region Data Structure
		private enum e_col_Number{
			TRANG_THAI_HANG = 5,DON_GIA_CHUA_VAT = 6,TEN_VPP = 2,DON_GIA_GOM_VAT = 7,SO_LUONG = 3,MA_VPP = 1,DON_VI_TINH = 4
		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_V_GD_DON_DAT_HANG_DETAIL m_ds = new DS_V_GD_DON_DAT_HANG_DETAIL();
		US_V_GD_DON_DAT_HANG_DETAIL m_us = new US_V_GD_DON_DAT_HANG_DETAIL();
        decimal m_id_hoa_don;
		#endregion

		#region Private Methods
		private void format_controls(){
			CControlFormat.setFormStyle(this, new CAppContext_201());
            m_lbl_tieu_de.Font = new System.Drawing.Font("Tahoma", 15, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            m_lbl_trung_tam.Font = new System.Drawing.Font("Tahoma", 13, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            m_lbl_ten_trung_tam.Font = new System.Drawing.Font("Tahoma", 13, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            m_lbl_ma_hd.Font = new System.Drawing.Font("Tahoma", 13, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            m_lbl_ma_hoa_don.Font = new System.Drawing.Font("Tahoma", 13, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			CControlFormat.setC1FlexFormat(m_grv_don_hang_de);
			CGridUtils.AddSave_Excel_Handlers(m_grv_don_hang_de);
            CGridUtils.AddSearch_Handlers(m_grv_don_hang_de);
            m_cmd_exit.Visible = true;
            m_cmd_exit.Enabled = true;
            m_cmd_xuat_excel.Visible = false;
            m_cmd_xuat_excel.Enabled = true;
            set_define_events();    
			this.KeyPreview = true;		
		}
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_grv_don_hang_de);
            load_data_2_grid();		
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(V_GD_DON_DAT_HANG_DETAIL.TRANG_THAI_HANG, e_col_Number.TRANG_THAI_HANG);			v_htb.Add(V_GD_DON_DAT_HANG_DETAIL.DON_GIA_CHUA_VAT, e_col_Number.DON_GIA_CHUA_VAT);			v_htb.Add(V_GD_DON_DAT_HANG_DETAIL.TEN_VPP, e_col_Number.TEN_VPP);			v_htb.Add(V_GD_DON_DAT_HANG_DETAIL.DON_GIA_GOM_VAT, e_col_Number.DON_GIA_GOM_VAT);			v_htb.Add(V_GD_DON_DAT_HANG_DETAIL.SO_LUONG, e_col_Number.SO_LUONG);			v_htb.Add(V_GD_DON_DAT_HANG_DETAIL.MA_VPP, e_col_Number.MA_VPP);			v_htb.Add(V_GD_DON_DAT_HANG_DETAIL.DON_VI_TINH, e_col_Number.DON_VI_TINH);									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.V_GD_DON_DAT_HANG_DETAIL.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){						
			m_ds = new DS_V_GD_DON_DAT_HANG_DETAIL();
            m_us.FillDatasetSearch_hdchitiet(m_ds, m_id_hoa_don);
			m_grv_don_hang_de.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_grv_don_hang_de, m_obj_trans);
            CGridUtils.MakeSoTT(0, m_grv_don_hang_de);
			m_grv_don_hang_de.Redraw = true;
		}
		private void grid2us_object(US_V_GD_DON_DAT_HANG_DETAIL i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_grv_don_hang_de.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

	
		private void us_object2grid(US_V_GD_DON_DAT_HANG_DETAIL i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_grv_don_hang_de.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}


		private void insert_v_gd_don_dat_hang_detail(){			
		//	f534_TRA_CUU_DON_HANG_DE_DE v_fDE = new  f534_TRA_CUU_DON_HANG_DE_DE();								
		//	v_fDE.display();
			load_data_2_grid();
		}

		private void update_v_gd_don_dat_hang_detail(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_don_hang_de)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_don_hang_de, m_grv_don_hang_de.Row)) return;			
			grid2us_object(m_us, m_grv_don_hang_de.Row);
		//	f534_TRA_CUU_DON_HANG_DE_DE v_fDE = new f534_TRA_CUU_DON_HANG_DE_DE();
		//	v_fDE.display(m_us);
			load_data_2_grid();
		}
				
		private void delete_v_gd_don_dat_hang_detail(){
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_don_hang_de)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_don_hang_de, m_grv_don_hang_de.Row)) return;
			if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted)  return;
			US_V_GD_DON_DAT_HANG_DETAIL v_us = new US_V_GD_DON_DAT_HANG_DETAIL();
			grid2us_object(v_us, m_grv_don_hang_de.Row);
			try {			
				v_us.BeginTransaction();    											
				v_us.Delete();                      								
				v_us.CommitTransaction();
				m_grv_don_hang_de.Rows.Remove(m_grv_don_hang_de.Row);				
			}
			catch (Exception v_e) {
				v_us.Rollback();
				CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
					new CDBClientDBExceptionInterpret());
				v_objErrHandler.showErrorMessage();
			}
		}

		private void view_v_gd_don_dat_hang_detail(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_don_hang_de)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_don_hang_de, m_grv_don_hang_de.Row)) return;
			grid2us_object(m_us, m_grv_don_hang_de.Row);
		//	f534_TRA_CUU_DON_HANG_DE_DE v_fDE = new f534_TRA_CUU_DON_HANG_DE_DE();			
		//	v_fDE.display(m_us);
		}
		private void set_define_events(){
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
			m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
			m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
			m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            //m_cmd_xuat_excel.Click += new EventHandler(m_cmd_xuat_excel_Click);
            this.KeyDown+=new KeyEventHandler(f534_TRA_CUU_DON_HANG_DE_KeyDown);
		}
		#endregion

//
		//
		//		EVENT HANLDERS
		//
		//
		private void f534_TRA_CUU_DON_HANG_DE_Load(object sender, System.EventArgs e) {
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
				insert_v_gd_don_dat_hang_detail();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_update_Click(object sender, EventArgs e) {
			try{
				update_v_gd_don_dat_hang_detail();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_delete_Click(object sender, EventArgs e) {
			try{
				delete_v_gd_don_dat_hang_detail();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

        private void m_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
			try
            {
                CExcelReport v_obj_excel_report = new CExcelReport("f534_tra_cuu_don_hang_de.xls", 7, 1);
                v_obj_excel_report.AddFindAndReplaceItem("<trung_tam>", m_lbl_ten_trung_tam.Text);
                v_obj_excel_report.AddFindAndReplaceItem("<hoa_don>", m_lbl_ma_hd.Text);
                v_obj_excel_report.FindAndReplace(false);
                v_obj_excel_report.Export2ExcelWithoutFixedRows(m_grv_don_hang_de, 0, m_grv_don_hang_de.Cols.Count-1, true);             
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}
        private void f534_TRA_CUU_DON_HANG_DE_KeyDown(object sender, KeyEventArgs e)
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
	}
}

