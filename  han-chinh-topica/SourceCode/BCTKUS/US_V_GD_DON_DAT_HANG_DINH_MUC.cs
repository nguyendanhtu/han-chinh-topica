///************************************************
/// Generated by: DungNT
/// Date: 09/08/2014 08:16:59
/// Goal: Create User Service Class for V_GD_DON_DAT_HANG_DINH_MUC
///************************************************
/// <summary>
/// Create User Service Class for V_GD_DON_DAT_HANG_DINH_MUC
/// </summary>

using System;
using BCTKDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BCTKUS{

public class US_V_GD_DON_DAT_HANG_DINH_MUC : US_Object
{
	private const string c_TableName = "V_GD_DON_DAT_HANG_DINH_MUC";
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

    public string strMA_DON_HANG
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "MA_DON_HANG", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["MA_DON_HANG"] = value;
        }
    }

    public bool IsMA_DON_HANGNull()
    {
        return pm_objDR.IsNull("MA_DON_HANG");
    }

    public void SetMA_DON_HANGNull()
    {
        pm_objDR["MA_DON_HANG"] = System.Convert.DBNull;
    }

    public decimal dcLAN_DAT_HANG
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "LAN_DAT_HANG", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["LAN_DAT_HANG"] = value;
        }
    }

    public bool IsLAN_DAT_HANGNull()
    {
        return pm_objDR.IsNull("LAN_DAT_HANG");
    }

    public void SetLAN_DAT_HANGNull()
    {
        pm_objDR["LAN_DAT_HANG"] = System.Convert.DBNull;
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

    public string strTEN_TRANG_THAI
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "TEN_TRANG_THAI", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["TEN_TRANG_THAI"] = value;
        }
    }

    public bool IsTEN_TRANG_THAINull()
    {
        return pm_objDR.IsNull("TEN_TRANG_THAI");
    }

    public void SetTEN_TRANG_THAINull()
    {
        pm_objDR["TEN_TRANG_THAI"] = System.Convert.DBNull;
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

    public bool IsGIA_TRI_CHUA_VATNull()
    {
        return pm_objDR.IsNull("GIA_TRI_CHUA_VAT");
    }

    public void SetGIA_TRI_CHUA_VATNull()
    {
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

    public bool IsGIA_TRI_DA_VATNull()
    {
        return pm_objDR.IsNull("GIA_TRI_DA_VAT");
    }

    public void SetGIA_TRI_DA_VATNull()
    {
        pm_objDR["GIA_TRI_DA_VAT"] = System.Convert.DBNull;
    }

    public decimal dcTONG_TIEN_DINH_MUC
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "TONG_TIEN_DINH_MUC", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["TONG_TIEN_DINH_MUC"] = value;
        }
    }

    public bool IsTONG_TIEN_DINH_MUCNull()
    {
        return pm_objDR.IsNull("TONG_TIEN_DINH_MUC");
    }

    public void SetTONG_TIEN_DINH_MUCNull()
    {
        pm_objDR["TONG_TIEN_DINH_MUC"] = System.Convert.DBNull;
    }

    public decimal dcTY_LE_VUOT
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "TY_LE_VUOT", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["TY_LE_VUOT"] = value;
        }
    }

    public bool IsTY_LE_VUOTNull()
    {
        return pm_objDR.IsNull("TY_LE_VUOT");
    }

    public void SetTY_LE_VUOTNull()
    {
        pm_objDR["TY_LE_VUOT"] = System.Convert.DBNull;
    }

    #endregion
    #region "Init Functions"
    public US_V_GD_DON_DAT_HANG_DINH_MUC()
    {
        pm_objDS = new DS_V_GD_DON_DAT_HANG_DINH_MUC();
        pm_strTableName = c_TableName;
        pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
    }

    public US_V_GD_DON_DAT_HANG_DINH_MUC(DataRow i_objDR)
        : this()
    {
        this.DataRow2Me(i_objDR);
    }

    public US_V_GD_DON_DAT_HANG_DINH_MUC(decimal i_dbID)
    {
        pm_objDS = new DS_V_GD_DON_DAT_HANG_DINH_MUC();
        pm_strTableName = c_TableName;
        IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
        v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
        SqlCommand v_cmdSQL;
        v_cmdSQL = v_objMkCmd.getSelectCmd();
        this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
        pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
    }
    #endregion

    public void FillDatasetSearch(DS_V_GD_DON_DAT_HANG_DINH_MUC ip_ds, decimal ip_dc_id_trung_tam,decimal ip_id_trang_thai)
    {
        CStoredProc v_store_proc = new CStoredProc("pr_V_GD_DON_DAT_HANG_DINH_MUC_Search");
        v_store_proc.addDecimalInputParam("@PHONG_BAN",ip_dc_id_trung_tam );
        v_store_proc.addDecimalInputParam("@ID_TRANG_THAI", ip_id_trang_thai);
        v_store_proc.fillDataSetByCommand(this, ip_ds);
    }
}
}
