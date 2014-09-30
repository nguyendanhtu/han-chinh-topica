///************************************************
/// Generated by: DungNT
/// Date: 24/07/2014 05:04:18
/// Goal: Create User Service Class for V_GD_DON_DAT_HANG_DETAIL
///************************************************
/// <summary>
/// Create User Service Class for V_GD_DON_DAT_HANG_DETAIL
/// </summary>

using System;
using BCTKDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BCTKUS{

public class US_V_GD_DON_DAT_HANG_DETAIL : US_Object
{
	private const string c_TableName = "V_GD_DON_DAT_HANG_DETAIL";
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

    public string strMA_VPP
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "MA_VPP", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["MA_VPP"] = value;
        }
    }

    public bool IsMA_VPPNull()
    {
        return pm_objDR.IsNull("MA_VPP");
    }

    public void SetMA_VPPNull()
    {
        pm_objDR["MA_VPP"] = System.Convert.DBNull;
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

    public bool IsSO_LUONGNull()
    {
        return pm_objDR.IsNull("SO_LUONG");
    }

    public void SetSO_LUONGNull()
    {
        pm_objDR["SO_LUONG"] = System.Convert.DBNull;
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

    public bool IsID_DON_DAT_HANGNull()
    {
        return pm_objDR.IsNull("ID_DON_DAT_HANG");
    }

    public void SetID_DON_DAT_HANGNull()
    {
        pm_objDR["ID_DON_DAT_HANG"] = System.Convert.DBNull;
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

    public bool IsID_TRANG_THAI_HANGNull()
    {
        return pm_objDR.IsNull("ID_TRANG_THAI_HANG");
    }

    public void SetID_TRANG_THAI_HANGNull()
    {
        pm_objDR["ID_TRANG_THAI_HANG"] = System.Convert.DBNull;
    }

    public string strTRANG_THAI_HANG
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "TRANG_THAI_HANG", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["TRANG_THAI_HANG"] = value;
        }
    }

    public bool IsTRANG_THAI_HANGNull()
    {
        return pm_objDR.IsNull("TRANG_THAI_HANG");
    }

    public void SetTRANG_THAI_HANGNull()
    {
        pm_objDR["TRANG_THAI_HANG"] = System.Convert.DBNull;
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
    public US_V_GD_DON_DAT_HANG_DETAIL()
    {
        pm_objDS = new DS_V_GD_DON_DAT_HANG_DETAIL();
        pm_strTableName = c_TableName;
        pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
    }

    public US_V_GD_DON_DAT_HANG_DETAIL(DataRow i_objDR)
        : this()
    {
        this.DataRow2Me(i_objDR);
    }

    public US_V_GD_DON_DAT_HANG_DETAIL(decimal i_dbID)
    {
        pm_objDS = new DS_V_GD_DON_DAT_HANG_DETAIL();
        pm_strTableName = c_TableName;
        IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
        v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
        SqlCommand v_cmdSQL;
        v_cmdSQL = v_objMkCmd.getSelectCmd();
        this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
        pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
    }
    #endregion

    public void FillDatasetSearch(DS_V_GD_DON_DAT_HANG_DETAIL ip_ds, DateTime ip_dat_thang, decimal ip_dc_id_trung_tam, string ip_str_tu_khoa)
    {
        CStoredProc v_stored_proc = new CStoredProc("pr_V_GD_DON_DAT_HANG_DETAIL_Search");
        v_stored_proc.addNVarcharInputParam("@TU_KHOA", ip_str_tu_khoa);
        v_stored_proc.addDecimalInputParam("@ID_PHONG_BAN", ip_dc_id_trung_tam);
        v_stored_proc.addDatetimeInputParam("@NGAY", ip_dat_thang);
        v_stored_proc.fillDataSetByCommand(this, ip_ds);
    }

    public void FillDatasetSearch_hdchitiet(DS_V_GD_DON_DAT_HANG_DETAIL ip_ds, decimal ip_dc_id_hoa_don)
    {
        CStoredProc v_stored_proc = new CStoredProc("pr_V_GD_DON_DAT_HANG_DETAIL_Search_hd_detail");
        v_stored_proc.addDecimalInputParam("@ID_DON_HANG", ip_dc_id_hoa_don);
        v_stored_proc.fillDataSetByCommand(this, ip_ds);
    }

    public void So_sanh_hoa_don_theo_ma_NCC(DS_V_GD_DON_DAT_HANG_DETAIL v_ds_v_don_dat_hang_de, string ip_ma_don_hang_NCC, string ip_ma_ten_vpp)
    {
        CStoredProc v_stored_proc = new CStoredProc("pr_So_sanh_chi_phi_NCC");
        v_stored_proc.addNVarcharInputParam("@MA_HD_NCC", ip_ma_don_hang_NCC);
        v_stored_proc.addNVarcharInputParam("@MA_TEN_VPP", ip_ma_ten_vpp);
        v_stored_proc.fillDataSetByCommand(this, v_ds_v_don_dat_hang_de);
    }

    public void FillDatasetSearch_phapnhan(DS_V_GD_DON_DAT_HANG_DETAIL ip_ds, DateTime ip_dat_thang, decimal ip_dc_id_phap_nhan, decimal ip_id_trang_thai, decimal ip_dc_id_trung_tam)
    {
        CStoredProc v_stored_proc = new CStoredProc("pr_V_GD_DON_DAT_HANG_DETAIL_Search_Phapnhan");
        v_stored_proc.addDecimalInputParam("@ID_PHONG_BAN", ip_dc_id_trung_tam);
        v_stored_proc.addDecimalInputParam("@ID_PHAP_NHAN", ip_dc_id_phap_nhan);
        v_stored_proc.addDecimalInputParam("@ID_TRANG_THAI", ip_id_trang_thai);
        v_stored_proc.addDatetimeInputParam("@NGAY", ip_dat_thang);
        v_stored_proc.fillDataSetByCommand(this, ip_ds);
    }

    public void FillDataset(DS_V_GD_DON_DAT_HANG_DETAIL ip_v_ds, string v_ma_don_hang, DateTime ip_dat_tu_ngay, DateTime ip_dat_den_ngay)
    {
        CStoredProc v_stored_proc = new CStoredProc("pr_BC_TINH_HINH_SU_DUNG_VPP_DETAIL_WEB");
        v_stored_proc.addNVarcharInputParam("@MA_DON_HANG", v_ma_don_hang);
        v_stored_proc.addDatetimeInputParam("@TU_NGAY", ip_dat_tu_ngay);
        v_stored_proc.addDatetimeInputParam("@DEN_NGAY", ip_dat_den_ngay);
        v_stored_proc.fillDataSetByCommand(this, ip_v_ds);
    }
}
}
