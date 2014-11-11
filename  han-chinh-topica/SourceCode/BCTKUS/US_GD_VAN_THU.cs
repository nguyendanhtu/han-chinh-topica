///************************************************
/// Generated by: TuDM
/// Date: 23/09/2014 09:26:41
/// Goal: Create User Service Class for GD_VAN_THU
///************************************************
/// <summary>
/// Create User Service Class for GD_VAN_THU
/// </summary>

using System;
using BCTKDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BCTKUS
{

    public class US_GD_VAN_THU : US_Object
    {
        private const string c_TableName = "GD_VAN_THU";
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

        public decimal dcID_PHAP_NHAN
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_PHAP_NHAN", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_PHAP_NHAN"] = value;
            }
        }

        public bool IsID_PHAP_NHANNull()
        {
            return pm_objDR.IsNull("ID_PHAP_NHAN");
        }

        public void SetID_PHAP_NHANNull()
        {
            pm_objDR["ID_PHAP_NHAN"] = System.Convert.DBNull;
        }

        public string strSO_CV_DEN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "SO_CV_DEN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["SO_CV_DEN"] = value;
            }
        }

        public bool IsSO_CV_DENNull()
        {
            return pm_objDR.IsNull("SO_CV_DEN");
        }

        public void SetSO_CV_DENNull()
        {
            pm_objDR["SO_CV_DEN"] = System.Convert.DBNull;
        }

        public string strNOI_GUI
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "NOI_GUI", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["NOI_GUI"] = value;
            }
        }

        public bool IsNOI_GUINull()
        {
            return pm_objDR.IsNull("NOI_GUI");
        }

        public void SetNOI_GUINull()
        {
            pm_objDR["NOI_GUI"] = System.Convert.DBNull;
        }

        public string strTEN_LOAI_VA_TRICH_YEU_ND
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_LOAI_VA_TRICH_YEU_ND", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_LOAI_VA_TRICH_YEU_ND"] = value;
            }
        }

        public bool IsTEN_LOAI_VA_TRICH_YEU_NDNull()
        {
            return pm_objDR.IsNull("TEN_LOAI_VA_TRICH_YEU_ND");
        }

        public void SetTEN_LOAI_VA_TRICH_YEU_NDNull()
        {
            pm_objDR["TEN_LOAI_VA_TRICH_YEU_ND"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_THANG_TREN_CONG_VAN
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_THANG_TREN_CONG_VAN", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_THANG_TREN_CONG_VAN"] = value;
            }
        }

        public bool IsNGAY_THANG_TREN_CONG_VANNull()
        {
            return pm_objDR.IsNull("NGAY_THANG_TREN_CONG_VAN");
        }

        public void SetNGAY_THANG_TREN_CONG_VANNull()
        {
            pm_objDR["NGAY_THANG_TREN_CONG_VAN"] = System.Convert.DBNull;
        }

        public decimal dcID_NOI_NGUOI_NHAN
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_NOI_NGUOI_NHAN", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_NOI_NGUOI_NHAN"] = value;
            }
        }

        public bool IsID_NOI_NGUOI_NHANNull()
        {
            return pm_objDR.IsNull("ID_NOI_NGUOI_NHAN");
        }

        public void SetID_NOI_NGUOI_NHANNull()
        {
            pm_objDR["ID_NOI_NGUOI_NHAN"] = System.Convert.DBNull;
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

        public string strNGUOI_LAP
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "NGUOI_LAP", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["NGUOI_LAP"] = value;
            }
        }

        public bool IsNGUOI_LAPNull()
        {
            return pm_objDR.IsNull("NGUOI_LAP");
        }

        public void SetNGUOI_LAPNull()
        {
            pm_objDR["NGUOI_LAP"] = System.Convert.DBNull;
        }

        public string strLINK_SCAN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "LINK_SCAN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["LINK_SCAN"] = value;
            }
        }

        public bool IsLINK_SCANNull()
        {
            return pm_objDR.IsNull("LINK_SCAN");
        }

        public void SetLINK_SCANNull()
        {
            pm_objDR["LINK_SCAN"] = System.Convert.DBNull;
        }

        public decimal dcID_LOAI_CONG_VAN
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_CONG_VAN", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_LOAI_CONG_VAN"] = value;
            }
        }

        public bool IsID_LOAI_CONG_VANNull()
        {
            return pm_objDR.IsNull("ID_LOAI_CONG_VAN");
        }

        public void SetID_LOAI_CONG_VANNull()
        {
            pm_objDR["ID_LOAI_CONG_VAN"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_LAP
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_LAP", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_LAP"] = value;
            }
        }

        public bool IsNGAY_LAPNull()
        {
            return pm_objDR.IsNull("NGAY_LAP");
        }

        public void SetNGAY_LAPNull()
        {
            pm_objDR["NGAY_LAP"] = System.Convert.DBNull;
        }

        public string strSO_VA_KY_HIEU
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "SO_VA_KY_HIEU", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["SO_VA_KY_HIEU"] = value;
            }
        }

        public bool IsSO_VA_KY_HIEUNull()
        {
            return pm_objDR.IsNull("SO_VA_KY_HIEU");
        }

        public void SetSO_VA_KY_HIEUNull()
        {
            pm_objDR["SO_VA_KY_HIEU"] = System.Convert.DBNull;
        }

        public string strNGUOI_KY
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "NGUOI_KY", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["NGUOI_KY"] = value;
            }
        }

        public bool IsNGUOI_KYNull()
        {
            return pm_objDR.IsNull("NGUOI_KY");
        }

        public void SetNGUOI_KYNull()
        {
            pm_objDR["NGUOI_KY"] = System.Convert.DBNull;
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

        public decimal dcID_NGUOI_NHAN_BAN_LUU
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_NGUOI_NHAN_BAN_LUU", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_NGUOI_NHAN_BAN_LUU"] = value;
            }
        }

        public bool IsID_NGUOI_NHAN_BAN_LUUNull()
        {
            return pm_objDR.IsNull("ID_NGUOI_NHAN_BAN_LUU");
        }

        public void SetID_NGUOI_NHAN_BAN_LUUNull()
        {
            pm_objDR["ID_NGUOI_NHAN_BAN_LUU"] = System.Convert.DBNull;
        }

        public string strDANH_SACH_EMAIL_BAN_HANH
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "DANH_SACH_EMAIL_BAN_HANH", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["DANH_SACH_EMAIL_BAN_HANH"] = value;
            }
        }

        public bool IsDANH_SACH_EMAIL_BAN_HANHNull()
        {
            return pm_objDR.IsNull("DANH_SACH_EMAIL_BAN_HANH");
        }

        public void SetDANH_SACH_EMAIL_BAN_HANHNull()
        {
            pm_objDR["DANH_SACH_EMAIL_BAN_HANH"] = System.Convert.DBNull;
        }

        public string strDANH_SACH_EMAIL_XAC_NHAN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "DANH_SACH_EMAIL_XAC_NHAN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["DANH_SACH_EMAIL_XAC_NHAN"] = value;
            }
        }

        public bool IsDANH_SACH_EMAIL_XAC_NHANNull()
        {
            return pm_objDR.IsNull("DANH_SACH_EMAIL_XAC_NHAN");
        }

        public void SetDANH_SACH_EMAIL_XAC_NHANNull()
        {
            pm_objDR["DANH_SACH_EMAIL_XAC_NHAN"] = System.Convert.DBNull;
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

        #endregion
        #region "Init Functions"
        public US_GD_VAN_THU()
        {
            pm_objDS = new DS_GD_VAN_THU();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_GD_VAN_THU(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_GD_VAN_THU(decimal i_dbID)
        {
            pm_objDS = new DS_GD_VAN_THU();
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