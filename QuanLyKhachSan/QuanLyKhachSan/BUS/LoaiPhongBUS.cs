using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.Entity;
using QuanLyKhachSan.DAL;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKhachSan.BUS
{
   public class LoaiPhongBUS
    {
        LoaiPhongDAL dal = new LoaiPhongDAL();

        public DataTable GetData()
        {
            return dal.GetData();
        }

        public int InsertData(LoaiPhongEntity lp)
        {
            return dal.InsertData(lp);
        }

        public int EditData(LoaiPhongEntity hd)
        {
            return dal.EditData(hd);
        }

        public int DeleteData(string Ma)
        {
            return dal.DeleteData(Ma);
        }
        public string TangMa()
        {
            return dal.TangMa();
        }
    }
}
