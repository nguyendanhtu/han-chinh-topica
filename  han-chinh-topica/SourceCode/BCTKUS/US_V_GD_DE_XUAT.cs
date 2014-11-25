///************************************************
/// Generated by: HuyTD
/// Date: 31/10/2014 07:39:32
/// Goal: Create User Service Class for V_GD_DE_XUAT
///************************************************
/// <summary>
/// Create User Service Class for V_GD_DE_XUAT
/// </summary>

using System;
using BCTKDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BCTKUS{

public class US_V_GD_DE_XUAT : US_Object
{
	private const string c_TableName = "V_GD_DE_XUAT";
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

	public DateTime datTHANG_AP_DUNG
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "THANG_AP_DUNG", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["THANG_AP_DUNG"] = value;
		}
	}

	public bool IsTHANG_AP_DUNGNull()
	{
		return pm_objDR.IsNull("THANG_AP_DUNG");
	}

	public void SetTHANG_AP_DUNGNull()
	{
		pm_objDR["THANG_AP_DUNG"] = System.Convert.DBNull;
	}

	public decimal dcSO_TIEN 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "SO_TIEN", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["SO_TIEN"] = value;
		}
	}

	public bool IsSO_TIENNull()	{
		return pm_objDR.IsNull("SO_TIEN");
	}

	public void SetSO_TIENNull() {
		pm_objDR["SO_TIEN"] = System.Convert.DBNull;
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

	public string strLOAI_DE_XUAT 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "LOAI_DE_XUAT", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["LOAI_DE_XUAT"] = value;
		}
	}

	public bool IsLOAI_DE_XUATNull() 
	{
		return pm_objDR.IsNull("LOAI_DE_XUAT");
	}

	public void SetLOAI_DE_XUATNull() {
		pm_objDR["LOAI_DE_XUAT"] = System.Convert.DBNull;
	}
    public string strLINK
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "LINK", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["LINK"] = value;
        }
    }

    public bool IsLINKNull()
    {
        return pm_objDR.IsNull("LINK");
    }

    public void SetLINKNull()
    {
        pm_objDR["LINK"] = System.Convert.DBNull;
    }
#endregion
#region "Init Functions"
	public US_V_GD_DE_XUAT() 
	{
		pm_objDS = new DS_V_GD_DE_XUAT();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_GD_DE_XUAT(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_GD_DE_XUAT(decimal i_dbID) 
	{
		pm_objDS = new DS_V_GD_DE_XUAT();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion
    public void FillDatasetSearch(DS_V_GD_DE_XUAT ip_ds, DateTime ip_dat_thang, decimal ip_dc_id_phap_nhan, decimal ip_dc_id_trung_tam, decimal ip_dc_id_de_xuat)
    {
        CStoredProc v_store_proc = new CStoredProc("pr_V_GD_DE_XUAT_Search");
        v_store_proc.addDatetimeInputParam("@THANG", ip_dat_thang);
        v_store_proc.addDecimalInputParam("@ID_PHONG_BAN", ip_dc_id_trung_tam);
        v_store_proc.addDecimalInputParam("@ID_PHAP_NHAN", ip_dc_id_phap_nhan);
        v_store_proc.addDecimalInputParam("@ID_DE_XUAT", ip_dc_id_de_xuat);
        v_store_proc.fillDataSetByCommand(this, ip_ds);
    }

    public void FillDSLayDeXuat(DS_V_GD_DE_XUAT v_ds_de_xuat, DateTime v_dat_ngay, decimal v_id_phong_ban)
    {
        CStoredProc v_strore_proc = new CStoredProc("pr_get_de_xuat_trung_tam");
        v_strore_proc.addDatetimeInputParam("@NGAY_DAT_HANG", v_dat_ngay);
        v_strore_proc.addDecimalInputParam("@ID_TRUNG_TAM", v_id_phong_ban);
        v_strore_proc.fillDataSetByCommand(this,v_ds_de_xuat);
    }
}
}
