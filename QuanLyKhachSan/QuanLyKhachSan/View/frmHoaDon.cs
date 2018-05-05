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
using QuanLyKhachSan.DAL;
using QuanLyKhachSan.BUS;
namespace QuanLyKhachSan.View
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }
        HoaDonBUS busHoaDon = new HoaDonBUS();
        HoaDonEntity EntityHoaDon = new HoaDonEntity();
        PhieuDangKyBUS busPDK = new PhieuDangKyBUS();
        NhanVienBus busNhanVien = new NhanVienBus();
        private int _click = 1;
        public void ClearTxt()
        {
            txtMaHD.Text = "";
            txtTongTien.Text = "";
            dtpNgayTT.Text = DateTime.Today.ToString();
            cbMaNV.Text = "";
            cbMaPDK.Text = "";
        }

        public void KhoaBtn( bool key)
        {
            btnThem.Enabled = !key;
            btnSua.Enabled = !key;
            btnXoa.Enabled = !key;
            btnLuu.Enabled = key;
            btnHuy.Enabled = key;
            btnThoat.Enabled = !key;

            txtMaHD.Enabled = key;
            txtTongTien.Enabled = key;
            cbMaNV.Enabled =key;
            cbMaPDK.Enabled = key;
            dtpNgayTT.Enabled = key;
        }
        public void HienThiDSHD()
        {
            dgvHoaDon.DataSource = busHoaDon.GetData();
        }

        public void HienThiMaLen_Cb()
        {        
            cbMaPDK.DataSource = busPDK.XemPhieuDangKy();
            cbMaPDK.DisplayMember = "MaPhieuDK";
            cbMaNV.DataSource = busNhanVien.GetData();
            cbMaNV.DisplayMember = "MaNV";
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            HienThiDSHD();
            KhoaBtn(false);
        }     

        private void dgvHoaDon_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvHoaDon.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_click == 0)
            {
                //txtMaHD.Text = Convert.ToString(dgvHoaDon.CurrentRow.Cells["MaHD"].Value);
                cbMaPDK.Text = Convert.ToString(dgvHoaDon.CurrentRow.Cells["MaPhieuDk"].Value);
                cbMaNV.Text = Convert.ToString(dgvHoaDon.CurrentRow.Cells["MaNV"].Value);
                txtTongTien.Text = Convert.ToString(dgvHoaDon.CurrentRow.Cells["TongTien"].Value);
                dtpNgayTT.Text = Convert.ToString(dgvHoaDon.CurrentRow.Cells["NgayThanhToan"].Value);
            }
            else
            {
                txtMaHD.Text = Convert.ToString(dgvHoaDon.CurrentRow.Cells["MaHD"].Value);
                cbMaPDK.Text = Convert.ToString(dgvHoaDon.CurrentRow.Cells["MaPhieuDk"].Value);
                cbMaNV.Text = Convert.ToString(dgvHoaDon.CurrentRow.Cells["MaNV"].Value);
                txtTongTien.Text = Convert.ToString(dgvHoaDon.CurrentRow.Cells["TongTien"].Value);
                dtpNgayTT.Text = Convert.ToString(dgvHoaDon.CurrentRow.Cells["NgayThanhToan"].Value);
            }
         }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            HienThiMaLen_Cb();
            _click = 0;
            ClearTxt();
            txtMaHD.Text = busHoaDon.TangMa();
            KhoaBtn(true);
            txtMaHD.Enabled = false;
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            HienThiMaLen_Cb();
            _click = 1;
            KhoaBtn(true);
            txtMaHD.Enabled = false;
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    busHoaDon.DeleteData(txtMaHD.Text);
                    MessageBox.Show("Xóa thành công!");
                    ClearTxt();
                    KhoaBtn(false);
                    HienThiDSHD();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex);
                }
            }
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                HienThiDSHD();
                ClearTxt();
                KhoaBtn(false);
                _click = 1;
            }
            else
                return;
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmMain m = new frmMain();
                m.Show();
                this.Close();
            }
            else
                HienThiDSHD();
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            EntityHoaDon.MaHD = txtMaHD.Text;
            EntityHoaDon.MaNV = cbMaNV.Text;
            EntityHoaDon.MaPhieuDK = cbMaPDK.Text;
            EntityHoaDon.NgayThanhToan = dtpNgayTT.Text;
            EntityHoaDon.TongTien = txtTongTien.Text;

            if (_click == 0)
            {
                try
                {
                    busHoaDon.InsertData(EntityHoaDon);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" +ex);
                }
            }
            else
            {
                try
                {
                    busHoaDon.EditData(EntityHoaDon);
                    MessageBox.Show("Sửa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi "+ex);
                }
            }
            HienThiDSHD();
            ClearTxt();
            KhoaBtn(false);
            _click = 1;
        }
   
    }
}
