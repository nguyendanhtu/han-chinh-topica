///************************************************
/// Generated by: DungNT
/// Date: 30/06/2014 08:47:26
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
//using IP.Core.IPData;
//using IP.Core.IPUserService;
using IP.Core.IPSystemAdmin;

using BCTKUS;
using BCTKDS;
using BCTKDS.CDBNames;

using C1.Win.C1FlexGrid;
using IP.Core.IPExcelReport;

namespace BCTKApp
{



	public class f511_TRA_CUU_TRANG_THAI_CPN : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private C1.Win.C1FlexGrid.C1FlexGrid m_grv_trang_thai;
		internal SIS.Controls.Button.SiSButton m_cmd_exit;
		internal SIS.Controls.Button.SiSButton m_cmd_xuat_excel;
        private Panel m_pnl_top;
        private DateTimePicker m_dtp_den_ngay;
        private DateTimePicker m_dtp_tu_ngay;
        private Label label6;
        private Label label7;
        private Label label3;
        private Label label4;
        private Label m_lbl_tieu_de;
        private ComboBox m_cbo_trang_thai;
        private Label label8;
        internal SIS.Controls.Button.SiSButton m_cmd_search;
        private Label label1;
        private TextBox m_txt_so_bill;
        private Label label2;
        private ComboBox m_cbo_trung_tam;
		private System.ComponentModel.IContainer components;

		public f511_TRA_CUU_TRANG_THAI_CPN()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f511_TRA_CUU_TRANG_THAI_CPN));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_xuat_excel = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_grv_trang_thai = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_pnl_top = new System.Windows.Forms.Panel();
            this.m_cbo_trung_tam = new System.Windows.Forms.ComboBox();
            this.m_cbo_trang_thai = new System.Windows.Forms.ComboBox();
            this.m_dtp_den_ngay = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.m_cmd_search = new SIS.Controls.Button.SiSButton();
            this.m_dtp_tu_ngay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.m_txt_so_bill = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_lbl_tieu_de = new System.Windows.Forms.Label();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_trang_thai)).BeginInit();
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
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_xuat_excel);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 526);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(884, 36);
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
            this.m_cmd_xuat_excel.TabIndex = 10;
            this.m_cmd_xuat_excel.Text = "Xuất Excel";
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
            // m_grv_trang_thai
            // 
            this.m_grv_trang_thai.ColumnInfo = resources.GetString("m_grv_trang_thai.ColumnInfo");
            this.m_grv_trang_thai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_grv_trang_thai.Location = new System.Drawing.Point(0, 196);
            this.m_grv_trang_thai.Name = "m_grv_trang_thai";
            this.m_grv_trang_thai.Size = new System.Drawing.Size(884, 330);
            this.m_grv_trang_thai.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_grv_trang_thai.Styles"));
            this.m_grv_trang_thai.TabIndex = 20;
            // 
            // m_pnl_top
            // 
            this.m_pnl_top.Controls.Add(this.m_cbo_trung_tam);
            this.m_pnl_top.Controls.Add(this.m_cbo_trang_thai);
            this.m_pnl_top.Controls.Add(this.m_dtp_den_ngay);
            this.m_pnl_top.Controls.Add(this.label8);
            this.m_pnl_top.Controls.Add(this.m_cmd_search);
            this.m_pnl_top.Controls.Add(this.m_dtp_tu_ngay);
            this.m_pnl_top.Controls.Add(this.label1);
            this.m_pnl_top.Controls.Add(this.label6);
            this.m_pnl_top.Controls.Add(this.m_txt_so_bill);
            this.m_pnl_top.Controls.Add(this.label7);
            this.m_pnl_top.Controls.Add(this.label2);
            this.m_pnl_top.Controls.Add(this.label3);
            this.m_pnl_top.Controls.Add(this.label4);
            this.m_pnl_top.Controls.Add(this.m_lbl_tieu_de);
            this.m_pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_pnl_top.Location = new System.Drawing.Point(0, 0);
            this.m_pnl_top.Name = "m_pnl_top";
            this.m_pnl_top.Size = new System.Drawing.Size(884, 190);
            this.m_pnl_top.TabIndex = 21;
            // 
            // m_cbo_trung_tam
            // 
            this.m_cbo_trung_tam.FormattingEnabled = true;
            this.m_cbo_trung_tam.Location = new System.Drawing.Point(317, 80);
            this.m_cbo_trung_tam.Name = "m_cbo_trung_tam";
            this.m_cbo_trung_tam.Size = new System.Drawing.Size(207, 21);
            this.m_cbo_trung_tam.TabIndex = 34;
            // 
            // m_cbo_trang_thai
            // 
            this.m_cbo_trang_thai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.m_cbo_trang_thai.FormattingEnabled = true;
            this.m_cbo_trang_thai.Location = new System.Drawing.Point(317, 117);
            this.m_cbo_trang_thai.Name = "m_cbo_trang_thai";
            this.m_cbo_trang_thai.Size = new System.Drawing.Size(207, 21);
            this.m_cbo_trang_thai.TabIndex = 4;
            // 
            // m_dtp_den_ngay
            // 
            this.m_dtp_den_ngay.Checked = false;
            this.m_dtp_den_ngay.CustomFormat = "dd/MM/yyyy";
            this.m_dtp_den_ngay.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_dtp_den_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dtp_den_ngay.Location = new System.Drawing.Point(542, 46);
            this.m_dtp_den_ngay.Name = "m_dtp_den_ngay";
            this.m_dtp_den_ngay.RightToLeftLayout = true;
            this.m_dtp_den_ngay.ShowCheckBox = true;
            this.m_dtp_den_ngay.Size = new System.Drawing.Size(126, 23);
            this.m_dtp_den_ngay.TabIndex = 2;
            this.m_dtp_den_ngay.Value = new System.DateTime(2014, 6, 30, 9, 16, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(239, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Trạng thái";
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_search.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_search.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_search.ImageIndex = 18;
            this.m_cmd_search.ImageList = this.ImageList;
            this.m_cmd_search.Location = new System.Drawing.Point(551, 144);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_search.TabIndex = 6;
            this.m_cmd_search.Text = "Tìm kiếm";
            // 
            // m_dtp_tu_ngay
            // 
            this.m_dtp_tu_ngay.Checked = false;
            this.m_dtp_tu_ngay.CustomFormat = "dd/MM/yyyy";
            this.m_dtp_tu_ngay.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_dtp_tu_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dtp_tu_ngay.Location = new System.Drawing.Point(317, 46);
            this.m_dtp_tu_ngay.Name = "m_dtp_tu_ngay";
            this.m_dtp_tu_ngay.ShowCheckBox = true;
            this.m_dtp_tu_ngay.Size = new System.Drawing.Size(126, 23);
            this.m_dtp_tu_ngay.TabIndex = 1;
            this.m_dtp_tu_ngay.Value = new System.DateTime(2014, 1, 30, 9, 16, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Từ khóa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(462, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Đến ngày";
            // 
            // m_txt_so_bill
            // 
            this.m_txt_so_bill.Location = new System.Drawing.Point(317, 152);
            this.m_txt_so_bill.Name = "m_txt_so_bill";
            this.m_txt_so_bill.Size = new System.Drawing.Size(207, 20);
            this.m_txt_so_bill.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(239, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Từ ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Phòng ban";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 28;
            // 
            // m_lbl_tieu_de
            // 
            this.m_lbl_tieu_de.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_tieu_de.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_tieu_de.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_tieu_de.Name = "m_lbl_tieu_de";
            this.m_lbl_tieu_de.Size = new System.Drawing.Size(884, 32);
            this.m_lbl_tieu_de.TabIndex = 27;
            this.m_lbl_tieu_de.Text = "TRA CỨU TRẠNG THÁI CPN";
            this.m_lbl_tieu_de.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // f511_TRA_CUU_TRANG_THAI_CPN
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.m_pnl_top);
            this.Controls.Add(this.m_grv_trang_thai);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f511_TRA_CUU_TRANG_THAI_CPN";
            this.Text = "F511-Tra cứu trạng thái CPN";
            this.Load += new System.EventHandler(this.f511_TRA_CUU_TRANG_THAI_CPN_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_trang_thai)).EndInit();
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
			NUOC_NGOAI = 10,TEN_PHONG_BAN = 1,SO_BILL = 4,GHI_CHU = 12,NOI_NHAN = 8,NGUOI_NHAN = 7,SO_TIEN = 5,TRONG_NUOC = 9,NOI_DUNG = 6,NGUOI_GUI = 11,TRANG_THAI_THU = 2,NGAY_GUI = 3
		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_V_DM_BILL m_ds = new DS_V_DM_BILL();
		US_V_DM_BILL m_us = new US_V_DM_BILL();
        private const String m_str_goi_y_phong_ban = "Nhập Tên đơn vị...";
        private const String m_str_goi_y_so_bill = "Nhập Số bill hoặc tên người gửi, người nhận...";
		#endregion

		#region Private Methods
		private void format_controls(){
			CControlFormat.setFormStyle(this, new CAppContext_201());
			CControlFormat.setC1FlexFormat(m_grv_trang_thai);
            m_lbl_tieu_de.Font = new System.Drawing.Font("Tahoma", 15, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			CGridUtils.AddSave_Excel_Handlers(m_grv_trang_thai);
            CGridUtils.AddSearch_Handlers(m_grv_trang_thai);
            m_grv_trang_thai.Tree.Column = (int)e_col_Number.TRANG_THAI_THU;
            m_grv_trang_thai.Cols[(int)e_col_Number.TEN_PHONG_BAN].Visible = false;
            m_grv_trang_thai.Cols[0].Caption = "STT";
            m_grv_trang_thai.Tree.Style = C1.Win.C1FlexGrid.TreeStyleFlags.ButtonBar;
            load_data_2_cbo();
            load_data_2_cbo_trung_tam();
			set_define_events();
            set_search_so_bill_format_before();
			this.KeyPreview = true;		
		}
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_grv_trang_thai);
			load_data_2_grid();		
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(V_DM_BILL.NUOC_NGOAI, e_col_Number.NUOC_NGOAI);			v_htb.Add(V_DM_BILL.TEN_PHONG_BAN, e_col_Number.TEN_PHONG_BAN);			v_htb.Add(V_DM_BILL.SO_BILL, e_col_Number.SO_BILL);			v_htb.Add(V_DM_BILL.GHI_CHU, e_col_Number.GHI_CHU);			v_htb.Add(V_DM_BILL.NOI_NHAN, e_col_Number.NOI_NHAN);			v_htb.Add(V_DM_BILL.NGUOI_NHAN, e_col_Number.NGUOI_NHAN);			v_htb.Add(V_DM_BILL.SO_TIEN, e_col_Number.SO_TIEN);			v_htb.Add(V_DM_BILL.TRONG_NUOC, e_col_Number.TRONG_NUOC);			v_htb.Add(V_DM_BILL.NOI_DUNG, e_col_Number.NOI_DUNG);			v_htb.Add(V_DM_BILL.NGUOI_GUI, e_col_Number.NGUOI_GUI);			v_htb.Add(V_DM_BILL.TRANG_THAI_THU, e_col_Number.TRANG_THAI_THU);			v_htb.Add(V_DM_BILL.NGAY_GUI, e_col_Number.NGAY_GUI);									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.V_DM_BILL.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){
            //string v_str_phong_ban = m_txt_phong_ban.Text;
            string v_str_so_bill = m_txt_so_bill.Text;
            decimal v_dc_id_phong_ban = CIPConvert.ToDecimal(m_cbo_trung_tam.SelectedValue);
            if (v_str_so_bill == m_str_goi_y_so_bill) v_str_so_bill = "";
            decimal v_dc_id_trang_thai = CIPConvert.ToDecimal(m_cbo_trang_thai.SelectedValue);
            DateTime v_dat_tu_ngay = m_dtp_tu_ngay.Value;
            DateTime v_dat_den_ngay = m_dtp_den_ngay.Value;
            if (m_dtp_den_ngay.Checked == false) v_dat_den_ngay = DateTime.Now.Date;		
			m_ds = new DS_V_DM_BILL();			
			m_us.FillDatasetSearch(m_ds,v_dc_id_phong_ban,v_str_so_bill,v_dc_id_trang_thai,v_dat_tu_ngay,v_dat_den_ngay);
			m_grv_trang_thai.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_grv_trang_thai, m_obj_trans);
            CGridUtils.MakeSoTT(0, m_grv_trang_thai);
            m_grv_trang_thai.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Count // chỗ này dùng hàm count tức là để đếm, có thể dùng các hàm khác thay thế
              , 0
              , (int)e_col_Number.TEN_PHONG_BAN // chỗ này là tên trường mà mình nhóm
              , (int)e_col_Number.SO_BILL // chỗ này là tên trường mà mình Count
              , "{0}"
              );
			m_grv_trang_thai.Redraw = true;
		}
		private void grid2us_object(US_V_DM_BILL i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_grv_trang_thai.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

	
		private void us_object2grid(US_V_DM_BILL i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_grv_trang_thai.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}

        private void load_data_2_cbo()
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            v_us.FillDataset(v_ds, "Where id_loai_tu_dien = 12");
            m_cbo_trang_thai.DataSource = v_ds.CM_DM_TU_DIEN;
            m_cbo_trang_thai.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_trang_thai.DisplayMember = CM_DM_TU_DIEN.TEN;

            DataRow v_dr = v_ds.CM_DM_TU_DIEN.NewRow();
            v_dr[CM_DM_TU_DIEN.ID] = -1;
            v_dr[CM_DM_TU_DIEN.ID_LOAI_TU_DIEN] = -1;
            v_dr[CM_DM_TU_DIEN.MA_TU_DIEN] = "TAT_CA";
            v_dr[CM_DM_TU_DIEN.TEN] = "-------Tất cả------";
            v_dr[CM_DM_TU_DIEN.TEN_NGAN] = "-------Tất cả------";
            v_dr[CM_DM_TU_DIEN.GHI_CHU] = "";
            v_ds.CM_DM_TU_DIEN.Rows.InsertAt(v_dr, 0);
            m_cbo_trang_thai.SelectedIndex = 0;

        }
		private void insert_v_dm_bill(){			
		//	f511_TRA_CUU_TRANG_THAI_CPN_DE v_fDE = new  f511_TRA_CUU_TRANG_THAI_CPN_DE();								
		//	v_fDE.display();
			load_data_2_grid();
		}

		private void update_v_dm_bill(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_trang_thai)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_trang_thai, m_grv_trang_thai.Row)) return;			
			grid2us_object(m_us, m_grv_trang_thai.Row);
		//	f511_TRA_CUU_TRANG_THAI_CPN_DE v_fDE = new f511_TRA_CUU_TRANG_THAI_CPN_DE();
		//	v_fDE.display(m_us);
			load_data_2_grid();
		}
				
		private void delete_v_dm_bill(){
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_trang_thai)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_trang_thai, m_grv_trang_thai.Row)) return;
			if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted)  return;
			US_V_DM_BILL v_us = new US_V_DM_BILL();
			grid2us_object(v_us, m_grv_trang_thai.Row);
			try {			
				v_us.BeginTransaction();    											
				v_us.Delete();                      								
				v_us.CommitTransaction();
				m_grv_trang_thai.Rows.Remove(m_grv_trang_thai.Row);				
			}
			catch (Exception v_e) {
				v_us.Rollback();
				CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
					new CDBClientDBExceptionInterpret());
				v_objErrHandler.showErrorMessage();
			}
		}

		private void view_v_dm_bill(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_trang_thai)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_trang_thai, m_grv_trang_thai.Row)) return;
			grid2us_object(m_us, m_grv_trang_thai.Row);
		//	f511_TRA_CUU_TRANG_THAI_CPN_DE v_fDE = new f511_TRA_CUU_TRANG_THAI_CPN_DE();			
		//	v_fDE.display(m_us);
		}
        
        private void set_search_so_bill_format_before()
        {
            if (m_txt_so_bill.Text == "")
            {
                m_txt_so_bill.Text = m_str_goi_y_so_bill;
                m_txt_so_bill.ForeColor = Color.Gray;
            }
        }
        private void set_search_so_bill_format_after()
        {
            if (m_txt_so_bill.Text == m_str_goi_y_so_bill)
            {
                m_txt_so_bill.Text = "";
            }
            m_txt_so_bill.ForeColor = Color.Black;
        }
        private void load_data_2_cbo_trung_tam()
        {
            US_DM_PHONG_BAN v_us = new US_DM_PHONG_BAN();
            DS_DM_PHONG_BAN v_ds = new DS_DM_PHONG_BAN();
            v_us.FillDataset(v_ds);
            m_cbo_trung_tam.DataSource = v_ds.DM_PHONG_BAN;
            m_cbo_trung_tam.ValueMember = DM_PHONG_BAN.ID;
            m_cbo_trung_tam.DisplayMember = DM_PHONG_BAN.TEN_PHONG_BAN;

            DataRow v_dr = v_ds.DM_PHONG_BAN.NewRow();
            v_dr[DM_PHONG_BAN.ID] = -1;
            v_dr[DM_PHONG_BAN.MA_PHONG_BAN] = "";
            v_dr[DM_PHONG_BAN.TEN_PHONG_BAN] = "-----Tất cả-----";

            v_ds.DM_PHONG_BAN.Rows.InsertAt(v_dr, 0);
            m_cbo_trung_tam.SelectedIndex = 0;

        }
        private void export_2_excel()
        {
            CExcelReport v_obj_excel_report = new CExcelReport("f511_tra_cuu_trang_thai_CPN.xls", 6, 1);
            v_obj_excel_report.AddFindAndReplaceItem("<tu_ngay>", m_dtp_tu_ngay.Text);
            v_obj_excel_report.AddFindAndReplaceItem("<den_ngay>", m_dtp_den_ngay.Text);
            v_obj_excel_report.FindAndReplace(false);
            v_obj_excel_report.Export2ExcelWithoutFixedRows(m_grv_trang_thai, 0, m_grv_trang_thai.Cols.Count-1, true);
        }
		private void set_define_events(){
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            //m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
            //m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            //m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            //m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
            m_cmd_search.Click += new EventHandler(m_cmd_search_Click);
            m_txt_so_bill.KeyDown += new KeyEventHandler(m_txt_so_bill_KeyDown);
            m_txt_so_bill.Leave += new EventHandler(m_txt_so_bill_Leave);
            m_txt_so_bill.MouseClick += new MouseEventHandler(m_txt_so_bill_MouseClick);
            m_cbo_trang_thai.SelectedIndexChanged+=new EventHandler(m_cbo_trang_thai_SelectedIndexChanged);
            m_cbo_trung_tam.SelectedIndexChanged+=new EventHandler(m_cbo_trung_tam_SelectedIndexChanged);
            m_cmd_xuat_excel.Click+=new EventHandler(m_cmd_xuat_excel_Click);
		}
		#endregion

//
		//
		//		EVENT HANLDERS
		//
        //
        #region Event
        private void f511_TRA_CUU_TRANG_THAI_CPN_Load(object sender, System.EventArgs e)
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

        private void m_cmd_view_Click(object sender, EventArgs e)
        {
            try
            {
                view_v_dm_bill();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        
        private void m_txt_so_bill_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    load_data_2_grid();
                }
                else
                {
                    set_search_so_bill_format_after();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_txt_so_bill_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                set_search_so_bill_format_after();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_txt_so_bill_Leave(object sender, EventArgs e)
        {
            try
            {
                set_search_so_bill_format_before();
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
        private void m_cbo_trang_thai_SelectedIndexChanged(object sender, EventArgs e)
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

