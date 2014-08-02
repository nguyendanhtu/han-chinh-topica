///************************************************
/// Generated by: HuyTD
/// Date: 02/08/2014 07:04:07
/// Goal: Create User Service Class for GD_DON_DAT_HANG_DETAIL
///************************************************
/// <summary>
/// Create User Service Class for GD_DON_DAT_HANG_DETAIL
/// </summary>

using System;
using BCTKDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BCTKUS{

public class US_GD_DON_DAT_HANG_DETAIL : US_Object
{
	private const string c_TableName = "GD_DON_DAT_HANG_DETAIL";
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

	public decimal dcID_DON_DAT_HANG 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_DON_DAT_HANG", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_DON_DAT_HANG"] = value;
		}
	}

	public bool IsID_DON_DAT_HANGNull()	{
		return pm_objDR.IsNull("ID_DON_DAT_HANG");
	}

	public void SetID_DON_DAT_HANGNull() {
		pm_objDR["ID_DON_DAT_HANG"] = System.Convert.DBNull;
	}

	public decimal dcID_TRANG_THAI_HANG 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_TRANG_THAI_HANG", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_TRANG_THAI_HANG"] = value;
		}
	}

	public bool IsID_TRANG_THAI_HANGNull()	{
		return pm_objDR.IsNull("ID_TRANG_THAI_HANG");
	}

	public void SetID_TRANG_THAI_HANGNull() {
		pm_objDR["ID_TRANG_THAI_HANG"] = System.Convert.DBNull;
	}

	public decimal dcDON_GIA_CHUA_VAT 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "DON_GIA_CHUA_VAT", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["DON_GIA_CHUA_VAT"] = value;
		}
	}

	public bool IsDON_GIA_CHUA_VATNull()	{
		return pm_objDR.IsNull("DON_GIA_CHUA_VAT");
	}

	public void SetDON_GIA_CHUA_VATNull() {
		pm_objDR["DON_GIA_CHUA_VAT"] = System.Convert.DBNull;
	}

	public decimal dcDON_GIA_GOM_VAT 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "DON_GIA_GOM_VAT", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["DON_GIA_GOM_VAT"] = value;
		}
	}

	public bool IsDON_GIA_GOM_VATNull()	{
		return pm_objDR.IsNull("DON_GIA_GOM_VAT");
	}

	public void SetDON_GIA_GOM_VATNull() {
		pm_objDR["DON_GIA_GOM_VAT"] = System.Convert.DBNull;
	}

	public decimal dcSO_LUONG 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "SO_LUONG", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["SO_LUONG"] = value;
		}
	}

	public bool IsSO_LUONGNull()	{
		return pm_objDR.IsNull("SO_LUONG");
	}

	public void SetSO_LUONGNull() {
		pm_objDR["SO_LUONG"] = System.Convert.DBNull;
	}

	public decimal dcID_VPP 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_VPP", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_VPP"] = value;
		}
	}

	public bool IsID_VPPNull()	{
		return pm_objDR.IsNull("ID_VPP");
	}

	public void SetID_VPPNull() {
		pm_objDR["ID_VPP"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_GD_DON_DAT_HANG_DETAIL() 
	{
		pm_objDS = new DS_GD_DON_DAT_HANG_DETAIL();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_GD_DON_DAT_HANG_DETAIL(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_GD_DON_DAT_HANG_DETAIL(decimal i_dbID) 
	{
		pm_objDS = new DS_GD_DON_DAT_HANG_DETAIL();
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
