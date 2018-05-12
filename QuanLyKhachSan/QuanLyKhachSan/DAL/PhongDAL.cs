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
    public class PhongDAL
    {
        KetNoi _connect = new KetNoi();

        public DataTable GetData()
        {
            return _connect.GetData("SP_PhongSelectAll", null);
        }

        public int InsertData(PhongEntity p)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaPhong",p.MaPhong),
                new SqlParameter("MaLoaiPhong",p.MaLoaiPhong),
                new SqlParameter("TenPhong",p.TenPhong),
                new SqlParameter("TrangThai",p.TrangThai),
                 new SqlParameter("Gia",p.Gia)
        };
            return _connect.ExcuteSQL("SP_ThemPhong ", para);
        }

        public int EditData(PhongEntity p)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaPhong",p.MaPhong),
                new SqlParameter("MaLoaiPhong",p.MaLoaiPhong),
                new SqlParameter("TenPhong",p.TenPhong),
                new SqlParameter("TrangThai",p.TrangThai),
                new SqlParameter("Gia",p.Gia)
            };
            return _connect.ExcuteSQL("SP_SuaPhong ", para);
        }


        public int DeleteData(string Ma)
        {

            SqlParameter[] para =
            {
                new SqlParameter("MaPhong",Ma)
             };
            return _connect.ExcuteSQL("SP_XoaPhong ", para);
        }

        public string TangMa()
        {
            return _connect.TangMa("Select * From Phong", "MP");
        }

        public bool KiemTraTonTai(string Ma)
        {
            return _connect.KiemTraTonTai("Select MaPhong from PhieuDangKy", Ma);
        }
    }
}
