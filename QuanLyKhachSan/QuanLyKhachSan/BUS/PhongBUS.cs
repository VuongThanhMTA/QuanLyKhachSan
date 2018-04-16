using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKhachSan.DAL;
using QuanLyKhachSan.Entity;

namespace QuanLyKhachSan.BUS
{
    public class PhongBUS
    {
        PhongDAL dal = new PhongDAL();

        public DataTable GetData()
        {
            return dal.GetData();
        }

        public int InsertData(PhongEntity lp)
        {
            return dal.InsertData(lp);
        }

        public int EditData(PhongEntity hd)
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

        public bool PhongDangSuDung(string Ma)
        {
            return dal.KiemTraTonTai(Ma);
        }
    }
}
