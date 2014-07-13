///************************************************
/// Generated by: DungNT
/// Date: 12/07/2014 11:05:37
/// Goal: Create Form for V_DM_BILL
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



	public class f512_BILL_BI_TRA_LAI : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
		private C1.Win.C1FlexGrid.C1FlexGrid m_grv_bill;
		internal SIS.Controls.Button.SiSButton m_cmd_delete;
		internal SIS.Controls.Button.SiSButton m_cmd_update;
		internal SIS.Controls.Button.SiSButton m_cmd_insert;
		internal SIS.Controls.Button.SiSButton m_cmd_exit;
		internal SIS.Controls.Button.SiSButton m_cmd_xuat_excel;
        private Panel m_pnl_top;
        private DateTimePicker m_dtp_den_ngay;
        private DateTimePicker m_dtp_tu_ngay;
        private Label label6;
        private Label label7;
        private Label m_lbl_tieu_de;
		private System.ComponentModel.IContainer components;

		public f512_BILL_BI_TRA_LAI()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f512_BILL_BI_TRA_LAI));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_xuat_excel = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_grv_bill = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_pnl_top = new System.Windows.Forms.Panel();
            this.m_dtp_den_ngay = new System.Windows.Forms.DateTimePicker();
            this.m_dtp_tu_ngay = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.m_lbl_tieu_de = new System.Windows.Forms.Label();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_bill)).BeginInit();
            this.m_pnl_top.SuspendLayout();
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
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_xuat_excel);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 526);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(884, 36);
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
            this.m_cmd_insert.Location = new System.Drawing.Point(528, 4);
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
            this.m_cmd_update.Location = new System.Drawing.Point(616, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_update.TabIndex = 13;
            this.m_cmd_update.Text = "&Sửa";
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
            this.m_cmd_xuat_excel.TabIndex = 21;
            this.m_cmd_xuat_excel.Text = "Xuất Excel";
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
            this.m_cmd_delete.Location = new System.Drawing.Point(704, 4);
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
            this.m_cmd_exit.Location = new System.Drawing.Point(792, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_grv_bill
            // 
            this.m_grv_bill.ColumnInfo = resources.GetString("m_grv_bill.ColumnInfo");
            this.m_grv_bill.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_grv_bill.Location = new System.Drawing.Point(0, 97);
            this.m_grv_bill.Name = "m_grv_bill";
            this.m_grv_bill.Size = new System.Drawing.Size(884, 429);
            this.m_grv_bill.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_grv_bill.Styles"));
            this.m_grv_bill.TabIndex = 20;
            // 
            // m_pnl_top
            // 
            this.m_pnl_top.Controls.Add(this.m_dtp_den_ngay);
            this.m_pnl_top.Controls.Add(this.m_dtp_tu_ngay);
            this.m_pnl_top.Controls.Add(this.label6);
            this.m_pnl_top.Controls.Add(this.label7);
            this.m_pnl_top.Controls.Add(this.m_lbl_tieu_de);
            this.m_pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_pnl_top.Location = new System.Drawing.Point(0, 0);
            this.m_pnl_top.Name = "m_pnl_top";
            this.m_pnl_top.Size = new System.Drawing.Size(884, 91);
            this.m_pnl_top.TabIndex = 22;
            // 
            // m_dtp_den_ngay
            // 
            this.m_dtp_den_ngay.Checked = false;
            this.m_dtp_den_ngay.CustomFormat = "dd/MM/yyyy";
            this.m_dtp_den_ngay.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_dtp_den_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dtp_den_ngay.Location = new System.Drawing.Point(582, 51);
            this.m_dtp_den_ngay.Name = "m_dtp_den_ngay";
            this.m_dtp_den_ngay.RightToLeftLayout = true;
            this.m_dtp_den_ngay.Size = new System.Drawing.Size(126, 23);
            this.m_dtp_den_ngay.TabIndex = 2;
            this.m_dtp_den_ngay.Value = new System.DateTime(2014, 7, 12, 0, 0, 0, 0);
            // 
            // m_dtp_tu_ngay
            // 
            this.m_dtp_tu_ngay.Checked = false;
            this.m_dtp_tu_ngay.CustomFormat = "dd/MM/yyyy";
            this.m_dtp_tu_ngay.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_dtp_tu_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dtp_tu_ngay.Location = new System.Drawing.Point(334, 50);
            this.m_dtp_tu_ngay.Name = "m_dtp_tu_ngay";
            this.m_dtp_tu_ngay.Size = new System.Drawing.Size(126, 23);
            this.m_dtp_tu_ngay.TabIndex = 1;
            this.m_dtp_tu_ngay.Value = new System.DateTime(2014, 1, 30, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(484, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Đến ngày";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(239, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Từ ngày";
            // 
            // m_lbl_tieu_de
            // 
            this.m_lbl_tieu_de.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_tieu_de.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_tieu_de.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_tieu_de.Name = "m_lbl_tieu_de";
            this.m_lbl_tieu_de.Size = new System.Drawing.Size(884, 36);
            this.m_lbl_tieu_de.TabIndex = 27;
            this.m_lbl_tieu_de.Text = "TỔNG HỢP THƯ BỊ TRẢ LẠI TOÀN TOPICA";
            this.m_lbl_tieu_de.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // f512_BILL_BI_TRA_LAI
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.m_pnl_top);
            this.Controls.Add(this.m_grv_bill);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f512_BILL_BI_TRA_LAI";
            this.Text = "F512 - Tổng hợp thư bị trả lại";
            this.Load += new System.EventHandler(this.f512_BILL_BI_TRA_LAI_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_bill)).EndInit();
            this.m_pnl_top.ResumeLayout(false);
            this.m_pnl_top.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		#region Public Interface
		public void display(){			
			this.ShowDialog();
		}
		#endregion

		#region Data Structure
		private enum e_col_Number{
			TEN_PHONG_BAN = 1,NGAY_GUI = 2,NOI_NHAN = 6,NGUOI_NHAN = 5,NOI_DUNG = 4,NGUOI_GUI = 7,SO_BILL = 3
		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_V_DM_BILL m_ds = new DS_V_DM_BILL();
		US_V_DM_BILL m_us = new US_V_DM_BILL();
		#endregion

		#region Private Methods
		private void format_controls(){
			CControlFormat.setFormStyle(this, new CAppContext_201());
			CControlFormat.setC1FlexFormat(m_grv_bill);
            m_lbl_tieu_de.Font = new System.Drawing.Font("Tahoma", 15, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			CGridUtils.AddSave_Excel_Handlers(m_grv_bill);
            CGridUtils.AddSearch_Handlers(m_grv_bill);
            m_grv_bill.Tree.Column = (int)e_col_Number.NGAY_GUI;
            m_grv_bill.Cols[(int)e_col_Number.TEN_PHONG_BAN].Visible = false;
            m_grv_bill.Tree.Style = C1.Win.C1FlexGrid.TreeStyleFlags.CompleteLeaf;
			set_define_events();
            DateTime v_dat_tu_ngay = new DateTime(2014, 1, 30);
            m_dtp_tu_ngay.Value = v_dat_tu_ngay.Date;
            //DateTime v_dat_den_ngay = new DateTime();
            //v_dat_den_ngay = DateTime.Now;
            //m_dtp_den_ngay.Value = v_dat_den_ngay.Date;
			this.KeyPreview = true;		
		}
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_grv_bill);
			load_data_2_grid();		
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(V_DM_BILL.TEN_PHONG_BAN, e_col_Number.TEN_PHONG_BAN);			v_htb.Add(V_DM_BILL.NGAY_GUI, e_col_Number.NGAY_GUI);			v_htb.Add(V_DM_BILL.NOI_NHAN, e_col_Number.NOI_NHAN);			v_htb.Add(V_DM_BILL.NGUOI_NHAN, e_col_Number.NGUOI_NHAN);			v_htb.Add(V_DM_BILL.NOI_DUNG, e_col_Number.NOI_DUNG);			v_htb.Add(V_DM_BILL.NGUOI_GUI, e_col_Number.NGUOI_GUI);			v_htb.Add(V_DM_BILL.SO_BILL, e_col_Number.SO_BILL);									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.V_DM_BILL.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){
            decimal v_dc_id_trang_thai = CONST_ID_TRANG_THAI_THU.ID_BI_TRA_LAI;
            DateTime v_dat_tu_ngay = m_dtp_tu_ngay.Value.Date;
            DateTime v_dat_den_ngay = m_dtp_den_ngay.Value.Date;
			m_ds = new DS_V_DM_BILL();
            m_us.FillDatasetSearch_bitralai(m_ds,v_dc_id_trang_thai, v_dat_tu_ngay, v_dat_den_ngay);
			m_grv_bill.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_grv_bill, m_obj_trans);
            CGridUtils.MakeSoTT(0, m_grv_bill);
            m_grv_bill.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Count // chỗ này dùng hàm count tức là để đếm, có thể dùng các hàm khác thay thế
              , 0
              , (int)e_col_Number.TEN_PHONG_BAN // chỗ này là tên trường mà mình nhóm
              , (int)e_col_Number.SO_BILL // chỗ này là tên trường mà mình Count
              , "{0}"
              );
			m_grv_bill.Redraw = true;
		}
		private void grid2us_object(US_V_DM_BILL i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_grv_bill.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

	
		private void us_object2grid(US_V_DM_BILL i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_grv_bill.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}


		private void insert_v_dm_bill(){			
		//	f512_BILL_BI_TRA_LAI_DE v_fDE = new  f512_BILL_BI_TRA_LAI_DE();								
		//	v_fDE.display();
			load_data_2_grid();
		}

		private void update_v_dm_bill(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_bill)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_bill, m_grv_bill.Row)) return;			
			grid2us_object(m_us, m_grv_bill.Row);
		//	f512_BILL_BI_TRA_LAI_DE v_fDE = new f512_BILL_BI_TRA_LAI_DE();
		//	v_fDE.display(m_us);
			load_data_2_grid();
		}
				
		private void delete_v_dm_bill(){
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_bill)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_bill, m_grv_bill.Row)) return;
			if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted)  return;
			US_V_DM_BILL v_us = new US_V_DM_BILL();
			grid2us_object(v_us, m_grv_bill.Row);
			try {			
				v_us.BeginTransaction();    											
				v_us.Delete();                      								
				v_us.CommitTransaction();
				m_grv_bill.Rows.Remove(m_grv_bill.Row);				
			}
			catch (Exception v_e) {
				v_us.Rollback();
				CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
					new CDBClientDBExceptionInterpret());
				v_objErrHandler.showErrorMessage();
			}
		}

		private void view_v_dm_bill(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_bill)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_bill, m_grv_bill.Row)) return;
			grid2us_object(m_us, m_grv_bill.Row);
		//	f512_BILL_BI_TRA_LAI_DE v_fDE = new f512_BILL_BI_TRA_LAI_DE();			
		//	v_fDE.display(m_us);
		}
        //private void load_data_2_cbo_trung_tam()
        //{
        //    US_DM_PHONG_BAN v_us = new US_DM_PHONG_BAN();
        //    DS_DM_PHONG_BAN v_ds = new DS_DM_PHONG_BAN();
        //    v_us.FillDataset(v_ds);
        //    m_cbo_trung_tam.DataSource = v_ds.DM_PHONG_BAN;
        //    m_cbo_trung_tam.ValueMember = DM_PHONG_BAN.ID;
        //    m_cbo_trung_tam.DisplayMember = DM_PHONG_BAN.TEN_PHONG_BAN;

        //    DataRow v_dr = v_ds.DM_PHONG_BAN.NewRow();
        //    v_dr[DM_PHONG_BAN.ID] = -1;
        //    v_dr[DM_PHONG_BAN.MA_PHONG_BAN] = "";
        //    v_dr[DM_PHONG_BAN.TEN_PHONG_BAN] = "-----Tất cả-----";

        //    v_ds.DM_PHONG_BAN.Rows.InsertAt(v_dr, 0);
        //    m_cbo_trung_tam.SelectedIndex = 0;

        //}
        private void export_2_excel()
        {
            CExcelReport v_obj_excel_report = new CExcelReport("f512_bill_bi_tra_lai.xlsx", 6, 1);
            v_obj_excel_report.AddFindAndReplaceItem("<tu_ngay>", m_dtp_tu_ngay.Text);
            v_obj_excel_report.AddFindAndReplaceItem("<den_ngay>", m_dtp_den_ngay.Text);
            v_obj_excel_report.FindAndReplace(false);
            v_obj_excel_report.Export2ExcelWithoutFixedRows(m_grv_bill, 0, m_grv_bill.Cols.Count - 1, true);
        }
		private void set_define_events(){
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
			m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
			m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
			m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
			m_cmd_xuat_excel.Click += new EventHandler(m_cmd_xuat_excel_Click);
            //m_cbo_trung_tam.SelectedIndexChanged+=new EventHandler(m_cbo_trung_tam_SelectedIndexChanged);
            m_dtp_tu_ngay.ValueChanged+=new EventHandler(m_dtp_tu_ngay_ValueChanged);
            m_dtp_den_ngay.ValueChanged+=new EventHandler(m_dtp_den_ngay_ValueChanged);
		}
		#endregion

//
		//
		//		EVENT HANLDERS
		//
        //
        #region Event
        private void f512_BILL_BI_TRA_LAI_Load(object sender, System.EventArgs e)
        {
            try
            {
                set_initial_form_load();
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

        private void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                insert_v_dm_bill();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {
                update_v_dm_bill();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                delete_v_dm_bill();
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
        private void m_dtp_tu_ngay_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_dtp_den_ngay_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
        

	}
}

