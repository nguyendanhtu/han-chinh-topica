using System;
using System.Web.SessionState;
using System.Web;

using BCTKDS;
using BCTKUS;
using BCTKUS;
using BCTKDS.CDBNames;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using IP.Core.IPData;
using IP.Core.IPData.DBNames;

using System.Web.UI.WebControls;
using System.Data;


namespace IP.Core.WinFormControls
{
    /// <summary>
    /// Summary description for ApplicationControls.
    /// </summary>
    public class WinFormControls
    {
        public WinFormControls()
        {
            //
            // TODO: Add constructor logic here
            //

        }

        #region Public Interfaces
        public enum eTAT_CA
        {
            YES,
            NO
        }

        public enum eLOAI_TU_DIEN
        {
            TRANG_THAI_DAT
                ,
            TRANG_THAI_NHA
                ,
            TRANG_THAI_OTO
                ,
            TRANG_THAI_TAI_SAN_KHAC
                ,
            LOAI_HINH_DON_VI
                ,
            PHAN_LOAI_TAI_SAN
                ,
            LOAI_BAO_CAO
                ,
            TINH_TRANG_TAI_SAN
                , LY_DO_TANG_GIAM_TS
        }

        public enum eLOAI_TANG_GIAM_TAI_SAN
        {
            TANG_TAI_SAN
            , GIAM_TAI_SAN
        }


        #endregion
    }
}
