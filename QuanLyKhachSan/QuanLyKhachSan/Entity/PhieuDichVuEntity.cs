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

        public PhieuDichVuEntity()
        {
            MaPhieuDK = "";
            MaDV = "";
            SoLuong = 0;
        }
        public PhieuDichVuEntity( string _MaPhieuDK, string _MaDV,int _SoLuong )
        {
            MaPhieuDK = _MaPhieuDK;
            MaDV = _MaDV;
            SoLuong = _SoLuong;
        }
    }
}
