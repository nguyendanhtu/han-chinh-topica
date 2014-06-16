///************************************************
/// Generated by: uyvq
/// Date: 08/09/2012 09:37:19
/// Goal: Create User Service Class for UT_SEQUENCES
///************************************************
/// <summary>
/// Create User Service Class for UT_SEQUENCES
/// </summary>


using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using System;
using BCTKDS;
namespace BCTKUS
{

public class US_UT_SEQUENCES : US_Object
{
	private const string c_TableName = "UT_SEQUENCES";
#region "Public Properties"
	public string strSEQ_NAME 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "SEQ_NAME", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["SEQ_NAME"] = value;
		}
	}

	public bool IsSEQ_NAMENull() 
	{
		return pm_objDR.IsNull("SEQ_NAME");
	}

	public void SetSEQ_NAMENull() {
		pm_objDR["SEQ_NAME"] = System.Convert.DBNull;
	}

	public decimal dcSEQ_VALUE 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "SEQ_VALUE", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["SEQ_VALUE"] = value;
		}
	}

	public bool IsSEQ_VALUENull()	{
		return pm_objDR.IsNull("SEQ_VALUE");
	}

	public void SetSEQ_VALUENull() {
		pm_objDR["SEQ_VALUE"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_UT_SEQUENCES() 
	{
		pm_objDS = new DS_UT_SEQUENCES();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_UT_SEQUENCES(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_UT_SEQUENCES(decimal i_dbID) 
	{
		pm_objDS = new DS_UT_SEQUENCES();
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
