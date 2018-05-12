using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Entity
{
    public class PhongEntity
    {
        private string _MaPhong;
        private string _TenPhong;
        private string _MaLoaiPhong;
        private string _TrangThai;
        private int _Gia;

        public int Gia
        {
            get { return _Gia; }
            set { _Gia = value; }
        }


        public string MaPhong
        {
            get
            {
                return _MaPhong;
            }

            set
            {
                _MaPhong = value;
            }
        }

        public string TenPhong
        {
            get
            {
                return _TenPhong;
            }

            set
            {
                _TenPhong = value;
            }
        }

        public string MaLoaiPhong
        {
            get
            {
                return _MaLoaiPhong;
            }

            set
            {
                _MaLoaiPhong = value;
            }
        }

        public string TrangThai
        {
            get
            {
                return _TrangThai;
            }

            set
            {
                _TrangThai = value;
            }
        }
    }
}
