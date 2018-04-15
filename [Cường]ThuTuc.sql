USE QuanLyKhachSan

GO
CREATE PROC Xem_KH
AS
BEGIN
	SELECT * FROM dbo.KhachHang
end

GO
CREATE PROC Them_KH(@makh VARCHAR(10),@tenkh NVARCHAR(30),@gioitinh NVARCHAR(5),@namsinh INT,@diachi NVARCHAR(50),@cmnd VARCHAR(15),@sdt VARCHAR(12))
AS
BEGIN
INSERT dbo.KhachHang(MaKH,TenKH,GioiTinh,NamSinh,DiaChi,CMND,SDT)
VALUES(@makh,@tenkh,@gioitinh,@namsinh,@diachi,@cmnd,@sdt)
END

GO
CREATE PROC Sua_KH(@makh VARCHAR(10),@tenkh NVARCHAR(30),@gioitinh NVARCHAR(5),@namsinh INT,@diachi NVARCHAR(50),@cmnd VARCHAR(15),@sdt VARCHAR(12))
AS
BEGIN
UPDATE dbo.KhachHang SET TenKh=@tenkh,GioiTinh=@gioitinh,NamSinh=@namsinh,DiaChi=@diachi,CMND=@cmnd,SDT=@sdt
WHERE MaKH=@makh
END

GO
CREATE PROC Xoa_KH(@makh VARCHAR(10))
AS
BEGIN
DELETE dbo.KhachHang
WHERE MaKH=@makh
END

--Sửa csdl --
ALTER TABLE dbo.KhachHang 
DROP COLUMN NamSinh
ALTER TABLE dbo.KhachHang
ADD  NamSinh DATE