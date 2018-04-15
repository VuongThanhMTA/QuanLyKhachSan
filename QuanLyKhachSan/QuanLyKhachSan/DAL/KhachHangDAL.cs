using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyKhachSan.Entity;

namespace QuanLyKhachSan.DAL
{
    public class KhachHangDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("Xem_KH", null);
        }
        public DataTable TimKiem(string str)
        {
            return conn.GetData(str);
        }
        public int ThemKH(KhachHangEntity kh)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaKH",kh.MaKH),
                new SqlParameter("TenKH",kh.TenKH),
                new SqlParameter("GioiTinh",kh.GioiTinh),
                new SqlParameter("NamSinh",kh.NamSinh),
                new SqlParameter("DiaChi",kh.DiaChi),
                new SqlParameter("CMND",kh.CMND),
                new SqlParameter("SDT",kh.SDT),
            };
            return conn.ExcuteSQL("Them_KH", para);
        }
        public int SuaKH(KhachHangEntity kh)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaKH",kh.MaKH),
                new SqlParameter("TenKH",kh.TenKH),
                new SqlParameter("GioiTinh",kh.GioiTinh),
                new SqlParameter("NamSinh",kh.NamSinh),
                new SqlParameter("DiaChi",kh.DiaChi),
                new SqlParameter("CMND",kh.CMND),
                new SqlParameter("SDT",kh.SDT),
            };
            return conn.ExcuteSQL("Sua_KH", para);
        }
        public int XoaKH(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaKH",ID)
            };
            return conn.ExcuteSQL("Xoa_KH", para);
        }
        public string TangMa()
        {
            return conn.TangMa("select * from KhachHang", "KH");
        }
    }
}
