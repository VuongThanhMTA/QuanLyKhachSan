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
    public class HoaDonBUS
    {
        HoaDonDAL dal = new HoaDonDAL();

        public DataTable GetData()
        {
            return dal.GetData();
        }

        public int InsertData(HoaDonEntity hd)
        {
            return dal.InsertData(hd);
        }

        public int EditData(HoaDonEntity hd)
        {
            return dal.EditData(hd);
        }

        public int DeleteData(string Ma)
        {
            return dal.DeleteData(Ma);
        }
    }
}
