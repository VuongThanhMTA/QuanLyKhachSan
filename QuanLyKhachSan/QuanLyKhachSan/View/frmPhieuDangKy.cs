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
    public partial class frmPhieuDangKy : Form
    {
        PhieuDangKy phieudk = new PhieuDangKy();
        PhieuDangKyBUS phieudkbus = new PhieuDangKyBUS();
        private int fluu = 1;
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnThoat.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMaPhieuDk.Enabled = e;
            cmbMaKH.Enabled = e;
            cmbMaPhong.Enabled = e;
            cmbMaNV.Enabled = e;
            dateNgayLap.Enabled = e;
            txtTienCoc.Enabled = e;
            // txtTimKiem.Enabled = e;
        }
        private void clearData()
        {
            txtMaPhieuDk.Text = "";
            cmbMaKH.Text = "";
            cmbMaPhong.Text = "";
            cmbMaNV.Text = "";
            dateNgayLap.Text = "";
            txtTienCoc.Text = "";
        }
        private void HienThi()
        {
            dgvPhieuDK.DataSource = phieudkbus.XemPhieuDangKy();
        }
        public frmPhieuDangKy()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
                HienThi();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                HienThi();
                DisEnl(false);
                fluu = 1;
            }
            else
                return;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            txtMaPhieuDk.Text = phieudkbus.TangMa();
            DisEnl(true);
            txtMaPhieuDk.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txtMaPhieuDk.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    phieudkbus.XoaPhieuDangKy(txtMaPhieuDk.Text);
                    MessageBox.Show("Xóa thành công!");
                    clearData();
                    DisEnl(false);
                    HienThi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            phieudk.MaPhieuDangKy = txtMaPhieuDk.Text;
            phieudk.MaKhachHang = cmbMaKH.Text;
            phieudk.MaNhanViebn = cmbMaNV.Text;
            phieudk.MaPhong = cmbMaPhong.Text;
            phieudk.NgayLap = Convert.ToDateTime(dateNgayLap.Text);
            phieudk.TienCoc = int.Parse(txtTienCoc.Text);

            if (fluu == 0)
            {
                try
                {
                    phieudkbus.ThemPhieuDangKy(phieudk);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    clearData();
                    DisEnl(false);
                    fluu = 1;
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi!");
                }
            }
            else
            {
                try
                {
                    phieudkbus.SuaPhieuDangKy(phieudk);
                    MessageBox.Show("Sửa Thành Công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    clearData();
                    DisEnl(false);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void dgvPhieuDK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {
                cmbMaKH.Text = Convert.ToString(dgvPhieuDK.CurrentRow.Cells["MaKH"].Value);
                cmbMaPhong.Text = Convert.ToString(dgvPhieuDK.CurrentRow.Cells["MaPhong"].Value);
                cmbMaNV.Text = Convert.ToString(dgvPhieuDK.CurrentRow.Cells["MaNV"].Value);
                dateNgayLap.Text = Convert.ToString(dgvPhieuDK.CurrentRow.Cells["NgayLap"].Value);
                txtTienCoc.Text = Convert.ToString(dgvPhieuDK.CurrentRow.Cells["TienCoc"].Value);
            }
            else
            {
                txtMaPhieuDk.Text = Convert.ToString(dgvPhieuDK.CurrentRow.Cells["MaPhieuDK"].Value);
                cmbMaKH.Text = Convert.ToString(dgvPhieuDK.CurrentRow.Cells["MaKH"].Value);
                cmbMaPhong.Text = Convert.ToString(dgvPhieuDK.CurrentRow.Cells["MaPhong"].Value);
                cmbMaNV.Text = Convert.ToString(dgvPhieuDK.CurrentRow.Cells["MaNV"].Value);
                dateNgayLap.Text = Convert.ToString(dgvPhieuDK.CurrentRow.Cells["NgayLap"].Value);
                txtTienCoc.Text = Convert.ToString(dgvPhieuDK.CurrentRow.Cells["TienCoc"].Value);
            }
        }

        private void dgvPhieuDK_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvPhieuDK.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void frmPhieuDangKy_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
            cmbMaNV.DataSource = phieudkbus.XemPhieuDK("select * from NhanVien");
            cmbMaNV.DisplayMember = "MaNV";
            cmbMaKH.DataSource = phieudkbus.XemPhieuDK("select * from KhachHang");
            cmbMaKH.DisplayMember = "MaKH";
            cmbMaPhong.DataSource = phieudkbus.XemPhieuDK("select * from Phong");
            cmbMaPhong.DisplayMember = "MaPhong";
        }
    }
}
