-- Sửa CSDL
USE QuanLyKhachSan
go
DROP TABLE dbo.PhieuDichVu
-- Thêm bảng PhieuDichVu và DichVu
GO 
CREATE TABLE DichVu(
MaDV varchar(10) PRIMARY KEY ,
TenDV nvarchar(50),
Gia bigint)

go
CREATE TABLE PhieuDichVu(
MaPhieuDK VARCHAR(10) REFERENCES dbo.PhieuDangKy(MaPhieuDK),
MaDV VARCHAR(10) REFERENCES dbo.DichVu(MaDV),
SoLuong INT,
PRIMARY KEY(MaPhieuDK, MaDV))

---- Thủ tục DỊCH VỤ
-- Xem dịch vụ
GO
CREATE PROC XemDV
AS
BEGIN
	SELECT *
	FROM dbo.DichVu
END
-- Thêm dịch vụ
GO
CREATE PROC ThemDV(@MaDV VARCHAR(10), @TenDV NVARCHAR(50),@Gia BIGINT)
AS
BEGIN
	INSERT INTO dbo.DichVu
	        ( MaDV, TenDV, Gia )
	VALUES  ( @MaDV,@TenDV,@Gia)
END
-- Sửa dịch vụ
GO
CREATE PROC SuaDV(@MaDV VARCHAR(10), @TenDV NVARCHAR(50),@Gia BIGINT)
AS
BEGIN
	UPDATE dbo.DichVu
	SET TenDV=@TenDV,Gia=@Gia
	WHERE MaDV=@MaDV
END
-- Xóa dịch vụ
GO
CREATE PROC XoaDV(@MaDV VARCHAR(10))
AS
BEGIN
	DELETE dbo.DichVu
	WHERE MaDV=@MaDV
END
------ Phiếu dịch vụ
-- Xem PDV
GO
CREATE PROC XemPDV
AS
BEGIN
	SELECT MaPhieuDK,TenDV,SoLuong, ThanhTien=(Gia*SoLuong) FROM dbo.PhieuDichVu INNER JOIN dbo.DichVu ON DichVu.MaDV = PhieuDichVu.MaDV
END
-- Thêm DV
GO
CREATE PROC ThemPDV(@MaPhieuDK VARCHAR(10), @MaDV VARCHAR(10), @SoLuong INT)
AS
BEGIN
	INSERT INTO dbo.PhieuDichVu
	        ( MaPhieuDK, MaDV, SoLuong )
	VALUES  (  @MaPhieuDK,@MaDV,@SoLuong )
END
-- Sửa PDV
GO
CREATE PROC SuaPDV(@MaPhieuDK VARCHAR(10), @MaDV VARCHAR(10), @SoLuong INT)
AS
BEGIN
	UPDATE dbo.PhieuDichVu
	SET MaDV=@MaDV,SoLuong=@SoLuong
	WHERE MaPhieuDK=@MaPhieuDK
END
-- Xóa PDV
GO
CREATE PROC XoaPDV(@MaPhieuDK VARCHAR(10), @MaDV VARCHAR(10))
AS
BEGIN
	DELETE dbo.PhieuDichVu
	WHERE MaPhieuDK=@MaPhieuDK AND MaDV=@MaDV
END
