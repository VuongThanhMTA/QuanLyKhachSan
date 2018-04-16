namespace QuanLyKhachSan.View
{
    partial class frmPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhong));
            this.tcPhong = new System.Windows.Forms.TabControl();
            this.tpPhong = new System.Windows.Forms.TabPage();
            this.cbMaLoaiPhong = new System.Windows.Forms.ComboBox();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaPhongP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.STT1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiPhong1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHuyP = new System.Windows.Forms.Button();
            this.btnLuuP = new System.Windows.Forms.Button();
            this.btnThoatP = new System.Windows.Forms.Button();
            this.btnXoaP = new System.Windows.Forms.Button();
            this.btnSuaP = new System.Windows.Forms.Button();
            this.btnThemP = new System.Windows.Forms.Button();
            this.tpLoaiPhong = new System.Windows.Forms.TabPage();
            this.btnHuyLP = new System.Windows.Forms.Button();
            this.btnLuuLP = new System.Windows.Forms.Button();
            this.btnThoatLP = new System.Windows.Forms.Button();
            this.btnXoaLP = new System.Windows.Forms.Button();
            this.btnSuaLP = new System.Windows.Forms.Button();
            this.btnThemLP = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoaiPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaLoaiPhongLP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLoaiPhong = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcPhong.SuspendLayout();
            this.tpPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.tpLoaiPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // tcPhong
            // 
            this.tcPhong.Controls.Add(this.tpPhong);
            this.tcPhong.Controls.Add(this.tpLoaiPhong);
            this.tcPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcPhong.Location = new System.Drawing.Point(0, 0);
            this.tcPhong.Margin = new System.Windows.Forms.Padding(4);
            this.tcPhong.MinimumSize = new System.Drawing.Size(1207, 658);
            this.tcPhong.Name = "tcPhong";
            this.tcPhong.SelectedIndex = 0;
            this.tcPhong.Size = new System.Drawing.Size(1210, 684);
            this.tcPhong.TabIndex = 0;
            // 
            // tpPhong
            // 
            this.tpPhong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tpPhong.Controls.Add(this.cbMaLoaiPhong);
            this.tpPhong.Controls.Add(this.txtTrangThai);
            this.tpPhong.Controls.Add(this.label8);
            this.tpPhong.Controls.Add(this.label7);
            this.tpPhong.Controls.Add(this.label6);
            this.tpPhong.Controls.Add(this.txtTenPhong);
            this.tpPhong.Controls.Add(this.label4);
            this.tpPhong.Controls.Add(this.txtMaPhongP);
            this.tpPhong.Controls.Add(this.label5);
            this.tpPhong.Controls.Add(this.dgvPhong);
            this.tpPhong.Controls.Add(this.btnHuyP);
            this.tpPhong.Controls.Add(this.btnLuuP);
            this.tpPhong.Controls.Add(this.btnThoatP);
            this.tpPhong.Controls.Add(this.btnXoaP);
            this.tpPhong.Controls.Add(this.btnSuaP);
            this.tpPhong.Controls.Add(this.btnThemP);
            this.tpPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpPhong.Location = new System.Drawing.Point(4, 31);
            this.tpPhong.Margin = new System.Windows.Forms.Padding(4);
            this.tpPhong.Name = "tpPhong";
            this.tpPhong.Padding = new System.Windows.Forms.Padding(4);
            this.tpPhong.Size = new System.Drawing.Size(1202, 649);
            this.tpPhong.TabIndex = 0;
            this.tpPhong.Text = "Quản Lý Phòng";
            // 
            // cbMaLoaiPhong
            // 
            this.cbMaLoaiPhong.FormattingEnabled = true;
            this.cbMaLoaiPhong.Location = new System.Drawing.Point(166, 308);
            this.cbMaLoaiPhong.Name = "cbMaLoaiPhong";
            this.cbMaLoaiPhong.Size = new System.Drawing.Size(248, 30);
            this.cbMaLoaiPhong.TabIndex = 51;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(166, 401);
            this.txtTrangThai.Margin = new System.Windows.Forms.Padding(6);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(248, 30);
            this.txtTrangThai.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 409);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 22);
            this.label8.TabIndex = 49;
            this.label8.Text = "Trạng Thái:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 316);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 22);
            this.label7.TabIndex = 47;
            this.label7.Text = "Mã Loại Phòng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(564, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 37);
            this.label6.TabIndex = 46;
            this.label6.Text = "Quản Lý Phòng";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(166, 213);
            this.txtTenPhong.Margin = new System.Windows.Forms.Padding(6);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(248, 30);
            this.txtTenPhong.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 221);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 22);
            this.label4.TabIndex = 44;
            this.label4.Text = "Tên Phòng :";
            // 
            // txtMaPhongP
            // 
            this.txtMaPhongP.Location = new System.Drawing.Point(166, 121);
            this.txtMaPhongP.Margin = new System.Windows.Forms.Padding(6);
            this.txtMaPhongP.Name = "txtMaPhongP";
            this.txtMaPhongP.Size = new System.Drawing.Size(248, 30);
            this.txtMaPhongP.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 22);
            this.label5.TabIndex = 42;
            this.label5.Text = "Mã  Phòng:";
            // 
            // dgvPhong
            // 
            this.dgvPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhong.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT1,
            this.MaPhong,
            this.TenPhong,
            this.MaLoaiPhong1,
            this.TrangThai});
            this.dgvPhong.Location = new System.Drawing.Point(437, 93);
            this.dgvPhong.Margin = new System.Windows.Forms.Padding(6);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowTemplate.Height = 24;
            this.dgvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhong.Size = new System.Drawing.Size(736, 411);
            this.dgvPhong.TabIndex = 41;
            this.dgvPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellClick);
            this.dgvPhong.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvPhong_RowPrePaint);
            // 
            // STT1
            // 
            this.STT1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.STT1.HeaderText = "STT";
            this.STT1.Name = "STT1";
            this.STT1.Width = 74;
            // 
            // MaPhong
            // 
            this.MaPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.Name = "MaPhong";
            // 
            // TenPhong
            // 
            this.TenPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Tên Phòng";
            this.TenPhong.Name = "TenPhong";
            // 
            // MaLoaiPhong1
            // 
            this.MaLoaiPhong1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaLoaiPhong1.DataPropertyName = "MaLoaiPhong";
            this.MaLoaiPhong1.HeaderText = "Mã Loại Phòng";
            this.MaLoaiPhong1.Name = "MaLoaiPhong1";
            // 
            // TrangThai
            // 
            this.TrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.Name = "TrangThai";
            // 
            // btnHuyP
            // 
            this.btnHuyP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuyP.Enabled = false;
            this.btnHuyP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnHuyP.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyP.Image")));
            this.btnHuyP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHuyP.Location = new System.Drawing.Point(833, 569);
            this.btnHuyP.Margin = new System.Windows.Forms.Padding(6);
            this.btnHuyP.Name = "btnHuyP";
            this.btnHuyP.Size = new System.Drawing.Size(128, 54);
            this.btnHuyP.TabIndex = 40;
            this.btnHuyP.Text = "Hủy";
            this.btnHuyP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuyP.UseVisualStyleBackColor = true;
            this.btnHuyP.Click += new System.EventHandler(this.btnHuyP_Click);
            // 
            // btnLuuP
            // 
            this.btnLuuP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuP.Enabled = false;
            this.btnLuuP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLuuP.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuP.Image")));
            this.btnLuuP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuuP.Location = new System.Drawing.Point(635, 569);
            this.btnLuuP.Margin = new System.Windows.Forms.Padding(6);
            this.btnLuuP.Name = "btnLuuP";
            this.btnLuuP.Size = new System.Drawing.Size(136, 54);
            this.btnLuuP.TabIndex = 39;
            this.btnLuuP.Text = "Lưu";
            this.btnLuuP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLuuP.UseVisualStyleBackColor = true;
            this.btnLuuP.Click += new System.EventHandler(this.btnLuuP_Click);
            // 
            // btnThoatP
            // 
            this.btnThoatP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoatP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThoatP.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatP.Image")));
            this.btnThoatP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoatP.Location = new System.Drawing.Point(1028, 569);
            this.btnThoatP.Margin = new System.Windows.Forms.Padding(6);
            this.btnThoatP.Name = "btnThoatP";
            this.btnThoatP.Size = new System.Drawing.Size(136, 54);
            this.btnThoatP.TabIndex = 38;
            this.btnThoatP.Text = "Thoát";
            this.btnThoatP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoatP.UseVisualStyleBackColor = true;
            this.btnThoatP.Click += new System.EventHandler(this.btnThoatP_Click);
            // 
            // btnXoaP
            // 
            this.btnXoaP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnXoaP.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaP.Image")));
            this.btnXoaP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoaP.Location = new System.Drawing.Point(458, 569);
            this.btnXoaP.Margin = new System.Windows.Forms.Padding(6);
            this.btnXoaP.Name = "btnXoaP";
            this.btnXoaP.Size = new System.Drawing.Size(129, 53);
            this.btnXoaP.TabIndex = 37;
            this.btnXoaP.Text = "Xóa";
            this.btnXoaP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoaP.UseVisualStyleBackColor = true;
            this.btnXoaP.Click += new System.EventHandler(this.btnXoaP_Click);
            // 
            // btnSuaP
            // 
            this.btnSuaP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSuaP.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaP.Image")));
            this.btnSuaP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSuaP.Location = new System.Drawing.Point(309, 568);
            this.btnSuaP.Margin = new System.Windows.Forms.Padding(6);
            this.btnSuaP.Name = "btnSuaP";
            this.btnSuaP.Size = new System.Drawing.Size(126, 54);
            this.btnSuaP.TabIndex = 36;
            this.btnSuaP.Text = "Sửa";
            this.btnSuaP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSuaP.UseVisualStyleBackColor = true;
            this.btnSuaP.Click += new System.EventHandler(this.btnSuaP_Click);
            // 
            // btnThemP
            // 
            this.btnThemP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThemP.Image = ((System.Drawing.Image)(resources.GetObject("btnThemP.Image")));
            this.btnThemP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThemP.Location = new System.Drawing.Point(141, 569);
            this.btnThemP.Margin = new System.Windows.Forms.Padding(6);
            this.btnThemP.Name = "btnThemP";
            this.btnThemP.Size = new System.Drawing.Size(125, 53);
            this.btnThemP.TabIndex = 35;
            this.btnThemP.Text = "Thêm";
            this.btnThemP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThemP.UseVisualStyleBackColor = true;
            this.btnThemP.Click += new System.EventHandler(this.btnThemP_Click);
            // 
            // tpLoaiPhong
            // 
            this.tpLoaiPhong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tpLoaiPhong.Controls.Add(this.btnHuyLP);
            this.tpLoaiPhong.Controls.Add(this.btnLuuLP);
            this.tpLoaiPhong.Controls.Add(this.btnThoatLP);
            this.tpLoaiPhong.Controls.Add(this.btnXoaLP);
            this.tpLoaiPhong.Controls.Add(this.btnSuaLP);
            this.tpLoaiPhong.Controls.Add(this.btnThemLP);
            this.tpLoaiPhong.Controls.Add(this.label3);
            this.tpLoaiPhong.Controls.Add(this.txtLoaiPhong);
            this.tpLoaiPhong.Controls.Add(this.label2);
            this.tpLoaiPhong.Controls.Add(this.txtMaLoaiPhongLP);
            this.tpLoaiPhong.Controls.Add(this.label1);
            this.tpLoaiPhong.Controls.Add(this.dgvLoaiPhong);
            this.tpLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpLoaiPhong.Location = new System.Drawing.Point(4, 31);
            this.tpLoaiPhong.Margin = new System.Windows.Forms.Padding(4);
            this.tpLoaiPhong.Name = "tpLoaiPhong";
            this.tpLoaiPhong.Padding = new System.Windows.Forms.Padding(4);
            this.tpLoaiPhong.Size = new System.Drawing.Size(1202, 649);
            this.tpLoaiPhong.TabIndex = 1;
            this.tpLoaiPhong.Text = "Quản Lý Loại Phong";
            // 
            // btnHuyLP
            // 
            this.btnHuyLP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuyLP.Enabled = false;
            this.btnHuyLP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyLP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnHuyLP.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyLP.Image")));
            this.btnHuyLP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHuyLP.Location = new System.Drawing.Point(795, 565);
            this.btnHuyLP.Margin = new System.Windows.Forms.Padding(6);
            this.btnHuyLP.Name = "btnHuyLP";
            this.btnHuyLP.Size = new System.Drawing.Size(128, 54);
            this.btnHuyLP.TabIndex = 46;
            this.btnHuyLP.Text = "Hủy";
            this.btnHuyLP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuyLP.UseVisualStyleBackColor = true;
            this.btnHuyLP.Click += new System.EventHandler(this.btnHuyLP_Click);
            // 
            // btnLuuLP
            // 
            this.btnLuuLP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuLP.Enabled = false;
            this.btnLuuLP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuLP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLuuLP.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuLP.Image")));
            this.btnLuuLP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuuLP.Location = new System.Drawing.Point(597, 565);
            this.btnLuuLP.Margin = new System.Windows.Forms.Padding(6);
            this.btnLuuLP.Name = "btnLuuLP";
            this.btnLuuLP.Size = new System.Drawing.Size(136, 54);
            this.btnLuuLP.TabIndex = 45;
            this.btnLuuLP.Text = "Lưu";
            this.btnLuuLP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLuuLP.UseVisualStyleBackColor = true;
            this.btnLuuLP.Click += new System.EventHandler(this.btnLuuLP_Click);
            // 
            // btnThoatLP
            // 
            this.btnThoatLP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoatLP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatLP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThoatLP.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatLP.Image")));
            this.btnThoatLP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoatLP.Location = new System.Drawing.Point(990, 565);
            this.btnThoatLP.Margin = new System.Windows.Forms.Padding(6);
            this.btnThoatLP.Name = "btnThoatLP";
            this.btnThoatLP.Size = new System.Drawing.Size(136, 54);
            this.btnThoatLP.TabIndex = 44;
            this.btnThoatLP.Text = "Thoát";
            this.btnThoatLP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoatLP.UseVisualStyleBackColor = true;
            this.btnThoatLP.Click += new System.EventHandler(this.btnThoatLP_Click);
            // 
            // btnXoaLP
            // 
            this.btnXoaLP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaLP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnXoaLP.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaLP.Image")));
            this.btnXoaLP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoaLP.Location = new System.Drawing.Point(430, 566);
            this.btnXoaLP.Margin = new System.Windows.Forms.Padding(6);
            this.btnXoaLP.Name = "btnXoaLP";
            this.btnXoaLP.Size = new System.Drawing.Size(129, 53);
            this.btnXoaLP.TabIndex = 43;
            this.btnXoaLP.Text = "Xóa";
            this.btnXoaLP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoaLP.UseVisualStyleBackColor = true;
            this.btnXoaLP.Click += new System.EventHandler(this.btnXoaLP_Click);
            // 
            // btnSuaLP
            // 
            this.btnSuaLP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaLP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSuaLP.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaLP.Image")));
            this.btnSuaLP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSuaLP.Location = new System.Drawing.Point(262, 565);
            this.btnSuaLP.Margin = new System.Windows.Forms.Padding(6);
            this.btnSuaLP.Name = "btnSuaLP";
            this.btnSuaLP.Size = new System.Drawing.Size(126, 54);
            this.btnSuaLP.TabIndex = 42;
            this.btnSuaLP.Text = "Sửa";
            this.btnSuaLP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSuaLP.UseVisualStyleBackColor = true;
            this.btnSuaLP.Click += new System.EventHandler(this.btnSuaLP_Click);
            // 
            // btnThemLP
            // 
            this.btnThemLP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemLP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThemLP.Image = ((System.Drawing.Image)(resources.GetObject("btnThemLP.Image")));
            this.btnThemLP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThemLP.Location = new System.Drawing.Point(103, 565);
            this.btnThemLP.Margin = new System.Windows.Forms.Padding(6);
            this.btnThemLP.Name = "btnThemLP";
            this.btnThemLP.Size = new System.Drawing.Size(125, 53);
            this.btnThemLP.TabIndex = 41;
            this.btnThemLP.Text = "Thêm";
            this.btnThemLP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThemLP.UseVisualStyleBackColor = true;
            this.btnThemLP.Click += new System.EventHandler(this.btnThemLP_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(544, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 37);
            this.label3.TabIndex = 35;
            this.label3.Text = "Quản Lý Loại Phòng";
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Location = new System.Drawing.Point(241, 229);
            this.txtLoaiPhong.Margin = new System.Windows.Forms.Padding(6);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.Size = new System.Drawing.Size(251, 30);
            this.txtLoaiPhong.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 236);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "Loại Phòng :";
            // 
            // txtMaLoaiPhongLP
            // 
            this.txtMaLoaiPhongLP.Location = new System.Drawing.Point(241, 131);
            this.txtMaLoaiPhongLP.Margin = new System.Windows.Forms.Padding(6);
            this.txtMaLoaiPhongLP.Name = "txtMaLoaiPhongLP";
            this.txtMaLoaiPhongLP.Size = new System.Drawing.Size(251, 30);
            this.txtMaLoaiPhongLP.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 22);
            this.label1.TabIndex = 31;
            this.label1.Text = "Mã Loại Phòng:";
            // 
            // dgvLoaiPhong
            // 
            this.dgvLoaiPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLoaiPhong.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaLoaiPhong,
            this.LoaiPhong});
            this.dgvLoaiPhong.Location = new System.Drawing.Point(515, 125);
            this.dgvLoaiPhong.Margin = new System.Windows.Forms.Padding(6);
            this.dgvLoaiPhong.Name = "dgvLoaiPhong";
            this.dgvLoaiPhong.RowTemplate.Height = 24;
            this.dgvLoaiPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiPhong.Size = new System.Drawing.Size(673, 371);
            this.dgvLoaiPhong.TabIndex = 30;
            this.dgvLoaiPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiPhong_CellClick);
            this.dgvLoaiPhong.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvLoaiPhong_RowPrePaint);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 74;
            // 
            // MaLoaiPhong
            // 
            this.MaLoaiPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaLoaiPhong.DataPropertyName = "MaLoaiPhong";
            this.MaLoaiPhong.HeaderText = "Mã Loại Phòng";
            this.MaLoaiPhong.Name = "MaLoaiPhong";
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LoaiPhong.DataPropertyName = "LoaiPhong";
            this.LoaiPhong.HeaderText = "Loại Phòng";
            this.LoaiPhong.Name = "LoaiPhong";
            // 
            // frmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 684);
            this.Controls.Add(this.tcPhong);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1228, 731);
            this.MinimumSize = new System.Drawing.Size(1228, 731);
            this.Name = "frmPhong";
            this.Text = "Quản Lý Phòng ";
            this.Load += new System.EventHandler(this.frmPhong_Load_1);
            this.tcPhong.ResumeLayout(false);
            this.tpPhong.ResumeLayout(false);
            this.tpPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.tpLoaiPhong.ResumeLayout(false);
            this.tpLoaiPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcPhong;
        private System.Windows.Forms.TabPage tpPhong;
        private System.Windows.Forms.TabPage tpLoaiPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLoaiPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaLoaiPhongLP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLoaiPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaPhongP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiPhong1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.Button btnHuyP;
        private System.Windows.Forms.Button btnLuuP;
        private System.Windows.Forms.Button btnThoatP;
        private System.Windows.Forms.Button btnXoaP;
        private System.Windows.Forms.Button btnSuaP;
        private System.Windows.Forms.Button btnThemP;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbMaLoaiPhong;
        private System.Windows.Forms.Button btnHuyLP;
        private System.Windows.Forms.Button btnLuuLP;
        private System.Windows.Forms.Button btnThoatLP;
        private System.Windows.Forms.Button btnXoaLP;
        private System.Windows.Forms.Button btnSuaLP;
        private System.Windows.Forms.Button btnThemLP;
    }
}