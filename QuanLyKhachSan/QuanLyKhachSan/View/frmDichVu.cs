using QuanLyKhachSan.BUS;
using QuanLyKhachSan.Entity;
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
    public partial class frmDichVu : Form
    {
        DichVuEntity obj = new DichVuEntity();
        DichVuBUS Bus = new DichVuBUS();
        private int fluu = 1;
        public frmDichVu()
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
            txtMaDV.Enabled = e;
            txtTenDV.Enabled = e;
            txtGia.Enabled = e;         
        }
        private void clearData()
        {
            txtMaDV.Text = "";
            txtTenDV.Text = "";
            txtGia.Text = "";
            txtTimKiem.Text = "";
            cbTimKiem.Text = "";
        }
        private void HienThi()
        {
            dgvDichVu.DataSource = Bus.GetData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
              
                this.Close();
            }
            else
                HienThi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            txtMaDV.Text = Bus.TangMa();
            DisEnl(true);
            txtMaDV.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txtMaDV.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Bus.DeleteData(txtMaDV.Text);
                    MessageBox.Show("Xóa thành công!");
                    clearData();
                    DisEnl(false);
                    HienThi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaDV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã dịch vụ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtTenDV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên dịch vụ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtGia.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập giá dịch vụ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            int _gia;
            int.TryParse(txtGia.Text, out _gia);

            obj.MaDV = txtMaDV.Text;
            obj.TenDV = txtTenDV.Text;
            obj.Gia = _gia;
           

            if (txtMaDV.Text != "" && txtTenDV.Text != "" && txtGia.Text != ""  && fluu == 0)
            {
                try
                {
                    Bus.InsertData(obj);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmDichVu_Load(sender, e);
                    clearData();
                    DisEnl(false);
                    fluu = 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
            else if (txtMaDV.Text != "" && txtTenDV.Text != "" && txtGia.Text != "" && fluu != 0)
            {
                try
                {
                    Bus.UpdateData(obj);
                    MessageBox.Show("Sửa Thành Công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmDichVu_Load(sender, e);
                    clearData();
                    DisEnl(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
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

        private void btnLamTrong_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbTimKiem.Text == "Mã Dịch Vụ")
            {
                dgvDichVu.DataSource = Bus.TimKiem("SELECT * from DichVu where MaDV like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Tên Dịch Vụ")
            {
                dgvDichVu.DataSource = Bus.TimKiem("SELECT * from DichVu where TenDV like N'%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Giá")
            {
                dgvDichVu.DataSource = Bus.TimKiem("SELECT * from DichVu where Gia like '%" + txtTimKiem.Text.Trim() + "%'");
            }
        }

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {
                txtTenDV.Text = Convert.ToString(dgvDichVu.CurrentRow.Cells["TenDV"].Value);
                txtGia.Text = Convert.ToString(dgvDichVu.CurrentRow.Cells["Gia"].Value);               
            }
            else
            {
                txtMaDV.Text = Convert.ToString(dgvDichVu.CurrentRow.Cells["MaDV"].Value);
                txtTenDV.Text = Convert.ToString(dgvDichVu.CurrentRow.Cells["TenDV"].Value);
                txtGia.Text = Convert.ToString(dgvDichVu.CurrentRow.Cells["Gia"].Value);               
            }
        }

        private void dgvDichVu_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvDichVu.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
    }
}
