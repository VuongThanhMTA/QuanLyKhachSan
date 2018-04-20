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
    public partial class frmPhieuDichVu : Form
    {
        PhieuDichVuEntity obj = new PhieuDichVuEntity();
        PhieuDichVuBUS Bus = new PhieuDichVuBUS();
        private int fluu = 1;
        public frmPhieuDichVu()
        {
            InitializeComponent();
        }
        string ma="";
        public frmPhieuDichVu(string text):this()
        {
            ma = text;
        }
        public void ShowDV()
        {
            DataTable dt = new DataTable();
            dt = Bus.GetListDV();
            cbDV.DataSource = dt;
            cbDV.DisplayMember = "TenDV";
            cbDV.ValueMember = "MaDV";

        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
           
            txtSoLuong.Enabled = e;
            cbDV.Enabled = e;
        }
        private void clearData()
        {
            txtMaPDK.Text = "";
            txtSoLuong.Text = "";
            cbDV.Text = "";
            
        }
        private void HienThi()
        {
            txtMaPDK.Text = ma;
            dgvPDV.DataSource = Bus.GetData("SELECT MaPhieuDK,TenDV,SoLuong, ThanhTien=(Gia*SoLuong) FROM dbo.PhieuDichVu INNER JOIN dbo.DichVu ON DichVu.MaDV = PhieuDichVu.MaDV WHERE MaPhieuDK LIKE '"+txtMaPDK.Text.Trim()+"'");
            txtMaPDK.Enabled = false;
            ShowDV();
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            fluu = 0;
            DisEnl(true);
            txtMaPDK.Enabled = false;
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txtMaPDK.Enabled = false;
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Bus.DeleteData(txtMaPDK.Text,cbDV.SelectedValue.ToString());
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

        private void btnLuuCT_Click(object sender, EventArgs e)
        {
            if (txtMaPDK.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã phiếu ĐK! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cbDV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên dịch vụ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int _soLuong;
            int.TryParse(txtSoLuong.Text, out _soLuong);

            obj.MaDV = cbDV.SelectedValue.ToString();
            obj.MaPhieuDK = txtMaPDK.Text;
            obj.SoLuong = _soLuong;


            if (txtMaPDK.Text != "" && txtSoLuong.Text != "" && cbDV.Text != "" && fluu == 0)
            {
                try
                {
                    Bus.InsertData(obj);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmPhieuDichVu_Load(sender, e);
                    clearData();
                    DisEnl(false);
                    fluu = 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
            else if (txtMaPDK.Text != "" && txtSoLuong.Text != "" && cbDV.Text != "" && fluu != 0)
            {
                try
                {
                    Bus.UpdateData(obj);
                    MessageBox.Show("Sửa Thành Công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmPhieuDichVu_Load(sender, e);
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

        private void frmPhieuDichVu_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
        }

        private void dgvPDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {           
                txtMaPDK.Text = Convert.ToString(dgvPDV.CurrentRow.Cells["MaPhieuDK"].Value);
                cbDV.Text = Convert.ToString(dgvPDV.CurrentRow.Cells["TenDV"].Value);
                txtSoLuong.Text = Convert.ToString(dgvPDV.CurrentRow.Cells["SoLuong"].Value);
        }

        private void dgvPDV_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvPDV.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
    }
}
