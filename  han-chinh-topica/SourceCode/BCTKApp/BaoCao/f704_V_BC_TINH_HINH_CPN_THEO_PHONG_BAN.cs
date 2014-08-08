///************************************************
/// Generated by: TuNA
/// Date: 02-07-2014 10:38:53
/// Goal: Create Form for V_BC_TINH_HINH_CPN_THEO_PHONG_BAN
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



	public class f704_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
		internal SIS.Controls.Button.SiSButton m_cmd_exit;
		internal SIS.Controls.Button.SiSButton m_cmd_xuat_excel;
        internal SIS.Controls.Button.SiSButton m_cmd_tim_kiem;
        private TextBox m_txt_tim_kiem;
        private Label m_lbl_tu_khoa;
        private DateTimePicker m_dt_tu_ngay;
        private Label m_lbl_den_ngay;
        private Label m_lbl_tu_ngay;
        private Label m_lbl_header;
        private Panel panel1;
        private ToolTip toolTip1;
        private Label label2;
        private Label label1;
        private Label m_lbl_tong_so_vuot_dm;
        private Label label3;
        private ToolTip toolTip2;
        private DateTimePicker m_dt_den_ngay;
		private System.ComponentModel.IContainer components;

		public f704_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f704_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_xuat_excel = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_cmd_tim_kiem = new SIS.Controls.Button.SiSButton();
            this.m_txt_tim_kiem = new System.Windows.Forms.TextBox();
            this.m_lbl_tu_khoa = new System.Windows.Forms.Label();
            this.m_dt_tu_ngay = new System.Windows.Forms.DateTimePicker();
            this.m_lbl_den_ngay = new System.Windows.Forms.Label();
            this.m_lbl_tu_ngay = new System.Windows.Forms.Label();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_dt_den_ngay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.m_lbl_tong_so_vuot_dm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
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
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_xuat_excel);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 487);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(990, 36);
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
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(104, 28);
            this.m_cmd_xuat_excel.TabIndex = 21;
            this.m_cmd_xuat_excel.Text = "Xuất ra Excel";
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
            this.m_cmd_exit.Location = new System.Drawing.Point(891, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(95, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(0, 158);
            this.m_fg.Name = "m_fg";
            this.m_fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
            this.m_fg.Size = new System.Drawing.Size(990, 329);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 20;
            this.toolTip1.SetToolTip(this.m_fg, "Bạn nhấp đúp chuột vào các cột: Tổng số bill đã gửi, Tổng số tiền thực tế và Tổng" +
        " số tiền định mức để xem chi tiết!");
            // 
            // m_cmd_tim_kiem
            // 
            this.m_cmd_tim_kiem.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_tim_kiem.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_tim_kiem.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_tim_kiem.ForeColor = System.Drawing.Color.Maroon;
            this.m_cmd_tim_kiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_tim_kiem.ImageIndex = 18;
            this.m_cmd_tim_kiem.ImageList = this.ImageList;
            this.m_cmd_tim_kiem.Location = new System.Drawing.Point(741, 58);
            this.m_cmd_tim_kiem.Name = "m_cmd_tim_kiem";
            this.m_cmd_tim_kiem.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_tim_kiem.TabIndex = 39;
            this.m_cmd_tim_kiem.Text = "Tìm kiếm";
            this.m_cmd_tim_kiem.Visible = false;
            this.m_cmd_tim_kiem.Click += new System.EventHandler(this.m_cmd_tim_kiem_Click);
            // 
            // m_txt_tim_kiem
            // 
            this.m_txt_tim_kiem.Location = new System.Drawing.Point(326, 60);
            this.m_txt_tim_kiem.Name = "m_txt_tim_kiem";
            this.m_txt_tim_kiem.Size = new System.Drawing.Size(395, 20);
            this.m_txt_tim_kiem.TabIndex = 38;
            this.toolTip2.SetToolTip(this.m_txt_tim_kiem, "Nhập Mã trung tâm, Tên trung tâm cần tìm!");
            // 
            // m_lbl_tu_khoa
            // 
            this.m_lbl_tu_khoa.AutoSize = true;
            this.m_lbl_tu_khoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.m_lbl_tu_khoa.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_tu_khoa.Location = new System.Drawing.Point(246, 66);
            this.m_lbl_tu_khoa.Name = "m_lbl_tu_khoa";
            this.m_lbl_tu_khoa.Size = new System.Drawing.Size(50, 13);
            this.m_lbl_tu_khoa.TabIndex = 35;
            this.m_lbl_tu_khoa.Text = "Từ khóa:";
            // 
            // m_dt_tu_ngay
            // 
            this.m_dt_tu_ngay.Checked = false;
            this.m_dt_tu_ngay.CustomFormat = "MM/yyyy";
            this.m_dt_tu_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dt_tu_ngay.Location = new System.Drawing.Point(326, 25);
            this.m_dt_tu_ngay.Name = "m_dt_tu_ngay";
            this.m_dt_tu_ngay.Size = new System.Drawing.Size(120, 20);
            this.m_dt_tu_ngay.TabIndex = 34;
            this.m_dt_tu_ngay.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            // 
            // m_lbl_den_ngay
            // 
            this.m_lbl_den_ngay.AutoSize = true;
            this.m_lbl_den_ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.m_lbl_den_ngay.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_den_ngay.Location = new System.Drawing.Point(520, 25);
            this.m_lbl_den_ngay.Name = "m_lbl_den_ngay";
            this.m_lbl_den_ngay.Size = new System.Drawing.Size(60, 13);
            this.m_lbl_den_ngay.TabIndex = 31;
            this.m_lbl_den_ngay.Text = "Đến tháng:";
            // 
            // m_lbl_tu_ngay
            // 
            this.m_lbl_tu_ngay.AutoSize = true;
            this.m_lbl_tu_ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.m_lbl_tu_ngay.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_tu_ngay.Location = new System.Drawing.Point(246, 25);
            this.m_lbl_tu_ngay.Name = "m_lbl_tu_ngay";
            this.m_lbl_tu_ngay.Size = new System.Drawing.Size(53, 13);
            this.m_lbl_tu_ngay.TabIndex = 32;
            this.m_lbl_tu_ngay.Text = "Từ tháng:";
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(990, 35);
            this.m_lbl_header.TabIndex = 30;
            this.m_lbl_header.Text = "BÁO CÁO TÌNH HÌNH CPN THEO TRUNG TÂM - BAN";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_dt_den_ngay);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.m_lbl_tong_so_vuot_dm);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.m_lbl_tu_ngay);
            this.panel1.Controls.Add(this.m_cmd_tim_kiem);
            this.panel1.Controls.Add(this.m_lbl_den_ngay);
            this.panel1.Controls.Add(this.m_txt_tim_kiem);
            this.panel1.Controls.Add(this.m_dt_tu_ngay);
            this.panel1.Controls.Add(this.m_lbl_tu_khoa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 123);
            this.panel1.TabIndex = 2830;
            // 
            // m_dt_den_ngay
            // 
            this.m_dt_den_ngay.Checked = false;
            this.m_dt_den_ngay.CustomFormat = "MM/yyyy";
            this.m_dt_den_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dt_den_ngay.Location = new System.Drawing.Point(611, 25);
            this.m_dt_den_ngay.Name = "m_dt_den_ngay";
            this.m_dt_den_ngay.Size = new System.Drawing.Size(120, 20);
            this.m_dt_den_ngay.TabIndex = 45;
            this.m_dt_den_ngay.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(557, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 44;
            // 
            // m_lbl_tong_so_vuot_dm
            // 
            this.m_lbl_tong_so_vuot_dm.AutoSize = true;
            this.m_lbl_tong_so_vuot_dm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_tong_so_vuot_dm.Location = new System.Drawing.Point(260, 102);
            this.m_lbl_tong_so_vuot_dm.Name = "m_lbl_tong_so_vuot_dm";
            this.m_lbl_tong_so_vuot_dm.Size = new System.Drawing.Size(14, 13);
            this.m_lbl_tong_so_vuot_dm.TabIndex = 43;
            this.m_lbl_tong_so_vuot_dm.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Tổng số trung tâm- ban vượt định mức: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(727, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Các trung tâm vượt định mức sẽ được đánh dấu đỏ";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 4500;
            this.toolTip1.InitialDelay = 450;
            this.toolTip1.ReshowDelay = 50;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // toolTip2
            // 
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // f704_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(990, 523);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_lbl_header);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f704_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN";
            this.Text = "F704 - Báo cáo tình hình CPN theo Trung tâm - Ban";
            this.Load += new System.EventHandler(this.f704_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m_fg_KeyDown);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
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
			TI_LE_DA_VUOT = 6
,TEN_PHONG_BAN = 2
,MA_PHONG_BAN = 1
,TONG_SO_BILL = 3
,DINH_MUC = 5
,TONG_SO_TIEN = 4

		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN m_ds = new DS_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN();
		US_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN m_us = new US_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN();
        bool m_trang_thai = false;
        DateTime v_dt_tu_ngay;
        DateTime v_dt_den_ngay;
		#endregion

		#region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            m_lbl_header.Font = new System.Drawing.Font("Tahoma", 18, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			
            m_fg.Cols[0].Caption = "STT";
            set_define_events();
            this.KeyPreview = true;
            //load_cbo_trang_thai();
        }
		private void set_initial_form_load(){
            m_obj_trans = get_trans_object(m_fg);
            m_dt_tu_ngay.Value = DateTime.Now.Date.AddDays(-DateTime.Now.Date.Day + 1);
            //DateTime temp = DateTime.Now.Date;
            //temp = temp.AddMonths(1);
            //temp = temp.AddDays(-(temp.Day));
            //m_dt_den_ngay.Value = DateTime.Now.Date.AddMonths(1).Date.AddDays(-DateTime.Now.Date.Day);

            DateTime dtResult = DateTime.Now.Date;
            dtResult = dtResult.AddMonths(1);
            dtResult = dtResult.AddDays(-(dtResult.Day));
            m_dt_den_ngay.Value = dtResult;

            load_data_2_grid();		
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(V_BC_TINH_HINH_CPN_THEO_PHONG_BAN.TI_LE_DA_VUOT, e_col_Number.TI_LE_DA_VUOT);
			v_htb.Add(V_BC_TINH_HINH_CPN_THEO_PHONG_BAN.TEN_PHONG_BAN, e_col_Number.TEN_PHONG_BAN);
			v_htb.Add(V_BC_TINH_HINH_CPN_THEO_PHONG_BAN.MA_PHONG_BAN, e_col_Number.MA_PHONG_BAN);
			v_htb.Add(V_BC_TINH_HINH_CPN_THEO_PHONG_BAN.TONG_SO_BILL, e_col_Number.TONG_SO_BILL);
			v_htb.Add(V_BC_TINH_HINH_CPN_THEO_PHONG_BAN.DINH_MUC, e_col_Number.DINH_MUC);
			v_htb.Add(V_BC_TINH_HINH_CPN_THEO_PHONG_BAN.TONG_SO_TIEN, e_col_Number.TONG_SO_TIEN);
									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.V_BC_TINH_HINH_CPN_THEO_PHONG_BAN.NewRow());
			return v_obj_trans;			
		}
        private void load_data_2_grid()
        {
            //decimal v_id_trang_thai = CIPConvert.ToDecimal(m_cbo_trang_thai.SelectedValue);
            //decimal v_id_trang_thai = -1;


            US_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN v_us = new US_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN();
            DS_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN v_ds = new DS_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN();
            v_us.FillDataset(v_ds);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(v_ds, m_fg, m_obj_trans);
            CGridUtils.MakeSoTT(0, m_fg);
            for (int i = m_fg.Rows.Fixed; i < m_fg.Rows.Count; i++)
            {
                if (m_fg[i, (int)e_col_Number.TI_LE_DA_VUOT] == null) continue;
                if (!CIPConvert.is_valid_number(m_fg[i, (int)e_col_Number.TI_LE_DA_VUOT])) continue;
                if (CIPConvert.ToDecimal((m_fg[i, (int)e_col_Number.TI_LE_DA_VUOT]).ToString()) > 20)
                {
                    m_fg.Rows[i].Style = m_fg.Styles["CustomStyle1"];
                }

            }
            m_fg.Redraw = true;
        }
        private void tim_kiem()
        {
            string v_id_tu_khoa = m_txt_tim_kiem.Text;
            //decimal v_id_trang_thai = CIPConvert.ToDecimal(m_cbo_trang_thai.SelectedValue);
            decimal v_id_trang_thai = -1;
            v_dt_tu_ngay = m_dt_tu_ngay.Value.AddDays(-m_dt_tu_ngay.Value.Date.Day+1);
            v_dt_den_ngay = m_dt_den_ngay.Value.AddMonths(1).AddDays(-m_dt_den_ngay.Value.Day);
            decimal v_dc_tong_so_vuot_dm = 0;
            US_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN v_us = new US_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN();
            DS_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN v_ds = new DS_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN();
            v_us.FillDatasetSearch(v_ds, v_dt_tu_ngay, v_dt_den_ngay, v_id_trang_thai, v_id_tu_khoa);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(v_ds, m_fg, m_obj_trans);
            CGridUtils.MakeSoTT(0, m_fg);
            for (int i = m_fg.Rows.Fixed; i < m_fg.Rows.Count; i++)
            {
                if (m_fg[i, (int)e_col_Number.TI_LE_DA_VUOT] == null || CIPConvert.ToDecimal(m_fg[i, (int)e_col_Number.TI_LE_DA_VUOT].ToString()) <0)
                    {
                        m_fg[i, (int)e_col_Number.TI_LE_DA_VUOT] = 0;
                        continue;
                    }
                if (!CIPConvert.is_valid_number(m_fg[i, (int)e_col_Number.TI_LE_DA_VUOT])) continue;
                if (CIPConvert.ToDecimal((m_fg[i, (int)e_col_Number.TI_LE_DA_VUOT]).ToString()) > 0)
                {
                    m_fg.Rows[i].Style = m_fg.Styles["CustomStyle1"];
                    v_dc_tong_so_vuot_dm++;
                }

            }
            if (v_dc_tong_so_vuot_dm == 0) m_lbl_tong_so_vuot_dm.Text = "0";
            else m_lbl_tong_so_vuot_dm.Text = CIPConvert.ToStr(v_dc_tong_so_vuot_dm, "#,###");
            m_fg.Redraw = true;
        }
		private void grid2us_object(US_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

	
		private void us_object2grid(US_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}


		private void insert_v_bc_tinh_hinh_cpn_theo_phong_ban(){			
		//	f704_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN_DE v_fDE = new  f704_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN_DE();								
		//	v_fDE.display();
			load_data_2_grid();
		}

		private void update_v_bc_tinh_hinh_cpn_theo_phong_ban(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;			
			grid2us_object(m_us, m_fg.Row);
		//	f704_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN_DE v_fDE = new f704_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN_DE();
		//	v_fDE.display(m_us);
			load_data_2_grid();
		}
				
		private void delete_v_bc_tinh_hinh_cpn_theo_phong_ban(){
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted)  return;
			US_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN v_us = new US_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN();
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

		private void view_v_bc_tinh_hinh_cpn_theo_phong_ban(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			grid2us_object(m_us, m_fg.Row);
		//	f704_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN_DE v_fDE = new f704_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN_DE();			
		//	v_fDE.display(m_us);
		}
        private void export_2_excel()
        {
            CExcelReport v_obj_excel_report = new CExcelReport("f704_bc_tinh_hinh_CPN_theo_phong_ban.xlsx", 7, 1);
            v_obj_excel_report.AddFindAndReplaceItem("<tu_ngay>", v_dt_tu_ngay.ToShortDateString());
            v_obj_excel_report.AddFindAndReplaceItem("<den_ngay>", v_dt_den_ngay.ToShortDateString());
            v_obj_excel_report.FindAndReplace(false);
            v_obj_excel_report.Export2ExcelWithoutFixedRows(m_fg, 0, m_fg.Cols.Count - 1, true);
        }
		private void set_define_events(){
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            
            m_cmd_xuat_excel.Click += new EventHandler(m_cmd_xuat_excel_Click);
            this.m_fg.DoubleClick += new System.EventHandler(this.m_fg_DoubleClick);
            m_dt_tu_ngay.ValueChanged += new EventHandler(m_dt_tu_ngay_ValueChanged);
            m_dt_den_ngay.ValueChanged += new EventHandler(m_dt_den_ngay_ValueChanged);
            m_txt_tim_kiem.TextChanged += new EventHandler(m_txt_tim_kiem_TextChanged);
		}
		#endregion

//
		//
		//		EVENT HANLDERS
		//
		//
		private void f704_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN_Load(object sender, System.EventArgs e) {
			try  {
				set_initial_form_load();
                tim_kiem();
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

		private void m_cmd_xuat_excel_Click(object sender, EventArgs e){
            try
            {
                export_2_excel();
            }
            catch (System.Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);	
            }
        }
        private void m_cbo_trang_thai_SelectedIndexChanged(object sender, EventArgs e) {
            if(m_trang_thai == true) {
                tim_kiem();
            }
        }

        private void m_dt_tu_ngay_ValueChanged(object sender, EventArgs e) {
            tim_kiem();
        }

        private void m_dt_den_ngay_ValueChanged(object sender, EventArgs e) {
            tim_kiem();
        }

        private void m_cmd_tim_kiem_Click(object sender, EventArgs e)
        {
            tim_kiem();
        }

        private void m_txt_tim_kiem_TextChanged(object sender, EventArgs e) {
            tim_kiem();
        }

        private void m_fg_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                decimal v_id_phong_ban;
                decimal v_tong_bill;
                decimal v_tong_tien;
                //decimal v_id_trang_thai = CIPConvert.ToDecimal(m_cbo_trang_thai.SelectedValue);
                DateTime v_dt_tu_ngay = m_dt_tu_ngay.Value;
                DateTime v_dt_den_ngay = m_dt_den_ngay.Value;
                int i_grid_row = m_fg.Selection.TopRow;
                int i_grid_col=m_fg.Selection.LeftCol;
                DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
                //Data v_dc = (DataColumn)m_fg.Cols[i_grid_row].UserData;
                v_id_phong_ban = CIPConvert.ToDecimal(v_dr[0]);
                if (v_dr[3].ToString() != "")
                    v_tong_bill = CIPConvert.ToDecimal(v_dr[3]);
                else
                    v_tong_bill = 0;
                if (v_dr[4].ToString() != "")
                    v_tong_tien = CIPConvert.ToDecimal(v_dr[4]);
                else
                    v_tong_tien = 0;
                if (i_grid_col == (int)e_col_Number.DINH_MUC)
                {
                    f706_V_BC_CHI_TIET_DM v_frm = new f706_V_BC_CHI_TIET_DM();
                    v_frm.Display_for_chi_tiet(v_id_phong_ban, v_dt_tu_ngay, v_dt_den_ngay);
                }
                else 
                if (((i_grid_col == (int)e_col_Number.TONG_SO_BILL) || (i_grid_col == (int)e_col_Number.TONG_SO_TIEN)))// && v_dr[4].ToString() != "")
                {
                    f407_V_TONG_HOP_BILL_THEO_PHONG_BAN_DE v_frm1 = new f407_V_TONG_HOP_BILL_THEO_PHONG_BAN_DE();
                    v_frm1.Display_for_chi_tiet(v_id_phong_ban, -1, v_dt_tu_ngay, v_dt_den_ngay, v_tong_bill, v_tong_tien);
                }
                else {
                    //BaseMessages.MsgBox_Infor("Bạn nhấp đúp chuột vào các cột: tổng số bill, tổng tiền thanh toán để xem chi tiết");
                    BaseMessages.MsgBox_Infor("Bạn nhấp đúp chuột vào các cột: Tổng số bill đã gửi, Tổng số tiền thực tế và Tổng số tiền định mức để xem chi tiết!");
              }
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_fg_KeyDown(object sender, KeyEventArgs e)
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

	}
}

