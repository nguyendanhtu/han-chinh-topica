///************************************************
/// Generated by: NinhVH
/// Date: 26/11/2012 03:27:37
/// Goal: Create User Service Class for HT_PHAN_QUYEN_CHO_NHOM
///************************************************
/// <summary>
/// Create User Service Class for HT_PHAN_QUYEN_CHO_NHOM
/// </summary>


using BCTKDS;
using BCTKDS.CDBNames;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using System;


namespace BCTKUS
{

    public class US_HT_PHAN_QUYEN_CHO_NHOM : US_Object
    {
        private const string c_TableName = "HT_PHAN_QUYEN_CHO_NHOM";
        #region Public Properties
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

        public decimal dcID_PHAN_QUYEN_HE_THONG
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_PHAN_QUYEN_HE_THONG", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_PHAN_QUYEN_HE_THONG"] = value;
            }
        }

        public bool IsID_PHAN_QUYEN_HE_THONGNull()
        {
            return pm_objDR.IsNull("ID_PHAN_QUYEN_HE_THONG");
        }

        public void SetID_PHAN_QUYEN_HE_THONGNull()
        {
            pm_objDR["ID_PHAN_QUYEN_HE_THONG"] = System.Convert.DBNull;
        }


        #endregion


        #region Init Functions
        public US_HT_PHAN_QUYEN_CHO_NHOM()
        {
            pm_objDS = new DS_HT_PHAN_QUYEN_CHO_NHOM();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_HT_PHAN_QUYEN_CHO_NHOM(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_HT_PHAN_QUYEN_CHO_NHOM(decimal i_dbID)
        {
            pm_objDS = new DS_HT_PHAN_QUYEN_CHO_NHOM();
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
        public void FillDatasetByGroupUserID(decimal i_dc_group_user_id
            , DS_HT_PHAN_QUYEN_CHO_NHOM i_ds)
        {

            IMakeSelectCmd v_obj_mak_cmd = new CMakeAndSelectCmd(i_ds, i_ds.HT_PHAN_QUYEN_CHO_NHOM.TableName);
            v_obj_mak_cmd.AddCondition(HT_PHAN_QUYEN_CHO_NHOM.ID_USER_GROUP, i_dc_group_user_id, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            this.FillDatasetByCommand(i_ds, v_obj_mak_cmd.getSelectCmd());
        }
        public void DeleteAllQuyenOfGroupUser(decimal i_dc_group_user_id)
        {
            CStoredProc v_obj = new CStoredProc("pr_HT_PHAN_QUYEN_HE_THONG_Delele_All_Quyen_Of_group_user");
            v_obj.addDecimalInputParam("@ip_dc_group_user_id", i_dc_group_user_id);
            v_obj.ExecuteCommand(this);
        }
        #endregion

        public void FillDatasetByIdUserGroupAndMaPhanQuyen(DS_HT_PHAN_QUYEN_CHO_NHOM op_ds, decimal ip_dc_id, string ip_str)
        {
            CStoredProc v_stored_proc = new CStoredProc("pr_HT_PHAN_QUYEN_CHO_NHOM_select_by_ma_pq");
            v_stored_proc.addNVarcharInputParam("@MA_PHAN_QUYEN", ip_str);
            v_stored_proc.addDecimalInputParam("@ID_USER_GROUP", ip_dc_id);
            v_stored_proc.fillDataSetByCommand(this, op_ds);
        }
    }

}
