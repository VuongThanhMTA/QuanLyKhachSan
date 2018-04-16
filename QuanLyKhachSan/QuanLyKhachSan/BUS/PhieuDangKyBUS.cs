using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.Entity;
using QuanLyKhachSan.DAL;
using System.Data;
namespace QuanLyKhachSan.BUS
{
    class PhieuDangKyBUS
    {
        PhieuDangKyDAL phieudal = new PhieuDangKyDAL();
        public DataTable XemPhieuDangKy()
        {
            return phieudal.XemPhieuDangKy();
        }
        public DataTable XemPhieuDK(string str)
        {
            return phieudal.XemPhieuDK(str);
        }
        public DataTable XemThongTinKhachHangDangKyPhong(string id)
        {
            return phieudal.XemThongTinKhachHangDangKyPhong(id);
        }
        public int ThemPhieuDangKy(PhieuDangKy phieudk)
        {
            return phieudal.ThemPhieuDangKy(phieudk);
        }
        public int SuaPhieuDangKy(PhieuDangKy phieudk)
        {
            return phieudal.SuaPhieuDangKy(phieudk);

        }
        public int XoaPhieuDangKy(string id)
        {
            return phieudal.XoaPhieuDangKy(id);
        }
        public string TangMa()
        {
            return phieudal.TangMa();
        }
    }
}
