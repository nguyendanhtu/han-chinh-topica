///************************************************
/// Generated by: HuyTD
/// Date: 03/07/2014 03:45:21
/// Goal: Create Form for V_BC_CHI_PHI_THEO_CAC_PHAP_NHAN
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



	public class f410_BC_CHI_PHI_THEO_CAC_PHAP_NHAN : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
		private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
		internal SIS.Controls.Button.SiSButton m_cmd_delete;
		internal SIS.Controls.Button.SiSButton m_cmd_update;
		internal SIS.Controls.Button.SiSButton m_cmd_insert;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private Label m_lbl_header;
        private DateTimePicker m_dt_den_ngay;
        private DateTimePicker m_dt_tu_ngay;
        private Label m_lbl_den_ngay;
        private Label m_lbl_tu_ngay;
        private ComboBox m_cbo_trang_thai;
        private Label m_lbl_trang_thai;
        internal SIS.Controls.Button.SiSButton m_cmd_xuat_excel;
		private System.ComponentModel.IContainer components;

		public f410_BC_CHI_PHI_THEO_CAC_PHAP_NHAN()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f410_BC_CHI_PHI_THEO_CAC_PHAP_NHAN));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_xuat_excel = new SIS.Controls.Button.SiSButton();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.m_dt_den_ngay = new System.Windows.Forms.DateTimePicker();
            this.m_dt_tu_ngay = new System.Windows.Forms.DateTimePicker();
            this.m_lbl_den_ngay = new System.Windows.Forms.Label();
            this.m_lbl_tu_ngay = new System.Windows.Forms.Label();
            this.m_cbo_trang_thai = new System.Windows.Forms.ComboBox();
            this.m_lbl_trang_thai = new System.Windows.Forms.Label();
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
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 393);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(764, 36);
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
            this.m_cmd_xuat_excel.TabIndex = 25;
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
            this.m_cmd_insert.Location = new System.Drawing.Point(408, 4);
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
            this.m_cmd_update.Location = new System.Drawing.Point(496, 4);
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
            this.m_cmd_delete.Location = new System.Drawing.Point(584, 4);
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
            this.m_cmd_exit.Location = new System.Drawing.Point(672, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_fg.Location = new System.Drawing.Point(0, 97);
            this.m_fg.Name = "m_fg";
            this.m_fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.m_fg.Size = new System.Drawing.Size(764, 296);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 7;
            this.m_fg.DoubleClick += new System.EventHandler(this.m_fg_DoubleClick);
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.AutoSize = true;
            this.m_lbl_header.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(228, 9);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(304, 22);
            this.m_lbl_header.TabIndex = 0;
            this.m_lbl_header.Text = "CHI PHÍ THEO CÁC PHÁP NHÂN";
            // 
            // m_dt_den_ngay
            // 
            this.m_dt_den_ngay.Checked = false;
            this.m_dt_den_ngay.CustomFormat = "dd/MM/yyyy";
            this.m_dt_den_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dt_den_ngay.Location = new System.Drawing.Point(501, 49);
            this.m_dt_den_ngay.Name = "m_dt_den_ngay";
            this.m_dt_den_ngay.ShowCheckBox = true;
            this.m_dt_den_ngay.Size = new System.Drawing.Size(120, 20);
            this.m_dt_den_ngay.TabIndex = 4;
            this.m_dt_den_ngay.ValueChanged += new System.EventHandler(this.m_dt_den_ngay_ValueChanged);
            // 
            // m_dt_tu_ngay
            // 
            this.m_dt_tu_ngay.Checked = false;
            this.m_dt_tu_ngay.CustomFormat = "dd/MM/yyyy";
            this.m_dt_tu_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dt_tu_ngay.Location = new System.Drawing.Point(226, 49);
            this.m_dt_tu_ngay.Name = "m_dt_tu_ngay";
            this.m_dt_tu_ngay.ShowCheckBox = true;
            this.m_dt_tu_ngay.Size = new System.Drawing.Size(120, 20);
            this.m_dt_tu_ngay.TabIndex = 2;
            this.m_dt_tu_ngay.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.m_dt_tu_ngay.ValueChanged += new System.EventHandler(this.m_dt_tu_ngay_ValueChanged);
            // 
            // m_lbl_den_ngay
            // 
            this.m_lbl_den_ngay.AutoSize = true;
            this.m_lbl_den_ngay.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_den_ngay.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_den_ngay.Location = new System.Drawing.Point(420, 49);
            this.m_lbl_den_ngay.Name = "m_lbl_den_ngay";
            this.m_lbl_den_ngay.Size = new System.Drawing.Size(62, 15);
            this.m_lbl_den_ngay.TabIndex = 3;
            this.m_lbl_den_ngay.Text = "Đến ngày:";
            // 
            // m_lbl_tu_ngay
            // 
            this.m_lbl_tu_ngay.AutoSize = true;
            this.m_lbl_tu_ngay.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_tu_ngay.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_tu_ngay.Location = new System.Drawing.Point(146, 49);
            this.m_lbl_tu_ngay.Name = "m_lbl_tu_ngay";
            this.m_lbl_tu_ngay.Size = new System.Drawing.Size(55, 15);
            this.m_lbl_tu_ngay.TabIndex = 1;
            this.m_lbl_tu_ngay.Text = "Từ ngày:";
            // 
            // m_cbo_trang_thai
            // 
            this.m_cbo_trang_thai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.m_cbo_trang_thai.FormattingEnabled = true;
            this.m_cbo_trang_thai.Location = new System.Drawing.Point(682, 14);
            this.m_cbo_trang_thai.Name = "m_cbo_trang_thai";
            this.m_cbo_trang_thai.Size = new System.Drawing.Size(61, 21);
            this.m_cbo_trang_thai.TabIndex = 6;
            this.m_cbo_trang_thai.Visible = false;
            this.m_cbo_trang_thai.SelectedIndexChanged += new System.EventHandler(this.m_cbo_trang_thai_SelectedIndexChanged);
            // 
            // m_lbl_trang_thai
            // 
            this.m_lbl_trang_thai.AutoSize = true;
            this.m_lbl_trang_thai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_trang_thai.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_trang_thai.Location = new System.Drawing.Point(611, 14);
            this.m_lbl_trang_thai.Name = "m_lbl_trang_thai";
            this.m_lbl_trang_thai.Size = new System.Drawing.Size(65, 15);
            this.m_lbl_trang_thai.TabIndex = 5;
            this.m_lbl_trang_thai.Text = "Trạng thái:";
            this.m_lbl_trang_thai.Visible = false;
            // 
            // f410_BC_CHI_PHI_THEO_CAC_PHAP_NHAN
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(764, 429);
            this.Controls.Add(this.m_cbo_trang_thai);
            this.Controls.Add(this.m_lbl_trang_thai);
            this.Controls.Add(this.m_dt_den_ngay);
            this.Controls.Add(this.m_dt_tu_ngay);
            this.Controls.Add(this.m_lbl_den_ngay);
            this.Controls.Add(this.m_lbl_tu_ngay);
            this.Controls.Add(this.m_lbl_header);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f410_BC_CHI_PHI_THEO_CAC_PHAP_NHAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F410-Báo cáo chi phí theo các pháp nhân";
            this.Load += new System.EventHandler(this.f410_BC_CHI_PHI_THEO_CAC_PHAP_NHAN_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		#region Public Interface
		public void display(){			
			this.ShowDialog();
		}
		#endregion

		#region Data Structure
		private enum e_col_Number{
			TONG_SO_TIEN = 5
            ,TEN_NGAN = 2
            ,TONG_SO_BILL = 4
            ,ID_PHAP_NHAN = 1
            ,TEN = 3
            ,VAT = 6
            ,TONG_CHI_PHI = 7

		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_V_BC_CHI_PHI_THEO_CAC_PHAP_NHAN m_ds = new DS_V_BC_CHI_PHI_THEO_CAC_PHAP_NHAN();
		US_V_BC_CHI_PHI_THEO_CAC_PHAP_NHAN m_us = new US_V_BC_CHI_PHI_THEO_CAC_PHAP_NHAN();
        bool m_trang_thai = false;
		#endregion

		#region Private Methods
		private void format_controls(){
            CControlFormat.setFormStyle(this, new CAppContext_201());
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(764, 429);
            this.MinimizeBox = true;
            // m_lbl_header
            // 
            this.m_lbl_header.AutoSize = true;
            this.m_lbl_header.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(265, 9);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(304, 22);
            this.m_lbl_header.TabIndex = 0;
            this.m_lbl_header.Text = "CHI PHÍ THEO CÁC PHÁP NHÂN";
            // 
			CControlFormat.setC1FlexFormat(m_fg);
			CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            m_fg.Cols[0].Caption = "STT";
			set_define_events();
			this.KeyPreview = true;
            load_cbo_trang_thai();
		}
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_fg);
			load_data_2_grid();		
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(V_BC_CHI_PHI_THEO_CAC_PHAP_NHAN.TONG_CHI_PHI, e_col_Number.TONG_CHI_PHI);
			v_htb.Add(V_BC_CHI_PHI_THEO_CAC_PHAP_NHAN.TEN_NGAN, e_col_Number.TEN_NGAN);
			v_htb.Add(V_BC_CHI_PHI_THEO_CAC_PHAP_NHAN.TONG_SO_BILL, e_col_Number.TONG_SO_BILL);
			v_htb.Add(V_BC_CHI_PHI_THEO_CAC_PHAP_NHAN.ID_PHAP_NHAN, e_col_Number.ID_PHAP_NHAN);
			v_htb.Add(V_BC_CHI_PHI_THEO_CAC_PHAP_NHAN.TEN, e_col_Number.TEN);
            v_htb.Add(V_BC_CHI_PHI_THEO_CAC_PHAP_NHAN.TONG_SO_TIEN, e_col_Number.TONG_SO_TIEN);
            v_htb.Add(V_BC_CHI_PHI_THEO_CAC_PHAP_NHAN.VAT, e_col_Number.VAT);
									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.V_BC_CHI_PHI_THEO_CAC_PHAP_NHAN.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){						
			m_ds = new DS_V_BC_CHI_PHI_THEO_CAC_PHAP_NHAN();			
			m_us.FillDataset(m_ds);
			m_fg.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            CGridUtils.MakeSoTT(0, m_fg);
			m_fg.Redraw = true;
		}
		private void grid2us_object(US_V_BC_CHI_PHI_THEO_CAC_PHAP_NHAN i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

	
		private void us_object2grid(US_V_BC_CHI_PHI_THEO_CAC_PHAP_NHAN i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}

        private void export_2_excel()
        {
            CExcelReport v_obj_excel_report = new CExcelReport("f410_bc_chi_phi_theo_phap_nhan.xlsx", 5, 1);
            v_obj_excel_report.AddFindAndReplaceItem("<tu_ngay>", m_dt_tu_ngay.Text);
            v_obj_excel_report.AddFindAndReplaceItem("<den_ngay>", m_dt_den_ngay.Text);
            //v_obj_excel_report.AddFindAndReplaceItem("<trang_thai>", m_cbo_trang_thai.Text);
            v_obj_excel_report.FindAndReplace(false);
            v_obj_excel_report.Export2ExcelWithoutFixedRows(m_fg, 0, m_fg.Cols.Count - 1, true);
        }
		private void insert_v_bc_chi_phi_theo_cac_phap_nhan(){			
		//	f410_BC_CHI_PHI_THEO_CAC_PHAP_NHAN_DE v_fDE = new  f410_BC_CHI_PHI_THEO_CAC_PHAP_NHAN_DE();								
		//	v_fDE.display();
			load_data_2_grid();
		}

		private void update_v_bc_chi_phi_theo_cac_phap_nhan(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;			
			grid2us_object(m_us, m_fg.Row);
		//	f410_BC_CHI_PHI_THEO_CAC_PHAP_NHAN_DE v_fDE = new f410_BC_CHI_PHI_THEO_CAC_PHAP_NHAN_DE();
		//	v_fDE.display(m_us);
			load_data_2_grid();
		}
				
		private void delete_v_bc_chi_phi_theo_cac_phap_nhan(){
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted)  return;
			US_V_BC_CHI_PHI_THEO_CAC_PHAP_NHAN v_us = new US_V_BC_CHI_PHI_THEO_CAC_PHAP_NHAN();
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

		private void view_v_bc_chi_phi_theo_cac_phap_nhan(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			grid2us_object(m_us, m_fg.Row);
		//	f410_BC_CHI_PHI_THEO_CAC_PHAP_NHAN_DE v_fDE = new f410_BC_CHI_PHI_THEO_CAC_PHAP_NHAN_DE();			
		//	v_fDE.display(m_us);
		}
		private void set_define_events(){
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
			m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
			m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
			m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            m_cmd_xuat_excel.Click += new System.EventHandler(this.m_cmd_xuat_excel_Click);
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
            m_cbo_trang_thai.SelectedIndex = 0;
            m_trang_thai = true;
        }
        private void tim_kiem()
        {
            decimal v_id_trang_thai = CIPConvert.ToDecimal(m_cbo_trang_thai.SelectedValue);
            DateTime v_dt_tu_ngay;
            DateTime v_dt_den_ngay;
            if (!m_dt_tu_ngay.Checked)
            {
                v_dt_tu_ngay = new DateTime(1970, 1, 1);
            }
            else
            {
                v_dt_tu_ngay = m_dt_tu_ngay.Value;
            }
            if (!m_dt_den_ngay.Checked)
            {
                v_dt_den_ngay = new DateTime(2050, 1, 1);
            }
            else
            {
                v_dt_den_ngay = m_dt_den_ngay.Value;
            }
            US_V_BC_CHI_PHI_THEO_CAC_PHAP_NHAN v_us = new US_V_BC_CHI_PHI_THEO_CAC_PHAP_NHAN();
            DS_V_BC_CHI_PHI_THEO_CAC_PHAP_NHAN v_ds = new DS_V_BC_CHI_PHI_THEO_CAC_PHAP_NHAN();
            v_us.FillDatasetSearch(v_ds, v_dt_tu_ngay, v_dt_den_ngay, v_id_trang_thai);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(v_ds, m_fg, m_obj_trans);
            m_fg.Redraw = true;
        }
		#endregion

        #region Event
        private void f410_BC_CHI_PHI_THEO_CAC_PHAP_NHAN_Load(object sender, System.EventArgs e) {
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
				insert_v_bc_chi_phi_theo_cac_phap_nhan();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_update_Click(object sender, EventArgs e) {
			try{
				update_v_bc_chi_phi_theo_cac_phap_nhan();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_delete_Click(object sender, EventArgs e) {
			try{
				delete_v_bc_chi_phi_theo_cac_phap_nhan();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_view_Click(object sender, EventArgs e) {
			try{
				view_v_bc_chi_phi_theo_cac_phap_nhan();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

        private void m_cbo_trang_thai_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_trang_thai == true)
                {
                    tim_kiem();
                }
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_dt_tu_ngay_ValueChanged(object sender, EventArgs e)
        {
            {
                try
                {
                    if (m_trang_thai == true)
                    {
                        tim_kiem();
                    }
                }
                catch (Exception v_e)
                {

                    CSystemLog_301.ExceptionHandle(v_e);
                }
            }
        }

        private void m_dt_den_ngay_ValueChanged(object sender, EventArgs e)
        {
            {
                try
                {
                    if (m_trang_thai == true)
                    {
                        tim_kiem();
                    }
                }
                catch (Exception v_e)
                {

                    CSystemLog_301.ExceptionHandle(v_e);
                }
            }
        }

        private void m_fg_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                decimal v_id_phap_nhan;
                decimal v_id_trang_thai = CIPConvert.ToDecimal(m_cbo_trang_thai.SelectedValue);
                decimal v_tong_bill;
                decimal v_tong_chi_phi;
                DateTime v_dt_tu_ngay = m_dt_tu_ngay.Value;
                DateTime v_dt_den_ngay = m_dt_den_ngay.Value;
                int i_grid_row = m_fg.Selection.TopRow;
                DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
                v_id_phap_nhan = CIPConvert.ToDecimal(v_dr[0]);
                v_tong_bill = CIPConvert.ToDecimal(v_dr[3]);
                if (v_dr[6].ToString() == "")
                {
                    v_tong_chi_phi = CIPConvert.ToDecimal(0);  
                }
                else
                { v_tong_chi_phi = CIPConvert.ToDecimal(v_dr[6]); }
                f411_V_TONG_HOP_CHI_PHI_THEO_PHONG_BAN_VA_PHAP_NHAN frm = new f411_V_TONG_HOP_CHI_PHI_THEO_PHONG_BAN_VA_PHAP_NHAN();
                frm.Display_for_chi_tiet(v_id_phap_nhan, v_id_trang_thai, v_dt_tu_ngay, v_dt_den_ngay, v_tong_bill, v_tong_chi_phi);
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

