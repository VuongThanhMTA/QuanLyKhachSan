USE QuanLyKhachSan
GO 
ALTER TABLE dbo.PhieuDichVu ADD TongTien INT 
ALTER TABLE dbo.Phong ADD Gia INT


--loại phòng
GO 
INSERT dbo.LoaiPhong( MaLoaiPhong, LoaiPhong )
VALUES  ('LP01',N'Phòng nghỉ')

INSERT dbo.LoaiPhong( MaLoaiPhong, LoaiPhong )
VALUES  ('LP02',N'Phòng Ăn')

GO 
ALTER  PROC SP_LoaiPhongSelectAll 
AS
BEGIN
	SELECT *FROM dbo.LoaiPhong
END 

GO 
ALTER  PROC SP_ThemLoaiPhong @MaLoaiPhong VARCHAR(5), @TenLP NVARCHAR(50)
AS
BEGIN 
	INSERT dbo.LoaiPhong( MaLoaiPhong, LoaiPhong )
	VALUES  ( @MaLoaiPhong,@TenLP)
END 

GO
ALTER PROC SP_SuaLoaiPhong @MaLoaiPhong VARCHAR(5), @TenLP NVARCHAR(50)
AS
BEGIN 
		UPDATE dbo.LoaiPhong SET LoaiPhong = @TenLP
		WHERE MaLoaiPhong = @MaLoaiPhong
END 

GO 
ALTER PROC  SP_XoaLoaiPhong @MaLoaiPhong VARCHAR(5)
AS
BEGIN
	DELETE dbo.LoaiPhong WHERE MaLoaiPhong = @MaLoaiPhong
END 

---Hóa đơn

GO 
ALTER PROC  SP_HoaDonSelectAll
AS
BEGIN
	SELECT *FROM dbo.HoaDon
END 

GO 
ALTER PROC SP_ThemHoaDon (@MaHD VARCHAR(5), @MaNV VARCHAR(5),@MaPhieuDK VARCHAR(5), @NgayThanhToan DATE)
AS
BEGIN
	DECLARE @TongTien INT 
	SELECT @TongTien = SUM(TongTien)  FROM  dbo.PhieuDichVu dv WHERE dv.MaPhieuDK = @MaPhieuDK

	INSERT dbo.HoaDon( MaHD , MaPhieuDK ,MaNV ,NgayThanhToan ,TongTien)
	VALUES  (@MaHD,@MaPhieuDK,@MaNV,@NgayThanhToan,@TongTien)
END

GO 
ALTER  PROC SP_SuaHoaDon @MaHD VARCHAR(5), @MaNV VARCHAR(5),@MaPhieuDK VARCHAR(5), @NgayThanhToan DATE,@TongTien INT
AS
BEGIN
	UPDATE dbo.HoaDon SET MaPhieuDK = @MaPhieuDK,MaNV = @MaNV,NgayThanhToan= @NgayThanhToan, TongTien = @TongTien
	WHERE MaHD = @MaHD
END 

GO 
ALTER PROC SP_XoaHoaDon @MaHD VARCHAR(5)
AS
BEGIN 
	DELETE dbo.HoaDon WHERE MaHD =@MaHD
END 

--PHÒNG

GO 
ALTER PROC SP_PhongSelectAll
AS
BEGIN
	SELECT *FROM dbo.Phong
END

GO 
ALTER PROC SP_XoaPhong @MaPhong VARCHAR(5)
AS
BEGIN 
	DELETE dbo.Phong WHERE MaPhong = @MaPhong
END

GO 
ALTER PROC XemPhong 
AS
BEGIN
	SELECT p.MaPhong,lp.LoaiPhong,p.TenPhong,p.TrangThai,p.Gia
	FROM dbo.Phong p  INNER JOIN dbo.LoaiPhong lp ON lp.MaLoaiPhong = p.MaLoaiPhong
END 




-- sua thu tuc 

GO
ALTER PROC SP_ThemPhong @MaPhong VARCHAR(5), @TenPhong NVARCHAR(50), @MaLoaiPhong VARCHAR(5), @TrangThai NVARCHAR(50), @Gia INT 
AS
BEGIN 
	INSERT dbo.Phong( MaPhong ,TenPhong ,MaLoaiPhong ,TrangThai,Gia)
	VALUES  (@MaPhong,@TenPhong,@MaLoaiPhong,@TrangThai,@Gia)
END

GO 
ALTER  PROC SP_SuaPhong @MaPhong VARCHAR(5), @TenPhong NVARCHAR(50), @MaLoaiPhong VARCHAR(5), @TrangThai NVARCHAR(50), @Gia INT 
AS
BEGIN 
	UPDATE dbo.Phong SET TenPhong = @TenPhong, MaLoaiPhong = @MaLoaiPhong, TrangThai = @TrangThai, Gia = @Gia
	WHERE MaPhong = @MaPhong
END

GO 
CREATE PROC SP_DanhSachPhieuDangKy 
AS
BEGIN
	SELECT pdk.MaPhieuDK, kh.TenKH,p.TenPhong,nv.TenNV,pdk.NgayLap,pdk.TienCoc
	FROM dbo.PhieuDangKy pdk INNER JOIN dbo.KhachHang kh ON kh.MaKH = pdk.MaKH INNER JOIN dbo.Phong p ON p.MaPhong = pdk.MaPhong INNER JOIN dbo.NhanVien nv ON nv.MaNV = pdk.MaNV
END

GO 
CREATE PROC SP_DanhSachDichVuSuDung @MaPhieuDK VARCHAR(10)
AS
BEGIN
	SELECT pdv.MaPhieuDK, dv.TenDV, pdv.SoLuong
	FROM dbo.PhieuDichVu pdv INNER JOIN dbo.DichVu dv ON dv.MaDV = pdv.MaDV 
	WHERE pdv.MaPhieuDK = @MaPhieuDK
END

GO 
CREATE PROC SP_DanhSachHoaDon
AS
BEGIN
	SELECT hd.MaHD, hd.MaPhieuDK,nv.TenNV,hd.NgayThanhToan,hd.TongTien
	FROM dbo.HoaDon hd INNER JOIN dbo.NhanVien nv ON nv.MaNV = hd.MaNV	
END
GO 
--- sửa thủ tục phiếu dv
ALTER PROC XemPDV
AS
BEGIN
	SELECT MaPhieuDK,TenDV,SoLuong, TongTien=(Gia*SoLuong) FROM dbo.PhieuDichVu INNER JOIN dbo.DichVu ON DichVu.MaDV = PhieuDichVu.MaDV
END
-- Thêm DV
GO
ALTER PROC ThemPDV(@MaPhieuDK VARCHAR(10), @MaDV VARCHAR(10), @SoLuong INT)
AS
BEGIN
	DECLARE @Gia INT
	SELECT @Gia = Gia FROM dbo.DichVu WHERE MaDV = @MaDV
	
	INSERT INTO dbo.PhieuDichVu
	        ( MaPhieuDK, MaDV, SoLuong,TongTien )
	VALUES  (  @MaPhieuDK,@MaDV,@SoLuong,@SoLuong*@Gia )
END
GO 
EXEC dbo.SuaPDV 'DK02','DV02','3'


-- Sửa PDV
GO
ALTER PROC SuaPDV(@MaPhieuDK VARCHAR(10), @MaDV VARCHAR(10), @SoLuong INT)
AS
BEGIN
	DECLARE @Gia INT
	SELECT @Gia = Gia FROM dbo.DichVu WHERE MaDV = @MaDV
	UPDATE dbo.PhieuDichVu
	SET SoLuong=@SoLuong , TongTien =  @SoLuong*@Gia
	WHERE MaPhieuDK=@MaPhieuDK AND MaDV=@MaDV
END
GO 