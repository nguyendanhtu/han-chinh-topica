using System;
using System.Collections.Generic;
using System.Text;
using BCTKDS;
using System.Configuration;

namespace BCTKDS.CDBNames
{
    public class LOAI_TU_DIEN_ID
    {
        public const decimal PHAN_QUYEN = 1;
        public const decimal DUOI_SO_VAO_SO = 2;
        public const decimal TRANG_THAI_GD_CHUNG_CHI = 3;
        public const decimal FONT_FAMILY = 4;
        public const decimal FONT_STYLE = 5;
        public const decimal TRANG_THAI_DOT_CAP_CC = 8;
        public const decimal LOG_LOAI_HANH_DONG = 10;
    }
    public class DM_DON_VI_CAP_CHUNG_CHI
    {
        public const string ID = "ID";
        public const string MA_DON_VI_CAP = "MA_DON_VI_CAP";
        public const string TEN_DON_VI_CAP = "TEN_DON_VI_CAP";
        public const string ID_DV_CAP_CHA = "ID_DV_CAP_CHA";
        public const string LEVEL_TREN_CAY = "LEVEL_TREN_CAY";
        public const string LA_LA_YN = "LA_LA_YN";
        public const string SO_THU_TU = "SO_THU_TU";
    }

    public class GD_PHAN_HOI
    {
        public const string ID = "ID";
        public const string HO_VA_TEN = "HO_VA_TEN";
        public const string SO_DIEN_THOAI = "SO_DIEN_THOAI";
        public const string EMAIL = "EMAIL";
        public const string TIEU_DE = "TIEU_DE";
        public const string NOI_DUNG_PHAN_HOI = "NOI_DUNG_PHAN_HOI";
        public const string THOI_GIAN_PHAN_HOI = "THOI_GIAN_PHAN_HOI";
        public const string GHI_CHU = "GHI_CHU";
    }
    public class THONG_BAO
    {
        public const int ER_DU_LIEU_CAN_CAP_NHAT = 1;
        public const int ER_KHONG_CO_QUYEN_SU_DUNG = 5;
        public const int ER_CON_CHUNG_CHI_CHUA_DUYET = 11;
        public const int SC_XUAT_CHUNG_CHI = 30;
        public const int SC_DUYET_TOAN_BO_CHUNG_CHI = 13;
        public const int SC_CAP_NHAT = 15;
        public const int SC_DUYET_CHUNG_CHI = 16;
        public const int SC_DUYET_TT_CHUNG = 17;
        public const int SC_THEM_THONG_TIN = 31;
        public const int SC_THEM_PHOI = 32;
        public const int SC_SUA_PHOI = 33;
        public const int SC_DUYET_PHOI = 21;
        public const int ER_GHI_LOG_HE_THONG = 22;
        public const int SC_THEM_THONG_TIN_PHOI = 23;
        public const int SC_SUA_THONG_TIN_PHOI = 24;
        public const int SC_DUYET_THONG_TIN_PHOI = 25;
        public const int SC_THEM_DOT_CAP = 26;
        public const int SC_SUA_DOT_CAP = 27;
        public const int SC_DUYET_DOT_CAP = 28;
        public const int SC_CAP_NHAT_TT_CHUNG = 29;
        public const int CF_XUAT_TIEP_BAN_MEM = 34;
        public const int CF_XUAT_CHUNG_CHI_RA_BAN_MEM = 35;
        public const int ER_DU_LIEU_TREN_LUOI_KO_DC_TRONG = 36;
        public const int SC_LOAD_FILE_EXCEL = 37;
        public const int ER_COT_STT_DE_TRONG = 38;
        public const int ER_CHUA_LOAD_FILE_EXCEL = 39;
        public const int SC_KIEM_TRA_DU_LIEU = 40;
        public const int ER_TON_TAI_DL_KO_HOP_LE = 41;
        public const int ER_CHUA_NHAP_DU_TT_CHUNG = 42;
    }
    public class TD_TRANG_THAI_CHUNG_CHI
    {
        public const decimal DA_NHAP= 21;
        public const decimal DA_DUYET= 22;
        public const decimal KHONG_DUYET = 120;
        public const decimal DA_EXPORT= 23;
    }
    public class TD_TRANG_THAI_DOT_CAP
    {
        public const decimal DA_TAO_DOT = 97;
        public const decimal DA_XUAT_ANH = 102;
        public const decimal DA_KET_THUC = 103;
    }

    public class HT_PHAN_QUYEN_HE_THONG
    {
        public const string ID = "ID";
        public const string MA_PHAN_QUYEN = "MA_PHAN_QUYEN";
        public const string GHI_CHU = "GHI_CHU";
        public const string LOAI_PHAN_QUYEN = "LOAI_PHAN_QUYEN";
    }
    public class HT_PHAN_QUYEN_CHO_NHOM
    {
        public const string ID = "ID";
        public const string ID_NHOM_NGUOI_SU_DUNG = "ID_NHOM_NGUOI_SU_DUNG";
        public const string ID_PHAN_QUYEN_HE_THONG = "ID_PHAN_QUYEN_HE_THONG";
    }
    public class DM_CHUNG_CHI_CHUAN_TOPICA_OLD_DATA_IMP
    {
        public const string ID = "ID";
        public const string STT = "STT";
        public const string SO_VAO_SO = "SO_VAO_SO";
        public const string TA_HO_TEN = "TA_HO_TEN";
        public const string TA_NGAY_SINH = "TA_NGAY_SINH";
        public const string TA_NOI_SINH = "TA_NOI_SINH";
        public const string TV_HO_TEN = "TV_HO_TEN";
        public const string TV_NGAY_SINH = "TV_NGAY_SINH";
        public const string TV_NOI_SINH = "TV_NOI_SINH";
        public const string TRANG_THAI = "TRANG_THAI";
        public const string DIEN_GIAI = "DIEN_GIAI";
    }
    public class DM_CHUNG_CHI_OLD_DATA_IMP
    {
        public const string ID = "ID";
        public const string STT = "STT";
        public const string SO_VAO_SO = "SO_VAO_SO";
        public const string HO_VA_TEN = "HO_VA_TEN";
        public const string LOP = "LOP";
        public const string DAT_THANH_TICH = "DAT_THANH_TICH";
        public const string NAM_HOC = "NAM_HOC";
        public const string TRANG_THAI = "TRANG_THAI";
        public const string DIEN_GIAI = "DIEN_GIAI";
    }
    public class HT_NHOM_NGUOI_SU_DUNG
    {
        public const string ID = "ID";
        public const string MA_NHOM = "MA_NHOM";
        public const string GHI_CHU = "GHI_CHU";
        public const string TRANG_THAI_NHOM = "TRANG_THAI_NHOM";
        public const string ID_INPUTED_BY = "ID_INPUTED_BY";
        public const string INPUTED_DATE = "INPUTED_DATE";
        public const string ID_LAST_UPDATED_BY = "ID_LAST_UPDATED_BY";
        public const string LAS_UPDATED_DATE = "LAS_UPDATED_DATE";
    }

    public class LOG_DOI_TUONG_TAC_DONG
    {
        public const string DANG_NHAP_XUAT = "";
        public const string DM_TU_DIEN = "Danh mục từ điển";
        public const string HT_NGUOI_SU_DUNG = "Người sử dụng";
        public const string HT_THAM_SO_HE_THONG = "Tham số hệ thống";
        public const string HT_NHOM_NGUOI_SU_DUNG = "Nhóm người dùng";
        public const string DM_DOT_CAP_CC = "Danh mục đợt cấp chứng chỉ";
        public const string DM_DON_VI_CAP_CC = "Danh mục đơn vị cấp chứng chỉ";
        public const string DM_PHOI_CHUNG_CHI = "Danh mục phôi chứng chỉ";
    }
    public class TRANG_THAI_DANH_MUC
    {
        public const decimal DA_LAP = 60;
        public const decimal DA_DUYET = 61;
        public const decimal DA_DONG = 68;
    }
    public class V_DM_DOT_CAP_CHUNG_CHI
    {
        public const string ID = "ID";
        public const string MA_DOT_CAP = "MA_DOT_CAP";
        public const string TEN_DOT_CAP = "TEN_DOT_CAP";
        public const string ID_DM_PHOI = "ID_DM_PHOI";
        public const string TEN_PHOI = "TEN_PHOI";
        public const string URL_ANH_PHOI = "URL_ANH_PHOI";
        public const string NGAY_CAP_DU_KIEN = "NGAY_CAP_DU_KIEN";
        public const string PUBLIC_YN = "PUBLIC_YN";
        public const string ID_TRANG_THAI_DOT_CAP = "ID_TRANG_THAI_DOT_CAP";
        public const string TRANG_THAI_DOT_CAP = "TRANG_THAI_DOT_CAP";
        public const string ID_NGUOI_TAO = "ID_NGUOI_TAO";
        public const string NGUOI_TAO = "NGUOI_TAO";
        public const string NGAY_TAO = "NGAY_TAO";
        public const string ID_NGUOI_CAP_NHAT = "ID_NGUOI_CAP_NHAT";
        public const string NGUOI_CAP_NHAT = "NGUOI_CAP_NHAT";
        public const string NGAY_CAP_NHAT = "NGAY_CAP_NHAT";
        public const string GHI_CHU = "GHI_CHU";
    }
    public class V_DM_DON_VI_CAP_LOAI_PHOI_VA_PHOI
    {
        public const string ID = "ID";
        public const string MA_LOAI = "MA_LOAI";
        public const string TEN_LOAI = "TEN_LOAI";
        public const string ID_CHA = "ID_CHA";
        public const string URL_ANH = "URL_ANH";
        public const string LEVEL_TREN_CAY = "LEVEL_TREN_CAY";
        public const string LA_LA_YN = "LA_LA_YN";
        public const string DON_VI_CAP_YN = "DON_VI_CAP_YN";
        public const string LOAI_PHOI_YN = "LOAI_PHOI_YN";
    }
    public class V_DM_PHOI_CHUNG_CHI
    {
        public const string ID = "ID";
        public const string MA_PHOI = "MA_PHOI";
        public const string TEN_PHOI = "TEN_PHOI";
        public const string URL_ANH_PHOI = "URL_ANH_PHOI";
        public const string ID_LOAI_PHOI = "ID_LOAI_PHOI";
        public const string TEN_LOAI_PHOI = "TEN_LOAI_PHOI";
        public const string SIZE_WIDTH = "SIZE_WIDTH";
        public const string SIZE_HEIGHT = "SIZE_HEIGHT";
        public const string NGAY_TAO = "NGAY_TAO";
        public const string ID_NGUOI_TAO = "ID_NGUOI_TAO";
        public const string NGUOI_TAO = "NGUOI_TAO";
        public const string NGAY_CAP_NHAT = "NGAY_CAP_NHAT";
        public const string ID_NGUOI_CAP_NHAT = "ID_NGUOI_CAP_NHAT";
        public const string NGUOI_CAP_NHAT = "NGUOI_CAP_NHAT";
        public const string ID_DUOI_PHOI = "ID_DUOI_PHOI";
        public const string DUOI_PHOI = "DUOI_PHOI";
    }
    public class V_DM_LOAI_PHOI_CHUNG_CHI
    {
        public const string ID = "ID";
        public const string TEN_LOAI_PHOI_CHUNG_CHI = "TEN_LOAI_PHOI_CHUNG_CHI";
        public const string MA_LOAI_PHOI_CHUNG_CHI = "MA_LOAI_PHOI_CHUNG_CHI";
        public const string ID_DON_VI_CAP = "ID_DON_VI_CAP";
        public const string TEN_DON_VI_CAP = "TEN_DON_VI_CAP";
        public const string GHI_CHU = "GHI_CHU";
    }
    public class V_DM_THONG_TIN_PHOI
    {
        public const string ID = "ID";
        public const string ID_DM_PHOI = "ID_DM_PHOI";
        public const string TEN_PHOI = "TEN_PHOI";
        public const string MA_THONG_TIN = "MA_THONG_TIN";
        public const string TEN_THONG_TIN = "TEN_THONG_TIN";
        public const string THONG_TIN_DEMO = "THONG_TIN_DEMO";
        public const string THONG_TIN_CHUNG_YN = "THONG_TIN_CHUNG_YN";
        public const string SO_VAO_SO_YN = "SO_VAO_SO_YN";
        public const string CENTER_YN = "CENTER_YN";
        public const string X1_POSITION = "X1_POSITION";
        public const string Y1_POSITION = "Y1_POSITION";
        public const string X2_POSITION = "X2_POSITION";
        public const string Y2_POSITION = "Y2_POSITION";
        public const string FONT_FAMILY = "FONT_FAMILY";
        public const string FONT_SIZE = "FONT_SIZE";
        public const string FONT_STYLE = "FONT_STYLE";
        public const string FONT_COLOR = "FONT_COLOR";
        public const string ID_NGUOI_TAO = "ID_NGUOI_TAO";
        public const string NGUOI_TAO = "NGUOI_TAO";
        public const string NGAY_TAO = "NGAY_TAO";
        public const string ID_NGUOI_CAP_NHAT = "ID_NGUOI_CAP_NHAT";
        public const string NGUOI_CAP_NHAT = "NGUOI_CAP_NHAT";
        public const string NGAY_CAP_NHAT = "NGAY_CAP_NHAT";
    }
    public class V_GD_CHUNG_CHI
    {
        public const string ID = "ID";
        public const string ID_DOT_CAP = "ID_DOT_CAP";
        public const string TEN_DOT_CAP = "TEN_DOT_CAP";
        public const string TEN_PHOI = "TEN_PHOI";
        public const string URL_ANH_PHOI = "URL_ANH_PHOI";
        public const string SO_VAO_SO = "SO_VAO_SO";
        public const string NGUOI_NHAN_CC = "NGUOI_NHAN_CC";
        public const string CMND_DKKD = "CMND_DKKD";
        public const string ID_TRANG_THAI_CC = "ID_TRANG_THAI_CC";
        public const string TRANG_THAI_CHUNG_CHI = "TRANG_THAI_CHUNG_CHI";
        public const string ID_NGUOI_TAO = "ID_NGUOI_TAO";
        public const string NGUOI_TAO = "NGUOI_TAO";
        public const string NGAY_TAO = "NGAY_TAO";
        public const string ID_NGUOI_DUYET = "ID_NGUOI_DUYET";
        public const string NGUOI_DUYET = "NGUOI_DUYET";
        public const string NGAY_DUYET = "NGAY_DUYET";
        public const string GHI_CHU = "GHI_CHU";
    }

    public class V_GD_CHUNG_CHI_DETAIL
    {
        public const string ID = "ID";
        public const string ID_CHUNG_CHI = "ID_CHUNG_CHI";
        public const string MA_TRUONG_THONG_TIN = "MA_TRUONG_THONG_TIN";
        public const string TEN_TRUONG_THONG_TIN = "TEN_TRUONG_THONG_TIN";
        public const string THONG_TIN_DEMO = "THONG_TIN_DEMO";
        public const string DU_LIEU_DIEN = "DU_LIEU_DIEN";
        public const string THONG_TIN_CHUNG_YN = "THONG_TIN_CHUNG_YN";
        public const string CENTER_YN = "CENTER_YN";
        public const string X1_POSITION = "X1_POSITION";
        public const string Y1_POSITION = "Y1_POSITION";
        public const string X2_POSITION = "X2_POSITION";
        public const string Y2_POSITION = "Y2_POSITION";
        public const string FONT_FAMILY = "FONT_FAMILY";
        public const string FONT_SIZE = "FONT_SIZE";
        public const string FONT_STYLE = "FONT_STYLE";
        public const string FONT_COLOR = "FONT_COLOR";
    }

    public class V_GD_THONG_TIN_CHUNG_CC
    {
        public const string ID = "ID";
        public const string ID_DOT_CAP = "ID_DOT_CAP";
        public const string MA_THONG_TIN = "MA_THONG_TIN";
        public const string TEN_THONG_TIN = "TEN_THONG_TIN";
        public const string THONG_TIN_DEMO = "THONG_TIN_DEMO";
        public const string SO_VAO_SO_YN = "SO_VAO_SO_YN";
        public const string DU_LIEU_DIEN = "DU_LIEU_DIEN";
        public const string X1_POSITION = "X1_POSITION";
        public const string Y1_POSITION = "Y1_POSITION";
        public const string FONT_FAMILY = "FONT_FAMILY";
        public const string FONT_SIZE = "FONT_SIZE";
        public const string FONT_STYLE = "FONT_STYLE";
        public const string FONT_COLOR = "FONT_COLOR";
    }

    public class DM_CHUNG_CHI_IMP
    {
        public const string ID = "ID";
        public const string STT = "STT";
        public const string HO_VA_TEN = "HO_VA_TEN";
        public const string LOP = "LOP";
        public const string DAT_THANH_TICH = "DAT_THANH_TICH";
        public const string NAM_HOC = "NAM_HOC";
        public const string TRANG_THAI = "TRANG_THAI";
        public const string DIEN_GIAI = "DIEN_GIAI";
    }
    public class DM_CHUNG_CHI_CHUAN_TOPICA_IMP
    {
        public const string ID = "ID";
        public const string STT = "STT";
        public const string TA_HO_TEN = "TA_HO_TEN";
        public const string TA_NGAY_SINH = "TA_NGAY_SINH";
        public const string TA_NOI_SINH = "TA_NOI_SINH";
        public const string TV_HO_TEN = "TV_HO_TEN";
        public const string TV_NGAY_SINH = "TV_NGAY_SINH";
        public const string TV_NOI_SINH = "TV_NOI_SINH";
        public const string TRANG_THAI = "TRANG_THAI";
        public const string DIEN_GIAI = "DIEN_GIAI";
    }
    public class RPT_LOC_CHUNG_CHI
    {
        public const string ID = "ID";
        public const string NGUOI_NHAN_CC = "NGUOI_NHAN_CC";
        public const string SO_VAO_SO = "SO_VAO_SO";
        public const string TEN_TRUONG_THONG_TIN = "TEN_TRUONG_THONG_TIN";
        public const string DU_LIEU_DIEN = "DU_LIEU_DIEN";
    }
    public class RPT_PORTAL_TRUY_VAN_CHUNG_CHI
    {
        public const string ID = "ID";
        public const string NGUOI_NHAN_CHUNG_CHI = "NGUOI_NHAN_CHUNG_CHI";
        public const string SO_VAO_SO = "SO_VAO_SO";
        public const string NGAY_CAP = "NGAY_CAP";
        public const string DON_VI_CAP = "DON_VI_CAP";
    }

    public class LOG_TRUY_CAP
    {
        public const decimal DANG_NHAP = 69;
        public const decimal DANG_XUAT = 70;
        public const decimal THEM = 71;
        public const decimal SUA = 72;
        public const decimal XOA = 73;
        public const decimal DUYET = 74;
        public const decimal IMPORT = 80;
        public const decimal CAP_NHAT_LS_THONG_THUONG = 90;
        public const decimal CAP_NHAT_LS_THOA_THUAN = 91;
        public const decimal SINH_LICH_TT_LAI_GOC = 92;
        public const decimal SINH_DS_TRA_LAI = 93;
        public const decimal TRA_LAI = 94;
        public const decimal TRA_GOC = 95;
    }
    public class LOAI_TU_DIEN_TEXT
    {
        public const string PHAN_QUYEN = "PHAN_QUYEN";
        public const string DUOI_SO_VAO_SO = "DUOI_SO_VAO_SO";
        public const string TRANG_THAI_GD_CHUNG_CHI = "TRANG_THAI_GD_CHUNG_CHI";
        public const string TRANG_THAI_DOT_CAP_CC = "TRANG_THAI_DOT_CAP_CC";
        public const string LOG_LOAI_HANH_DONG = "LOG_LOAI_HANH_DONG";
        public const string FONT_FAMILY = "FONT_FAMILY";
        public const string FONT_STYLE = "FONT_STYLE";
    }
    public class CM_DM_LOAI_TD
    {
        public const string ID = "ID";
        public const string MA_LOAI = "MA_LOAI";
        public const string TEN_LOAI = "TEN_LOAI";
    }
    public class CM_DM_TU_DIEN
    {
        public const string ID = "ID";
        public const string MA_TU_DIEN = "MA_TU_DIEN";
        public const string ID_LOAI_TU_DIEN = "ID_LOAI_TU_DIEN";
        public const string TEN_NGAN = "TEN_NGAN";
        public const string TEN = "TEN";
        public const string GHI_CHU = "GHI_CHU";
    }
    public class DM_COMPANY_INFO
    {
        public const string ID = "ID";
        public const string SHORT_NAME = "SHORT_NAME";
        public const string FULL_NAME = "FULL_NAME";
        public const string ADDRESS = "ADDRESS";
        public const string MOBLIE = "MOBLIE";
        public const string EMAIL = "EMAIL";
        public const string TAX_CODE = "TAX_CODE";
    }
    public class DOC_COLUMN_COMMENT
    {
        public const string COLUMN_NAME = "COLUMN_NAME";
        public const string TABLE_NAME = "TABLE_NAME";
        public const string COLUMN_COMMENT = "COLUMN_COMMENT";
    }
    public class DOC_TABLE_COMMENT
    {
        public const string TABLE_NAME = "TABLE_NAME";
        public const string TABLE_COMMENT = "TABLE_COMMENT";
    }

    public class HT_BACKUP_HISTORY
    {
        public const string ID = "ID";
        public const string NGUOI_BACKUP = "NGUOI_BACKUP";
        public const string NGAY_BACKUP = "NGAY_BACKUP";
        public const string NOI_LUU = "NOI_LUU";
        public const string TEN_FILE = "TEN_FILE";
        public const string GhI_CHU = "GhI_CHU";
    }
    public class HT_BUSINESS_PROCESS_LOCK
    {
        public const string LOCK_NAME = "LOCK_NAME";
        public const string GRANTED_SYS_DATETIME = "GRANTED_SYS_DATETIME";
    }
    public class HT_NGUOI_SU_DUNG
    {
        public const string ID = "ID";
        public const string TEN_TRUY_CAP = "TEN_TRUY_CAP";
        public const string TEN = "TEN";
        public const string MAT_KHAU = "MAT_KHAU";
        public const string NGAY_TAO = "NGAY_TAO";
        public const string NGUOI_TAO = "NGUOI_TAO";
        public const string TRANG_THAI = "TRANG_THAI";
        public const string BUILT_IN_YN = "BUILT_IN_YN";
    }
    public class HT_QUYEN_USER
    {
        public const string ID = "ID";
        public const string ID_USER = "ID_USER";
        public const string ID_QUYEN = "ID_QUYEN";
    }
    public class HT_THAM_SO_HE_THONG
    {
        public const string ID = "ID";
        public const string LOAI_THAM_SO = "LOAI_THAM_SO";
        public const string MA_THAM_SO = "MA_THAM_SO";
        public const string PHAN_HE = "PHAN_HE";
        public const string GHI_CHU = "GHI_CHU";
        public const string KIEU_DU_LIEU = "KIEU_DU_LIEU";
        public const string GIA_TRI = "GIA_TRI";
        public const string CO_THE_NULL_YN = "CO_THE_NULL_YN";
    }
    public class RPT_NHAC_VIEC
    {
        public const string ID = "ID";
        public const string ID_NGUOI_XEM = "ID_NGUOI_XEM";
        public const string NGAY = "NGAY";
        public const string TEN_TRAI_PHIEU = "TEN_TRAI_PHIEU";
        public const string NOI_DUNG_NHAC = "NOI_DUNG_NHAC";
    }
    public class UT_SEQUENCES
    {
        public const string SEQ_NAME = "SEQ_NAME";
        public const string SEQ_VALUE = "SEQ_VALUE";
    }
    public class V_HT_LOG_TRUY_CAP
    {
        public const string ID = "ID";
        public const string ID_DANG_NHAP = "ID_DANG_NHAP";
        public const string TEN_TRUY_CAP = "TEN_TRUY_CAP";
        public const string TEN = "TEN";
        public const string THOI_GIAN = "THOI_GIAN";
        public const string ID_LOAI_HANH_DONG = "ID_LOAI_HANH_DONG";
        public const string LOAI_HANH_DONG = "LOAI_HANH_DONG";
        public const string DOI_TUONG_THAO_TAC = "DOI_TUONG_THAO_TAC";
        public const string MO_TA = "MO_TA";
        public const string GHI_CHU = "GHI_CHU";
    }

    public class CConstant
    {
        public static string SO_VAO_SO_DAU_TIEN = ConfigurationSettings.AppSettings["SO_VAO_SO_DAU_TIEN"].ToString();
        public static string FORMAT_SO_VAO_SO = ConfigurationSettings.AppSettings["FORMAT_SO_VAO_SO"].ToString();
        public static string PATH_CHUNG_CHI = ConfigurationSettings.AppSettings["PATH_CHUNG_CHI"].ToString();
    }
    public class CM_DM_DANG_KY_GUI
    {
        public const string ID = "ID";
        public const string NOI_DUNG = "NOI_DUNG";
        public const string NOI_NHAN = "NOI_NHAN";
        public const string NGUOI_NHAN = "NGUOI_NHAN";
        public const string TRONG_NUOC = "TRONG_NUOC";
        public const string NUOC_NGOAI = "NUOC_NGOAI";
        public const string SO_BILL = "SO_BILL";
        public const string NGUOI_GUI = "NGUOI_GUI";
        public const string NGAY_GUI = "NGAY_GUI";
        public const string GHI_CHU = "GHI_CHU";
        public const string PHONG_BAN_ID = "PHONG_BAN_ID";
        public const string SO_TIEN = "SO_TIEN";
    }
    public class V_CM_DM_DANG_KY_GUI
    {
        public const string ID = "ID";
        public const string NOI_DUNG = "NOI_DUNG";
        public const string NOI_NHAN = "NOI_NHAN";
        public const string NGUOI_NHAN = "NGUOI_NHAN";
        public const string TRONG_NUOC = "TRONG_NUOC";
        public const string NUOC_NGOAI = "NUOC_NGOAI";
        public const string SO_BILL = "SO_BILL";
        public const string NGUOI_GUI = "NGUOI_GUI";
        public const string NGAY_GUI = "NGAY_GUI";
        public const string GHI_CHU = "GHI_CHU";
        public const string MA_PHONG_BAN = "MA_PHONG_BAN";
        public const string TEN_PHONG_BAN = "TEN_PHONG_BAN";
        public const string SO_TIEN = "SO_TIEN";
        public const string PHONG_BAN_ID = "PHONG_BAN_ID";
    }
    public class CM_DM_BANG_CHI_TIET_CUOI_THANG
    {
        public const string ID = "ID";
        public const string STT = "STT";
        public const string NGAY = "NGAY";
        public const string LOAI = "LOAI";
        public const string BARCODE = "BARCODE";
        public const string NOIDEN = "NOIDEN";
        public const string TRLUONG = "TRLUONG";
        public const string CUOC = "CUOC";
        public const string PHI = "PHI";
        public const string PHIXD = "PHIXD";
        public const string TIENCK = "TIENCK";
        public const string PHIHK = "PHIHK";
        public const string TIEN = "TIEN";
        public const string GHICHU = "GHICHU";
        public const string TRANG_THAI = "TRANG_THAI";
        public const string DIEN_GIAI = "DIEN_GIAI";
    }
    public class CM_DM_TONG_HOP_TIEN_CHUYEN_PHAT_NHANH
    {
        public const string PHONG_BAN_ID = "PHONG_BAN_ID";
        public const string MA_PHONG_BAN = "MA_PHONG_BAN";
        public const string TEN_PHONG_BAN = "TEN_PHONG_BAN";
        public const string TONG_SO_TIEN = "TONG_SO_TIEN";
        public const string VAT = "VAT";
        public const string THANH_TIEN = "THANH_TIEN";
    }
    public class CM_DM_DANG_KY_GUI_DANH_SACH_TUNG_PHONG
    {
        public const string STT = "STT";
        public const string NOI_DUNG = "NOI_DUNG";
        public const string NOI_NHAN = "NOI_NHAN";
        public const string NGUOI_NHAN = "NGUOI_NHAN";
        public const string TRONG_NUOC = "TRONG_NUOC";
        public const string NUOC_NGOAI = "NUOC_NGOAI";
        public const string SO_BILL = "SO_BILL";
        public const string NGUOI_GUI = "NGUOI_GUI";
        public const string NGAY_GUI = "NGAY_GUI";
        public const string GHI_CHU = "GHI_CHU";
        public const string MA_PHONG_BAN = "MA_PHONG_BAN";
    }
  
}
