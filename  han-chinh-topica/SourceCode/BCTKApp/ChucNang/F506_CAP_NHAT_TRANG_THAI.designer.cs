﻿namespace BCTKApp
{
    partial class F506_CAP_NHAT_TRANG_THAI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F506_CAP_NHAT_TRANG_THAI));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.m_grv_trang_thai_cu = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_dtp_tu_ngay = new System.Windows.Forms.DateTimePicker();
            this.m_cmd_search = new SIS.Controls.Button.SiSButton();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_grv_trang_thai_moi = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_cmd_right_2_left_all = new SIS.Controls.Button.SiSButton();
            this.m_cmd_right_2_left = new SIS.Controls.Button.SiSButton();
            this.m_cmd_left_2_right_all = new SIS.Controls.Button.SiSButton();
            this.m_cmd_left_2_right = new SIS.Controls.Button.SiSButton();
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_cbo_trung_tam = new System.Windows.Forms.ComboBox();
            this.m_lbl_tieu_de = new System.Windows.Forms.Label();
            this.m_txt_key_word = new System.Windows.Forms.TextBox();
            this.m_tab_main = new System.Windows.Forms.TabControl();
            this.m_tm_bill_da_nhan = new System.Windows.Forms.TabPage();
            this.m_cmd_xem_bill_da_chuyen_cpn = new SIS.Controls.Button.SiSButton();
            this.m_tm_bill_da_chuyen_cho_cpn = new System.Windows.Forms.TabPage();
            this.m_cmd_xem_ds_bill_da_nhan = new SIS.Controls.Button.SiSButton();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_trang_thai_cu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_trang_thai_moi)).BeginInit();
            this.m_pnl_out_place_dm.SuspendLayout();
            this.m_tab_main.SuspendLayout();
            this.m_tm_bill_da_nhan.SuspendLayout();
            this.m_tm_bill_da_chuyen_cho_cpn.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "Trung tâm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 14);
            this.label4.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(502, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 41;
            this.label7.Text = "Tại ngày";
            // 
            // m_grv_trang_thai_cu
            // 
            this.m_grv_trang_thai_cu.ColumnInfo = resources.GetString("m_grv_trang_thai_cu.ColumnInfo");
            this.m_grv_trang_thai_cu.Location = new System.Drawing.Point(6, 18);
            this.m_grv_trang_thai_cu.Name = "m_grv_trang_thai_cu";
            this.m_grv_trang_thai_cu.Size = new System.Drawing.Size(665, 325);
            this.m_grv_trang_thai_cu.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_grv_trang_thai_cu.Styles"));
            this.m_grv_trang_thai_cu.TabIndex = 36;
            // 
            // m_dtp_tu_ngay
            // 
            this.m_dtp_tu_ngay.Checked = false;
            this.m_dtp_tu_ngay.CustomFormat = "dd/MM/yyyy";
            this.m_dtp_tu_ngay.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_dtp_tu_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dtp_tu_ngay.Location = new System.Drawing.Point(565, 64);
            this.m_dtp_tu_ngay.Name = "m_dtp_tu_ngay";
            this.m_dtp_tu_ngay.ShowCheckBox = true;
            this.m_dtp_tu_ngay.Size = new System.Drawing.Size(148, 23);
            this.m_dtp_tu_ngay.TabIndex = 1;
            this.m_dtp_tu_ngay.Value = new System.DateTime(2014, 6, 7, 0, 0, 0, 0);
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_search.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_search.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_search.ImageIndex = 18;
            this.m_cmd_search.ImageList = this.ImageList;
            this.m_cmd_search.Location = new System.Drawing.Point(516, 116);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(88, 30);
            this.m_cmd_search.TabIndex = 5;
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
            // m_grv_trang_thai_moi
            // 
            this.m_grv_trang_thai_moi.ColumnInfo = resources.GetString("m_grv_trang_thai_moi.ColumnInfo");
            this.m_grv_trang_thai_moi.Location = new System.Drawing.Point(6, 18);
            this.m_grv_trang_thai_moi.Name = "m_grv_trang_thai_moi";
            this.m_grv_trang_thai_moi.Size = new System.Drawing.Size(661, 328);
            this.m_grv_trang_thai_moi.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_grv_trang_thai_moi.Styles"));
            this.m_grv_trang_thai_moi.TabIndex = 37;
            // 
            // m_cmd_right_2_left_all
            // 
            this.m_cmd_right_2_left_all.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_right_2_left_all.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_right_2_left_all.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_right_2_left_all.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_right_2_left_all.ImageIndex = 10;
            this.m_cmd_right_2_left_all.Location = new System.Drawing.Point(682, 102);
            this.m_cmd_right_2_left_all.Name = "m_cmd_right_2_left_all";
            this.m_cmd_right_2_left_all.Size = new System.Drawing.Size(115, 78);
            this.m_cmd_right_2_left_all.TabIndex = 9;
            this.m_cmd_right_2_left_all.Text = "Huỷ tất cả ";
            // 
            // m_cmd_right_2_left
            // 
            this.m_cmd_right_2_left.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_right_2_left.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_right_2_left.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_right_2_left.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_right_2_left.ImageIndex = 10;
            this.m_cmd_right_2_left.Location = new System.Drawing.Point(682, 18);
            this.m_cmd_right_2_left.Name = "m_cmd_right_2_left";
            this.m_cmd_right_2_left.Size = new System.Drawing.Size(115, 78);
            this.m_cmd_right_2_left.TabIndex = 8;
            this.m_cmd_right_2_left.Text = "Huỷ chuyển bill cho CPN";
            // 
            // m_cmd_left_2_right_all
            // 
            this.m_cmd_left_2_right_all.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_left_2_right_all.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_left_2_right_all.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_left_2_right_all.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_left_2_right_all.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_left_2_right_all.ImageIndex = 10;
            this.m_cmd_left_2_right_all.Location = new System.Drawing.Point(689, 102);
            this.m_cmd_left_2_right_all.Name = "m_cmd_left_2_right_all";
            this.m_cmd_left_2_right_all.Size = new System.Drawing.Size(115, 78);
            this.m_cmd_left_2_right_all.TabIndex = 7;
            this.m_cmd_left_2_right_all.Text = "Chuyển tất cả bill cho CPN";
            // 
            // m_cmd_left_2_right
            // 
            this.m_cmd_left_2_right.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_left_2_right.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_left_2_right.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_left_2_right.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_left_2_right.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_left_2_right.ImageIndex = 10;
            this.m_cmd_left_2_right.Location = new System.Drawing.Point(689, 18);
            this.m_cmd_left_2_right.Name = "m_cmd_left_2_right";
            this.m_cmd_left_2_right.Size = new System.Drawing.Size(115, 78);
            this.m_cmd_left_2_right.TabIndex = 6;
            this.m_cmd_left_2_right.Text = "Chuyển bill đã chọn cho CPN";
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 573);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(924, 40);
            this.m_pnl_out_place_dm.TabIndex = 50;
            // 
            // m_cmd_update
            // 
            this.m_cmd_update.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_update.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_update.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_update.ImageIndex = 10;
            this.m_cmd_update.ImageList = this.ImageList;
            this.m_cmd_update.Location = new System.Drawing.Point(744, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(88, 32);
            this.m_cmd_update.TabIndex = 10;
            this.m_cmd_update.Text = "&Cập nhật";
            this.m_cmd_update.Visible = false;
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 11;
            this.m_cmd_exit.ImageList = this.ImageList;
            this.m_cmd_exit.Location = new System.Drawing.Point(832, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 32);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Trở về (Esc)";
            // 
            // m_cbo_trung_tam
            // 
            this.m_cbo_trung_tam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_trung_tam.FormattingEnabled = true;
            this.m_cbo_trung_tam.Location = new System.Drawing.Point(209, 65);
            this.m_cbo_trung_tam.Name = "m_cbo_trung_tam";
            this.m_cbo_trung_tam.Size = new System.Drawing.Size(277, 22);
            this.m_cbo_trung_tam.TabIndex = 2;
            // 
            // m_lbl_tieu_de
            // 
            this.m_lbl_tieu_de.AutoSize = true;
            this.m_lbl_tieu_de.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_tieu_de.Location = new System.Drawing.Point(304, 6);
            this.m_lbl_tieu_de.Name = "m_lbl_tieu_de";
            this.m_lbl_tieu_de.Size = new System.Drawing.Size(214, 23);
            this.m_lbl_tieu_de.TabIndex = 51;
            this.m_lbl_tieu_de.Text = "Cập nhật trạng thái CPN";
            // 
            // m_txt_key_word
            // 
            this.m_txt_key_word.Location = new System.Drawing.Point(209, 120);
            this.m_txt_key_word.Name = "m_txt_key_word";
            this.m_txt_key_word.Size = new System.Drawing.Size(277, 20);
            this.m_txt_key_word.TabIndex = 53;
            // 
            // m_tab_main
            // 
            this.m_tab_main.Controls.Add(this.m_tm_bill_da_nhan);
            this.m_tab_main.Controls.Add(this.m_tm_bill_da_chuyen_cho_cpn);
            this.m_tab_main.Location = new System.Drawing.Point(38, 180);
            this.m_tab_main.Name = "m_tab_main";
            this.m_tab_main.SelectedIndex = 0;
            this.m_tab_main.Size = new System.Drawing.Size(834, 387);
            this.m_tab_main.TabIndex = 61;
            // 
            // m_tm_bill_da_nhan
            // 
            this.m_tm_bill_da_nhan.Controls.Add(this.m_grv_trang_thai_cu);
            this.m_tm_bill_da_nhan.Controls.Add(this.m_cmd_left_2_right);
            this.m_tm_bill_da_nhan.Controls.Add(this.m_cmd_xem_bill_da_chuyen_cpn);
            this.m_tm_bill_da_nhan.Controls.Add(this.m_cmd_left_2_right_all);
            this.m_tm_bill_da_nhan.Location = new System.Drawing.Point(4, 23);
            this.m_tm_bill_da_nhan.Name = "m_tm_bill_da_nhan";
            this.m_tm_bill_da_nhan.Padding = new System.Windows.Forms.Padding(3);
            this.m_tm_bill_da_nhan.Size = new System.Drawing.Size(826, 360);
            this.m_tm_bill_da_nhan.TabIndex = 0;
            this.m_tm_bill_da_nhan.Text = "DS bill đã nhận";
            this.m_tm_bill_da_nhan.UseVisualStyleBackColor = true;
            // 
            // m_cmd_xem_bill_da_chuyen_cpn
            // 
            this.m_cmd_xem_bill_da_chuyen_cpn.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_xem_bill_da_chuyen_cpn.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_xem_bill_da_chuyen_cpn.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_xem_bill_da_chuyen_cpn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_xem_bill_da_chuyen_cpn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_xem_bill_da_chuyen_cpn.ImageIndex = 10;
            this.m_cmd_xem_bill_da_chuyen_cpn.Location = new System.Drawing.Point(689, 265);
            this.m_cmd_xem_bill_da_chuyen_cpn.Name = "m_cmd_xem_bill_da_chuyen_cpn";
            this.m_cmd_xem_bill_da_chuyen_cpn.Size = new System.Drawing.Size(115, 78);
            this.m_cmd_xem_bill_da_chuyen_cpn.TabIndex = 7;
            this.m_cmd_xem_bill_da_chuyen_cpn.Text = "Xem ds bill đã chuyển cho CPN";
            // 
            // m_tm_bill_da_chuyen_cho_cpn
            // 
            this.m_tm_bill_da_chuyen_cho_cpn.Controls.Add(this.m_grv_trang_thai_moi);
            this.m_tm_bill_da_chuyen_cho_cpn.Controls.Add(this.m_cmd_right_2_left);
            this.m_tm_bill_da_chuyen_cho_cpn.Controls.Add(this.m_cmd_xem_ds_bill_da_nhan);
            this.m_tm_bill_da_chuyen_cho_cpn.Controls.Add(this.m_cmd_right_2_left_all);
            this.m_tm_bill_da_chuyen_cho_cpn.Location = new System.Drawing.Point(4, 23);
            this.m_tm_bill_da_chuyen_cho_cpn.Name = "m_tm_bill_da_chuyen_cho_cpn";
            this.m_tm_bill_da_chuyen_cho_cpn.Padding = new System.Windows.Forms.Padding(3);
            this.m_tm_bill_da_chuyen_cho_cpn.Size = new System.Drawing.Size(826, 360);
            this.m_tm_bill_da_chuyen_cho_cpn.TabIndex = 1;
            this.m_tm_bill_da_chuyen_cho_cpn.Text = "DS bill đã chuyển cho CPN";
            this.m_tm_bill_da_chuyen_cho_cpn.UseVisualStyleBackColor = true;
            // 
            // m_cmd_xem_ds_bill_da_nhan
            // 
            this.m_cmd_xem_ds_bill_da_nhan.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_xem_ds_bill_da_nhan.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_xem_ds_bill_da_nhan.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_xem_ds_bill_da_nhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_xem_ds_bill_da_nhan.ImageIndex = 10;
            this.m_cmd_xem_ds_bill_da_nhan.Location = new System.Drawing.Point(682, 268);
            this.m_cmd_xem_ds_bill_da_nhan.Name = "m_cmd_xem_ds_bill_da_nhan";
            this.m_cmd_xem_ds_bill_da_nhan.Size = new System.Drawing.Size(115, 78);
            this.m_cmd_xem_ds_bill_da_nhan.TabIndex = 9;
            this.m_cmd_xem_ds_bill_da_nhan.Text = "Xem danh sách bill đã nhận";
            // 
            // F506_CAP_NHAT_TRANG_THAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 613);
            this.Controls.Add(this.m_tab_main);
            this.Controls.Add(this.m_txt_key_word);
            this.Controls.Add(this.m_lbl_tieu_de);
            this.Controls.Add(this.m_cbo_trung_tam);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.m_dtp_tu_ngay);
            this.Controls.Add(this.m_cmd_search);
            this.Name = "F506_CAP_NHAT_TRANG_THAI";
            this.Text = "F506-Cập nhật trạng thái CPN";
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_trang_thai_cu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_trang_thai_moi)).EndInit();
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.m_tab_main.ResumeLayout(false);
            this.m_tm_bill_da_nhan.ResumeLayout(false);
            this.m_tm_bill_da_chuyen_cho_cpn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker m_dtp_tu_ngay;
        internal SIS.Controls.Button.SiSButton m_cmd_search;
        private C1.Win.C1FlexGrid.C1FlexGrid m_grv_trang_thai_cu;
        private C1.Win.C1FlexGrid.C1FlexGrid m_grv_trang_thai_moi;
        internal SIS.Controls.Button.SiSButton m_cmd_right_2_left_all;
        internal SIS.Controls.Button.SiSButton m_cmd_right_2_left;
        internal SIS.Controls.Button.SiSButton m_cmd_left_2_right_all;
        internal SIS.Controls.Button.SiSButton m_cmd_left_2_right;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        internal SIS.Controls.Button.SiSButton m_cmd_update;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        internal System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.ComboBox m_cbo_trung_tam;
        private System.Windows.Forms.Label m_lbl_tieu_de;
        private System.Windows.Forms.TextBox m_txt_key_word;
        private System.Windows.Forms.TabControl m_tab_main;
        private System.Windows.Forms.TabPage m_tm_bill_da_nhan;
        private System.Windows.Forms.TabPage m_tm_bill_da_chuyen_cho_cpn;
        internal SIS.Controls.Button.SiSButton m_cmd_xem_bill_da_chuyen_cpn;
        internal SIS.Controls.Button.SiSButton m_cmd_xem_ds_bill_da_nhan;
    }
}