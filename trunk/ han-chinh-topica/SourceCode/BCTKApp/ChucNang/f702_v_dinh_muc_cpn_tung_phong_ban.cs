///************************************************
/// Generated by: TuNA
/// Date: 27-06-2014 05:48:26
/// Goal: Create Form for V_DINH_MUC_CPN_TUNG_PHONG_BAN
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



	public class f702_v_dinh_muc_cpn_tung_phong_ban : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private TextBox m_txt_tim_kiem;
        private Label m_lbl_header;
        private DateTimePicker m_dat_tai_ngay;
        private Label label1;
        private Label label3;
        private Panel panel1;
        internal SIS.Controls.Button.SiSButton m_cmd_tim_kiem;
        private Label label2;
        private DateTimePicker m_dt_den_ngay;
        private DateTimePicker m_dt_tu_ngay;
        private Label m_lbl_den_ngay;
        private Label m_lbl_tu_ngay;
		private System.ComponentModel.IContainer components;

		public f702_v_dinh_muc_cpn_tung_phong_ban()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f702_v_dinh_muc_cpn_tung_phong_ban));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_txt_tim_kiem = new System.Windows.Forms.TextBox();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.m_dat_tai_ngay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.m_cmd_tim_kiem = new SIS.Controls.Button.SiSButton();
            this.m_dt_den_ngay = new System.Windows.Forms.DateTimePicker();
            this.m_dt_tu_ngay = new System.Windows.Forms.DateTimePicker();
            this.m_lbl_den_ngay = new System.Windows.Forms.Label();
            this.m_lbl_tu_ngay = new System.Windows.Forms.Label();
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
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 439);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(901, 36);
            this.m_pnl_out_place_dm.TabIndex = 19;
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
            this.m_cmd_exit.Location = new System.Drawing.Point(797, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(100, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(0, 139);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(901, 300);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 20;
            // 
            // m_txt_tim_kiem
            // 
            this.m_txt_tim_kiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.m_txt_tim_kiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.m_txt_tim_kiem.Location = new System.Drawing.Point(343, 36);
            this.m_txt_tim_kiem.Name = "m_txt_tim_kiem";
            this.m_txt_tim_kiem.Size = new System.Drawing.Size(279, 20);
            this.m_txt_tim_kiem.TabIndex = 2832;
            this.m_txt_tim_kiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.m_txt_tim_kiem_MouseClick);
            this.m_txt_tim_kiem.MouseEnter += new System.EventHandler(this.m_txt_tim_kiem_Leave);
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(901, 38);
            this.m_lbl_header.TabIndex = 2835;
            this.m_lbl_header.Text = "TỔNG TIỀN ĐỊNH MỨC CHUYỂN PHÁT NHANH TỪNG TRUNG TÂM - BAN";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_dat_tai_ngay
            // 
            this.m_dat_tai_ngay.CustomFormat = "";
            this.m_dat_tai_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.m_dat_tai_ngay.Location = new System.Drawing.Point(12, 62);
            this.m_dat_tai_ngay.Name = "m_dat_tai_ngay";
            this.m_dat_tai_ngay.Size = new System.Drawing.Size(192, 20);
            this.m_dat_tai_ngay.TabIndex = 2837;
            this.m_dat_tai_ngay.ValueChanged += new System.EventHandler(this.m_cmd_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(287, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2842;
            this.label1.Text = "Từ khóa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(10, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2843;
            this.label3.Text = "Tại ngày: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_dt_den_ngay);
            this.panel1.Controls.Add(this.m_dt_tu_ngay);
            this.panel1.Controls.Add(this.m_lbl_den_ngay);
            this.panel1.Controls.Add(this.m_lbl_tu_ngay);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.m_cmd_tim_kiem);
            this.panel1.Controls.Add(this.m_txt_tim_kiem);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.m_dat_tai_ngay);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 101);
            this.panel1.TabIndex = 2844;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 13);
            this.label2.TabIndex = 2845;
            this.label2.Text = "Nhấp đúp chuột vào mỗi dòng để xem chi tiết nhé!";
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
            this.m_cmd_tim_kiem.Location = new System.Drawing.Point(435, 62);
            this.m_cmd_tim_kiem.Name = "m_cmd_tim_kiem";
            this.m_cmd_tim_kiem.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_tim_kiem.TabIndex = 2844;
            this.m_cmd_tim_kiem.Text = "Tìm kiếm";
            this.m_cmd_tim_kiem.Click += new System.EventHandler(this.m_cmd_search_Click);
            // 
            // m_dt_den_ngay
            // 
            this.m_dt_den_ngay.Checked = false;
            this.m_dt_den_ngay.CustomFormat = "dd/MM/yyyy";
            this.m_dt_den_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dt_den_ngay.Location = new System.Drawing.Point(558, 10);
            this.m_dt_den_ngay.Name = "m_dt_den_ngay";
            this.m_dt_den_ngay.Size = new System.Drawing.Size(120, 20);
            this.m_dt_den_ngay.TabIndex = 2848;
            // 
            // m_dt_tu_ngay
            // 
            this.m_dt_tu_ngay.Checked = false;
            this.m_dt_tu_ngay.CustomFormat = "dd/MM/yyyy";
            this.m_dt_tu_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dt_tu_ngay.Location = new System.Drawing.Point(335, 9);
            this.m_dt_tu_ngay.Name = "m_dt_tu_ngay";
            this.m_dt_tu_ngay.Size = new System.Drawing.Size(120, 20);
            this.m_dt_tu_ngay.TabIndex = 2849;
            this.m_dt_tu_ngay.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            // 
            // m_lbl_den_ngay
            // 
            this.m_lbl_den_ngay.AutoSize = true;
            this.m_lbl_den_ngay.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_den_ngay.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_den_ngay.Location = new System.Drawing.Point(484, 12);
            this.m_lbl_den_ngay.Name = "m_lbl_den_ngay";
            this.m_lbl_den_ngay.Size = new System.Drawing.Size(62, 15);
            this.m_lbl_den_ngay.TabIndex = 2846;
            this.m_lbl_den_ngay.Text = "Đến ngày:";
            // 
            // m_lbl_tu_ngay
            // 
            this.m_lbl_tu_ngay.AutoSize = true;
            this.m_lbl_tu_ngay.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_tu_ngay.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_tu_ngay.Location = new System.Drawing.Point(266, 11);
            this.m_lbl_tu_ngay.Name = "m_lbl_tu_ngay";
            this.m_lbl_tu_ngay.Size = new System.Drawing.Size(55, 15);
            this.m_lbl_tu_ngay.TabIndex = 2847;
            this.m_lbl_tu_ngay.Text = "Từ ngày:";
            // 
            // f702_v_dinh_muc_cpn_tung_phong_ban
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(901, 475);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_lbl_header);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f702_v_dinh_muc_cpn_tung_phong_ban";
            this.Text = "F702 - Tổng tiền định mức CPN của từng trung tâm - ban";
            this.Load += new System.EventHandler(this.f702_v_dinh_muc_cpn_tung_phong_ban_Load);
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
			TEN_PHONG_BAN = 2
,MA_PHONG_BAN = 1
,DINH_MUC_GAN_NHAT = 3

		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;
        private const String m_str_tim_kiem = "Nhập tên mã phòng ban, tên phòng ban cần tìm";
		DS_V_DINH_MUC_CPN_TUNG_PHONG_BAN m_ds = new DS_V_DINH_MUC_CPN_TUNG_PHONG_BAN();
		US_V_DINH_MUC_CPN_TUNG_PHONG_BAN m_us = new US_V_DINH_MUC_CPN_TUNG_PHONG_BAN();
        DateTime v_dat_tai_ngay;
		#endregion

		#region Private Methods
        private void load_custom_source_2_m_txt_tim_kiem()
        {
            int count = m_ds.Tables["V_DINH_MUC_CPN_TUNG_PHONG_BAN"].Rows.Count;
            AutoCompleteStringCollection v_acsc_search = new AutoCompleteStringCollection();
            foreach (DataRow dr in m_ds.V_DINH_MUC_CPN_TUNG_PHONG_BAN)
            {
                v_acsc_search.Add(dr[V_DINH_MUC_CPN_TUNG_PHONG_BAN.TEN_PHONG_BAN].ToString());
                //v_acsc_search.Add(dr[V_DINH_MUC_CPN_TUNG_PHONG_BAN.MA_PHONG_BAN].ToString());

            }
            m_txt_tim_kiem.AutoCompleteCustomSource = v_acsc_search;
        }
        private void format_controls()
        {

            CControlFormat.setFormStyle(this, new CAppContext_201());
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            m_lbl_header.Font = new System.Drawing.Font("Tahoma", 14, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			
            m_fg.Cols[0].Caption = "STT";
            //m_fg.Tree.Style = C1.Win.C1FlexGrid.TreeStyleFlags.SimpleLeaf;

            set_define_events();
            this.KeyPreview = true;
        }
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_fg);
            m_dt_tu_ngay.Value = DateTime.Now.Date.AddDays(-DateTime.Now.Date.Day + 1);
            DateTime temp = (DateTime.Now.Date).AddMonths(1);
            m_dt_den_ngay.Value = temp.AddDays(-temp.Day);
			load_data_2_grid();		
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(V_DINH_MUC_CPN_TUNG_PHONG_BAN.TEN_PHONG_BAN, e_col_Number.TEN_PHONG_BAN);
			v_htb.Add(V_DINH_MUC_CPN_TUNG_PHONG_BAN.MA_PHONG_BAN, e_col_Number.MA_PHONG_BAN);
			v_htb.Add(V_DINH_MUC_CPN_TUNG_PHONG_BAN.DINH_MUC_GAN_NHAT, e_col_Number.DINH_MUC_GAN_NHAT);
									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.V_DINH_MUC_CPN_TUNG_PHONG_BAN.NewRow());
			return v_obj_trans;
        }
        private void set_search_format_before()
        {
            if (m_txt_tim_kiem.Text == "")
            {
                m_txt_tim_kiem.Text = m_str_tim_kiem;
                m_txt_tim_kiem.ForeColor = Color.Gray;
            }

        }
        private void set_search_format_after()
        {
            if (m_txt_tim_kiem.Text == m_str_tim_kiem)
            {
                m_txt_tim_kiem.Text = "";
            }
            m_txt_tim_kiem.ForeColor = Color.Black;
        }
		private void load_data_2_grid(){
            m_ds.Clear();
            v_dat_tai_ngay = m_dat_tai_ngay.Value;
            
            if (m_txt_tim_kiem.Text.Trim() == m_str_tim_kiem || m_txt_tim_kiem.Text.Trim() == "") m_us.FillDatasetSearch(m_ds, "",v_dat_tai_ngay);
            else m_us.FillDatasetSearch(m_ds, m_txt_tim_kiem.Text.Trim(),v_dat_tai_ngay);
            //decimal v_tong_dinh_muc=0;
            //for (int i = 1; i <= m_ds.V_DINH_MUC_CPN_TUNG_PHONG_BAN.Count; i++)
            //{
            //v_tong_dinh_muc += CIPConvert.ToDecimal(m_ds.Tables[0].Rows[i][BCTKDS.CDBNames.V_DINH_MUC_CPN_TUNG_PHONG_BAN.DINH_MUC_GAN_NHAT]);
            //}
            //m_lbl_tong_dinh_muc.Text=CIPConvert.ToStr(v_tong_dinh_muc, "#,###") + "   VNĐ";
            var v_str_search = m_txt_tim_kiem.Text.Trim();
            if (v_str_search.Equals(m_str_tim_kiem))
            {
                v_str_search = "";
            }
            m_fg.Redraw = true;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            CGridUtils.MakeSoTT(0, m_fg);
           
			//m_us.FillDataset(m_ds);

			m_fg.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
			m_fg.Redraw = true;
            set_search_format_before();
		}
		private void grid2us_object(US_V_DINH_MUC_CPN_TUNG_PHONG_BAN i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

	
		private void us_object2grid(US_V_DINH_MUC_CPN_TUNG_PHONG_BAN i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}


		private void insert_v_dinh_muc_cpn_tung_phong_ban(){			
		//	f702_v_dinh_muc_cpn_tung_phong_ban_DE v_fDE = new  f702_v_dinh_muc_cpn_tung_phong_ban_DE();								
		//	v_fDE.display();
			load_data_2_grid();
		}

		private void update_v_dinh_muc_cpn_tung_phong_ban(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;			
			grid2us_object(m_us, m_fg.Row);
		//	f702_v_dinh_muc_cpn_tung_phong_ban_DE v_fDE = new f702_v_dinh_muc_cpn_tung_phong_ban_DE();
		//	v_fDE.display(m_us);
			load_data_2_grid();
		}
				
		
		private void set_define_events(){
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
			
            
            m_txt_tim_kiem.KeyDown += m_txt_tim_kiem_KeyDown;
            m_txt_tim_kiem.MouseClick += m_txt_tim_kiem_MouseClick;
            m_txt_tim_kiem.Leave += m_txt_tim_kiem_Leave;
		}
		#endregion

//
		//
		//		EVENT HANLDERS
		//
		//
		private void f702_v_dinh_muc_cpn_tung_phong_ban_Load(object sender, System.EventArgs e) {
			try{
				set_initial_form_load();
                load_custom_source_2_m_txt_tim_kiem();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		
		}
        private void m_txt_tim_kiem_MouseClick(object sender, MouseEventArgs e)
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
        private void m_txt_tim_kiem_Leave(object sender, EventArgs e)
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
        private void m_txt_tim_kiem_KeyDown(object sender, KeyEventArgs e)
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
		private void m_cmd_exit_Click(object sender, EventArgs e) {
			try{
				this.Close();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		

	}
}

