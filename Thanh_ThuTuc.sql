USE QuanLyKhachSan

--loại phòng
GO 
INSERT dbo.LoaiPhong( MaLoaiPhong, LoaiPhong )
VALUES  ('LP01',N'Phòng nghỉ')

INSERT dbo.LoaiPhong( MaLoaiPhong, LoaiPhong )
VALUES  ('LP02',N'Phòng Ăn')

GO 
CREATE PROC SP_LoaiPhongSelectAll 
AS
BEGIN
	SELECT *FROM dbo.LoaiPhong
END 

GO 
CREATE PROC SP_ThemLoaiPhong @MaLoaiPhong VARCHAR(5), @TenLP NVARCHAR(50)
AS
BEGIN 
	INSERT dbo.LoaiPhong( MaLoaiPhong, LoaiPhong )
	VALUES  ( @MaLoaiPhong,@TenLP)
END 

GO
CREATE PROC SP_SuaLoaiPhong @MaLoaiPhong VARCHAR(5), @TenLP NVARCHAR(50)
AS
BEGIN 
		UPDATE dbo.LoaiPhong SET LoaiPhong = @MaLoaiPhong
		WHERE MaLoaiPhong = @MaLoaiPhong
END 

GO 
CREATE PROC  SP_XoaLoaiPhong @MaLoaiPhong VARCHAR(5)
AS
BEGIN
	DELETE dbo.LoaiPhong WHERE MaLoaiPhong = @MaLoaiPhong
END 


---Hóa đơn

GO 
CREATE PROC  SP_HoaDonSelectAll
AS
BEGIN
	SELECT *FROM dbo.HoaDon
END 

GO 
ALTER PROC SP_ThemHoaDon (@MaHD VARCHAR(5), @MaNV VARCHAR(5),@MaPhieuDK VARCHAR(5), @NgayThanhToan DATE,@TongTien INT)
AS
BEGIN
	INSERT dbo.HoaDon( MaHD , MaPhieuDK ,MaNV ,NgayThanhToan ,TongTien)
	VALUES  (@MaHD,@MaPhieuDK,@MaNV,@NgayThanhToan,@TongTien)
END
 
GO 
EXEC dbo.SP_ThemHoaDon 'HD02','NV01','DK01','4/14/2018',5000000


GO 
CREATE PROC SP_SuaHoaDon @MaHD VARCHAR(5), @MaNV VARCHAR(5),@MaPhieuDK VARCHAR(5), @NgayThanhToan DATE,@TongTien INT
AS
BEGIN
	UPDATE dbo.HoaDon SET MaPhieuDK = @MaPhieuDK,MaNV = @MaNV,NgayThanhToan= @NgayThanhToan, TongTien = @TongTien
	WHERE MaHD = @MaHD
END 

GO 
CREATE PROC SP_XoaHoaDon @MaHD VARCHAR(5)
AS
BEGIN 
	DELETE dbo.HoaDon WHERE MaHD =@MaHD
END 