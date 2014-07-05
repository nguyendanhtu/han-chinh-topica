///************************************************
/// Generated by: TuNA
/// Date: 04-07-2014 03:37:10
/// Goal: Create User Service Class for V_BC_CHI_TIET_DM
///************************************************
/// <summary>
/// Create User Service Class for V_BC_CHI_TIET_DM
/// </summary>

using System;
using BCTKDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BCTKUS{

public class US_V_BC_CHI_TIET_DM : US_Object
{
	private const string c_TableName = "V_BC_CHI_TIET_DM";
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

	public decimal dcID_LOAI_THONG_KE 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_THONG_KE", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_LOAI_THONG_KE"] = value;
		}
	}

	public bool IsID_LOAI_THONG_KENull()	{
		return pm_objDR.IsNull("ID_LOAI_THONG_KE");
	}

	public void SetID_LOAI_THONG_KENull() {
		pm_objDR["ID_LOAI_THONG_KE"] = System.Convert.DBNull;
	}

	public string strLOAI_TK 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "LOAI_TK", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["LOAI_TK"] = value;
		}
	}

	public bool IsLOAI_TKNull() 
	{
		return pm_objDR.IsNull("LOAI_TK");
	}

	public void SetLOAI_TKNull() {
		pm_objDR["LOAI_TK"] = System.Convert.DBNull;
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

	public string strLOAI_THOI_GIAN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "LOAI_THOI_GIAN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["LOAI_THOI_GIAN"] = value;
		}
	}

	public bool IsLOAI_THOI_GIANNull() 
	{
		return pm_objDR.IsNull("LOAI_THOI_GIAN");
	}

	public void SetLOAI_THOI_GIANNull() {
		pm_objDR["LOAI_THOI_GIAN"] = System.Convert.DBNull;
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

	public decimal dcDON_GIA 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "DON_GIA", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["DON_GIA"] = value;
		}
	}

	public bool IsDON_GIANull()	{
		return pm_objDR.IsNull("DON_GIA");
	}

	public void SetDON_GIANull() {
		pm_objDR["DON_GIA"] = System.Convert.DBNull;
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

#endregion
#region "Init Functions"
    public void FillDataset_chi_tiet_dm(DS_V_BC_CHI_TIET_DM ip_v_ds, decimal ip_v_id_phong_ban, DateTime ip_v_dt_tu_ngay, DateTime ip_v_dt_den_ngay)
    {
        CStoredProc v_stored_proc = new CStoredProc("pr_V_BC_CHI_TIET_DM_search");
        v_stored_proc.addNVarcharInputParam("@ID_PHONG_BAN", ip_v_id_phong_ban);
        v_stored_proc.addDatetimeInputParam("@TU_NGAY", ip_v_dt_tu_ngay);
        v_stored_proc.addDatetimeInputParam("@DEN_NGAY", ip_v_dt_den_ngay);

        v_stored_proc.fillDataSetByCommand(this, ip_v_ds);
    }
	public US_V_BC_CHI_TIET_DM() 
	{
		pm_objDS = new DS_V_BC_CHI_TIET_DM();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_BC_CHI_TIET_DM(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_BC_CHI_TIET_DM(decimal i_dbID) 
	{
		pm_objDS = new DS_V_BC_CHI_TIET_DM();
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
