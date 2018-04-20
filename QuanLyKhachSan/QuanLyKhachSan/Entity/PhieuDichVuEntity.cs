using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Entity
{
    public class PhieuDichVuEntity
    {
        public string MaPhieuDK { get; set; }
        public string MaDV { get; set; }
        public int SoLuong { get; set; }
        public string TenDV { get; set; }

        public PhieuDichVuEntity()
        {
            MaPhieuDK = "";
            MaDV = "";
            SoLuong = 0;
            TenDV = "";
        }
        public PhieuDichVuEntity( string _MaPhieuDK, string _MaDV,int _SoLuong,string _TenDV )
        {
            MaPhieuDK = _MaPhieuDK;
            MaDV = _MaDV;
            SoLuong = _SoLuong;
            TenDV = _TenDV;
        }
    }
}
