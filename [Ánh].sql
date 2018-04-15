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