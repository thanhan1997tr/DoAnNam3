namespace GiaoDien
{
    partial class rpGiaoCa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpGiaoCa));
            this.SP_HOADON_GIAOCABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new GiaoDien.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SP_HOADON_GIAOCATableAdapter = new GiaoDien.DataSet1TableAdapters.SP_HOADON_GIAOCATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SP_HOADON_GIAOCABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // SP_HOADON_GIAOCABindingSource
            // 
            this.SP_HOADON_GIAOCABindingSource.DataMember = "SP_HOADON_GIAOCA";
            this.SP_HOADON_GIAOCABindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_HOADON_GIAOCABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GiaoDien.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(573, 586);
            this.reportViewer1.TabIndex = 1;
            // 
            // SP_HOADON_GIAOCATableAdapter
            // 
            this.SP_HOADON_GIAOCATableAdapter.ClearBeforeFill = true;
            // 
            // rpGiaoCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(597, 610);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "rpGiaoCa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Kết Ca";
            this.Load += new System.EventHandler(this.rpGiaoCa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP_HOADON_GIAOCABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_HOADON_GIAOCABindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.SP_HOADON_GIAOCATableAdapter SP_HOADON_GIAOCATableAdapter;
    }
}