using System;
using System.Collections.Generic;
using System.Text;
using BCTKDS;
using System.Configuration;

namespace BCTKDS.CDBNames
{
    public class HT_CHUC_NANG
    {
        public const string ID = "ID";
        public const string TEN_CHUC_NANG = "TEN_CHUC_NANG";
        public const string URL_FORM = "URL_FORM";
        public const string TRANG_THAI_YN = "TRANG_THAI_YN";
        public const string VI_TRI = "VI_TRI";
        public const string CHUC_NANG_PARENT_ID = "CHUC_NANG_PARENT_ID";
        public const string HIEN_THI_YN = "HIEN_THI_YN";
    }
    public class HT_QUYEN_GROUP
    {
        public const string ID = "ID";
        public const string ID_USER_GROUP = "ID_USER_GROUP";
        public const string ID_QUYEN = "ID_QUYEN";
    }
    public class DM_DON_VI
    {
        public const string ID = "ID";
        public const string MA_VIET_TAT = "MA_VIET_TAT";
        public const string TEN_DAY_DU = "TEN_DAY_DU";
        public const string MA_SO_THUE = "MA_SO_THUE";
        public const string DIA_CHI = "DIA_CHI";
        public const string GHI_CHU_1 = "GHI_CHU_1";
        public const string GHI_CHU_2 = "GHI_CHU_2";
        public const string GHI_CHU_3 = "GHI_CHU_3";
        public const string TEN_DON_VI_CAP_TREN = "TEN_DON_VI_CAP_TREN";
        public const string NGUOI_QUAN_TRI = "NGUOI_QUAN_TRI";
        public const string NGUOI_DAI_DIEN = "NGUOI_DAI_DIEN";
        public const string ID_DON_VI_CAP_TREN = "ID_DON_VI_CAP_TREN";
        public const string ID_LOAI_DON_VI = "ID_LOAI_DON_VI";
    }
    public class RPT_BANG_DINH_MUC {
        public const string ID = "ID";
        public const string NOI_DUNG = "NOI_DUNG";
        public const string L8 = "L8";
        public const string NHAN_VIEN = "NHAN_VIEN";
        public const string HOC_VIEN_DANG_HOC = "HOC_VIEN_DANG_HOC";
    }

    public class V_BC_CHI_TIET_DM
    {
        public const string ID = "ID";
        public const string ID_LOAI_THONG_KE = "ID_LOAI_THONG_KE";
        public const string LOAI_TK = "LOAI_TK";
        public const string TEN_THONG_KE = "TEN_THONG_KE";
        public const string ID_LOAI_THOI_GIAN = "ID_LOAI_THOI_GIAN";
        public const string LOAI_THOI_GIAN = "LOAI_THOI_GIAN";
        public const string TU_NGAY = "TU_NGAY";
        public const string DEN_NGAY = "DEN_NGAY";
        public const string ID_PHONG_BAN = "ID_PHONG_BAN";
        public const string MA_PHONG_BAN = "MA_PHONG_BAN";
        public const string TEN_PHONG_BAN = "TEN_PHONG_BAN";
        public const string GIA_TRI_THONG_KE = "GIA_TRI_THONG_KE";
        public const string DON_GIA = "DON_GIA";
        public const string DINH_MUC = "DINH_MUC";
    }

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
    public class UT_SEQUENCES
    {
        public const string SEQ_NAME = "SEQ_NAME";
        public const string SEQ_VALUE = "SEQ_VALUE";
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
        public const decimal DA_NHAP = 21;
        public const decimal DA_DUYET = 22;
        public const decimal KHONG_DUYET = 120;
        public const decimal DA_EXPORT = 23;
    }
    public class CConstant
    {
        public static string SO_VAO_SO_DAU_TIEN = ConfigurationSettings.AppSettings["SO_VAO_SO_DAU_TIEN"].ToString();
        public static string FORMAT_SO_VAO_SO = ConfigurationSettings.AppSettings["FORMAT_SO_VAO_SO"].ToString();
        public static string PATH_CHUNG_CHI = ConfigurationSettings.AppSettings["PATH_CHUNG_CHI"].ToString();
    }
    public class V_BC_TINH_HINH_CPN_THEO_PHONG_BAN
    {
        public const string ID_PHONG_BAN = "ID_PHONG_BAN";
        public const string MA_PHONG_BAN = "MA_PHONG_BAN";
        public const string TEN_PHONG_BAN = "TEN_PHONG_BAN";
        public const string TONG_SO_BILL = "TONG_SO_BILL";
        public const string TONG_SO_TIEN = "TONG_SO_TIEN";
        public const string DINH_MUC = "DINH_MUC";
        public const string TI_LE_DA_VUOT = "TI_LE_DA_VUOT";
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
    public class V_BANG_CO_SO_DINH_MUC
    {
        public const string LOAI_DM = "LOAI_DM";
        public const string HOC_VIEN_TUYEN_MOI = "HOC_VIEN_TUYEN_MOI";
        public const string NHAN_VIEN_DON_VI = "NHAN_VIEN_DON_VI";
        public const string HOC_VIEN_DANG_HOC = "HOC_VIEN_DANG_HOC";
        public const string SD_CC = "SD_CC";
        public const string TD_DON_VI = "TD_DON_VI";
        public const string PM_DON_VI = "PM_DON_VI";
    }
    public class V_DINH_MUC_CPN_TUNG_PHONG_BAN
    {
        public const string ID = "ID";
        public const string MA_PHONG_BAN = "MA_PHONG_BAN";
        public const string TEN_PHONG_BAN = "TEN_PHONG_BAN";
        public const string DINH_MUC_GAN_NHAT = "DINH_MUC_GAN_NHAT";
    }

    public class TONG_HOP_CPN_THEO_PHONG_BAN
    {
        public const string MA_PHONG_BAN = "MA_PHONG_BAN";
        public const string TEN_PHONG_BAN = "TEN_PHONG_BAN";
        public const string NGAY_GUI = "NGAY_GUI";
        public const string SO_BILL = "SO_BILL";
        public const string NGUOI_GUI = "NGUOI_GUI";
        public const string NGUOI_NHAN = "NGUOI_NHAN";
        public const string TRANG_THAI = "TRANG_THAI";
        public const string TRONG_NUOC = "TRONG_NUOC";
        public const string NUOC_NGOAI = "NUOC_NGOAI";
        public const string GHI_CHU = "GHI_CHU";
    }
    public class V_TONG_HOP_CPN_THEO_PHONG_BAN
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
        public const string ID_PHONG_BAN = "ID_PHONG_BAN";
        public const string SO_TIEN = "SO_TIEN";
        public const string ID_TRANG_THAI = "ID_TRANG_THAI";
        public const string TRANG_THAI = "TRANG_THAI";
        public const string MA_PHONG_BAN = "MA_PHONG_BAN";
        public const string TEN_PHONG_BAN = "TEN_PHONG_BAN";
    }
    public class V_TONG_HOP_BILL_THEO_PHONG_BAN
    {
        public const string ID_PHONG_BAN = "ID_PHONG_BAN";
        public const string MA_PHONG_BAN = "MA_PHONG_BAN";
        public const string TEN_PHONG_BAN = "TEN_PHONG_BAN";
        public const string TONG_SO_BILL = "TONG_SO_BILL";
        public const string TONG_SO_TIEN = "TONG_SO_TIEN";
    }
    public class V_TONG_TIEN_BILL_THEO_PHONG_BAN
    {
        public const string ID_PHONG_BAN = "ID_PHONG_BAN";
        public const string MA_PHONG_BAN = "MA_PHONG_BAN";
        public const string TEN_PHONG_BAN = "TEN_PHONG_BAN";
        public const string TONG_SO_BILL = "TONG_SO_BILL";
        public const string TONG_SO_TIEN = "TONG_SO_TIEN";
        public const string VAT = "VAT";
        public const string TONG_TIEN_THANH_TOAN = "TONG_TIEN_THANH_TOAN";
    }
    public class V_BC_CHI_PHI_THEO_CAC_PHAP_NHAN
    {
        public const string ID_PHAP_NHAN = "ID_PHAP_NHAN";
        public const string TEN_NGAN = "TEN_NGAN";
        public const string TEN = "TEN";
        public const string TONG_SO_BILL = "TONG_SO_BILL";
        public const string TONG_SO_TIEN = "TONG_SO_TIEN";
        public const string VAT = "VAT";
        public const string TONG_CHI_PHI = "TONG_CHI_PHI";
    }

    public class V_GD_PHONG_BAN_DINH_MUC
    {
        public const string ID = "ID";
        public const string ID_PHONG_BAN = "ID_PHONG_BAN";
        public const string ID_CO_SO_DINH_MUC = "ID_CO_SO_DINH_MUC";
        public const string ID_LOAI_DINH_MUC = "ID_LOAI_DINH_MUC";
        public const string ID_DM_CO_SO = "ID_DM_CO_SO";
        public const string MA_CO_SO_DINH_MUC = "MA_CO_SO_DINH_MUC";
        public const string TEN_CO_SO_DINH_MUC = "TEN_CO_SO_DINH_MUC";
        public const string ID_LOAI_CO_SO_DINH_MUC = "ID_LOAI_CO_SO_DINH_MUC";
        public const string MA = "MA";
        public const string MO_TA = "MO_TA";
        public const string ID_LOAI_CO_SO = "ID_LOAI_CO_SO";
        public const string MA_PHONG_BAN = "MA_PHONG_BAN";
        public const string TEN_PHONG_BAN = "TEN_PHONG_BAN";
        public const string TEN_LOAI_CO_SO = "TEN_LOAI_CO_SO";
        public const string TEN_LOAI_DINH_MUC = "TEN_LOAI_DINH_MUC";
    }
    public class V_DM_PHONG_BAN_PHAP_NHAN
    {
        public const string ID = "ID";
        public const string ID_PHONG_BAN = "ID_PHONG_BAN";
        public const string ID_PHAP_NHAN = "ID_PHAP_NHAN";
        public const string TY_TRONG = "TY_TRONG";
        public const string MA_PHONG_BAN = "MA_PHONG_BAN";
        public const string TEN_PHONG_BAN = "TEN_PHONG_BAN";
        public const string MA_PHAP_NHAN = "MA_PHAP_NHAN";
        public const string TEN_PHAP_NHAN = "TEN_PHAP_NHAN";
    }
    public class DM_PHAP_NHAN
    {
        public const string ID = "ID";
        public const string MA_PHAP_NHAN = "MA_PHAP_NHAN";
        public const string TEN_PHAP_NHAN = "TEN_PHAP_NHAN";
        public const string GHI_CHU = "GHI_CHU";
    }

    public class DM_PHONG_BAN_PHAP_NHAN
    {
        public const string ID = "ID";
        public const string ID_PHONG_BAN = "ID_PHONG_BAN";
        public const string ID_PHAP_NHAN = "ID_PHAP_NHAN";
        public const string TY_TRONG = "TY_TRONG";
    }


    #region HE_THONG
    public class HT_USER_GROUP
    {
        public const string ID = "ID";
        public const string USER_GROUP_NAME = "USER_GROUP_NAME";
        public const string DESCRIPTION = "DESCRIPTION";
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
    public class HT_PHAN_QUYEN_HE_THONG
    {
        public const string ID = "ID";
        public const string MA_PHAN_QUYEN = "MA_PHAN_QUYEN";
        public const string GHI_CHU = "GHI_CHU";
        public const string LOAI_PHAN_QUYEN = "LOAI_PHAN_QUYEN";
    }
    public class HT_PHAN_QUYEN_CHO_NHOM {
        public const string ID = "ID";
        public const string ID_USER_GROUP = "ID_USER_GROUP";
        public const string ID_PHAN_QUYEN_HE_THONG = "ID_PHAN_QUYEN_HE_THONG";
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
    public class HT_NGUOI_SU_DUNG {
        public const string ID = "ID";
        public const string TEN_TRUY_CAP = "TEN_TRUY_CAP";
        public const string TEN = "TEN";
        public const string MAT_KHAU = "MAT_KHAU";
        public const string NGAY_TAO = "NGAY_TAO";
        public const string NGUOI_TAO = "NGUOI_TAO";
        public const string TRANG_THAI = "TRANG_THAI";
        public const string BUILT_IN_YN = "BUILT_IN_YN";
        public const string ID_USER_GROUP = "ID_USER_GROUP";
        public const string ID_TRAINING_PROJECT = "ID_TRAINING_PROJECT";
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
    #endregion

    #region Version1
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
    #endregion

    #region Version 2
    public class RPT_TONG_TIEN_DINH_MUC {
        public const string ID = "ID";
        public const string ID_LOAI_DINH_MUC = "ID_LOAI_DINH_MUC";
        public const string TEN_NGAN = "TEN_NGAN";
        public const string ID_PHONG_BAN = "ID_PHONG_BAN";
        public const string MA_PHONG_BAN = "MA_PHONG_BAN";
        public const string TEN_PHONG_BAN = "TEN_PHONG_BAN";
        public const string TONG_TIEN_DINH_MUC = "TONG_TIEN_DINH_MUC";
    }


    public class DM_BILL
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
        public const string ID_PHONG_BAN = "ID_PHONG_BAN";
        public const string SO_TIEN = "SO_TIEN";
        public const string ID_TRANG_THAI = "ID_TRANG_THAI";
    }
    public class V_DM_BILL
    {
        public const string ID = "ID";
        public const string NGAY_GUI = "NGAY_GUI";
        public const string SO_BILL = "SO_BILL";
        public const string ID_PHONG_BAN = "ID_PHONG_BAN";
        public const string MA_PHONG_BAN = "MA_PHONG_BAN";
        public const string TEN_PHONG_BAN = "TEN_PHONG_BAN";
        public const string NGUOI_GUI = "NGUOI_GUI";
        public const string NGUOI_NHAN = "NGUOI_NHAN";
        public const string NOI_NHAN = "NOI_NHAN";
        public const string TRONG_NUOC = "TRONG_NUOC";
        public const string NUOC_NGOAI = "NUOC_NGOAI";
        public const string NOI_DUNG = "NOI_DUNG";
        public const string GHI_CHU = "GHI_CHU";
        public const string ID_TRANG_THAI = "ID_TRANG_THAI";
        public const string TRANG_THAI_THU = "TRANG_THAI_THU";
        public const string SO_TIEN = "SO_TIEN";
    }
    public class V_DM_PHONG_BAN {
        public const string ID = "ID";
        public const string MA_PHONG_BAN = "MA_PHONG_BAN";
        public const string TEN_PHONG_BAN = "TEN_PHONG_BAN";
        public const string TEN = "TEN";
    }

    public class DM_PHONG_BAN
    {
        public const string ID = "ID";
        public const string MA_PHONG_BAN = "MA_PHONG_BAN";
        public const string TEN_PHONG_BAN = "TEN_PHONG_BAN";
    }
    public class GD_PHONG_BAN_DINH_MUC
    {
        public const string ID = "ID";
        public const string ID_PHONG_BAN = "ID_PHONG_BAN";
        public const string ID_CO_SO_DINH_MUC = "ID_CO_SO_DINH_MUC";
    }
    public class GD_DINH_MUC
    {
        public const string ID = "ID";
        public const string ID_LOAI_DINH_MUC = "ID_LOAI_DINH_MUC";
        public const string ID_CO_SO_DINH_MUC = "ID_CO_SO_DINH_MUC";
        public const string SO_TIEN_DINH_MUC = "SO_TIEN_DINH_MUC";
        public const string AP_DUNG_TU_NGAY = "AP_DUNG_TU_NGAY";
    }
    public class GD_THONG_KE
    {
        public const string ID = "ID";
        public const string ID_LOAI_THONG_KE = "ID_LOAI_THONG_KE";
        public const string TEN_THONG_KE = "TEN_THONG_KE";
        public const string ID_LOAI_THOI_GIAN = "ID_LOAI_THOI_GIAN";
        public const string TU_NGAY = "TU_NGAY";
        public const string DEN_NGAY = "DEN_NGAY";
        public const string GIA_TRI_THONG_KE = "GIA_TRI_THONG_KE";
        public const string ID_DON_VI_THONG_KE = "ID_DON_VI_THONG_KE";
        public const string ID_PHONG_BAN = "ID_PHONG_BAN";
        public const string GHI_CHU_1 = "GHI_CHU_1";
        public const string GHI_CHU_2 = "GHI_CHU_2";
        public const string GHI_CHU_3 = "GHI_CHU_3";
    }
    public class V_GD_THONG_KE
    {
        public const string ID = "ID";
        public const string ID_LOAI_THONG_KE = "ID_LOAI_THONG_KE";
        public const string LOAI_TK = "LOAI_TK";
        public const string TEN_THONG_KE = "TEN_THONG_KE";
        public const string ID_LOAI_THOI_GIAN = "ID_LOAI_THOI_GIAN";
        public const string LOAI_THOI_GIAN = "LOAI_THOI_GIAN";
        public const string TU_NGAY = "TU_NGAY";
        public const string DEN_NGAY = "DEN_NGAY";
        public const string ID_PHONG_BAN = "ID_PHONG_BAN";
        public const string MA_PHONG_BAN = "MA_PHONG_BAN";
        public const string TEN_PHONG_BAN = "TEN_PHONG_BAN";
        public const string GIA_TRI_THONG_KE = "GIA_TRI_THONG_KE";
        public const string ID_DON_VI_THONG_KE = "ID_DON_VI_THONG_KE";
        public const string DON_VI_THONG_KE = "DON_VI_THONG_KE";
        public const string GHI_CHU_1 = "GHI_CHU_1";
        public const string GHI_CHU_2 = "GHI_CHU_2";
        public const string GHI_CHU_3 = "GHI_CHU_3";
    }
    public class DM_CO_SO
    {
        public const string ID = "ID";
        public const string MA = "MA";
        public const string MO_TA = "MO_TA";
        public const string ID_LOAI_CO_SO = "ID_LOAI_CO_SO";
    }
    public class V_DM_CO_SO
    {
        public const string ID = "ID";
        public const string MA = "MA";
        public const string MO_TA = "MO_TA";
        public const string ID_LOAI_CO_SO = "ID_LOAI_CO_SO";
        public const string TEN_LOAI_CO_SO = "TEN_LOAI_CO_SO";
    }
    public class V_DM_CO_SO_DINH_MUC
    {
        public const string ID = "ID";
        public const string MA_CO_SO_DINH_MUC = "MA_CO_SO_DINH_MUC";
        public const string TEN_CO_SO_DINH_MUC = "TEN_CO_SO_DINH_MUC";
        public const string ID_LOAI_CO_SO_DINH_MUC = "ID_LOAI_CO_SO_DINH_MUC";
        public const string TEN_LOAI_CO_SO = "TEN_LOAI_CO_SO";
    }
    public class DM_CO_SO_DINH_MUC
    {
        public const string ID = "ID";
        public const string MA_CO_SO_DINH_MUC = "MA_CO_SO_DINH_MUC";
        public const string TEN_CO_SO_DINH_MUC = "TEN_CO_SO_DINH_MUC";
        public const string ID_LOAI_CO_SO_DINH_MUC = "ID_LOAI_CO_SO_DINH_MUC";
    }
    #endregion
}
