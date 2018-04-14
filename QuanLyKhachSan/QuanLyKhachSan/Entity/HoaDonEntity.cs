using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Entity
{
    public class HoaDonEntity
    {
        string _MaHD;
        string _MaNV;
        string _MaPhieuDK;
        string _NgayThanhToan;
        string _TongTien;

        public string MaHD
        {
            get
            {
                return _MaHD;
            }

            set
            {
                _MaHD = value;
            }
        }

        public string MaNV
        {
            get
            {
                return _MaNV;
            }

            set
            {
                _MaNV = value;
            }
        }

        public string MaPhieuDK
        {
            get
            {
                return _MaPhieuDK;
            }

            set
            {
                _MaPhieuDK = value;
            }
        }

        public string NgayThanhToan
        {
            get
            {
                return _NgayThanhToan;
            }

            set
            {
                _NgayThanhToan = value;
            }
        }

        public string TongTien
        {
            get
            {
                return _TongTien;
            }

            set
            {
                _TongTien = value;
            }
        }
    }
}
