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
    public class PhieuDichVuBUS
    {
        PhieuDichVuDAL da = new PhieuDichVuDAL();
        public DataTable GetData(string str)
        {
            return da.GetDataStr(str);
        }
        public int InsertData(PhieuDichVuEntity PDV)
        {
            return da.InsertData(PDV);
        }
        public int UpdateData(PhieuDichVuEntity PDV)
        {
            return da.UpdateData(PDV);
        }
        public int DeleteData(string IDP, string IDM)
        {
            return da.DeleteData(IDP,IDM);
        }
        public DataTable GetListDV()
        {
            return da.GetListDV();
        }
    }
}
