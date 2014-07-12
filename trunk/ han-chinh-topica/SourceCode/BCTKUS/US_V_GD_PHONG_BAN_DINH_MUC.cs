///************************************************
/// Generated by: HuyTD
/// Date: 12/07/2014 12:12:55
/// Goal: Create User Service Class for V_GD_PHONG_BAN_DINH_MUC
///************************************************
/// <summary>
/// Create User Service Class for V_GD_PHONG_BAN_DINH_MUC
/// </summary>

using System;
using BCTKDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BCTKUS{

public class US_V_GD_PHONG_BAN_DINH_MUC : US_Object
{
	private const string c_TableName = "V_GD_PHONG_BAN_DINH_MUC";
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

	public decimal dcID_LOAI_DINH_MUC 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_DINH_MUC", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_LOAI_DINH_MUC"] = value;
		}
	}

	public bool IsID_LOAI_DINH_MUCNull()	{
		return pm_objDR.IsNull("ID_LOAI_DINH_MUC");
	}

	public void SetID_LOAI_DINH_MUCNull() {
		pm_objDR["ID_LOAI_DINH_MUC"] = System.Convert.DBNull;
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

	public string strMA_CO_SO_DINH_MUC 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_CO_SO_DINH_MUC", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_CO_SO_DINH_MUC"] = value;
		}
	}

	public bool IsMA_CO_SO_DINH_MUCNull() 
	{
		return pm_objDR.IsNull("MA_CO_SO_DINH_MUC");
	}

	public void SetMA_CO_SO_DINH_MUCNull() {
		pm_objDR["MA_CO_SO_DINH_MUC"] = System.Convert.DBNull;
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

	public decimal dcID_LOAI_CO_SO_DINH_MUC 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_CO_SO_DINH_MUC", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_LOAI_CO_SO_DINH_MUC"] = value;
		}
	}

	public bool IsID_LOAI_CO_SO_DINH_MUCNull()	{
		return pm_objDR.IsNull("ID_LOAI_CO_SO_DINH_MUC");
	}

	public void SetID_LOAI_CO_SO_DINH_MUCNull() {
		pm_objDR["ID_LOAI_CO_SO_DINH_MUC"] = System.Convert.DBNull;
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

	public decimal dcID_LOAI_CO_SO 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_CO_SO", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_LOAI_CO_SO"] = value;
		}
	}

	public bool IsID_LOAI_CO_SONull()	{
		return pm_objDR.IsNull("ID_LOAI_CO_SO");
	}

	public void SetID_LOAI_CO_SONull() {
		pm_objDR["ID_LOAI_CO_SO"] = System.Convert.DBNull;
	}

	public string strMA_PHONG_BAN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_PHONG_BAN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_PHONG_BAN"] = value;
		}
	}

	public bool IsMA_PHONG_BANNull() 
	{
		return pm_objDR.IsNull("MA_PHONG_BAN");
	}

	public void SetMA_PHONG_BANNull() {
		pm_objDR["MA_PHONG_BAN"] = System.Convert.DBNull;
	}

	public string strTEN_PHONG_BAN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_PHONG_BAN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_PHONG_BAN"] = value;
		}
	}

	public bool IsTEN_PHONG_BANNull() 
	{
		return pm_objDR.IsNull("TEN_PHONG_BAN");
	}

	public void SetTEN_PHONG_BANNull() {
		pm_objDR["TEN_PHONG_BAN"] = System.Convert.DBNull;
	}

	public string strTEN_LOAI_CO_SO 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_LOAI_CO_SO", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_LOAI_CO_SO"] = value;
		}
	}

	public bool IsTEN_LOAI_CO_SONull() 
	{
		return pm_objDR.IsNull("TEN_LOAI_CO_SO");
	}

	public void SetTEN_LOAI_CO_SONull() {
		pm_objDR["TEN_LOAI_CO_SO"] = System.Convert.DBNull;
	}

	public string strTEN_LOAI_DINH_MUC 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_LOAI_DINH_MUC", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_LOAI_DINH_MUC"] = value;
		}
	}

	public bool IsTEN_LOAI_DINH_MUCNull() 
	{
		return pm_objDR.IsNull("TEN_LOAI_DINH_MUC");
	}

	public void SetTEN_LOAI_DINH_MUCNull() {
		pm_objDR["TEN_LOAI_DINH_MUC"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_V_GD_PHONG_BAN_DINH_MUC() 
	{
		pm_objDS = new DS_V_GD_PHONG_BAN_DINH_MUC();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_GD_PHONG_BAN_DINH_MUC(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_GD_PHONG_BAN_DINH_MUC(decimal i_dbID) 
	{
		pm_objDS = new DS_V_GD_PHONG_BAN_DINH_MUC();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion

    public void FillDataset(DS_V_GD_PHONG_BAN_DINH_MUC ip_m_ds, decimal ip_v_dc_id_trung_tam, decimal ip_v_dc_id_loai_dm, string ip_v_str_tim_kiem)
    {
        CStoredProc v_stored_proc = new CStoredProc("pr_V_GD_PHONG_BAN_DINH_MUC_Search");
        v_stored_proc.addNVarcharInputParam("@TU_KHOA",ip_v_str_tim_kiem);
        v_stored_proc.addDecimalInputParam("@ID_PHONG_BAN", ip_v_dc_id_trung_tam);
        v_stored_proc.addDecimalInputParam("@ID_LOAI_DM", ip_v_dc_id_loai_dm);
        v_stored_proc.fillDataSetByCommand(this, ip_m_ds);
    }
}
}
