using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Entity
{
    public class DichVuEntity
    {
        public string MaDV { get; set; }
        public string TenDV { get; set; }
        public long Gia { get; set; }

        public DichVuEntity()
        {
            MaDV = "";
            TenDV = "";
            Gia = 0;
        }
        public DichVuEntity(string _MaDV, string _TenDV, long _Gia)
        {
            MaDV = _MaDV;
            TenDV = _TenDV;
            Gia = _Gia;
        }
    }
}
