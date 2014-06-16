namespace BCTKApp
{
    partial class f130_chuc_nang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f130_chuc_nang));
            this.m_fg_load_file = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_lbl_label_tong_sl_tp = new System.Windows.Forms.Label();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_dgl_open_file = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_xuat_excel = new SIS.Controls.Button.SiSButton();
            this.m_cmd_thoat = new SIS.Controls.Button.SiSButton();
            this.m_lbl_tong_so_luong = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.m_cmd_luu = new SIS.Controls.Button.SiSButton();
            this.m_cmd_kiem_tra = new SIS.Controls.Button.SiSButton();
            this.m_cmd_load_ds = new SIS.Controls.Button.SiSButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_lbl_loading = new System.Windows.Forms.Label();
            this.m_lbl_header = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg_load_file)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_fg_load_file
            // 
            this.m_fg_load_file.AllowDelete = true;
            this.m_fg_load_file.ColumnInfo = resources.GetString("m_fg_load_file.ColumnInfo");
            this.m_fg_load_file.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg_load_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_fg_load_file.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.m_fg_load_file.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.m_fg_load_file.Location = new System.Drawing.Point(0, 97);
            this.m_fg_load_file.Name = "m_fg_load_file";
            this.m_fg_load_file.Size = new System.Drawing.Size(939, 294);
            this.m_fg_load_file.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg_load_file.Styles"));
            this.m_fg_load_file.TabIndex = 6;
            // 
            // m_lbl_label_tong_sl_tp
            // 
            this.m_lbl_label_tong_sl_tp.AutoSize = true;
            this.m_lbl_label_tong_sl_tp.Enabled = false;
            this.m_lbl_label_tong_sl_tp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_label_tong_sl_tp.Location = new System.Drawing.Point(512, 24);
            this.m_lbl_label_tong_sl_tp.Name = "m_lbl_label_tong_sl_tp";
            this.m_lbl_label_tong_sl_tp.Size = new System.Drawing.Size(211, 16);
            this.m_lbl_label_tong_sl_tp.TabIndex = 14;
            this.m_lbl_label_tong_sl_tp.Text = "Tổng số bưu nhập vào từ flie Excel";
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
            // m_dgl_open_file
            // 
            this.m_dgl_open_file.Filter = "Excel files|*.xls";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_xuat_excel);
            this.panel1.Controls.Add(this.m_cmd_thoat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 391);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 40);
            this.panel1.TabIndex = 7;
            // 
            // m_xuat_excel
            // 
            this.m_xuat_excel.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_xuat_excel.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_xuat_excel.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_xuat_excel.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_xuat_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_xuat_excel.ImageIndex = 19;
            this.m_xuat_excel.ImageList = this.ImageList;
            this.m_xuat_excel.Location = new System.Drawing.Point(0, 0);
            this.m_xuat_excel.Name = "m_xuat_excel";
            this.m_xuat_excel.Size = new System.Drawing.Size(133, 40);
            this.m_xuat_excel.TabIndex = 0;
            this.m_xuat_excel.Text = "Xuất Excel";
            this.m_xuat_excel.UseVisualStyleBackColor = true;
            // 
            // m_cmd_thoat
            // 
            this.m_cmd_thoat.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_thoat.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_thoat.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_thoat.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_thoat.ImageIndex = 12;
            this.m_cmd_thoat.ImageList = this.ImageList;
            this.m_cmd_thoat.Location = new System.Drawing.Point(846, 0);
            this.m_cmd_thoat.Name = "m_cmd_thoat";
            this.m_cmd_thoat.Size = new System.Drawing.Size(93, 40);
            this.m_cmd_thoat.TabIndex = 1;
            this.m_cmd_thoat.Text = "Thoát";
            this.m_cmd_thoat.UseVisualStyleBackColor = true;
            // 
            // m_lbl_tong_so_luong
            // 
            this.m_lbl_tong_so_luong.AutoSize = true;
            this.m_lbl_tong_so_luong.Enabled = false;
            this.m_lbl_tong_so_luong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_tong_so_luong.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_tong_so_luong.Location = new System.Drawing.Point(744, 24);
            this.m_lbl_tong_so_luong.Name = "m_lbl_tong_so_luong";
            this.m_lbl_tong_so_luong.Size = new System.Drawing.Size(20, 16);
            this.m_lbl_tong_so_luong.TabIndex = 14;
            this.m_lbl_tong_so_luong.Text = "...";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.m_lbl_tong_so_luong);
            this.panel3.Controls.Add(this.m_lbl_label_tong_sl_tp);
            this.panel3.Controls.Add(this.m_cmd_luu);
            this.panel3.Controls.Add(this.m_cmd_kiem_tra);
            this.panel3.Controls.Add(this.m_cmd_load_ds);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(939, 44);
            this.panel3.TabIndex = 5;
            // 
            // m_cmd_luu
            // 
            this.m_cmd_luu.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_luu.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_luu.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_luu.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_luu.ImageIndex = 10;
            this.m_cmd_luu.ImageList = this.ImageList;
            this.m_cmd_luu.Location = new System.Drawing.Point(340, 0);
            this.m_cmd_luu.Name = "m_cmd_luu";
            this.m_cmd_luu.Size = new System.Drawing.Size(142, 44);
            this.m_cmd_luu.TabIndex = 2;
            this.m_cmd_luu.Text = "3. Lưu DS bưu";
            this.m_cmd_luu.UseVisualStyleBackColor = true;
            // 
            // m_cmd_kiem_tra
            // 
            this.m_cmd_kiem_tra.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_kiem_tra.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_kiem_tra.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_kiem_tra.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_kiem_tra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_kiem_tra.ImageIndex = 13;
            this.m_cmd_kiem_tra.ImageList = this.ImageList;
            this.m_cmd_kiem_tra.Location = new System.Drawing.Point(198, 0);
            this.m_cmd_kiem_tra.Name = "m_cmd_kiem_tra";
            this.m_cmd_kiem_tra.Size = new System.Drawing.Size(142, 44);
            this.m_cmd_kiem_tra.TabIndex = 1;
            this.m_cmd_kiem_tra.Text = "2. Kiểm tra dữ liệu";
            this.m_cmd_kiem_tra.UseVisualStyleBackColor = true;
            // 
            // m_cmd_load_ds
            // 
            this.m_cmd_load_ds.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_load_ds.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_load_ds.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_load_ds.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_load_ds.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_load_ds.ImageIndex = 8;
            this.m_cmd_load_ds.ImageList = this.ImageList;
            this.m_cmd_load_ds.Location = new System.Drawing.Point(0, 0);
            this.m_cmd_load_ds.Name = "m_cmd_load_ds";
            this.m_cmd_load_ds.Size = new System.Drawing.Size(198, 44);
            this.m_cmd_load_ds.TabIndex = 0;
            this.m_cmd_load_ds.Text = "1. Nhập DS bưu từ file excel";
            this.m_cmd_load_ds.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_lbl_loading);
            this.panel2.Controls.Add(this.m_lbl_header);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(939, 53);
            this.panel2.TabIndex = 4;
            // 
            // m_lbl_loading
            // 
            this.m_lbl_loading.AutoSize = true;
            this.m_lbl_loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_loading.ForeColor = System.Drawing.Color.DarkRed;
            this.m_lbl_loading.Location = new System.Drawing.Point(706, 17);
            this.m_lbl_loading.Name = "m_lbl_loading";
            this.m_lbl_loading.Size = new System.Drawing.Size(154, 16);
            this.m_lbl_loading.TabIndex = 14;
            this.m_lbl_loading.Text = "Đang thực hiện, xin đợi ....";
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(939, 45);
            this.m_lbl_header.TabIndex = 0;
            this.m_lbl_header.Text = "F130 - Nhập thông tin chi phí cuối tháng";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // f130_chuc_nang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 431);
            this.Controls.Add(this.m_fg_load_file);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "f130_chuc_nang";
            this.Text = "F130 - Chức năng";
            ((System.ComponentModel.ISupportInitialize)(this.m_fg_load_file)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid m_fg_load_file;
        private System.Windows.Forms.Label m_lbl_label_tong_sl_tp;
        private SIS.Controls.Button.SiSButton m_cmd_luu;
        internal System.Windows.Forms.ImageList ImageList;
        private SIS.Controls.Button.SiSButton m_cmd_kiem_tra;
        private SIS.Controls.Button.SiSButton m_cmd_load_ds;
        private SIS.Controls.Button.SiSButton m_xuat_excel;
        private System.Windows.Forms.OpenFileDialog m_dgl_open_file;
        private System.Windows.Forms.Panel panel1;
        private SIS.Controls.Button.SiSButton m_cmd_thoat;
        private System.Windows.Forms.Label m_lbl_tong_so_luong;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label m_lbl_header;
        private System.Windows.Forms.Label m_lbl_loading;
    }
}