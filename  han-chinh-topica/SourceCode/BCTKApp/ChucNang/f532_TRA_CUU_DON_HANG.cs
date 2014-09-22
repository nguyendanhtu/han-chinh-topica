///************************************************
/// Generated by: DungNT
/// Date: 12/08/2014 04:00:13
/// Goal: Create Form for V_GD_DON_DAT_HANG
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



	public class f532_TRA_CUU_DON_HANG : System.Windows.Forms.Form
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
        private Label label1;
        private Label label7;
        private Label m_lbl_tieu_de;
        internal SIS.Controls.Button.SiSButton m_cmd_search;
        private TCDatetime m_dtp_thang;
        private ToolTip toolTip1;
        private ComboBox m_cbo_phap_nhan;
        private Label label2;
        private TextBox m_txt_tu_khoa;
		private System.ComponentModel.IContainer components;

		public f532_TRA_CUU_DON_HANG()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f532_TRA_CUU_DON_HANG));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_xuat_excel = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_grv_don_hang = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cbo_phap_nhan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_dtp_thang = new BCTKApp.TCDatetime();
            this.m_cmd_search = new SIS.Controls.Button.SiSButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.m_lbl_tieu_de = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.m_txt_tu_khoa = new System.Windows.Forms.TextBox();
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
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 526);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(751, 36);
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
            this.m_cmd_insert.Location = new System.Drawing.Point(395, 4);
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
            this.m_cmd_update.Location = new System.Drawing.Point(483, 4);
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
            this.m_cmd_xuat_excel.Text = "Xem";
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
            this.m_cmd_delete.Location = new System.Drawing.Point(571, 4);
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
            this.m_cmd_exit.Location = new System.Drawing.Point(659, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_grv_don_hang
            // 
            this.m_grv_don_hang.ColumnInfo = resources.GetString("m_grv_don_hang.ColumnInfo");
            this.m_grv_don_hang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_grv_don_hang.Location = new System.Drawing.Point(0, 132);
            this.m_grv_don_hang.Name = "m_grv_don_hang";
            this.m_grv_don_hang.Size = new System.Drawing.Size(751, 394);
            this.m_grv_don_hang.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_grv_don_hang.Styles"));
            this.m_grv_don_hang.TabIndex = 20;
            this.toolTip1.SetToolTip(this.m_grv_don_hang, "Nhấp đúp chuột để xem chi tiết");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_txt_tu_khoa);
            this.panel1.Controls.Add(this.m_cbo_phap_nhan);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.m_dtp_thang);
            this.panel1.Controls.Add(this.m_cmd_search);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.m_lbl_tieu_de);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 126);
            this.panel1.TabIndex = 22;
            // 
            // m_cbo_phap_nhan
            // 
            this.m_cbo_phap_nhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_phap_nhan.FormattingEnabled = true;
            this.m_cbo_phap_nhan.Location = new System.Drawing.Point(463, 39);
            this.m_cbo_phap_nhan.Name = "m_cbo_phap_nhan";
            this.m_cbo_phap_nhan.Size = new System.Drawing.Size(122, 21);
            this.m_cbo_phap_nhan.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(379, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "Pháp nhân";
            // 
            // m_dtp_thang
            // 
            this.m_dtp_thang.Format = BCTKApp.TCDatetime.DinhDang.MM_yyyy;
            this.m_dtp_thang.Location = new System.Drawing.Point(244, 44);
            this.m_dtp_thang.Mask = "00/0000";
            this.m_dtp_thang.Name = "m_dtp_thang";
            this.m_dtp_thang.Size = new System.Drawing.Size(111, 20);
            this.m_dtp_thang.TabIndex = 48;
            this.m_dtp_thang.ValidatingType = typeof(System.DateTime);
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_search.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_search.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_search.ImageIndex = 18;
            this.m_cmd_search.ImageList = this.ImageList;
            this.m_cmd_search.Location = new System.Drawing.Point(606, 74);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_search.TabIndex = 39;
            this.m_cmd_search.Text = "Tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Trung tâm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(160, 45);
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
            this.m_lbl_tieu_de.Size = new System.Drawing.Size(751, 32);
            this.m_lbl_tieu_de.TabIndex = 28;
            this.m_lbl_tieu_de.Text = "TRA CỨU ĐƠN HÀNG THEO TỪNG TRUNG TÂM";
            this.m_lbl_tieu_de.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            // 
            // m_txt_tu_khoa
            // 
            this.m_txt_tu_khoa.Location = new System.Drawing.Point(244, 82);
            this.m_txt_tu_khoa.Name = "m_txt_tu_khoa";
            this.m_txt_tu_khoa.Size = new System.Drawing.Size(341, 20);
            this.m_txt_tu_khoa.TabIndex = 51;
            // 
            // f532_TRA_CUU_DON_HANG
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(751, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_grv_don_hang);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f532_TRA_CUU_DON_HANG";
            this.Text = "F532- Tra cứu đơn hàng theo từng trung tâm";
            this.Load += new System.EventHandler(this.f532_TRA_CUU_DON_HNAG_Load);
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
			GIA_TRI_CHUA_VAT = 6,TEN_PHONG_BAN = 1,LAN = 3,MA_HD = 4,NGAY_DAT_HANG = 2,GIA_TRI_DA_VAT = 7,TRANG_THAI = 5
		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_V_GD_DON_DAT_HANG m_ds = new DS_V_GD_DON_DAT_HANG();
		US_V_GD_DON_DAT_HANG m_us = new US_V_GD_DON_DAT_HANG();
        private const String m_str_goi_y = "Nhập mã ,tên trung tâm";
		#endregion

		#region Private Methods
		private void format_controls(){
			CControlFormat.setFormStyle(this, new CAppContext_201());
            m_lbl_tieu_de.Font = new System.Drawing.Font("Tahoma", 15, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			CControlFormat.setC1FlexFormat(m_grv_don_hang);
			CGridUtils.AddSave_Excel_Handlers(m_grv_don_hang);
            m_grv_don_hang.Tree.Column = (int)e_col_Number.NGAY_DAT_HANG;
            m_grv_don_hang.Cols[(int)e_col_Number.TEN_PHONG_BAN].Visible = false;
            m_grv_don_hang.Tree.Style = C1.Win.C1FlexGrid.TreeStyleFlags.ButtonBar;
            CGridUtils.AddSearch_Handlers(m_grv_don_hang);
            load_data_2_cbo_phap_nhan();
            m_cmd_exit.Visible = true;
            m_cmd_exit.Enabled = true;
            m_cmd_search.Visible = true;
            m_cmd_search.Enabled = true;
            set_search_tu_khoa_format_before();
			set_define_events();
			this.KeyPreview = true;		
		}
		private void set_initial_form_load(){
            m_dtp_thang.Text = DateTime.Now.Date.ToString("MM/yyyy");			
			m_obj_trans = get_trans_object(m_grv_don_hang);
			load_data_2_grid();		
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(V_GD_DON_DAT_HANG.GIA_TRI_CHUA_VAT, e_col_Number.GIA_TRI_CHUA_VAT);			v_htb.Add(V_GD_DON_DAT_HANG.TEN_PHONG_BAN, e_col_Number.TEN_PHONG_BAN);			v_htb.Add(V_GD_DON_DAT_HANG.LAN, e_col_Number.LAN);			v_htb.Add(V_GD_DON_DAT_HANG.MA_HD, e_col_Number.MA_HD);			v_htb.Add(V_GD_DON_DAT_HANG.NGAY_DAT_HANG, e_col_Number.NGAY_DAT_HANG);			v_htb.Add(V_GD_DON_DAT_HANG.GIA_TRI_DA_VAT, e_col_Number.GIA_TRI_DA_VAT);			v_htb.Add(V_GD_DON_DAT_HANG.TRANG_THAI, e_col_Number.TRANG_THAI);									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.V_GD_DON_DAT_HANG.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){
            DateTime temp = CIPConvert.ToDatetime("01/"+m_dtp_thang.Text);
            temp = temp.AddMonths(1);
            temp = temp.AddDays(-(temp.Day));
            DateTime v_dat_thang = temp;
            string v_str_tu_khoa = m_txt_tu_khoa.Text;
            if (v_str_tu_khoa == m_str_goi_y) v_str_tu_khoa = "";
            decimal v_dc_id_phap_nhan = CIPConvert.ToDecimal(m_cbo_phap_nhan.SelectedValue);	
			m_ds = new DS_V_GD_DON_DAT_HANG();
            m_us.FillDatasetSearch_phap_nhan(m_ds, v_dat_thang, v_dc_id_phap_nhan,CONST_ID_TRANG_THAI_DON_HANG.DA_DUYET,v_str_tu_khoa);
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
		private void grid2us_object(US_V_GD_DON_DAT_HANG i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_grv_don_hang.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

	
		private void us_object2grid(US_V_GD_DON_DAT_HANG i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_grv_don_hang.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}
        private void load_data_2_cbo_phap_nhan()
        {
            US_DM_PHAP_NHAN v_us = new US_DM_PHAP_NHAN();
            DS_DM_PHAP_NHAN v_ds = new DS_DM_PHAP_NHAN();
            v_us.FillDataset(v_ds);
            m_cbo_phap_nhan.DataSource = v_ds.DM_PHAP_NHAN;
            m_cbo_phap_nhan.ValueMember = DM_PHAP_NHAN.ID;
            m_cbo_phap_nhan.DisplayMember = DM_PHAP_NHAN.TEN_PHAP_NHAN;
            DataRow v_dr = v_ds.DM_PHAP_NHAN.NewRow();
            v_dr[DM_PHAP_NHAN.ID] = -1;
            v_dr[DM_PHAP_NHAN.MA_PHAP_NHAN] = "";
            v_dr[DM_PHAP_NHAN.TEN_PHAP_NHAN] = "Tất cả";
            v_dr[DM_PHAP_NHAN.GHI_CHU] = " ";
            v_ds.DM_PHAP_NHAN.Rows.InsertAt(v_dr, 0);
            m_cbo_phap_nhan.SelectedIndex = 0;
        }

		private void insert_v_gd_don_dat_hang(){			
		//	f532_TRA_CUU_DON_HNAG_DE v_fDE = new  f532_TRA_CUU_DON_HNAG_DE();								
		//	v_fDE.display();
			load_data_2_grid();
		}

		private void update_v_gd_don_dat_hang(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_don_hang)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_don_hang, m_grv_don_hang.Row)) return;			
			grid2us_object(m_us, m_grv_don_hang.Row);
		//	f532_TRA_CUU_DON_HNAG_DE v_fDE = new f532_TRA_CUU_DON_HNAG_DE();
		//	v_fDE.display(m_us);
			load_data_2_grid();
		}
				
		private void delete_v_gd_don_dat_hang(){
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_don_hang)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_don_hang, m_grv_don_hang.Row)) return;
			if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted)  return;
			US_V_GD_DON_DAT_HANG v_us = new US_V_GD_DON_DAT_HANG();
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

		private void view_v_gd_don_dat_hang(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_don_hang)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_don_hang, m_grv_don_hang.Row)) return;
			grid2us_object(m_us, m_grv_don_hang.Row);
		//	f532_TRA_CUU_DON_HNAG_DE v_fDE = new f532_TRA_CUU_DON_HNAG_DE();			
		//	v_fDE.display(m_us);
		}
        private void set_search_tu_khoa_format_before()
        {
            if (m_txt_tu_khoa.Text == "")
            {
                m_txt_tu_khoa.Text = m_str_goi_y;
                m_txt_tu_khoa.ForeColor = Color.Gray;
            }
        }
        private void set_search_tu_khoa_format_after()
        {
            if (m_txt_tu_khoa.Text == m_str_goi_y)
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
			m_cmd_xuat_excel.Click += new EventHandler(m_cmd_view_Click);
            m_cmd_search.Click+=new EventHandler(m_cmd_search_Click);
            //m_cbo_trung_tam.SelectedIndexChanged+=new EventHandler(m_cbo_trung_tam_SelectedIndexChanged);
            m_grv_don_hang.DoubleClick+=new EventHandler(m_grv_don_hang_DoubleClick);
            this.KeyDown+=new KeyEventHandler(f532_TRA_CUU_DON_HANG_KeyDown);
            m_txt_tu_khoa.KeyDown += new KeyEventHandler(m_txt_tu_khoa_KeyDown);
            m_txt_tu_khoa.Leave += new EventHandler(m_txt_tu_khoa_Leave);
            m_txt_tu_khoa.MouseClick += new MouseEventHandler(m_txt_tu_khoa_MouseClick);
		}
		#endregion

//
		//
		//		EVENT HANLDERS
		//
		//
		private void f532_TRA_CUU_DON_HNAG_Load(object sender, System.EventArgs e) {
			try{
				set_initial_form_load();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		
		}
        private void f532_TRA_CUU_DON_HANG_KeyDown(object sender, KeyEventArgs e)
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
				insert_v_gd_don_dat_hang();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_update_Click(object sender, EventArgs e) {
			try{
				update_v_gd_don_dat_hang();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_delete_Click(object sender, EventArgs e) {
			try{
				delete_v_gd_don_dat_hang();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_view_Click(object sender, EventArgs e) {
			try{
				view_v_gd_don_dat_hang();
			}
			catch (Exception v_e){
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
        private void m_grv_don_hang_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_don_hang)) return;
                if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_don_hang, m_grv_don_hang.Row)) return;
                US_V_GD_DON_DAT_HANG v_us = new US_V_GD_DON_DAT_HANG();
                grid2us_object(v_us, m_grv_don_hang.Row);
                f534_TRA_CUU_DON_HANG_DE v_frm = new f534_TRA_CUU_DON_HANG_DE();
                v_frm.display_for_chi_tiet(v_us);
            }
            catch (Exception v_e)
            {
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
                    set_search_tu_khoa_format_after();
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
                set_search_tu_khoa_format_after();
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
                set_search_tu_khoa_format_before();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

	}
}

