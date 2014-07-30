///************************************************
/// Generated by: TuNA
/// Date: 04-07-2014 03:49:44
/// Goal: Create Form for V_BC_CHI_TIET_DM
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



    public class f706_V_BC_CHI_TIET_DM : System.Windows.Forms.Form
    {
        internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private Label m_lbl_den_ngay;
        private Label label2;
        private Label m_lbl_tu_ngay;
        private Label m_lbl_ten_phong_ban;
        private Label label1;
        private Label m_lbl_header;
        private Label m_lbl_tong_dm;
        private Label label3;
        private Panel panel1;
        private System.ComponentModel.IContainer components;

        public f706_V_BC_CHI_TIET_DM()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f706_V_BC_CHI_TIET_DM));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_lbl_den_ngay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_lbl_tu_ngay = new System.Windows.Forms.Label();
            this.m_lbl_ten_phong_ban = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.m_lbl_tong_dm = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 494);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(1220, 36);
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
            this.m_cmd_exit.Location = new System.Drawing.Point(1128, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(0, 118);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(1220, 376);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 20;
            // 
            // m_lbl_den_ngay
            // 
            this.m_lbl_den_ngay.AutoSize = true;
            this.m_lbl_den_ngay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_den_ngay.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_den_ngay.Location = new System.Drawing.Point(703, 10);
            this.m_lbl_den_ngay.Name = "m_lbl_den_ngay";
            this.m_lbl_den_ngay.Size = new System.Drawing.Size(81, 19);
            this.m_lbl_den_ngay.TabIndex = 27;
            this.m_lbl_den_ngay.Text = "29/06/2014";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(619, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Đến ngày:";
            // 
            // m_lbl_tu_ngay
            // 
            this.m_lbl_tu_ngay.AutoSize = true;
            this.m_lbl_tu_ngay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_tu_ngay.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_tu_ngay.Location = new System.Drawing.Point(461, 10);
            this.m_lbl_tu_ngay.Name = "m_lbl_tu_ngay";
            this.m_lbl_tu_ngay.Size = new System.Drawing.Size(81, 19);
            this.m_lbl_tu_ngay.TabIndex = 29;
            this.m_lbl_tu_ngay.Text = "01/01/2001";
            // 
            // m_lbl_ten_phong_ban
            // 
            this.m_lbl_ten_phong_ban.AutoSize = true;
            this.m_lbl_ten_phong_ban.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_ten_phong_ban.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_ten_phong_ban.Location = new System.Drawing.Point(33, 46);
            this.m_lbl_ten_phong_ban.Name = "m_lbl_ten_phong_ban";
            this.m_lbl_ten_phong_ban.Size = new System.Drawing.Size(106, 19);
            this.m_lbl_ten_phong_ban.TabIndex = 30;
            this.m_lbl_ten_phong_ban.Text = "Tên phòng ban";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(385, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Từ ngày:";
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(1220, 42);
            this.m_lbl_header.TabIndex = 26;
            this.m_lbl_header.Text = "CHI TIẾT TỔNG ĐỊNH MỨC THEO TRUNG TÂM - BAN";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_lbl_tong_dm
            // 
            this.m_lbl_tong_dm.AutoSize = true;
            this.m_lbl_tong_dm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_tong_dm.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_tong_dm.Location = new System.Drawing.Point(979, 46);
            this.m_lbl_tong_dm.Name = "m_lbl_tong_dm";
            this.m_lbl_tong_dm.Size = new System.Drawing.Size(17, 19);
            this.m_lbl_tong_dm.TabIndex = 32;
            this.m_lbl_tong_dm.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(830, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tổng tiền định mức:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.m_lbl_tong_dm);
            this.panel1.Controls.Add(this.m_lbl_ten_phong_ban);
            this.panel1.Controls.Add(this.m_lbl_den_ngay);
            this.panel1.Controls.Add(this.m_lbl_tu_ngay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 76);
            this.panel1.TabIndex = 34;
            // 
            // f706_V_BC_CHI_TIET_DM
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1220, 530);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_lbl_header);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f706_V_BC_CHI_TIET_DM";
            this.Text = "F706 - Báo cáo chi tiết định mức";
            this.Load += new System.EventHandler(this.f706_V_BC_CHI_TIET_DM_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m_fg_KeyDown);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }
        public void Display_for_chi_tiet(decimal ip_v_id_phong_ban, DateTime ip_v_dt_tu_ngay, DateTime ip_v_dt_den_ngay)
        {
            m_obj_trans = get_trans_object(m_fg);
            format_controls();
            US_DM_PHONG_BAN v_us_dm_pb = new US_DM_PHONG_BAN();
            DS_DM_PHONG_BAN v_ds_dm_pb = new DS_DM_PHONG_BAN();
            v_us_dm_pb.FillDataset(v_ds_dm_pb, "where ID =" + ip_v_id_phong_ban);
            m_lbl_ten_phong_ban.Text = v_ds_dm_pb.Tables[0].Rows[0][2].ToString();
            m_lbl_tu_ngay.Text = ip_v_dt_tu_ngay.Date.ToShortDateString();
            m_lbl_den_ngay.Text = ip_v_dt_den_ngay.Date.ToShortDateString();
            DS_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN v_ds = new DS_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN();
            //US_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN v_us = new US_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN();
            //m_us.FillDataset_chi_tiet_dm(m_ds, ip_v_id_phong_ban, ip_v_dt_tu_ngay, ip_v_dt_den_ngay);
            m_dt_den_ngay = ip_v_dt_den_ngay;
            m_dt_tu_ngay = ip_v_dt_tu_ngay;
            m_id_phong_ban = ip_v_id_phong_ban;
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            CGridUtils.MakeSoTT(0, m_fg);
            //m_fg.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Count // chỗ này dùng hàm count tức là để đếm, có thể dùng các hàm khác thay thế
            // , 0
            // , (int)e_col_Number.LOAI_TK // chỗ này là tên trường mà mình nhóm
            // , (int)e_col_Number.GIA_TRI_THONG_KE // chỗ này là tên trường mà mình Count
            // , "{0}"
            // );
            //m_fg.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum
            //    , 0
            //    , (int)e_col_Number.LOAI_TK
            //    , (int)e_col_Number.DINH_MUC
            //    , "{0}"
            //    );
            m_fg.Redraw = true;
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            TONG_TIEN_DM=1
            ,DON_GIA = 2
            ,GIA_TRI_THONG_KE = 3
            ,DON_VI_TK = 4
            ,CO_SO_DINH_MUC = 5
                ,
            TEN_THONG_KE = 6
            ,LOAI_THOI_GIAN = 7
            ,TU_NGAY = 8
            ,DEN_NGAY = 9
            ,TEN_CO_SO_TINH_DM=10

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        decimal m_id_phong_ban;
        DateTime m_dt_tu_ngay, m_dt_den_ngay;
        DS_V_BC_CHI_TIET_DM m_ds = new DS_V_BC_CHI_TIET_DM();
        US_V_BC_CHI_TIET_DM m_us = new US_V_BC_CHI_TIET_DM();

        #endregion

        #region Private Methods
        private void format_controls()
        {
            //CControlFormat.setFormStyle(this, new CAppContext_201());
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            //m_fg.Tree.Column = (int)e_col_Number.TEN_THUOC;
            //m_fg.Tree.Column = (int)e_col_Number.LOAI_TK;
            //m_fg.Cols[(int)e_col_Number.LOAI_TK].Visible = false;
            
            set_caption_of_grid();
            m_fg.Tree.Style = C1.Win.C1FlexGrid.TreeStyleFlags.Complete;
            set_define_events();
            this.KeyPreview = true;
        }
        private void set_caption_of_grid(){
            m_fg.Rows.Fixed = 2;
            m_fg.Cols[0].Caption = "STT";
            m_fg[1,(int)e_col_Number.TONG_TIEN_DM] = "(1)=(2)*(3)";
            for (int v_i_cur_col = (int)e_col_Number.DON_GIA; v_i_cur_col < m_fg.Cols.Count;v_i_cur_col++ ){
                m_fg[1,v_i_cur_col] = "("+v_i_cur_col.ToString()+")";
            }

                
            
        }
        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_fg);
            load_data_2_grid();
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_BC_CHI_TIET_DM.DON_VI_THONG_KE, e_col_Number.DON_VI_TK);
            v_htb.Add(V_BC_CHI_TIET_DM.DON_GIA, e_col_Number.DON_GIA);
            v_htb.Add(V_BC_CHI_TIET_DM.DEN_NGAY, e_col_Number.DEN_NGAY);
            v_htb.Add(V_BC_CHI_TIET_DM.TEN_THONG_KE, e_col_Number.TEN_THONG_KE);
            v_htb.Add(V_BC_CHI_TIET_DM.TU_NGAY, e_col_Number.TU_NGAY);
            v_htb.Add(V_BC_CHI_TIET_DM.GIA_TRI_THONG_KE, e_col_Number.GIA_TRI_THONG_KE);
            v_htb.Add(V_BC_CHI_TIET_DM.LOAI_THOI_GIAN, e_col_Number.LOAI_THOI_GIAN);
            v_htb.Add(V_BC_CHI_TIET_DM.MO_TA, e_col_Number.CO_SO_DINH_MUC);
            v_htb.Add(V_BC_CHI_TIET_DM.TEN_CO_SO_DINH_MUC, e_col_Number.TEN_CO_SO_TINH_DM);
            v_htb.Add(V_BC_CHI_TIET_DM.TONG_TIEN_DM, e_col_Number.TONG_TIEN_DM);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_BC_CHI_TIET_DM.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            m_ds = new DS_V_BC_CHI_TIET_DM();
            m_us.FillDataset_chi_tiet_dm(m_ds, m_dt_tu_ngay, m_dt_den_ngay,174,m_id_phong_ban);
            m_fg.Redraw = false;
            decimal v_dc_tong_doanh_thu = 0;
            //m_v_us.get_tong_doanh_thu(v_dc_tong_doanh_thu);
            for (int i = 0; i < m_ds.V_BC_CHI_TIET_DM.Count; i++)
            {
                v_dc_tong_doanh_thu += CIPConvert.ToDecimal(m_ds.Tables[0].Rows[i][m_ds.V_BC_CHI_TIET_DM.TONG_TIEN_DMColumn]);
            }
            m_lbl_tong_dm.Text = CIPConvert.ToStr(v_dc_tong_doanh_thu, "#,###.##") + "   VNĐ";
            //m_fg.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Count // chỗ này dùng hàm count tức là để đếm, có thể dùng các hàm khác thay thế
            //, 0
            //, (int)e_col_Number.LOAI_TK // chỗ này là tên trường mà mình nhóm
            //, (int)e_col_Number.GIA_TRI_THONG_KE // chỗ này là tên trường mà mình Count
            //, "{0}"
            //);
            //m_fg.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum
            //    , 0
            //    , (int)e_col_Number.LOAI_TK
            //    , (int)e_col_Number.DINH_MUC
            //    , "{0}"
            //    );
            m_fg.Redraw = true;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);

            m_fg.Redraw = true;
        }
        private void grid2us_object(US_V_BC_CHI_TIET_DM i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_V_BC_CHI_TIET_DM i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }
       private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            
        }
        #endregion

        //
        //
        //		EVENT HANLDERS
        //
        //
        private void f706_V_BC_CHI_TIET_DM_Load(object sender, System.EventArgs e)
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

