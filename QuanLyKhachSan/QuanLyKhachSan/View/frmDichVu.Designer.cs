namespace QuanLyKhachSan.View
{
    partial class frmDichVu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDichVu));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnLamTrong = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbTimKiem = new System.Windows.Forms.ComboBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvPhieuYeuCau = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPHIEU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuYeuCau)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnLamTrong);
            this.groupBox4.Controls.Add(this.btnLuu);
            this.groupBox4.Controls.Add(this.btnXoa);
            this.groupBox4.Controls.Add(this.btnSua);
            this.groupBox4.Controls.Add(this.btnThem);
            this.groupBox4.Location = new System.Drawing.Point(345, 33);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(186, 158);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức Năng";
            // 
            // btnLamTrong
            // 
            this.btnLamTrong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLamTrong.Image = ((System.Drawing.Image)(resources.GetObject("btnLamTrong.Image")));
            this.btnLamTrong.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLamTrong.Location = new System.Drawing.Point(123, 76);
            this.btnLamTrong.Name = "btnLamTrong";
            this.btnLamTrong.Size = new System.Drawing.Size(51, 53);
            this.btnLamTrong.TabIndex = 13;
            this.btnLamTrong.Text = "Làm Trống";
            this.btnLamTrong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLamTrong.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuu.Location = new System.Drawing.Point(9, 76);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(51, 53);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(123, 17);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(51, 53);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(66, 17);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(51, 53);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(9, 17);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(51, 53);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbTimKiem);
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Location = new System.Drawing.Point(37, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 64);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // cbTimKiem
            // 
            this.cbTimKiem.FormattingEnabled = true;
            this.cbTimKiem.Items.AddRange(new object[] {
            "Mã Phiếu",
            "Khách Hàng",
            "Nhân Viên",
            "Ngày Nhập"});
            this.cbTimKiem.Location = new System.Drawing.Point(269, 26);
            this.cbTimKiem.Name = "cbTimKiem";
            this.cbTimKiem.Size = new System.Drawing.Size(121, 21);
            this.cbTimKiem.TabIndex = 3;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(408, 23);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(74, 25);
            this.btnLamMoi.TabIndex = 2;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(86, 26);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(177, 20);
            this.txtTimKiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(6, 22);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(74, 26);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.dgvPhieuYeuCau);
            this.groupBox3.Location = new System.Drawing.Point(37, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(494, 278);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Phiếu Dịch Vụ";
            // 
            // dgvPhieuYeuCau
            // 
            this.dgvPhieuYeuCau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuYeuCau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MAPHIEU,
            this.MAKH,
            this.MANV,
            this.NGAYNHAP});
            this.dgvPhieuYeuCau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuYeuCau.Location = new System.Drawing.Point(3, 16);
            this.dgvPhieuYeuCau.Name = "dgvPhieuYeuCau";
            this.dgvPhieuYeuCau.Size = new System.Drawing.Size(488, 259);
            this.dgvPhieuYeuCau.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 35;
            // 
            // MAPHIEU
            // 
            this.MAPHIEU.DataPropertyName = "MAPHIEU";
            this.MAPHIEU.HeaderText = "Mã Phiếu";
            this.MAPHIEU.Name = "MAPHIEU";
            this.MAPHIEU.Width = 80;
            // 
            // MAKH
            // 
            this.MAKH.DataPropertyName = "MAKH";
            this.MAKH.HeaderText = "Mã Khách Hàng";
            this.MAKH.Name = "MAKH";
            this.MAKH.Width = 120;
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã Nhân Viên Phục Vụ";
            this.MANV.Name = "MANV";
            this.MANV.Width = 120;
            // 
            // NGAYNHAP
            // 
            this.NGAYNHAP.DataPropertyName = "NGAYNHAP";
            this.NGAYNHAP.HeaderText = "Ngày Nhập";
            this.NGAYNHAP.Name = "NGAYNHAP";
            this.NGAYNHAP.Width = 90;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtNgayNhap);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.txtMaPhieu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(32, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 158);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin Phiếu Yêu Dịch Vụ";
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.Location = new System.Drawing.Point(112, 124);
            this.dtNgayNhap.Name = "dtNgayNhap";
            this.dtNgayNhap.Size = new System.Drawing.Size(173, 20);
            this.dtNgayNhap.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ngày Nhập";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(112, 90);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(174, 20);
            this.txtMaNV.TabIndex = 6;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(112, 54);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(174, 20);
            this.txtMaKH.TabIndex = 5;
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(112, 23);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(174, 20);
            this.txtMaPhieu.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã Nhân Viên Nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Phiếu";
            // 
            // frmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 595);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDichVu";
            this.Text = "frmDichVu";
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuYeuCau)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnLamTrong;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvPhieuYeuCau;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHIEU;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYNHAP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtNgayNhap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}