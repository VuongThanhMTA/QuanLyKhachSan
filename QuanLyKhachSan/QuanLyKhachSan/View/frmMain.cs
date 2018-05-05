using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.View
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private int i = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbchuchay.Location = new Point(lbchuchay.Location.X - i, lbchuchay.Location.Y);

            if (lbchuchay.Location.X <= -510 || lbchuchay.Location.Y <= 0)
            {
                lbchuchay.Location = new Point(lbchuchay.Location.X + 1300, lbchuchay.Location.Y);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap dn = new frmDangNhap();
            dn.Show();
            this.Hide();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien dt = new frmNhanVien();
            dt.Show();
            this.Hide();
        }

       

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmhuongdan h = new frmhuongdan();
            h.Show();
        }

        private void quảnLýkhachhangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang k = new frmKhachHang();
            k.Show();
            this.Hide();
        }

        private void quảnLýhoadonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon k = new frmHoaDon();
            k.Show();
            this.Hide();
        }

        private void quảnLýDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDichVu k = new frmDichVu();
            k.Show();
            this.Hide();
        }

        private void phiếuĐăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuDangKy k = new frmPhieuDangKy();
            k.Show();
            this.Hide();
        }

        private void phiếuDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuDichVu k = new frmPhieuDichVu();
            k.Show();
            this.Hide();
        }

        private void QuanlyphongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhong k = new frmPhong();
            k.Show();
            this.Hide();
        }
    }
}
