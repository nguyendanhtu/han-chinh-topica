///************************************************
/// Generated by: TuDM
/// Date: 05/02/2015 02:02:34
/// Goal: Create User Service Class for V_HT_VAN_THU_HISTORY
///************************************************
/// <summary>
/// Create User Service Class for V_HT_VAN_THU_HISTORY
/// </summary>

using System;
using BCTKDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BCTKUS
{

	public class US_V_HT_VAN_THU_HISTORY : US_Object
	{
		private const string c_TableName = "V_HT_VAN_THU_HISTORY";
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

		public decimal dcID_NGUOI_SU_DUNG
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "ID_NGUOI_SU_DUNG", IPConstants.c_DefaultDecimal);
			}
			set
			{
				pm_objDR["ID_NGUOI_SU_DUNG"] = value;
			}
		}

		public bool IsID_NGUOI_SU_DUNGNull()
		{
			return pm_objDR.IsNull("ID_NGUOI_SU_DUNG");
		}

		public void SetID_NGUOI_SU_DUNGNull()
		{
			pm_objDR["ID_NGUOI_SU_DUNG"] = System.Convert.DBNull;
		}

		public DateTime datTHOI_DIEM
		{
			get
			{
				return CNull.RowNVLDate(pm_objDR, "THOI_DIEM", IPConstants.c_DefaultDate);
			}
			set
			{
				pm_objDR["THOI_DIEM"] = value;
			}
		}

		public bool IsTHOI_DIEMNull()
		{
			return pm_objDR.IsNull("THOI_DIEM");
		}

		public void SetTHOI_DIEMNull()
		{
			pm_objDR["THOI_DIEM"] = System.Convert.DBNull;
		}

		public string strHANH_DONG
		{
			get
			{
				return CNull.RowNVLString(pm_objDR, "HANH_DONG", IPConstants.c_DefaultString);
			}
			set
			{
				pm_objDR["HANH_DONG"] = value;
			}
		}

		public bool IsHANH_DONGNull()
		{
			return pm_objDR.IsNull("HANH_DONG");
		}

		public void SetHANH_DONGNull()
		{
			pm_objDR["HANH_DONG"] = System.Convert.DBNull;
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

		public string strGHI_CHU_1
		{
			get
			{
				return CNull.RowNVLString(pm_objDR, "GHI_CHU_1", IPConstants.c_DefaultString);
			}
			set
			{
				pm_objDR["GHI_CHU_1"] = value;
			}
		}

		public bool IsGHI_CHU_1Null()
		{
			return pm_objDR.IsNull("GHI_CHU_1");
		}

		public void SetGHI_CHU_1Null()
		{
			pm_objDR["GHI_CHU_1"] = System.Convert.DBNull;
		}

		public string strGHI_CHU_2
		{
			get
			{
				return CNull.RowNVLString(pm_objDR, "GHI_CHU_2", IPConstants.c_DefaultString);
			}
			set
			{
				pm_objDR["GHI_CHU_2"] = value;
			}
		}

		public bool IsGHI_CHU_2Null()
		{
			return pm_objDR.IsNull("GHI_CHU_2");
		}

		public void SetGHI_CHU_2Null()
		{
			pm_objDR["GHI_CHU_2"] = System.Convert.DBNull;
		}

		public string strTEN_TRUY_CAP
		{
			get
			{
				return CNull.RowNVLString(pm_objDR, "TEN_TRUY_CAP", IPConstants.c_DefaultString);
			}
			set
			{
				pm_objDR["TEN_TRUY_CAP"] = value;
			}
		}

		public bool IsTEN_TRUY_CAPNull()
		{
			return pm_objDR.IsNull("TEN_TRUY_CAP");
		}

		public void SetTEN_TRUY_CAPNull()
		{
			pm_objDR["TEN_TRUY_CAP"] = System.Convert.DBNull;
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

		#endregion
		#region "Init Functions"
		public US_V_HT_VAN_THU_HISTORY()
		{
			pm_objDS = new DS_V_HT_VAN_THU_HISTORY();
			pm_strTableName = c_TableName;
			pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
		}

		public US_V_HT_VAN_THU_HISTORY(DataRow i_objDR)
			: this()
		{
			this.DataRow2Me(i_objDR);
		}

		public US_V_HT_VAN_THU_HISTORY(decimal i_dbID)
		{
			pm_objDS = new DS_V_HT_VAN_THU_HISTORY();
			pm_strTableName = c_TableName;
			IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
			v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
			SqlCommand v_cmdSQL;
			v_cmdSQL = v_objMkCmd.getSelectCmd();
			this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
			pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
		}
		#endregion

		#region "Additional"
		public void v_ht_van_thu_history_search_F660(
			DS_V_HT_VAN_THU_HISTORY op_ds
			,DateTime ip_dat_tu_ngay
			,DateTime ip_dat_den_ngay
			,string ip_str_tu_khoa)
		{
			CStoredProc v_sp = new CStoredProc("pr_v_ht_van_thu_history_search_F660");
			v_sp.addDatetimeInputParam("@ip_dat_tu_ngay", ip_dat_tu_ngay);
			v_sp.addDatetimeInputParam("@ip_dat_den_ngay", ip_dat_den_ngay);
			v_sp.addNVarcharInputParam("@ip_str_tu_khoa", ip_str_tu_khoa);
			v_sp.fillDataSetByCommand(this, op_ds);
		}
		#endregion
	}
}
