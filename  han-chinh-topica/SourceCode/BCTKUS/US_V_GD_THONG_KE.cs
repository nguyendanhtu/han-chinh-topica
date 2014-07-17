///************************************************
/// Generated by: DungNT
/// Date: 16/07/2014 04:39:31
/// Goal: Create User Service Class for V_GD_THONG_KE
///************************************************
/// <summary>
/// Create User Service Class for V_GD_THONG_KE
/// </summary>

using System;
using BCTKDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BCTKUS{

public class US_V_GD_THONG_KE : US_Object
{
	private const string c_TableName = "V_GD_THONG_KE";
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

	public decimal dcID_CO_SO_DINH_MUC 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_CO_SO_DINH_MUC", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_CO_SO_DINH_MUC"] = value;
		}
	}

	public bool IsID_CO_SO_DINH_MUCNull()	{
		return pm_objDR.IsNull("ID_CO_SO_DINH_MUC");
	}

	public void SetID_CO_SO_DINH_MUCNull() {
		pm_objDR["ID_CO_SO_DINH_MUC"] = System.Convert.DBNull;
	}

	public string strTEN_CO_SO_DINH_MUC 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_CO_SO_DINH_MUC", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_CO_SO_DINH_MUC"] = value;
		}
	}

	public bool IsTEN_CO_SO_DINH_MUCNull() 
	{
		return pm_objDR.IsNull("TEN_CO_SO_DINH_MUC");
	}

	public void SetTEN_CO_SO_DINH_MUCNull() {
		pm_objDR["TEN_CO_SO_DINH_MUC"] = System.Convert.DBNull;
	}

	public string strTEN_THONG_KE 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_THONG_KE", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_THONG_KE"] = value;
		}
	}

	public bool IsTEN_THONG_KENull() 
	{
		return pm_objDR.IsNull("TEN_THONG_KE");
	}

	public void SetTEN_THONG_KENull() {
		pm_objDR["TEN_THONG_KE"] = System.Convert.DBNull;
	}

	public decimal dcID_LOAI_THOI_GIAN 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_THOI_GIAN", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_LOAI_THOI_GIAN"] = value;
		}
	}

	public bool IsID_LOAI_THOI_GIANNull()	{
		return pm_objDR.IsNull("ID_LOAI_THOI_GIAN");
	}

	public void SetID_LOAI_THOI_GIANNull() {
		pm_objDR["ID_LOAI_THOI_GIAN"] = System.Convert.DBNull;
	}

	public string strTEN_NGAN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_NGAN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_NGAN"] = value;
		}
	}

	public bool IsTEN_NGANNull() 
	{
		return pm_objDR.IsNull("TEN_NGAN");
	}

	public void SetTEN_NGANNull() {
		pm_objDR["TEN_NGAN"] = System.Convert.DBNull;
	}

	public DateTime datTU_NGAY
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "TU_NGAY", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["TU_NGAY"] = value;
		}
	}

	public bool IsTU_NGAYNull()
	{
		return pm_objDR.IsNull("TU_NGAY");
	}

	public void SetTU_NGAYNull()
	{
		pm_objDR["TU_NGAY"] = System.Convert.DBNull;
	}

	public DateTime datDEN_NGAY
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "DEN_NGAY", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["DEN_NGAY"] = value;
		}
	}

	public bool IsDEN_NGAYNull()
	{
		return pm_objDR.IsNull("DEN_NGAY");
	}

	public void SetDEN_NGAYNull()
	{
		pm_objDR["DEN_NGAY"] = System.Convert.DBNull;
	}

	public decimal dcGIA_TRI_THONG_KE 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "GIA_TRI_THONG_KE", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["GIA_TRI_THONG_KE"] = value;
		}
	}

	public bool IsGIA_TRI_THONG_KENull()	{
		return pm_objDR.IsNull("GIA_TRI_THONG_KE");
	}

	public void SetGIA_TRI_THONG_KENull() {
		pm_objDR["GIA_TRI_THONG_KE"] = System.Convert.DBNull;
	}

	public decimal dcID_DON_VI_THONG_KE 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_DON_VI_THONG_KE", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_DON_VI_THONG_KE"] = value;
		}
	}

	public bool IsID_DON_VI_THONG_KENull()	{
		return pm_objDR.IsNull("ID_DON_VI_THONG_KE");
	}

	public void SetID_DON_VI_THONG_KENull() {
		pm_objDR["ID_DON_VI_THONG_KE"] = System.Convert.DBNull;
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

	public decimal dcID_DM_CO_SO 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_DM_CO_SO", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_DM_CO_SO"] = value;
		}
	}

	public bool IsID_DM_CO_SONull()	{
		return pm_objDR.IsNull("ID_DM_CO_SO");
	}

	public void SetID_DM_CO_SONull() {
		pm_objDR["ID_DM_CO_SO"] = System.Convert.DBNull;
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

	public string strGHI_CHU_1 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "GHI_CHU_1", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["GHI_CHU_1"] = value;
		}
	}

	public bool IsGHI_CHU_1Null() 
	{
		return pm_objDR.IsNull("GHI_CHU_1");
	}

	public void SetGHI_CHU_1Null() {
		pm_objDR["GHI_CHU_1"] = System.Convert.DBNull;
	}

	public string strGHI_CHU_2 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "GHI_CHU_2", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["GHI_CHU_2"] = value;
		}
	}

	public bool IsGHI_CHU_2Null() 
	{
		return pm_objDR.IsNull("GHI_CHU_2");
	}

	public void SetGHI_CHU_2Null() {
		pm_objDR["GHI_CHU_2"] = System.Convert.DBNull;
	}

	public string strGHI_CHU_3 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "GHI_CHU_3", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["GHI_CHU_3"] = value;
		}
	}

	public bool IsGHI_CHU_3Null() 
	{
		return pm_objDR.IsNull("GHI_CHU_3");
	}

	public void SetGHI_CHU_3Null() {
		pm_objDR["GHI_CHU_3"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_V_GD_THONG_KE() 
	{
		pm_objDS = new DS_V_GD_THONG_KE();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_GD_THONG_KE(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_GD_THONG_KE(decimal i_dbID) 
	{
		pm_objDS = new DS_V_GD_THONG_KE();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion
    public void FillDatasetSearch(DS_V_GD_THONG_KE ip_m_ds, decimal ip_dc_id_co_so_dinh_muc,string ip_v_str_tim_kiem,DateTime ip_dat_tu_ngay,DateTime ip_dat_den_ngay)
    {
        CStoredProc v_stored_proc = new CStoredProc("pr_V_GD_THONG_KE_Search");
        v_stored_proc.addNVarcharInputParam("@TU_KHOA", ip_v_str_tim_kiem);
        v_stored_proc.addDecimalInputParam("@ID_CO_SO_DM",ip_dc_id_co_so_dinh_muc);
        v_stored_proc.addDatetimeInputParam("@TU_NGAY", ip_dat_tu_ngay);
        v_stored_proc.addDatetimeInputParam("@DEN_NGAY", ip_dat_den_ngay);
        v_stored_proc.fillDataSetByCommand(this, ip_m_ds);
    }
	}
}
