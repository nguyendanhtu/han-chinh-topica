///************************************************
/// Generated by: HuyTD
/// Date: 13/07/2014 02:34:19
/// Goal: Create User Service Class for V_DM_PHONG_BAN_PHAP_NHAN
///************************************************
/// <summary>
/// Create User Service Class for V_DM_PHONG_BAN_PHAP_NHAN
/// </summary>

using System;
using BCTKDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BCTKUS{

public class US_V_DM_PHONG_BAN_PHAP_NHAN : US_Object
{
	private const string c_TableName = "V_DM_PHONG_BAN_PHAP_NHAN";
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

	public decimal dcID_PHAP_NHAN 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_PHAP_NHAN", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_PHAP_NHAN"] = value;
		}
	}

	public bool IsID_PHAP_NHANNull()	{
		return pm_objDR.IsNull("ID_PHAP_NHAN");
	}

	public void SetID_PHAP_NHANNull() {
		pm_objDR["ID_PHAP_NHAN"] = System.Convert.DBNull;
	}

	public decimal dcTY_TRONG 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "TY_TRONG", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["TY_TRONG"] = value;
		}
	}

	public bool IsTY_TRONGNull()	{
		return pm_objDR.IsNull("TY_TRONG");
	}

	public void SetTY_TRONGNull() {
		pm_objDR["TY_TRONG"] = System.Convert.DBNull;
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

	public string strMA_PHAP_NHAN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_PHAP_NHAN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_PHAP_NHAN"] = value;
		}
	}

	public bool IsMA_PHAP_NHANNull() 
	{
		return pm_objDR.IsNull("MA_PHAP_NHAN");
	}

	public void SetMA_PHAP_NHANNull() {
		pm_objDR["MA_PHAP_NHAN"] = System.Convert.DBNull;
	}

	public string strTEN_PHAP_NHAN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_PHAP_NHAN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_PHAP_NHAN"] = value;
		}
	}

	public bool IsTEN_PHAP_NHANNull() 
	{
		return pm_objDR.IsNull("TEN_PHAP_NHAN");
	}

	public void SetTEN_PHAP_NHANNull() {
		pm_objDR["TEN_PHAP_NHAN"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_V_DM_PHONG_BAN_PHAP_NHAN() 
	{
		pm_objDS = new DS_V_DM_PHONG_BAN_PHAP_NHAN();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_DM_PHONG_BAN_PHAP_NHAN(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_DM_PHONG_BAN_PHAP_NHAN(decimal i_dbID) 
	{
		pm_objDS = new DS_V_DM_PHONG_BAN_PHAP_NHAN();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion

    public void FillDataset(DS_V_DM_PHONG_BAN_PHAP_NHAN ip_m_ds, decimal ip_v_id_phap_nhan, string ip_v_str_tu_khoa, decimal ip_v_id_trung_tam)
    {
        CStoredProc v_stored_proc = new CStoredProc("pr_V_GD_PHONG_BAN_PHAP_NHAN_Search");
        v_stored_proc.addNVarcharInputParam("@TU_KHOA", ip_v_str_tu_khoa);
        v_stored_proc.addDecimalInputParam("@ID_PHAP_NHAN", ip_v_id_phap_nhan);
        v_stored_proc.addDecimalInputParam("@ID_PHONG_BAN", ip_v_id_phap_nhan);
        v_stored_proc.fillDataSetByCommand(this, ip_m_ds);
    }
}
}
