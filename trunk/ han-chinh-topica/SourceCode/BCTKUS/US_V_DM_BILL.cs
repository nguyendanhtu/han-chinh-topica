///************************************************
/// Generated by: TuyenNT
/// Date: 25/06/2014 05:53:26
/// Goal: Create User Service Class for V_DM_BILL
///************************************************
/// <summary>
/// Create User Service Class for V_DM_BILL
/// </summary>

using System;
using BCTKDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BCTKUS{

public class US_V_DM_BILL : US_Object
{
	private const string c_TableName = "V_DM_BILL";
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

    public bool IsIDNull()
    {
        return pm_objDR.IsNull("ID");
    }

    public void SetIDNull()
    {
        pm_objDR["ID"] = System.Convert.DBNull;
    }

    public DateTime datNGAY_GUI
    {
        get
        {
            return CNull.RowNVLDate(pm_objDR, "NGAY_GUI", IPConstants.c_DefaultDate);
        }
        set
        {
            pm_objDR["NGAY_GUI"] = value;
        }
    }

    public bool IsNGAY_GUINull()
    {
        return pm_objDR.IsNull("NGAY_GUI");
    }

    public void SetNGAY_GUINull()
    {
        pm_objDR["NGAY_GUI"] = System.Convert.DBNull;
    }

    public string strSO_BILL
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "SO_BILL", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["SO_BILL"] = value;
        }
    }

    public bool IsSO_BILLNull()
    {
        return pm_objDR.IsNull("SO_BILL");
    }

    public void SetSO_BILLNull()
    {
        pm_objDR["SO_BILL"] = System.Convert.DBNull;
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

    public bool IsID_PHONG_BANNull()
    {
        return pm_objDR.IsNull("ID_PHONG_BAN");
    }

    public void SetID_PHONG_BANNull()
    {
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

    public void SetMA_PHONG_BANNull()
    {
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

    public void SetTEN_PHONG_BANNull()
    {
        pm_objDR["TEN_PHONG_BAN"] = System.Convert.DBNull;
    }

    public string strNGUOI_GUI
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "NGUOI_GUI", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["NGUOI_GUI"] = value;
        }
    }

    public bool IsNGUOI_GUINull()
    {
        return pm_objDR.IsNull("NGUOI_GUI");
    }

    public void SetNGUOI_GUINull()
    {
        pm_objDR["NGUOI_GUI"] = System.Convert.DBNull;
    }

    public string strNGUOI_NHAN
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "NGUOI_NHAN", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["NGUOI_NHAN"] = value;
        }
    }

    public bool IsNGUOI_NHANNull()
    {
        return pm_objDR.IsNull("NGUOI_NHAN");
    }

    public void SetNGUOI_NHANNull()
    {
        pm_objDR["NGUOI_NHAN"] = System.Convert.DBNull;
    }

    public string strNOI_NHAN
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "NOI_NHAN", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["NOI_NHAN"] = value;
        }
    }

    public bool IsNOI_NHANNull()
    {
        return pm_objDR.IsNull("NOI_NHAN");
    }

    public void SetNOI_NHANNull()
    {
        pm_objDR["NOI_NHAN"] = System.Convert.DBNull;
    }

    public string strTRONG_NUOC
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "TRONG_NUOC", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["TRONG_NUOC"] = value;
        }
    }

    public bool IsTRONG_NUOCNull()
    {
        return pm_objDR.IsNull("TRONG_NUOC");
    }

    public void SetTRONG_NUOCNull()
    {
        pm_objDR["TRONG_NUOC"] = System.Convert.DBNull;
    }

    public string strNUOC_NGOAI
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "NUOC_NGOAI", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["NUOC_NGOAI"] = value;
        }
    }

    public bool IsNUOC_NGOAINull()
    {
        return pm_objDR.IsNull("NUOC_NGOAI");
    }

    public void SetNUOC_NGOAINull()
    {
        pm_objDR["NUOC_NGOAI"] = System.Convert.DBNull;
    }

    public string strNOI_DUNG
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "NOI_DUNG", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["NOI_DUNG"] = value;
        }
    }

    public bool IsNOI_DUNGNull()
    {
        return pm_objDR.IsNull("NOI_DUNG");
    }

    public void SetNOI_DUNGNull()
    {
        pm_objDR["NOI_DUNG"] = System.Convert.DBNull;
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

    public void SetGHI_CHUNull()
    {
        pm_objDR["GHI_CHU"] = System.Convert.DBNull;
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

    public bool IsID_TRANG_THAINull()
    {
        return pm_objDR.IsNull("ID_TRANG_THAI");
    }

    public void SetID_TRANG_THAINull()
    {
        pm_objDR["ID_TRANG_THAI"] = System.Convert.DBNull;
    }

    public string strTRANG_THAI_THU
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "TRANG_THAI_THU", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["TRANG_THAI_THU"] = value;
        }
    }

    public bool IsTRANG_THAI_THUNull()
    {
        return pm_objDR.IsNull("TRANG_THAI_THU");
    }

    public void SetTRANG_THAI_THUNull()
    {
        pm_objDR["TRANG_THAI_THU"] = System.Convert.DBNull;
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

    public bool IsSO_TIENNull()
    {
        return pm_objDR.IsNull("SO_TIEN");
    }

    public void SetSO_TIENNull()
    {
        pm_objDR["SO_TIEN"] = System.Convert.DBNull;
    }

    #endregion

#region "Init Functions"
	public US_V_DM_BILL() 
	{
		pm_objDS = new DS_V_DM_BILL();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_DM_BILL(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_DM_BILL(decimal i_dbID) 
	{
		pm_objDS = new DS_V_DM_BILL();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion

    public void FillDatasetSearch(DS_V_DM_BILL ip_ds, decimal ip_dc_id_phong_ban, string ip_str_so_bill, decimal ip_dc_id_trang_thai_cu, DateTime ip_dat_tu_ngay, DateTime ip_dat_den_ngay)
    {
        CStoredProc v_store_proc = new CStoredProc("pr_V_DM_BILL_Search_trang_thai");
        v_store_proc.addDecimalInputParam("@ID_PHONG_BAN", ip_dc_id_phong_ban);
        v_store_proc.addNVarcharInputParam("@SO_BILL", ip_str_so_bill);
        v_store_proc.addDecimalInputParam("@ID_TRANG_THAI", ip_dc_id_trang_thai_cu);
        v_store_proc.addDatetimeInputParam("@TU_NGAY", ip_dat_tu_ngay);
        v_store_proc.addDatetimeInputParam("@DEN_NGAY", ip_dat_den_ngay);
        v_store_proc.fillDataSetByCommand(this, ip_ds);
    }
    public void FillDatasetSearch_grid_ngay(DS_V_DM_BILL ip_ds, DateTime ip_dat_ngay, decimal ip_dc_id_trung_tam, decimal ip_dc_id_trang_thai, string ip_str_key_word)
    {

        CStoredProc v_store_proc = new CStoredProc("pr_V_DM_BILL_Search_phongban_ngay");
        v_store_proc.addNVarcharInputParam("@KEY_WORD", ip_str_key_word);
        v_store_proc.addDecimalInputParam("@ID_TRUNG_TAM", ip_dc_id_trung_tam);
        v_store_proc.addDecimalInputParam("@ID_TRANG_THAI", ip_dc_id_trang_thai);
        v_store_proc.addDatetimeInputParam("@TU_NGAY", ip_dat_ngay);
        v_store_proc.fillDataSetByCommand(this, ip_ds);
    }
    public void FillDatasetSearch_grid(DS_V_DM_BILL ip_ds, decimal ip_dc_id_trung_tam, decimal ip_dc_id_trang_thai, string ip_str_key_word)
    {

        CStoredProc v_store_proc = new CStoredProc("pr_V_DM_BILL_Search_phongban");
        v_store_proc.addNVarcharInputParam("@KEY_WORD", ip_str_key_word);
        v_store_proc.addDecimalInputParam("@ID_TRUNG_TAM", ip_dc_id_trung_tam);
        v_store_proc.addDecimalInputParam("@ID_TRANG_THAI", ip_dc_id_trang_thai);
        v_store_proc.fillDataSetByCommand(this, ip_ds);
    }
    public void FillDatasetSearch_bitralai(DS_V_DM_BILL ip_ds,decimal ip_dc_id_trang_thai, DateTime ip_dat_tu_ngay, DateTime ip_dat_den_ngay)
    {
        CStoredProc v_store_proc = new CStoredProc("pr_V_DM_BILL_Search_trang_thai_tra_lai");
        v_store_proc.addDecimalInputParam("@ID_TRANG_THAI", ip_dc_id_trang_thai);
        v_store_proc.addDatetimeInputParam("@TU_NGAY", ip_dat_tu_ngay);
        v_store_proc.addDatetimeInputParam("@DEN_NGAY", ip_dat_den_ngay);
        v_store_proc.fillDataSetByCommand(this, ip_ds);
    }
    public void FillDatasetSearch_bill(DS_V_DM_BILL ip_ds, decimal ip_dc_id_phong_ban, string ip_str_tu_khoa, DateTime ip_dat_tu_ngay, DateTime ip_dat_den_ngay)
    {
        CStoredProc v_store_proc = new CStoredProc("pr_V_DM_BILL_Search");
        v_store_proc.addDecimalInputParam("@ID_TRUNG_TAM", ip_dc_id_phong_ban);
        v_store_proc.addNVarcharInputParam("@TU_KHOA", ip_str_tu_khoa);
        v_store_proc.addDatetimeInputParam("@TU_NGAY", ip_dat_tu_ngay);
        v_store_proc.addDatetimeInputParam("@DEN_NGAY", ip_dat_den_ngay);
        v_store_proc.fillDataSetByCommand(this, ip_ds);
    }

    public void FillDataset(DS_V_DM_BILL ip_v_ds_v_dm_bill, decimal ip_dc_id_trung_tam, DateTime ip_v_dat_tu_ngay, DateTime ip_v_dat_den_ngay, decimal ip_v_dc_id_trang_thai, string ip_v_str_tu_khoa)
    {
        CStoredProc v_store_proc = new CStoredProc("pr_TRA_CUU_TRANG_THAI_CUA_TRUNG_TAM_WEB_Search");
        v_store_proc.addDecimalInputParam("@ID_TRUNG_TAM", ip_dc_id_trung_tam);
        v_store_proc.addNVarcharInputParam("@TU_KHOA", ip_v_str_tu_khoa);
        v_store_proc.addDatetimeInputParam("@TU_NGAY", ip_v_dat_tu_ngay);
        v_store_proc.addDatetimeInputParam("@DEN_NGAY", ip_v_dat_den_ngay);
        v_store_proc.addDecimalInputParam("@ID_TRANG_THAI", ip_v_dc_id_trang_thai);
        v_store_proc.fillDataSetByCommand(this, ip_v_ds_v_dm_bill);
    }
}
}
