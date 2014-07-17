///************************************************
/// Generated by: DungNT
/// Date: 16/07/2014 05:02:25
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



	public class f521_THONG_KE_NHAN_SU : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
		private C1.Win.C1FlexGrid.C1FlexGrid m_grv_nhan_su;
		internal SIS.Controls.Button.SiSButton m_cmd_delete;
		internal SIS.Controls.Button.SiSButton m_cmd_update;
		internal SIS.Controls.Button.SiSButton m_cmd_insert;
		internal SIS.Controls.Button.SiSButton m_cmd_exit;
		internal SIS.Controls.Button.SiSButton m_cmd_view;
        private Panel panel1;
        private DateTimePicker m_dtp_den_ngay;
        private DateTimePicker m_dtp_tu_ngay;
        private Label label2;
        private Label label1;
        private Label m_lbl_tieu_de;
        private TextBox m_txt_tu_khoa;
        private Label label4;
        private Label label3;
        private ComboBox m_cbo_co_so_tinh;
        internal SIS.Controls.Button.SiSButton m_cmd_search;
		private System.ComponentModel.IContainer components;

		public f521_THONG_KE_NHAN_SU()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f521_THONG_KE_NHAN_SU));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_view = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_grv_nhan_su = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_dtp_tu_ngay = new System.Windows.Forms.DateTimePicker();
            this.m_dtp_den_ngay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_lbl_tieu_de = new System.Windows.Forms.Label();
            this.m_cbo_co_so_tinh = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_txt_tu_khoa = new System.Windows.Forms.TextBox();
            this.m_cmd_search = new SIS.Controls.Button.SiSButton();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_nhan_su)).BeginInit();
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
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_view);
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
            // m_cmd_view
            // 
            this.m_cmd_view.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_view.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_view.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_view.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_view.ImageIndex = 18;
            this.m_cmd_view.ImageList = this.ImageList;
            this.m_cmd_view.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_view.Name = "m_cmd_view";
            this.m_cmd_view.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_view.TabIndex = 21;
            this.m_cmd_view.Text = "Xem";
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
            // m_grv_nhan_su
            // 
            this.m_grv_nhan_su.ColumnInfo = resources.GetString("m_grv_nhan_su.ColumnInfo");
            this.m_grv_nhan_su.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_grv_nhan_su.Location = new System.Drawing.Point(0, 171);
            this.m_grv_nhan_su.Name = "m_grv_nhan_su";
            this.m_grv_nhan_su.Size = new System.Drawing.Size(884, 355);
            this.m_grv_nhan_su.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_grv_nhan_su.Styles"));
            this.m_grv_nhan_su.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_search);
            this.panel1.Controls.Add(this.m_txt_tu_khoa);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.m_cbo_co_so_tinh);
            this.panel1.Controls.Add(this.m_lbl_tieu_de);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.m_dtp_den_ngay);
            this.panel1.Controls.Add(this.m_dtp_tu_ngay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 165);
            this.panel1.TabIndex = 21;
            // 
            // m_dtp_tu_ngay
            // 
            this.m_dtp_tu_ngay.CustomFormat = "dd/MM/yyyy";
            this.m_dtp_tu_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dtp_tu_ngay.Location = new System.Drawing.Point(291, 50);
            this.m_dtp_tu_ngay.Name = "m_dtp_tu_ngay";
            this.m_dtp_tu_ngay.Size = new System.Drawing.Size(125, 20);
            this.m_dtp_tu_ngay.TabIndex = 0;
            this.m_dtp_tu_ngay.Value = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            // 
            // m_dtp_den_ngay
            // 
            this.m_dtp_den_ngay.CustomFormat = "dd/MM/yyyy";
            this.m_dtp_den_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dtp_den_ngay.Location = new System.Drawing.Point(494, 50);
            this.m_dtp_den_ngay.Name = "m_dtp_den_ngay";
            this.m_dtp_den_ngay.Size = new System.Drawing.Size(125, 20);
            this.m_dtp_den_ngay.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến ngày";
            // 
            // m_lbl_tieu_de
            // 
            this.m_lbl_tieu_de.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_tieu_de.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_tieu_de.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_tieu_de.Name = "m_lbl_tieu_de";
            this.m_lbl_tieu_de.Size = new System.Drawing.Size(884, 36);
            this.m_lbl_tieu_de.TabIndex = 28;
            this.m_lbl_tieu_de.Text = "THỐNG KÊ";
            this.m_lbl_tieu_de.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_cbo_co_so_tinh
            // 
            this.m_cbo_co_so_tinh.FormattingEnabled = true;
            this.m_cbo_co_so_tinh.Location = new System.Drawing.Point(291, 88);
            this.m_cbo_co_so_tinh.Name = "m_cbo_co_so_tinh";
            this.m_cbo_co_so_tinh.Size = new System.Drawing.Size(237, 21);
            this.m_cbo_co_so_tinh.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Cơ sở tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Từ khóa";
            // 
            // m_txt_tu_khoa
            // 
            this.m_txt_tu_khoa.Location = new System.Drawing.Point(291, 126);
            this.m_txt_tu_khoa.Name = "m_txt_tu_khoa";
            this.m_txt_tu_khoa.Size = new System.Drawing.Size(328, 20);
            this.m_txt_tu_khoa.TabIndex = 32;
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_search.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_search.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_search.ImageIndex = 18;
            this.m_cmd_search.ImageList = this.ImageList;
            this.m_cmd_search.Location = new System.Drawing.Point(656, 118);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_search.TabIndex = 22;
            this.m_cmd_search.Text = "Tìm kiếm";
            // 
            // f521_THONG_KE_NHAN_SU
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_grv_nhan_su);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f521_THONG_KE_NHAN_SU";
            this.Text = "F521- Thống kê";
            this.Load += new System.EventHandler(this.f521_THONG_KE_NHAN_SU_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_nhan_su)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
			MA = 1,TEN_CO_SO_DINH_MUC = 4,GHI_CHU_3 = 11,GHI_CHU_1 = 9,DEN_NGAY = 6,TEN_THONG_KE = 3,GHI_CHU_2 = 10,MO_TA = 2,TEN = 8,TU_NGAY = 5,GIA_TRI_THONG_KE = 7
		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_V_GD_THONG_KE m_ds = new DS_V_GD_THONG_KE();
		US_V_GD_THONG_KE m_us = new US_V_GD_THONG_KE();
		#endregion

		#region Private Methods
		private void format_controls(){
			CControlFormat.setFormStyle(this, new CAppContext_201());
            m_lbl_tieu_de.Font = new System.Drawing.Font("Tahoma", 15, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			CControlFormat.setC1FlexFormat(m_grv_nhan_su);
			CGridUtils.AddSave_Excel_Handlers(m_grv_nhan_su);
            CGridUtils.AddSearch_Handlers(m_grv_nhan_su);
            m_grv_nhan_su.Tree.Column = (int)e_col_Number.MO_TA;
            m_grv_nhan_su.Cols[(int)e_col_Number.MA].Visible = false;
            m_grv_nhan_su.Tree.Style = C1.Win.C1FlexGrid.TreeStyleFlags.ButtonBar;
            load_data_2_cbo();
			set_define_events();
			this.KeyPreview = true;		
		}
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_grv_nhan_su);
			load_data_2_grid();		
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(V_GD_THONG_KE.MA, e_col_Number.MA);			v_htb.Add(V_GD_THONG_KE.TEN_CO_SO_DINH_MUC, e_col_Number.TEN_CO_SO_DINH_MUC);			v_htb.Add(V_GD_THONG_KE.GHI_CHU_3, e_col_Number.GHI_CHU_3);			v_htb.Add(V_GD_THONG_KE.GHI_CHU_1, e_col_Number.GHI_CHU_1);			v_htb.Add(V_GD_THONG_KE.DEN_NGAY, e_col_Number.DEN_NGAY);			v_htb.Add(V_GD_THONG_KE.TEN_THONG_KE, e_col_Number.TEN_THONG_KE);			v_htb.Add(V_GD_THONG_KE.GHI_CHU_2, e_col_Number.GHI_CHU_2);			v_htb.Add(V_GD_THONG_KE.MO_TA, e_col_Number.MO_TA);			v_htb.Add(V_GD_THONG_KE.TEN, e_col_Number.TEN);			v_htb.Add(V_GD_THONG_KE.TU_NGAY, e_col_Number.TU_NGAY);			v_htb.Add(V_GD_THONG_KE.GIA_TRI_THONG_KE, e_col_Number.GIA_TRI_THONG_KE);									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.V_GD_THONG_KE.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){
            DateTime v_dat_tu_ngay = m_dtp_tu_ngay.Value.Date;
            DateTime v_dat_den_ngay = m_dtp_den_ngay.Value.Date;
            string v_str_tu_khoa = m_txt_tu_khoa.Text;
            decimal v_dc_id_co_so_dm = CIPConvert.ToDecimal(m_cbo_co_so_tinh.SelectedValue);
			m_ds = new DS_V_GD_THONG_KE();			
			m_us.FillDatasetSearch(m_ds,v_dc_id_co_so_dm,v_str_tu_khoa,v_dat_tu_ngay,v_dat_den_ngay);
			m_grv_nhan_su.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_grv_nhan_su, m_obj_trans);
            CGridUtils.MakeSoTT(0, m_grv_nhan_su);
           m_grv_nhan_su.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Count // chỗ này dùng hàm count tức là để đếm, có thể dùng các hàm khác thay thế
              , 0
              , (int)e_col_Number.MA// chỗ này là tên trường mà mình nhóm
              , (int)e_col_Number.TEN_THONG_KE // chỗ này là tên trường mà mình Count
              , "{0}"
              );
			m_grv_nhan_su.Redraw = true;
		}
		private void grid2us_object(US_V_GD_THONG_KE i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_grv_nhan_su.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

	
		private void us_object2grid(US_V_GD_THONG_KE i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_grv_nhan_su.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}


		private void insert_v_gd_thong_ke(){			
		//	f521_THONG_KE_NHAN_SU_DE v_fDE = new  f521_THONG_KE_NHAN_SU_DE();								
		//	v_fDE.display();
			load_data_2_grid();
		}

		private void update_v_gd_thong_ke(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_nhan_su)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_nhan_su, m_grv_nhan_su.Row)) return;			
			grid2us_object(m_us, m_grv_nhan_su.Row);
		//	f521_THONG_KE_NHAN_SU_DE v_fDE = new f521_THONG_KE_NHAN_SU_DE();
		//	v_fDE.display(m_us);
			load_data_2_grid();
		}
				
		private void delete_v_gd_thong_ke(){
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_nhan_su)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_nhan_su, m_grv_nhan_su.Row)) return;
			if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted)  return;
			US_V_GD_THONG_KE v_us = new US_V_GD_THONG_KE();
			grid2us_object(v_us, m_grv_nhan_su.Row);
			try {			
				v_us.BeginTransaction();    											
				v_us.Delete();                      								
				v_us.CommitTransaction();
				m_grv_nhan_su.Rows.Remove(m_grv_nhan_su.Row);				
			}
			catch (Exception v_e) {
				v_us.Rollback();
				CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
					new CDBClientDBExceptionInterpret());
				v_objErrHandler.showErrorMessage();
			}
		}

		private void view_v_gd_thong_ke(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_nhan_su)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_nhan_su, m_grv_nhan_su.Row)) return;
			grid2us_object(m_us, m_grv_nhan_su.Row);
		//	f521_THONG_KE_NHAN_SU_DE v_fDE = new f521_THONG_KE_NHAN_SU_DE();			
		//	v_fDE.display(m_us);
		}
        private void load_data_2_cbo()
        {
            US_DM_CO_SO_DINH_MUC v_us = new US_DM_CO_SO_DINH_MUC();
            DS_DM_CO_SO_DINH_MUC v_ds = new DS_DM_CO_SO_DINH_MUC();
            v_us.FillDataset(v_ds);
            m_cbo_co_so_tinh.DataSource = v_ds.DM_CO_SO_DINH_MUC;
            m_cbo_co_so_tinh.DisplayMember = DM_CO_SO_DINH_MUC.TEN_CO_SO_DINH_MUC;
            m_cbo_co_so_tinh.ValueMember = DM_CO_SO_DINH_MUC.ID;

            DataRow v_dr = v_ds.DM_CO_SO_DINH_MUC.NewRow();
            v_dr[DM_CO_SO_DINH_MUC.ID] = -1;
            v_dr[DM_CO_SO_DINH_MUC.ID_LOAI_CO_SO_DINH_MUC] = -1;
            v_dr[DM_CO_SO_DINH_MUC.MA_CO_SO_DINH_MUC] = "TAT_CA";
            v_dr[DM_CO_SO_DINH_MUC.TEN_CO_SO_DINH_MUC] = "------Tất cả-----";
            v_ds.DM_CO_SO_DINH_MUC.Rows.InsertAt(v_dr, 0);
            m_cbo_co_so_tinh.SelectedIndex = 0;
        }
		private void set_define_events(){
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
			m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
			m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
			m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
			m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
            m_cmd_search.Click+=new EventHandler(m_cmd_search_Click);
		}
		#endregion

//
		//
		//		EVENT HANLDERS
		//
        //
        #region Event
        private void f521_THONG_KE_NHAN_SU_Load(object sender, System.EventArgs e)
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

        private void m_cmd_view_Click(object sender, EventArgs e)
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

