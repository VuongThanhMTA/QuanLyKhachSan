using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using QuanLyKhachSan.BUS;
using QuanLyKhachSan.Entity;
namespace QuanLyKhachSan.View
{
    public partial class frmKhachHang : Form
    {
        KhachHangBUS bus = new KhachHangBUS();
        KhachHangEntity kh = new KhachHangEntity();
        private int fluu = 1;
        public frmKhachHang()
        {
            InitializeComponent();
        }
        public void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMaKH.Enabled = e;
            txtTenKH.Enabled = e;
            txtNamSinh.Enabled = e;
            txtDiaChi.Enabled = e;
            txtCMND.Enabled = e;
            txtSDT.Enabled = e;
            cbbGioiTinh.Enabled = e;
        }
        private void clearData()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtNamSinh.Text = "";
            txtDiaChi.Text = "";
            txtCMND.Text = "";
            txtSDT.Text = "";
            cbbGioiTinh.Text = "";
        }
        private void HienThi()
        {
            dgvKH.DataSource = bus.GetData();
        }
        private void txtNamSinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {
                txtMaKH.Text = Convert.ToString(dgvKH.CurrentRow.Cells["MaKH"].Value);
                txtTenKH.Text = Convert.ToString(dgvKH.CurrentRow.Cells["TenKH"].Value);
                txtNamSinh.Text = Convert.ToString(dgvKH.CurrentRow.Cells["NamSinh"].Value);
                txtDiaChi.Text = Convert.ToString(dgvKH.CurrentRow.Cells["DiaChi"].Value);
                txtCMND.Text = Convert.ToString(dgvKH.CurrentRow.Cells["CMND"].Value);
                txtSDT.Text = Convert.ToString(dgvKH.CurrentRow.Cells["CMND"].Value);
                cbbGioiTinh.Text = Convert.ToString(dgvKH.CurrentRow.Cells["GioiTinh"].Value);
            }
            else
            {
                txtMaKH.Text = Convert.ToString(dgvKH.CurrentRow.Cells["MaKH"].Value);
                txtTenKH.Text = Convert.ToString(dgvKH.CurrentRow.Cells["TenKH"].Value);
                txtNamSinh.Text = Convert.ToString(dgvKH.CurrentRow.Cells["NamSinh"].Value);
                txtDiaChi.Text = Convert.ToString(dgvKH.CurrentRow.Cells["DiaChi"].Value);
                txtCMND.Text = Convert.ToString(dgvKH.CurrentRow.Cells["CMND"].Value);
                txtSDT.Text = Convert.ToString(dgvKH.CurrentRow.Cells["CMND"].Value);
                cbbGioiTinh.Text = Convert.ToString(dgvKH.CurrentRow.Cells["GioiTinh"].Value);
            }
        }

        private void dgvKH_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvKH.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            txtMaKH.Text = bus.TangMa();
            DisEnl(true);
            txtMaKH.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txtMaKH.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bus.XoaKH(txtMaKH.Text);
                    MessageBox.Show("Xóa thành công!");
                    clearData();
                    DisEnl(false);
                    HienThi();
                }
                catch
                {
                    MessageBox.Show("Lỗi không xóa được");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            kh.MaKH = txtMaKH.Text;
            kh.TenKH = txtTenKH.Text;
            kh.NamSinh = Convert.ToInt32(txtNamSinh.Text);
            kh.DiaChi = txtDiaChi.Text;
            kh.GioiTinh = cbbGioiTinh.Text;
            kh.CMND = txtCMND.Text;
            kh.SDT = txtSDT.Text;

            if (fluu == 0)
            {

                try
                {
                    int dt;
                    dt = bus.ThemKH(kh);
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
                bus.SuaKH(kh);
                MessageBox.Show("Sửa Thành Công ! ");
                HienThi();
                clearData();
                DisEnl(false);
            }
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
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                this.Close();
            }
            else
                HienThi();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cmbTimKiem.Text == "Theo Mã Khách Hàng")
            {
                dgvKH.DataSource = bus.TimKiem(" SELECT * FROM dbo.KhachHang where MaKH like '%" + txtTimKiem.Text + "%'");
            }
            if (cmbTimKiem.Text == "Theo Tên Khách Hàng")
            {
                dgvKH.DataSource = bus.TimKiem(" SELECT * FROM dbo.KhachHang where TenKH like '%" + txtTimKiem.Text + "%'");
            }
            if (cmbTimKiem.Text == "Theo Giới Tính")
            {
                dgvKH.DataSource = bus.TimKiem(" SELECT * FROM dbo.KhachHang where GioiTinh like '%" + txtTimKiem.Text + "%'");
            }
            
            if (cmbTimKiem.Text == "Theo Địa Chỉ")
            {
                dgvKH.DataSource = bus.TimKiem(" SELECT * FROM dbo.KhachHang where DiaChi like '%" + txtTimKiem.Text + "%'");
            }
            if (cmbTimKiem.Text == "Theo Năm Sinh")
            {
                dgvKH.DataSource = bus.TimKiem(" SELECT * FROM dbo.KhachHang where NamSinh like '%" + txtTimKiem.Text + "%'");
            }
            if (cmbTimKiem.Text == "Theo CMND")
            {
                dgvKH.DataSource = bus.TimKiem(" SELECT * FROM dbo.KhachHang where CMND like '%" + txtTimKiem.Text + "%'");
            }
            if (cmbTimKiem.Text == "Theo SĐT")
            {
                dgvKH.DataSource = bus.TimKiem(" SELECT * FROM dbo.KhachHang where SDT like '%" + txtTimKiem.Text + "%'");
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
