///************************************************
/// Generated by: TuDM
/// Date: 24/07/2014 08:40:08
/// Goal: Create User Service Class for GD_DON_DAT_HANG
///************************************************
/// <summary>
/// Create User Service Class for GD_DON_DAT_HANG
/// </summary>

using System;
using BCTKDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BCTKUS{

public class US_GD_DON_DAT_HANG : US_Object
{
	private const string c_TableName = "GD_DON_DAT_HANG";
#region "Public Properties"
	public decimal dcID 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID"] = value;
		}
	}

	public bool IsIDNull()	{
		return pm_objDR.IsNull("ID");
	}

	public void SetIDNull() {
		pm_objDR["ID"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_DAT_HANG
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_DAT_HANG", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_DAT_HANG"] = value;
		}
	}

	public bool IsNGAY_DAT_HANGNull()
	{
		return pm_objDR.IsNull("NGAY_DAT_HANG");
	}

	public void SetNGAY_DAT_HANGNull()
	{
		pm_objDR["NGAY_DAT_HANG"] = System.Convert.DBNull;
	}

	public decimal dcLAN 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "LAN", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["LAN"] = value;
		}
	}

	public bool IsLANNull()	{
		return pm_objDR.IsNull("LAN");
	}

	public void SetLANNull() {
		pm_objDR["LAN"] = System.Convert.DBNull;
	}

	public decimal dcID_TRANG_THAI 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_TRANG_THAI", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_TRANG_THAI"] = value;
		}
	}

	public bool IsID_TRANG_THAINull()	{
		return pm_objDR.IsNull("ID_TRANG_THAI");
	}

	public void SetID_TRANG_THAINull() {
		pm_objDR["ID_TRANG_THAI"] = System.Convert.DBNull;
	}

	public decimal dcID_PHONG_BAN 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_PHONG_BAN", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_PHONG_BAN"] = value;
		}
	}

	public bool IsID_PHONG_BANNull()	{
		return pm_objDR.IsNull("ID_PHONG_BAN");
	}

	public void SetID_PHONG_BANNull() {
		pm_objDR["ID_PHONG_BAN"] = System.Convert.DBNull;
	}

	public string strMA 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA"] = value;
		}
	}

	public bool IsMANull() 
	{
		return pm_objDR.IsNull("MA");
	}

	public void SetMANull() {
		pm_objDR["MA"] = System.Convert.DBNull;
	}

	public decimal dcGIA_TRI_CHUA_VAT 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "GIA_TRI_CHUA_VAT", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["GIA_TRI_CHUA_VAT"] = value;
		}
	}

	public bool IsGIA_TRI_CHUA_VATNull()	{
		return pm_objDR.IsNull("GIA_TRI_CHUA_VAT");
	}

	public void SetGIA_TRI_CHUA_VATNull() {
		pm_objDR["GIA_TRI_CHUA_VAT"] = System.Convert.DBNull;
	}

	public decimal dcGIA_TRI_DA_VAT 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "GIA_TRI_DA_VAT", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["GIA_TRI_DA_VAT"] = value;
		}
	}

	public bool IsGIA_TRI_DA_VATNull()	{
		return pm_objDR.IsNull("GIA_TRI_DA_VAT");
	}

	public void SetGIA_TRI_DA_VATNull() {
		pm_objDR["GIA_TRI_DA_VAT"] = System.Convert.DBNull;
	}

	public string strMA_HD_NCC 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_HD_NCC", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_HD_NCC"] = value;
		}
	}

	public bool IsMA_HD_NCCNull() 
	{
		return pm_objDR.IsNull("MA_HD_NCC");
	}

	public void SetMA_HD_NCCNull() {
		pm_objDR["MA_HD_NCC"] = System.Convert.DBNull;
	}

#endregion

#region "Init Functions"
	public US_GD_DON_DAT_HANG() 
	{
		pm_objDS = new DS_GD_DON_DAT_HANG();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_GD_DON_DAT_HANG(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_GD_DON_DAT_HANG(decimal i_dbID) 
	{
		pm_objDS = new DS_GD_DON_DAT_HANG();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion

    public void Update_tong_tien_don_hang(DS_GD_DON_DAT_HANG ip_v_ds, decimal ip_id_don_hang)
    {
        CStoredProc v_store_proc = new CStoredProc("pr_update_gia_tien_don_hang");
        v_store_proc.addDecimalInputParam("@ID_DON_DAT_HANG ", ip_id_don_hang);
        v_store_proc.fillDataSetByCommand(this, ip_v_ds);
    }

    public bool check_is_having_ma_don_hang(string ip_ma_don_hang)
    {
        DS_GD_DON_DAT_HANG v_ds = new DS_GD_DON_DAT_HANG();
        CStoredProc v_cstore = new CStoredProc("pr_check_is_having_ma_don_hang");
        v_cstore.addNVarcharInputParam("@MA_DON_HANG", ip_ma_don_hang);
        v_cstore.fillDataSetByCommand(this, v_ds);
        if (v_ds.GD_DON_DAT_HANG.Rows.Count == 0)
            return false;
        return true;
    }
    public void load_ddh_xin_td_duyet(DS_GD_DON_DAT_HANG ip_ds, decimal ip_id_trung_tam, DateTime ip_dau_thang, DateTime ip_cuoi_thang) {
        CStoredProc v_store_proc = new CStoredProc("pr_td_duyet_don_dat_hang");
        v_store_proc.addDecimalInputParam("@ID_TRUNG_TAM ", ip_id_trung_tam);
        v_store_proc.addDatetimeInputParam("@DAU_THANG", ip_dau_thang);
        v_store_proc.addDatetimeInputParam("@CUOI_THANG", ip_cuoi_thang);
        v_store_proc.fillDataSetByCommand(this, ip_ds);
    }
    public void load_ddh_xin_cc_duyet(DS_GD_DON_DAT_HANG ip_ds, decimal ip_id_trung_tam, DateTime ip_dau_thang, DateTime ip_cuoi_thang)
    {
        CStoredProc v_store_proc = new CStoredProc("pr_cc_duyet_don_dat_hang");
        v_store_proc.addDecimalInputParam("@ID_TRUNG_TAM ", ip_id_trung_tam);
        v_store_proc.addDatetimeInputParam("@DAU_THANG", ip_dau_thang);
        v_store_proc.addDatetimeInputParam("@CUOI_THANG", ip_cuoi_thang);
        v_store_proc.fillDataSetByCommand(this, ip_ds);
    }
    public decimal get_tong_tien_dinh_muc_hang_thang(decimal ip_id_trung_tam, decimal ip_id_loai_dinh_muc, DateTime ip_dau_thang, DateTime ip_cuoi_thang) {
        CStoredProc v_store_proc = new CStoredProc("[pr_get_tong_tien_dm_theo_thang]");
        v_store_proc.addDecimalInputParam("@ID_TRUNG_TAM ", ip_id_trung_tam);
        v_store_proc.addDatetimeInputParam("@DAU_THANG", ip_dau_thang.Date);
        v_store_proc.addDatetimeInputParam("@CUOI_THANG", ip_cuoi_thang.Date);
        v_store_proc.addDecimalInputParam("@ID_LOAI_DINH_MUC", ip_id_loai_dinh_muc);
        SqlParameter v_obj_tong_tien_dinh_muc = v_store_proc.addDecimalOutputParam("@TONG_TIEN", 0);


        v_store_proc.ExecuteCommand(this);
        if(v_obj_tong_tien_dinh_muc.Value!=null)
            return CIPConvert.ToDecimal(v_obj_tong_tien_dinh_muc.Value);
        return 0;
    }
    public decimal get_tong_tien_da_chi_hang_thang(decimal ip_id_trung_tam, DateTime ip_thang) {
        CStoredProc v_store_proc = new CStoredProc("[pr_get_tong_tien_da_chi_hang_thang]");
        v_store_proc.addDecimalInputParam("@ID_TRUNG_TAM ", ip_id_trung_tam);
        v_store_proc.addDatetimeInputParam("@THANG", ip_thang.Date);
        SqlParameter v_obj_tong_tien_dinh_muc = v_store_proc.addDecimalOutputParam("@TONG_TIEN", 0);


        v_store_proc.ExecuteCommand(this);
        if(v_obj_tong_tien_dinh_muc.Value!=null)
            return CIPConvert.ToDecimal(v_obj_tong_tien_dinh_muc.Value);
        return 0;
    }

    public void Chuyen_trang_thai_gui_cho_td(DS_GD_DON_DAT_HANG ip_v_ds, string ip_ma_phieu)
    {
        CStoredProc v_store_proc = new CStoredProc("pr_chuyen_trang_thai_xin_td_duyet");
        v_store_proc.addNVarcharInputParam("@MA_PHIEU",ip_ma_phieu);
        v_store_proc.fillDataSetByCommand(this, ip_v_ds);
    }

    public void Kiem_tra_don_dat_hang_hdncc(DS_GD_DON_DAT_HANG ip_v_ds, string ip_ma_phieu)
    {
        CStoredProc v_store_proc = new CStoredProc("pr_Kiem_tra_don_dat_hang_hdncc");
        v_store_proc.addNVarcharInputParam("@MA_PHIEU", ip_ma_phieu);
        v_store_proc.fillDataSetByCommand(this, ip_v_ds);
    }

    public void Insert_ma_hdncc(DS_GD_DON_DAT_HANG ip_v_ds, string ip_ma_hd_ncc, string ip_ma_hd)
    {
        CStoredProc v_store_proc = new CStoredProc("pr_Insert_ma_hdncc");
        v_store_proc.addNVarcharInputParam("@MA_HD_NCC ", ip_ma_hd_ncc);
        v_store_proc.addNVarcharInputParam("@MA_HD ", ip_ma_hd);
        v_store_proc.fillDataSetByCommand(this, ip_v_ds);
    }
    public void FillDatasetSearch_Web(DS_GD_DON_DAT_HANG ip_ds, DateTime ip_dat_thang, decimal ip_id_trung_tam, decimal ip_id_trang_thai, string ip_str_tu_khoa)
    {
        CStoredProc v_store_proc = new CStoredProc("pr_GD_DON_DAT_HANG_Search_Web");
        v_store_proc.addDatetimeInputParam("@THANG", ip_dat_thang);
        v_store_proc.addDecimalInputParam("@ID_PHONG_BAN", ip_id_trung_tam);
        v_store_proc.addDecimalInputParam("@ID_TRANG_THAI", ip_id_trang_thai);
        v_store_proc.addNVarcharInputParam("@TU_KHOA", ip_str_tu_khoa);
        v_store_proc.fillDataSetByCommand(this, ip_ds);
    }

    public void FillDataset(DS_GD_DON_DAT_HANG ip_ds, DateTime v_ngay_dau_thang, decimal ip_id_trung_tam)
    {
        CStoredProc v_store_proc = new CStoredProc("pr_tao_don_hang");
        v_store_proc.addDecimalInputParam("@ID_PHONG_BAN", ip_id_trung_tam);
        v_store_proc.addDatetimeInputParam("@THANG", v_ngay_dau_thang);
        v_store_proc.fillDataSetByCommand(this, ip_ds);
    }

    public void get_so_don_hang_nhap_trung_tam(DS_GD_DON_DAT_HANG ip_ds, decimal ip_id_trung_Tam, decimal ip_id_trang_thai)
    {
        CStoredProc v_store_proc = new CStoredProc("pr_get_so_don_hang_nhap_trung_tam");
        v_store_proc.addDecimalInputParam("@ID_PHONG_BAN", ip_id_trung_Tam);
        v_store_proc.addDecimalInputParam("@ID_TRANG_THAI", ip_id_trang_thai);
        v_store_proc.fillDataSetByCommand(this, ip_ds);
    }
}
}
