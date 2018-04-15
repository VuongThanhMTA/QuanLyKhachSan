using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Entity
{
    public class KhachHangEntity
    {
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string GioiTinh { get; set; }
        public int NamSinh { get; set; }
        public string DiaChi { get; set; }
        public string CMND { get; set; }
        public string SDT { get; set; }

        public KhachHangEntity()
        {
            MaKH = "";
            TenKH = "";
            GioiTinh = "";
            NamSinh = 0;
            DiaChi = "";
            CMND = "";
            SDT = "";
        }
        public KhachHangEntity(string _MaKH,string _TenKH,string _GioiTinh,int _NamSinh,string _DiaChi,string _CMND,string _SDT)
        {
            MaKH = _MaKH;
            TenKH = _TenKH;
            GioiTinh = _GioiTinh;
            NamSinh = _NamSinh;
            DiaChi = _DiaChi;
            CMND = _CMND;
            SDT = _SDT;
        }
    }
}
