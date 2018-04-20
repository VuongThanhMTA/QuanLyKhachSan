USE QuanLyKhachSan
GO
---Them NV
CREATE PROC ThemNhanVien (@MaNV VARCHAR(10),@TenNV NVARCHAR(50),@NgaySinh DATE,@GioiTinh NVARCHAR(5),@DiaChi NVARCHAR(50),@luong INT,@CMTND VARCHAR(15),@SDT VARCHAR(15))
AS
BEGIN
INSERT INTO dbo.NhanVien
        ( MaNV ,
          TenNV ,
          GioiTinh ,
          NgaySinh ,
          DiaChi ,
          CMND ,
          SDT,
		  Luong
        )
VALUES  (@MaNV,@TenNV,@GioiTinh,@NgaySinh,@DiaChi,@CMTND,@SDT,@luong )
END 
GO
---Sua NV
CREATE PROC SuaNhanVien (@MaNV VARCHAR(10),@TenNV NVARCHAR(50),@NgaySinh DATE,@GioiTinh NVARCHAR(5),@DiaChi NVARCHAR(50),@luong INT,@CMTND VARCHAR(15),@SDT VARCHAR(15))
AS
BEGIN
UPDATE dbo.NhanVien
SET TenNV = @TenNV,GioiTinh = @GioiTinh,NgaySinh = @NgaySinh,DiaChi = @DiaChi,CMND =@CMTND,SDT = @SDT,Luong = @luong
WHERE MaNV =@MaNV
END
GO
---Xoa NV
CREATE PROC XoaNhanVien (@Ma varchar(10))
AS
BEGIN
DELETE dbo.NhanVien WHERE MaNV = @Ma
END

go
CREATE PROC NhanVien_SelectAll
AS
BEGIN
SELECT * FROM dbo.NhanVien
END