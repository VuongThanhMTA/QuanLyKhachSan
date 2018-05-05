using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.BUS;
using QuanLyKhachSan.Entity;
namespace QuanLyKhachSan.View
{
    public partial class frmNhanVien : Form
    {
        NhanVienBus bus = new NhanVienBus();
        NhanVienEntity Nv = new NhanVienEntity();
        private int fluu = 1;
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMaNV.Enabled = e;
            txtTenNV.Enabled = e;
            cmbGioiTinh.Enabled = e;
            txtLuong.Enabled = e;
            txtDiaChi.Enabled = e;
            dpNgaySinh.Enabled = e;
            txtCMTND.Enabled = e;
            txtSDT.Enabled = e;
        }
        private void clearData()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            cmbGioiTinh.Text = "";
            txtLuong.Text = "";
            txtDiaChi.Text = "";
            txtCMTND.Text = "";
            txtSDT.Text = "";
            dpNgaySinh.Text = "";
        }
        private void HienThi()
        {
            dgvNhanVien.DataSource = bus.GetData();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {
                txtTenNV.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["TenNV"].Value);
                txtLuong.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["Luong"].Value);
                txtDiaChi.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["DiaChi"].Value);
                dpNgaySinh.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["NgaySinh"].Value);
                cmbGioiTinh.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["GioiTinh"].Value);
                txtCMTND.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["CMTND"].Value);
                txtSDT.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["SDT"].Value);
            }
            else
            {
                txtMaNV.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["MaNV"].Value);
                txtTenNV.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["TenNV"].Value);
                txtLuong.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["Luong"].Value);
                txtDiaChi.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["DiaChi"].Value);
                dpNgaySinh.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["NgaySinh"].Value);
                cmbGioiTinh.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["GioiTinh"].Value);
                txtCMTND.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["CMTND"].Value);
                txtSDT.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["SDT"].Value);

            }
        }

        private void dgvNhanVien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvNhanVien.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            txtMaNV.Text = bus.TangMa();
            DisEnl(true);
            txtMaNV.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bus.DeleteData(txtMaNV.Text);
                    MessageBox.Show("Xóa thành công!");
                    clearData();
                    DisEnl(false);
                    HienThi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi không xóa được \n" +ex);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Nv.MaNV = txtMaNV.Text;
            Nv.TenNV = txtTenNV.Text;
            Nv.Luong = Convert.ToInt32(txtLuong.Text);
            Nv.DiaChi = txtDiaChi.Text;
            Nv.NgaySinh = dpNgaySinh.Text;
            Nv.GioiTinh = cmbGioiTinh.Text;
            Nv.CMTND = txtCMTND.Text;
            Nv.SDT = txtSDT.Text;

            if (fluu == 0)
            {

                try
                {
                    int dt;
                    dt = bus.InsertData(Nv);
                    if (dt != 0)
                    {
                        MessageBox.Show("Thêm thành công!");
                    }
                }
                catch
                {
                    MessageBox.Show("không được thêm nhân viên  dưới 18 tuổi!");
                }




                HienThi();
                clearData();
                DisEnl(false);
            }
            else
            {
                bus.UpdateData(Nv);
                MessageBox.Show("Sửa Thành Công ! ");
                HienThi();
                clearData();
                DisEnl(false);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txtMaNV.Enabled = false;
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmMain m = new frmMain();
                m.Show();
                this.Close();
            }
            else
                HienThi();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cmbTimKiem.Text == "Theo Mã Nhân Viên")
            {
                dgvNhanVien.DataSource = bus.TimKiem(" SELECT * FROM dbo.NhanVien where Ma_NV like '%" + txtTimKiem.Text + "%'");
            }
            if (cmbTimKiem.Text == "Theo Tên Nhân Viên")
            {
                dgvNhanVien.DataSource = bus.TimKiem(" SELECT * FROM dbo.NhanVien where Ten_NV like '%" + txtTimKiem.Text + "%'");
            }
            if (cmbTimKiem.Text == "Theo Giới Tính")
            {
                dgvNhanVien.DataSource = bus.TimKiem(" SELECT * FROM dbo.NhanVien where Gioi_Tinh like '%" + txtTimKiem.Text + "%'");
            }
            if (cmbTimKiem.Text == "Theo Lương")
            {
                dgvNhanVien.DataSource = bus.TimKiem(" SELECT * FROM dbo.NhanVien where Luong like '%" + txtTimKiem.Text + "%'");
            }
            if (cmbTimKiem.Text == "Theo Địa Chỉ")
            {
                dgvNhanVien.DataSource = bus.TimKiem(" SELECT * FROM dbo.NhanVien where DiaChi like '%" + txtTimKiem.Text + "%'");
            }
            if (cmbTimKiem.Text == "Theo Ngày Sinh")
            {
                dgvNhanVien.DataSource = bus.TimKiem(" SELECT * FROM dbo.NhanVien where Ngay_Sinh like '%" + txtTimKiem.Text + "%'");
            }
            if (cmbTimKiem.Text == "Theo CMTND")
            {
                dgvNhanVien.DataSource = bus.TimKiem(" SELECT * FROM dbo.NhanVien where CMTND like '%" + txtTimKiem.Text + "%'");
            }
            if (cmbTimKiem.Text == "Theo SĐT")
            {
                dgvNhanVien.DataSource = bus.TimKiem(" SELECT * FROM dbo.NhanVien where SDT like '%" + txtTimKiem.Text + "%'");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
            txtTimKiem.Text = "";
            cmbTimKiem.Text = "";
        }
    }
}
