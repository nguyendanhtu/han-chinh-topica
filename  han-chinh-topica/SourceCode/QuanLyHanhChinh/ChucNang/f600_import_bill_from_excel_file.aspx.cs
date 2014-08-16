using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using C1.Win.C1FlexGrid;
using System.Data;
using System.ComponentModel;
using Excel;
using System.Data;
using IP.Core.IPCommon;
using BCTKUS;
using IP.Core.IPUserService;
using BCTKDS;
using BCTKDS.CDBNames;
using System.Globalization;
public partial class ChucNang_f600_import_bill_from_excel_file : System.Web.UI.Page
{


    #region Public Interfaces

    #endregion

    #region Members
    CSystemMessage m_sm = new CSystemMessage();
    #endregion

    #region Data Structures

    #endregion

    #region Private Methods
    private void thong_bao(string ip_str_mess, bool ip_panel_thong_bao_visible)
    {
        m_mtv_1.SetActiveView(m_view_confirm);
        m_lbl_popup_mess.Text = ip_str_mess;
        m_pnl_confirm_tg.Visible = ip_panel_thong_bao_visible;
        m_cmd_ok.Visible = ip_panel_thong_bao_visible;
    }
    public void thong_bao(string ip_str_mess, bool ip_panel_thong_bao_visible, bool ip_button_ok_visible)
    {
        m_mtv_1.SetActiveView(m_view_confirm);
        m_lbl_popup_mess.Text = ip_str_mess;
        m_pnl_confirm_tg.Visible = ip_panel_thong_bao_visible;
        m_cmd_ok.Visible = ip_button_ok_visible;
    }
    public void thong_bao(string ip_str_mess)
    {
        m_mtv_1.SetActiveView(m_view_confirm);
        m_lbl_popup_mess.Text = ip_str_mess;
        m_pnl_confirm_tg.Visible = true;
        m_cmd_ok.Visible = true;
    }
    private void save_file_upload(string ip_str_our_dir)
    {
        if (m_fu_chon_file_import.HasFile)
        {
            if (check_file_upload_is_ok(m_fu_chon_file_import.FileName))
            {
                m_fu_chon_file_import.SaveAs(ip_str_our_dir);
            }
            else
            {
                m_lbl_message.Text = "File import phải là file excel đuôi .xls!";
            }
        }
    }
    private void delete_file_imported(string ip_str_file_dir)
    {
        //if (Directory.Exists(ip_str_file_dir.Replace("/","\\")))
        //{
        File.Delete(ip_str_file_dir);
        //}
    }
    private void excel_file_to_grid(GridView ip_grv, int ip_i_start_row, string ip_str_file_dir)
    {
        m_hdf_so_ban_ghi.Value = "0";
        FileStream v_fs_stream = File.Open(ip_str_file_dir, FileMode.Open, FileAccess.Read);
        IExcelDataReader v_edr = ExcelReaderFactory.CreateBinaryReader(v_fs_stream);
        DataSet v_ds_result = v_edr.AsDataSet();


        if (ip_i_start_row < v_ds_result.Tables[0].Rows.Count)
        {
            for (int i = 0; i < ip_i_start_row; i++)
            {
                v_ds_result.Tables[0].Rows[0].Delete();
                v_ds_result.AcceptChanges();
            }
        }
        int v_i_row_count = v_ds_result.Tables[0].Rows.Count;
        for (int i = 0; i < v_i_row_count; i++)
        {
            if (v_ds_result.Tables[0].Rows[i][2].ToString().Equals(""))
            {
                v_ds_result.Tables[0].Rows[i].Delete();
                v_ds_result.AcceptChanges();
                v_i_row_count--;
                i--;
            }
        }
        CultureInfo v_ct = new CultureInfo("en-US");
        for (int i = 0; i < v_ds_result.Tables[0].Rows.Count; i++)
        {
            //string temp = DateTime.FromOADate(Convert.ToDouble(v_ds_result.Tables[0].Rows[i][8])).t
            v_ds_result.Tables[0].Rows[i][8] = DateTime.FromOADate(Convert.ToDouble(v_ds_result.Tables[0].Rows[i][8])).ToString("dd/MM/yyyy");
            //DateTime.Parse(DateTime.FromOADate(Convert.ToDouble(v_ds_result.Tables[0].Rows[i][8])).ToString(), v_ct);
        }

        if (v_ds_result.Tables[0].Columns.Count < 11) return;
        v_ds_result.Tables[0].Columns[0].ColumnName = "STT";
        v_ds_result.Tables[0].Columns[1].ColumnName = "NOI_DUNG";
        v_ds_result.Tables[0].Columns[2].ColumnName = "NOI_NHAN";
        v_ds_result.Tables[0].Columns[3].ColumnName = "NGUOI_NHAN";
        v_ds_result.Tables[0].Columns[4].ColumnName = "TRONG_NUOC";
        v_ds_result.Tables[0].Columns[5].ColumnName = "NGOAI_NUOC";
        v_ds_result.Tables[0].Columns[6].ColumnName = "SO_BILL";
        v_ds_result.Tables[0].Columns[7].ColumnName = "NGUOI_GUI";
        v_ds_result.Tables[0].Columns[8].ColumnName = "NGAY_GUI";
        v_ds_result.Tables[0].Columns[9].ColumnName = "GHI_CHU";
        v_ds_result.Tables[0].Columns[10].ColumnName = "MA_PHONG_BAN";
        v_ds_result.Tables[0].Columns[11].ColumnName = "TEN_PHONG_BAN";

        ip_grv.DataSource = v_ds_result;
        m_hdf_so_ban_ghi.Value = (v_ds_result.Tables[0].Rows.Count / m_grv_dm_bill.PageSize +1).ToString();
        m_grv_dm_bill.Visible = true;
        ip_grv.DataBind();
        //v_edr.Close();
    }
    private void save_grid_to_database()
    {
        US_DM_BILL v_us_dm_bill;
        GridViewRow[] v_arr_gvr = new GridViewRow[m_grv_dm_bill.Rows.Count];
        System.Web.UI.WebControls.TextBox v_txt_so_bill;
        System.Web.UI.WebControls.TextBox v_txt_ma_phong_ban;
        System.Web.UI.WebControls.TextBox v_txt_nguoi_nhan;
        System.Web.UI.WebControls.TextBox v_txt_nguoi_gui;
        System.Web.UI.WebControls.TextBox v_txt_noi_nhan;
        System.Web.UI.WebControls.TextBox v_txt_noi_dung_gui;
        System.Web.UI.WebControls.TextBox v_txt_noi_ghi_chu;
        System.Web.UI.WebControls.RadioButton v_rdb_trong_nuoc;
        //eWorld.UI.CalendarPopup v_dat_ngay_gui;
        m_grv_dm_bill.Rows.CopyTo(v_arr_gvr, 0);

        //Phải chia nhỏ để insert nếu số lượng bản ghi lớn

        int start_number = 0; //vị trí bản ghi bắt đầu insert
        int numbers_record_limited = v_arr_gvr.Length; // số bản ghi được insert k vượt quá 50
        //int numbers_record_remain = v_arr_gvr.Length; //số bản ghi còn lại sau mỗi lần insert

        //while (numbers_record_remain >= 0)
        //{
        //    if (numbers_record_remain - 50 > 0)
        //        numbers_record_limited = 50;
        //    else
        //        numbers_record_limited = numbers_record_remain;
        for (int i = start_number; i < numbers_record_limited; i++)
        {
            v_txt_so_bill = (System.Web.UI.WebControls.TextBox)v_arr_gvr[i].FindControl("m_txt_so_bill_grid");
            v_txt_ma_phong_ban = (System.Web.UI.WebControls.TextBox)v_arr_gvr[i].FindControl("m_txt_ma_phong_ban_grid");
            v_txt_nguoi_nhan = (System.Web.UI.WebControls.TextBox)v_arr_gvr[i].FindControl("m_txt_nguoi_nhan_grid");
            v_txt_nguoi_gui = (System.Web.UI.WebControls.TextBox)v_arr_gvr[i].FindControl("m_txt_nguoi_gui_grid");
            v_txt_noi_nhan = (System.Web.UI.WebControls.TextBox)v_arr_gvr[i].FindControl("m_txt_noi_nhan_grid");
            v_txt_noi_dung_gui = (System.Web.UI.WebControls.TextBox)v_arr_gvr[i].FindControl("m_txt_noi_dung_grid");
            v_txt_noi_ghi_chu = (System.Web.UI.WebControls.TextBox)v_arr_gvr[i].FindControl("m_txt_ghi_chu_grid");
            v_rdb_trong_nuoc = (System.Web.UI.WebControls.RadioButton)v_arr_gvr[i].FindControl("m_rdb_trong_nuoc");
            //v_dat_ngay_gui = (eWorld.UI.CalendarPopup)v_arr_gvr[i].FindControl("m_dat_ngay_gui");
            System.Web.UI.WebControls.TextBox v_txt_ngay_gui = (System.Web.UI.WebControls.TextBox)v_arr_gvr[i].FindControl("m_txt_ngay_gui_grid");


            US_DM_PHONG_BAN v_us_dm_phong_ban = new US_DM_PHONG_BAN();
            DS_DM_PHONG_BAN v_ds_dm_phong_ban = new DS_DM_PHONG_BAN();
            // chỗ này kiêm tra điêu kiên phân quyen du lieu
            // chi cho luu du lieu cua phong ban duoc phan quyen

            //em bỏ check ơr ma phong ban roi
            if (CIPConvert.ToDecimal(m_hdf_so_ban_ghi.Value) == m_grv_dm_bill.PageIndex) return;
            v_us_dm_phong_ban.FillDataset(v_ds_dm_phong_ban, "where id=" + CIPConvert.ToDecimal(m_hdf_id_trung_tam.Value));
            if (v_ds_dm_phong_ban.DM_PHONG_BAN.Count < 1) continue;
            else
            {
                v_us_dm_bill = new US_DM_BILL();
                //v_us_dm_bill.BeginTransaction();
                v_us_dm_bill.dcID_PHONG_BAN = CIPConvert.ToDecimal(v_ds_dm_phong_ban.DM_PHONG_BAN[0][0]);
                v_us_dm_bill.dcID_TRANG_THAI = CONST_ID_TRANG_THAI_THU.ID_DA_NHAN_NOI_BO;
                v_us_dm_bill.strSO_BILL = v_txt_so_bill.Text.Trim();
                v_us_dm_bill.strGHI_CHU = v_txt_noi_ghi_chu.Text.Trim();
                v_us_dm_bill.strNGUOI_GUI = v_txt_nguoi_gui.Text.Trim();
                v_us_dm_bill.strNGUOI_NHAN = v_txt_nguoi_nhan.Text.Trim();
                v_us_dm_bill.strNOI_NHAN = v_txt_noi_nhan.Text.Trim();
                v_us_dm_bill.strNOI_DUNG = v_txt_noi_dung_gui.Text.Trim();
                //v_us_dm_bill.datNGAY_GUI = v_dat_ngay_gui.SelectedDate;
                v_us_dm_bill.datNGAY_GUI = CIPConvert.ToDatetime(v_txt_ngay_gui.Text.Trim(), "dd/MM/yyyy");
                if (v_rdb_trong_nuoc.Checked == true)
                {
                    v_us_dm_bill.strTRONG_NUOC = "x";
                    v_us_dm_bill.SetNUOC_NGOAINull();
                }
                else
                {
                    v_us_dm_bill.SetTRONG_NUOCNull();
                    v_us_dm_bill.strNUOC_NGOAI = "x";
                }
                v_us_dm_bill.Insert();

                thong_bao("Đã import thành công!", true);
            }
            //}
            //if (numbers_record_limited == 50)
            //    start_number = start_number + 50; // lấy vị trí bản ghi tiếp theo sẽ dc insert nếu còn
            //numbers_record_remain = numbers_record_remain - 50; // tính số bản ghi còn lại chưa insert
        }
        m_grv_dm_bill.PageIndex = m_grv_dm_bill.PageIndex + 1;
        if (CIPConvert.ToDecimal(m_hdf_so_ban_ghi.Value) == m_grv_dm_bill.PageIndex)
        {
            m_grv_dm_bill.DataSource = null;
            m_grv_dm_bill.Visible = false;
        }
        m_grv_dm_bill.DataBind();
    }
    private bool check_validate_grid_is_ok()
    {
        bool v_b_result = true;
        if (Session[SESSION.UserID] == null)
        {
            Response.Redirect("/QuanLyHanhChinh/Default.aspx", false);
        }
        decimal v_dc_id_user = CIPConvert.ToDecimal(Session[SESSION.UserID]);
        US_HT_NGUOI_SU_DUNG v_us_ht_nguoi_su_dung = new US_HT_NGUOI_SU_DUNG(v_dc_id_user);
        US_HT_USER_GROUP v_us_ht_user_group = new US_HT_USER_GROUP(v_us_ht_nguoi_su_dung.dcID_USER_GROUP);
        DS_HT_USER_GROUP v_ds_ht_user_group = new DS_HT_USER_GROUP();
        US_HT_QUAN_HE_SU_DUNG_DU_LIEU v_us_ht_quan_he_su_dung_du_lieu = new US_HT_QUAN_HE_SU_DUNG_DU_LIEU();
        string v_str_ma_phong_ban = v_us_ht_quan_he_su_dung_du_lieu.get_all_ma_phong_ban_by_id_user_group(v_us_ht_user_group.dcID);

        System.Drawing.Color v_color_alert = System.Drawing.Color.LightGreen;
        System.Drawing.Color v_color_alert_message = System.Drawing.Color.Green;
        System.Drawing.Color v_color_ok = System.Drawing.Color.Blue;
        System.Drawing.Color v_color_dangerous = System.Drawing.Color.LightPink;
        System.Drawing.Color v_color_dangerous_message = System.Drawing.Color.Red;
        System.Drawing.Color v_color_normal = System.Drawing.Color.White;

        GridViewRow[] v_arr_gvr = new GridViewRow[m_grv_dm_bill.Rows.Count];
        m_grv_dm_bill.Rows.CopyTo(v_arr_gvr, 0);
        for (int i = 0; i < v_arr_gvr.Length; i++)
        {
            System.Web.UI.WebControls.TextBox v_txt_so_bill = (System.Web.UI.WebControls.TextBox)v_arr_gvr[i].FindControl("m_txt_so_bill_grid");

            System.Web.UI.WebControls.TextBox v_txt_ma_phong_ban = (System.Web.UI.WebControls.TextBox)v_arr_gvr[i].FindControl("m_txt_ma_phong_ban_grid");
            System.Web.UI.WebControls.TextBox v_txt_nguoi_nhan = (System.Web.UI.WebControls.TextBox)v_arr_gvr[i].FindControl("m_txt_nguoi_nhan_grid");
            System.Web.UI.WebControls.TextBox v_txt_nguoi_gui = (System.Web.UI.WebControls.TextBox)v_arr_gvr[i].FindControl("m_txt_nguoi_gui_grid");
            System.Web.UI.WebControls.TextBox v_txt_noi_nhan = (System.Web.UI.WebControls.TextBox)v_arr_gvr[i].FindControl("m_txt_noi_nhan_grid");
            System.Web.UI.WebControls.TextBox v_txt_noi_dung_gui = (System.Web.UI.WebControls.TextBox)v_arr_gvr[i].FindControl("m_txt_noi_dung_grid");

            System.Web.UI.WebControls.Label v_lbl_so_bill_message = (System.Web.UI.WebControls.Label)v_arr_gvr[i].FindControl("m_lbl_so_bill_message");
            System.Web.UI.WebControls.Label v_lbl_ma_phong_ban_message = (System.Web.UI.WebControls.Label)v_arr_gvr[i].FindControl("m_lbl_ma_phong_ban_message");
            System.Web.UI.WebControls.Label v_lbl_nguoi_nhan_message = (System.Web.UI.WebControls.Label)v_arr_gvr[i].FindControl("m_lbl_nguoi_nhan_message");
            System.Web.UI.WebControls.Label v_lbl_nguoi_gui_message = (System.Web.UI.WebControls.Label)v_arr_gvr[i].FindControl("m_lbl_nguoi_gui_message");
            System.Web.UI.WebControls.Label v_lbl_noi_nhan_message = (System.Web.UI.WebControls.Label)v_arr_gvr[i].FindControl("m_lbl_noi_nhan_message");
            System.Web.UI.WebControls.Label v_lbl_noi_dung_gui_message = (System.Web.UI.WebControls.Label)v_arr_gvr[i].FindControl("m_lbl_noi_dung_message");
            // check so bill
            if (!v_txt_so_bill.Text.Equals("") && check_validate_is_having_so_bill(v_txt_so_bill.Text.Trim()))
            {
                v_txt_so_bill.BackColor = v_color_normal;
                v_lbl_so_bill_message.Text = "Dữ liệu hợp lý!";
                v_lbl_so_bill_message.ForeColor = v_color_ok;
                v_lbl_so_bill_message.Font.Bold = true;
            }
            else
            {
                v_txt_so_bill.BackColor = v_color_dangerous;
                v_lbl_so_bill_message.Text = "Số bill đã tồn tại hoặc đang để trống!";
                v_lbl_so_bill_message.ForeColor = v_color_dangerous_message;
                v_lbl_so_bill_message.Font.Bold = true;
                v_b_result = false;
            }
            ////check ma phong ban
            //if(!v_txt_ma_phong_ban.Text.Equals("") && v_str_ma_phong_ban.Contains(v_txt_ma_phong_ban.Text.Trim().ToUpper())) {
            //    v_txt_ma_phong_ban.BackColor = v_color_normal;
            //    v_lbl_ma_phong_ban_message.Text = "Dữ liệu hợp lý!";
            //    v_lbl_ma_phong_ban_message.ForeColor = v_color_ok;
            //    v_lbl_ma_phong_ban_message.Font.Bold = true;
            //}
            //else {
            //    v_txt_ma_phong_ban.BackColor = v_color_dangerous;
            //    v_lbl_ma_phong_ban_message.Text = "Bạn chỉ được nhập bill của phòng: "+v_str_ma_phong_ban+" !";
            //    v_lbl_ma_phong_ban_message.ForeColor = v_color_dangerous_message;
            //    v_lbl_ma_phong_ban_message.Font.Bold = true;
            //    v_b_result = false;
            //}
            //check nguoi gui
            if (!v_txt_nguoi_gui.Text.Equals(""))
            {
                v_txt_nguoi_gui.BackColor = v_color_normal;
                v_lbl_nguoi_gui_message.Text = "Dữ liệu hợp lý!";
                v_lbl_nguoi_gui_message.ForeColor = v_color_ok;
                v_lbl_nguoi_gui_message.Font.Bold = true;
            }
            else
            {
                v_txt_nguoi_gui.BackColor = v_color_dangerous;
                v_lbl_nguoi_gui_message.Text = "Bạn phải nhập người gửi!";
                v_lbl_nguoi_gui_message.ForeColor = v_color_dangerous_message;
                v_lbl_nguoi_gui_message.Font.Bold = true;
                v_b_result = false;
            }
            //check so nguoi nhan
            if (!v_txt_nguoi_nhan.Text.Equals(""))
            {
                v_txt_nguoi_nhan.BackColor = v_color_normal;
                v_lbl_nguoi_nhan_message.Text = "Dữ liệu hợp lý!";
                v_lbl_nguoi_nhan_message.ForeColor = v_color_ok;
                v_lbl_nguoi_nhan_message.Font.Bold = true;
            }
            else
            {
                v_txt_nguoi_nhan.BackColor = v_color_dangerous;
                v_lbl_nguoi_nhan_message.Text = "Bạn phải nhập người nhận!";
                v_lbl_nguoi_nhan_message.ForeColor = v_color_dangerous_message;
                v_lbl_nguoi_nhan_message.Font.Bold = true;
                v_b_result = false;
            }
            //check so noi nhan
            if (!v_txt_noi_nhan.Text.Equals(""))
            {
                v_txt_noi_nhan.BackColor = v_color_normal;
                v_lbl_noi_nhan_message.Text = "Dữ liệu hợp lý!";
                v_lbl_noi_nhan_message.ForeColor = v_color_ok; ;
                v_lbl_noi_nhan_message.Font.Bold = true;
            }
            else
            {
                v_txt_noi_nhan.BackColor = v_color_dangerous;
                v_lbl_noi_nhan_message.Text = "Bạn phải nhập nơi nhận!";
                v_lbl_noi_nhan_message.ForeColor = v_color_dangerous_message;
                v_lbl_noi_nhan_message.Font.Bold = true;
                v_b_result = false;
            }
            ////check so noi dung gui
            //if (!v_txt_noi_dung_gui.Text.Equals(""))
            //{
            //    v_txt_noi_dung_gui.BackColor = v_color_normal;
            //    v_lbl_noi_dung_gui_message.Text = "Dữ liệu hợp lý!";
            //    v_lbl_noi_dung_gui_message.ForeColor = v_color_ok; ;
            //    v_lbl_noi_dung_gui_message.Font.Bold = true;
            //}
            //else
            //{
            //    v_txt_noi_dung_gui.BackColor = v_color_alert;
            //    v_lbl_noi_dung_gui_message.Text = "Bạn phải nên nhập nội dung gửi!";
            //    v_lbl_noi_dung_gui_message.ForeColor = v_color_alert_message;
            //    v_lbl_noi_dung_gui_message.Font.Bold = true;
            //}
        }
        return v_b_result;
    }
    private bool check_file_upload_is_ok(string ip_str_file_name)
    {
        if (!Path.GetExtension(ip_str_file_name).Equals(".xls")) {return false;}
        return true;
    }

    #endregion

    #region Events
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            //this.Form.DefaultButton = m_cmd_tim_kiem.UniqueID;
            if (!IsPostBack)
            {
                if (!Person.check_user_have_menu())
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "<script type = 'text/javascript'>alert('Bạn không có quyền sử dụng chức năng này!');window.location.replace('/TraCuuKeToan/')</script>");
                }
                US_HT_NGUOI_SU_DUNG v_us_nguoi_su_dung = new US_HT_NGUOI_SU_DUNG();
                if (Session[SESSION.AccounLoginYN] == "Y")
                {
                    decimal v_id_user = CIPConvert.ToDecimal(Session[SESSION.UserID]);
                    US_HT_NGUOI_SU_DUNG v_us_ht_nguoi_su_dung = new US_HT_NGUOI_SU_DUNG();
                    IP.Core.IPData.DS_HT_NGUOI_SU_DUNG v_ds_ht_nguoi_su_dung = new IP.Core.IPData.DS_HT_NGUOI_SU_DUNG();
                    v_us_ht_nguoi_su_dung.FillDataset(v_ds_ht_nguoi_su_dung, " WHERE ID =" + v_id_user);
                    decimal v_id_user_group = CIPConvert.ToDecimal(v_ds_ht_nguoi_su_dung.HT_NGUOI_SU_DUNG.Rows[0]["ID_USER_GROUP"]);
                    US_HT_QUAN_HE_SU_DUNG_DU_LIEU v_us_ht_qh_sd_dl = new US_HT_QUAN_HE_SU_DUNG_DU_LIEU();
                    DS_HT_QUAN_HE_SU_DUNG_DU_LIEU v_ds_ht_qh_sd_dl = new DS_HT_QUAN_HE_SU_DUNG_DU_LIEU();
                    v_us_ht_qh_sd_dl.FillDataset(v_ds_ht_qh_sd_dl, "where ID_USER_GROUP =" + v_id_user_group);
                    m_hdf_id_trung_tam.Value = v_ds_ht_qh_sd_dl.HT_QUAN_HE_SU_DUNG_DU_LIEU.Rows[0]["ID_PHONG_BAN"].ToString();
                    thong_bao("", false);
                }
                else
                {
                    Response.Redirect("../Default.aspx", false);
                    HttpContext.Current.ApplicationInstance.CompleteRequest();
                }
            }
            thong_bao("", false);
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    protected void m_cmd_upload_Click(object sender, EventArgs e)
    {
        try
        {
            if (m_fu_chon_file_import.HasFile)
            {
                string v_str_file_save = DateTime.Now.ToString("ss.fff") + m_fu_chon_file_import.FileName;
                m_hdf_dir_save_excel.Value = Server.MapPath("~") + "//TempImportExcel//" + v_str_file_save;
                save_file_upload(m_hdf_dir_save_excel.Value);
                if (check_file_upload_is_ok(m_fu_chon_file_import.FileName))
                {
                    excel_file_to_grid(m_grv_dm_bill, 1, m_hdf_dir_save_excel.Value);
                    check_validate_grid_is_ok();
                }
                else
                {
                    thong_bao("Bạn phải import file excel .xls",true);
                }
                
                //delete_file_imported(m_hdf_dir_save_excel.Value);
            }
        }
        catch (Exception v_e)
        {
            thong_bao("Import không thành công",true);
            delete_file_imported(m_hdf_dir_save_excel.Value);
            m_sm.ExceptionHanlde(this, v_e);
        }
    }
    protected void m_cmd_kiem_tra_va_import_Click(object sender, EventArgs e)
    {
        try
        {
            if (check_validate_grid_is_ok())
            {

                save_grid_to_database();
                excel_file_to_grid(m_grv_dm_bill, 1, m_hdf_dir_save_excel.Value);
                check_validate_grid_is_ok();
            }
        }
        catch (Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }

    }
    protected void m_grv_dm_bill_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

    }
    protected void m_grv_dm_bill_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            m_grv_dm_bill.PageIndex = e.NewPageIndex;
            excel_file_to_grid(m_grv_dm_bill, 1, m_hdf_dir_save_excel.Value);
            check_validate_grid_is_ok();
            //m_grv_dm_bill.DataBind();
        }
        catch (Exception v_e)
        {

            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    private bool check_validate_is_having_so_bill(string ip_str_so_bill)
    {
        bool v_b_result = true;
        US_DM_BILL v_us_dm_bill = new US_DM_BILL();
        DS_DM_BILL v_ds_dm_bill = new DS_DM_BILL();
        v_us_dm_bill.FillDataset(v_ds_dm_bill, "where so_bill = '" + ip_str_so_bill + "'");
        if (v_ds_dm_bill.DM_BILL.Count > 0) v_b_result = false;
        return v_b_result;
    }
    protected void m_cmd_ok_Click(object sender, EventArgs e)
    {
        try
        {
            thong_bao("", false);
        }
        catch (System.Exception v_e)
        {
            CSystemLog_301.ExceptionHandle(this, v_e);
        }
    }
    #endregion

}