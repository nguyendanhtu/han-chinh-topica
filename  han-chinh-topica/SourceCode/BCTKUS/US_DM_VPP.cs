///************************************************
/// Generated by: TuDM
/// Date: 24/07/2014 08:38:24
/// Goal: Create User Service Class for DM_VPP
///************************************************
/// <summary>
/// Create User Service Class for DM_VPP
/// </summary>

using System;
using BCTKDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BCTKUS
{

    public class US_DM_VPP : US_Object
    {
        private const string c_TableName = "DM_VPP";
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

        public string strTEN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN"] = value;
            }
        }

        public bool IsTENNull()
        {
            return pm_objDR.IsNull("TEN");
        }

        public void SetTENNull()
        {
            pm_objDR["TEN"] = System.Convert.DBNull;
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
        public US_DM_VPP()
        {
            pm_objDS = new DS_DM_VPP();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_DM_VPP(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_DM_VPP(decimal i_dbID)
        {
            pm_objDS = new DS_DM_VPP();
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
