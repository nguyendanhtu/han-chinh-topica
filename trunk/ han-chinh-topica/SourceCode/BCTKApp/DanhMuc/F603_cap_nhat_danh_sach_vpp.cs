///************************************************
/// Generated by: TuDM
/// Date: 01/09/2014 01:02:07
/// Goal: Create Form for V_DM_VPP
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
using System.Linq.Expressions;
using System.Linq;
using IP.Core.IPExcelReport;
using System.Collections.Generic;

namespace BCTKApp
{



    public class F603_cap_nhat_danh_sach_vpp : System.Windows.Forms.Form
    {
        internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        internal SIS.Controls.Button.SiSButton m_cmd_delete;
        internal SIS.Controls.Button.SiSButton m_cmd_update;
        internal SIS.Controls.Button.SiSButton m_cmd_insert;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        internal SIS.Controls.Button.SiSButton m_cmd_view;
        private ComboBox m_cbo_nha_cung_cap;
        private OpenFileDialog m_ofd_bang_gia;
        private SIS.Controls.Button.SiSButton m_cmd_chon_file_bang_gia;
        private SIS.Controls.Button.SiSButton m_cmd_hien_thi_du_lieu;
        private SIS.Controls.Button.SiSButton m_cmd_cap_nhat_danh_sach_vpp;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Panel m_pnl_header;
        private Label m_lbl_header;
        private System.ComponentModel.IContainer components;

        public F603_cap_nhat_danh_sach_vpp()
        {

            InitializeComponent();
            format_controls();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F603_cap_nhat_danh_sach_vpp));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_view = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_cbo_nha_cung_cap = new System.Windows.Forms.ComboBox();
            this.m_ofd_bang_gia = new System.Windows.Forms.OpenFileDialog();
            this.m_cmd_chon_file_bang_gia = new SIS.Controls.Button.SiSButton();
            this.m_cmd_hien_thi_du_lieu = new SIS.Controls.Button.SiSButton();
            this.m_cmd_cap_nhat_danh_sach_vpp = new SIS.Controls.Button.SiSButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.m_pnl_header = new System.Windows.Forms.Panel();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.m_pnl_header.SuspendLayout();
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
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 485);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(760, 36);
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
            this.m_cmd_insert.Location = new System.Drawing.Point(404, 4);
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
            this.m_cmd_update.Location = new System.Drawing.Point(492, 4);
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
            this.m_cmd_delete.Location = new System.Drawing.Point(580, 4);
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
            this.m_cmd_exit.Location = new System.Drawing.Point(668, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_fg.ExtendLastCol = true;
            this.m_fg.Location = new System.Drawing.Point(0, 154);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(760, 331);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 20;
            // 
            // m_cbo_nha_cung_cap
            // 
            this.m_cbo_nha_cung_cap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_nha_cung_cap.FormattingEnabled = true;
            this.m_cbo_nha_cung_cap.Location = new System.Drawing.Point(106, 53);
            this.m_cbo_nha_cung_cap.Name = "m_cbo_nha_cung_cap";
            this.m_cbo_nha_cung_cap.Size = new System.Drawing.Size(360, 21);
            this.m_cbo_nha_cung_cap.TabIndex = 21;
            // 
            // m_cmd_chon_file_bang_gia
            // 
            this.m_cmd_chon_file_bang_gia.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_chon_file_bang_gia.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_chon_file_bang_gia.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_chon_file_bang_gia.Location = new System.Drawing.Point(4, 82);
            this.m_cmd_chon_file_bang_gia.Name = "m_cmd_chon_file_bang_gia";
            this.m_cmd_chon_file_bang_gia.Size = new System.Drawing.Size(124, 48);
            this.m_cmd_chon_file_bang_gia.TabIndex = 23;
            this.m_cmd_chon_file_bang_gia.Text = "1- Chọn file và hiển thị";
            this.m_cmd_chon_file_bang_gia.UseVisualStyleBackColor = true;
            // 
            // m_cmd_hien_thi_du_lieu
            // 
            this.m_cmd_hien_thi_du_lieu.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_hien_thi_du_lieu.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_hien_thi_du_lieu.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_hien_thi_du_lieu.Location = new System.Drawing.Point(134, 82);
            this.m_cmd_hien_thi_du_lieu.Name = "m_cmd_hien_thi_du_lieu";
            this.m_cmd_hien_thi_du_lieu.Size = new System.Drawing.Size(123, 48);
            this.m_cmd_hien_thi_du_lieu.TabIndex = 23;
            this.m_cmd_hien_thi_du_lieu.Text = "2 - Kiểm tra";
            this.m_cmd_hien_thi_du_lieu.UseVisualStyleBackColor = true;
            // 
            // m_cmd_cap_nhat_danh_sach_vpp
            // 
            this.m_cmd_cap_nhat_danh_sach_vpp.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_cap_nhat_danh_sach_vpp.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_cap_nhat_danh_sach_vpp.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_cap_nhat_danh_sach_vpp.Location = new System.Drawing.Point(273, 82);
            this.m_cmd_cap_nhat_danh_sach_vpp.Name = "m_cmd_cap_nhat_danh_sach_vpp";
            this.m_cmd_cap_nhat_danh_sach_vpp.Size = new System.Drawing.Size(126, 48);
            this.m_cmd_cap_nhat_danh_sach_vpp.TabIndex = 23;
            this.m_cmd_cap_nhat_danh_sach_vpp.Text = "3 - Cập nhật danh sách văn phòng phẩm";
            this.m_cmd_cap_nhat_danh_sach_vpp.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nhà cung cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(469, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 15);
            this.label2.TabIndex = 40;
            this.label2.Text = "Giá trị sai lệch với giá trị trong phần mềm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(469, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "VPP không có trong hóa đơn";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Yellow;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(704, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(44, 20);
            this.textBox2.TabIndex = 37;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Red;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(704, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(44, 20);
            this.textBox1.TabIndex = 38;
            // 
            // m_pnl_header
            // 
            this.m_pnl_header.Controls.Add(this.m_lbl_header);
            this.m_pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_pnl_header.Location = new System.Drawing.Point(0, 0);
            this.m_pnl_header.Name = "m_pnl_header";
            this.m_pnl_header.Size = new System.Drawing.Size(760, 42);
            this.m_pnl_header.TabIndex = 41;
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_lbl_header.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(760, 42);
            this.m_lbl_header.TabIndex = 0;
            this.m_lbl_header.Text = "DANH SÁCH VĂN PHÒNG PHẨM";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // F603_cap_nhat_danh_sach_vpp
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(760, 521);
            this.Controls.Add(this.m_pnl_header);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_cmd_cap_nhat_danh_sach_vpp);
            this.Controls.Add(this.m_cmd_hien_thi_du_lieu);
            this.Controls.Add(this.m_cmd_chon_file_bang_gia);
            this.Controls.Add(this.m_cbo_nha_cung_cap);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "F603_cap_nhat_danh_sach_vpp";
            this.Text = "F603_cap_nhat_danh_sach_vpp";
            this.Load += new System.EventHandler(this.F603_cap_nhat_danh_sach_vpp_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.m_pnl_header.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            TEN_NCC = 1
,
            DON_GIA_CHUA_VAT = 5
                ,
            MA = 2
                ,
            DON_GIA_GOM_VAT = 6
                ,
            TEN_VPP = 3
                , DON_VI_TINH = 4

        }
        public class VanPhongPham
        {
            public decimal ID;
            public decimal ID_NHA_CUNG_CAP;
            public string MA;
            public string TEN;
            public decimal GIA_TRI_CHUA_VAT;
            public decimal GIA_TRI_GOM_VAT;
            public string DON_VI_TINH;
        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_V_DM_VPP m_ds = new DS_V_DM_VPP();
        US_V_DM_VPP m_us = new US_V_DM_VPP();
        DataSet m_ds_temp = new DataSet();
        DataTable m_dt_temp = new DataTable();
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            m_lbl_header.Font = new System.Drawing.Font("Tahoma", 15, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            m_fg.ExtendLastCol = true;
            m_fg.AutoClipboard = true;
            m_cmd_chon_file_bang_gia.Visible = true;
            m_cmd_chon_file_bang_gia.Enabled = true;
            m_cmd_exit.Visible = true;
            m_cmd_exit.Enabled = true;
            m_cmd_hien_thi_du_lieu.Visible = true;
            m_cmd_hien_thi_du_lieu.Enabled = true;
            m_cmd_cap_nhat_danh_sach_vpp.Visible = true;
            m_cmd_cap_nhat_danh_sach_vpp.Enabled = true;
            m_cmd_insert.Visible = true;
            m_cmd_insert.Enabled = true;
            m_cmd_update.Visible = true;
            m_cmd_update.Enabled = true;
            m_cmd_delete.Visible = true;
            m_cmd_delete.Enabled = true;
            set_define_events();
            this.KeyPreview = true;
        }
        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_fg);
            load_data_to_cbo_nha_cung_cap();
            load_data_2_grid();
        }
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
            m_cmd_chon_file_bang_gia.Click += new EventHandler(m_cmd_chon_file_bang_gia_Click);
            m_cmd_hien_thi_du_lieu.Click += new EventHandler(m_cmd_hien_thi_du_lieu_Click);
            m_cmd_cap_nhat_danh_sach_vpp.Click += new EventHandler(m_cmd_cap_nhat_danh_sach_vpp_Click);
            //m_fg.DoubleClick += new EventHandler(m_fg_DoubleClick);
        }

        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_DM_VPP.TEN_NCC, e_col_Number.TEN_NCC);
            v_htb.Add(V_DM_VPP.DON_GIA_CHUA_VAT, e_col_Number.DON_GIA_CHUA_VAT);
            v_htb.Add(V_DM_VPP.MA, e_col_Number.MA);
            v_htb.Add(V_DM_VPP.DON_GIA_GOM_VAT, e_col_Number.DON_GIA_GOM_VAT);
            v_htb.Add(V_DM_VPP.TEN_VPP, e_col_Number.TEN_VPP);
            v_htb.Add(V_DM_VPP.DON_VI_TINH, e_col_Number.DON_VI_TINH);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_DM_VPP.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            m_ds = new DS_V_DM_VPP();
            m_us.FillDataset(m_ds, "where id_nha_cung_cap=" + m_cbo_nha_cung_cap.SelectedValue.ToString());
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            m_fg.Redraw = true;
        }
        private void grid2us_object(US_V_DM_VPP i_us, int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }
        private void grid2vpp_object(VanPhongPham ip_vpp, int i_grid_row)
        {
            //DataRow v_dr;
            //v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            ip_vpp.MA = m_fg.Rows[i_grid_row][2].ToString();
            ip_vpp.TEN = m_fg.Rows[i_grid_row][3].ToString();
            ip_vpp.DON_VI_TINH = m_fg.Rows[i_grid_row][4].ToString();
            ip_vpp.GIA_TRI_CHUA_VAT = CIPConvert.ToDecimal(m_fg.Rows[i_grid_row][5].ToString().Replace(",", "").Replace(".", ""));
            ip_vpp.GIA_TRI_GOM_VAT = CIPConvert.ToDecimal(m_fg.Rows[i_grid_row][6].ToString().Replace(",", "").Replace(".", ""));
        }
        private void us_object2grid(US_V_DM_VPP i_us, int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }
        //addition methods

        private void load_data_to_cbo_nha_cung_cap()
        {
            US_DM_NHA_CUNG_CAP v_us_dm_nha_cung_cap = new US_DM_NHA_CUNG_CAP();
            DS_DM_NHA_CUNG_CAP v_ds_dm_nha_cung_cap = new DS_DM_NHA_CUNG_CAP();
            v_us_dm_nha_cung_cap.FillDataset(v_ds_dm_nha_cung_cap, "order by ten");
            m_cbo_nha_cung_cap.DisplayMember = DM_NHA_CUNG_CAP.TEN;
            m_cbo_nha_cung_cap.ValueMember = DM_NHA_CUNG_CAP.ID;
            m_cbo_nha_cung_cap.DataSource = v_ds_dm_nha_cung_cap.DM_NHA_CUNG_CAP;
        }
        private void check_update_data()
        {
            //lay du lieu bang vpp
            DS_V_DM_VPP v_ds_v_dm_vpp = new DS_V_DM_VPP();
            m_us.FillDataset(v_ds_v_dm_vpp, "where id_nha_cung_cap=" + m_cbo_nha_cung_cap.SelectedValue.ToString());
            // datatable to list
            List<VanPhongPham> v_lst_vpp = new List<VanPhongPham>();
            foreach (DataRow v_dr in v_ds_v_dm_vpp.Tables[0].Rows)
            {
                var vpp = new VanPhongPham();
                vpp.ID = CIPConvert.ToDecimal(v_dr[V_DM_VPP.ID_VPP]);
                vpp.ID_NHA_CUNG_CAP = CIPConvert.ToDecimal(m_cbo_nha_cung_cap.SelectedValue.ToString());
                vpp.MA = v_dr[V_DM_VPP.MA].ToString();
                vpp.TEN = v_dr[V_DM_VPP.TEN_VPP].ToString();
                vpp.DON_VI_TINH = v_dr[V_DM_VPP.DON_VI_TINH].ToString();
                vpp.GIA_TRI_CHUA_VAT = CIPConvert.ToDecimal(v_dr[V_DM_VPP.DON_GIA_CHUA_VAT].ToString());
                vpp.GIA_TRI_GOM_VAT = CIPConvert.ToDecimal(v_dr[V_DM_VPP.DON_GIA_GOM_VAT].ToString());
                //add item to list
                v_lst_vpp.Add(vpp);

            }

            C1.Win.C1FlexGrid.CellStyle v_cell_style_err = this.m_fg.Styles.Add("RowColorErr");
            v_cell_style_err.BackColor = Color.Red;
            C1.Win.C1FlexGrid.CellStyle v_cell_style_err2 = this.m_fg.Styles.Add("RowColorErr2");
            v_cell_style_err2.BackColor = Color.Yellow;
            v_cell_style_err2.ForeColor = Color.DarkRed;

            C1.Win.C1FlexGrid.CellStyle v_cell_style_ok = this.m_fg.Styles.Add("RowColorOk");
            v_cell_style_ok.BackColor = Color.White;
            C1.Win.C1FlexGrid.CellStyle v_cell_style_chu_ok = this.m_fg.Styles.Add("RowColor");
            v_cell_style_chu_ok.BackColor = Color.Black;

            C1.Win.C1FlexGrid.CellStyle v_cell_style_notOK_in_data = this.m_fg.Styles.Add("RowColorNotOk");
            v_cell_style_notOK_in_data.BackColor = Color.Green;

            //so sánh từng hóa đơn với MA_HD_NCC trong List vpp
            for (int v_i_row_fg = 1; v_i_row_fg < m_fg.Rows.Count; v_i_row_fg++)
            {
                VanPhongPham v_dm_vpp = new VanPhongPham();
                grid2vpp_object(v_dm_vpp, v_i_row_fg);
                List<VanPhongPham> v_lst_find_match = new List<VanPhongPham>();
                v_lst_find_match = v_lst_vpp.FindAll(x => /*x.MA == v_dm_vpp.MA ||*/x.TEN == v_dm_vpp.TEN);
                if (v_lst_find_match.Count > 0)
                {
                    if (v_dm_vpp.GIA_TRI_CHUA_VAT != v_lst_find_match[0].GIA_TRI_CHUA_VAT)
                    {
                        m_fg.SetCellStyle(v_i_row_fg, 5, v_cell_style_err2);
                    }
                    if (v_dm_vpp.GIA_TRI_GOM_VAT != v_lst_find_match[0].GIA_TRI_GOM_VAT)
                    {
                        m_fg.SetCellStyle(v_i_row_fg, 6, v_cell_style_err2);
                    }
                }
                else
                {
                    m_fg.SetCellStyle(v_i_row_fg, 5, v_cell_style_err);
                    m_fg.SetCellStyle(v_i_row_fg, 6, v_cell_style_err);
                }

            }
        }
        private void cap_nhat_danh_sach_vpp()
        {
            // dm_vpp to List
            DS_V_DM_VPP v_ds_v_dm_vpp = new DS_V_DM_VPP();
            m_us.FillDataset(v_ds_v_dm_vpp, "where id_nha_cung_cap=" + m_cbo_nha_cung_cap.SelectedValue.ToString());
            // datatable to list, nhiem vu: tim id vpp
            List<VanPhongPham> v_lst_vpp = new List<VanPhongPham>();
            foreach (DataRow v_dr in v_ds_v_dm_vpp.Tables[0].Rows)
            {

                var vpp = new VanPhongPham();
                vpp.ID = CIPConvert.ToDecimal(v_dr[V_DM_VPP.ID_VPP]);
                vpp.ID_NHA_CUNG_CAP = CIPConvert.ToDecimal(m_cbo_nha_cung_cap.SelectedValue.ToString());
                vpp.MA = v_dr[V_DM_VPP.MA].ToString();
                vpp.TEN = v_dr[V_DM_VPP.TEN_VPP].ToString();
                vpp.DON_VI_TINH = v_dr[V_DM_VPP.DON_VI_TINH].ToString();
                vpp.GIA_TRI_CHUA_VAT = CIPConvert.ToDecimal(v_dr[V_DM_VPP.DON_GIA_CHUA_VAT].ToString());
                vpp.GIA_TRI_GOM_VAT = CIPConvert.ToDecimal(v_dr[V_DM_VPP.DON_GIA_GOM_VAT].ToString());
                //add item to list
                v_lst_vpp.Add(vpp);

            }
            // cap nhat danh sach vpp
            for (int v_i_row_fg = 1; v_i_row_fg < m_fg.Rows.Count; v_i_row_fg++)
            {
                VanPhongPham v_dm_vpp = new VanPhongPham();
                grid2vpp_object(v_dm_vpp, v_i_row_fg);
                List<VanPhongPham> v_lst_find_match = new List<VanPhongPham>();
                v_lst_find_match = v_lst_vpp.FindAll(x => /*x.MA == v_dm_vpp.MA ||*/x.TEN == v_dm_vpp.TEN);
                if (v_lst_find_match.Count == 0)// khi chua co vpp
                {
                    US_DM_VPP v_us_dm_vpp = new US_DM_VPP();
                    v_us_dm_vpp.dcID_NHA_CUNG_CAP = CIPConvert.ToDecimal(m_cbo_nha_cung_cap.SelectedValue.ToString());
                    v_us_dm_vpp.dcDON_GIA_CHUA_VAT = CIPConvert.ToDecimal(m_fg.Rows[v_i_row_fg][5].ToString());
                    v_us_dm_vpp.dcDON_GIA_GOM_VAT = CIPConvert.ToDecimal(m_fg.Rows[v_i_row_fg][6].ToString());
                    v_us_dm_vpp.strMA = m_fg.Rows[v_i_row_fg][2].ToString();
                    v_us_dm_vpp.strTEN = m_fg.Rows[v_i_row_fg][3].ToString();
                    v_us_dm_vpp.strDON_VI_TINH = m_fg.Rows[v_i_row_fg][4].ToString();
                    v_us_dm_vpp.Insert();
                }
                else //cap nhat don gia
                {
                    US_DM_VPP v_us_dm_vpp = new US_DM_VPP(v_lst_find_match[0].ID);
                    v_us_dm_vpp.dcDON_GIA_CHUA_VAT = CIPConvert.ToDecimal(m_fg.Rows[v_i_row_fg][5].ToString());
                    v_us_dm_vpp.dcDON_GIA_GOM_VAT = CIPConvert.ToDecimal(m_fg.Rows[v_i_row_fg][6].ToString());
                    v_us_dm_vpp.Update();
                }
            }
        }
        private void excel_file_to_dataset(string ip_str_file_path)
        {
            CExcelReport v_cer = new CExcelReport(ip_str_file_path);
            //tao 1 dataset de luu du lieu tu file excel
            m_ds_temp = new DataSet();
            m_dt_temp = new DataTable();
            m_dt_temp.TableName = "DM_VPP";
            m_dt_temp.Columns.Add("Temp");//cot thua
            m_dt_temp.Columns.Add("STT");
            m_dt_temp.Columns.Add("MA_SAN_PHAM");
            m_dt_temp.Columns.Add("TEN_VPP");
            m_dt_temp.Columns.Add("DON_VI_TINH");
            m_dt_temp.Columns.Add("DON_GIA_CHUA_VAT");
            m_dt_temp.Columns.Add("DON_GIA_GOM_VAT");
            m_ds_temp.Tables.Add(m_dt_temp);
            //data from excel file to dataset and fill to grid
            v_cer.Export2DatasetDSPhongThi(m_ds_temp, m_ds_temp.Tables[0].TableName, 10);
            m_ds_temp.Tables[0].Columns.RemoveAt(0);//loai bo cot thua
            m_ds_temp.AcceptChanges();
            //format lai 2 cot don gia
            for (int i = 0; i < m_ds_temp.Tables[0].Rows.Count; i++)
            {
                m_ds.Tables[0].Rows[i][2] = CIPConvert.ToDecimal(m_ds.Tables[0].Rows[i][2]).ToString();
                m_ds.Tables[0].Rows[i][3] = CIPConvert.ToDecimal(m_ds.Tables[0].Rows[i][3]).ToString();
            }
            m_fg.DataSource = m_ds_temp.Tables[0];
        }
        private void insert_v_dm_vpp()
        {
         F604_v_dm_vpp_de v_fDE = new  F604_v_dm_vpp_de();								
           v_fDE.display_for_insert();
            load_data_2_grid();
        }

        private void update_v_dm_vpp()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            F604_v_dm_vpp_de v_fDE = new F604_v_dm_vpp_de();
            v_fDE.display_for_update(m_us);
            load_data_2_grid();
        }

        private void delete_v_dm_vpp()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_V_DM_VPP v_us = new US_V_DM_VPP();
            grid2us_object(v_us, m_fg.Row);
            US_DM_VPP v_us_dm = new US_DM_VPP();
            v_us_dm.dcID = v_us.dcID_VPP;
            try
            {
                v_us_dm.BeginTransaction();
                v_us_dm.Delete();
                v_us_dm.CommitTransaction();
                m_fg.Rows.Remove(m_fg.Row);
            }
            catch (Exception v_e)
            {
                v_us_dm.Rollback();
                CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
                    new CDBClientDBExceptionInterpret());
                v_objErrHandler.showErrorMessage();
            }
        }

        private void view_v_dm_vpp()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            //	F603_cap_nhat_danh_sach_vpp_DE v_fDE = new F603_cap_nhat_danh_sach_vpp_DE();			
            //	v_fDE.display(m_us);
        }

        #endregion

        #region Events
        private void F603_cap_nhat_danh_sach_vpp_Load(object sender, System.EventArgs e)
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
                insert_v_dm_vpp();
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
                update_v_dm_vpp();
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
                delete_v_dm_vpp();
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
                view_v_dm_vpp();
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
                update_v_dm_vpp();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }


        void m_cmd_chon_file_bang_gia_Click(object sender, EventArgs e)
        {
            try
            {
                m_ofd_bang_gia.Filter = "File Excel|*.xls";
                m_ofd_bang_gia.Title = "Hãy chọn file excel";
                m_ofd_bang_gia.FileName = "Chọn file excel";
                DialogResult result = m_ofd_bang_gia.ShowDialog();
                if (result == DialogResult.Cancel) return;
                if (result == DialogResult.OK) // Test result.
                {
                    //m_txt_file_path.Text = m_openDiaglog.FileName;
                    excel_file_to_dataset(m_ofd_bang_gia.FileName);
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_hien_thi_du_lieu_Click(object sender, EventArgs e)
        {
            try
            {
                check_update_data();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }
        void m_cmd_cap_nhat_danh_sach_vpp_Click(object sender, EventArgs e)
        {
            try
            {
                cap_nhat_danh_sach_vpp();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        #endregion
    }
}
