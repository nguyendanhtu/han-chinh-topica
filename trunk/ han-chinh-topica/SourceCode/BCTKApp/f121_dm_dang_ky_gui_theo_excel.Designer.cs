namespace BCTKApp
{
    partial class f121_dm_dang_ky_gui_theo_excel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f121_dm_dang_ky_gui_theo_excel));
            this.m_lbl_title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_thoat = new SIS.Controls.Button.SiSButton();
            this.m_lbl_label_tong_sl_tp = new System.Windows.Forms.Label();
            this.m_lbl_tong_so_luong = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.m_cbo_phong_ban = new System.Windows.Forms.ComboBox();
            this.m_cmd_luu = new SIS.Controls.Button.SiSButton();
            this.m_cmd_kiem_tra = new SIS.Controls.Button.SiSButton();
            this.m_cmd_load_ds = new SIS.Controls.Button.SiSButton();
            this.m_lbl_loading = new System.Windows.Forms.Label();
            this.m_dgl_open_file = new System.Windows.Forms.OpenFileDialog();
            this.m_fg_load_file = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg_load_file)).BeginInit();
            this.SuspendLayout();
            // 
            // m_lbl_title
            // 
            this.m_lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_title.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_title.Name = "m_lbl_title";
            this.m_lbl_title.Size = new System.Drawing.Size(944, 45);
            this.m_lbl_title.TabIndex = 1;
            this.m_lbl_title.Text = "F121 - Danh sách đăng ký gửi hàng ngày theo file excel";
            this.m_lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_thoat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 432);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 40);
            this.panel1.TabIndex = 8;
            // 
            // m_cmd_thoat
            // 
            this.m_cmd_thoat.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_thoat.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_thoat.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_thoat.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_thoat.ImageIndex = 12;
            this.m_cmd_thoat.Location = new System.Drawing.Point(851, 0);
            this.m_cmd_thoat.Name = "m_cmd_thoat";
            this.m_cmd_thoat.Size = new System.Drawing.Size(93, 40);
            this.m_cmd_thoat.TabIndex = 0;
            this.m_cmd_thoat.Text = "Thoát";
            this.m_cmd_thoat.UseVisualStyleBackColor = true;
            // 
            // m_lbl_label_tong_sl_tp
            // 
            this.m_lbl_label_tong_sl_tp.AutoSize = true;
            this.m_lbl_label_tong_sl_tp.Enabled = false;
            this.m_lbl_label_tong_sl_tp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_label_tong_sl_tp.Location = new System.Drawing.Point(729, 25);
            this.m_lbl_label_tong_sl_tp.Name = "m_lbl_label_tong_sl_tp";
            this.m_lbl_label_tong_sl_tp.Size = new System.Drawing.Size(211, 16);
            this.m_lbl_label_tong_sl_tp.TabIndex = 14;
            this.m_lbl_label_tong_sl_tp.Text = "Tổng số bưu nhập vào từ flie Excel";
            // 
            // m_lbl_tong_so_luong
            // 
            this.m_lbl_tong_so_luong.AutoSize = true;
            this.m_lbl_tong_so_luong.Enabled = false;
            this.m_lbl_tong_so_luong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_tong_so_luong.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_tong_so_luong.Location = new System.Drawing.Point(958, 25);
            this.m_lbl_tong_so_luong.Name = "m_lbl_tong_so_luong";
            this.m_lbl_tong_so_luong.Size = new System.Drawing.Size(20, 16);
            this.m_lbl_tong_so_luong.TabIndex = 14;
            this.m_lbl_tong_so_luong.Text = "...";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.m_cbo_phong_ban);
            this.panel3.Controls.Add(this.m_cmd_luu);
            this.panel3.Controls.Add(this.m_cmd_kiem_tra);
            this.panel3.Controls.Add(this.m_cmd_load_ds);
            this.panel3.Controls.Add(this.m_lbl_tong_so_luong);
            this.panel3.Controls.Add(this.m_lbl_label_tong_sl_tp);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(944, 47);
            this.panel3.TabIndex = 6;
            // 
            // m_cbo_phong_ban
            // 
            this.m_cbo_phong_ban.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_phong_ban.FormattingEnabled = true;
            this.m_cbo_phong_ban.Location = new System.Drawing.Point(218, 15);
            this.m_cbo_phong_ban.Name = "m_cbo_phong_ban";
            this.m_cbo_phong_ban.Size = new System.Drawing.Size(377, 21);
            this.m_cbo_phong_ban.TabIndex = 2;
            // 
            // m_cmd_luu
            // 
            this.m_cmd_luu.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_luu.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_luu.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_luu.ImageIndex = 10;
            this.m_cmd_luu.ImageList = this.ImageList;
            this.m_cmd_luu.Location = new System.Drawing.Point(605, 13);
            this.m_cmd_luu.Name = "m_cmd_luu";
            this.m_cmd_luu.Size = new System.Drawing.Size(96, 28);
            this.m_cmd_luu.TabIndex = 3;
            this.m_cmd_luu.Text = "4. Lưu DS bưu";
            this.m_cmd_luu.UseVisualStyleBackColor = true;
            // 
            // m_cmd_kiem_tra
            // 
            this.m_cmd_kiem_tra.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_kiem_tra.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_kiem_tra.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_kiem_tra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_kiem_tra.ImageIndex = 13;
            this.m_cmd_kiem_tra.ImageList = this.ImageList;
            this.m_cmd_kiem_tra.Location = new System.Drawing.Point(114, 10);
            this.m_cmd_kiem_tra.Name = "m_cmd_kiem_tra";
            this.m_cmd_kiem_tra.Size = new System.Drawing.Size(95, 31);
            this.m_cmd_kiem_tra.TabIndex = 1;
            this.m_cmd_kiem_tra.Text = "2. Kiểm tra dữ liệu";
            this.m_cmd_kiem_tra.UseVisualStyleBackColor = true;
            // 
            // m_cmd_load_ds
            // 
            this.m_cmd_load_ds.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_load_ds.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_load_ds.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_load_ds.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_load_ds.ImageIndex = 14;
            this.m_cmd_load_ds.ImageList = this.ImageList;
            this.m_cmd_load_ds.Location = new System.Drawing.Point(5, 10);
            this.m_cmd_load_ds.Name = "m_cmd_load_ds";
            this.m_cmd_load_ds.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m_cmd_load_ds.Size = new System.Drawing.Size(105, 31);
            this.m_cmd_load_ds.TabIndex = 0;
            this.m_cmd_load_ds.Text = "1. Nhập DS bưu từ file excel";
            this.m_cmd_load_ds.UseVisualStyleBackColor = true;
            // 
            // m_lbl_loading
            // 
            this.m_lbl_loading.AutoSize = true;
            this.m_lbl_loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_loading.ForeColor = System.Drawing.Color.DarkRed;
            this.m_lbl_loading.Location = new System.Drawing.Point(798, 17);
            this.m_lbl_loading.Name = "m_lbl_loading";
            this.m_lbl_loading.Size = new System.Drawing.Size(154, 16);
            this.m_lbl_loading.TabIndex = 15;
            this.m_lbl_loading.Text = "Đang thực hiện, xin đợi ....";
            // 
            // m_dgl_open_file
            // 
            this.m_dgl_open_file.Filter = "Excel files|*.xls";
            // 
            // m_fg_load_file
            // 
            this.m_fg_load_file.AllowDelete = true;
            this.m_fg_load_file.ColumnInfo = resources.GetString("m_fg_load_file.ColumnInfo");
            this.m_fg_load_file.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg_load_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_fg_load_file.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.m_fg_load_file.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.m_fg_load_file.Location = new System.Drawing.Point(0, 92);
            this.m_fg_load_file.Name = "m_fg_load_file";
            this.m_fg_load_file.Size = new System.Drawing.Size(944, 340);
            this.m_fg_load_file.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg_load_file.Styles"));
            this.m_fg_load_file.TabIndex = 17;
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
            // f121_dm_dang_ky_gui_theo_excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 472);
            this.Controls.Add(this.m_fg_load_file);
            this.Controls.Add(this.m_lbl_loading);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.m_lbl_title);
            this.Name = "f121_dm_dang_ky_gui_theo_excel";
            this.Text = "F121 - Danh sách đăng ký gửi hàng ngày theo file excel";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg_load_file)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_lbl_title;
        private System.Windows.Forms.Panel panel1;
        private SIS.Controls.Button.SiSButton m_cmd_thoat;
        private System.Windows.Forms.Label m_lbl_label_tong_sl_tp;
        private System.Windows.Forms.Label m_lbl_tong_so_luong;
        private System.Windows.Forms.Panel panel3;
        private SIS.Controls.Button.SiSButton m_cmd_luu;
        private SIS.Controls.Button.SiSButton m_cmd_kiem_tra;
        private System.Windows.Forms.ComboBox m_cbo_phong_ban;
        private System.Windows.Forms.Label m_lbl_loading;
        private System.Windows.Forms.OpenFileDialog m_dgl_open_file;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg_load_file;
        private SIS.Controls.Button.SiSButton m_cmd_load_ds;
        internal System.Windows.Forms.ImageList ImageList;
    }
}