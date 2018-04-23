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
    public class NhanVienDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("NhanVien_SelectALL", null);
        }
        public DataTable TimKiem(string str)
        {
            return conn.GetData(str);
        }
        public int InsertData(NhanVienEntity nv)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaNV",nv.MaNV),
                new SqlParameter("TenNV",nv.TenNV),
                new SqlParameter("GioiTinh",nv.GioiTinh),
                new SqlParameter("Luong",nv.Luong),
                new SqlParameter("CMTND",nv.CMTND),
                new SqlParameter("SDT",nv.SDT),
                new SqlParameter("DiaChi",nv.DiaChi),
                new SqlParameter("NgaySinh",nv.NgaySinh)
            };
            return conn.ExcuteSQL("ThemNhanVien", para);
        }
        public int UpdateData(NhanVienEntity nv)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaNV",nv.MaNV),
                new SqlParameter("TenNV",nv.TenNV),
                new SqlParameter("GioiTinh",nv.GioiTinh),
                new SqlParameter("Luong",nv.Luong),
                new SqlParameter("CMTND",nv.CMTND),
                new SqlParameter("SDT",nv.SDT),
                new SqlParameter("DiaChi",nv.DiaChi),
                new SqlParameter("NgaySinh",nv.NgaySinh)
            };
            return conn.ExcuteSQL("SuaNhanVien", para);
        }
        public int DeleteData(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("Ma",ID)
            };
            return conn.ExcuteSQL("XoaNhanVien", para);
        }
        public string TangMa()
        {
            return conn.TangMa("Select * From NhanVien", "NV");
        }
    }
}
