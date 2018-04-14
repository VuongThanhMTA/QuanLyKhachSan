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
        HoaDonBUS hoaDonBUS = new HoaDonBUS();
        HoaDonEntity hoaDonEntity = new HoaDonEntity();
        private int _click = 1;
        public void ClearTxt()
        {
            txtMaHD.Text = "";
            txtMaNV.Text = "";
            txtMaPhieuDK.Text = "";
            txtTongTien.Text = "";
            dtpNgayTT.Text = DateTime.Today.ToString();
        }

        public void KhoaBtn( bool key)
        {
            btnThem.Enabled = !key;
            btnSua.Enabled = !key;
            btnXoa.Enabled = !key;
            btnLuu.Enabled = key;
            btnHuy.Enabled = key;
            btnThoat.Enabled = !key;
        }
        public void HienThi()
        {
            dgvHoaDon.DataSource = hoaDonBUS.GetData();
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            HienThi();
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
                txtMaPhieuDK.Text = Convert.ToString(dgvHoaDon.CurrentRow.Cells["MaPhieuDk"].Value);
                txtMaNV.Text = Convert.ToString(dgvHoaDon.CurrentRow.Cells["MaNV"].Value);
                txtTongTien.Text = Convert.ToString(dgvHoaDon.CurrentRow.Cells["TongTien"].Value);
                dtpNgayTT.Text = Convert.ToString(dgvHoaDon.CurrentRow.Cells["NgayThanhToan"].Value);
            }
            else
            {
                txtMaHD.Text = Convert.ToString(dgvHoaDon.CurrentRow.Cells["MaHD"].Value);
                txtMaPhieuDK.Text = Convert.ToString(dgvHoaDon.CurrentRow.Cells["MaPhieuDk"].Value);
                txtMaNV.Text = Convert.ToString(dgvHoaDon.CurrentRow.Cells["MaNV"].Value);
                txtTongTien.Text = Convert.ToString(dgvHoaDon.CurrentRow.Cells["TongTien"].Value);
                dtpNgayTT.Text = Convert.ToString(dgvHoaDon.CurrentRow.Cells["NgayThanhToan"].Value);
            }
         }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _click = 0;
            KhoaBtn(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _click = 1;
            KhoaBtn(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    hoaDonBUS.DeleteData(txtMaHD.Text);
                    MessageBox.Show("Xóa thành công!");
                    ClearTxt();
                    KhoaBtn(false);
                    HienThi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                HienThi();
                KhoaBtn(false);
                _click = 1;
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            hoaDonEntity.MaHD = txtMaHD.Text;
            hoaDonEntity.MaNV = txtMaNV.Text;
            hoaDonEntity.MaPhieuDK = txtMaPhieuDK.Text;
            hoaDonEntity.NgayThanhToan = dtpNgayTT.Text;
            hoaDonEntity.TongTien = txtTongTien.Text;

            if (_click == 0)
            {
                try
                {
                    hoaDonBUS.InsertData(hoaDonEntity);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    ClearTxt();
                    KhoaBtn(false);
                    _click = 1;
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
                    hoaDonBUS.EditData(hoaDonEntity);
                    MessageBox.Show("Sửa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    ClearTxt();
                    KhoaBtn(false);
                    _click = 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi "+ex);
                }
            }
        }
    }
}
