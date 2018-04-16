using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Entity
{
    public class LoaiPhongEntity
    {
        private string _MaLoaiPhong;
        private string _LoaiPhong;

        public string LoaiPhong
        {
            get
            {
                return _LoaiPhong;
            }

            set
            {
                _LoaiPhong = value;
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
    }
}
