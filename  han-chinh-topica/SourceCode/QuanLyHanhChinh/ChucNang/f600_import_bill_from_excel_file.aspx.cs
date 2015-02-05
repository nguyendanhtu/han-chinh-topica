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
using IP.Core.WinFormControls;
using IP.Core.IPSystemAdmin;

public partial class ChucNang_f600_import_bill_from_excel_file : System.Web.UI.Page
{

	#region Public Interfaces

	#endregion

	#region Members
	CSystemMessage m_sm = new CSystemMessage();
	int m_i_error_cout = 0;
	#endregion

	#region Data Structures

	public class CImportBillExcelWeb
	{
		private string _STT;
		private string _NOI_DUNG;
		private string _NOI_NHAN;
		private string _NGUOI_NHAN;
		private string _TRONG_NUOC;
		private string _NGOAI_NUOC;
		private string _SO_BILL;
		private string _NGUOI_GUI;
		private string _NGAY_GUI;
		private string _GHI_CHU;
		private string _MA_PHONG_BAN;
		private string _TEN_PHONG_BAN;
		private string _TRANG_THAI;
		public string STT
		{
			get { return _STT; }
			set { _STT = value; }
		}
		public string NOI_DUNG
		{
			get { return _NOI_DUNG; }
			set { _NOI_DUNG = value; }
		}
		public string NOI_NHAN
		{
			get { return _NOI_NHAN; }
			set { _NOI_NHAN = value; }
		}
		public string NGUOI_NHAN
		{
			get { return _NGUOI_NHAN; }
			set { _NGUOI_NHAN = value; }
		}
		public string TRONG_NUOC
		{
			get { return _TRONG_NUOC; }
			set { _TRONG_NUOC = value; }
		}
		public string NGOAI_NUOC
		{
			get { return _NGOAI_NUOC; }
			set { _NGOAI_NUOC = value; }
		}
		public string SO_BILL
		{
			get { return _SO_BILL; }
			set { _SO_BILL = value; }
		}
		public string NGUOI_GUI
		{
			get { return _NGUOI_GUI; }
			set { _NGUOI_GUI = value; }
		}
		public string NGAY_GUI
		{
			get { return _NGAY_GUI; }
			set { _NGAY_GUI = value; }
		}
		public string GHI_CHU
		{
			get { return _GHI_CHU; }
			set { _GHI_CHU = value; }
		}
		public string MA_PHONG_BAN
		{
			get { return _MA_PHONG_BAN; }
			set { _MA_PHONG_BAN = value; }
		}
		public string TEN_PHONG_BAN
		{
			get { return _TEN_PHONG_BAN; }
			set { _TEN_PHONG_BAN = value; }
		}
		public string TRANG_THAI
		{
			get { return _TRANG_THAI; }
			set { _TRANG_THAI = value; }
		}

		public CImportBillExcelWeb() { }
	}
	#endregion
	#region Private Methods
	private void set_intinal_form_load()
	{
		decimal v_id_trung_tam = CIPConvert.ToDecimal(m_hdf_id_trung_tam.Value);
		US_DM_PHONG_BAN v_us = new US_DM_PHONG_BAN();
		DS_DM_PHONG_BAN v_ds = new DS_DM_PHONG_BAN();
		v_us.FillDataset(v_ds, "where id=" + v_id_trung_tam);
		m_lbl_ten_trung_tam.Text = v_ds.DM_PHONG_BAN.Rows[0]["TEN_PHONG_BAN"].ToString();
		m_lbl_thong_tim_grv_dm_bill.Text = "(Chưa có Bill nào được import)";
		m_lbl_thong_tim_grv_dm_bill.ForeColor = System.Drawing.Color.Red;
		m_cmd_upload.Visible = true;
		m_cmd_kiem_tra_va_import.Visible = true;
	}
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
		try
		{
			File.Delete(ip_str_file_dir.Replace("//", "\\"));
		}
		catch (Exception)
		{
			File.Delete(ip_str_file_dir);
		}
	}
	
	
	private void excel_file_to_grid(GridView ip_grv, int ip_i_start_row, string ip_str_file_dir)
	{

		m_hdf_so_ban_ghi.Value = "0";
		FileStream v_fs_stream = File.Open(ip_str_file_dir, FileMode.Open, FileAccess.Read);
		IExcelDataReader v_edr = ExcelReaderFactory.CreateBinaryReader(v_fs_stream);
		DataSet v_ds_result = v_edr.AsDataSet();

		//DS_RPT_DS_IMPORT_BILL_EXCEL_WEB v_ds_merge = new DS_RPT_DS_IMPORT_BILL_EXCEL_WEB();
		List<CImportBillExcelWeb> lst_import = new List<CImportBillExcelWeb>();
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
			if (v_ds_result.Tables[0].Rows[i][2].ToString().Equals("") && v_ds_result.Tables[0].Rows[i][3].ToString().Equals(""))
			{
				v_ds_result.Tables[0].Rows[i].Delete();
				v_ds_result.AcceptChanges();
				v_i_row_count--;
				i--;
			}
		}
		for (int i = 0; i < v_i_row_count; i++)
		{
			//DataRow v_dr = v_ds_merge.Tables[0].NewRow();
			CImportBillExcelWeb v_bill = new CImportBillExcelWeb();
			v_bill.TRANG_THAI = "KHONG_DAT";
			string v_str_ma_phong_ban = "";
			DateTime v_dat = new DateTime();
			switch (m_hdf_phong_ban.Value)
			{
				case "tawl":
					v_str_ma_phong_ban = "TAW";
					v_bill.STT = "0";// CIPConvert.ToDecimal(v_ds_result.Tables[0].Rows[i][0]); //stt
					v_bill.NOI_DUNG = v_ds_result.Tables[0].Rows[i][5].ToString(); // nội dung
					v_bill.NOI_NHAN = v_ds_result.Tables[0].Rows[i][10].ToString(); // nơi nhận
					v_bill.NGUOI_NHAN = v_ds_result.Tables[0].Rows[i][3].ToString() + " " + v_ds_result.Tables[0].Rows[i][4].ToString(); //người nhận
					v_bill.TRONG_NUOC = "X"; // trong nước
					v_bill.NGOAI_NUOC = "";   //ngoài nước
					v_bill.SO_BILL = v_ds_result.Tables[0].Rows[i][2].ToString();
					v_bill.NGUOI_GUI = v_ds_result.Tables[0].Rows[i][12].ToString();
					if (DateTime.TryParseExact(v_ds_result.Tables[0].Rows[i][13].ToString(), "dd/MM/yyyy", null, new DateTimeStyles(), out v_dat))
					{
						v_bill.NGAY_GUI = CIPConvert.ToStr(v_dat, "dd/MM/yyyy");
					}
					else
					{
						v_bill.NGAY_GUI = CIPConvert.ToStr(DateTime.FromOADate(Convert.ToDouble(v_ds_result.Tables[0].Rows[i][13])), "dd/MM/yyyy");
					}
					//v_bill.NGAY_GUI = v_ds_result.Tables[0].Rows[i][13].ToString();
					v_bill.GHI_CHU = "";
					v_bill.MA_PHONG_BAN = v_str_ma_phong_ban;
					v_bill.TEN_PHONG_BAN = "TAW - Tư vấn tuyển sinh";
					break;
				case "tawh":
					v_str_ma_phong_ban = "TAW";
					v_bill.STT = "0";// CIPConvert.ToDecimal(v_ds_result.Tables[0].Rows[i][0]); //stt
					v_bill.NOI_DUNG = ""; // nội dung
					v_bill.NOI_NHAN = v_ds_result.Tables[0].Rows[i][10].ToString(); // nơi nhận
					v_bill.NGUOI_NHAN = v_ds_result.Tables[0].Rows[i][7].ToString();
					v_bill.TRONG_NUOC = "X"; // trong nước
					v_bill.NGOAI_NUOC = "";   //ngoài nước
					v_bill.SO_BILL = v_ds_result.Tables[0].Rows[i][12].ToString();
					v_bill.NGUOI_GUI = v_ds_result.Tables[0].Rows[i][2].ToString();
					//DateTime v_dat = new DateTime();
					if (DateTime.TryParseExact(v_ds_result.Tables[0].Rows[i][1].ToString(), "dd/MM/yyyy", null, new DateTimeStyles(), out v_dat))
					{
						v_bill.NGAY_GUI = CIPConvert.ToStr(v_dat, "dd/MM/yyyy");
					}
					else
					{
						v_bill.NGAY_GUI = CIPConvert.ToStr(DateTime.FromOADate(Convert.ToDouble(v_ds_result.Tables[0].Rows[i][1])), "dd/MM/yyyy");
					}
					//v_bill.NGAY_GUI = v_ds_result.Tables[0].Rows[i][1].ToString();
					v_bill.GHI_CHU = "";
					v_bill.MA_PHONG_BAN = v_str_ma_phong_ban;
					v_bill.TEN_PHONG_BAN = "TAW - Tư vấn tuyển sinh";
					break;
				case "tne":
					v_str_ma_phong_ban = "TNE";
					v_bill.STT = "0";// CIPConvert.ToDecimal(v_ds_result.Tables[0].Rows[i][0]); //stt
					v_bill.NOI_DUNG = ""; // nội dung
					v_bill.NOI_NHAN = v_ds_result.Tables[0].Rows[i][4].ToString(); // nơi nhận
					v_bill.NGUOI_NHAN = v_ds_result.Tables[0].Rows[i][1].ToString() + " " + v_ds_result.Tables[0].Rows[i][2].ToString(); //người nhận
					v_bill.TRONG_NUOC = "X"; // trong nước
					v_bill.NGOAI_NUOC = "";   //ngoài nước
					v_bill.SO_BILL = v_ds_result.Tables[0].Rows[i][6].ToString();
					v_bill.NGUOI_GUI = v_ds_result.Tables[0].Rows[i][8].ToString();
					if (DateTime.TryParseExact(v_ds_result.Tables[0].Rows[i][7].ToString(), "dd/MM/yyyy", null, new DateTimeStyles(), out v_dat))
					{
						v_bill.NGAY_GUI = CIPConvert.ToStr(v_dat, "dd/MM/yyyy");
					}
					else
					{
						v_bill.NGAY_GUI = CIPConvert.ToStr(DateTime.FromOADate(Convert.ToDouble(v_ds_result.Tables[0].Rows[i][7])), "dd/MM/yyyy");
					}
					//v_bill.NGAY_GUI = v_ds_result.Tables[0].Rows[i][7].ToString();
					v_bill.GHI_CHU = "";
					v_bill.MA_PHONG_BAN = v_str_ma_phong_ban;
					v_bill.TEN_PHONG_BAN = "TNE-Trung tâm Đào tạo NEU-EDUTOP";
					break;
				case "tmh":
					v_str_ma_phong_ban = "TMH";
					v_bill.STT = "0";// CIPConvert.ToDecimal(v_ds_result.Tables[0].Rows[i][0]); //stt
					v_bill.NOI_DUNG = ""; // nội dung
					v_bill.NOI_NHAN = v_ds_result.Tables[0].Rows[i][10].ToString(); // nơi nhận
					v_bill.NGUOI_NHAN = v_ds_result.Tables[0].Rows[i][7].ToString();
					v_bill.TRONG_NUOC = "X"; // trong nước
					v_bill.NGOAI_NUOC = "";   //ngoài nước
					v_bill.SO_BILL = v_ds_result.Tables[0].Rows[i][12].ToString();
					v_bill.NGUOI_GUI = v_ds_result.Tables[0].Rows[i][2].ToString();
					if (DateTime.TryParseExact(v_ds_result.Tables[0].Rows[i][1].ToString(), "dd/MM/yyyy", null, new DateTimeStyles(), out v_dat))
					{
						v_bill.NGAY_GUI = CIPConvert.ToStr(v_dat, "dd/MM/yyyy");
					}
					else
					{
						v_bill.NGAY_GUI = CIPConvert.ToStr(DateTime.FromOADate(Convert.ToDouble(v_ds_result.Tables[0].Rows[i][1])), "dd/MM/yyyy");
					}
					//v_bill.NGAY_GUI = v_ds_result.Tables[0].Rows[i][1].ToString();
					v_bill.GHI_CHU = "";
					v_bill.MA_PHONG_BAN = v_str_ma_phong_ban;
					v_bill.TEN_PHONG_BAN = "TMH-Trung tâm Đào tạo TOPICA - HOU";
					break;
				case "tad":
					v_str_ma_phong_ban = "TMH";
					v_bill.STT = "0";// CIPConvert.ToDecimal(v_ds_result.Tables[0].Rows[i][0]); //stt
					v_bill.NOI_DUNG = v_ds_result.Tables[0].Rows[i][1].ToString(); ; // nội dung
					v_bill.NOI_NHAN = v_ds_result.Tables[0].Rows[i][2].ToString(); // nơi nhận
					v_bill.NGUOI_NHAN = v_ds_result.Tables[0].Rows[i][3].ToString();
					v_bill.TRONG_NUOC = "X"; // trong nước
					v_bill.NGOAI_NUOC = "";   //ngoài nước
					v_bill.SO_BILL = v_ds_result.Tables[0].Rows[i][6].ToString();
					v_bill.NGUOI_GUI = v_ds_result.Tables[0].Rows[i][7].ToString();
					if (DateTime.TryParseExact(v_ds_result.Tables[0].Rows[i][8].ToString(), "dd/MM/yyyy", null, new DateTimeStyles(), out v_dat))
					{
						v_bill.NGAY_GUI = CIPConvert.ToStr(v_dat, "dd/MM/yyyy");
					}
					else
					{
						v_bill.NGAY_GUI = CIPConvert.ToStr(DateTime.FromOADate(Convert.ToDouble(v_ds_result.Tables[0].Rows[i][8])), "dd/MM/yyyy");
					}
					//v_bill.NGAY_GUI = v_ds_result.Tables[0].Rows[i][8].ToString();
					v_bill.GHI_CHU = v_ds_result.Tables[0].Rows[i][9].ToString();
					v_bill.MA_PHONG_BAN = v_str_ma_phong_ban;
					v_bill.TEN_PHONG_BAN = "TAD";
					break;
				case "tos":
					v_str_ma_phong_ban = "TMH";
					v_bill.STT = "0";// CIPConvert.ToDecimal(v_ds_result.Tables[0].Rows[i][0]); //stt
					v_bill.NOI_DUNG = v_ds_result.Tables[0].Rows[i][1].ToString(); ; // nội dung
					v_bill.NOI_NHAN = v_ds_result.Tables[0].Rows[i][2].ToString(); // nơi nhận
					v_bill.NGUOI_NHAN = v_ds_result.Tables[0].Rows[i][3].ToString();
					v_bill.TRONG_NUOC = "X"; // trong nước
					v_bill.NGOAI_NUOC = "";   //ngoài nước
					v_bill.SO_BILL = v_ds_result.Tables[0].Rows[i][6].ToString();
					v_bill.NGUOI_GUI = v_ds_result.Tables[0].Rows[i][7].ToString();
					if (DateTime.TryParseExact(v_ds_result.Tables[0].Rows[i][8].ToString(), "dd/MM/yyyy", null, new DateTimeStyles(), out v_dat))
					{
						v_bill.NGAY_GUI = CIPConvert.ToStr(v_dat, "dd/MM/yyyy");
					}
					else
					{
						v_bill.NGAY_GUI = CIPConvert.ToStr(DateTime.FromOADate(Convert.ToDouble(v_ds_result.Tables[0].Rows[i][8])), "dd/MM/yyyy");
					}
					//v_bill.NGAY_GUI = v_ds_result.Tables[0].Rows[i][8].ToString();
					v_bill.GHI_CHU = v_ds_result.Tables[0].Rows[i][9].ToString();
					v_bill.MA_PHONG_BAN = v_str_ma_phong_ban;
					v_bill.TEN_PHONG_BAN = "TOS";
					break;

			}
			//v_ds_merge.Tables[0].Rows.Add(v_dr);
			v_bill.STT = (i + 1).ToString();
			lst_import.Add(v_bill);
		}
		Session["TempImportExcel"] = null;
		Session["TempImportExcel"] = lst_import;
		List<CImportBillExcelWeb> lst_order = OrderByTrangThai(lst_import);

		if (m_i_error_cout == 0)
		{
			//save_data_to_database();
			//m_cmd_upload.Visible = true;
			//m_cmd_kiem_tra_va_import.Visible = false;
			//thong_bao("Đã cập nhật thành công " + lst_import.Count + " bill!");
			m_lbl_thong_tim_grv_dm_bill.Text = "Có tất cả " + lst_order.Count + " bill hợp lệ!";
			m_lbl_thong_tim_grv_dm_bill.ForeColor = System.Drawing.Color.Green;
			m_grv_dm_bill.DataSource = lst_order;
			m_grv_dm_bill.DataBind();
		}
		else
		{
			string v_str_mess = "Có tất cả " + lst_import.Count + " bill. Trong đó có " + (lst_import.Count - m_i_error_cout) + " bill hợp lệ và " + m_i_error_cout + " bill không hợp lệ bên dưới. Bạn hãy sửa chúng!";
			thong_bao(v_str_mess);
			ip_grv.DataSource = lst_order;
			//m_hdf_so_ban_ghi.Value = (lst_import.Count).ToString();
			m_grv_dm_bill.Visible = true;
			ip_grv.DataBind();
			m_lbl_thong_tim_grv_dm_bill.Text = v_str_mess;
			//check_validate_grid_is_ok();
		}
	}
	
	public void list_to_grid(string ip_mode)
	{
		List<CImportBillExcelWeb> lst_import = (List<CImportBillExcelWeb>)Session["TempImportExcel"];
		List<CImportBillExcelWeb> lst_err = OrderByTrangThai(lst_import);

		if (m_i_error_cout == 0 && ip_mode.Equals("Save"))
		{
			save_data_to_database();
			//m_cmd_upload.Visible = true;
			//m_cmd_kiem_tra_va_import.Visible = false;
			Session["TempImportExcel"] = null;
			thong_bao("Đã cập nhật thành công " + lst_import.Count + " bill!");
			m_lbl_thong_tim_grv_dm_bill.Text = "Đã cập nhật thành công " + lst_import.Count + " bill!";
			m_grv_dm_bill.DataSource = null;
			m_grv_dm_bill.DataBind();
		}
		else
		{
			//string v_str_mess = "Có tất cả " + lst_import.Count + " bill. Trong đó có " + lst_err.Count + " bill hợp lệ và " + (lst_import.Count - lst_err.Count) + " bill không hợp lệ bên dưới. Bạn hãy sửa chúng!";
			//thong_bao(v_str_mess);
			m_grv_dm_bill.DataSource = lst_err;
			//m_hdf_so_ban_ghi.Value = (lst_import.Count).ToString();
			m_grv_dm_bill.Visible = true;
			m_grv_dm_bill.DataBind();
			//m_lbl_thong_tim_grv_dm_bill.Text = v_str_mess;
			//check_validate_grid_is_ok();
		}
	}
	public List<CImportBillExcelWeb> OrderByTrangThai(List<CImportBillExcelWeb> ip_lst)
	{
		List<CImportBillExcelWeb> op_lst = new List<CImportBillExcelWeb>();
		for (int i = 0; i < ip_lst.Count; i++)
		{
			CImportBillExcelWeb v_bill = new CImportBillExcelWeb();
			v_bill = ip_lst[i];
			if (v_bill.NGUOI_GUI.Equals("") | v_bill.NGUOI_NHAN.Equals("") | v_bill.SO_BILL.Length != 8 | !isNumber(v_bill.SO_BILL) | !check_validate_so_bill_is_ok(v_bill.SO_BILL))
				ip_lst[i].TRANG_THAI = "N";
			else ip_lst[i].TRANG_THAI = "Y";
		}
		for (int i = 0; i < ip_lst.Count; i++)
		{
			if (ip_lst[i].TRANG_THAI == "N")
				op_lst.Add(ip_lst[i]);
		}
		m_i_error_cout = op_lst.Count;
		for (int i = 0; i < ip_lst.Count; i++)
		{
			if (ip_lst[i].TRANG_THAI == "Y")
				op_lst.Add(ip_lst[i]);
		}
		return op_lst;
	}
	
	
	
	private void save_data_to_database()
	{
		List<CImportBillExcelWeb> lst_import = new List<CImportBillExcelWeb>();
		lst_import = (List<CImportBillExcelWeb>)Session["TempImportExcel"];
		US_DM_PHONG_BAN v_us_dm_phong_ban = new US_DM_PHONG_BAN();
		DS_DM_PHONG_BAN v_ds_dm_phong_ban = new DS_DM_PHONG_BAN();
		v_us_dm_phong_ban.FillDataset(v_ds_dm_phong_ban, "where id=" + CIPConvert.ToDecimal(m_hdf_id_trung_tam.Value));
		if (v_ds_dm_phong_ban.DM_PHONG_BAN.Count >= 1)
			for (int i = 0; i < lst_import.Count; i++)
			{
				US_DM_BILL v_us = new US_DM_BILL();
				v_us.dcID_PHONG_BAN = CIPConvert.ToDecimal(v_ds_dm_phong_ban.DM_PHONG_BAN[0][0]);
				v_us.dcID_TRANG_THAI = CONST_ID_TRANG_THAI_THU.ID_DA_NHAN_NOI_BO;
				v_us.strSO_BILL = lst_import[i].SO_BILL;
				v_us.strGHI_CHU = lst_import[i].GHI_CHU;
				v_us.strNGUOI_GUI = lst_import[i].NGUOI_GUI;
				v_us.strNGUOI_NHAN = lst_import[i].NGUOI_NHAN;
				v_us.strNOI_NHAN = lst_import[i].NOI_NHAN;
				v_us.strNOI_DUNG = lst_import[i].NOI_DUNG;
				v_us.datNGAY_GUI = CIPConvert.ToDatetime(lst_import[i].NGAY_GUI, "dd/MM/yyyy");
				DateTime v_dat = new DateTime();
				if (DateTime.TryParseExact(lst_import[i].NGAY_GUI, "dd/MM/yyyy", null, new DateTimeStyles(), out v_dat))
				{
					v_us.datNGAY_GUI = v_dat;
				}
				else
				{
					v_us.datNGAY_GUI = DateTime.FromOADate(Convert.ToDouble(lst_import[i].NGAY_GUI));
				}
				v_us.strNUOC_NGOAI = lst_import[i].NGOAI_NUOC;
				v_us.strTRONG_NUOC = lst_import[i].TRONG_NUOC;
				v_us.Insert();

			}
		string v_str_ten_phong_ban = v_ds_dm_phong_ban.DM_PHONG_BAN[0][DM_PHONG_BAN.TEN_PHONG_BAN].ToString();
		string v_str_noi_dung = "Thông báo\n TAD đã nhận được thông tin đặt hàng CPN:\n Tên phòng:" + v_str_ten_phong_ban + "\n Tổng số bill: " + lst_import.Count + " bill"
			+ "\n Ngày gửi: " + DateTime.Now.ToString("dd/MM/yyyy");
		string v_str_subject = "[WebsiteQuanLyHanhChinh] Phong ban " + v_str_ten_phong_ban + " nhap bill";
		string v_str_send_mail_to = "";
		US_HT_NGUOI_SU_DUNG v_us_ht_nguoi_su_dung = new US_HT_NGUOI_SU_DUNG(69758);
		v_str_send_mail_to = v_us_ht_nguoi_su_dung.strMAIL;
		if (v_str_send_mail_to.Equals("")) return;
		WinFormControls.SendEmailHanhChinhTopica(v_str_send_mail_to, v_str_subject, v_str_noi_dung);

		//m_cmd_upload.Visible = true;
		//m_cmd_kiem_tra_va_import.Visible = false;
		Session["TempImportExcel"] = null;
	}
	private void save_grid_to_list()
	{
		List<CImportBillExcelWeb> lst_import = new List<CImportBillExcelWeb>();
		lst_import = (List<CImportBillExcelWeb>)Session["TempImportExcel"];
		if (lst_import.Count == 0)
		{
			//m_cmd_upload.Visible = true;
			//m_cmd_kiem_tra_va_import.Visible = false;
			return;
		}
		GridViewRow[] v_arr_gvr = new GridViewRow[m_grv_dm_bill.Rows.Count];
		System.Web.UI.WebControls.TextBox v_txt_so_bill;
		System.Web.UI.WebControls.TextBox v_txt_ma_phong_ban;
		System.Web.UI.WebControls.TextBox v_txt_nguoi_nhan;
		System.Web.UI.WebControls.TextBox v_txt_nguoi_gui;
		System.Web.UI.WebControls.TextBox v_txt_noi_nhan;
		System.Web.UI.WebControls.TextBox v_txt_noi_dung_gui;
		System.Web.UI.WebControls.TextBox v_txt_noi_ghi_chu;
		System.Web.UI.WebControls.RadioButton v_rdb_trong_nuoc;
		System.Web.UI.WebControls.HiddenField v_hdf_stt;
		m_grv_dm_bill.Rows.CopyTo(v_arr_gvr, 0);

		//Phải chia nhỏ để insert nếu số lượng bản ghi lớn

		int start_number = 0; //vị trí bản ghi bắt đầu insert
		int numbers_record_limited = v_arr_gvr.Length; // số bản ghi được insert k vượt quá 50

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
			v_hdf_stt = (System.Web.UI.WebControls.HiddenField)v_arr_gvr[i].FindControl("m_hdf_stt");
			System.Web.UI.WebControls.TextBox v_txt_ngay_gui = (System.Web.UI.WebControls.TextBox)v_arr_gvr[i].FindControl("m_txt_ngay_gui_grid");
			int v_index = findBillHaveSTT(lst_import, v_hdf_stt.Value);
			lst_import[v_index].SO_BILL = v_txt_so_bill.Text.Trim();
			lst_import[v_index].MA_PHONG_BAN = v_txt_ma_phong_ban.Text;
			lst_import[v_index].NGUOI_NHAN = v_txt_nguoi_nhan.Text;
			lst_import[v_index].NGUOI_GUI = v_txt_nguoi_gui.Text;
			lst_import[v_index].NOI_NHAN = v_txt_noi_nhan.Text;
			lst_import[v_index].NOI_DUNG = v_txt_noi_dung_gui.Text;
			lst_import[v_index].GHI_CHU = v_txt_noi_ghi_chu.Text;
			if (v_rdb_trong_nuoc.Checked == true)
			{
				lst_import[v_index].TRONG_NUOC = "X";
				lst_import[v_index].NGOAI_NUOC = "";
			}
			else
			{
				lst_import[v_index].TRONG_NUOC = "";
				lst_import[v_index].NGOAI_NUOC = "X";
			}

		}
		Session["TempImportExcel"] = null;
		Session["TempImportExcel"] = lst_import;
	}
	public bool isAllItemUniqueInList(List<CImportBillExcelWeb> ip_lst, ref string op_str_mess)
	{
		//get distinct count
		decimal v_dc_count_distict = 1;
		for (int i = 1; i < ip_lst.Count; i++)
		{
			bool v_b_isHavingItemLikeMe = false;
			for (int j = 0; j < ip_lst.Count; j++)
			{
				if (ip_lst[i].SO_BILL == ip_lst[j].SO_BILL && i != j)
				{
					v_b_isHavingItemLikeMe = true;
				}
			}
			if (!v_b_isHavingItemLikeMe) v_dc_count_distict++;
		}
		if (v_dc_count_distict != ip_lst.Count)
		{
			op_str_mess = "Có " + (ip_lst.Count - v_dc_count_distict) + " bản ghi có cùng số Bill, bạn hãy sửa lại file excel rồi thực hiện lại các thao tác import!";
			return false;
		}
		return true;
	}

	public int findBillHaveSTT(List<CImportBillExcelWeb> ip_lst, string ip_str_stt)
	{
		CImportBillExcelWeb v_bill = new CImportBillExcelWeb();
		int i = 0;
		for (i = 0; i < ip_lst.Count; i++)
		{
			if (ip_lst[i].STT == ip_str_stt)
			{
				v_bill = ip_lst[i];
				break;
			}
		}
		return i;
	}
	public bool isNumber(string ip_str)
	{
		decimal num;
		return decimal.TryParse(ip_str, out num);
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

			//System.Web.UI.WebControls.Label v_lbl_so_bill_message = (System.Web.UI.WebControls.Label)v_arr_gvr[i].FindControl("m_lbl_so_bill_message");
			//System.Web.UI.WebControls.Label v_lbl_ma_phong_ban_message = (System.Web.UI.WebControls.Label)v_arr_gvr[i].FindControl("m_lbl_ma_phong_ban_message");
			//System.Web.UI.WebControls.Label v_lbl_nguoi_nhan_message = (System.Web.UI.WebControls.Label)v_arr_gvr[i].FindControl("m_lbl_nguoi_nhan_message");
			//System.Web.UI.WebControls.Label v_lbl_nguoi_gui_message = (System.Web.UI.WebControls.Label)v_arr_gvr[i].FindControl("m_lbl_nguoi_gui_message");
			//System.Web.UI.WebControls.Label v_lbl_noi_nhan_message = (System.Web.UI.WebControls.Label)v_arr_gvr[i].FindControl("m_lbl_noi_nhan_message");
			//System.Web.UI.WebControls.Label v_lbl_noi_dung_gui_message = (System.Web.UI.WebControls.Label)v_arr_gvr[i].FindControl("m_lbl_noi_dung_message");
			// check so bill
			if (!v_txt_so_bill.Text.Equals("") && check_validate_so_bill_is_ok(v_txt_so_bill.Text.Trim()))
			{
				decimal num;
				bool isNumberic = decimal.TryParse(v_txt_so_bill.Text, out num);
				if (isNumberic == true && v_txt_so_bill.Text.Trim().Length == 8)
				{
					v_txt_so_bill.BackColor = v_color_normal;
					v_txt_so_bill.ToolTip = "Đã có dữ liệu. Click nếu muốn thay đổi";
				}
				else
				{
					if (isNumberic == false)
					{
						v_txt_so_bill.BackColor = v_color_dangerous;
						v_txt_so_bill.ToolTip = "Số bill phải là kiểu số. Click để sửa";
						v_b_result = false;
					}
					if (v_txt_so_bill.Text.Trim().Length != 8)
					{
						v_txt_so_bill.BackColor = v_color_dangerous;
						v_txt_so_bill.ToolTip = "Bạn phải nhập số bill có 8 chữ số";
						v_b_result = false;
					}
				}

				//v_lbl_so_bill_message.Text = "Dữ liệu hợp lý!";
				//v_lbl_so_bill_message.ForeColor = v_color_ok;
				//v_lbl_so_bill_message.Font.Bold = true;
			}
			else
			{
				v_txt_so_bill.BackColor = v_color_alert;
				//v_lbl_so_bill_message.Text = "Số bill đã tồn tại hoặc đang để trống!";
				v_txt_so_bill.ToolTip = "Số bill đã tồn tại hoặc đang để trống! Click để thêm hoặc chỉnh sửa";
				//v_lbl_so_bill_message.ForeColor = v_color_dangerous_message;
				//v_lbl_so_bill_message.Font.Bold = true;
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
				v_txt_nguoi_gui.ToolTip = "Dã có dữ liệu. Click nếu muốn thay đổi";
				//v_lbl_nguoi_gui_message.Text = "Dữ liệu hợp lý!";
				//v_lbl_nguoi_gui_message.ForeColor = v_color_ok;
				//v_lbl_nguoi_gui_message.Font.Bold = true;
			}
			else
			{
				v_txt_nguoi_gui.BackColor = v_color_dangerous;
				//v_lbl_nguoi_gui_message.Text = "Bạn phải nhập người gửi!";
				v_txt_nguoi_gui.ToolTip = "Bạn phải nhập người gửi";
				//v_lbl_nguoi_gui_message.ForeColor = v_color_dangerous_message;
				//v_lbl_nguoi_gui_message.Font.Bold = true;
				v_b_result = false;
			}
			//check so nguoi nhan
			if (!v_txt_nguoi_nhan.Text.Equals(""))
			{
				v_txt_nguoi_nhan.BackColor = v_color_normal;
				v_txt_nguoi_nhan.ToolTip = "Đã có dữ liệu. Click nếu muốn thay đổi";
				//v_lbl_nguoi_nhan_message.Text = "Dữ liệu hợp lý!";
				//v_lbl_nguoi_nhan_message.ForeColor = v_color_ok;
				//v_lbl_nguoi_nhan_message.Font.Bold = true;
			}
			else
			{
				v_txt_nguoi_nhan.BackColor = v_color_dangerous;
				//v_lbl_nguoi_nhan_message.Text = "Bạn phải nhập người nhận!";
				v_txt_noi_nhan.ToolTip = "Bạn phải nhập người nhận";
				//v_lbl_nguoi_nhan_message.ForeColor = v_color_dangerous_message;
				//v_lbl_nguoi_nhan_message.Font.Bold = true;
				v_b_result = false;
			}
			//check so noi nhan
			if (!v_txt_noi_nhan.Text.Equals(""))
			{
				v_txt_noi_nhan.BackColor = v_color_normal;
				v_txt_noi_nhan.ToolTip = "Đã có dữ liệu. Click nếu muốn thay đổi";
				//v_lbl_noi_nhan_message.Text = "Dữ liệu hợp lý!";
				//v_lbl_noi_nhan_message.ForeColor = v_color_ok; ;
				//v_lbl_noi_nhan_message.Font.Bold = true;
			}
			else
			{
				v_txt_noi_nhan.BackColor = v_color_dangerous;
				//v_lbl_noi_nhan_message.Text = "Bạn phải nhập nơi nhận!";
				v_txt_noi_nhan.ToolTip = "Bạn phải nhập người gửi";
				//v_lbl_noi_nhan_message.ForeColor = v_color_dangerous_message;
				//v_lbl_noi_nhan_message.Font.Bold = true;
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
		if (!Path.GetExtension(ip_str_file_name).Equals(".xls")) { return false; }
		return true;
	}
	private void show_import(string ip_str_phong_ban)
	{
		m_hdf_phong_ban.Value = ip_str_phong_ban;
		switch (ip_str_phong_ban)
		{
			case "tawl":
				m_pnl_import.Visible = true;
				m_pnl_import_grid.Visible = true;
				m_lnk_import_mau.NavigateUrl = "https://docs.google.com/spreadsheets/d/1EsFtp2P5G6vk-5C20x29va88WDRQ2fIgyRWTfcdZvPA/edit?usp=sharing";
				m_lnk_import_mau.Text = "Tải mẫu import của TAW (Lụa)";
				break;
			case "tawh":
				m_pnl_import.Visible = true;
				m_pnl_import_grid.Visible = true;
				m_lnk_import_mau.NavigateUrl = "https://docs.google.com/spreadsheets/d/1_n19Y5oxwEPz2jUr8dEdC1CnzmgxfJ-emc9CHoQl5wQ/edit#gid=337873717";
				m_lnk_import_mau.Text = "Tải mẫu import của TAW (Hồng)";
				break;
			case "tmh":
				m_pnl_import.Visible = true;
				m_pnl_import_grid.Visible = true;
				m_lnk_import_mau.NavigateUrl = "https://docs.google.com/spreadsheets/d/1EqEV10yIiMWMwwHrGagFVRHjefQaJbeDdAtfMNvgBqQ/edit?usp=sharing";
				m_lnk_import_mau.Text = "Tải mẫu import của TMH";
				break;
			case "tne":
				m_pnl_import.Visible = true;
				m_pnl_import_grid.Visible = true;
				m_lnk_import_mau.NavigateUrl = "https://docs.google.com/spreadsheets/d/1qtmFe5ftjLaJZRdtvtFVuecs8JV95GarXboAgnIRvR4/edit#gid=61115495";
				m_lnk_import_mau.Text = "Tải mẫu import của TNE";
				break;
			case "tad":
				m_pnl_import.Visible = true;
				m_pnl_import_grid.Visible = true;
				m_lnk_import_mau.NavigateUrl = "https://drive.google.com/file/d/0B9iodcNpN7ZYT0pXQkdnUmt5aUE/edit?usp=sharing";
				m_lnk_import_mau.Text = "Tải mẫu import chung (TAD)";
				break;
			case "tos":
				m_pnl_import.Visible = true;
				m_pnl_import_grid.Visible = true;
				m_lnk_import_mau.NavigateUrl = "https://drive.google.com/file/d/0B9iodcNpN7ZYOGN2SEtRU3hCR2c/edit?usp=sharing";
				m_lnk_import_mau.Text = "Tải mẫu import của TOS";
				break;
			default:
				m_pnl_import.Visible = false;
				m_pnl_import_grid.Visible = false;
				m_lnk_import_mau.NavigateUrl = "#";
				break;
		}
	}
	public bool check_validate_so_bill_is_ok(string ip_str_so_bill)
	{
		bool v_b_result = true;
		US_DM_BILL v_us_dm_bill = new US_DM_BILL();
		DS_DM_BILL v_ds_dm_bill = new DS_DM_BILL();
		v_us_dm_bill.FillDataset(v_ds_dm_bill, "where so_bill = '" + ip_str_so_bill + "'");
		if (v_ds_dm_bill.DM_BILL.Count > 0) v_b_result = false;
		return v_b_result;
	}
	#endregion

	#region Events
	protected void Page_Load(object sender, EventArgs e)
	{
		try
		{
			if (!IsPostBack)
			{
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
					set_intinal_form_load();
					thong_bao("", false);
					show_import("");
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
				string v_str_file_save = DateTime.Now.Year.ToString() + "." + DateTime.Now.Month.ToString() +
					"." + DateTime.Now.Day.ToString() + "." + DateTime.Now.ToString("ss.fff") + m_fu_chon_file_import.FileName;
				m_hdf_dir_save_excel.Value = Server.MapPath("~") + "//TempImportExcel//" + v_str_file_save;
				save_file_upload(m_hdf_dir_save_excel.Value);
				if (check_file_upload_is_ok(m_fu_chon_file_import.FileName))
				{
					excel_file_to_grid(m_grv_dm_bill, 1, m_hdf_dir_save_excel.Value);
					delete_file_imported(m_hdf_dir_save_excel.Value);
					check_validate_grid_is_ok();
				}
				else
				{
					thong_bao("Bạn phải import file excel .xls", true);
				}
			}
		}
		catch (Exception v_e)
		{
			thong_bao("Import không thành công. Bạn phải import file theo các mấu mà chúng tôi đã cung cấp!");
			m_grv_dm_bill.EmptyDataText = "Import không thành công!";
			delete_file_imported(m_hdf_dir_save_excel.Value);
		}
	}
	protected void m_cmd_kiem_tra_va_import_Click(object sender, EventArgs e)
	{
		try
		{
			List<CImportBillExcelWeb> lst_import = (List<CImportBillExcelWeb>)Session["TempImportExcel"];
			string v_str_mess = "";
			if (!isAllItemUniqueInList(lst_import, ref v_str_mess))
			{
				thong_bao(v_str_mess);
				return;
			}
			else
			{
				save_grid_to_list();
				list_to_grid("Save");
				check_validate_grid_is_ok();
			}


		}
		catch (Exception v_e)
		{
			//m_grv_dm_bill.DataSource = null;
			//m_grv_dm_bill.DataBind();
			//thong_bao("Import không thành công. Lỗi: " + v_e.ToString());
		}

	}
	protected void m_grv_dm_bill_RowDeleting(object sender, GridViewDeleteEventArgs e)
	{
		//save_grid_to_list();
		HiddenField v_hdf_stt = (HiddenField)(m_grv_dm_bill.Rows[e.RowIndex]).FindControl("m_hdf_stt");
		List<CImportBillExcelWeb> lst_import = new List<CImportBillExcelWeb>();
		lst_import = (List<CImportBillExcelWeb>)Session["TempImportExcel"];
		int v_index = findBillHaveSTT(lst_import, v_hdf_stt.Value);
		lst_import.RemoveAt(v_index);
		Session["TempImportExcel"] = null;
		Session["TempImportExcel"] = lst_import;
		m_cmd_kiem_tra_va_import_Click(null, null);
		//list_to_grid("Save");
		list_to_grid("NoSave");
		check_validate_grid_is_ok();

	}
	protected void m_grv_dm_bill_PageIndexChanging(object sender, GridViewPageEventArgs e)
	{
		try
		{
			m_grv_dm_bill.PageIndex = e.NewPageIndex;
			List<CImportBillExcelWeb> lst_import = new List<CImportBillExcelWeb>();
			lst_import = OrderByTrangThai((List<CImportBillExcelWeb>)Session["TempImportExcel"]);
			m_grv_dm_bill.DataSource = lst_import;
			m_grv_dm_bill.DataBind();
			check_validate_grid_is_ok();
		}
		catch (Exception v_e)
		{

			CSystemLog_301.ExceptionHandle(this, v_e);
		}
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

	protected void m_rdb_tawl_CheckedChanged(object sender, EventArgs e)
	{
		if (m_rdb_tawl.Checked == true)
		{
			show_import("tawl");
		}
	}
	protected void m_rdb_tawh_CheckedChanged(object sender, EventArgs e)
	{
		if (m_rdb_tawh.Checked == true)
		{
			show_import("tawh");
		}
	}
	protected void m_rdb_thm_CheckedChanged(object sender, EventArgs e)
	{
		if (m_rdb_thm.Checked == true)
		{
			show_import("tmh");
		}
	}
	protected void m_rdb_tne_CheckedChanged(object sender, EventArgs e)
	{
		if (m_rdb_tne.Checked == true)
		{
			show_import("tne");
		}
	}
	protected void m_rdb_tad_CheckedChanged(object sender, EventArgs e)
	{
		if (m_rdb_tad.Checked == true)
		{
			show_import("tad");
		}
	}
	protected void m_rdb_tos_CheckedChanged(object sender, EventArgs e)
	{
		if (m_rdb_tos.Checked == true)
		{
			show_import("tos");
		}

	}
	#endregion
}