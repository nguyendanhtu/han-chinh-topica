///************************************************
/// Generated by: DungNT
/// Date: 12/07/2014 11:04:32
/// Goal: Create Form for V_DM_CO_SO
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



	public class f508_V_DM_CO_SO : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
		private C1.Win.C1FlexGrid.C1FlexGrid m_grv_dm_co_so;
		internal SIS.Controls.Button.SiSButton m_cmd_delete;
		internal SIS.Controls.Button.SiSButton m_cmd_update;
		internal SIS.Controls.Button.SiSButton m_cmd_insert;
		internal SIS.Controls.Button.SiSButton m_cmd_exit;
		internal SIS.Controls.Button.SiSButton m_cmd_view;
        private Panel panel1;
        internal SIS.Controls.Button.SiSButton m_cmd_search;
        private TextBox m_txt_tu_khoa;
        private Label label1;
        private Label m_lbl_tieu_de;
		private System.ComponentModel.IContainer components;

		public f508_V_DM_CO_SO()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f508_V_DM_CO_SO));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_grv_dm_co_so = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_txt_tu_khoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_lbl_tieu_de = new System.Windows.Forms.Label();
            this.m_cmd_search = new SIS.Controls.Button.SiSButton();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_view = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_co_so)).BeginInit();
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
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 373);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(686, 36);
            this.m_pnl_out_place_dm.TabIndex = 19;
            // 
            // m_grv_dm_co_so
            // 
            this.m_grv_dm_co_so.ColumnInfo = resources.GetString("m_grv_dm_co_so.ColumnInfo");
            this.m_grv_dm_co_so.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_grv_dm_co_so.Location = new System.Drawing.Point(0, 106);
            this.m_grv_dm_co_so.Name = "m_grv_dm_co_so";
            this.m_grv_dm_co_so.Size = new System.Drawing.Size(686, 267);
            this.m_grv_dm_co_so.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_grv_dm_co_so.Styles"));
            this.m_grv_dm_co_so.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_search);
            this.panel1.Controls.Add(this.m_txt_tu_khoa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.m_lbl_tieu_de);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 100);
            this.panel1.TabIndex = 24;
            // 
            // m_txt_tu_khoa
            // 
            this.m_txt_tu_khoa.Location = new System.Drawing.Point(245, 56);
            this.m_txt_tu_khoa.Name = "m_txt_tu_khoa";
            this.m_txt_tu_khoa.Size = new System.Drawing.Size(191, 20);
            this.m_txt_tu_khoa.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ khóa";
            // 
            // m_lbl_tieu_de
            // 
            this.m_lbl_tieu_de.AutoSize = true;
            this.m_lbl_tieu_de.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_tieu_de.Location = new System.Drawing.Point(275, 7);
            this.m_lbl_tieu_de.Name = "m_lbl_tieu_de";
            this.m_lbl_tieu_de.Size = new System.Drawing.Size(144, 19);
            this.m_lbl_tieu_de.TabIndex = 0;
            this.m_lbl_tieu_de.Text = "DANH MỤC CƠ SỞ";
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_search.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_search.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_search.ImageIndex = 18;
            this.m_cmd_search.ImageList = this.ImageList;
            this.m_cmd_search.Location = new System.Drawing.Point(461, 50);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_search.TabIndex = 22;
            this.m_cmd_search.Text = "Tìm kiếm";
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
            this.m_cmd_insert.Location = new System.Drawing.Point(330, 4);
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
            this.m_cmd_update.Location = new System.Drawing.Point(418, 4);
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
            this.m_cmd_view.Visible = false;
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
            this.m_cmd_delete.Location = new System.Drawing.Point(506, 4);
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
            this.m_cmd_exit.Location = new System.Drawing.Point(594, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // f508_V_DM_CO_SO
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(686, 409);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_grv_dm_co_so);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f508_V_DM_CO_SO";
            this.Text = "F508 - Danh mục cơ sở";
            this.Load += new System.EventHandler(this.f508_V_DM_CO_SO_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_co_so)).EndInit();
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
			MO_TA = 2,MA = 1,TEN_LOAI_CO_SO = 3
		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_V_DM_CO_SO m_ds = new DS_V_DM_CO_SO();
		US_V_DM_CO_SO m_us = new US_V_DM_CO_SO();
        private const String m_str_goi_y_tim_kiem = "Nhập tên cơ sở, mã cơ sở... ";
		#endregion

		#region Private Methods
		private void format_controls(){
			CControlFormat.setFormStyle(this, new CAppContext_201());
			CControlFormat.setC1FlexFormat(m_grv_dm_co_so);
            m_lbl_tieu_de.Font = new System.Drawing.Font("Tahoma", 15, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			CGridUtils.AddSave_Excel_Handlers(m_grv_dm_co_so);
            			CGridUtils.AddSearch_Handlers(m_grv_dm_co_so);
			set_define_events();
			this.KeyPreview = true;		
		}
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_grv_dm_co_so);
			load_data_2_grid();		
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(V_DM_CO_SO.MO_TA, e_col_Number.MO_TA);			v_htb.Add(V_DM_CO_SO.MA, e_col_Number.MA);			v_htb.Add(V_DM_CO_SO.TEN_LOAI_CO_SO, e_col_Number.TEN_LOAI_CO_SO);									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.V_DM_CO_SO.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){
            string v_str_tu_khoa = m_txt_tu_khoa.Text;
            if (v_str_tu_khoa == m_str_goi_y_tim_kiem) v_str_tu_khoa = "";
			m_ds = new DS_V_DM_CO_SO();			
			m_us.FillDatasetSearch(m_ds,v_str_tu_khoa);
			m_grv_dm_co_so.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_grv_dm_co_so, m_obj_trans);
            CGridUtils.MakeSoTT(0, m_grv_dm_co_so);
			m_grv_dm_co_so.Redraw = true;
            set_search_format_before();
		}
		private void grid2us_object(US_V_DM_CO_SO i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_grv_dm_co_so.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}
        private void dm_grid2us_object(US_DM_CO_SO i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_grv_dm_co_so.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }
	
		private void us_object2grid(US_V_DM_CO_SO i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_grv_dm_co_so.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}


		private void insert_v_dm_co_so(){
            f509_V_DM_CO_SO_DE v_fDE = new f509_V_DM_CO_SO_DE();
            v_fDE.display_for_insert();
			load_data_2_grid();
		}

		private void update_v_dm_co_so(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_dm_co_so)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_dm_co_so, m_grv_dm_co_so.Row)) return;			
			grid2us_object(m_us, m_grv_dm_co_so.Row);
            f509_V_DM_CO_SO_DE v_fDE = new f509_V_DM_CO_SO_DE();
            v_fDE.display_for_update(m_us);
			load_data_2_grid();
		}
				
		private void delete_v_dm_co_so(){
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_dm_co_so)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_dm_co_so, m_grv_dm_co_so.Row)) return;
			if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted)  return;
			US_DM_CO_SO v_us = new US_DM_CO_SO();
			dm_grid2us_object(v_us, m_grv_dm_co_so.Row);
			try {			
				v_us.BeginTransaction();    											
				v_us.Delete();                      								
				v_us.CommitTransaction();
				m_grv_dm_co_so.Rows.Remove(m_grv_dm_co_so.Row);				
			}
			catch (Exception v_e) {
				v_us.Rollback();
				CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
					new CDBClientDBExceptionInterpret());
				v_objErrHandler.showErrorMessage();
			}
		}

		private void view_v_dm_co_so(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_dm_co_so)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_dm_co_so, m_grv_dm_co_so.Row)) return;
			grid2us_object(m_us, m_grv_dm_co_so.Row);
		//	f508_V_DM_CO_SO_DE v_fDE = new f508_V_DM_CO_SO_DE();			
		//	v_fDE.display(m_us);
		}
        private void set_search_format_before()
        {
            if (m_txt_tu_khoa.Text == "")
            {
                m_txt_tu_khoa.Text = m_str_goi_y_tim_kiem;
                m_txt_tu_khoa.ForeColor = Color.Gray;
            }
        }
        private void set_search_format_after()
        {
            if (m_txt_tu_khoa.Text == m_str_goi_y_tim_kiem)
            {
                m_txt_tu_khoa.Text = "";
            }
            m_txt_tu_khoa.ForeColor = Color.Black;
        }
		private void set_define_events(){
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
			m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
			m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
			m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
			m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
            m_txt_tu_khoa.KeyDown+=new KeyEventHandler(m_txt_tu_khoa_KeyDown);
            m_txt_tu_khoa.Leave+=new EventHandler(m_txt_tu_khoa_Leave);
            m_txt_tu_khoa.MouseClick+=new MouseEventHandler(m_txt_tu_khoa_MouseClick);
            m_grv_dm_co_so.DoubleClick+=new EventHandler(m_grv_dm_co_so_DoubleClick);
		}
		#endregion

//
		//
		//		EVENT HANLDERS
		//
		//
		private void f508_V_DM_CO_SO_Load(object sender, System.EventArgs e) {
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
				insert_v_dm_co_so();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_update_Click(object sender, EventArgs e) {
			try{
				update_v_dm_co_so();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_delete_Click(object sender, EventArgs e) {
			try{
				delete_v_dm_co_so();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_view_Click(object sender, EventArgs e) {
			try{
				view_v_dm_co_so();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}
        private void m_txt_tu_khoa_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    load_data_2_grid();
                }
                else
                {
                    set_search_format_after();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_txt_tu_khoa_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                set_search_format_after();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_txt_tu_khoa_Leave(object sender, EventArgs e)
        {
            try
            {
                set_search_format_before();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_grv_dm_co_so_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                update_v_dm_co_so();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

	}
}

