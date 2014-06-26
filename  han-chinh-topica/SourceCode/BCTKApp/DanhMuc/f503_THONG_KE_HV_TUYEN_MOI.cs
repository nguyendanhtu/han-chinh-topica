///************************************************
/// Generated by: DungNT
/// Date: 26/06/2014 09:06:17
/// Goal: Create Form for V_GD_THONG_KE
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

namespace BCTKApp
{



	public class f503_THONG_KE_HV_TUYEN_MOI : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
		private C1.Win.C1FlexGrid.C1FlexGrid m_grv_thong_ke;
		internal SIS.Controls.Button.SiSButton m_cmd_delete;
		internal SIS.Controls.Button.SiSButton m_cmd_update;
		internal SIS.Controls.Button.SiSButton m_cmd_insert;
		internal SIS.Controls.Button.SiSButton m_cmd_exit;
		internal SIS.Controls.Button.SiSButton m_cmd_xuat_excel;
        private Panel m_pnl_top;
        internal SIS.Controls.Button.SiSButton m_cmd_search;
        private TextBox m_txt_tu_khoa;
        private Label label4;
        private DateTimePicker m_dtp_den_thang;
        private DateTimePicker m_dtp_tu_thang;
        private Label label3;
        private Label label2;
        private Label label1;
		private System.ComponentModel.IContainer components;

		public f503_THONG_KE_HV_TUYEN_MOI()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f503_THONG_KE_HV_TUYEN_MOI));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_xuat_excel = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_grv_thong_ke = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_pnl_top = new System.Windows.Forms.Panel();
            this.m_cmd_search = new SIS.Controls.Button.SiSButton();
            this.m_txt_tu_khoa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.m_dtp_den_thang = new System.Windows.Forms.DateTimePicker();
            this.m_dtp_tu_thang = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_thong_ke)).BeginInit();
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
            // m_grv_thong_ke
            // 
            this.m_grv_thong_ke.ColumnInfo = resources.GetString("m_grv_thong_ke.ColumnInfo");
            this.m_grv_thong_ke.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_grv_thong_ke.Location = new System.Drawing.Point(0, 152);
            this.m_grv_thong_ke.Name = "m_grv_thong_ke";
            this.m_grv_thong_ke.Size = new System.Drawing.Size(884, 374);
            this.m_grv_thong_ke.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_grv_thong_ke.Styles"));
            this.m_grv_thong_ke.TabIndex = 20;
            // 
            // m_pnl_top
            // 
            this.m_pnl_top.Controls.Add(this.m_cmd_search);
            this.m_pnl_top.Controls.Add(this.m_txt_tu_khoa);
            this.m_pnl_top.Controls.Add(this.label4);
            this.m_pnl_top.Controls.Add(this.m_dtp_den_thang);
            this.m_pnl_top.Controls.Add(this.m_dtp_tu_thang);
            this.m_pnl_top.Controls.Add(this.label3);
            this.m_pnl_top.Controls.Add(this.label2);
            this.m_pnl_top.Controls.Add(this.label1);
            this.m_pnl_top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_pnl_top.Location = new System.Drawing.Point(0, 0);
            this.m_pnl_top.Name = "m_pnl_top";
            this.m_pnl_top.Size = new System.Drawing.Size(884, 152);
            this.m_pnl_top.TabIndex = 23;
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_search.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_search.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_search.ImageIndex = 18;
            this.m_cmd_search.ImageList = this.ImageList;
            this.m_cmd_search.Location = new System.Drawing.Point(528, 93);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_search.TabIndex = 22;
            this.m_cmd_search.Text = "Tìm kiếm";
            // 
            // m_txt_tu_khoa
            // 
            this.m_txt_tu_khoa.Location = new System.Drawing.Point(302, 98);
            this.m_txt_tu_khoa.Name = "m_txt_tu_khoa";
            this.m_txt_tu_khoa.Size = new System.Drawing.Size(200, 20);
            this.m_txt_tu_khoa.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(236, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Từ khóa";
            // 
            // m_dtp_den_thang
            // 
            this.m_dtp_den_thang.CustomFormat = "MM/yyyy";
            this.m_dtp_den_thang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_dtp_den_thang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dtp_den_thang.Location = new System.Drawing.Point(534, 38);
            this.m_dtp_den_thang.Name = "m_dtp_den_thang";
            this.m_dtp_den_thang.Size = new System.Drawing.Size(126, 23);
            this.m_dtp_den_thang.TabIndex = 4;
            this.m_dtp_den_thang.Value = new System.DateTime(2014, 6, 26, 9, 16, 54, 0);
            // 
            // m_dtp_tu_thang
            // 
            this.m_dtp_tu_thang.CustomFormat = "MM/yyyy";
            this.m_dtp_tu_thang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_dtp_tu_thang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dtp_tu_thang.Location = new System.Drawing.Point(302, 41);
            this.m_dtp_tu_thang.Name = "m_dtp_tu_thang";
            this.m_dtp_tu_thang.Size = new System.Drawing.Size(126, 23);
            this.m_dtp_tu_thang.TabIndex = 3;
            this.m_dtp_tu_thang.Value = new System.DateTime(2014, 6, 26, 9, 16, 54, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(448, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đến tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Từ tháng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ HỌC VIÊN TUYỂN MỚI";
            // 
            // f503_THONG_KE_HV_TUYEN_MOI
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.m_pnl_top);
            this.Controls.Add(this.m_grv_thong_ke);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f503_THONG_KE_HV_TUYEN_MOI";
            this.Text = "f503_THONG_KE_HV_TUYEN_MOI";
            this.Load += new System.EventHandler(this.f503_THONG_KE_HV_TUYEN_MOI_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_thong_ke)).EndInit();
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
			LOAI_THOI_GIAN = 5,DON_VI_THONG_KE = 8,MA_PHONG_BAN = 1,DEN_NGAY = 7,TEN_PHONG_BAN = 2,TEN_THONG_KE = 4,TU_NGAY = 6,GIA_TRI_THONG_KE = 9,LOAI_TK = 3
		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_V_GD_THONG_KE m_ds = new DS_V_GD_THONG_KE();
		US_V_GD_THONG_KE m_us = new US_V_GD_THONG_KE();
		#endregion

		#region Private Methods
		private void format_controls(){
            //CControlFormat.setFormStyle(this, new CAppContext_201());
            this.StartPosition = FormStartPosition.CenterScreen;
			CControlFormat.setC1FlexFormat(m_grv_thong_ke);
			CGridUtils.AddSave_Excel_Handlers(m_grv_thong_ke);
            			CGridUtils.AddSearch_Handlers(m_grv_thong_ke);
			set_define_events();
			this.KeyPreview = true;		
		}
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_grv_thong_ke);
			load_data_2_grid();		
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(V_GD_THONG_KE.LOAI_THOI_GIAN, e_col_Number.LOAI_THOI_GIAN);			v_htb.Add(V_GD_THONG_KE.DON_VI_THONG_KE, e_col_Number.DON_VI_THONG_KE);			v_htb.Add(V_GD_THONG_KE.MA_PHONG_BAN, e_col_Number.MA_PHONG_BAN);			v_htb.Add(V_GD_THONG_KE.DEN_NGAY, e_col_Number.DEN_NGAY);			v_htb.Add(V_GD_THONG_KE.TEN_PHONG_BAN, e_col_Number.TEN_PHONG_BAN);			v_htb.Add(V_GD_THONG_KE.TEN_THONG_KE, e_col_Number.TEN_THONG_KE);			v_htb.Add(V_GD_THONG_KE.TU_NGAY, e_col_Number.TU_NGAY);			v_htb.Add(V_GD_THONG_KE.GIA_TRI_THONG_KE, e_col_Number.GIA_TRI_THONG_KE);			v_htb.Add(V_GD_THONG_KE.LOAI_TK, e_col_Number.LOAI_TK);									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.V_GD_THONG_KE.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){
            string v_str_tu_khoa = m_txt_tu_khoa.Text;		
			m_ds = new DS_V_GD_THONG_KE();			
			m_us.FillDatasetSearch_hvtuyenmoi(m_ds,v_str_tu_khoa);
			m_grv_thong_ke.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_grv_thong_ke, m_obj_trans);
			m_grv_thong_ke.Redraw = true;
		}
		private void grid2us_object(US_V_GD_THONG_KE i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_grv_thong_ke.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

	
		private void us_object2grid(US_V_GD_THONG_KE i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_grv_thong_ke.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}


		private void insert_v_gd_thong_ke(){			
		//	f503_THONG_KE_HV_TUYEN_MOI_DE v_fDE = new  f503_THONG_KE_HV_TUYEN_MOI_DE();								
		//	v_fDE.display();
			load_data_2_grid();
		}

		private void update_v_gd_thong_ke(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_thong_ke)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_thong_ke, m_grv_thong_ke.Row)) return;			
			grid2us_object(m_us, m_grv_thong_ke.Row);
		//	f503_THONG_KE_HV_TUYEN_MOI_DE v_fDE = new f503_THONG_KE_HV_TUYEN_MOI_DE();
		//	v_fDE.display(m_us);
			load_data_2_grid();
		}
				
		private void delete_v_gd_thong_ke(){
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_thong_ke)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_thong_ke, m_grv_thong_ke.Row)) return;
			if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted)  return;
			US_V_GD_THONG_KE v_us = new US_V_GD_THONG_KE();
			grid2us_object(v_us, m_grv_thong_ke.Row);
			try {			
				v_us.BeginTransaction();    											
				v_us.Delete();                      								
				v_us.CommitTransaction();
				m_grv_thong_ke.Rows.Remove(m_grv_thong_ke.Row);				
			}
			catch (Exception v_e) {
				v_us.Rollback();
				CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
					new CDBClientDBExceptionInterpret());
				v_objErrHandler.showErrorMessage();
			}
		}

		private void view_v_gd_thong_ke(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_thong_ke)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_thong_ke, m_grv_thong_ke.Row)) return;
			grid2us_object(m_us, m_grv_thong_ke.Row);
		//	f503_THONG_KE_HV_TUYEN_MOI_DE v_fDE = new f503_THONG_KE_HV_TUYEN_MOI_DE();			
		//	v_fDE.display(m_us);
		}
		private void set_define_events(){
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
			m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
			m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
			m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            m_cmd_xuat_excel.Click += new EventHandler(m_cmd_xuat_excel_Click);
            m_cmd_search.Click+=new EventHandler(m_cmd_search_Click);
		}
		#endregion

//
		//
		//		EVENT HANLDERS
		//
        //
        #region EVent
        private void f503_THONG_KE_HV_TUYEN_MOI_Load(object sender, System.EventArgs e)
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
                insert_v_gd_thong_ke();
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
                update_v_gd_thong_ke();
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
                delete_v_gd_thong_ke();
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
                view_v_gd_thong_ke();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_search_Click(object sender, EventArgs e)
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

