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
        // PhieuDangKyBUS busPhieuDK = new PhieuDangKyBUS();
        public static string maPhieuDK;
        private int _click = 1;
        public void ClearTxt()
        {
            txtMaHD.Text = "";
           // txtTongTien.Text = "";
            dtpNgayTT.Text = DateTime.Today.ToString();
            cbMaNV.Text = "";
            cbMaPDK.Text = "";
        }

        public void KhoaBtn( bool key)
        {
            btnThem.Enabled = !key;
            //btnSua.Enabled = !key;
            btnXoa.Enabled = !key;
            btnLuu.Enabled = key;
            btnHuy.Enabled = key;
            btnThoat.Enabled = !key;

            txtMaHD.Enabled = key;
            //txtTongTien.Enabled = key;
            cbMaNV.Enabled =key;
            cbMaPDK.Enabled = key;
            dtpNgayTT.Enabled = key;
        }
        public void HienThiDSHD()
        {
            dgvDanhSachDatPhong.DataSource = busHoaDon.DanhSachDatPhong();
            dgvHoaDon.DataSource = busHoaDon.GetData();
        }

        public void HienThiMaLen_Cb()
        {        
            cbMaPDK.DataSource = busPDK.XemPhieuDangKy();
            cbMaPDK.DisplayMember = "MaPhieuDK";
            cbMaNV.DataSource = busNhanVien.GetData();
            cbMaNV.ValueMember = "MaNV";
            cbMaNV.DisplayMember = "TenNV";
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            HienThiDSHD();
            KhoaBtn(false);
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

        //private void btnSua_Click_1(object sender, EventArgs e)
        //{
        //    HienThiMaLen_Cb();
        //    _click = 1;
        //    KhoaBtn(true);
        //    txtMaHD.Enabled = false;
        //}

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if(txtMaHD.Text =="")
            {
                MessageBox.Show("Chọn hóa đơn!");
            }
            else if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            if (txtMaHD.Text == "")
            {
                MessageBox.Show("Điền thông tin!");
            }      
           // EntityHoaDon.TongTien = txtTongTien.Text;

           else if (_click == 0)
            {
                try
                {
                    EntityHoaDon.MaHD = txtMaHD.Text;
                    EntityHoaDon.MaNV = cbMaNV.SelectedValue.ToString();
                    EntityHoaDon.MaPhieuDK = cbMaPDK.Text;
                    EntityHoaDon.NgayThanhToan = dtpNgayTT.Text;

                    busHoaDon.InsertData(EntityHoaDon);
                    MessageBox.Show("Đã tạo hóa đơn!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" +ex);
                }
            }
            //else
            //{
            //    try
            //    {
            //        busHoaDon.EditData(EntityHoaDon);
            //        MessageBox.Show("Sửa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Lỗi "+ex);
            //    }
            //}
            HienThiDSHD();
            ClearTxt();
            KhoaBtn(false);
            _click = 1;
        }

        private void dgvDanhSachDatPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
  
                cbMaPDK.Text = Convert.ToString(dgvDanhSachDatPhong.CurrentRow.Cells["MaPhieuDK"].Value);
                cbMaNV.Text = Convert.ToString(dgvDanhSachDatPhong.CurrentRow.Cells["MaNV"].Value);

                 dgvDanhSachDichVu.DataSource = busHoaDon.DanhSachDichVuSuDung(cbMaPDK.Text);
        }

        private void dgvHoaDon_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (_click == 0)
            {             
                cbMaPDK.Text = Convert.ToString(dgvHoaDon.CurrentRow.Cells["MaPhieuDK2"].Value);
                cbMaNV.Text = Convert.ToString(dgvHoaDon.CurrentRow.Cells["MaNV2"].Value);                
                dtpNgayTT.Text = Convert.ToString(dgvHoaDon.CurrentRow.Cells["NgayTT"].Value);
            }
            else
            {
                txtMaHD.Text = Convert.ToString(dgvHoaDon.CurrentRow.Cells["MaHD"].Value);
                cbMaPDK.Text = Convert.ToString(dgvHoaDon.CurrentRow.Cells["MaPhieuDK2"].Value);
                cbMaNV.Text = Convert.ToString(dgvHoaDon.CurrentRow.Cells["MaNV2"].Value);              
                dtpNgayTT.Text = Convert.ToString(dgvHoaDon.CurrentRow.Cells["NgayTT"].Value);
            }
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "")
            {
                MessageBox.Show("Chọn hóa đơn!");
            }
            else
            {
                maPhieuDK = cbMaPDK.Text;
                frmInHoaDon InHoaDon = new frmInHoaDon();
                InHoaDon.Show();
                ClearTxt();
                KhoaBtn(false);
            }
        }

  

        private void dgvHoaDon_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvHoaDon.Rows[e.RowIndex].Cells["STT2"].Value = e.RowIndex + 1;
        }

        private void dgvDanhSachDichVu_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvDanhSachDichVu.Rows[e.RowIndex].Cells["STT1"].Value = e.RowIndex + 1;
        }

        private void dgvDanhSachDatPhong_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvDanhSachDatPhong.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
    }
}
