using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.Entity;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKhachSan.DAL
{
    public class HoaDonDAL
    {
        KetNoi _connect = new KetNoi();

        public DataTable GetData()
        {
            return _connect.GetData("SP_DanhSachHoaDon", null);
        }

        public DataTable DanhSachDatPhong()
        {
            return _connect.GetData("SP_DanhSachPhieuDangKy", null);
        }

        public DataTable DanhSachDichVuSuDung(string maPhieuDK)
        {
            SqlParameter[] para = { new SqlParameter("MaPhieuDK", maPhieuDK) };
            return _connect.GetData("SP_DanhSachDichVuSuDung", para);
        }
        public int InsertData(HoaDonEntity hd)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaHD",hd.MaHD),
                new SqlParameter("MaNV",hd.MaNV),
                new SqlParameter("MaPhieuDK",hd.MaPhieuDK),
                new SqlParameter("NgayThanhToan",hd.NgayThanhToan)
                //new SqlParameter("TongTien",hd.TongTien)
        };
            return _connect.ExcuteSQL("SP_ThemHoaDon ", para);
        }

        public int EditData(HoaDonEntity hd)
        {

            SqlParameter[] para =
            {
                new SqlParameter("MaHD",hd.MaHD),
                new SqlParameter("MaNV",hd.MaNV),
                new SqlParameter("MaPhieuDK",hd.MaPhieuDK),
                new SqlParameter("NgayThanhToan",hd.NgayThanhToan)
                //new SqlParameter("TongTien",hd.TongTien)

            };
            return _connect.ExcuteSQL("SP_SuaHoaDon ", para);
        }


        public int DeleteData(string Ma)
        {

            SqlParameter[] para =
            {
                new SqlParameter("MaHD",Ma)
             };
            return _connect.ExcuteSQL("SP_XoaHoaDon ", para);
        }
        public string TangMa()
        {
            return _connect.TangMa("Select * From HoaDon", "HD");
        }
    }
}
