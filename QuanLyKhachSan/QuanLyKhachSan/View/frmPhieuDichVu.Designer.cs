namespace QuanLyKhachSan.View
{
    partial class frmPhieuDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuDichVu));
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgvPDV = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhieuDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHuy = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbDV = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtMaPDK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnLamTrong = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPDV)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox7.Controls.Add(this.dgvPDV);
            this.groupBox7.Location = new System.Drawing.Point(12, 188);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(467, 249);
            this.groupBox7.TabIndex = 20;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Chi Tiết Phiếu Dịch Vụ";
            // 
            // dgvPDV
            // 
            this.dgvPDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaPhieuDK,
            this.TenDV,
            this.SoLuong,
            this.THANHTIEN});
            this.dgvPDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPDV.Location = new System.Drawing.Point(3, 16);
            this.dgvPDV.Name = "dgvPDV";
            this.dgvPDV.Size = new System.Drawing.Size(461, 230);
            this.dgvPDV.TabIndex = 0;
            this.dgvPDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPDV_CellClick);
            this.dgvPDV.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvPDV_RowPrePaint);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // MaPhieuDK
            // 
            this.MaPhieuDK.DataPropertyName = "MaPhieuDK";
            this.MaPhieuDK.HeaderText = "Mã Phiếu ĐK";
            this.MaPhieuDK.Name = "MaPhieuDK";
            // 
            // TenDV
            // 
            this.TenDV.DataPropertyName = "TenDV";
            this.TenDV.HeaderText = "Dịch Vụ";
            this.TenDV.Name = "TenDV";
            this.TenDV.Width = 90;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 70;
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.DataPropertyName = "ThanhTien";
            this.THANHTIEN.HeaderText = "Thành Tiền";
            this.THANHTIEN.Name = "THANHTIEN";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHuy.Location = new System.Drawing.Point(66, 76);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(51, 53);
            this.btnHuy.TabIndex = 16;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbDV);
            this.groupBox6.Controls.Add(this.txtSoLuong);
            this.groupBox6.Controls.Add(this.txtMaPDK);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Location = new System.Drawing.Point(204, 24);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(275, 158);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Nhập Thông Tin Phiếu Dịch Vụ";
            // 
            // cbDV
            // 
            this.cbDV.FormattingEnabled = true;
            this.cbDV.Location = new System.Drawing.Point(83, 54);
            this.cbDV.Name = "cbDV";
            this.cbDV.Size = new System.Drawing.Size(174, 21);
            this.cbDV.TabIndex = 7;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(83, 90);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(174, 20);
            this.txtSoLuong.TabIndex = 6;
            // 
            // txtMaPDK
            // 
            this.txtMaPDK.Location = new System.Drawing.Point(83, 23);
            this.txtMaPDK.Name = "txtMaPDK";
            this.txtMaPDK.Size = new System.Drawing.Size(174, 20);
            this.txtMaPDK.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Số Lượng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Dịch Vụ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã Phiếu ĐK";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnLamTrong);
            this.groupBox5.Controls.Add(this.btnLuu);
            this.groupBox5.Controls.Add(this.btnXoa);
            this.groupBox5.Controls.Add(this.btnHuy);
            this.groupBox5.Controls.Add(this.btnSua);
            this.groupBox5.Controls.Add(this.btnThem);
            this.groupBox5.Location = new System.Drawing.Point(12, 24);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(186, 158);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chức Năng";
            // 
            // btnLamTrong
            // 
            this.btnLamTrong.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLamTrong.Image = ((System.Drawing.Image)(resources.GetObject("btnLamTrong.Image")));
            this.btnLamTrong.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLamTrong.Location = new System.Drawing.Point(123, 76);
            this.btnLamTrong.Name = "btnLamTrong";
            this.btnLamTrong.Size = new System.Drawing.Size(51, 53);
            this.btnLamTrong.TabIndex = 17;
            this.btnLamTrong.Text = "Làm Trống";
            this.btnLamTrong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLamTrong.UseVisualStyleBackColor = false;
            this.btnLamTrong.Click += new System.EventHandler(this.btnLamTrong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuu.Location = new System.Drawing.Point(9, 76);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(51, 53);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuuCT_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.SteelBlue;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(123, 17);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(51, 53);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoaCT_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(66, 17);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(51, 53);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSuaCT_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.SteelBlue;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(9, 17);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(51, 53);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.SteelBlue;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(485, 24);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(51, 53);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmPhieuDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(551, 449);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Name = "frmPhieuDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmPhieuDichVu";
            this.Load += new System.EventHandler(this.frmPhieuDichVu_Load);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPDV)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dgvPDV;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cbDV;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtMaPDK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamTrong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
        private System.Windows.Forms.Button btnSua;
    }
}