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
    public partial class frmPhong : Form
    {
        public frmPhong()
        {
            InitializeComponent();
        }

        LoaiPhongBUS loaiPhongBUS = new LoaiPhongBUS();
        LoaiPhongEntity LoaiPhongE = new LoaiPhongEntity();
        PhongBUS phongBUS = new PhongBUS();
        PhongEntity phongE = new PhongEntity();

        private int _clickBtnPhong = 1;  // khi click vào thêm  = 0 và sửa =1 
        private int _clickBtnLoaiPhong = 1;

        public void ClearTxt_Phong()
        {          
            txtMaPhongP.Text = "";
            txtTenPhong.Text = "";
            txtTrangThai.Text = "";
            cbMaLoaiPhong.Text = "";
        }

        public void ClearTxt_LoaiPhong()
        {
            txtMaLoaiPhongLP.Text = "";
            txtLoaiPhong.Text = "";
        }
        public void KhoaBtn_Phong(bool key)
        {
            
            txtMaPhongP.Enabled = key;
            txtMaLoaiPhongLP.Enabled = key;
            txtTenPhong.Enabled = key;
            txtTrangThai.Enabled = key;
            cbMaLoaiPhong.Enabled = key;

            btnThemP.Enabled = !key;
            btnSuaP.Enabled = !key;
            btnXoaP.Enabled = !key;
            btnLuuP.Enabled = key;
            btnHuyP.Enabled = key;
            btnThoatP.Enabled = !key;
        }

        public void KhoaBtn_LoaiPhong(bool key)
        {
            txtMaLoaiPhongLP.Enabled = key;
            txtLoaiPhong.Enabled = key;

            btnThemLP.Enabled = !key;
            btnSuaLP.Enabled = !key;
            btnXoaLP.Enabled = !key;
            btnLuuLP.Enabled = key;
            btnHuyLP.Enabled = key;
            btnThoatLP.Enabled = !key;
        }
        public void HienThiMaLoaiPhong()
        {
            cbMaLoaiPhong.DataSource = loaiPhongBUS.GetData();
            cbMaLoaiPhong.DisplayMember = "MaLoaiPhong";
        }

        public void HienThi()
        {
            dgvLoaiPhong.DataSource = loaiPhongBUS.GetData();
            dgvPhong.DataSource = phongBUS.GetData();
            

        }

        private void frmPhong_Load_1(object sender, EventArgs e)
        {
            KhoaBtn_LoaiPhong(false);
            KhoaBtn_Phong(false);
            HienThi();
        }


        //PHONG
        private void btnThemP_Click(object sender, EventArgs e)
        {
            HienThiMaLoaiPhong();
            _clickBtnPhong = 0;
            KhoaBtn_Phong(true);
            txtMaPhongP.Text = phongBUS.TangMa();
            txtMaPhongP.Enabled = false;
        }

        private void btnSuaP_Click(object sender, EventArgs e)
        {
            HienThiMaLoaiPhong();
            _clickBtnPhong = 1;
            KhoaBtn_Phong(true);   
            txtMaPhongP.Enabled = false;
        }

        private void btnXoaP_Click(object sender, EventArgs e)
        {
            if (txtMaPhongP.Text == "")
                MessageBox.Show("Chọn đối tượng cần xóa !");
            else
            {
                if(phongBUS.PhongDangSuDung(txtMaPhongP.Text) == true)
                    MessageBox.Show("Phòng đang được đăng ký không thể xóa !!");
                else if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        phongBUS.DeleteData(txtMaPhongP.Text);
                        MessageBox.Show("Xóa thành công!");
                        ClearTxt_Phong();
                        KhoaBtn_Phong(false);
                        HienThi();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi " + ex);
                    }
                }
            }
        }

        private void btnLuuP_Click(object sender, EventArgs e)
        {
            if (txtMaPhongP.Text == "" || txtTenPhong.Text == "")
            {
                MessageBox.Show("Nhâp chưa đầy đủ thông tin !");

            }
            else
            {
                phongE.MaPhong = txtMaPhongP.Text;
                phongE.MaLoaiPhong = cbMaLoaiPhong.Text;
                phongE.TenPhong = txtTenPhong.Text;
                phongE.TrangThai = txtTrangThai.Text;

                if (_clickBtnPhong == 0)
                {
                    try
                    {
                        phongBUS.InsertData(phongE);
                        MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi!  " + ex);
                    }
                }
                else
                {
                    try
                    {
                        phongBUS.EditData(phongE);
                        MessageBox.Show("Sửa Thành Công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi " + ex);
                    }
                }
                HienThi();
                ClearTxt_Phong();
                KhoaBtn_Phong(false);
                _clickBtnPhong = 1;
            }        
        }

        private void btnHuyP_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                HienThi();
                ClearTxt_Phong();
                KhoaBtn_Phong(false);
                _clickBtnPhong = 1;
            }
            else
                return;
        }

        private void btnThoatP_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn thoát", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
                HienThi();
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_clickBtnPhong == 0)
            {
                cbMaLoaiPhong.Text = Convert.ToString(dgvPhong.CurrentRow.Cells["MaLoaiPhong1"].Value);
                txtTenPhong.Text = Convert.ToString(dgvPhong.CurrentRow.Cells["TenPhong"].Value);
                txtTrangThai.Text = Convert.ToString(dgvPhong.CurrentRow.Cells["TrangThai"].Value);
            }
            else
            {
                cbMaLoaiPhong.Text = Convert.ToString(dgvPhong.CurrentRow.Cells["MaLoaiPhong1"].Value);
                txtMaPhongP.Text = Convert.ToString(dgvPhong.CurrentRow.Cells["MaPhong"].Value);
                txtTenPhong.Text = Convert.ToString(dgvPhong.CurrentRow.Cells["TenPhong"].Value);
                txtTrangThai.Text = Convert.ToString(dgvPhong.CurrentRow.Cells["TrangThai"].Value);
            }
        }

        private void dgvPhong_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvPhong.Rows[e.RowIndex].Cells["STT1"].Value = e.RowIndex + 1;
        }


        //LOAI PHONG
        private void btnThemLP_Click(object sender, EventArgs e)
        {
            _clickBtnLoaiPhong = 0;
            KhoaBtn_LoaiPhong(true);
            txtMaLoaiPhongLP.Text = loaiPhongBUS.TangMa();
            txtMaLoaiPhongLP.Enabled = false;
        }

        private void btnSuaLP_Click(object sender, EventArgs e)
        {
            _clickBtnLoaiPhong = 1;
            KhoaBtn_LoaiPhong(true);
            txtMaLoaiPhongLP.Enabled = false;
        }

        private void btnXoaLP_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiPhongLP.Text == "")
            {
                MessageBox.Show("Chọn đối tượng xóa!");
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        loaiPhongBUS.DeleteData(txtMaLoaiPhongLP.Text);
                        MessageBox.Show("Xóa thành công!");
                        ClearTxt_LoaiPhong();
                        KhoaBtn_LoaiPhong(false);
                        HienThi();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi " + ex);
                    }
                }
            }
        }

        private void btnLuuLP_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiPhongLP.Text == "" || txtLoaiPhong.Text == "")
            {
                MessageBox.Show("Nhâp chưa đầy đủ thông tin !");

            }
            else
            {
                LoaiPhongE.LoaiPhong = txtLoaiPhong.Text;
                LoaiPhongE.MaLoaiPhong = txtMaLoaiPhongLP.Text;


                if (_clickBtnLoaiPhong == 0)
                {
                    try
                    {
                        loaiPhongBUS.InsertData(LoaiPhongE);
                        MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi!  " + ex);
                    }
                }
                else
                {
                    try
                    {
                        loaiPhongBUS.EditData(LoaiPhongE);
                        MessageBox.Show("Sửa Thành Công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi " + ex);
                    }
                }
                HienThi();
                ClearTxt_LoaiPhong();
                KhoaBtn_LoaiPhong(false);
                _clickBtnLoaiPhong = 1;
            }
        }

        private void btnHuyLP_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                HienThi();
                ClearTxt_LoaiPhong();
                KhoaBtn_LoaiPhong(false);
                _clickBtnLoaiPhong = 1;
            }
            else
                return;
        }

        private void btnThoatLP_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn thoát", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
                HienThi();
        }

        private void dgvLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_clickBtnLoaiPhong == 0)
            {
               // txtMaLoaiPhongLP.Text = Convert.ToString(dgvPhong.CurrentRow.Cells["MaLoaiPhong"].Value);
                txtLoaiPhong.Text = Convert.ToString(dgvLoaiPhong.CurrentRow.Cells["LoaiPhong"].Value);

            }
            else
            {
                txtMaLoaiPhongLP.Text = Convert.ToString(dgvLoaiPhong.CurrentRow.Cells["MaLoaiPhong"].Value);
                txtLoaiPhong.Text = Convert.ToString(dgvLoaiPhong.CurrentRow.Cells["LoaiPhong"].Value);
            }
        }

        private void dgvLoaiPhong_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvLoaiPhong.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
    }
}
