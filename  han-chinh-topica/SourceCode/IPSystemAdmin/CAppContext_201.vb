Option Explicit On 
Option Strict On

Imports IP.Core.IPCommon
Imports IP.Core.IPUserService
Imports IP.Core.IPData

'Imports eSchool.eSchoolData
'Imports eSchool.eSchoolUserService

#Region "Nhiệm vụ của Class"
'************************************************************************
'* Phục vụ lấy dữ liệu đặc trưng cho ứng dụng
'*
'************************************************************************
#End Region

Public Class CAppContext_201
    Implements IControlerControl

#Region "Variables"
    Private Shared m_us_user As US_HT_NGUOI_SU_DUNG
    Private Shared m_strRunMode As String
    Private Shared m_dsDecentralization As New DS_HT_PHAN_QUYEN_DETAIL
#End Region

#Region "Public interface"
    Public Shared Sub LoadDecentralizationByUserLogin()
        Dim v_us As New US_HT_PHAN_QUYEN_DETAIL
        m_dsDecentralization.Clear()
        v_us.FillDatasetByUserLogin(m_dsDecentralization, CAppContext_201.getCurrentUserName())
    End Sub
    Public Function CanUseControl(ByVal ip_strFormName As String, ByVal ip_strControlName As String, ByVal ip_strControlType As String) As Boolean Implements IPCommon.IControlerControl.CanUseControl
        Return Me.CanUseThisControl(ip_strFormName, ip_strControlName, ip_strControlType)
    End Function

    Public Shared Function IsHavingQuyen(ByVal i_str_ma_quyen As String) As Boolean
        Return US_HT_NGUOI_SU_DUNG.IsHavingMA_QUYEN( _
           CAppContext_201.getCurrentUserID() _
           , i_str_ma_quyen)

    End Function



    Public Shared Sub InitializeContext(ByVal i_LoginInfo As CLoginInformation_302)
        '*****************************************************************
        '* Init context 
        '* 1. các giá trị thường dùng trong hệ thống
        '* 2. load phân quyền hệ thống về 
        '* 3. Các biến môi trường khác
        '****************************************************************
        '* 1. các giá trị thường dùng trong hệ thống
        '        Debug.Assert(m_strCurrentUserName <> "")
        Try

            m_us_user = i_LoginInfo.m_us_user
            '* 2. load phân quyền hệ thống về 
            '* 3. Các biến môi trường khác
            Dim v_configReader As New System.Configuration.AppSettingsReader
            m_strRunMode = v_configReader.GetValue("RUN_MODE", IPConstants.C_StringType).ToString()
            v_configReader = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Shared Function getCurentDate() As DateTime
        '*****************************************************************
        '*  Gọi để lấy ngày hiện tại
        '***********************************************************************
        Return System.DateTime.Now.Date
    End Function

    Public Shared Function getCurrentUserName() As String
        Return m_us_user.strTEN_TRUY_CAP
    End Function

    Public Shared Function getCurrentUser() As String
        Return m_us_user.strTEN
    End Function

    Public Shared Function getCurrentUserID() As Decimal
        Return m_us_user.dcID
    End Function

    Public Shared Function getRunMode() As String
        Return m_strRunMode
    End Function

    Public Shared Function getAppPath() As String
        Return AppDomain.CurrentDomain.SetupInformation.ApplicationBase
    End Function

    Public Shared Function get_DefaultReportRootPath() As String
        Dim v_strRootPath As String
        v_strRootPath = Application.StartupPath
        'v_strRootPath += "\..\.."
        v_strRootPath += "\Reports"
        Return v_strRootPath
    End Function

    Public Shared Function checkLicense() As Boolean

    End Function
#End Region


#Region "Private Methods"
    Private Shared Sub LoadDecentralization(ByVal ip_dsDecentralization As DS_HT_PHAN_QUYEN_DETAIL)
        m_dsDecentralization = ip_dsDecentralization
    End Sub

    Private Shared Function CanUseThisControl( _
                ByVal ip_strFormName As String _
                , ByVal ip_strControlName As String _
                , ByVal ip_strControlType As String) As Boolean
        If (m_dsDecentralization.HT_PHAN_QUYEN_DETAIL.Select("FORM_NAME = '" & ip_strFormName & "' AND CONTROL_NAME ='" & ip_strControlName & "'").Length > 0) Then
            Return True
        End If
        Return False
    End Function
#End Region
End Class
Public Class PHAN_QUYEN
    Public Const QLHT_NHOM_NGUOI_DUNG As String = "QLHT_nhom_nguoi_dung"
    Public Const QLHT_NGUOI_SU_DUNG As String = "QLHT_nguoi_su_dung"
    Public Const QLHT_NGAY_LAM_VIEC As String = "QLHT_ngay_lam_viec"
    Public Const QLHT_THAM_SO_HE_THONG As String = "QLHT_tham_so_he_thong"
    Public Const QLHT_THAM_SO_NHAC_VIEC As String = "QLHT_tham_so_nhac_viec"
    Public Const QLHT_LICH_SU_TRUY_CAP As String = "QLHT_lich_su_truy_cap"
    Public Const QLTD_TU_DIEN As String = "QLTD_tu_dien"
    Public Const QLDM_DON_VI_CAP_CC As String = "QLDM_don_vi_cap_cc"
    Public Const QLDM_DOT_CAP_CHUNG_CHI As String = "QLDM_dot_cap_chung_chi"
    Public Const QLDM_PHOI_CHUNG_CHI As String = "QLDM_phoi"
    Public Const QLDM_LOAI_PHOI As String = "QLDM_loai_phoi"
    Public Const QLDM_DUOI_SO_VAO_SO As String = "QLDM_duoi_so_vao_so"
    Public Const QLDM_THONG_TIN_PHOI As String = "QLDM_thong_tin_phoi"
    Public Const QLNV_NHAP_THONG_TIN_CHUNG_CC As String = "QLNV_Nhap_thong_tin_chung_cc"
    Public Const QLNV_NHAP_TT_TUNG_CHUNG_CHI As String = "QLNV_Nhap_tt_tung_chung_chi"
    Public Const QLNV_IMPORT_CHUNG_CHI As String = "QLNV_Import_chung_chi"
    Public Const QLNV_DUYET_CHUNG_CHI As String = "QLNV_Duyet_chung_chi"
    Public Const QLNV_EXPORT_BAN_MEM_CC As String = "QLNV_Export_ban_mem_cc"
    Public Const QLNV_GT_DM_GIAO_DICH As String = "QLNV_GT_dm_giao_dich"
    Public Const QLNV_GT_BAO_CAO As String = "QLNV_GT_bao_cao"
    Public Const QLNV_IMPORT_CHUNG_NHAN_CHUAN_TOPICA As String = "QLNV_Import_chung_nhan_chuan_Topica"
    Public Const QLNV_IMPORT_CHUNG_NHAN_HD_NGOAI_KHOA_HOC_TAP As String = "QLNV_Import_chung_nhan_hd_ngoai_khoa_hoc_tap"
    Public Const QLNV_CNLS_THOA_THUAN As String = "QLNV_cnls_thoa_thuan"
    Public Const QLNV_TRA_LAI As String = "QLNV_tra_lai"
    Public Const QLNV_TRA_VON As String = "QLNV_tra_von"
    Public Const BC_DANH_SACH_CHUNG_CHI As String = "BC_Danh_sach_chung_chi"
    Public Const BC_THONG_BAO_NGAY_CHOT_DANH_SACH As String = "BC_thong_bao_ngay_chot_danh_sach"
    Public Const BC_THONG_BAO_THANH_TOAN_LAI As String = "BC_thong_bao_thanh_toan_lai"
    Public Const BC_PHIEU_DE_NGHI_LAI_SUAT_KY_TIEP_THEO As String = "BC_phieu_de_nghi_lai_suat_ky_tiep_theo"
    Public Const BC_DANH_SACH_TRA_LAI As String = "BC_danh_sach_tra_lai"
    Public Const BC_DANH_SACH_NGUOI_SU_HUU_TRAI_PHIEU_IN_TIMES As String = "BC_danh_sach_nguoi_su_huu_trai_phieu_in_times"
    Public Const BC_YEU_CAU_TO_CHUC_PHAT_HANH_TRA_LAI As String = "BC_yeu_cau_to_chuc_phat_hanh_tra_lai"
    Public Const BC_LAI_SUAT_TRAI_PHIEU As String = "BC_lai_suat_trai_phieu"
    Public Const BC_CHUYEN_NHUONG As String = "BC_chuyen_nhuong"
    Public Const GIOI_THIEU As String = "Gioi_thieu"
    Public Const QUY_TRINH_CAP_CC As String = "Quy_trinh_cap_cc"
    Public Const IN_SO_SO_HUU_TRAI_PHIEU As String = "In_so_so_huu_trai_phieu"
End Class
