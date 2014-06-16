///************************************************
/// Generated by: linhdh
/// Date: 06/11/2012 04:18:59
/// Goal: Create User Service Class for V_HT_LOG_TRUY_CAP
///************************************************
/// <summary>
/// Create User Service Class for V_HT_LOG_TRUY_CAP
/// </summary>

using System;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using BCTKDS;


namespace BCTKUS{

public class US_V_HT_LOG_TRUY_CAP : US_Object
{
	private const string c_TableName = "V_HT_LOG_TRUY_CAP";
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

	public decimal dcID_DANG_NHAP 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_DANG_NHAP", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_DANG_NHAP"] = value;
		}
	}

	public bool IsID_DANG_NHAPNull()	{
		return pm_objDR.IsNull("ID_DANG_NHAP");
	}

	public void SetID_DANG_NHAPNull() {
		pm_objDR["ID_DANG_NHAP"] = System.Convert.DBNull;
	}

	public string strTEN_TRUY_CAP 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_TRUY_CAP", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_TRUY_CAP"] = value;
		}
	}

	public bool IsTEN_TRUY_CAPNull() 
	{
		return pm_objDR.IsNull("TEN_TRUY_CAP");
	}

	public void SetTEN_TRUY_CAPNull() {
		pm_objDR["TEN_TRUY_CAP"] = System.Convert.DBNull;
	}

	public string strTEN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN"] = value;
		}
	}

	public bool IsTENNull() 
	{
		return pm_objDR.IsNull("TEN");
	}

	public void SetTENNull() {
		pm_objDR["TEN"] = System.Convert.DBNull;
	}

	public DateTime datTHOI_GIAN
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "THOI_GIAN", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["THOI_GIAN"] = value;
		}
	}

	public bool IsTHOI_GIANNull()
	{
		return pm_objDR.IsNull("THOI_GIAN");
	}

	public void SetTHOI_GIANNull()
	{
		pm_objDR["THOI_GIAN"] = System.Convert.DBNull;
	}

	public decimal dcID_LOAI_HANH_DONG 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_HANH_DONG", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_LOAI_HANH_DONG"] = value;
		}
	}

	public bool IsID_LOAI_HANH_DONGNull()	{
		return pm_objDR.IsNull("ID_LOAI_HANH_DONG");
	}

	public void SetID_LOAI_HANH_DONGNull() {
		pm_objDR["ID_LOAI_HANH_DONG"] = System.Convert.DBNull;
	}

	public string strLOAI_HANH_DONG 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "LOAI_HANH_DONG", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["LOAI_HANH_DONG"] = value;
		}
	}

	public bool IsLOAI_HANH_DONGNull() 
	{
		return pm_objDR.IsNull("LOAI_HANH_DONG");
	}

	public void SetLOAI_HANH_DONGNull() {
		pm_objDR["LOAI_HANH_DONG"] = System.Convert.DBNull;
	}

	public string strDOI_TUONG_THAO_TAC 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "DOI_TUONG_THAO_TAC", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["DOI_TUONG_THAO_TAC"] = value;
		}
	}

	public bool IsDOI_TUONG_THAO_TACNull() 
	{
		return pm_objDR.IsNull("DOI_TUONG_THAO_TAC");
	}

	public void SetDOI_TUONG_THAO_TACNull() {
		pm_objDR["DOI_TUONG_THAO_TAC"] = System.Convert.DBNull;
	}

	public string strMO_TA 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MO_TA", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MO_TA"] = value;
		}
	}

	public bool IsMO_TANull() 
	{
		return pm_objDR.IsNull("MO_TA");
	}

	public void SetMO_TANull() {
		pm_objDR["MO_TA"] = System.Convert.DBNull;
	}

	public string strGHI_CHU 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "GHI_CHU", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["GHI_CHU"] = value;
		}
	}

	public bool IsGHI_CHUNull() 
	{
		return pm_objDR.IsNull("GHI_CHU");
	}

	public void SetGHI_CHUNull() {
		pm_objDR["GHI_CHU"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_V_HT_LOG_TRUY_CAP() 
	{
		pm_objDS = new DS_V_HT_LOG_TRUY_CAP();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_HT_LOG_TRUY_CAP(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_HT_LOG_TRUY_CAP(decimal i_dbID) 
	{
		pm_objDS = new DS_V_HT_LOG_TRUY_CAP();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion

    #region Additional Functions
    public void fill_data_bo_loc(DS_V_HT_LOG_TRUY_CAP op_ds_ht_log_truy_cap
                                , string ip_str_username
                                , DateTime ip_dat_tu_ngay
                                , DateTime ip_dat_den_ngay
                                , decimal ip_dc_id_hanh_dong)
    {
        CStoredProc v_cstore = new CStoredProc("pr_V_HT_LOG_TRUY_CAP_filter");
        v_cstore.addNVarcharInputParam("@USERNAME", ip_str_username);
        v_cstore.addDatetimeInputParam("@TU_NGAY", ip_dat_tu_ngay);
        v_cstore.addDatetimeInputParam("@DEN_NGAY", ip_dat_den_ngay);
        v_cstore.addDecimalInputParam("@ID_LOAI_HANH_DONG", ip_dc_id_hanh_dong);
        v_cstore.fillDataSetByCommand(this, op_ds_ht_log_truy_cap);
    }
    #endregion
}
}
