///************************************************
/// Generated by: TuDM
/// Date: 28/07/2013 09:46:35
/// Goal: Create User Service Class for HT_QUAN_HE_SU_DUNG_DU_LIEU
///************************************************
/// <summary>
/// Create User Service Class for HT_QUAN_HE_SU_DUNG_DU_LIEU
/// </summary>

using System;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using BCTKDS;


namespace BCTKUS
{

    public class US_HT_QUAN_HE_SU_DUNG_DU_LIEU : US_Object
    {
        private const string c_TableName = "HT_QUAN_HE_SU_DUNG_DU_LIEU";
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

        public decimal dcID_USER_GROUP
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_USER_GROUP", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_USER_GROUP"] = value;
            }
        }

        public bool IsID_USER_GROUPNull()
        {
            return pm_objDR.IsNull("ID_USER_GROUP");
        }

        public void SetID_USER_GROUPNull()
        {
            pm_objDR["ID_USER_GROUP"] = System.Convert.DBNull;
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

        #endregion
        #region "Init Functions"
        public US_HT_QUAN_HE_SU_DUNG_DU_LIEU()
        {
            pm_objDS = new DS_HT_QUAN_HE_SU_DUNG_DU_LIEU();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_HT_QUAN_HE_SU_DUNG_DU_LIEU(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_HT_QUAN_HE_SU_DUNG_DU_LIEU(decimal i_dbID)
        {
            pm_objDS = new DS_HT_QUAN_HE_SU_DUNG_DU_LIEU();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion

        #region Addtional

        public void update_quyen_group(decimal i_dc_user_group, string i_arr_dc_don_vi)
        {
            CStoredProc v_cstore = new CStoredProc("pr_HT_QUAN_HE_SU_DUNG_DU_LIEU_UpdateQuyen4Group");
            v_cstore.addDecimalInputParam("@ID_USER_GROUP", i_dc_user_group);
            v_cstore.addNVarcharInputParam("@ID_PHONG_BAN", i_arr_dc_don_vi);
            v_cstore.ExecuteCommand(this);
        }
        #endregion
    }
}
