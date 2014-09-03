///************************************************
/// Generated by: TuyenNT
/// Date: 29/08/2014 12:02:54
/// Goal: Create User Service Class for RPT_CHI_TIET_CHI_PHI_PHAP_NHAN
///************************************************
/// <summary>
/// Create User Service Class for RPT_CHI_TIET_CHI_PHI_PHAP_NHAN
/// </summary>

using System;
using BCTKDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BCTKUS{

public class US_RPT_CHI_TIET_CHI_PHI_PHAP_NHAN : US_Object
{
	private const string c_TableName = "RPT_CHI_TIET_CHI_PHI_PHAP_NHAN";
    #region "Public Properties"
    public decimal dcID {
        get {
            return CNull.RowNVLDecimal(pm_objDR, "ID", IPConstants.c_DefaultDecimal);
        }
        set {
            pm_objDR["ID"] = value;
        }
    }

    public bool IsIDNull() {
        return pm_objDR.IsNull("ID");
    }

    public void SetIDNull() {
        pm_objDR["ID"] = System.Convert.DBNull;
    }

    public string strNOI_DUNG {
        get {
            return CNull.RowNVLString(pm_objDR, "NOI_DUNG", IPConstants.c_DefaultString);
        }
        set {
            pm_objDR["NOI_DUNG"] = value;
        }
    }

    public bool IsNOI_DUNGNull() {
        return pm_objDR.IsNull("NOI_DUNG");
    }

    public void SetNOI_DUNGNull() {
        pm_objDR["NOI_DUNG"] = System.Convert.DBNull;
    }

    public string strNOI_NHAN {
        get {
            return CNull.RowNVLString(pm_objDR, "NOI_NHAN", IPConstants.c_DefaultString);
        }
        set {
            pm_objDR["NOI_NHAN"] = value;
        }
    }

    public bool IsNOI_NHANNull() {
        return pm_objDR.IsNull("NOI_NHAN");
    }

    public void SetNOI_NHANNull() {
        pm_objDR["NOI_NHAN"] = System.Convert.DBNull;
    }

    public string strNGUOI_NHAN {
        get {
            return CNull.RowNVLString(pm_objDR, "NGUOI_NHAN", IPConstants.c_DefaultString);
        }
        set {
            pm_objDR["NGUOI_NHAN"] = value;
        }
    }

    public bool IsNGUOI_NHANNull() {
        return pm_objDR.IsNull("NGUOI_NHAN");
    }

    public void SetNGUOI_NHANNull() {
        pm_objDR["NGUOI_NHAN"] = System.Convert.DBNull;
    }

    public string strTRONG_NUOC {
        get {
            return CNull.RowNVLString(pm_objDR, "TRONG_NUOC", IPConstants.c_DefaultString);
        }
        set {
            pm_objDR["TRONG_NUOC"] = value;
        }
    }

    public bool IsTRONG_NUOCNull() {
        return pm_objDR.IsNull("TRONG_NUOC");
    }

    public void SetTRONG_NUOCNull() {
        pm_objDR["TRONG_NUOC"] = System.Convert.DBNull;
    }

    public string strNUOC_NGOAI {
        get {
            return CNull.RowNVLString(pm_objDR, "NUOC_NGOAI", IPConstants.c_DefaultString);
        }
        set {
            pm_objDR["NUOC_NGOAI"] = value;
        }
    }

    public bool IsNUOC_NGOAINull() {
        return pm_objDR.IsNull("NUOC_NGOAI");
    }

    public void SetNUOC_NGOAINull() {
        pm_objDR["NUOC_NGOAI"] = System.Convert.DBNull;
    }

    public string strSO_BILL {
        get {
            return CNull.RowNVLString(pm_objDR, "SO_BILL", IPConstants.c_DefaultString);
        }
        set {
            pm_objDR["SO_BILL"] = value;
        }
    }

    public bool IsSO_BILLNull() {
        return pm_objDR.IsNull("SO_BILL");
    }

    public void SetSO_BILLNull() {
        pm_objDR["SO_BILL"] = System.Convert.DBNull;
    }

    public string strNGUOI_GUI {
        get {
            return CNull.RowNVLString(pm_objDR, "NGUOI_GUI", IPConstants.c_DefaultString);
        }
        set {
            pm_objDR["NGUOI_GUI"] = value;
        }
    }

    public bool IsNGUOI_GUINull() {
        return pm_objDR.IsNull("NGUOI_GUI");
    }

    public void SetNGUOI_GUINull() {
        pm_objDR["NGUOI_GUI"] = System.Convert.DBNull;
    }

    public DateTime datNGAY_GUI {
        get {
            return CNull.RowNVLDate(pm_objDR, "NGAY_GUI", IPConstants.c_DefaultDate);
        }
        set {
            pm_objDR["NGAY_GUI"] = value;
        }
    }

    public bool IsNGAY_GUINull() {
        return pm_objDR.IsNull("NGAY_GUI");
    }

    public void SetNGAY_GUINull() {
        pm_objDR["NGAY_GUI"] = System.Convert.DBNull;
    }

    public string strGHI_CHU {
        get {
            return CNull.RowNVLString(pm_objDR, "GHI_CHU", IPConstants.c_DefaultString);
        }
        set {
            pm_objDR["GHI_CHU"] = value;
        }
    }

    public bool IsGHI_CHUNull() {
        return pm_objDR.IsNull("GHI_CHU");
    }

    public void SetGHI_CHUNull() {
        pm_objDR["GHI_CHU"] = System.Convert.DBNull;
    }

    public decimal dcID_PHONG_BAN {
        get {
            return CNull.RowNVLDecimal(pm_objDR, "ID_PHONG_BAN", IPConstants.c_DefaultDecimal);
        }
        set {
            pm_objDR["ID_PHONG_BAN"] = value;
        }
    }

    public bool IsID_PHONG_BANNull() {
        return pm_objDR.IsNull("ID_PHONG_BAN");
    }

    public void SetID_PHONG_BANNull() {
        pm_objDR["ID_PHONG_BAN"] = System.Convert.DBNull;
    }

    public decimal dcSO_TIEN {
        get {
            return CNull.RowNVLDecimal(pm_objDR, "SO_TIEN", IPConstants.c_DefaultDecimal);
        }
        set {
            pm_objDR["SO_TIEN"] = value;
        }
    }

    public bool IsSO_TIENNull() {
        return pm_objDR.IsNull("SO_TIEN");
    }

    public void SetSO_TIENNull() {
        pm_objDR["SO_TIEN"] = System.Convert.DBNull;
    }

    public decimal dcID_TRANG_THAI {
        get {
            return CNull.RowNVLDecimal(pm_objDR, "ID_TRANG_THAI", IPConstants.c_DefaultDecimal);
        }
        set {
            pm_objDR["ID_TRANG_THAI"] = value;
        }
    }

    public bool IsID_TRANG_THAINull() {
        return pm_objDR.IsNull("ID_TRANG_THAI");
    }

    public void SetID_TRANG_THAINull() {
        pm_objDR["ID_TRANG_THAI"] = System.Convert.DBNull;
    }

    public decimal dcID_PHAP_NHAN {
        get {
            return CNull.RowNVLDecimal(pm_objDR, "ID_PHAP_NHAN", IPConstants.c_DefaultDecimal);
        }
        set {
            pm_objDR["ID_PHAP_NHAN"] = value;
        }
    }

    public bool IsID_PHAP_NHANNull() {
        return pm_objDR.IsNull("ID_PHAP_NHAN");
    }

    public void SetID_PHAP_NHANNull() {
        pm_objDR["ID_PHAP_NHAN"] = System.Convert.DBNull;
    }

    public decimal dcTY_TRONG {
        get {
            return CNull.RowNVLDecimal(pm_objDR, "TY_TRONG", IPConstants.c_DefaultDecimal);
        }
        set {
            pm_objDR["TY_TRONG"] = value;
        }
    }

    public bool IsTY_TRONGNull() {
        return pm_objDR.IsNull("TY_TRONG");
    }

    public void SetTY_TRONGNull() {
        pm_objDR["TY_TRONG"] = System.Convert.DBNull;
    }

    public decimal dcTIEN_PN {
        get {
            return CNull.RowNVLDecimal(pm_objDR, "TIEN_PN", IPConstants.c_DefaultDecimal);
        }
        set {
            pm_objDR["TIEN_PN"] = value;
        }
    }

    public bool IsTIEN_PNNull() {
        return pm_objDR.IsNull("TIEN_PN");
    }

    public void SetTIEN_PNNull() {
        pm_objDR["TIEN_PN"] = System.Convert.DBNull;
    }

    public string strMA_PHONG_BAN {
        get {
            return CNull.RowNVLString(pm_objDR, "MA_PHONG_BAN", IPConstants.c_DefaultString);
        }
        set {
            pm_objDR["MA_PHONG_BAN"] = value;
        }
    }

    public bool IsMA_PHONG_BANNull() {
        return pm_objDR.IsNull("MA_PHONG_BAN");
    }

    public void SetMA_PHONG_BANNull() {
        pm_objDR["MA_PHONG_BAN"] = System.Convert.DBNull;
    }

    public string strTEN_PHONG_BAN {
        get {
            return CNull.RowNVLString(pm_objDR, "TEN_PHONG_BAN", IPConstants.c_DefaultString);
        }
        set {
            pm_objDR["TEN_PHONG_BAN"] = value;
        }
    }

    public bool IsTEN_PHONG_BANNull() {
        return pm_objDR.IsNull("TEN_PHONG_BAN");
    }

    public void SetTEN_PHONG_BANNull() {
        pm_objDR["TEN_PHONG_BAN"] = System.Convert.DBNull;
    }

    public string strMA_PHAP_NHAN {
        get {
            return CNull.RowNVLString(pm_objDR, "MA_PHAP_NHAN", IPConstants.c_DefaultString);
        }
        set {
            pm_objDR["MA_PHAP_NHAN"] = value;
        }
    }

    public bool IsMA_PHAP_NHANNull() {
        return pm_objDR.IsNull("MA_PHAP_NHAN");
    }

    public void SetMA_PHAP_NHANNull() {
        pm_objDR["MA_PHAP_NHAN"] = System.Convert.DBNull;
    }

    public string strTEN_PHAP_NHAN {
        get {
            return CNull.RowNVLString(pm_objDR, "TEN_PHAP_NHAN", IPConstants.c_DefaultString);
        }
        set {
            pm_objDR["TEN_PHAP_NHAN"] = value;
        }
    }

    public bool IsTEN_PHAP_NHANNull() {
        return pm_objDR.IsNull("TEN_PHAP_NHAN");
    }

    public void SetTEN_PHAP_NHANNull() {
        pm_objDR["TEN_PHAP_NHAN"] = System.Convert.DBNull;
    }

    #endregion
#region "Init Functions"
	public US_RPT_CHI_TIET_CHI_PHI_PHAP_NHAN() 
	{
		pm_objDS = new DS_RPT_CHI_TIET_CHI_PHI_PHAP_NHAN();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_RPT_CHI_TIET_CHI_PHI_PHAP_NHAN(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_RPT_CHI_TIET_CHI_PHI_PHAP_NHAN(decimal i_dbID) 
	{
		pm_objDS = new DS_RPT_CHI_TIET_CHI_PHI_PHAP_NHAN();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion
    public void fillDatasetChiPhiPhapNhan(DS_RPT_CHI_TIET_CHI_PHI_PHAP_NHAN op_ds, decimal ip_id_phap_nhan, DateTime ip_tu_ngay, DateTime ip_den_ngay) {
        CStoredProc v_proc = new CStoredProc("pr_chi_tiet_chi_phi_phap_nhan");
        v_proc.addNVarcharInputParam("@ID_PHAP_NHAN", ip_id_phap_nhan);
        v_proc.addDatetimeInputParam("@TU_NGAY", ip_tu_ngay);
        v_proc.addDatetimeInputParam("@DEN_NGAY", ip_den_ngay);
        v_proc.fillDataSetByCommand(this, op_ds);
    }

	}
}
