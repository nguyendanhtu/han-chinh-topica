using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;

namespace BCTKApp.BaoCao {
    public partial class f861_RPT_TONG_TIEN_DINH_MUC_DE : Form {
        public f861_RPT_TONG_TIEN_DINH_MUC_DE() {
            InitializeComponent();
            format_control();
        }

        private void format_control() {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            set_define_events();
        }

        private void set_define_events() {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
        }

        public void display_for_detail(BCTKUS.US_RPT_TONG_TIEN_DINH_MUC ip_us, DateTime ip_from_date, DateTime ip_to_date) {
            decimal don_gia_dinh_muc = 0;
            decimal so_luong_thong_ke = 0;
            decimal id_co_so_dinh_muc = -1;
            DateTime ap_dung_tu_ngay = new DateTime();
            string ten_co_so_dinh_muc = "";
            ip_us.get_don_gia_dinh_muc_and_so_luong_thong_ke(ip_us.dcID_PHONG_BAN, ip_us.dcID_LOAI_DINH_MUC
                                                                , ip_from_date, ip_to_date
                                                                , ref don_gia_dinh_muc, ref so_luong_thong_ke);
            m_lbl_don_gia.Text = CIPConvert.ToStr(don_gia_dinh_muc, "#,###") + " (VNĐ)";
            //m_lbl_ngay_ap_dung.Text = so_luong_thong_ke + " (người)";
            m_lbl_sltk.Text = so_luong_thong_ke + " (người)";
            m_lbl_tong_tien.Text = CIPConvert.ToStr(don_gia_dinh_muc * so_luong_thong_ke,"#,###") + " (VNĐ)";
            if(don_gia_dinh_muc*so_luong_thong_ke == 0) {
                m_lbl_tong_tien.Text = "0" + " (VNĐ)";
            }
            ip_us.get_co_so_dinh_muc_ap_dung_tu_ngay(ip_us.dcID_PHONG_BAN, ip_us.dcID_LOAI_DINH_MUC
                                                            , ip_from_date, ip_to_date
                                                            , ref id_co_so_dinh_muc, ref ap_dung_tu_ngay
                                                            , ref ten_co_so_dinh_muc);
            m_lbl_co_so_dinh_muc.Text = ten_co_so_dinh_muc;
            if(ap_dung_tu_ngay.ToShortDateString() != "01/01/0001") {
                m_lbl_ngay_ap_dung.Text = ap_dung_tu_ngay.ToShortDateString();
            }
            this.ShowDialog();
        }

        ///Events
        ///
        private void m_cmd_exit_Click(object sender, EventArgs e) {
            try {
                this.Close();
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
