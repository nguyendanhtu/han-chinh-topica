///************************************************
/// Generated by: DungNT
/// Date: 28/07/2014 10:16:12
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

namespace BCTKApp
{



	public class f535_gui_don_dat_hang_cho_NCC : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
		private C1.Win.C1FlexGrid.C1FlexGrid m_grv_don_hang;
		internal SIS.Controls.Button.SiSButton m_cmd_delete;
		internal SIS.Controls.Button.SiSButton m_cmd_update;
		internal SIS.Controls.Button.SiSButton m_cmd_insert;
		internal SIS.Controls.Button.SiSButton m_cmd_exit;
		internal SIS.Controls.Button.SiSButton m_cmd_xuat_excel;
        private Panel panel1;
        private ComboBox m_cbo_trung_tam;
        private Label label1;
        private DateTimePicker m_dtp_thang;
        private Label label7;
        private Label m_lbl_tieu_de;
		private System.ComponentModel.IContainer components;

		public f535_gui_don_dat_hang_cho_NCC()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f535_gui_don_dat_hang_cho_NCC));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_xuat_excel = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_grv_don_hang = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cbo_trung_tam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_dtp_thang = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.m_lbl_tieu_de = new System.Windows.Forms.Label();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_don_hang)).BeginInit();
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
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_xuat_excel);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 451);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(738, 36);
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
            this.m_cmd_insert.Location = new System.Drawing.Point(382, 4);
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
            this.m_cmd_update.Location = new System.Drawing.Point(470, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_update.TabIndex = 13;
            this.m_cmd_update.Text = "&Sửa";
            this.m_cmd_update.Visible = false;
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
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(107, 28);
            this.m_cmd_xuat_excel.TabIndex = 21;
            this.m_cmd_xuat_excel.Text = "Xuất ra Excel";
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
            this.m_cmd_delete.Location = new System.Drawing.Point(558, 4);
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
            this.m_cmd_exit.Location = new System.Drawing.Point(646, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_grv_don_hang
            // 
            this.m_grv_don_hang.ColumnInfo = resources.GetString("m_grv_don_hang.ColumnInfo");
            this.m_grv_don_hang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_grv_don_hang.Location = new System.Drawing.Point(0, 126);
            this.m_grv_don_hang.Name = "m_grv_don_hang";
            this.m_grv_don_hang.Size = new System.Drawing.Size(738, 325);
            this.m_grv_don_hang.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_grv_don_hang.Styles"));
            this.m_grv_don_hang.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cbo_trung_tam);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.m_dtp_thang);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.m_lbl_tieu_de);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 120);
            this.panel1.TabIndex = 22;
            // 
            // m_cbo_trung_tam
            // 
            this.m_cbo_trung_tam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_trung_tam.FormattingEnabled = true;
            this.m_cbo_trung_tam.Location = new System.Drawing.Point(309, 81);
            this.m_cbo_trung_tam.Name = "m_cbo_trung_tam";
            this.m_cbo_trung_tam.Size = new System.Drawing.Size(299, 21);
            this.m_cbo_trung_tam.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Trung tâm";
            // 
            // m_dtp_thang
            // 
            this.m_dtp_thang.CustomFormat = "MM/yyyy";
            this.m_dtp_thang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_dtp_thang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dtp_thang.Location = new System.Drawing.Point(309, 46);
            this.m_dtp_thang.Name = "m_dtp_thang";
            this.m_dtp_thang.Size = new System.Drawing.Size(126, 23);
            this.m_dtp_thang.TabIndex = 32;
            this.m_dtp_thang.Value = new System.DateTime(2014, 7, 24, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(225, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "Tháng";
            // 
            // m_lbl_tieu_de
            // 
            this.m_lbl_tieu_de.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_tieu_de.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_tieu_de.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_tieu_de.Name = "m_lbl_tieu_de";
            this.m_lbl_tieu_de.Size = new System.Drawing.Size(738, 32);
            this.m_lbl_tieu_de.TabIndex = 28;
            this.m_lbl_tieu_de.Text = "ĐƠN HÀNG THEO TỪNG TRUNG TÂM";
            this.m_lbl_tieu_de.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // f535_gui_don_dat_hang_cho_NCC
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(738, 487);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_grv_don_hang);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f535_gui_don_dat_hang_cho_NCC";
            this.Text = "f535_gui_don_dat_hang_cho_NCC";
            this.Load += new System.EventHandler(this.f535_gui_don_dat_hang_cho_NCC_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_don_hang)).EndInit();
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
			TEN_VPP = 6,TEN_PHONG_BAN = 1,NGAY_DAT_HANG = 2,DON_VI_TINH = 8,SO_LUONG = 7,MA_VPP = 5,MA_DON_HANG = 4,LAN_DAT_HANG = 3
		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_V_GD_DON_DAT_HANG_DETAIL m_ds = new DS_V_GD_DON_DAT_HANG_DETAIL();
		US_V_GD_DON_DAT_HANG_DETAIL m_us = new US_V_GD_DON_DAT_HANG_DETAIL();
		#endregion

		#region Private Methods
		private void format_controls(){
			CControlFormat.setFormStyle(this, new CAppContext_201());
			CControlFormat.setC1FlexFormat(m_grv_don_hang);
			CGridUtils.AddSave_Excel_Handlers(m_grv_don_hang);
            CGridUtils.AddSearch_Handlers(m_grv_don_hang);
            m_lbl_tieu_de.Font = new System.Drawing.Font("Tahoma", 15, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            m_grv_don_hang.Tree.Column = (int)e_col_Number.NGAY_DAT_HANG;
            m_grv_don_hang.Cols[(int)e_col_Number.TEN_PHONG_BAN].Visible = false;
            m_grv_don_hang.Tree.Style = C1.Win.C1FlexGrid.TreeStyleFlags.ButtonBar;
            load_data_2_cbo_trung_tam();
            set_define_events();
			this.KeyPreview = true;		
		}
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_grv_don_hang);
			load_data_2_grid();		
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(V_GD_DON_DAT_HANG_DETAIL.TEN_VPP, e_col_Number.TEN_VPP);			v_htb.Add(V_GD_DON_DAT_HANG_DETAIL.TEN_PHONG_BAN, e_col_Number.TEN_PHONG_BAN);			v_htb.Add(V_GD_DON_DAT_HANG_DETAIL.NGAY_DAT_HANG, e_col_Number.NGAY_DAT_HANG);			v_htb.Add(V_GD_DON_DAT_HANG_DETAIL.DON_VI_TINH, e_col_Number.DON_VI_TINH);			v_htb.Add(V_GD_DON_DAT_HANG_DETAIL.SO_LUONG, e_col_Number.SO_LUONG);			v_htb.Add(V_GD_DON_DAT_HANG_DETAIL.MA_VPP, e_col_Number.MA_VPP);			v_htb.Add(V_GD_DON_DAT_HANG_DETAIL.MA_DON_HANG, e_col_Number.MA_DON_HANG);			v_htb.Add(V_GD_DON_DAT_HANG_DETAIL.LAN_DAT_HANG, e_col_Number.LAN_DAT_HANG);									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.V_GD_DON_DAT_HANG_DETAIL.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){
            decimal v_dc_id_trung_tam = CIPConvert.ToDecimal(m_cbo_trung_tam.SelectedValue);
		    DateTime temp = m_dtp_thang.Value.Date;
            temp = temp.AddMonths(1);
            temp = temp.AddDays(-(temp.Day));
            DateTime v_dat_thang = temp;
			m_ds = new DS_V_GD_DON_DAT_HANG_DETAIL();			
			m_us.FillDatasetSearch(m_ds,v_dat_thang,v_dc_id_trung_tam,"");
			m_grv_don_hang.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_grv_don_hang, m_obj_trans);
            CGridUtils.MakeSoTT(0, m_grv_don_hang);
            m_grv_don_hang.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Count // chỗ này dùng hàm count tức là để đếm, có thể dùng các hàm khác thay thế
              , 0
              , (int)e_col_Number.TEN_PHONG_BAN // chỗ này là tên trường mà mình nhóm
              , (int)e_col_Number.NGAY_DAT_HANG // chỗ này là tên trường mà mình Count
              , "{0}"
              );
			m_grv_don_hang.Redraw = true;
		}
        private void load_data_2_cbo_trung_tam()
        {
            US_DM_PHONG_BAN v_us = new US_DM_PHONG_BAN();
            DS_DM_PHONG_BAN v_ds = new DS_DM_PHONG_BAN();
            v_us.FillDataset(v_ds, "order by ten_phong_ban");
            m_cbo_trung_tam.DataSource = v_ds.DM_PHONG_BAN;
            m_cbo_trung_tam.ValueMember = DM_PHONG_BAN.ID;
            m_cbo_trung_tam.DisplayMember = DM_PHONG_BAN.TEN_PHONG_BAN;

            DataRow v_dr = v_ds.DM_PHONG_BAN.NewRow();
            v_dr[DM_PHONG_BAN.ID] = -1;
            v_dr[DM_PHONG_BAN.MA_PHONG_BAN] = "";
            v_dr[DM_PHONG_BAN.TEN_PHONG_BAN] = "------------Tất cả------------";


            v_ds.DM_PHONG_BAN.Rows.InsertAt(v_dr, 0);
            m_cbo_trung_tam.SelectedIndex = 0;
        }
		private void grid2us_object(US_V_GD_DON_DAT_HANG_DETAIL i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_grv_don_hang.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

	
		private void us_object2grid(US_V_GD_DON_DAT_HANG_DETAIL i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_grv_don_hang.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}


		private void insert_v_gd_don_dat_hang_detail(){			
		//	f535_gui_don_dat_hang_cho_NCC_DE v_fDE = new  f535_gui_don_dat_hang_cho_NCC_DE();								
		//	v_fDE.display();
			load_data_2_grid();
		}

		private void update_v_gd_don_dat_hang_detail(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_don_hang)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_don_hang, m_grv_don_hang.Row)) return;			
			grid2us_object(m_us, m_grv_don_hang.Row);
		//	f535_gui_don_dat_hang_cho_NCC_DE v_fDE = new f535_gui_don_dat_hang_cho_NCC_DE();
		//	v_fDE.display(m_us);
			load_data_2_grid();
		}
				
		private void delete_v_gd_don_dat_hang_detail(){
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_don_hang)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_don_hang, m_grv_don_hang.Row)) return;
			if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted)  return;
			US_V_GD_DON_DAT_HANG_DETAIL v_us = new US_V_GD_DON_DAT_HANG_DETAIL();
			grid2us_object(v_us, m_grv_don_hang.Row);
			try {			
				v_us.BeginTransaction();    											
				v_us.Delete();                      								
				v_us.CommitTransaction();
				m_grv_don_hang.Rows.Remove(m_grv_don_hang.Row);				
			}
			catch (Exception v_e) {
				v_us.Rollback();
				CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
					new CDBClientDBExceptionInterpret());
				v_objErrHandler.showErrorMessage();
			}
		}

		private void view_v_gd_don_dat_hang_detail(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_don_hang)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_don_hang, m_grv_don_hang.Row)) return;
			grid2us_object(m_us, m_grv_don_hang.Row);
		//	f535_gui_don_dat_hang_cho_NCC_DE v_fDE = new f535_gui_don_dat_hang_cho_NCC_DE();			
		//	v_fDE.display(m_us);
		}
		private void set_define_events(){
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
			m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
			m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
			m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
			m_cmd_xuat_excel.Click += new EventHandler(m_cmd_xuat_excel_Click);
            m_cbo_trung_tam.SelectedIndexChanged+=new EventHandler(m_cbo_trung_tam_SelectedIndexChanged);
            m_dtp_thang.ValueChanged+=new EventHandler(m_dtp_thang_ValueChanged);
		}
		#endregion

//
		//
		//		EVENT HANLDERS
		//
		//
		private void f535_gui_don_dat_hang_cho_NCC_Load(object sender, System.EventArgs e) {
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

		private void m_cmd_xuat_excel_Click(object sender, EventArgs e) {
			try{
				view_v_gd_don_dat_hang_detail();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}
        private void m_cbo_trung_tam_SelectedIndexChanged(object sender, EventArgs e)
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
        private void m_dtp_thang_ValueChanged(object sender, EventArgs e)
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


	}
}

