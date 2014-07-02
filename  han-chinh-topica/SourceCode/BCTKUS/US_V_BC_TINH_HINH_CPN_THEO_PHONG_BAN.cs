///************************************************
/// Generated by: TuNA
/// Date: 02-07-2014 10:26:49
/// Goal: Create User Service Class for V_BC_TINH_HINH_CPN_THEO_PHONG_BAN
///************************************************
/// <summary>
/// Create User Service Class for V_BC_TINH_HINH_CPN_THEO_PHONG_BAN
/// </summary>

using System;
using BCTKDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BCTKUS{

public class US_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN : US_Object
{
	private const string c_TableName = "V_BC_TINH_HINH_CPN_THEO_PHONG_BAN";
#region "Public Properties"
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

	public decimal dcTONG_SO_BILL 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "TONG_SO_BILL", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["TONG_SO_BILL"] = value;
		}
	}

	public bool IsTONG_SO_BILLNull()	{
		return pm_objDR.IsNull("TONG_SO_BILL");
	}

	public void SetTONG_SO_BILLNull() {
		pm_objDR["TONG_SO_BILL"] = System.Convert.DBNull;
	}

	public decimal dcTONG_SO_TIEN 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "TONG_SO_TIEN", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["TONG_SO_TIEN"] = value;
		}
	}

	public bool IsTONG_SO_TIENNull()	{
		return pm_objDR.IsNull("TONG_SO_TIEN");
	}

	public void SetTONG_SO_TIENNull() {
		pm_objDR["TONG_SO_TIEN"] = System.Convert.DBNull;
	}

	public decimal dcDINH_MUC 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "DINH_MUC", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["DINH_MUC"] = value;
		}
	}

	public bool IsDINH_MUCNull()	{
		return pm_objDR.IsNull("DINH_MUC");
	}

	public void SetDINH_MUCNull() {
		pm_objDR["DINH_MUC"] = System.Convert.DBNull;
	}

	public decimal dcTI_LE_DA_VUOT 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "TI_LE_DA_VUOT", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["TI_LE_DA_VUOT"] = value;
		}
	}

	public bool IsTI_LE_DA_VUOTNull()	{
		return pm_objDR.IsNull("TI_LE_DA_VUOT");
	}

	public void SetTI_LE_DA_VUOTNull() {
		pm_objDR["TI_LE_DA_VUOT"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN() 
	{
		pm_objDS = new DS_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN(decimal i_dbID) 
	{
		pm_objDS = new DS_V_BC_TINH_HINH_CPN_THEO_PHONG_BAN();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion
	}
}
