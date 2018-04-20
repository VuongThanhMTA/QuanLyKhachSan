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
    public class DichVuDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("XemDV", null);
        }
        public int InsertData(DichVuEntity DV)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaDV",DV.MaDV),
                new SqlParameter("TenDV",DV.TenDV),
                new SqlParameter("Gia",DV.Gia)
              
            };
            return conn.ExcuteSQL("ThemDV", para);
        }
        public int UpdateData(DichVuEntity DV)
        {
            SqlParameter[] para =
           {
                 new SqlParameter("MaDV",DV.MaDV),
                new SqlParameter("TenDV",DV.TenDV),
                new SqlParameter("Gia",DV.Gia)
            };
            return conn.ExcuteSQL("SuaDV", para);
        }
        public int DeleteData(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaDV",ID)
        };
            return conn.ExcuteSQL("XoaDV", para);
        }
        public string TangMa()
        {
            return conn.TangMa("Select * From DichVu", "DV");
        }
        public DataTable TimKiem(string strTimKiem)
        {
            return conn.GetData(strTimKiem);
        }
    }
}
