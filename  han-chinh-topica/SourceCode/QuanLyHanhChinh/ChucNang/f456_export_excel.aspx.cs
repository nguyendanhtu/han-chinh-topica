using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BCTKUS;
using BCTKDS;
using BCTKDS.CDBNames;

using IP.Core.IPCommon;
using IP.Core.WinFormControls;
using IP.Core.IPUserService;
using System.IO;

public partial class ChucNang_f456_export_excel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string id_don_hang = Request.QueryString["id_don_hang"];
        string id_trung_tam = Request.QueryString["id_trung_tam"];
        m_hdf_id_don_hang.Value = id_don_hang;
        m_hdf_id_trung_tam.Value = id_trung_tam;
        load_ma_ten_trung_tam();
        load_data_to_grid_don_hang_de();
        load_ma_don_hang_title();
        ExportGridToExcel();
    }
    private void load_ma_ten_trung_tam()
    {

        decimal v_id_trung_tam = CIPConvert.ToDecimal(m_hdf_id_trung_tam.Value);
        US_DM_PHONG_BAN v_us = new US_DM_PHONG_BAN();
        DS_DM_PHONG_BAN v_ds = new DS_DM_PHONG_BAN();
        v_us.FillDataset(v_ds, "where id=" + v_id_trung_tam);
        m_lbl_title.Text = "Trung tâm - ban: " + v_ds.DM_PHONG_BAN.Rows[0]["TEN_PHONG_BAN"].ToString();
        // lấy mã trung tâm
        m_hdf_ma_trung_tam.Value = v_ds.DM_PHONG_BAN.Rows[0]["MA_PHONG_BAN"].ToString();
    }
    private void load_data_to_grid_don_hang_de()
    {
        //load grid đơn hàng detail:
        US_V_DON_DAT_HANG_DETAIL_NHAP_DON_HANG_LE v_us_don_hang_de = new US_V_DON_DAT_HANG_DETAIL_NHAP_DON_HANG_LE();
        DS_V_DON_DAT_HANG_DETAIL_NHAP_DON_HANG_LE v_ds_don_hang_de = new DS_V_DON_DAT_HANG_DETAIL_NHAP_DON_HANG_LE();
        v_us_don_hang_de.FillDataset(v_ds_don_hang_de, "Where id_don_dat_hang=" + CIPConvert.ToDecimal(m_hdf_id_don_hang.Value));
        m_grv_don_hang_de.DataSource = v_ds_don_hang_de.V_DON_DAT_HANG_DETAIL_NHAP_DON_HANG_LE;
        m_grv_don_hang_de.DataBind();
        string v_str_thong_tin_don_hang_de = " (Có " + v_ds_don_hang_de.V_DON_DAT_HANG_DETAIL_NHAP_DON_HANG_LE.Rows.Count + " mặt hàng)";
        //m_lbl_thong_tim_grv_don_hang_de.Text = v_str_thong_tin_don_hang_de;

        if (!m_hdf_ID_GD_DON_DAT_HANG_DE.Value.Equals(""))
        {
            m_grv_don_hang_de.SelectedIndex = -1;
            for (int i = 0; i < m_grv_don_hang_de.Rows.Count; i++)
                if (CIPConvert.ToDecimal(m_grv_don_hang_de.DataKeys[i].Value) == CIPConvert.ToDecimal(m_hdf_ID_GD_DON_DAT_HANG_DE.Value)) m_grv_don_hang_de.SelectedIndex = i;
        }
        m_grv_don_hang_de.Visible = true;
    }
    private void load_ma_don_hang_title()
    {
        US_GD_DON_DAT_HANG v_us = new US_GD_DON_DAT_HANG();
        DS_GD_DON_DAT_HANG v_ds = new DS_GD_DON_DAT_HANG();
        v_us.FillDataset(v_ds, "where id=" + CIPConvert.ToDecimal(m_hdf_id_don_hang.Value));
        m_lbl_title_ma_don_hang.Text = "Nhập chi tiết đơn hàng ";
        m_lbl_ma_don_hang_de.Text = v_ds.Tables[0].Rows[0]["MA"].ToString();
        m_lbl_ma_don_hang_de.Visible = true;
        m_lbl_MP.Visible = true;

        decimal v_id_phong_ban = CIPConvert.ToDecimal(m_hdf_id_trung_tam.Value);
        US_RPT_GD_DON_DAT_HANG_DINH_MUC v_us_don_hang = new US_RPT_GD_DON_DAT_HANG_DINH_MUC();
        DS_RPT_GD_DON_DAT_HANG_DINH_MUC v_ds_don_hang = new DS_RPT_GD_DON_DAT_HANG_DINH_MUC();
        v_us_don_hang.FillDS_don_hang_dinh_muc(v_ds_don_hang, v_id_phong_ban);
        m_lbl_pop_lan.Text = CIPConvert.ToStr(v_ds_don_hang.RPT_GD_DON_DAT_HANG_DINH_MUC.Rows[0]["LAN"], "#,###");
        DateTime v_dat_ngay = (DateTime)v_ds_don_hang.RPT_GD_DON_DAT_HANG_DINH_MUC.Rows[0]["NGAY_DAT_HANG"];
        m_lbl_pop_ngay.Text = v_dat_ngay.ToString("dd/MM/yyyy");
        m_lbl_pop_tong_tien.Text = CIPConvert.ToStr(v_ds_don_hang.RPT_GD_DON_DAT_HANG_DINH_MUC.Rows[0]["GIA_TRI_DA_VAT"], "#,###") + "  (VNĐ)";
        m_lbl_pop_dinh_muc.Text = CIPConvert.ToStr(v_ds_don_hang.RPT_GD_DON_DAT_HANG_DINH_MUC.Rows[0]["DINH_MUC"], "#,###") + "  (VNĐ)";
    }
    private void ExportGridToExcel()
    {
        Response.Clear();
        Response.Buffer = true;
        Response.ClearContent();
        Response.ClearHeaders();
        Response.Charset = "";
        string FileName = "Phieu_de_nghi_Cap_" + CIPConvert.ToStr(m_hdf_ma_trung_tam.Value) + "_" + DateTime.Now.ToString("yyyyMMdd") +".xls";
        StringWriter strwritter = new StringWriter();
        HtmlTextWriter htmltextwrtter = new HtmlTextWriter(strwritter);
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.ContentType = "application/vnd.ms-excel";
        Response.AddHeader("Content-Disposition", "attachment;filename=" + FileName);
        htmltextwrtter.Write("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;");
        m_lbl_header.RenderControl(htmltextwrtter);
        htmltextwrtter.WriteLine("<br />");
        // tên phòng ban
        htmltextwrtter.Write("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;");
        m_lbl_title.RenderControl(htmltextwrtter);
        htmltextwrtter.WriteLine("<br />");
        //m_lbl_title_ma_don_hang.RenderControl(htmltextwrtter);
        //Mã đơn hàng
        m_lbl_MP.RenderControl(htmltextwrtter);
        m_lbl_ma_don_hang_de.RenderControl(htmltextwrtter);
        htmltextwrtter.Write("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;");
        m_lbl_pop_lan_tl.RenderControl(htmltextwrtter);
        htmltextwrtter.Write("&nbsp&nbsp&nbsp");
        m_lbl_pop_lan.RenderControl(htmltextwrtter);
        htmltextwrtter.Write("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;");
        m_lbl_pop_ngay_dat_hang_tl.RenderControl(htmltextwrtter);
        htmltextwrtter.Write("&nbsp&nbsp&nbsp");
        m_lbl_pop_ngay.RenderControl(htmltextwrtter);

        htmltextwrtter.Write("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;");
        m_lbl_pop_tong_tien_tl.RenderControl(htmltextwrtter);
        htmltextwrtter.Write("&nbsp&nbsp&nbsp");
        m_lbl_pop_tong_tien.RenderControl(htmltextwrtter);

        htmltextwrtter.Write("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;");
        m_lbl_pop_dinh_muc_tl.RenderControl(htmltextwrtter);
        htmltextwrtter.Write("&nbsp&nbsp&nbsp");
        m_lbl_pop_dinh_muc.RenderControl(htmltextwrtter);
        m_grv_don_hang_de.GridLines = GridLines.Both;
        m_grv_don_hang_de.HeaderStyle.Font.Bold = true;
        m_grv_don_hang_de.RenderControl(htmltextwrtter);
        Response.Write(strwritter.ToString());
        Response.End();

    }
    public override void VerifyRenderingInServerForm(System.Web.UI.Control control)
    {
        //Required to verify that the control is rendered properly on page
    }
  
}