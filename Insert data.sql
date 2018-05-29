USE QuanLyKhachSan
GO
INSERT dbo.KhachHang
VALUES  ( 'KH01' , N'Hồ Trấn Thành' ,N'Nam' ,N'Hồ Chí Minh' ,N'0111252545' , N'0169653245' ,1985)
INSERT dbo.KhachHang
VALUES  ( 'KH02' , N'Nguyễn Việt Hương' ,N'Nữ' ,N'Hà Nội' ,N'125452568' , N'0196523564' ,1989)
INSERT dbo.KhachHang
VALUES  ( 'KH03' , N'Nguyễn Thị Phương Trinh' ,N'Nữ' ,N'Thanh Hóa' ,N'125421458' , N'0123658457' ,1990)
INSERT dbo.KhachHang
VALUES  ( 'KH04' , N'Võ Vũ Trường Giang' ,N'Nam' ,N'Hà Nội' ,N'145854254' , N'0169631258' ,1982)
INSERT dbo.KhachHang
VALUES  ( 'KH05' , N'Võ Hoài Linh' ,N'Nam' ,N'Nghệ An' ,N'1256456757' , N'09865615245' ,1986)
INSERT dbo.KhachHang
VALUES  ( 'KH06' , N'Nguyễn Xuân Bắc' ,N'Nam' ,N'Hà Nội' ,N'145487878' , N'0169854647' ,1991)
INSERT dbo.KhachHang
VALUES  ( 'KH07' , N'Đinh Mạnh Ninh' ,N'Nam' ,N'Vũng Tàu' ,N'145865898' , N'016855325' ,1991)
INSERT dbo.KhachHang
VALUES  ( 'KH08' , N'Hồ Ngọc Hà' ,N'Nữ' ,N'Thanh Hóa' ,N'145865895' , N'0986532458' ,1992)
INSERT dbo.KhachHang
VALUES  ( 'KH09' , N'Đàm Vĩnh Hưng' ,N'Nam' ,N'Hồ Chí Minh' ,N'12498789' , N'0169568675' ,1989)
INSERT dbo.KhachHang
VALUES  ( 'KH10' , N'Phan Đình Tùng' ,N'Nam' ,N'Hà Nội' ,N'4566458757' , N'0169653258' ,1985)

GO
INSERT INTO dbo.DichVu
        ( MaDV, TenDV, Gia )
VALUES  ( 'DV01', -- MaDV - varchar(10)
          N'Ăn sáng', -- TenDV - nvarchar(50)
          30000  -- Gia - bigint
          )
GO
INSERT INTO dbo.DichVu
        ( MaDV, TenDV, Gia )
VALUES  ( 'DV02', -- MaDV - varchar(10)
          N'Ăn trưa', -- TenDV - nvarchar(50)
          50000  -- Gia - bigint
          )
GO
INSERT INTO dbo.DichVu
        ( MaDV, TenDV, Gia )
VALUES  ( 'DV03', -- MaDV - varchar(10)
          N'Ăn tối', -- TenDV - nvarchar(50)
          60000  -- Gia - bigint
          )
GO
INSERT INTO dbo.DichVu
        ( MaDV, TenDV, Gia )
VALUES  ( 'DV04', -- MaDV - varchar(10)
          N'Thuê xe đạp', -- TenDV - nvarchar(50)
          30000  -- Gia - bigint
          )
GO
INSERT INTO dbo.DichVu
        ( MaDV, TenDV, Gia )
VALUES  ( 'DV05', -- MaDV - varchar(10)
          N'Thuê xe máy', -- TenDV - nvarchar(50)
          100000  -- Gia - bigint
          )
GO
INSERT INTO dbo.DichVu
        ( MaDV, TenDV, Gia )
VALUES  ( 'DV06', -- MaDV - varchar(10)
          N'Team Building', -- TenDV - nvarchar(50)
          150000  -- Gia - bigint
          )
GO
INSERT INTO dbo.DichVu
        ( MaDV, TenDV, Gia )
VALUES  ( 'DV07', -- MaDV - varchar(10)
          N'Tổ chức sinh nhật', -- TenDV - nvarchar(50)
          500000  -- Gia - bigint
          )
GO
INSERT INTO dbo.DichVu
        ( MaDV, TenDV, Gia )
VALUES  ( 'DV08', -- MaDV - varchar(10)
          N'Caffe Phim', -- TenDV - nvarchar(50)
          150000  -- Gia - bigint
          )
GO
INSERT INTO dbo.DichVu
        ( MaDV, TenDV, Gia )
VALUES  ( 'DV09', -- MaDV - varchar(10)
          N'Giải khát', -- TenDV - nvarchar(50)
          50000  -- Gia - bigint
          )
GO
INSERT INTO dbo.DichVu
        ( MaDV, TenDV, Gia )
VALUES  ( 'DV10', -- MaDV - varchar(10)
          N'Buffe', -- TenDV - nvarchar(50)
          200000  -- Gia - bigint
          )
go
INSERT INTO dbo.PhieuDichVu
        ( MaPhieuDK, MaDV, SoLuong )
VALUES  ( 'DK01', -- MaPhieuDK - varchar(10)
          'DV01', -- MaDV - varchar(10)
          2  -- SoLuong - int
          )
go
INSERT INTO dbo.PhieuDichVu
        ( MaPhieuDK, MaDV, SoLuong )
VALUES  ( 'DK01', -- MaPhieuDK - varchar(10)
          'DV02', -- MaDV - varchar(10)
          2  -- SoLuong - int
          )
go
INSERT INTO dbo.PhieuDichVu
        ( MaPhieuDK, MaDV, SoLuong )
VALUES  ( 'DK01', -- MaPhieuDK - varchar(10)
          'DV03', -- MaDV - varchar(10)
          2  -- SoLuong - int
          )
go
INSERT INTO dbo.PhieuDichVu
        ( MaPhieuDK, MaDV, SoLuong )
VALUES  ( 'DK02', -- MaPhieuDK - varchar(10)
          'DV04', -- MaDV - varchar(10)
          1  -- SoLuong - int
          )
GO
INSERT INTO dbo.PhieuDichVu
        ( MaPhieuDK, MaDV, SoLuong )
VALUES  ( 'DK02', -- MaPhieuDK - varchar(10)
          'DV06', -- MaDV - varchar(10)
          1  -- SoLuong - int
          )
GO
INSERT INTO dbo.PhieuDichVu
        ( MaPhieuDK, MaDV, SoLuong )
VALUES  ( 'DK03', -- MaPhieuDK - varchar(10)
          'DV02', -- MaDV - varchar(10)
          4  -- SoLuong - int
          )
GO
INSERT INTO dbo.PhieuDichVu
        ( MaPhieuDK, MaDV, SoLuong )
VALUES  ( 'DK03', -- MaPhieuDK - varchar(10)
          'DV03', -- MaDV - varchar(10)
          4  -- SoLuong - int
          )
GO
INSERT INTO dbo.PhieuDichVu
        ( MaPhieuDK, MaDV, SoLuong )
VALUES  ( 'DK04', -- MaPhieuDK - varchar(10)
          'DV07', -- MaDV - varchar(10)
          2 -- SoLuong - int
          )
GO
INSERT INTO dbo.PhieuDichVu
        ( MaPhieuDK, MaDV, SoLuong )
VALUES  ( 'DK04', -- MaPhieuDK - varchar(10)
          'DV02', -- MaDV - varchar(10)
          2 -- SoLuong - int
          )
GO
INSERT INTO dbo.PhieuDichVu
        ( MaPhieuDK, MaDV, SoLuong )
VALUES  ( 'DK05', -- MaPhieuDK - varchar(10)
          'DV01', -- MaDV - varchar(10)
          3 -- SoLuong - int
          )