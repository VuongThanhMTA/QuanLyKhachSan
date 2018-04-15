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
    public class KhachHangBUS
    {
        KhachHangDAL kh = new KhachHangDAL();
        public DataTable GetData()
        {
            return kh.GetData();
        }
        public int ThemKH(KhachHangEntity en)
        {
            return kh.ThemKH(en);
        }
        public int SuaKH(KhachHangEntity en)
        {
            return kh.SuaKH(en);
        }
        public int XoaKH(string ID)
        {
            return kh.XoaKH(ID);
        }
        public string TangMa()
        {
            return kh.TangMa();
        }
        public DataTable TimKiem(string str)
        {
            return kh.TimKiem(str);
        }
    }
}
