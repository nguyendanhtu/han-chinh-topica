﻿namespace BCTKApp.ChucNang
{
    partial class f461_So_sanh_chi_phi_cuoi_thang_NCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f461_So_sanh_chi_phi_cuoi_thang_NCC));
            this.m_pnl_header = new System.Windows.Forms.Panel();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.m_pnl_btn = new System.Windows.Forms.Panel();
            this.m_lbl_loading = new System.Windows.Forms.Label();
            this.m_cmd_nhap_excel = new SIS.Controls.Button.SiSButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_grid = new System.Windows.Forms.Panel();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_OpenFile_dlg = new System.Windows.Forms.OpenFileDialog();
            this.m_cmd_so_sanh_chi_phi = new SIS.Controls.Button.SiSButton();
            this.m_xuat_excel = new SIS.Controls.Button.SiSButton();
            this.m_cmd_thoat = new SIS.Controls.Button.SiSButton();
            this.m_pnl_header.SuspendLayout();
            this.m_pnl_btn.SuspendLayout();
            this.m_pnl_grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_pnl_header
            // 
            this.m_pnl_header.Controls.Add(this.m_lbl_header);
            this.m_pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_pnl_header.Location = new System.Drawing.Point(0, 0);
            this.m_pnl_header.Name = "m_pnl_header";
            this.m_pnl_header.Size = new System.Drawing.Size(978, 42);
            this.m_pnl_header.TabIndex = 0;
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.AutoSize = true;
            this.m_lbl_header.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(133, 9);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(608, 23);
            this.m_lbl_header.TabIndex = 0;
            this.m_lbl_header.Text = "SO SÁNH VỚI BẢNG CHI PHÍ CUỐI THÁNG TỪ NHÀ CUNG CẤP";
            // 
            // m_pnl_btn
            // 
            this.m_pnl_btn.Controls.Add(this.m_cmd_so_sanh_chi_phi);
            this.m_pnl_btn.Controls.Add(this.m_lbl_loading);
            this.m_pnl_btn.Controls.Add(this.m_cmd_nhap_excel);
            this.m_pnl_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_pnl_btn.Location = new System.Drawing.Point(0, 42);
            this.m_pnl_btn.Name = "m_pnl_btn";
            this.m_pnl_btn.Size = new System.Drawing.Size(978, 78);
            this.m_pnl_btn.TabIndex = 1;
            // 
            // m_lbl_loading
            // 
            this.m_lbl_loading.AutoSize = true;
            this.m_lbl_loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_loading.ForeColor = System.Drawing.Color.DarkRed;
            this.m_lbl_loading.Location = new System.Drawing.Point(429, 27);
            this.m_lbl_loading.Name = "m_lbl_loading";
            this.m_lbl_loading.Size = new System.Drawing.Size(154, 16);
            this.m_lbl_loading.TabIndex = 22;
            this.m_lbl_loading.Text = "Đang thực hiện, xin đợi ....";
            // 
            // m_cmd_nhap_excel
            // 
            this.m_cmd_nhap_excel.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_nhap_excel.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_nhap_excel.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_nhap_excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_nhap_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_nhap_excel.ImageIndex = 19;
            this.m_cmd_nhap_excel.ImageList = this.imageList1;
            this.m_cmd_nhap_excel.Location = new System.Drawing.Point(22, 18);
            this.m_cmd_nhap_excel.Name = "m_cmd_nhap_excel";
            this.m_cmd_nhap_excel.Size = new System.Drawing.Size(191, 34);
            this.m_cmd_nhap_excel.TabIndex = 31;
            this.m_cmd_nhap_excel.Text = "Chọn File Excel chi phí từ NCC";
            this.m_cmd_nhap_excel.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            this.imageList1.Images.SetKeyName(8, "");
            this.imageList1.Images.SetKeyName(9, "");
            this.imageList1.Images.SetKeyName(10, "");
            this.imageList1.Images.SetKeyName(11, "");
            this.imageList1.Images.SetKeyName(12, "");
            this.imageList1.Images.SetKeyName(13, "");
            this.imageList1.Images.SetKeyName(14, "");
            this.imageList1.Images.SetKeyName(15, "");
            this.imageList1.Images.SetKeyName(16, "");
            this.imageList1.Images.SetKeyName(17, "");
            this.imageList1.Images.SetKeyName(18, "");
            this.imageList1.Images.SetKeyName(19, "");
            this.imageList1.Images.SetKeyName(20, "");
            this.imageList1.Images.SetKeyName(21, "");
            // 
            // m_pnl_grid
            // 
            this.m_pnl_grid.Controls.Add(this.m_fg);
            this.m_pnl_grid.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_pnl_grid.Location = new System.Drawing.Point(0, 120);
            this.m_pnl_grid.Name = "m_pnl_grid";
            this.m_pnl_grid.Size = new System.Drawing.Size(978, 378);
            this.m_pnl_grid.TabIndex = 2;
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_fg.Location = new System.Drawing.Point(0, 0);
            this.m_fg.Name = "m_fg";
            this.m_fg.Rows.Count = 2;
            this.m_fg.Size = new System.Drawing.Size(978, 394);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 2;
            this.m_fg.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_thoat);
            this.panel1.Controls.Add(this.m_xuat_excel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 546);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 36);
            this.panel1.TabIndex = 3;
            // 
            // m_OpenFile_dlg
            // 
            this.m_OpenFile_dlg.FileName = "openFileDialog1";
            // 
            // m_cmd_so_sanh_chi_phi
            // 
            this.m_cmd_so_sanh_chi_phi.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_so_sanh_chi_phi.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_so_sanh_chi_phi.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_so_sanh_chi_phi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_so_sanh_chi_phi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_so_sanh_chi_phi.ImageIndex = 13;
            this.m_cmd_so_sanh_chi_phi.ImageList = this.imageList1;
            this.m_cmd_so_sanh_chi_phi.Location = new System.Drawing.Point(242, 18);
            this.m_cmd_so_sanh_chi_phi.Name = "m_cmd_so_sanh_chi_phi";
            this.m_cmd_so_sanh_chi_phi.Size = new System.Drawing.Size(145, 34);
            this.m_cmd_so_sanh_chi_phi.TabIndex = 32;
            this.m_cmd_so_sanh_chi_phi.Text = "So sánh với đơn hàng";
            this.m_cmd_so_sanh_chi_phi.UseVisualStyleBackColor = true;
            // 
            // m_xuat_excel
            // 
            this.m_xuat_excel.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_xuat_excel.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_xuat_excel.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_xuat_excel.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_xuat_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_xuat_excel.ImageIndex = 19;
            this.m_xuat_excel.ImageList = this.imageList1;
            this.m_xuat_excel.Location = new System.Drawing.Point(0, 0);
            this.m_xuat_excel.Name = "m_xuat_excel";
            this.m_xuat_excel.Size = new System.Drawing.Size(133, 36);
            this.m_xuat_excel.TabIndex = 1;
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
            this.m_cmd_thoat.ImageList = this.imageList1;
            this.m_cmd_thoat.Location = new System.Drawing.Point(885, 0);
            this.m_cmd_thoat.Name = "m_cmd_thoat";
            this.m_cmd_thoat.Size = new System.Drawing.Size(93, 36);
            this.m_cmd_thoat.TabIndex = 2;
            this.m_cmd_thoat.Text = "Thoát";
            this.m_cmd_thoat.UseVisualStyleBackColor = true;
            // 
            // f461_So_sanh_chi_phi_cuoi_thang_NCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 582);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_pnl_grid);
            this.Controls.Add(this.m_pnl_btn);
            this.Controls.Add(this.m_pnl_header);
            this.Name = "f461_So_sanh_chi_phi_cuoi_thang_NCC";
            this.Text = "f461- So sánh chi phí cuối tháng từ nhà cung  cấp";
            this.m_pnl_header.ResumeLayout(false);
            this.m_pnl_header.PerformLayout();
            this.m_pnl_btn.ResumeLayout(false);
            this.m_pnl_btn.PerformLayout();
            this.m_pnl_grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel m_pnl_header;
        private System.Windows.Forms.Label m_lbl_header;
        private System.Windows.Forms.Panel m_pnl_btn;
        private SIS.Controls.Button.SiSButton m_cmd_nhap_excel;
        internal System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel m_pnl_grid;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        private System.Windows.Forms.Label m_lbl_loading;
        private System.Windows.Forms.OpenFileDialog m_OpenFile_dlg;
        private SIS.Controls.Button.SiSButton m_cmd_so_sanh_chi_phi;
        private SIS.Controls.Button.SiSButton m_xuat_excel;
        private SIS.Controls.Button.SiSButton m_cmd_thoat;
    }
}