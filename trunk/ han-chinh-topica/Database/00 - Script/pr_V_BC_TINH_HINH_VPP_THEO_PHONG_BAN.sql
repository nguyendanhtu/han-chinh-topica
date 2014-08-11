USE [ADMIN_SOFT]
GO
/****** Object:  StoredProcedure [dbo].[pr_V_BC_TINH_HINH_VPP_THEO_PHONG_BAN_search]    Script Date: 08/11/2014 13:22:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pr_V_BC_TINH_HINH_VPP_THEO_PHONG_BAN_search]
@TU_NGAY DATETIME,
@DEN_NGAY DATETIME,
@ID_TRANG_THAI NUMERIC(18,0),
@TU_KHOA NVARCHAR(250)
AS
BEGIN
	SELECT pb.MA_PHONG_BAN
		  ,pb.TEN_PHONG_BAN
		  ,pb.ID AS ID_PHONG_BAN
		  ,isnull(sl.TONG_SO_BILL,0) AS TONG_SO_BILL
		  ,isnull(st.TONG_SO_TIEN,0) AS TONG_SO_TIEN
		  ,dbo.f73_Tim_tong_dm_tung_trung_tam(pb.ID, 173, @TU_NGAY, @DEN_NGAY) AS DINH_MUC
		  ,TI_LE_DA_VUOT = CASE 
							WHEN dbo.f73_Tim_tong_dm_tung_trung_tam(pb.ID, 173, @TU_NGAY, @DEN_NGAY) != 0
									AND st.TONG_SO_TIEN != 0
									AND st.TONG_SO_TIEN > dbo.f73_Tim_tong_dm_tung_trung_tam(pb.ID, 173, @TU_NGAY, @DEN_NGAY)
								THEN (st.TONG_SO_TIEN - dbo.f73_Tim_tong_dm_tung_trung_tam(pb.ID, 173, @TU_NGAY, @DEN_NGAY))/dbo.f73_Tim_tong_dm_tung_trung_tam(pb.ID, 173, @TU_NGAY, @DEN_NGAY)
							ELSE 0
						   END
	FROM DM_PHONG_BAN pb
			LEFT JOIN	   (SELECT b.ID, SUM(a.SO_TIEN) AS TONG_SO_TIEN
							FROM DM_PHONG_BAN b LEFT JOIN DM_BILL a 
										ON a.ID_PHONG_BAN = b.ID
			         	    WHERE a.NGAY_GUI <= @DEN_NGAY AND a.NGAY_GUI >= @TU_NGAY
							GROUP BY b.ID) st 
					ON pb.ID = st.ID
							
			LEFT JOIN	   (SELECT b.ID, count(a.SO_BILL) AS TONG_SO_BILL
							FROM DM_PHONG_BAN b LEFT JOIN DM_BILL a 
										ON a.ID_PHONG_BAN = b.ID
			         	    where a.NGAY_GUI <= @DEN_NGAY AND a.NGAY_GUI >= @TU_NGAY
							GROUP BY b.ID) sl
					ON pb.ID = sl.ID
	WHERE 	(pb.MA_PHONG_BAN LIKE '%'+@TU_KHOA+'%' 
				OR pb.TEN_PHONG_BAN LIKE '%'+@TU_KHOA+'%' 
				OR @TU_KHOA IS NULL)
	ORDER BY pb.MA_PHONG_BAN
END