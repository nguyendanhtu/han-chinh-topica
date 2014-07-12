///************************************************
/// Generated by: TuNA
/// Date: 27-06-2014 05:41:54
/// Goal: Create User Service Class for V_DINH_MUC_CPN_TUNG_PHONG_BAN
///************************************************
/// <summary>
/// Create User Service Class for V_DINH_MUC_CPN_TUNG_PHONG_BAN
/// </summary>

using System;
using BCTKDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BCTKUS{

public class US_V_DINH_MUC_CPN_TUNG_PHONG_BAN : US_Object
{
	private const string c_TableName = "V_DINH_MUC_CPN_TUNG_PHONG_BAN";
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

	public decimal dcDINH_MUC_GAN_NHAT 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "DINH_MUC_GAN_NHAT", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["DINH_MUC_GAN_NHAT"] = value;
		}
	}

	public bool IsDINH_MUC_GAN_NHATNull()	{
		return pm_objDR.IsNull("DINH_MUC_GAN_NHAT");
	}

	public void SetDINH_MUC_GAN_NHATNull() {
		pm_objDR["DINH_MUC_GAN_NHAT"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
    public void FillDatasetSearch(DS_V_DINH_MUC_CPN_TUNG_PHONG_BAN op_ds_bc_da, string i_str_tu_khoa, DateTime i_dat_tu_ngay)
    {
        CStoredProc v_sp = new CStoredProc("pr_V_DINH_MUC_CPN_TUNG_PHONG_BAN_TAI_NGAY_Search");
        v_sp.addNVarcharInputParam("@STR_SEARCH", i_str_tu_khoa);
        v_sp.addDatetimeInputParam("@TAI_NGAY", i_dat_tu_ngay);
        v_sp.fillDataSetByCommand(this, op_ds_bc_da);
    }
	public US_V_DINH_MUC_CPN_TUNG_PHONG_BAN() 
	{
		pm_objDS = new DS_V_DINH_MUC_CPN_TUNG_PHONG_BAN();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_DINH_MUC_CPN_TUNG_PHONG_BAN(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_DINH_MUC_CPN_TUNG_PHONG_BAN(decimal i_dbID) 
	{
		pm_objDS = new DS_V_DINH_MUC_CPN_TUNG_PHONG_BAN();
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