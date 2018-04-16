using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.Entity;
using QuanLyKhachSan.BUS;
namespace QuanLyKhachSan.View
{
    public partial class frmXemThngTinKhachHang : Form
    {
        PhieuDangKy phieudk = new PhieuDangKy();
        PhieuDangKyBUS phieubus = new PhieuDangKyBUS();
        public frmXemThngTinKhachHang()
        {
            InitializeComponent();
        }

        private void frmXemThngTinKhachHang_Load(object sender, EventArgs e)
        {
            dgvThongTInKhachHang.DataSource = phieubus.XemThongTinKhachHangDangKyPhong(frmPhieuDangKy.MaKH1);
        }
    }
}
