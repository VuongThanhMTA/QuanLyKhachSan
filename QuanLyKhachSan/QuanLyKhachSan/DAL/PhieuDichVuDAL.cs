using QuanLyKhachSan.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    public class PhieuDichVuDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("XemPDV", null);
        }
        public int InsertData(PhieuDichVuEntity PDV)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaPhieuDK",PDV.MaPhieuDK),
                new SqlParameter("MaDV",PDV.MaDV),
                new SqlParameter("SoLuong",PDV.SoLuong)

            };
            return conn.ExcuteSQL("ThemPDV", para);
        }
        public int UpdateData(PhieuDichVuEntity PDV)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaPhieuDK",PDV.MaPhieuDK),
                new SqlParameter("MaDV",PDV.MaDV),
                new SqlParameter("SoLuong",PDV.SoLuong)

            };
            return conn.ExcuteSQL("SuaPDV", para);
        }
        public int DeleteData(string IDP,string IDM)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaPhieuDK",IDP),
                new SqlParameter("MaDV",IDM)
        };
            return conn.ExcuteSQL("XoaPDV", para);
        }
        public DataTable GetListDV()
        {
            return conn.GetData("XemDV", null);
        }
    }
}
