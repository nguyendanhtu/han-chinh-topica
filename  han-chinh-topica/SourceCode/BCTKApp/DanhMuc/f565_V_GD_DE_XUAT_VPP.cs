///************************************************
/// Generated by: DungNT
/// Date: 07/10/2014 03:35:18
/// Goal: Create Form for V_GD_DE_XUAT_VPP
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



	public class f565_V_GD_DE_XUAT_VPP : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
		private C1.Win.C1FlexGrid.C1FlexGrid m_grv_de_xuat;
		internal SIS.Controls.Button.SiSButton m_cmd_delete;
		internal SIS.Controls.Button.SiSButton m_cmd_update;
		internal SIS.Controls.Button.SiSButton m_cmd_insert;
		internal SIS.Controls.Button.SiSButton m_cmd_exit;
		internal SIS.Controls.Button.SiSButton m_cmd_view;
        private Panel panel1;
        private TCDatetime m_dtp_thang;
        private ComboBox m_cbo_phap_nhan;
        private Label label2;
        private ComboBox m_cbo_trung_tam;
        internal SIS.Controls.Button.SiSButton m_cmd_search;
        private Label label4;
        private Label m_lbl_tieu_de;
        private Label m_lbl_thang;
		private System.ComponentModel.IContainer components;

		public f565_V_GD_DE_XUAT_VPP()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f565_V_GD_DE_XUAT_VPP));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_view = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_grv_de_xuat = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_dtp_thang = new BCTKApp.TCDatetime();
            this.m_cbo_phap_nhan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_cbo_trung_tam = new System.Windows.Forms.ComboBox();
            this.m_cmd_search = new SIS.Controls.Button.SiSButton();
            this.label4 = new System.Windows.Forms.Label();
            this.m_lbl_tieu_de = new System.Windows.Forms.Label();
            this.m_lbl_thang = new System.Windows.Forms.Label();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_de_xuat)).BeginInit();
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
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 428);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(713, 36);
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
            this.m_cmd_insert.Location = new System.Drawing.Point(357, 4);
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
            this.m_cmd_update.Location = new System.Drawing.Point(445, 4);
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
            this.m_cmd_delete.Location = new System.Drawing.Point(533, 4);
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
            this.m_cmd_exit.Location = new System.Drawing.Point(621, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_grv_de_xuat
            // 
            this.m_grv_de_xuat.ColumnInfo = resources.GetString("m_grv_de_xuat.ColumnInfo");
            this.m_grv_de_xuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_grv_de_xuat.Location = new System.Drawing.Point(0, 136);
            this.m_grv_de_xuat.Name = "m_grv_de_xuat";
            this.m_grv_de_xuat.Size = new System.Drawing.Size(713, 292);
            this.m_grv_de_xuat.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_grv_de_xuat.Styles"));
            this.m_grv_de_xuat.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_dtp_thang);
            this.panel1.Controls.Add(this.m_cbo_phap_nhan);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.m_cbo_trung_tam);
            this.panel1.Controls.Add(this.m_cmd_search);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.m_lbl_tieu_de);
            this.panel1.Controls.Add(this.m_lbl_thang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 126);
            this.panel1.TabIndex = 23;
            // 
            // m_dtp_thang
            // 
            this.m_dtp_thang.Format = BCTKApp.TCDatetime.DinhDang.MM_yyyy;
            this.m_dtp_thang.Location = new System.Drawing.Point(198, 44);
            this.m_dtp_thang.Mask = "00/0000";
            this.m_dtp_thang.Name = "m_dtp_thang";
            this.m_dtp_thang.Size = new System.Drawing.Size(81, 20);
            this.m_dtp_thang.TabIndex = 53;
            this.m_dtp_thang.ValidatingType = typeof(System.DateTime);
            // 
            // m_cbo_phap_nhan
            // 
            this.m_cbo_phap_nhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_phap_nhan.FormattingEnabled = true;
            this.m_cbo_phap_nhan.Location = new System.Drawing.Point(378, 43);
            this.m_cbo_phap_nhan.Name = "m_cbo_phap_nhan";
            this.m_cbo_phap_nhan.Size = new System.Drawing.Size(122, 21);
            this.m_cbo_phap_nhan.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Pháp nhân";
            // 
            // m_cbo_trung_tam
            // 
            this.m_cbo_trung_tam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_trung_tam.FormattingEnabled = true;
            this.m_cbo_trung_tam.Location = new System.Drawing.Point(198, 84);
            this.m_cbo_trung_tam.Name = "m_cbo_trung_tam";
            this.m_cbo_trung_tam.Size = new System.Drawing.Size(302, 21);
            this.m_cbo_trung_tam.TabIndex = 32;
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_search.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_search.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_search.ImageIndex = 18;
            this.m_cmd_search.ImageList = this.ImageList;
            this.m_cmd_search.Location = new System.Drawing.Point(520, 79);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_search.TabIndex = 22;
            this.m_cmd_search.Text = "Tìm kiếm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Trung tâm";
            // 
            // m_lbl_tieu_de
            // 
            this.m_lbl_tieu_de.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_tieu_de.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_tieu_de.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_tieu_de.Name = "m_lbl_tieu_de";
            this.m_lbl_tieu_de.Size = new System.Drawing.Size(713, 36);
            this.m_lbl_tieu_de.TabIndex = 28;
            this.m_lbl_tieu_de.Text = "TRA CỨU ĐỀ XUẤT VPP THEO TRUNG TÂM";
            this.m_lbl_tieu_de.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_lbl_thang
            // 
            this.m_lbl_thang.AutoSize = true;
            this.m_lbl_thang.Location = new System.Drawing.Point(128, 50);
            this.m_lbl_thang.Name = "m_lbl_thang";
            this.m_lbl_thang.Size = new System.Drawing.Size(38, 13);
            this.m_lbl_thang.TabIndex = 2;
            this.m_lbl_thang.Text = "Tháng";
            // 
            // f565_V_GD_DE_XUAT_VPP
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(713, 464);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_grv_de_xuat);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f565_V_GD_DE_XUAT_VPP";
            this.Text = "F565-Đề xuất văn phòng phẩm";
            this.Load += new System.EventHandler(this.f565_V_GD_DE_XUAT_VPP_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_de_xuat)).EndInit();
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
			TEN_PHONG_BAN = 1,GHI_CHU = 4,SO_TIEN = 3,THANG_AP_DUNG = 2
		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_V_GD_DE_XUAT_VPP m_ds = new DS_V_GD_DE_XUAT_VPP();
		US_V_GD_DE_XUAT_VPP m_us = new US_V_GD_DE_XUAT_VPP();
		#endregion

		#region Private Methods
		private void format_controls(){
			CControlFormat.setFormStyle(this, new CAppContext_201());
			CControlFormat.setC1FlexFormat(m_grv_de_xuat);
            m_lbl_tieu_de.Font = new System.Drawing.Font("Tahoma", 15, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			CGridUtils.AddSave_Excel_Handlers(m_grv_de_xuat);
            CGridUtils.AddSearch_Handlers(m_grv_de_xuat);
            load_data_2_cbo_phap_nhan();
            load_cbo_trung_tam();
            m_cmd_exit.Visible = true;
            m_cmd_exit.Enabled = true;
            m_cmd_search.Visible = true;
            m_cmd_search.Enabled = true;
            m_cmd_insert.Visible = true;
            m_cmd_insert.Enabled = true;
            m_cmd_update.Visible = true;
            m_cmd_update.Enabled = true;
            m_cmd_delete.Visible = true;
            m_cmd_delete.Enabled = true;
			set_define_events();
			this.KeyPreview = true;		
		}
		private void set_initial_form_load(){
            m_dtp_thang.Text = DateTime.Now.Date.ToString("MM/yyyy");			
			m_obj_trans = get_trans_object(m_grv_de_xuat);
			load_data_2_grid();		
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(V_GD_DE_XUAT_VPP.TEN_PHONG_BAN, e_col_Number.TEN_PHONG_BAN);			v_htb.Add(V_GD_DE_XUAT_VPP.GHI_CHU, e_col_Number.GHI_CHU);			v_htb.Add(V_GD_DE_XUAT_VPP.SO_TIEN, e_col_Number.SO_TIEN);			v_htb.Add(V_GD_DE_XUAT_VPP.THANG_AP_DUNG, e_col_Number.THANG_AP_DUNG);									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds._V_GD_DE_XUAT_VPP.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){
            DateTime v_dat_thang = CIPConvert.ToDatetime("01/" + m_dtp_thang.Text, "dd/MM/yyyy");
            decimal v_dc_id_phap_nhan = CIPConvert.ToDecimal(m_cbo_phap_nhan.SelectedValue);
            decimal v_dc_id_trung_tam = CIPConvert.ToDecimal(m_cbo_trung_tam.SelectedValue);			
			m_ds = new DS_V_GD_DE_XUAT_VPP();			
			m_us.FillDatasetSearch(m_ds,v_dat_thang,v_dc_id_phap_nhan,v_dc_id_trung_tam);
			m_grv_de_xuat.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_grv_de_xuat, m_obj_trans);
            CGridUtils.MakeSoTT(0, m_grv_de_xuat);
			m_grv_de_xuat.Redraw = true;
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
        private void load_cbo_trung_tam()
        {
            US_V_DM_PHONG_BAN_PHAP_NHAN v_us = new US_V_DM_PHONG_BAN_PHAP_NHAN();
            DS_V_DM_PHONG_BAN_PHAP_NHAN v_ds = new DS_V_DM_PHONG_BAN_PHAP_NHAN();
            decimal v_id_phap_nhan = CIPConvert.ToDecimal(m_cbo_phap_nhan.SelectedValue);
            if (v_id_phap_nhan == -1)
            {
                v_us.FillDataset(v_ds);
            }
            else
            {
                v_us.FillDataset(v_ds, "where id_phap_nhan=" + v_id_phap_nhan);
            }
            m_cbo_trung_tam.DataSource = v_ds.v_DM_PHONG_BAN_PHAP_NHAN;
            m_cbo_trung_tam.ValueMember = V_DM_PHONG_BAN_PHAP_NHAN.ID_PHONG_BAN;
            m_cbo_trung_tam.DisplayMember = V_DM_PHONG_BAN_PHAP_NHAN.TEN_PHONG_BAN;
            DataRow v_dr = v_ds.v_DM_PHONG_BAN_PHAP_NHAN.NewRow();
            v_dr[V_DM_PHONG_BAN_PHAP_NHAN.ID] = -1;
            v_dr[V_DM_PHONG_BAN_PHAP_NHAN.ID_PHAP_NHAN] = -1;
            v_dr[V_DM_PHONG_BAN_PHAP_NHAN.ID_PHONG_BAN] = -1;
            v_dr[V_DM_PHONG_BAN_PHAP_NHAN.MA_PHAP_NHAN] = "";
            v_dr[V_DM_PHONG_BAN_PHAP_NHAN.TEN_PHAP_NHAN] = "Tất cả";
            v_dr[V_DM_PHONG_BAN_PHAP_NHAN.TEN_PHONG_BAN] = "Tất cả";
            v_dr[V_DM_PHONG_BAN_PHAP_NHAN.MA_PHONG_BAN] = "";
            v_dr[V_DM_PHONG_BAN_PHAP_NHAN.TY_TRONG] = 100;
            v_ds.v_DM_PHONG_BAN_PHAP_NHAN.Rows.InsertAt(v_dr, 0);
            m_cbo_trung_tam.SelectedIndex = 0;
        }
		private void grid2us_object(US_V_GD_DE_XUAT_VPP i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_grv_de_xuat.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

        private void dm_grid2us_object(US_GD_DE_XUAT_VPP i_us
                , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_grv_de_xuat.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }
		private void us_object2grid(US_V_GD_DE_XUAT_VPP i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_grv_de_xuat.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}


		private void insert_v_gd_de_xuat_vpp(){
            F566_V_GD_DE_XUAT_VPP_DE v_fDE = new F566_V_GD_DE_XUAT_VPP_DE();
            v_fDE.display_for_insert();
			load_data_2_grid();
		}

		private void update_v_gd_de_xuat_vpp()
        {			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_de_xuat)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_de_xuat, m_grv_de_xuat.Row)) return;			
			grid2us_object(m_us, m_grv_de_xuat.Row);
            F566_V_GD_DE_XUAT_VPP_DE v_fDE = new F566_V_GD_DE_XUAT_VPP_DE();
            v_fDE.display_for_update(m_us);
			load_data_2_grid();
		}
				
		private void delete_v_gd_de_xuat_vpp(){
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_de_xuat)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_de_xuat, m_grv_de_xuat.Row)) return;
			if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted)  return;
			US_GD_DE_XUAT_VPP v_us = new US_GD_DE_XUAT_VPP();
			dm_grid2us_object(v_us, m_grv_de_xuat.Row);
			try {			
				v_us.BeginTransaction();    											
				v_us.Delete();                      								
				v_us.CommitTransaction();
				m_grv_de_xuat.Rows.Remove(m_grv_de_xuat.Row);				
			}
			catch (Exception v_e) {
				v_us.Rollback();
				CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
					new CDBClientDBExceptionInterpret());
				v_objErrHandler.showErrorMessage();
			}
		}

		private void view_v_gd_de_xuat_vpp(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_de_xuat)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_de_xuat, m_grv_de_xuat.Row)) return;
			grid2us_object(m_us, m_grv_de_xuat.Row);
		//	f565_V_GD_DE_XUAT_VPP_DE v_fDE = new f565_V_GD_DE_XUAT_VPP_DE();			
		//	v_fDE.display(m_us);
		}
		private void set_define_events(){
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
			m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
			m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
			m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
			m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
            m_cmd_search.Click += m_cmd_search_Click;
            m_cbo_phap_nhan.SelectedIndexChanged += m_cbo_phap_nhan_SelectedIndexChanged;
            m_grv_de_xuat.DoubleClick += m_grv_de_xuat_DoubleClick;
        }


		#endregion

//
		//
		//		EVENT HANLDERS
		//
        //
        #region Event
        private void f565_V_GD_DE_XUAT_VPP_Load(object sender, System.EventArgs e)
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
                insert_v_gd_de_xuat_vpp();
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
                update_v_gd_de_xuat_vpp();
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
                delete_v_gd_de_xuat_vpp();
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
                view_v_gd_de_xuat_vpp();
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
        private void m_cbo_phap_nhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                load_cbo_trung_tam();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_grv_de_xuat_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                update_v_gd_de_xuat_vpp();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
        

	}
}

