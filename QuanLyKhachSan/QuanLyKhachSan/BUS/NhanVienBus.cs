using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyKhachSan.DAL;
using QuanLyKhachSan.Entity;

namespace QuanLyKhachSan.BUS
{
    public class NhanVienBus
    {
        NhanVienDAL Dal = new NhanVienDAL();
        public DataTable GetData()
        {
            return Dal.GetData();
        }
        public int InsertData(NhanVienEntity nv)
        {
            return Dal.InsertData(nv);
        }
        public int UpdateData(NhanVienEntity nv)
        {
            return Dal.UpdateData(nv);
        }
        public int DeleteData(String ID)
        {
            return Dal.DeleteData(ID);
        }
        public string TangMa()
        {
            return Dal.TangMa();
        }
        public DataTable TimKiem(string str)
        {
            return Dal.TimKiem(str);
        }
    }
}
