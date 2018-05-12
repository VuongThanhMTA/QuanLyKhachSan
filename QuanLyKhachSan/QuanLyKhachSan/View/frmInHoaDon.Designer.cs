namespace QuanLyKhachSan.View
{
    partial class frmInHoaDon
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpvInHoaDon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.chiTietHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetQLKS = new QuanLyKhachSan.DataSetQLKS();
            this.chiTietHoaDonTableAdapter = new QuanLyKhachSan.DataSetQLKSTableAdapters.ChiTietHoaDonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLKS)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvInHoaDon
            // 
            this.rpvInHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetHoaDon";
            reportDataSource1.Value = this.chiTietHoaDonBindingSource;
            this.rpvInHoaDon.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvInHoaDon.LocalReport.ReportEmbeddedResource = "QuanLyKhachSan.View.rpHoaDon.rdlc";
            this.rpvInHoaDon.Location = new System.Drawing.Point(0, 0);
            this.rpvInHoaDon.Name = "rpvInHoaDon";
            this.rpvInHoaDon.Size = new System.Drawing.Size(1010, 696);
            this.rpvInHoaDon.TabIndex = 0;
            // 
            // chiTietHoaDonBindingSource
            // 
            this.chiTietHoaDonBindingSource.DataMember = "ChiTietHoaDon";
            this.chiTietHoaDonBindingSource.DataSource = this.dataSetQLKS;
            // 
            // dataSetQLKS
            // 
            this.dataSetQLKS.DataSetName = "DataSetQLKS";
            this.dataSetQLKS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chiTietHoaDonTableAdapter
            // 
            this.chiTietHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // frmInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 696);
            this.Controls.Add(this.rpvInHoaDon);
            this.Name = "frmInHoaDon";
            this.Text = "frmInHoaDon";
            this.Load += new System.EventHandler(this.frmInHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLKS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvInHoaDon;
        private DataSetQLKS dataSetQLKS;
        private System.Windows.Forms.BindingSource chiTietHoaDonBindingSource;
        private DataSetQLKSTableAdapters.ChiTietHoaDonTableAdapter chiTietHoaDonTableAdapter;
    }
}