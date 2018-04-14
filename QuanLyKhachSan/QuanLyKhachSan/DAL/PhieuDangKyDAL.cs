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
    public class PhieuDangKyDAL
    {
        KetNoi kn = new KetNoi();
        public DataTable XemPhieuDangKy()
        {
            return kn.GetData("SP_XemPhieuDangKy");
        }
        public DataTable XemPhieuDK(string str)
        {
            return kn.GetData(str);
        }
        public int ThemPhieuDangKy(PhieuDangKy phieudk)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaPhieuDK",phieudk.MaPhieuDangKy),
                new SqlParameter("MaKH",phieudk.MaKhachHang),
                new SqlParameter("MaPhong",phieudk.MaPhong),
                new SqlParameter("MaNV",phieudk.MaNhanViebn),
                new SqlParameter("NgayLap",phieudk.NgayLap),
                new SqlParameter("TienCoc",phieudk.TienCoc),
            };
            return kn.ExcuteSQL("SP_ThemPhieuDangKy", para);
        }
        public int SuaPhieuDangKy(PhieuDangKy phieudk)
        {
            SqlParameter[] para =
               {
                new SqlParameter("MaPhieuDK",phieudk.MaPhieuDangKy),
                new SqlParameter("MaKH",phieudk.MaKhachHang),
                new SqlParameter("MaPhong",phieudk.MaPhong),
                new SqlParameter("MaNV",phieudk.MaNhanViebn),
                new SqlParameter("NgayLap",phieudk.NgayLap),
                new SqlParameter("TienCoc",phieudk.TienCoc),
            };
            return kn.ExcuteSQL("SP_SuaPhieuDangKy", para);

        }
        public int XoaPhieuDangKy(string id)
        {
            SqlParameter[] para =
               {
                new SqlParameter("MaPhieuDangKy",id)
            };
            return kn.ExcuteSQL("SP_XoaPhieuDangKy", para);
        }
        public string TangMa()
        {
            return kn.TangMa("Select * From PhieuDangKy", "PDK");
        }
    }
}
