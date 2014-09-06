///************************************************
/// Generated by: Huytd
/// Date: 02/09/2014 08:45:09
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



    public class f462_Nhap_ma_hoa_don_NCC : System.Windows.Forms.Form
    {
        internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg_don_dat_hang;
        internal SIS.Controls.Button.SiSButton m_cmd_delete;
        internal SIS.Controls.Button.SiSButton m_cmd_update;
        internal SIS.Controls.Button.SiSButton m_cmd_insert;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        internal SIS.Controls.Button.SiSButton m_cmd_view;
        private Panel m_pnl_header;
        private Label m_lbl_header;
        private Panel m_pnl_don_dat_hang;
        private Label m_lbl_ds_don_dat_hang;
        private Panel m_pnl_don_dat_hang_de;
        private Label m_lbl_ds_don_dat_hang_de;
        private C1FlexGrid m_fg_don_dat_hang_de;
        private DateTimePicker m_dt_chon_thang;
        private Label m_lbl_tu_ngay;
        private ComboBox m_cbo_loc;
        private Label m_lbl_chon_trang_thai;
        private Label m_lbl_loading;
        internal SIS.Controls.Button.SiSButton m_cmd_save;
        private ToolTip toolTip1;
        private System.ComponentModel.IContainer components;

        public f462_Nhap_ma_hoa_don_NCC()
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
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f462_Nhap_ma_hoa_don_NCC));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_view = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg_don_dat_hang = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_pnl_header = new System.Windows.Forms.Panel();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.m_pnl_don_dat_hang = new System.Windows.Forms.Panel();
            this.m_cbo_loc = new System.Windows.Forms.ComboBox();
            this.m_dt_chon_thang = new System.Windows.Forms.DateTimePicker();
            this.m_lbl_ds_don_dat_hang = new System.Windows.Forms.Label();
            this.m_lbl_chon_trang_thai = new System.Windows.Forms.Label();
            this.m_lbl_loading = new System.Windows.Forms.Label();
            this.m_lbl_tu_ngay = new System.Windows.Forms.Label();
            this.m_pnl_don_dat_hang_de = new System.Windows.Forms.Panel();
            this.m_lbl_ds_don_dat_hang_de = new System.Windows.Forms.Label();
            this.m_fg_don_dat_hang_de = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_cmd_save = new SIS.Controls.Button.SiSButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg_don_dat_hang)).BeginInit();
            this.m_pnl_header.SuspendLayout();
            this.m_pnl_don_dat_hang.SuspendLayout();
            this.m_pnl_don_dat_hang_de.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg_don_dat_hang_de)).BeginInit();
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
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 556);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(921, 36);
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
            this.m_cmd_insert.Location = new System.Drawing.Point(565, 4);
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
            this.m_cmd_update.Location = new System.Drawing.Point(653, 4);
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
            this.m_cmd_delete.Location = new System.Drawing.Point(741, 4);
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
            this.m_cmd_exit.Location = new System.Drawing.Point(829, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_fg_don_dat_hang
            // 
            this.m_fg_don_dat_hang.ColumnInfo = resources.GetString("m_fg_don_dat_hang.ColumnInfo");
            this.m_fg_don_dat_hang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_fg_don_dat_hang.Location = new System.Drawing.Point(0, 49);
            this.m_fg_don_dat_hang.Name = "m_fg_don_dat_hang";
            this.m_fg_don_dat_hang.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.m_fg_don_dat_hang.Size = new System.Drawing.Size(921, 133);
            this.m_fg_don_dat_hang.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg_don_dat_hang.Styles"));
            this.m_fg_don_dat_hang.TabIndex = 20;
            this.toolTip1.SetToolTip(this.m_fg_don_dat_hang, "Click chuột vào ô trên cột Mã HD của NCC để nhập ");
            this.m_fg_don_dat_hang.Click += new System.EventHandler(this.m_fg_don_dat_hang_Click);
            // 
            // m_pnl_header
            // 
            this.m_pnl_header.Controls.Add(this.m_lbl_header);
            this.m_pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_pnl_header.Location = new System.Drawing.Point(0, 0);
            this.m_pnl_header.Name = "m_pnl_header";
            this.m_pnl_header.Size = new System.Drawing.Size(921, 47);
            this.m_pnl_header.TabIndex = 21;
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.AutoSize = true;
            this.m_lbl_header.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(284, 9);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(282, 23);
            this.m_lbl_header.TabIndex = 0;
            this.m_lbl_header.Text = "NHẬP MÃ HÓA ĐƠN TỪ NCC";
            // 
            // m_pnl_don_dat_hang
            // 
            this.m_pnl_don_dat_hang.Controls.Add(this.m_cmd_save);
            this.m_pnl_don_dat_hang.Controls.Add(this.m_cbo_loc);
            this.m_pnl_don_dat_hang.Controls.Add(this.m_dt_chon_thang);
            this.m_pnl_don_dat_hang.Controls.Add(this.m_lbl_ds_don_dat_hang);
            this.m_pnl_don_dat_hang.Controls.Add(this.m_lbl_chon_trang_thai);
            this.m_pnl_don_dat_hang.Controls.Add(this.m_lbl_loading);
            this.m_pnl_don_dat_hang.Controls.Add(this.m_lbl_tu_ngay);
            this.m_pnl_don_dat_hang.Controls.Add(this.m_fg_don_dat_hang);
            this.m_pnl_don_dat_hang.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_pnl_don_dat_hang.Location = new System.Drawing.Point(0, 47);
            this.m_pnl_don_dat_hang.Name = "m_pnl_don_dat_hang";
            this.m_pnl_don_dat_hang.Size = new System.Drawing.Size(921, 182);
            this.m_pnl_don_dat_hang.TabIndex = 22;
            // 
            // m_cbo_loc
            // 
            this.m_cbo_loc.FormattingEnabled = true;
            this.m_cbo_loc.Items.AddRange(new object[] {
            "----------Tất cả---------",
            "Chưa có mã HD từ NCC",
            "Đã có mã HD từ NCC"});
            this.m_cbo_loc.Location = new System.Drawing.Point(445, 13);
            this.m_cbo_loc.Name = "m_cbo_loc";
            this.m_cbo_loc.Size = new System.Drawing.Size(180, 21);
            this.m_cbo_loc.TabIndex = 26;
            this.m_cbo_loc.Text = "Chưa có mã HD từ NCC";
            this.m_cbo_loc.SelectedIndexChanged += new System.EventHandler(this.m_cbo_loc_SelectedIndexChanged);
            // 
            // m_dt_chon_thang
            // 
            this.m_dt_chon_thang.Checked = false;
            this.m_dt_chon_thang.CustomFormat = "MM/yyyy";
            this.m_dt_chon_thang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dt_chon_thang.Location = new System.Drawing.Point(163, 12);
            this.m_dt_chon_thang.Name = "m_dt_chon_thang";
            this.m_dt_chon_thang.Size = new System.Drawing.Size(84, 20);
            this.m_dt_chon_thang.TabIndex = 25;
            this.m_dt_chon_thang.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            // 
            // m_lbl_ds_don_dat_hang
            // 
            this.m_lbl_ds_don_dat_hang.AutoSize = true;
            this.m_lbl_ds_don_dat_hang.Location = new System.Drawing.Point(4, 31);
            this.m_lbl_ds_don_dat_hang.Name = "m_lbl_ds_don_dat_hang";
            this.m_lbl_ds_don_dat_hang.Size = new System.Drawing.Size(127, 13);
            this.m_lbl_ds_don_dat_hang.TabIndex = 21;
            this.m_lbl_ds_don_dat_hang.Text = "Danh sách đơn đặt hàng";
            // 
            // m_lbl_chon_trang_thai
            // 
            this.m_lbl_chon_trang_thai.AutoSize = true;
            this.m_lbl_chon_trang_thai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_chon_trang_thai.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_chon_trang_thai.Location = new System.Drawing.Point(354, 19);
            this.m_lbl_chon_trang_thai.Name = "m_lbl_chon_trang_thai";
            this.m_lbl_chon_trang_thai.Size = new System.Drawing.Size(85, 15);
            this.m_lbl_chon_trang_thai.TabIndex = 24;
            this.m_lbl_chon_trang_thai.Text = "Lọc danh sách";
            // 
            // m_lbl_loading
            // 
            this.m_lbl_loading.AutoSize = true;
            this.m_lbl_loading.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_loading.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_loading.Location = new System.Drawing.Point(337, 31);
            this.m_lbl_loading.Name = "m_lbl_loading";
            this.m_lbl_loading.Size = new System.Drawing.Size(139, 15);
            this.m_lbl_loading.TabIndex = 24;
            this.m_lbl_loading.Text = "Đang thực hiện, xin đợi...";
            this.m_lbl_loading.Visible = false;
            // 
            // m_lbl_tu_ngay
            // 
            this.m_lbl_tu_ngay.AutoSize = true;
            this.m_lbl_tu_ngay.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_tu_ngay.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_tu_ngay.Location = new System.Drawing.Point(89, 16);
            this.m_lbl_tu_ngay.Name = "m_lbl_tu_ngay";
            this.m_lbl_tu_ngay.Size = new System.Drawing.Size(70, 15);
            this.m_lbl_tu_ngay.TabIndex = 24;
            this.m_lbl_tu_ngay.Text = "Chọn tháng";
            // 
            // m_pnl_don_dat_hang_de
            // 
            this.m_pnl_don_dat_hang_de.Controls.Add(this.m_lbl_ds_don_dat_hang_de);
            this.m_pnl_don_dat_hang_de.Controls.Add(this.m_fg_don_dat_hang_de);
            this.m_pnl_don_dat_hang_de.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_don_dat_hang_de.Location = new System.Drawing.Point(0, 248);
            this.m_pnl_don_dat_hang_de.Name = "m_pnl_don_dat_hang_de";
            this.m_pnl_don_dat_hang_de.Size = new System.Drawing.Size(921, 308);
            this.m_pnl_don_dat_hang_de.TabIndex = 23;
            // 
            // m_lbl_ds_don_dat_hang_de
            // 
            this.m_lbl_ds_don_dat_hang_de.AutoSize = true;
            this.m_lbl_ds_don_dat_hang_de.Location = new System.Drawing.Point(4, 7);
            this.m_lbl_ds_don_dat_hang_de.Name = "m_lbl_ds_don_dat_hang_de";
            this.m_lbl_ds_don_dat_hang_de.Size = new System.Drawing.Size(88, 13);
            this.m_lbl_ds_don_dat_hang_de.TabIndex = 21;
            this.m_lbl_ds_don_dat_hang_de.Text = "Chi tiết đơn hàng";
            // 
            // m_fg_don_dat_hang_de
            // 
            this.m_fg_don_dat_hang_de.ColumnInfo = resources.GetString("m_fg_don_dat_hang_de.ColumnInfo");
            this.m_fg_don_dat_hang_de.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_fg_don_dat_hang_de.Location = new System.Drawing.Point(0, 32);
            this.m_fg_don_dat_hang_de.Name = "m_fg_don_dat_hang_de";
            this.m_fg_don_dat_hang_de.Size = new System.Drawing.Size(921, 276);
            this.m_fg_don_dat_hang_de.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg_don_dat_hang_de.Styles"));
            this.m_fg_don_dat_hang_de.TabIndex = 21;
            // 
            // m_cmd_save
            // 
            this.m_cmd_save.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_save.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_save.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_save.ImageIndex = 13;
            this.m_cmd_save.ImageList = this.ImageList;
            this.m_cmd_save.Location = new System.Drawing.Point(684, 3);
            this.m_cmd_save.Name = "m_cmd_save";
            this.m_cmd_save.Size = new System.Drawing.Size(174, 35);
            this.m_cmd_save.TabIndex = 27;
            this.m_cmd_save.Text = "Kiểm tra và lưu mã HD NCC";
            this.m_cmd_save.Click += new System.EventHandler(this.m_cmd_save_Click);
            // 
            // f462_Nhap_ma_hoa_don_NCC
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(921, 592);
            this.Controls.Add(this.m_pnl_don_dat_hang_de);
            this.Controls.Add(this.m_pnl_don_dat_hang);
            this.Controls.Add(this.m_pnl_header);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f462_Nhap_ma_hoa_don_NCC";
            this.Text = "f462 -Nhập mã hóa đơn từ NCC";
            this.Load += new System.EventHandler(this.f461_Nhap_ma_hoa_don_NCC_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg_don_dat_hang)).EndInit();
            this.m_pnl_header.ResumeLayout(false);
            this.m_pnl_header.PerformLayout();
            this.m_pnl_don_dat_hang.ResumeLayout(false);
            this.m_pnl_don_dat_hang.PerformLayout();
            this.m_pnl_don_dat_hang_de.ResumeLayout(false);
            this.m_pnl_don_dat_hang_de.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg_don_dat_hang_de)).EndInit();
            this.ResumeLayout(false);

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
            GIA_TRI_CHUA_VAT = 7
,
            ID = 9
                ,
            NGAY_DAT_HANG = 1
                ,
            TRANG_THAI = 4
                ,
            LAN = 3
                ,
            TEN_PHONG_BAN = 2
                ,
            GIA_TRI_DA_VAT = 8
                ,
            MA_HD = 5
                , MA_HD_NCC = 6

        }
        private enum e_col_Number_de
        {
            MA_VPP = 1
,
            TEN_VPP = 2
                ,
            DON_VI_TINH = 3
                ,
            SO_LUONG = 4
                ,
            DON_GIA_CHUA_VAT = 5
                ,
            DON_GIA_GOM_VAT= 6
        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        ITransferDataRow m_obj_trans_de;
        DS_V_GD_DON_DAT_HANG m_ds = new DS_V_GD_DON_DAT_HANG();
        US_V_GD_DON_DAT_HANG m_us = new US_V_GD_DON_DAT_HANG();
        US_V_GD_DON_DAT_HANG_DETAIL m_us_de = new US_V_GD_DON_DAT_HANG_DETAIL();
        DS_V_GD_DON_DAT_HANG_DETAIL m_ds_de = new DS_V_GD_DON_DAT_HANG_DETAIL();
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            CControlFormat.setC1FlexFormat(m_fg_don_dat_hang);
            CControlFormat.setC1FlexFormat(m_fg_don_dat_hang_de);
            CGridUtils.AddSave_Excel_Handlers(m_fg_don_dat_hang);
            CGridUtils.AddSearch_Handlers(m_fg_don_dat_hang);
            m_fg_don_dat_hang.AllowEditing = true;
            m_fg_don_dat_hang_de.AllowEditing = false;
            m_fg_don_dat_hang.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            m_fg_don_dat_hang.AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.None;
            m_fg_don_dat_hang.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcrossOut;
            m_fg_don_dat_hang.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcrossOut;
            // m_lbl_header
            // 
            this.m_lbl_header.AutoSize = true;
            this.m_lbl_header.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(284, 9);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(282, 23);
            this.m_lbl_header.TabIndex = 0;
            this.m_lbl_header.Text = "NHẬP MÃ HÓA ĐƠN TỪ NCC";
            // 
            set_define_events();
            this.KeyPreview = true;
        }
        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_fg_don_dat_hang);
            m_obj_trans_de = get_trans_object_de(m_fg_don_dat_hang_de);
            load_data_2_grid();
            m_dt_chon_thang.Checked = true;
            m_dt_chon_thang.Value = DateTime.Now.Date;
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_GD_DON_DAT_HANG.GIA_TRI_CHUA_VAT, e_col_Number.GIA_TRI_CHUA_VAT);
            v_htb.Add(V_GD_DON_DAT_HANG.ID, e_col_Number.ID);
            v_htb.Add(V_GD_DON_DAT_HANG.NGAY_DAT_HANG, e_col_Number.NGAY_DAT_HANG);
            v_htb.Add(V_GD_DON_DAT_HANG.TRANG_THAI, e_col_Number.TRANG_THAI);
            v_htb.Add(V_GD_DON_DAT_HANG.LAN, e_col_Number.LAN);
            v_htb.Add(V_GD_DON_DAT_HANG.TEN_PHONG_BAN, e_col_Number.TEN_PHONG_BAN);
            v_htb.Add(V_GD_DON_DAT_HANG.GIA_TRI_DA_VAT, e_col_Number.GIA_TRI_DA_VAT);
            v_htb.Add(V_GD_DON_DAT_HANG.MA_HD, e_col_Number.MA_HD);
            v_htb.Add(V_GD_DON_DAT_HANG.MA_HD_NCC, e_col_Number.MA_HD_NCC);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_GD_DON_DAT_HANG.NewRow());
            return v_obj_trans;
        }
        private ITransferDataRow get_trans_object_de(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_GD_DON_DAT_HANG_DETAIL.MA_VPP, e_col_Number_de.MA_VPP);
            v_htb.Add(V_GD_DON_DAT_HANG_DETAIL.TEN_VPP, e_col_Number_de.TEN_VPP);
            v_htb.Add(V_GD_DON_DAT_HANG_DETAIL.SO_LUONG, e_col_Number_de.SO_LUONG);
            v_htb.Add(V_GD_DON_DAT_HANG_DETAIL.DON_VI_TINH, e_col_Number_de.DON_VI_TINH);
            v_htb.Add(V_GD_DON_DAT_HANG_DETAIL.DON_GIA_CHUA_VAT, e_col_Number_de.DON_GIA_CHUA_VAT);
            v_htb.Add(V_GD_DON_DAT_HANG_DETAIL.DON_GIA_GOM_VAT, e_col_Number_de.DON_GIA_GOM_VAT);
            ITransferDataRow v_obj_trans_de = new CC1TransferDataRow(i_fg, v_htb, m_ds_de.V_GD_DON_DAT_HANG_DETAIL.NewRow());
            return v_obj_trans_de;
        }
        private void load_data_2_grid()
        {
            m_ds = new DS_V_GD_DON_DAT_HANG();
            DateTime v_dt_tu_ngay;
            DateTime v_dt_den_ngay;
            if (!m_dt_chon_thang.Checked)
            {
                v_dt_tu_ngay = new DateTime(1900, 1, 1);
                v_dt_den_ngay = new DateTime(2789, 1, 1);
            }
            else
            {
                v_dt_tu_ngay = m_dt_chon_thang.Value.AddDays(-m_dt_chon_thang.Value.Date.Day + 1);
                v_dt_den_ngay = m_dt_chon_thang.Value.AddMonths(1).AddDays(-m_dt_chon_thang.Value.Day);
            }
            m_us.Nhap_ma_hoa_don_NCC(m_ds, v_dt_tu_ngay, v_dt_den_ngay, CONST_ID_TRANG_THAI_DON_HANG.DA_DUYET);
            m_fg_don_dat_hang.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg_don_dat_hang, m_obj_trans);
            m_fg_don_dat_hang.Redraw = true;
            kiem_tra_du_lieu_don_dat_hang();
        }
        private void load_don_dat_hang_de(string ip_v_ma_phieu)
        {
            US_V_GD_DON_DAT_HANG_DETAIL v_us = new US_V_GD_DON_DAT_HANG_DETAIL();
            DS_V_GD_DON_DAT_HANG_DETAIL v_ds = new DS_V_GD_DON_DAT_HANG_DETAIL();
            v_us.FillDataset(v_ds, "Where MA_DON_HANG =" + "'"+ip_v_ma_phieu+"' order by NGAY_DAT_HANG DESC");
            m_fg_don_dat_hang_de.Redraw = false;
            CGridUtils.Dataset2C1Grid(v_ds, m_fg_don_dat_hang_de, m_obj_trans_de);
            m_fg_don_dat_hang_de.Redraw = true;
        }
        private void grid2us_object(US_V_GD_DON_DAT_HANG i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg_don_dat_hang.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_V_GD_DON_DAT_HANG i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg_don_dat_hang.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }


        private void insert_v_gd_don_dat_hang()
        {
            //	f461_Nhap_ma_hoa_don_NCC_DE v_fDE = new  f461_Nhap_ma_hoa_don_NCC_DE();								
            //	v_fDE.display();
            load_data_2_grid();
        }

        private void update_v_gd_don_dat_hang()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg_don_dat_hang)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg_don_dat_hang, m_fg_don_dat_hang.Row)) return;
            grid2us_object(m_us, m_fg_don_dat_hang.Row);
            //	f461_Nhap_ma_hoa_don_NCC_DE v_fDE = new f461_Nhap_ma_hoa_don_NCC_DE();
            //	v_fDE.display(m_us);
            load_data_2_grid();
        }

        private void delete_v_gd_don_dat_hang()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg_don_dat_hang)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg_don_dat_hang, m_fg_don_dat_hang.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_V_GD_DON_DAT_HANG v_us = new US_V_GD_DON_DAT_HANG();
            grid2us_object(v_us, m_fg_don_dat_hang.Row);
            try
            {
                v_us.BeginTransaction();
                v_us.Delete();
                v_us.CommitTransaction();
                m_fg_don_dat_hang.Rows.Remove(m_fg_don_dat_hang.Row);
            }
            catch (Exception v_e)
            {
                v_us.Rollback();
                CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
                    new CDBClientDBExceptionInterpret());
                v_objErrHandler.showErrorMessage();
            }
        }

        private void view_v_gd_don_dat_hang()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg_don_dat_hang)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg_don_dat_hang, m_fg_don_dat_hang.Row)) return;
            grid2us_object(m_us, m_fg_don_dat_hang.Row);
            //	f461_Nhap_ma_hoa_don_NCC_DE v_fDE = new f461_Nhap_ma_hoa_don_NCC_DE();			
            //	v_fDE.display(m_us);
        }


        private void save_ma_HD_NCC()
        {
            US_GD_DON_DAT_HANG v_us = new US_GD_DON_DAT_HANG();
            DS_GD_DON_DAT_HANG v_ds = new DS_GD_DON_DAT_HANG();
            int v_i_row_fg = 1;

            for (v_i_row_fg = 1; v_i_row_fg < m_ds.V_GD_DON_DAT_HANG.Count; v_i_row_fg++)
            {
                if (m_fg_don_dat_hang.Rows[v_i_row_fg][(int)e_col_Number.MA_HD_NCC].ToString().Trim() != "")
                {
                    v_us.Insert_ma_hdncc(v_ds, m_fg_don_dat_hang.Rows[v_i_row_fg][(int)e_col_Number.MA_HD_NCC].ToString().Trim(), m_fg_don_dat_hang.Rows[v_i_row_fg][(int)e_col_Number.MA_HD].ToString());
                }
                v_ds.Clear();
            }
           
        }
        private void kiem_tra_du_lieu_don_dat_hang()
        {
            US_GD_DON_DAT_HANG v_us = new US_GD_DON_DAT_HANG();
            DS_GD_DON_DAT_HANG v_ds = new DS_GD_DON_DAT_HANG();
            int v_i_row_fg = 1;

            //set Style cell
            C1.Win.C1FlexGrid.CellStyle v_cell_style_err = this.m_fg_don_dat_hang.Styles.Add("RowColorErr");
            v_cell_style_err.BackColor = Color.Yellow;
            C1.Win.C1FlexGrid.CellStyle v_cell_style_err2 = this.m_fg_don_dat_hang.Styles.Add("RowColorErr2");
            v_cell_style_err2.BackColor = Color.Yellow;
            v_cell_style_err2.ForeColor = Color.DarkRed;

            C1.Win.C1FlexGrid.CellStyle v_cell_style_ok = this.m_fg_don_dat_hang.Styles.Add("RowColorOk");
            v_cell_style_ok.BackColor = Color.AliceBlue;
            C1.Win.C1FlexGrid.CellStyle v_cell_style_chu_ok = this.m_fg_don_dat_hang.Styles.Add("RowColor");
            v_cell_style_chu_ok.BackColor = Color.Black;

            C1.Win.C1FlexGrid.CellStyle v_cell_style_notOK_in_data = this.m_fg_don_dat_hang.Styles.Add("RowColorNotOk");
            v_cell_style_notOK_in_data.BackColor = Color.Green;

            for (v_i_row_fg = 1; v_i_row_fg <= m_ds.V_GD_DON_DAT_HANG.Count; v_i_row_fg++)
            {
                //v_us.Kiem_tra_don_dat_hang_hdncc(v_ds, m_ds.V_GD_DON_DAT_HANG.Rows[v_i_row_fg][(int)e_col_Number.MA_HD].ToString());
                //if (v_ds.GD_DON_DAT_HANG.Rows.Count > 0)
                string t = CIPConvert.ToStr(m_fg_don_dat_hang.Rows[v_i_row_fg][(int)e_col_Number.MA_HD_NCC]).Trim();
                if(CIPConvert.ToStr(m_fg_don_dat_hang.Rows[v_i_row_fg][(int)e_col_Number.MA_HD_NCC]).Trim() != "")
                {
                        m_fg_don_dat_hang.SetCellStyle(v_i_row_fg, (int)e_col_Number.MA_HD_NCC, v_cell_style_ok);
                }
                else
                {
                    m_fg_don_dat_hang.SetCellStyle(v_i_row_fg, (int)e_col_Number.MA_HD_NCC, v_cell_style_err);
                    //m_fg.Rows[v_i_row_fg].StyleDisplay.ForeColor = Color.White;
                }
                v_ds.Clear();
            }
        }

        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
            this.m_dt_chon_thang.ValueChanged += new System.EventHandler(this.m_dt_chon_thang_ValueChanged);
            m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
        }
        #endregion

        //
        //
        //		EVENT HANLDERS
        //
        //
        private void f461_Nhap_ma_hoa_don_NCC_Load(object sender, System.EventArgs e)
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
                insert_v_gd_don_dat_hang();
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
                update_v_gd_don_dat_hang();
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
                delete_v_gd_don_dat_hang();
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
                view_v_gd_don_dat_hang();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_fg_don_dat_hang_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_fg_don_dat_hang.Rows[m_fg_don_dat_hang.Row].IsNode)
                {
                    return;
                }
                string v_ma_phieu;
                int i_grid_row = m_fg_don_dat_hang.Selection.TopRow;
                DataRow v_dr = (DataRow)m_fg_don_dat_hang.Rows[i_grid_row].UserData;
                v_ma_phieu = CIPConvert.ToStr(v_dr[7]);
                load_don_dat_hang_de(v_ma_phieu);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_dt_chon_thang_ValueChanged(object sender, EventArgs e)
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
        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                save_ma_HD_NCC();
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cbo_loc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

