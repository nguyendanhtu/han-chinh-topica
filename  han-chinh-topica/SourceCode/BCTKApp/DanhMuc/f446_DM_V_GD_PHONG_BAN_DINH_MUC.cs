///************************************************
/// Generated by: HuyTD
/// Date: 12/07/2014 12:26:58
/// Goal: Create Form for V_GD_PHONG_BAN_DINH_MUC
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
using IP.Core.IPExcelReport;

using BCTKUS;
using BCTKDS;
using BCTKDS.CDBNames;

using BCTKApp.DanhMuc;

using C1.Win.C1FlexGrid;

namespace BCTKApp
{



    public class f446_DM_V_GD_PHONG_BAN_DINH_MUC : System.Windows.Forms.Form
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
        private Label m_lbl_loai_dm;
        private ComboBox m_cbo_loai_dm;
        private Label m_lbl_trung_tam;
        private ComboBox m_cbo_trung_tam;
        private Label m_lbl_tim_kiem;
        private TextBox m_txt_tim_kiem;
        private System.ComponentModel.IContainer components;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f446_DM_V_GD_PHONG_BAN_DINH_MUC));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_view = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.m_lbl_loai_dm = new System.Windows.Forms.Label();
            this.m_cbo_loai_dm = new System.Windows.Forms.ComboBox();
            this.m_lbl_trung_tam = new System.Windows.Forms.Label();
            this.m_cbo_trung_tam = new System.Windows.Forms.ComboBox();
            this.m_lbl_tim_kiem = new System.Windows.Forms.Label();
            this.m_txt_tim_kiem = new System.Windows.Forms.TextBox();
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
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 471);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(903, 36);
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
            this.m_cmd_insert.Location = new System.Drawing.Point(547, 4);
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
            this.m_cmd_update.Location = new System.Drawing.Point(635, 4);
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
            this.m_cmd_delete.Location = new System.Drawing.Point(723, 4);
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
            this.m_cmd_exit.Location = new System.Drawing.Point(811, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_fg.Location = new System.Drawing.Point(0, 141);
            this.m_fg.Name = "m_fg";
            this.m_fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.m_fg.Size = new System.Drawing.Size(903, 330);
            this.m_fg.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
            this.m_fg.TabIndex = 20;
            this.m_fg.DoubleClick += new System.EventHandler(this.m_fg_DoubleClick);
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.AutoSize = true;
            this.m_lbl_header.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(273, 9);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(359, 22);
            this.m_lbl_header.TabIndex = 21;
            this.m_lbl_header.Text = "CƠ SỞ ĐỊNH MỨC THEO TRUNG TÂM";
            // 
            // m_lbl_loai_dm
            // 
            this.m_lbl_loai_dm.AutoSize = true;
            this.m_lbl_loai_dm.Location = new System.Drawing.Point(244, 47);
            this.m_lbl_loai_dm.Name = "m_lbl_loai_dm";
            this.m_lbl_loai_dm.Size = new System.Drawing.Size(115, 13);
            this.m_lbl_loai_dm.TabIndex = 22;
            this.m_lbl_loai_dm.Text = "Lọc theo loại định mức";
            // 
            // m_cbo_loai_dm
            // 
            this.m_cbo_loai_dm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.m_cbo_loai_dm.FormattingEnabled = true;
            this.m_cbo_loai_dm.Location = new System.Drawing.Point(365, 44);
            this.m_cbo_loai_dm.Name = "m_cbo_loai_dm";
            this.m_cbo_loai_dm.Size = new System.Drawing.Size(305, 21);
            this.m_cbo_loai_dm.TabIndex = 23;
            // 
            // m_lbl_trung_tam
            // 
            this.m_lbl_trung_tam.AutoSize = true;
            this.m_lbl_trung_tam.Location = new System.Drawing.Point(244, 75);
            this.m_lbl_trung_tam.Name = "m_lbl_trung_tam";
            this.m_lbl_trung_tam.Size = new System.Drawing.Size(96, 13);
            this.m_lbl_trung_tam.TabIndex = 22;
            this.m_lbl_trung_tam.Text = "Lọc theo trung tâm";
            // 
            // m_cbo_trung_tam
            // 
            this.m_cbo_trung_tam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.m_cbo_trung_tam.FormattingEnabled = true;
            this.m_cbo_trung_tam.Location = new System.Drawing.Point(365, 72);
            this.m_cbo_trung_tam.Name = "m_cbo_trung_tam";
            this.m_cbo_trung_tam.Size = new System.Drawing.Size(305, 21);
            this.m_cbo_trung_tam.TabIndex = 23;
            // 
            // m_lbl_tim_kiem
            // 
            this.m_lbl_tim_kiem.AutoSize = true;
            this.m_lbl_tim_kiem.Location = new System.Drawing.Point(244, 102);
            this.m_lbl_tim_kiem.Name = "m_lbl_tim_kiem";
            this.m_lbl_tim_kiem.Size = new System.Drawing.Size(88, 13);
            this.m_lbl_tim_kiem.TabIndex = 24;
            this.m_lbl_tim_kiem.Text = "Từ khóa tìm kiếm";
            // 
            // m_txt_tim_kiem
            // 
            this.m_txt_tim_kiem.Location = new System.Drawing.Point(365, 99);
            this.m_txt_tim_kiem.Name = "m_txt_tim_kiem";
            this.m_txt_tim_kiem.Size = new System.Drawing.Size(305, 20);
            this.m_txt_tim_kiem.TabIndex = 25;
            // 
            // f446_DM_V_GD_PHONG_BAN_DINH_MUC
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(903, 507);
            this.Controls.Add(this.m_txt_tim_kiem);
            this.Controls.Add(this.m_lbl_tim_kiem);
            this.Controls.Add(this.m_cbo_trung_tam);
            this.Controls.Add(this.m_lbl_trung_tam);
            this.Controls.Add(this.m_cbo_loai_dm);
            this.Controls.Add(this.m_lbl_loai_dm);
            this.Controls.Add(this.m_lbl_header);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f446_DM_V_GD_PHONG_BAN_DINH_MUC";
            this.Text = "F446 - Cở định mức theo trung tâm";
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Public Interface
        public f446_DM_V_GD_PHONG_BAN_DINH_MUC()
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
        public void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            ID_DM_CO_SO = 11
,
            MA = 5
                ,
            TEN_CO_SO_DINH_MUC = 4
                ,
            ID_LOAI_DINH_MUC = 12
                ,
            MO_TA = 6
                ,
            ID_LOAI_CO_SO = 8
                ,
            TEN_PHONG_BAN = 3
                ,
            ID_CO_SO_DINH_MUC = 13
                ,
            MA_CO_SO_DINH_MUC = 10
                ,
            ID_PHONG_BAN = 14
                ,
            ID_LOAI_CO_SO_DINH_MUC = 9
                ,
            TEN_LOAI_DINH_MUC = 1
                ,
            MA_PHONG_BAN = 2
                , TEN_LOAI_CO_SO = 7

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_V_GD_PHONG_BAN_DINH_MUC m_ds = new DS_V_GD_PHONG_BAN_DINH_MUC();
        US_V_GD_PHONG_BAN_DINH_MUC m_us = new US_V_GD_PHONG_BAN_DINH_MUC();
        bool m_trang_thai = false;
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            m_fg.Tree.Column = (int)e_col_Number.TEN_LOAI_DINH_MUC;
            m_fg.Cols[(int)e_col_Number.TEN_LOAI_DINH_MUC].Visible = true;
            m_fg.Cols[0].Caption = "STT";
            m_fg.Tree.Style = C1.Win.C1FlexGrid.TreeStyleFlags.ButtonBar;
            // m_lbl_header
            // 
            this.m_lbl_header.AutoSize = true;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(273, 9);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(372, 24);
            this.m_lbl_header.TabIndex = 21;
            this.m_lbl_header.Text = "CƠ SỞ ĐỊNH MỨC THEO TRUNG TÂM";
            // 
            this.MinimizeBox = true;
            load_cbo_trung_tam();
            load_cbo_loai_dinh_muc();
            set_define_events();
            this.KeyPreview = true;
        }
        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_fg);
            load_data_2_grid();
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_GD_PHONG_BAN_DINH_MUC.ID_DM_CO_SO, e_col_Number.ID_DM_CO_SO);
            v_htb.Add(V_GD_PHONG_BAN_DINH_MUC.MA, e_col_Number.MA);
            v_htb.Add(V_GD_PHONG_BAN_DINH_MUC.TEN_CO_SO_DINH_MUC, e_col_Number.TEN_CO_SO_DINH_MUC);
            v_htb.Add(V_GD_PHONG_BAN_DINH_MUC.ID_LOAI_DINH_MUC, e_col_Number.ID_LOAI_DINH_MUC);
            v_htb.Add(V_GD_PHONG_BAN_DINH_MUC.MO_TA, e_col_Number.MO_TA);
            v_htb.Add(V_GD_PHONG_BAN_DINH_MUC.ID_LOAI_CO_SO, e_col_Number.ID_LOAI_CO_SO);
            v_htb.Add(V_GD_PHONG_BAN_DINH_MUC.TEN_PHONG_BAN, e_col_Number.TEN_PHONG_BAN);
            v_htb.Add(V_GD_PHONG_BAN_DINH_MUC.ID_CO_SO_DINH_MUC, e_col_Number.ID_CO_SO_DINH_MUC);
            v_htb.Add(V_GD_PHONG_BAN_DINH_MUC.MA_CO_SO_DINH_MUC, e_col_Number.MA_CO_SO_DINH_MUC);
            v_htb.Add(V_GD_PHONG_BAN_DINH_MUC.ID_PHONG_BAN, e_col_Number.ID_PHONG_BAN);
            v_htb.Add(V_GD_PHONG_BAN_DINH_MUC.ID_LOAI_CO_SO_DINH_MUC, e_col_Number.ID_LOAI_CO_SO_DINH_MUC);
            v_htb.Add(V_GD_PHONG_BAN_DINH_MUC.TEN_LOAI_DINH_MUC, e_col_Number.TEN_LOAI_DINH_MUC);
            v_htb.Add(V_GD_PHONG_BAN_DINH_MUC.MA_PHONG_BAN, e_col_Number.MA_PHONG_BAN);
            v_htb.Add(V_GD_PHONG_BAN_DINH_MUC.TEN_LOAI_CO_SO, e_col_Number.TEN_LOAI_CO_SO);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_GD_PHONG_BAN_DINH_MUC.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            string v_str_tim_kiem = m_txt_tim_kiem.Text.Trim();
            decimal v_dc_id_trung_tam = CIPConvert.ToDecimal(m_cbo_trung_tam.SelectedValue);
            decimal v_dc_id_loai_dm = CIPConvert.ToDecimal(m_cbo_loai_dm.SelectedValue);
            m_ds = new DS_V_GD_PHONG_BAN_DINH_MUC();
            m_us.FillDataset(m_ds, v_dc_id_trung_tam, v_dc_id_loai_dm, v_str_tim_kiem);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            CGridUtils.MakeSoTT(0, m_fg);
            m_fg.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Count // chỗ này dùng hàm count tức là để đếm, có thể dùng các hàm khác thay thế
            , 0
            , (int)e_col_Number.TEN_LOAI_DINH_MUC // chỗ này là tên trường mà mình nhóm
            , (int)e_col_Number.MA_PHONG_BAN // chỗ này là tên trường mà mình Count
            , "{0}"
            );
            m_fg.Redraw = true;
            m_fg.Tree.Show(0);
        }
        private void grid2us_object(US_V_GD_PHONG_BAN_DINH_MUC i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_V_GD_PHONG_BAN_DINH_MUC i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }
        private void tim_kiem()
        {
            string v_str_tim_kiem = m_txt_tim_kiem.Text.Trim();
            decimal v_dc_id_trung_tam = CIPConvert.ToDecimal(m_cbo_trung_tam.SelectedValue);
            decimal v_dc_id_loai_dm = CIPConvert.ToDecimal(m_cbo_loai_dm.SelectedValue);
            m_ds = new DS_V_GD_PHONG_BAN_DINH_MUC();
            m_us.FillDataset(m_ds, v_dc_id_trung_tam, v_dc_id_loai_dm, v_str_tim_kiem);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            CGridUtils.MakeSoTT(0, m_fg);
            m_fg.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Count // chỗ này dùng hàm count tức là để đếm, có thể dùng các hàm khác thay thế
            , 0
            , (int)e_col_Number.TEN_LOAI_DINH_MUC // chỗ này là tên trường mà mình nhóm
            , (int)e_col_Number.MA_PHONG_BAN // chỗ này là tên trường mà mình Count
            , "{0}"
            );
            m_fg.Redraw = true;
        }
        private void load_cbo_trung_tam()
        {
            m_trang_thai = false;
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
            m_trang_thai = true;
        }
        private void load_cbo_loai_dinh_muc()
        {
            m_trang_thai = false;
            BCTKUS.US_CM_DM_TU_DIEN v_us = new BCTKUS.US_CM_DM_TU_DIEN();
            BCTKDS.DS_CM_DM_TU_DIEN v_ds = new BCTKDS.DS_CM_DM_TU_DIEN();
            v_us.FillDataset(v_ds, "where id_loai_tu_dien =" + 17);
            m_cbo_loai_dm.DataSource = v_ds.CM_DM_TU_DIEN;
            m_cbo_loai_dm.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_loai_dm.DisplayMember = CM_DM_TU_DIEN.TEN;
            DataRow v_dr = v_ds.CM_DM_TU_DIEN.NewRow();
            v_dr[CM_DM_TU_DIEN.ID] = -1;
            v_dr[CM_DM_TU_DIEN.ID_LOAI_TU_DIEN] = 17;
            v_dr[CM_DM_TU_DIEN.MA_TU_DIEN] = " ";
            v_dr[CM_DM_TU_DIEN.TEN] = "Tất cả";
            v_dr[CM_DM_TU_DIEN.TEN_NGAN] = "Tất cả";
            v_ds.CM_DM_TU_DIEN.Rows.InsertAt(v_dr, 0);
            m_cbo_loai_dm.SelectedIndex = 0;
            m_trang_thai = true;
        }
        private void insert_v_gd_phong_ban_dinh_muc()
        {
            f448_DM_V_GD_PHONG_BAN_DINH_MUC_DE v_frm = new f448_DM_V_GD_PHONG_BAN_DINH_MUC_DE();
            v_frm.Display();
            load_data_2_grid();
        }

        private void update_v_gd_phong_ban_dinh_muc()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (m_fg.Rows[m_fg.Row].IsNode) return;
            grid2us_object(m_us, m_fg.Row);
            f448_DM_V_GD_PHONG_BAN_DINH_MUC_DE v_fDE = new f448_DM_V_GD_PHONG_BAN_DINH_MUC_DE();
            v_fDE.display(m_us);
            load_data_2_grid();
        }

        private void delete_v_gd_phong_ban_dinh_muc()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (m_fg.Rows[m_fg.Row].IsNode) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_V_GD_PHONG_BAN_DINH_MUC v_us = new US_V_GD_PHONG_BAN_DINH_MUC();
            grid2us_object(v_us, m_fg.Row);
            try
            {
                v_us.BeginTransaction();
                v_us.Delete();
                v_us.CommitTransaction();
                m_fg.Rows.Remove(m_fg.Row);
            }
            catch (Exception v_e)
            {
                v_us.Rollback();
                CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
                    new CDBClientDBExceptionInterpret());
                v_objErrHandler.showErrorMessage();
            }
        }

        private void view_v_gd_phong_ban_dinh_muc()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            //	f446_DM_V_GD_PHONG_BAN_DINH_MUC_DE v_fDE = new f446_DM_V_GD_PHONG_BAN_DINH_MUC_DE();			
            //	v_fDE.display(m_us);
        }
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
            m_txt_tim_kiem.TextChanged += new System.EventHandler(m_txt_tim_kiem_TextChanged);
            m_cbo_trung_tam.SelectedIndexChanged += new System.EventHandler(m_cbo_trung_tam_SelectedIndexChanged);
            m_cbo_loai_dm.SelectedIndexChanged += new System.EventHandler(m_cbo_loai_dm_SelectedIndexChanged);
            KeyDown += new System.Windows.Forms.KeyEventHandler(f446_DM_V_GD_PHONG_BAN_DINH_MUC_KeyDown);
            Load += new System.EventHandler(f446_DM_V_GD_PHONG_BAN_DINH_MUC_Load);
        }
        #endregion

        #region Event

        private void f446_DM_V_GD_PHONG_BAN_DINH_MUC_Load(object sender, System.EventArgs e)
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
                insert_v_gd_phong_ban_dinh_muc();
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
                update_v_gd_phong_ban_dinh_muc();
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
                delete_v_gd_phong_ban_dinh_muc();
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
                view_v_gd_phong_ban_dinh_muc();
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

        private void m_cbo_loai_dm_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_trang_thai == true)
                    tim_kiem();
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
                if (m_trang_thai == true)
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
                if (m_fg.Rows[m_fg.Row].IsNode)
                {
                    return;
                }
                update_v_gd_phong_ban_dinh_muc();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void f446_DM_V_GD_PHONG_BAN_DINH_MUC_KeyDown(object sender, KeyEventArgs e)
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

