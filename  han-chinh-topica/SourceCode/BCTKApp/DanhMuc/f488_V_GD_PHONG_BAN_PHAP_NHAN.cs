///************************************************
/// Generated by: HuyTD
/// Date: 13/07/2014 02:22:46
/// Goal: Create Form for V_DM_PHONG_BAN_PHAP_NHAN
///************************************************


using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
//using IP.Core.IPData;
using IP.Core.IPUserService;
using IP.Core.IPSystemAdmin;

using BCTKUS;
using BCTKDS;
using BCTKDS.CDBNames;
using BCTKApp.DanhMuc;

using C1.Win.C1FlexGrid;

namespace BCTKApp
{



	public class f488_V_GD_PHONG_BAN_PHAP_NHAN : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
		private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
		internal SIS.Controls.Button.SiSButton m_cmd_delete;
		internal SIS.Controls.Button.SiSButton m_cmd_update;
		internal SIS.Controls.Button.SiSButton m_cmd_insert;
		internal SIS.Controls.Button.SiSButton m_cmd_exit;
		internal SIS.Controls.Button.SiSButton m_cmd_view;
        private Label m_lbl_header;
        private ComboBox m_cbo_phap_nhan;
        private Label m_lbl_ten_phap_nhan;
        private Label m_lbl_tu_khoa;
        private TextBox m_txt_tim_kiem;
        private ComboBox m_cbo_trung_tam;
        private Label label1;
		private System.ComponentModel.IContainer components;

		public f488_V_GD_PHONG_BAN_PHAP_NHAN()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f488_V_GD_PHONG_BAN_PHAP_NHAN));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_view = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.m_cbo_phap_nhan = new System.Windows.Forms.ComboBox();
            this.m_lbl_ten_phap_nhan = new System.Windows.Forms.Label();
            this.m_lbl_tu_khoa = new System.Windows.Forms.Label();
            this.m_txt_tim_kiem = new System.Windows.Forms.TextBox();
            this.m_cbo_trung_tam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_view);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 380);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(695, 36);
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
            this.m_cmd_insert.Location = new System.Drawing.Point(339, 4);
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
            this.m_cmd_update.Location = new System.Drawing.Point(427, 4);
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
            this.m_cmd_delete.Location = new System.Drawing.Point(515, 4);
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
            this.m_cmd_exit.Location = new System.Drawing.Point(603, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_fg.Location = new System.Drawing.Point(0, 108);
            this.m_fg.Name = "m_fg";
            this.m_fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.m_fg.Size = new System.Drawing.Size(695, 272);
            this.m_fg.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
            this.m_fg.TabIndex = 20;
            this.m_fg.DoubleClick += new System.EventHandler(this.m_fg_DoubleClick);
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.AutoSize = true;
            this.m_lbl_header.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(103, 9);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(516, 22);
            this.m_lbl_header.TabIndex = 21;
            this.m_lbl_header.Text = "TỶ TRỌNG ĐỊNH MỨC TRUNG TÂM THEO PHÁP NHÂN";
            // 
            // m_cbo_phap_nhan
            // 
            this.m_cbo_phap_nhan.FormattingEnabled = true;
            this.m_cbo_phap_nhan.Location = new System.Drawing.Point(570, 42);
            this.m_cbo_phap_nhan.Name = "m_cbo_phap_nhan";
            this.m_cbo_phap_nhan.Size = new System.Drawing.Size(84, 21);
            this.m_cbo_phap_nhan.TabIndex = 22;
            this.m_cbo_phap_nhan.Visible = false;
            // 
            // m_lbl_ten_phap_nhan
            // 
            this.m_lbl_ten_phap_nhan.AutoSize = true;
            this.m_lbl_ten_phap_nhan.Location = new System.Drawing.Point(505, 42);
            this.m_lbl_ten_phap_nhan.Name = "m_lbl_ten_phap_nhan";
            this.m_lbl_ten_phap_nhan.Size = new System.Drawing.Size(59, 13);
            this.m_lbl_ten_phap_nhan.TabIndex = 23;
            this.m_lbl_ten_phap_nhan.Text = "Pháp nhân";
            this.m_lbl_ten_phap_nhan.Visible = false;
            // 
            // m_lbl_tu_khoa
            // 
            this.m_lbl_tu_khoa.AutoSize = true;
            this.m_lbl_tu_khoa.Location = new System.Drawing.Point(147, 75);
            this.m_lbl_tu_khoa.Name = "m_lbl_tu_khoa";
            this.m_lbl_tu_khoa.Size = new System.Drawing.Size(47, 13);
            this.m_lbl_tu_khoa.TabIndex = 23;
            this.m_lbl_tu_khoa.Text = "Từ khóa";
            // 
            // m_txt_tim_kiem
            // 
            this.m_txt_tim_kiem.Location = new System.Drawing.Point(221, 72);
            this.m_txt_tim_kiem.Name = "m_txt_tim_kiem";
            this.m_txt_tim_kiem.Size = new System.Drawing.Size(272, 20);
            this.m_txt_tim_kiem.TabIndex = 24;
            // 
            // m_cbo_trung_tam
            // 
            this.m_cbo_trung_tam.FormattingEnabled = true;
            this.m_cbo_trung_tam.Location = new System.Drawing.Point(221, 42);
            this.m_cbo_trung_tam.Name = "m_cbo_trung_tam";
            this.m_cbo_trung_tam.Size = new System.Drawing.Size(272, 21);
            this.m_cbo_trung_tam.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Trung tâm";
            // 
            // f488_V_GD_PHONG_BAN_PHAP_NHAN
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(695, 416);
            this.Controls.Add(this.m_txt_tim_kiem);
            this.Controls.Add(this.m_lbl_tu_khoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_lbl_ten_phap_nhan);
            this.Controls.Add(this.m_cbo_trung_tam);
            this.Controls.Add(this.m_cbo_phap_nhan);
            this.Controls.Add(this.m_lbl_header);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f488_V_GD_PHONG_BAN_PHAP_NHAN";
            this.Text = "F488- Tỷ trọng định mức trung tâm theo pháp nhân";
            this.Load += new System.EventHandler(this.frm_V_GD_PHONG_BAN_PHAP_NHAN_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f488_V_GD_PHONG_BAN_PHAP_NHAN_KeyDown);
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
			TY_TRONG = 5
,TEN_PHONG_BAN = 2
,ID_PHONG_BAN = 1
,MA_PHAP_NHAN = 7
,MA_PHONG_BAN = 3
,ID_PHAP_NHAN = 6
,TEN_PHAP_NHAN = 4

		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_V_DM_PHONG_BAN_PHAP_NHAN m_ds = new DS_V_DM_PHONG_BAN_PHAP_NHAN();
        US_V_DM_PHONG_BAN_PHAP_NHAN m_us = new US_V_DM_PHONG_BAN_PHAP_NHAN();
        bool flag = false;
		#endregion

		#region Private Methods
		private void format_controls(){
			CControlFormat.setFormStyle(this, new CAppContext_201());
            // m_lbl_header
            // 
            this.m_lbl_header.AutoSize = true;
            this.m_lbl_header.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(103, 9);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(516, 22);
            this.m_lbl_header.TabIndex = 21;
            this.m_lbl_header.Text = "TỶ TRỌNG ĐỊNH MỨC TRUNG TÂM THEO PHÁP NHÂN";
            //
			CControlFormat.setC1FlexFormat(m_fg);
			CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            m_fg.Tree.Column = (int)e_col_Number.TEN_PHONG_BAN;
            m_fg.Cols[(int)e_col_Number.TEN_PHAP_NHAN].Visible = true;
            m_fg.Cols[0].Caption = "STT";
            m_fg.Tree.Style = C1.Win.C1FlexGrid.TreeStyleFlags.ButtonBar;
			set_define_events();
			this.KeyPreview = true;
            load_cbo_phap_nhan();
            load_cbo_trung_tam();
		}
        private void load_cbo_phap_nhan()
        {
            flag = false;
            US_DM_PHAP_NHAN v_us = new US_DM_PHAP_NHAN();
            DS_DM_PHAP_NHAN v_ds = new DS_DM_PHAP_NHAN();
            v_us.FillDataset(v_ds);
            m_cbo_phap_nhan.DataSource = v_ds.DM_PHAP_NHAN;
            m_cbo_phap_nhan.ValueMember = DM_PHAP_NHAN.ID;
            m_cbo_phap_nhan.DisplayMember = DM_PHAP_NHAN.TEN_PHAP_NHAN;
            DataRow v_dr = v_ds.Tables[0].NewRow();
            v_dr[DM_PHAP_NHAN.ID] = -1;
            v_dr[DM_PHAP_NHAN.MA_PHAP_NHAN] = "";
            v_dr[DM_PHAP_NHAN.TEN_PHAP_NHAN] = "Tất cả";
            v_ds.DM_PHAP_NHAN.Rows.InsertAt(v_dr, 0);
            m_cbo_phap_nhan.SelectedIndex = 0;
            flag = true;
        }
        private void load_cbo_trung_tam()
        {
            flag = false;
            US_DM_PHONG_BAN v_us = new US_DM_PHONG_BAN();
            DS_DM_PHONG_BAN v_ds = new DS_DM_PHONG_BAN();
            v_us.FillDataset(v_ds);
            m_cbo_trung_tam.DataSource = v_ds.DM_PHONG_BAN;
            m_cbo_trung_tam.ValueMember = DM_PHONG_BAN.ID;
            m_cbo_trung_tam.DisplayMember = DM_PHONG_BAN.TEN_PHONG_BAN;
            DataRow v_dr = v_ds.DM_PHONG_BAN.NewRow();
            v_dr[DM_PHONG_BAN.ID] = -1;
            v_dr[DM_PHONG_BAN.MA_PHONG_BAN] = "Tất cả";
            v_dr[DM_PHONG_BAN.TEN_PHONG_BAN] = "Tất cả";
            v_ds.DM_PHONG_BAN.Rows.InsertAt(v_dr, 0);
            m_cbo_trung_tam.SelectedIndex = 0;
            flag = true;
        }
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_fg);
			load_data_2_grid();		
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(V_DM_PHONG_BAN_PHAP_NHAN.TY_TRONG, e_col_Number.TY_TRONG);
			v_htb.Add(V_DM_PHONG_BAN_PHAP_NHAN.TEN_PHONG_BAN, e_col_Number.TEN_PHONG_BAN);
			v_htb.Add(V_DM_PHONG_BAN_PHAP_NHAN.ID_PHONG_BAN, e_col_Number.ID_PHONG_BAN);
			v_htb.Add(V_DM_PHONG_BAN_PHAP_NHAN.MA_PHAP_NHAN, e_col_Number.MA_PHAP_NHAN);
			v_htb.Add(V_DM_PHONG_BAN_PHAP_NHAN.MA_PHONG_BAN, e_col_Number.MA_PHONG_BAN);
			v_htb.Add(V_DM_PHONG_BAN_PHAP_NHAN.ID_PHAP_NHAN, e_col_Number.ID_PHAP_NHAN);
			v_htb.Add(V_DM_PHONG_BAN_PHAP_NHAN.TEN_PHAP_NHAN, e_col_Number.TEN_PHAP_NHAN);
									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.v_DM_PHONG_BAN_PHAP_NHAN.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){						
			m_ds = new DS_V_DM_PHONG_BAN_PHAP_NHAN();			
			m_us.FillDataset(m_ds);
			m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            CGridUtils.MakeSoTT(0, m_fg);
            m_fg.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Count // chỗ này dùng hàm count tức là để đếm, có thể dùng các hàm khác thay thế
            , 0
            , (int)e_col_Number.TEN_PHONG_BAN // chỗ này là tên trường mà mình nhóm
            , (int)e_col_Number.TEN_PHAP_NHAN // chỗ này là tên trường mà mình Count
            , "{0}"
            );
            m_fg.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum
               , 0
               , (int)e_col_Number.TEN_PHONG_BAN
               , (int)e_col_Number.TY_TRONG
               , "{0}"
               );
			m_fg.Redraw = true;
            m_fg.Tree.Show(0);
		}
        private void tim_kiem()
        {
            decimal v_id_phap_nhan = CIPConvert.ToDecimal(m_cbo_phap_nhan.SelectedValue);
            string v_str_tu_khoa = m_txt_tim_kiem.Text.Trim();
            decimal v_id_trung_tam = CIPConvert.ToDecimal(m_cbo_trung_tam.SelectedValue);
            m_ds = new DS_V_DM_PHONG_BAN_PHAP_NHAN();
            m_us.FillDataset(m_ds, v_id_phap_nhan, v_str_tu_khoa, v_id_trung_tam);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            CGridUtils.MakeSoTT(0, m_fg);
            m_fg.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Count // chỗ này dùng hàm count tức là để đếm, có thể dùng các hàm khác thay thế
            , 0
            , (int)e_col_Number.TEN_PHONG_BAN // chỗ này là tên trường mà mình nhóm
            , (int)e_col_Number.TEN_PHAP_NHAN // chỗ này là tên trường mà mình Count
            , "{0}"
            );
            m_fg.Redraw = true;
        }
		private void grid2us_object(US_V_DM_PHONG_BAN_PHAP_NHAN i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

	
		private void us_object2grid(US_V_DM_PHONG_BAN_PHAP_NHAN i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}


		private void insert_v_dm_phong_ban_phap_nhan(){
            f489_V_DM_PHONG_BAN_PHAP_NHAN_DE v_fDE = new f489_V_DM_PHONG_BAN_PHAP_NHAN_DE();
            v_fDE.Display();
			load_data_2_grid();
		}

		private void update_v_dm_phong_ban_phap_nhan(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (m_fg.Rows[m_fg.Row].IsNode) return;
			grid2us_object(m_us, m_fg.Row);
            f489_V_DM_PHONG_BAN_PHAP_NHAN_DE v_fDE = new f489_V_DM_PHONG_BAN_PHAP_NHAN_DE();
            v_fDE.display(m_us);
			load_data_2_grid();
		}
				
		private void delete_v_dm_phong_ban_phap_nhan(){
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (m_fg.Rows[m_fg.Row].IsNode) return;
			if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted)  return;
			US_V_DM_PHONG_BAN_PHAP_NHAN v_us = new US_V_DM_PHONG_BAN_PHAP_NHAN();
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

		private void view_v_dm_phong_ban_phap_nhan(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			grid2us_object(m_us, m_fg.Row);
		//	frm_V_GD_PHONG_BAN_PHAP_NHAN_DE v_fDE = new frm_V_GD_PHONG_BAN_PHAP_NHAN_DE();			
		//	v_fDE.display(m_us);
		}
		private void set_define_events(){
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
			m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
			m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
			m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
			m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
            m_cbo_phap_nhan.SelectedValueChanged += new EventHandler(m_cbo_phap_nhan_SelectedValueChanged);
            m_txt_tim_kiem.TextChanged += new EventHandler(m_txt_tim_kiem_TextChanged);
            m_cbo_trung_tam.SelectedValueChanged += new EventHandler(m_cbo_trung_tam_SelectedValueChanged);
		}
		#endregion

        #region Event
        private void frm_V_GD_PHONG_BAN_PHAP_NHAN_Load(object sender, System.EventArgs e) {
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
				insert_v_dm_phong_ban_phap_nhan();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_update_Click(object sender, EventArgs e) {
			try{
				update_v_dm_phong_ban_phap_nhan();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_delete_Click(object sender, EventArgs e) {
			try{
				delete_v_dm_phong_ban_phap_nhan();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_view_Click(object sender, EventArgs e) {
			try{
				view_v_dm_phong_ban_phap_nhan();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}
        private void m_cbo_phap_nhan_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if(flag == true)
                tim_kiem();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_txt_tim_kiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tim_kiem();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            } 
        }
        private void m_cbo_trung_tam_SelectedValueChanged(object sender, EventArgs e)
        {
               try
            {
                if(flag == true)
                tim_kiem();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_fg_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                update_v_dm_phong_ban_phap_nhan();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void f488_V_GD_PHONG_BAN_PHAP_NHAN_KeyDown(object sender, KeyEventArgs e)
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

        #endregion

    }
}

