///************************************************
/// Generated by: DungNT
/// Date: 09/08/2014 08:20:19
/// Goal: Create Form for V_GD_DON_DAT_HANG_DINH_MUC
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



	public class f538_TAD_DUYET_DON_HANG : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
		private C1.Win.C1FlexGrid.C1FlexGrid m_grv_don_hang;
		internal SIS.Controls.Button.SiSButton m_cmd_khong_duyet;
		internal SIS.Controls.Button.SiSButton m_cmd_duyet;
		internal SIS.Controls.Button.SiSButton m_cmd_insert;
		internal SIS.Controls.Button.SiSButton m_cmd_exit;
		internal SIS.Controls.Button.SiSButton m_cmd_view;
        private Panel panel1;
        private ComboBox m_cbo_trung_tam;
        private Label label1;
        private Label m_lbl_tieu_de;
		private System.ComponentModel.IContainer components;

		public f538_TAD_DUYET_DON_HANG()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f538_TAD_DUYET_DON_HANG));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_duyet = new SIS.Controls.Button.SiSButton();
            this.m_cmd_view = new SIS.Controls.Button.SiSButton();
            this.m_cmd_khong_duyet = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_grv_don_hang = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cbo_trung_tam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_duyet);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_view);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_khong_duyet);
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
            // 
            // m_cmd_duyet
            // 
            this.m_cmd_duyet.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_duyet.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_duyet.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_duyet.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_duyet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_duyet.ImageIndex = 16;
            this.m_cmd_duyet.ImageList = this.ImageList;
            this.m_cmd_duyet.Location = new System.Drawing.Point(470, 4);
            this.m_cmd_duyet.Name = "m_cmd_duyet";
            this.m_cmd_duyet.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_duyet.TabIndex = 13;
            this.m_cmd_duyet.Text = "&Duyệt";
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
            // m_cmd_khong_duyet
            // 
            this.m_cmd_khong_duyet.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_khong_duyet.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_khong_duyet.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_khong_duyet.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_khong_duyet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_khong_duyet.ImageIndex = 4;
            this.m_cmd_khong_duyet.ImageList = this.ImageList;
            this.m_cmd_khong_duyet.Location = new System.Drawing.Point(558, 4);
            this.m_cmd_khong_duyet.Name = "m_cmd_khong_duyet";
            this.m_cmd_khong_duyet.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_khong_duyet.TabIndex = 14;
            this.m_cmd_khong_duyet.Text = "&Không duyệt";
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
            this.m_grv_don_hang.Location = new System.Drawing.Point(0, 108);
            this.m_grv_don_hang.Name = "m_grv_don_hang";
            this.m_grv_don_hang.Size = new System.Drawing.Size(738, 343);
            this.m_grv_don_hang.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_grv_don_hang.Styles"));
            this.m_grv_don_hang.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cbo_trung_tam);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.m_lbl_tieu_de);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 102);
            this.panel1.TabIndex = 23;
            // 
            // m_cbo_trung_tam
            // 
            this.m_cbo_trung_tam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_trung_tam.FormattingEnabled = true;
            this.m_cbo_trung_tam.Location = new System.Drawing.Point(233, 47);
            this.m_cbo_trung_tam.Name = "m_cbo_trung_tam";
            this.m_cbo_trung_tam.Size = new System.Drawing.Size(299, 21);
            this.m_cbo_trung_tam.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Trung tâm";
            // 
            // m_lbl_tieu_de
            // 
            this.m_lbl_tieu_de.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_tieu_de.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_tieu_de.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_tieu_de.Name = "m_lbl_tieu_de";
            this.m_lbl_tieu_de.Size = new System.Drawing.Size(738, 32);
            this.m_lbl_tieu_de.TabIndex = 28;
            this.m_lbl_tieu_de.Text = "DUYỆT ĐƠN ĐẶT HÀNG";
            this.m_lbl_tieu_de.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // f538_TAD_DUYET_DON_HANG
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(738, 487);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_grv_don_hang);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f538_TAD_DUYET_DON_HANG";
            this.Text = "F538 - Duyệt đơn đặt hàng";
            this.Load += new System.EventHandler(this.f538_TAD_DUYET_DON_HANG_Load);
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
			TEN_PHONG_BAN = 3
		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_V_GD_DON_DAT_HANG_DINH_MUC m_ds = new DS_V_GD_DON_DAT_HANG_DINH_MUC();
		US_V_GD_DON_DAT_HANG_DINH_MUC m_us = new US_V_GD_DON_DAT_HANG_DINH_MUC();
		#endregion

		#region Private Methods
		private void format_controls(){
			CControlFormat.setFormStyle(this, new CAppContext_201());
            m_lbl_tieu_de.Font = new System.Drawing.Font("Tahoma", 15, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			CControlFormat.setC1FlexFormat(m_grv_don_hang);
			CGridUtils.AddSave_Excel_Handlers(m_grv_don_hang);
            CGridUtils.AddSearch_Handlers(m_grv_don_hang);
            load_data_2_cbo_trung_tam();
            m_cmd_duyet.Visible = true;
            m_cmd_duyet.Enabled = true;
            m_cmd_exit.Visible = true;
            m_cmd_exit.Enabled = true;
            m_cmd_khong_duyet.Visible = true;
            m_cmd_khong_duyet.Enabled = true;
			set_define_events();
			this.KeyPreview = true;		
		}
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_grv_don_hang);
			load_data_2_grid();		
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(V_GD_DON_DAT_HANG_DINH_MUC.TEN_PHONG_BAN, e_col_Number.TEN_PHONG_BAN);
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.V_GD_DON_DAT_HANG_DINH_MUC.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){	
			decimal v_dc_id_trung_tam=CIPConvert.ToDecimal(m_cbo_trung_tam.SelectedValue);		
			m_ds = new DS_V_GD_DON_DAT_HANG_DINH_MUC();
            m_us.FillDatasetSearch(m_ds, v_dc_id_trung_tam,CONST_ID_TRANG_THAI_DON_HANG.XIN_TAD_DUYET);
			m_grv_don_hang.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_grv_don_hang, m_obj_trans);
            CGridUtils.MakeSoTT(0, m_grv_don_hang);
			m_grv_don_hang.Redraw = true;
		}
		private void grid2us_object(US_V_GD_DON_DAT_HANG_DINH_MUC i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_grv_don_hang.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

	
		private void us_object2grid(US_V_GD_DON_DAT_HANG_DINH_MUC i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_grv_don_hang.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
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
		private void insert_v_gd_don_dat_hang_dinh_muc(){			
		//	f538_TAD_DUYET_DON_HANG_DE v_fDE = new  f538_TAD_DUYET_DON_HANG_DE();								
		//	v_fDE.display();
			load_data_2_grid();
		}

		private void duyet_v_gd_don_dat_hang_dinh_muc(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_don_hang)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_don_hang, m_grv_don_hang.Row)) return;			
			grid2us_object(m_us, m_grv_don_hang.Row);
		//	f538_TAD_DUYET_DON_HANG_DE v_fDE = new f538_TAD_DUYET_DON_HANG_DE();
		//	v_fDE.display(m_us);
            update_trang_thai(m_us, CONST_ID_TRANG_THAI_DON_HANG.DA_DUYET);
			load_data_2_grid();
		}
        private void khong_duyet_v_gd_don_dat_hang_dinh_muc()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_don_hang)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_don_hang, m_grv_don_hang.Row)) return;
            grid2us_object(m_us, m_grv_don_hang.Row);
            //	f538_TAD_DUYET_DON_HANG_DE v_fDE = new f538_TAD_DUYET_DON_HANG_DE();
            //	v_fDE.display(m_us);
            update_trang_thai(m_us, CONST_ID_TRANG_THAI_DON_HANG.NHAP);
            load_data_2_grid();
        }		
		private void delete_v_gd_don_dat_hang_dinh_muc(){
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_don_hang)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_don_hang, m_grv_don_hang.Row)) return;
			if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted)  return;
			US_V_GD_DON_DAT_HANG_DINH_MUC v_us = new US_V_GD_DON_DAT_HANG_DINH_MUC();
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

		private void view_v_gd_don_dat_hang_dinh_muc(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_don_hang)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_don_hang, m_grv_don_hang.Row)) return;
			grid2us_object(m_us, m_grv_don_hang.Row);
		//	f538_TAD_DUYET_DON_HANG_DE v_fDE = new f538_TAD_DUYET_DON_HANG_DE();			
		//	v_fDE.display(m_us);
		}
        private void update_trang_thai(US_V_GD_DON_DAT_HANG_DINH_MUC ip_us_v,decimal ip_id_trang_thai)
        {
            US_GD_DON_DAT_HANG v_us = new US_GD_DON_DAT_HANG();
            v_us.dcID = ip_us_v.dcID;
            v_us.datNGAY_DAT_HANG = ip_us_v.datNGAY_DAT_HANG;
            v_us.dcID_PHONG_BAN = ip_us_v.dcID_PHONG_BAN;
            v_us.dcGIA_TRI_CHUA_VAT = ip_us_v.dcGIA_TRI_CHUA_VAT;
            v_us.dcGIA_TRI_DA_VAT = ip_us_v.dcGIA_TRI_DA_VAT;
            v_us.dcLAN = ip_us_v.dcLAN_DAT_HANG;
            v_us.dcID_TRANG_THAI = ip_id_trang_thai;
            v_us.Update();
        }
		private void set_define_events(){
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
			m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
			m_cmd_duyet.Click += new EventHandler(m_cmd_duyet_Click);
			m_cmd_khong_duyet.Click += new EventHandler(m_cmd_khong_duyet_Click);
			m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
            m_cbo_trung_tam.SelectedIndexChanged+=new EventHandler(m_cbo_trung_tam_SelectedIndexChanged);
            this.KeyDown+=new KeyEventHandler(f538_TAD_DUYET_DON_HANG_KeyDown);
		}
		#endregion

//
		//
		//		EVENT HANLDERS
		//
		//
		private void f538_TAD_DUYET_DON_HANG_Load(object sender, System.EventArgs e) {
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
				insert_v_gd_don_dat_hang_dinh_muc();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

        private void m_cmd_duyet_Click(object sender, EventArgs e)
        {
			try{
				duyet_v_gd_don_dat_hang_dinh_muc();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_khong_duyet_Click(object sender, EventArgs e) {
			try{
                //delete_v_gd_don_dat_hang_dinh_muc();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_view_Click(object sender, EventArgs e) {
			try{
				view_v_gd_don_dat_hang_dinh_muc();
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
        private void f538_TAD_DUYET_DON_HANG_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
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
