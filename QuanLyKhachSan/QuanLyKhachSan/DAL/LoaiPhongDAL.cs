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
    public class LoaiPhongDAL
    {
        KetNoi _connect = new KetNoi();

        public DataTable GetData()
        {
            return _connect.GetData("SP_LoaiPhongSelectAll", null);
        }

        public int InsertData(LoaiPhongEntity lp)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaLoaiPhong",lp.MaLoaiPhong),
                new SqlParameter("TenLP",lp.LoaiPhong)
        };
            return _connect.ExcuteSQL("SP_ThemLoaiPhong ", para);
        }

        public int EditData(LoaiPhongEntity lp)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaLoaiPhong",lp.MaLoaiPhong),
                new SqlParameter("TenLp",lp.LoaiPhong)
            };
            return _connect.ExcuteSQL("SP_SuaLoaiPhong ", para);
        }


        public int DeleteData(string Ma)
        {

            SqlParameter[] para =
            {
                new SqlParameter("MaLoaiPhong",Ma)
             };
            return _connect.ExcuteSQL("SP_XoaLoaiPhong ", para);
        }

        public string TangMa()
        {
            return _connect.TangMa("Select * From LoaiPhong", "LP");
        }
    }
}
