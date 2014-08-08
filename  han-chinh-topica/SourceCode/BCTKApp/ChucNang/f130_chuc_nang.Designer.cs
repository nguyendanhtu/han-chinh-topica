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
            this.m_cmd_insert_row = new SIS.Controls.Button.SiSButton();
            this.m_cmd_del = new SIS.Controls.Button.SiSButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.m_fg_load_file.Location = new System.Drawing.Point(0, 167);
            this.m_fg_load_file.Name = "m_fg_load_file";
            this.m_fg_load_file.Size = new System.Drawing.Size(1081, 388);
            this.m_fg_load_file.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg_load_file.Styles"));
            this.m_fg_load_file.TabIndex = 6;
            // 
            // m_lbl_label_tong_sl_tp
            // 
            this.m_lbl_label_tong_sl_tp.AutoSize = true;
            this.m_lbl_label_tong_sl_tp.Enabled = false;
            this.m_lbl_label_tong_sl_tp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_label_tong_sl_tp.Location = new System.Drawing.Point(382, 100);
            this.m_lbl_label_tong_sl_tp.Name = "m_lbl_label_tong_sl_tp";
            this.m_lbl_label_tong_sl_tp.Size = new System.Drawing.Size(207, 16);
            this.m_lbl_label_tong_sl_tp.TabIndex = 14;
            this.m_lbl_label_tong_sl_tp.Text = "Tổng số Bill nhập vào từ flie Excel";
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
            this.panel1.Location = new System.Drawing.Point(0, 555);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 40);
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
            this.m_cmd_thoat.Location = new System.Drawing.Point(988, 0);
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
            this.m_lbl_tong_so_luong.Location = new System.Drawing.Point(599, 100);
            this.m_lbl_tong_so_luong.Name = "m_lbl_tong_so_luong";
            this.m_lbl_tong_so_luong.Size = new System.Drawing.Size(20, 16);
            this.m_lbl_tong_so_luong.TabIndex = 14;
            this.m_lbl_tong_so_luong.Text = "...";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.m_cmd_insert_row);
            this.panel3.Controls.Add(this.m_cmd_del);
            this.panel3.Controls.Add(this.m_lbl_loading);
            this.panel3.Controls.Add(this.m_lbl_tong_so_luong);
            this.panel3.Controls.Add(this.m_lbl_label_tong_sl_tp);
            this.panel3.Controls.Add(this.m_cmd_luu);
            this.panel3.Controls.Add(this.m_cmd_kiem_tra);
            this.panel3.Controls.Add(this.m_cmd_load_ds);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1081, 128);
            this.panel3.TabIndex = 5;
            // 
            // m_cmd_luu
            // 
            this.m_cmd_luu.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_luu.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_luu.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_luu.ImageIndex = 10;
            this.m_cmd_luu.ImageList = this.ImageList;
            this.m_cmd_luu.Location = new System.Drawing.Point(208, 5);
            this.m_cmd_luu.Name = "m_cmd_luu";
            this.m_cmd_luu.Size = new System.Drawing.Size(142, 44);
            this.m_cmd_luu.TabIndex = 2;
            this.m_cmd_luu.Text = "Bước 2: Lưu DS Bill";
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
            this.m_cmd_kiem_tra.Location = new System.Drawing.Point(399, 3);
            this.m_cmd_kiem_tra.Name = "m_cmd_kiem_tra";
            this.m_cmd_kiem_tra.Size = new System.Drawing.Size(173, 44);
            this.m_cmd_kiem_tra.TabIndex = 1;
            this.m_cmd_kiem_tra.Text = "Bước 2: Kiểm tra dữ liệu";
            this.m_cmd_kiem_tra.UseVisualStyleBackColor = true;
            // 
            // m_cmd_load_ds
            // 
            this.m_cmd_load_ds.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_load_ds.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_load_ds.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_load_ds.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_load_ds.ImageIndex = 8;
            this.m_cmd_load_ds.ImageList = this.ImageList;
            this.m_cmd_load_ds.Location = new System.Drawing.Point(4, 5);
            this.m_cmd_load_ds.Name = "m_cmd_load_ds";
            this.m_cmd_load_ds.Size = new System.Drawing.Size(198, 42);
            this.m_cmd_load_ds.TabIndex = 0;
            this.m_cmd_load_ds.Text = "Bước 1: Nhập DS Bill từ file excel";
            this.m_cmd_load_ds.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_lbl_header);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1081, 39);
            this.panel2.TabIndex = 4;
            // 
            // m_lbl_loading
            // 
            this.m_lbl_loading.AutoSize = true;
            this.m_lbl_loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_loading.ForeColor = System.Drawing.Color.DarkRed;
            this.m_lbl_loading.Location = new System.Drawing.Point(413, 77);
            this.m_lbl_loading.Name = "m_lbl_loading";
            this.m_lbl_loading.Size = new System.Drawing.Size(154, 16);
            this.m_lbl_loading.TabIndex = 14;
            this.m_lbl_loading.Text = "Đang thực hiện, xin đợi ....";
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(1081, 41);
            this.m_lbl_header.TabIndex = 0;
            this.m_lbl_header.Text = "F130 - NHẬP THÔNG TIN CHI PHÍ CUỐI THÁNG";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_cmd_insert_row
            // 
            this.m_cmd_insert_row.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_insert_row.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_insert_row.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_insert_row.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_insert_row.ImageIndex = 2;
            this.m_cmd_insert_row.ImageList = this.ImageList;
            this.m_cmd_insert_row.Location = new System.Drawing.Point(93, 95);
            this.m_cmd_insert_row.Name = "m_cmd_insert_row";
            this.m_cmd_insert_row.Size = new System.Drawing.Size(83, 26);
            this.m_cmd_insert_row.TabIndex = 19;
            this.m_cmd_insert_row.TabStop = false;
            this.m_cmd_insert_row.Text = "&Thêm hàng";
            // 
            // m_cmd_del
            // 
            this.m_cmd_del.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_del.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_del.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_del.ImageIndex = 4;
            this.m_cmd_del.ImageList = this.ImageList;
            this.m_cmd_del.Location = new System.Drawing.Point(4, 95);
            this.m_cmd_del.Name = "m_cmd_del";
            this.m_cmd_del.Size = new System.Drawing.Size(83, 26);
            this.m_cmd_del.TabIndex = 18;
            this.m_cmd_del.TabStop = false;
            this.m_cmd_del.Text = "&Xóa hàng";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Yellow;
            this.textBox1.Location = new System.Drawing.Point(677, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 20);
            this.textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Red;
            this.textBox2.Location = new System.Drawing.Point(677, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(90, 20);
            this.textBox2.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(776, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Bill đã có số tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(776, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Bill chưa có trong phần mềm";
            // 
            // f130_chuc_nang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 595);
            this.Controls.Add(this.m_fg_load_file);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "f130_chuc_nang";
            this.Text = "F130 - Nhập thông tin chi phí cuối tháng";
            ((System.ComponentModel.ISupportInitialize)(this.m_fg_load_file)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
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
        internal SIS.Controls.Button.SiSButton m_cmd_insert_row;
        internal SIS.Controls.Button.SiSButton m_cmd_del;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}