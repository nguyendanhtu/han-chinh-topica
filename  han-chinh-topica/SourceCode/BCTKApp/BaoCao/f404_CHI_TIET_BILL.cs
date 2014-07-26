using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using BCTKDS;
using BCTKUS;
using BCTKDS.CDBNames;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;
using IP.Core.IPSystemAdmin;


namespace BCTKApp.BaoCao
{
    public partial class f404_CHI_TIET_BILL : Form
    {
        public f404_CHI_TIET_BILL()
        {
            InitializeComponent();
        }

        public void Display_for_chi_tiet(decimal v_id)
        {
            format_controls();
            US_V_TONG_HOP_CPN_THEO_PHONG_BAN v_us = new US_V_TONG_HOP_CPN_THEO_PHONG_BAN();
            DS_V_TONG_HOP_CPN_THEO_PHONG_BAN v_ds = new DS_V_TONG_HOP_CPN_THEO_PHONG_BAN();
            v_us.FillDataset(v_ds,"where id ="+ v_id);
            DataRow v_dr = v_ds.Tables[0].Rows[0];
            DateTime v_dat_ngay_gui = (DateTime)(v_dr["NGAY_GUI"]);
            m_lbl_phong.Text = v_dr["TEN_PHONG_BAN"].ToString();
            m_lbl_so_bill.Text = v_dr["SO_BILL"].ToString();
            m_lbl_ngay_gui.Text = v_dat_ngay_gui.ToShortDateString();
            m_lbl_nguoi_gui.Text = v_dr["NGUOI_GUI"].ToString();
            m_lbl_nguoi_nhan.Text = v_dr["NGUOI_NHAN"].ToString();
            m_lbl_noi_nhan.Text = v_dr["NOI_NHAN"].ToString();
            m_lbl_trang_thai.Text = v_dr["TRANG_THAI"].ToString();
            m_lbl_noi_dung.Text = v_dr["NOI_DUNG"].ToString();
            if (v_dr["SO_TIEN"].ToString() == "" || v_dr["SO_TIEN"] == null)
            {
                m_lbl_so_tien.Text = " 0 (vnđ)";   
            }
            else m_lbl_so_tien.Text = CIPConvert.ToStr(v_dr["SO_TIEN"], "#,###") + " (vnđ)";
            if(v_dr["TRONG_NUOC"].ToString() == "x")
            {
                m_lbl_khu_vuc.Text = "Trong nước";
            }
            if (v_dr["NUOC_NGOAI"].ToString() == "x")
            {
                m_lbl_khu_vuc.Text = "Ngoài nước";
            }
            if (v_dr["GHI_CHU"] == null || v_dr["GHI_CHU"].ToString() == "")
            {
                m_lbl_ghi_chu.Text = "................";
            }
            else
            m_lbl_ghi_chu.Text = v_dr["GHI_CHU"].ToString();
            this.ShowDialog();
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
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            // m_lbl_header
            // 
            this.m_lbl_header.AutoSize = true;
            this.m_lbl_header.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(206, 9);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(145, 22);
            this.m_lbl_header.TabIndex = 0;
            this.m_lbl_header.Text = "CHI TIẾT BILL";
            // 
            // label1
            // 
            //this.label1.AutoSize = true;
            //this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.label1.ForeColor = System.Drawing.Color.Maroon;
            //this.label1.Location = new System.Drawing.Point(82, 63);
            //this.label1.Name = "label1";
            //this.label1.Size = new System.Drawing.Size(49, 15);
            //this.label1.TabIndex = 1;
            //this.label1.Text = "Số Bill:";
            // 
            // label3
            // 
            //this.label3.AutoSize = true;
            //this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.label3.ForeColor = System.Drawing.Color.Maroon;
            //this.label3.Location = new System.Drawing.Point(82, 181);
            //this.label3.Name = "label3";
            //this.label3.Size = new System.Drawing.Size(76, 15);
            //this.label3.TabIndex = 3;
            //this.label3.Text = "Người nhận:";
            // 
            // label5
            // 
            //this.label5.AutoSize = true;
            //this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.label5.ForeColor = System.Drawing.Color.Maroon;
            //this.label5.Location = new System.Drawing.Point(82, 162);
            //this.label5.Name = "label5";
            //this.label5.Size = new System.Drawing.Size(68, 15);
            //this.label5.TabIndex = 5;
            //this.label5.Text = "Người gửi:";
            // 
            // lbl_ngay_gui
            // 
            //this.lbl_ngay_gui.AutoSize = true;
            //this.lbl_ngay_gui.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.lbl_ngay_gui.ForeColor = System.Drawing.Color.Maroon;
            //this.lbl_ngay_gui.Location = new System.Drawing.Point(83, 83);
            //this.lbl_ngay_gui.Name = "lbl_ngay_gui";
            //this.lbl_ngay_gui.Size = new System.Drawing.Size(61, 15);
            //this.lbl_ngay_gui.TabIndex = 7;
            //this.lbl_ngay_gui.Text = "Ngày gửi:";
            // 
            // label4
            // 
            //this.label4.AutoSize = true;
            //this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.label4.ForeColor = System.Drawing.Color.Maroon;
            //this.label4.Location = new System.Drawing.Point(82, 200);
            //this.label4.Name = "label4";
            //this.label4.Size = new System.Drawing.Size(61, 15);
            //this.label4.TabIndex = 5;
            //this.label4.Text = "Nơi nhận:";
            // 
            // label6
            // 
            //this.label6.AutoSize = true;
            //this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.label6.ForeColor = System.Drawing.Color.Maroon;
            //this.label6.Location = new System.Drawing.Point(82, 143);
            //this.label6.Name = "label6";
            //this.label6.Size = new System.Drawing.Size(68, 15);
            //this.label6.TabIndex = 5;
            //this.label6.Text = "Trạng thái:";
            // 
            // label8
            // 
            //this.label8.AutoSize = true;
            //this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.label8.ForeColor = System.Drawing.Color.Maroon;
            //this.label8.Location = new System.Drawing.Point(83, 124);
            //this.label8.Name = "label8";
            //this.label8.Size = new System.Drawing.Size(60, 15);
            //this.label8.TabIndex = 5;
            //this.label8.Text = "Nội dung:";
            // 
            // label9
            // 
            //this.label9.AutoSize = true;
            //this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.label9.ForeColor = System.Drawing.Color.Maroon;
            //this.label9.Location = new System.Drawing.Point(83, 103);
            //this.label9.Name = "label9";
            //this.label9.Size = new System.Drawing.Size(49, 15);
            //this.label9.TabIndex = 5;
            //this.label9.Text = "Số tiền:";
            // 
            // label12
            // 
            //this.label12.AutoSize = true;
            //this.label12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.label12.ForeColor = System.Drawing.Color.Maroon;
            //this.label12.Location = new System.Drawing.Point(82, 220);
            //this.label12.Name = "label12";
            //this.label12.Size = new System.Drawing.Size(56, 15);
            //this.label12.TabIndex = 5;
            //this.label12.Text = "Khu vực:";
            // 
            // label13
            // 
            //this.label13.AutoSize = true;
            //this.label13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.label13.ForeColor = System.Drawing.Color.Maroon;
            //this.label13.Location = new System.Drawing.Point(82, 240);
            //this.label13.Name = "label13";
            //this.label13.Size = new System.Drawing.Size(54, 15);
            //this.label13.TabIndex = 5;
            //this.label13.Text = "Ghi chú:";
            // 
            // label11
            // 
            //this.label11.AutoSize = true;
            //this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.label11.ForeColor = System.Drawing.Color.Maroon;
            //this.label11.Location = new System.Drawing.Point(82, 44);
            //this.label11.Name = "label11";
            //this.label11.Size = new System.Drawing.Size(46, 15);
            //this.label11.TabIndex = 1;
            //this.label11.Text = "Phòng:";
            // 
            // m_pnl_out_place_dm
            // 
            //this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            //this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            //this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 285);
            //this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            //this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            //this.m_pnl_out_place_dm.Size = new System.Drawing.Size(539, 36);
            //this.m_pnl_out_place_dm.TabIndex = 20;
            // 
            // m_cmd_exit
            // 
            //this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            //this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            //this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            //this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            //this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //this.m_cmd_exit.ImageIndex = 12;
            //this.m_cmd_exit.ImageList = this.ImageList;
            //this.m_cmd_exit.Location = new System.Drawing.Point(447, 4);
            //this.m_cmd_exit.Name = "m_cmd_exit";
            //this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            //this.m_cmd_exit.TabIndex = 11;
            //this.m_cmd_exit.Text = "Thoát (Esc)";
            //this.m_cmd_exit.Click += new System.EventHandler(this.m_cmd_exit_Click);
            // 
            // m_lbl_so_bill
            // 
            //this.m_lbl_so_bill.AutoSize = true;
            //this.m_lbl_so_bill.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.m_lbl_so_bill.ForeColor = System.Drawing.Color.Maroon;
            //this.m_lbl_so_bill.Location = new System.Drawing.Point(170, 61);
            //this.m_lbl_so_bill.Name = "m_lbl_so_bill";
            //this.m_lbl_so_bill.Size = new System.Drawing.Size(52, 17);
            //this.m_lbl_so_bill.TabIndex = 1;
            //this.m_lbl_so_bill.Text = "...........";
            // 
            // m_lbl_phong
            // 
            //this.m_lbl_phong.AutoSize = true;
            //this.m_lbl_phong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.m_lbl_phong.ForeColor = System.Drawing.Color.Maroon;
            //this.m_lbl_phong.Location = new System.Drawing.Point(171, 44);
            //this.m_lbl_phong.Name = "m_lbl_phong";
            //this.m_lbl_phong.Size = new System.Drawing.Size(40, 15);
            //this.m_lbl_phong.TabIndex = 1;
            //this.m_lbl_phong.Text = "...........";
            // 
            // m_lbl_so_tien
            // 
            //this.m_lbl_so_tien.AutoSize = true;
            //this.m_lbl_so_tien.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.m_lbl_so_tien.ForeColor = System.Drawing.Color.Maroon;
            //this.m_lbl_so_tien.Location = new System.Drawing.Point(171, 103);
            //this.m_lbl_so_tien.Name = "m_lbl_so_tien";
            //this.m_lbl_so_tien.Size = new System.Drawing.Size(52, 17);
            //this.m_lbl_so_tien.TabIndex = 1;
            //this.m_lbl_so_tien.Text = "...........";
            // 
            // m_lbl_nguoi_gui
            // 
            //this.m_lbl_nguoi_gui.AutoSize = true;
            //this.m_lbl_nguoi_gui.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.m_lbl_nguoi_gui.ForeColor = System.Drawing.Color.Maroon;
            //this.m_lbl_nguoi_gui.Location = new System.Drawing.Point(171, 162);
            //this.m_lbl_nguoi_gui.Name = "m_lbl_nguoi_gui";
            //this.m_lbl_nguoi_gui.Size = new System.Drawing.Size(40, 15);
            //this.m_lbl_nguoi_gui.TabIndex = 1;
            //this.m_lbl_nguoi_gui.Text = "...........";
            // 
            // m_lbl_noi_dung
            // 
            //this.m_lbl_noi_dung.AutoSize = true;
            //this.m_lbl_noi_dung.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.m_lbl_noi_dung.ForeColor = System.Drawing.Color.Maroon;
            //this.m_lbl_noi_dung.Location = new System.Drawing.Point(171, 124);
            //this.m_lbl_noi_dung.Name = "m_lbl_noi_dung";
            //this.m_lbl_noi_dung.Size = new System.Drawing.Size(40, 15);
            //this.m_lbl_noi_dung.TabIndex = 1;
            //this.m_lbl_noi_dung.Text = "...........";
            // 
            // m_lbl_ngay_gui
            // 
            //this.m_lbl_ngay_gui.AutoSize = true;
            //this.m_lbl_ngay_gui.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.m_lbl_ngay_gui.ForeColor = System.Drawing.Color.Maroon;
            //this.m_lbl_ngay_gui.Location = new System.Drawing.Point(170, 83);
            //this.m_lbl_ngay_gui.Name = "m_lbl_ngay_gui";
            //this.m_lbl_ngay_gui.Size = new System.Drawing.Size(40, 15);
            //this.m_lbl_ngay_gui.TabIndex = 1;
            //this.m_lbl_ngay_gui.Text = "...........";
            // 
            // m_lbl_trang_thai
            // 
            //this.m_lbl_trang_thai.AutoSize = true;
            //this.m_lbl_trang_thai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.m_lbl_trang_thai.ForeColor = System.Drawing.Color.Maroon;
            //this.m_lbl_trang_thai.Location = new System.Drawing.Point(171, 143);
            //this.m_lbl_trang_thai.Name = "m_lbl_trang_thai";
            //this.m_lbl_trang_thai.Size = new System.Drawing.Size(40, 15);
            //this.m_lbl_trang_thai.TabIndex = 1;
            //this.m_lbl_trang_thai.Text = "...........";
            //// 
            //// m_lbl_khu_vuc
            //// 
            //this.m_lbl_khu_vuc.AutoSize = true;
            //this.m_lbl_khu_vuc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.m_lbl_khu_vuc.ForeColor = System.Drawing.Color.Maroon;
            //this.m_lbl_khu_vuc.Location = new System.Drawing.Point(171, 220);
            //this.m_lbl_khu_vuc.Name = "m_lbl_khu_vuc";
            //this.m_lbl_khu_vuc.Size = new System.Drawing.Size(40, 15);
            //this.m_lbl_khu_vuc.TabIndex = 1;
            //this.m_lbl_khu_vuc.Text = "...........";
            //// 
            //// m_lbl_ghi_chu
            //// 
            //this.m_lbl_ghi_chu.AutoSize = true;
            //this.m_lbl_ghi_chu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.m_lbl_ghi_chu.ForeColor = System.Drawing.Color.Maroon;
            //this.m_lbl_ghi_chu.Location = new System.Drawing.Point(170, 240);
            //this.m_lbl_ghi_chu.Name = "m_lbl_ghi_chu";
            //this.m_lbl_ghi_chu.Size = new System.Drawing.Size(40, 15);
            //this.m_lbl_ghi_chu.TabIndex = 1;
            //this.m_lbl_ghi_chu.Text = "...........";
            //// 
            //// m_lbl_nguoi_nhan
            //// 
            //this.m_lbl_nguoi_nhan.AutoSize = true;
            //this.m_lbl_nguoi_nhan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.m_lbl_nguoi_nhan.ForeColor = System.Drawing.Color.Maroon;
            //this.m_lbl_nguoi_nhan.Location = new System.Drawing.Point(171, 181);
            //this.m_lbl_nguoi_nhan.Name = "m_lbl_nguoi_nhan";
            //this.m_lbl_nguoi_nhan.Size = new System.Drawing.Size(40, 15);
            //this.m_lbl_nguoi_nhan.TabIndex = 1;
            //this.m_lbl_nguoi_nhan.Text = "...........";
            //// 
            //// m_lbl_noi_nhan
            //// 
            //this.m_lbl_noi_nhan.AutoSize = true;
            //this.m_lbl_noi_nhan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.m_lbl_noi_nhan.ForeColor = System.Drawing.Color.Maroon;
            //this.m_lbl_noi_nhan.Location = new System.Drawing.Point(170, 200);
            //this.m_lbl_noi_nhan.Name = "m_lbl_noi_nhan";
            //this.m_lbl_noi_nhan.Size = new System.Drawing.Size(40, 15);
            //this.m_lbl_noi_nhan.TabIndex = 1;
            //this.m_lbl_noi_nhan.Text = "...........";
            // 
          
        }
        public void f404_CHI_TIET_BILL_Load(object sender, System.EventArgs e)
        {
            try
            {

            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void f404_CHI_TIET_BILL_KeyDown(object sender, KeyEventArgs e)
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
