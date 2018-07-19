namespace GiaoDien
{
    partial class rpHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpHoaDon));
            this.SP_HOADONCHITIET_DSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new GiaoDien.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SP_HOADONCHITIET_DSTableAdapter = new GiaoDien.DataSet1TableAdapters.SP_HOADONCHITIET_DSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SP_HOADONCHITIET_DSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // SP_HOADONCHITIET_DSBindingSource
            // 
            this.SP_HOADONCHITIET_DSBindingSource.DataMember = "SP_HOADONCHITIET_DS";
            this.SP_HOADONCHITIET_DSBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_HOADONCHITIET_DSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GiaoDien.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(526, 692);
            this.reportViewer1.TabIndex = 0;
            // 
            // SP_HOADONCHITIET_DSTableAdapter
            // 
            this.SP_HOADONCHITIET_DSTableAdapter.ClearBeforeFill = true;
            // 
            // rpHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(550, 716);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "rpHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Hóa Đơn";
            this.Load += new System.EventHandler(this.rpHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP_HOADONCHITIET_DSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_HOADONCHITIET_DSBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.SP_HOADONCHITIET_DSTableAdapter SP_HOADONCHITIET_DSTableAdapter;
    }
}