///************************************************
/// Generated by: TuNA
/// Date: 24/07/2014 10:25:51
/// Goal: Create User Service Class for V_DM_VPP
///************************************************
/// <summary>
/// Create User Service Class for V_DM_VPP
/// </summary>

using System;
using BCTKDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BCTKUS{

public class US_V_DM_VPP : US_Object
{
	private const string c_TableName = "V_DM_VPP";
    #region "Public Properties"
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

    public bool IsID_VPPNull()
    {
        return pm_objDR.IsNull("ID_VPP");
    }

    public void SetID_VPPNull()
    {
        pm_objDR["ID_VPP"] = System.Convert.DBNull;
    }

    public string strMA
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "MA", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["MA"] = value;
        }
    }

    public bool IsMANull()
    {
        return pm_objDR.IsNull("MA");
    }

    public void SetMANull()
    {
        pm_objDR["MA"] = System.Convert.DBNull;
    }

    public string strTEN_VPP
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "TEN_VPP", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["TEN_VPP"] = value;
        }
    }

    public bool IsTEN_VPPNull()
    {
        return pm_objDR.IsNull("TEN_VPP");
    }

    public void SetTEN_VPPNull()
    {
        pm_objDR["TEN_VPP"] = System.Convert.DBNull;
    }

    public string strDON_VI_TINH
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "DON_VI_TINH", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["DON_VI_TINH"] = value;
        }
    }

    public bool IsDON_VI_TINHNull()
    {
        return pm_objDR.IsNull("DON_VI_TINH");
    }

    public void SetDON_VI_TINHNull()
    {
        pm_objDR["DON_VI_TINH"] = System.Convert.DBNull;
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

    public bool IsDON_GIA_CHUA_VATNull()
    {
        return pm_objDR.IsNull("DON_GIA_CHUA_VAT");
    }

    public void SetDON_GIA_CHUA_VATNull()
    {
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

    public bool IsDON_GIA_GOM_VATNull()
    {
        return pm_objDR.IsNull("DON_GIA_GOM_VAT");
    }

    public void SetDON_GIA_GOM_VATNull()
    {
        pm_objDR["DON_GIA_GOM_VAT"] = System.Convert.DBNull;
    }

    public decimal dcID_NHA_CUNG_CAP
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "ID_NHA_CUNG_CAP", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["ID_NHA_CUNG_CAP"] = value;
        }
    }

    public bool IsID_NHA_CUNG_CAPNull()
    {
        return pm_objDR.IsNull("ID_NHA_CUNG_CAP");
    }

    public void SetID_NHA_CUNG_CAPNull()
    {
        pm_objDR["ID_NHA_CUNG_CAP"] = System.Convert.DBNull;
    }

    public string strTEN_NCC
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "TEN_NCC", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["TEN_NCC"] = value;
        }
    }

    public bool IsTEN_NCCNull()
    {
        return pm_objDR.IsNull("TEN_NCC");
    }

    public void SetTEN_NCCNull()
    {
        pm_objDR["TEN_NCC"] = System.Convert.DBNull;
    }

    public string strGIOI_HAN_VPP
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "GIOI_HAN_VPP", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["GIOI_HAN_VPP"] = value;
        }
    }

    public bool IsGIOI_HAN_VPPNull()
    {
        return pm_objDR.IsNull("GIOI_HAN_VPP");
    }

    public void SetGIOI_HAN_VPPNull()
    {
        pm_objDR["GIOI_HAN_VPP"] = System.Convert.DBNull;
    }

    #endregion
    #region "Init Functions"
    public US_V_DM_VPP()
    {
        pm_objDS = new DS_V_DM_VPP();
        pm_strTableName = c_TableName;
        pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
    }

    public US_V_DM_VPP(DataRow i_objDR)
        : this()
    {
        this.DataRow2Me(i_objDR);
    }

    public US_V_DM_VPP(decimal i_dbID)
    {
        pm_objDS = new DS_V_DM_VPP();
        pm_strTableName = c_TableName;
        IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
        v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
        SqlCommand v_cmdSQL;
        v_cmdSQL = v_objMkCmd.getSelectCmd();
        this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
        pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
    }
    #endregion

    public void FillDatasetsearch(DS_V_DM_VPP ip_m_ds, decimal ip_v_id_ncc, decimal ip_v_dc_tu_khoa)
    {
        CStoredProc v_stored_proc = new CStoredProc("pr_V_DM_VPP_Search");
        v_stored_proc.addDecimalInputParam("@ID_VPP", ip_v_dc_tu_khoa);
        v_stored_proc.addDecimalInputParam("@ID_NCC", ip_v_id_ncc);
        v_stored_proc.fillDataSetByCommand(this, ip_m_ds);
    }
}
}
