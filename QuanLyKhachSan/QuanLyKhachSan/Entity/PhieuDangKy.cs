using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Entity
{
    public class PhieuDangKy
    {
        public string MaPhieuDangKy { get; set; }
        public string MaKhachHang { get; set; }
        public string MaPhong { get; set; }
        public string MaNhanViebn { get; set; }
        public DateTime NgayLap { get; set; }
        public int TienCoc { get; set; }
    }
}
