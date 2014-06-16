namespace BCTKApp
{
    partial class f140_thong_tin_cuoi_thang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f140_thong_tin_cuoi_thang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_cmd_xoa_trang_den_ngay = new System.Windows.Forms.Button();
            this.m_cmd_xoa_trang_tu_ngay = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.m_cbo_phong_ban = new System.Windows.Forms.ComboBox();
            this.m_dtp_den_ngay_gui = new System.Windows.Forms.DateTimePicker();
            this.m_txt_den_ngay_gui = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.m_dtp_tu_ngay_gui = new System.Windows.Forms.DateTimePicker();
            this.m_txt_tu_ngay_gui = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_cmd_search = new SIS.Controls.Button.SiSButton();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_txt_noi_nhan = new System.Windows.Forms.TextBox();
            this.m_txt_ma_so = new System.Windows.Forms.TextBox();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_xuat_excel = new SIS.Controls.Button.SiSButton();
            this.m_lbl_title = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.m_pnl_out_place_dm.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_cmd_xoa_trang_den_ngay);
            this.groupBox1.Controls.Add(this.m_cmd_xoa_trang_tu_ngay);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.m_cbo_phong_ban);
            this.groupBox1.Controls.Add(this.m_dtp_den_ngay_gui);
            this.groupBox1.Controls.Add(this.m_txt_den_ngay_gui);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.m_dtp_tu_ngay_gui);
            this.groupBox1.Controls.Add(this.m_txt_tu_ngay_gui);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.m_cmd_search);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.m_txt_noi_nhan);
            this.groupBox1.Controls.Add(this.m_txt_ma_so);
            this.groupBox1.Location = new System.Drawing.Point(0, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(981, 147);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // m_cmd_xoa_trang_den_ngay
            // 
            this.m_cmd_xoa_trang_den_ngay.Location = new System.Drawing.Point(392, 113);
            this.m_cmd_xoa_trang_den_ngay.Name = "m_cmd_xoa_trang_den_ngay";
            this.m_cmd_xoa_trang_den_ngay.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_xoa_trang_den_ngay.TabIndex = 30;
            this.m_cmd_xoa_trang_den_ngay.Text = "Xóa trắng";
            this.m_cmd_xoa_trang_den_ngay.UseVisualStyleBackColor = true;
            // 
            // m_cmd_xoa_trang_tu_ngay
            // 
            this.m_cmd_xoa_trang_tu_ngay.Location = new System.Drawing.Point(392, 81);
            this.m_cmd_xoa_trang_tu_ngay.Name = "m_cmd_xoa_trang_tu_ngay";
            this.m_cmd_xoa_trang_tu_ngay.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_xoa_trang_tu_ngay.TabIndex = 29;
            this.m_cmd_xoa_trang_tu_ngay.Text = "Xóa trắng";
            this.m_cmd_xoa_trang_tu_ngay.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(533, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tìm theo văn phòng TOPICA";
            // 
            // m_cbo_phong_ban
            // 
            this.m_cbo_phong_ban.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_phong_ban.Items.AddRange(new object[] {
            "Đang sử dụng",
            "Đã đóng"});
            this.m_cbo_phong_ban.Location = new System.Drawing.Point(684, 116);
            this.m_cbo_phong_ban.Name = "m_cbo_phong_ban";
            this.m_cbo_phong_ban.Size = new System.Drawing.Size(285, 21);
            this.m_cbo_phong_ban.TabIndex = 6;
            // 
            // m_dtp_den_ngay_gui
            // 
            this.m_dtp_den_ngay_gui.CustomFormat = "dd/MM/yyyy";
            this.m_dtp_den_ngay_gui.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dtp_den_ngay_gui.Location = new System.Drawing.Point(281, 114);
            this.m_dtp_den_ngay_gui.Name = "m_dtp_den_ngay_gui";
            this.m_dtp_den_ngay_gui.Size = new System.Drawing.Size(110, 20);
            this.m_dtp_den_ngay_gui.TabIndex = 5;
            // 
            // m_txt_den_ngay_gui
            // 
            this.m_txt_den_ngay_gui.Enabled = false;
            this.m_txt_den_ngay_gui.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txt_den_ngay_gui.Location = new System.Drawing.Point(132, 114);
            this.m_txt_den_ngay_gui.Name = "m_txt_den_ngay_gui";
            this.m_txt_den_ngay_gui.Size = new System.Drawing.Size(146, 21);
            this.m_txt_den_ngay_gui.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Đến ngày";
            // 
            // m_dtp_tu_ngay_gui
            // 
            this.m_dtp_tu_ngay_gui.CustomFormat = "dd/MM/yyyy";
            this.m_dtp_tu_ngay_gui.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dtp_tu_ngay_gui.Location = new System.Drawing.Point(281, 81);
            this.m_dtp_tu_ngay_gui.Name = "m_dtp_tu_ngay_gui";
            this.m_dtp_tu_ngay_gui.Size = new System.Drawing.Size(110, 20);
            this.m_dtp_tu_ngay_gui.TabIndex = 3;
            // 
            // m_txt_tu_ngay_gui
            // 
            this.m_txt_tu_ngay_gui.Enabled = false;
            this.m_txt_tu_ngay_gui.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txt_tu_ngay_gui.Location = new System.Drawing.Point(132, 81);
            this.m_txt_tu_ngay_gui.Name = "m_txt_tu_ngay_gui";
            this.m_txt_tu_ngay_gui.Size = new System.Drawing.Size(146, 21);
            this.m_txt_tu_ngay_gui.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tìm từ ngày";
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_search.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_search.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_search.ImageIndex = 5;
            this.m_cmd_search.ImageList = this.ImageList;
            this.m_cmd_search.Location = new System.Drawing.Point(839, 19);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(92, 67);
            this.m_cmd_search.TabIndex = 7;
            this.m_cmd_search.Text = "Tìm kiếm";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tìm theo nơi nhận";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm theo mã số ";
            // 
            // m_txt_noi_nhan
            // 
            this.m_txt_noi_nhan.Location = new System.Drawing.Point(132, 49);
            this.m_txt_noi_nhan.Name = "m_txt_noi_nhan";
            this.m_txt_noi_nhan.Size = new System.Drawing.Size(259, 20);
            this.m_txt_noi_nhan.TabIndex = 1;
            // 
            // m_txt_ma_so
            // 
            this.m_txt_ma_so.Location = new System.Drawing.Point(132, 23);
            this.m_txt_ma_so.Name = "m_txt_ma_so";
            this.m_txt_ma_so.Size = new System.Drawing.Size(177, 20);
            this.m_txt_ma_so.TabIndex = 0;
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
            this.m_cmd_exit.Location = new System.Drawing.Point(889, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Location = new System.Drawing.Point(1, 194);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(980, 254);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 24;
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_xuat_excel);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 449);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(981, 36);
            this.m_pnl_out_place_dm.TabIndex = 23;
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
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(93, 28);
            this.m_cmd_xuat_excel.TabIndex = 15;
            this.m_cmd_xuat_excel.Text = "Xuất Excel";
            this.m_cmd_xuat_excel.UseVisualStyleBackColor = true;
            // 
            // m_lbl_title
            // 
            this.m_lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_title.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_title.Name = "m_lbl_title";
            this.m_lbl_title.Size = new System.Drawing.Size(981, 38);
            this.m_lbl_title.TabIndex = 26;
            this.m_lbl_title.Text = "F120 - Danh sách đăng ký gửi cuối tháng";
            this.m_lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // f140_thong_tin_cuoi_thang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 485);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Controls.Add(this.m_lbl_title);
            this.Name = "f140_thong_tin_cuoi_thang";
            this.Text = "f140_thong_tin_cuoi_thang";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker m_dtp_den_ngay_gui;
        private System.Windows.Forms.TextBox m_txt_den_ngay_gui;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker m_dtp_tu_ngay_gui;
        private System.Windows.Forms.TextBox m_txt_tu_ngay_gui;
        private System.Windows.Forms.Label label3;
        internal SIS.Controls.Button.SiSButton m_cmd_search;
        internal System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_txt_noi_nhan;
        private System.Windows.Forms.TextBox m_txt_ma_so;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private SIS.Controls.Button.SiSButton m_cmd_xuat_excel;
        private System.Windows.Forms.Label m_lbl_title;
        private System.Windows.Forms.ComboBox m_cbo_phong_ban;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button m_cmd_xoa_trang_den_ngay;
        private System.Windows.Forms.Button m_cmd_xoa_trang_tu_ngay;

    }
}