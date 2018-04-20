using QuanLyKhachSan.DAL;
using QuanLyKhachSan.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class DichVuBUS
    {
        DichVuDAL da = new DichVuDAL();
        public DataTable GetData()
        {
            return da.GetData();
        }
        public int InsertData(DichVuEntity DV)
        {
            return da.InsertData(DV);
        }
        public int UpdateData(DichVuEntity DV)
        {
            return da.UpdateData(DV);
        }
        public int DeleteData(string ID)
        {
            return da.DeleteData(ID);
        }
        public string TangMa()
        {
            return da.TangMa();
        }
        public DataTable TimKiem(string strTimKiem)
        {
            return da.TimKiem(strTimKiem);
        }
    }
}
