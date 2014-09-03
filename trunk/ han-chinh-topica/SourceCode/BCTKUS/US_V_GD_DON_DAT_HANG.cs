///************************************************
/// Generated by: DungNT
/// Date: 12/08/2014 03:52:39
/// Goal: Create User Service Class for V_GD_DON_DAT_HANG
///************************************************
/// <summary>
/// Create User Service Class for V_GD_DON_DAT_HANG
/// </summary>

using System;
using BCTKDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BCTKUS{

public class US_V_GD_DON_DAT_HANG : US_Object
{
	private const string c_TableName = "V_GD_DON_DAT_HANG";
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

	public string strTRANG_THAI 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TRANG_THAI", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TRANG_THAI"] = value;
		}
	}

	public bool IsTRANG_THAINull() 
	{
		return pm_objDR.IsNull("TRANG_THAI");
	}

	public void SetTRANG_THAINull() {
		pm_objDR["TRANG_THAI"] = System.Convert.DBNull;
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

	public string strMA_HD 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_HD", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_HD"] = value;
		}
	}

	public bool IsMA_HDNull() 
	{
		return pm_objDR.IsNull("MA_HD");
	}

	public void SetMA_HDNull() {
		pm_objDR["MA_HD"] = System.Convert.DBNull;
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

    public void SetMA_HD_NCCNull()
    {
        pm_objDR["MA_HD_NCC"] = System.Convert.DBNull;
    }

#endregion
#region "Init Functions"
	public US_V_GD_DON_DAT_HANG() 
	{
		pm_objDS = new DS_V_GD_DON_DAT_HANG();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_GD_DON_DAT_HANG(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_GD_DON_DAT_HANG(decimal i_dbID) 
	{
		pm_objDS = new DS_V_GD_DON_DAT_HANG();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion

    public void FillDatasetSearch(DS_V_GD_DON_DAT_HANG ip_ds, DateTime ip_dat_thang, decimal ip_dc_id_trung_tam,decimal ip_id_trang_thai )
    {
        CStoredProc v_stored_proc = new CStoredProc("pr_V_GD_DON_DAT_HANG_Search");
        v_stored_proc.addDecimalInputParam("@ID_PHONG_BAN", ip_dc_id_trung_tam);
        v_stored_proc.addDatetimeInputParam("@NGAY", ip_dat_thang);
        v_stored_proc.addDecimalInputParam("@ID_TRANG_THAI", ip_id_trang_thai);
        v_stored_proc.fillDataSetByCommand(this, ip_ds);
    }
}
}
