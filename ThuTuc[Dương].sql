USE QuanLyKhachSan
GO
USE QuanLyKhachSan
GO
--xem phieu dang ky
CREATE PROC SP_XemPhieuDangKy
AS
BEGIN
	SELECT * FROM PhieuDangKy
END
GO 
--them phieu dang ky
CREATE PROC SP_ThemPhieuDangKy(@MaPhieuDK VARCHAR(10),@MaKH VARCHAR(10),@MaPhong VARCHAR(10),@MaNV VARCHAR(10),@NgayLap DATE, @TienCoc INT )
AS
BEGIN
	INSERT dbo.PhieuDangKy
	VALUES  ( @MaPhieuDK , @MaKH ,@MaPhong , @MaNV ,@NgayLap , @TienCoc  )
END
GO


--sua phieu dang ky
CREATE PROC SP_SuaPhieuDangKy(@MaPhieuDK VARCHAR(10),@MaKH VARCHAR(10),@MaPhong VARCHAR(10),@MaNV VARCHAR(10),@NgayLap DATE, @TienCoc INT)
AS
BEGIN
	UPDATE dbo.PhieuDangKy
	SET MaKH=@MaKH,MaPhong=@MaPhong,MaNV=@MaNV,NgayLap=@NgayLap,TienCoc=@TienCoc
	WHERE MaPhieuDK=@MaPhieuDK
END
GO
--xoa phieudang ky
CREATE PROC SP_XoaPhieuDangKy(@MaPhieuDangKy VARCHAR(10))
AS
BEGIN
	DELETE dbo.PhieuDangKy
	WHERE MaPhieuDK=@MaPhieuDangKy
END
GO
--thu tuc XemThongTinKhachHangDangKyPhong
CREATE PROC XemThongTinKhachHangDangKyPhong
AS 
BEGIN
	SELECT TenKH,TenPhong,LoaiPhong,SDT,CMND FROM dbo.KhachHang JOIN dbo.PhieuDangKy
	ON PhieuDangKy.MaKH = KhachHang.MaKH
	JOIN dbo.Phong 
	ON Phong.MaPhong = PhieuDangKy.MaPhong
	JOIN dbo.LoaiPhong 
	ON LoaiPhong.MaLoaiPhong = Phong.MaLoaiPhong
END
