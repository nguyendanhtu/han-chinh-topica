﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BCTKUS
{
    public class ID_LOAI_VAN_THU
    {
        public const decimal CONG_VAN_DEN_KHONG_LUU = 222;
        public const decimal CONG_VAN_DI = 223;
        public const decimal CONG_VAN_DEN_LUU = 229;
    }
    public class ID_TRANG_THAI_VAN_THU
    {
        public const decimal CHO_SO_VAO_SO_DONG_DAU = 224;
        public const decimal DA_LUU_TAI_TAD = 225;
        public const decimal DA_CHUYEN_DEN_NGUOI_NHAN = 226;
        public const decimal NGUOI_NHAN_DA_NHAN_DUOC = 227;
        public const decimal DA_CHUYEN_CHO_DON_VI_BAN_HANH = 228;
    }
    public class CONST_ID_TRANG_THAI_DON_HANG
    { 
        public const decimal NHAP = 209;
        public const decimal DA_DUYET = 210;
        public const decimal XIN_TAD_DUYET = 211;
        public const decimal XIN_CC_DUYET = 212;
        public const decimal TAD_KHONG_DUYET = 213;
        public const decimal CC_KHONG_DUYET = 214;
        public const decimal XIN_TD_DUYET = 215 ;
        public const decimal TD_KHONG_DUYET = 216;
    }
    public class CONST_ID_TRANG_THAI_DON_HANG_DE
    {
        public const decimal TAD_NHAN_HANG = 217;
        public const decimal TT_NHAN_HANG = 218;
        public const decimal TT_DANG_KI_DON_HANG = 219;
    }
    public class CONST_ID_LOAI_CO_SO_DINH_MUC {
        public const decimal ID_NHAN_VIEN = 201;
        public const decimal ID_L8 = 204;
        public const decimal ID_HV_DANG_HOC = 203;
    }
    public class CONST_ID_LOAI_DINH_MUC {
        public const decimal VPP = 173;
        public const decimal CPN = 174;
        public const decimal DIENTHOAI = 206;
        public const decimal IN = 207;
        public const decimal PHOTO = 208;
    }
    public class CONST_ID_CM_DM_LOAI_TD {
        public const decimal ID_CHUC_NANG = 16;
        public const decimal ID_LOAI_DINH_MUC = 17;
        public const decimal ID_LOAI_CONG_VAN = 23;
        public const decimal ID_TRANG_THAI_VAN_THU = 22;
    }
    public class CONST_ID_CM_DM_TU_DIEN {
        public const decimal ID_VIEW = 698;
        public const decimal ID_REPORT= 699;
        public const decimal ID_EDIT = 697;
        public const decimal ID_PHAT_SINH_TRONG_KY = 171;
        public const decimal ID_PHAT_SINH_CUOi_KY= 172;
         
    }
    public class CONST_ID_TRANG_THAI_THU 
    {
        public const decimal ID_DA_NHAN_NOI_BO = 156;
        public const decimal ID_DA_CHUYEN_CPN = 158;
        public const decimal ID_BI_TRA_LAI = 161;
        public const decimal ID_NOI_BO_NHAN_TRA_LAI = 162;
        public const decimal ID_BI_TRA_LAI_MAT_PHI = -161;
        public const decimal ID_BI_TRA_LAI_KHONG_MAT_PHI = -162;
    }
    public class SESSION
    {
        public const string UserFullName = "UserFullName";
        public const string UserName = "UserName";
        public const string UserID = "UserID";

        public const string AccounLoginYN = "AccounLoginYN";
        public const string UserQuyen = "user_quyen";
        //public const string QuyenGV = "QuyenGV";
        public const string Allow2DeleteDataYN = "Allow2DeleteDataYN";
        public const string NHOM_PHAN_QUYEN = "NHOM_PHAN_QUYEN";
    }
    public class CONST_ID_DON_VI_THONG_KE
    {
        public const decimal NHAN_VIEN = 169;
        public const decimal HOC_VIEN = 168;
    }
    public class CONST_ID_CO_SO_DINH_MUC
    {
        public const decimal NV_TRUNGTAM = 1;
        public const decimal NV_DIAPHUONG = 2;
        public const decimal NV_ALL = 3;
        public const decimal DANGHOC_TRUONG = 4;
        public const decimal DANGHOC_DIAPHUONG = 5;
        public const decimal DANGHOC_ALL = 6;
        public const decimal TUYENMOI_TRUONG = 7;
        public const decimal TUYENMOI_DIAPHUONG = 8;
        public const decimal TUYENMOI_ALL = 9;
        public const decimal DANGHOC_TRUONG_DIAPHUONG = 10;
        public const decimal TUYENMOI_TRUONG_DIAPHUONG = 11;

    }

    public class CONST_ID_LOAI_CONG_VAN
    {
        public const decimal CONG_VAN_DEN = 222;
        public const decimal CONG_VAN_DEN_KHONG_LUU = 229;
        public const decimal CONG_VAN_DI = 223;
    }
}
