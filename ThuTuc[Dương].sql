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
CREATE PROC SP_ThemPhieuDangKy(@MaPhieuDK VARCHAR(5),@MaKH VARCHAR(4),@MaPhong VARCHAR(4),@MaNV VARCHAR(4),@NgayLap DATE, @TienCoc INT )
AS
BEGIN
	INSERT dbo.PhieuDangKy
	VALUES  ( @MaPhieuDK , @MaKH ,@MaPhong , @MaNV ,@NgayLap , @TienCoc  )
END
GO


--sua phieu dang ky
CREATE PROC SP_SuaPhieuDangKy(@MaPhieuDK VARCHAR(5),@MaKH VARCHAR(4),@MaPhong VARCHAR(4),@MaNV VARCHAR(4),@NgayLap DATE, @TienCoc INT)
AS
BEGIN
	UPDATE dbo.PhieuDangKy
	SET MaKH=@MaKH,MaPhong=@MaPhong,MaNV=@MaNV,NgayLap=@NgayLap,TienCoc=@TienCoc
	WHERE MaPhieuDK=@MaPhieuDK
END
GO
--xoa phieudang ky
CREATE PROC SP_XoaPhieuDangKy(@MaPhieuDangKy VARCHAR(5))
AS
BEGIN
	DELETE dbo.PhieuDangKy
	WHERE MaPhieuDK=@MaPhieuDangKy
END
GO
