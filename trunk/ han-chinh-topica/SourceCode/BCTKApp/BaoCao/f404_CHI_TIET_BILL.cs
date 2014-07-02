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
            m_lbl_phong_ban.Text = v_dr["TEN_PHONG_BAN"].ToString();
            m_lbl_so_Bill.Text = v_dr["SO_BILL"].ToString();
            m_lbl_ngay_gui.Text = v_dr["NGAY_GUI"].ToString();
            m_lbl_nguoi_gui.Text = v_dr["NGUOI_GUI"].ToString();
            m_lbl_nguoi_nhan.Text = v_dr["NGUOI_NHAN"].ToString();
            m_lbl_noi_nhan.Text = v_dr["NOI_NHAN"].ToString();
            m_lbl_trang_thai.Text = v_dr["TRANG_THAI"].ToString();
            m_lbl_noi_dung.Text = v_dr["NOI_DUNG"].ToString();
            m_lbl_so_tien.Text = v_dr["SO_TIEN"].ToString();
            if(v_dr["TRONG_NUOC"].ToString() == "x")
            {
                m_lbl_khu_vuc.Text = "Trong nước";
            }
            if (v_dr["NUOC_NGOAI"].ToString() == "x")
            {
                m_lbl_khu_vuc.Text = "Ngoài nước";
            }
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
            //CControlFormat.setFormStyle(this, new CAppContext_201());
        }
    }
}
