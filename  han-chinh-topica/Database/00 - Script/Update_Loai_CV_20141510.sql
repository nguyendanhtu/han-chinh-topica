-- Thêm loại công văn đi bên ngoài --
INSERT INTO CM_DM_TU_DIEN
(
	ID,
	MA_TU_DIEN,
	ID_LOAI_TU_DIEN,
	TEN_NGAN,
	TEN,
	GHI_CHU
)
VALUES
(
	221,
	N'CONG_VAN_DI_BEN_NGOAI',
	23,
	N'Công văn đi bên ngoài',
	N'Công văn đi bên ngoài',
	NULL
)
GO

-- Update loại công văn đi nội bộ --
UPDATE CM_DM_TU_DIEN
SET
	MA_TU_DIEN = 'CONG_VAN_DI_NOI_BO',
	TEN_NGAN = N'Công văn đi nội bộ',
	TEN = N'Công văn đi nội bộ'
WHERE ID = 220
GO
SELECT * FROM CM_DM_TU_DIEN cdtd