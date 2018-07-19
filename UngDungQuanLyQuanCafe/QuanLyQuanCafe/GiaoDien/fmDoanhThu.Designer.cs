namespace GiaoDien
{
    partial class fmDoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmDoanhThu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnTra_dt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtimeDenNgay_dt = new System.Windows.Forms.DateTimePicker();
            this.dtimeTuNgay_dt = new System.Windows.Forms.DateTimePicker();
            this.lvDoanhThu = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTongTien_dt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.btnTra_dt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtimeDenNgay_dt);
            this.panel1.Controls.Add(this.dtimeTuNgay_dt);
            this.panel1.Location = new System.Drawing.Point(2, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 84);
            this.panel1.TabIndex = 7;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLoad.Location = new System.Drawing.Point(256, 39);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(89, 31);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnTra_dt
            // 
            this.btnTra_dt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTra_dt.Location = new System.Drawing.Point(256, 1);
            this.btnTra_dt.Name = "btnTra_dt";
            this.btnTra_dt.Size = new System.Drawing.Size(89, 31);
            this.btnTra_dt.TabIndex = 3;
            this.btnTra_dt.Text = "Tra";
            this.btnTra_dt.UseVisualStyleBackColor = true;
            this.btnTra_dt.Click += new System.EventHandler(this.btnTra_dt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(532, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ ngày";
            // 
            // dtimeDenNgay_dt
            // 
            this.dtimeDenNgay_dt.CustomFormat = "dd/MM/yyyy";
            this.dtimeDenNgay_dt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtimeDenNgay_dt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtimeDenNgay_dt.Location = new System.Drawing.Point(392, 3);
            this.dtimeDenNgay_dt.Name = "dtimeDenNgay_dt";
            this.dtimeDenNgay_dt.Size = new System.Drawing.Size(134, 26);
            this.dtimeDenNgay_dt.TabIndex = 2;
            // 
            // dtimeTuNgay_dt
            // 
            this.dtimeTuNgay_dt.CustomFormat = "dd/MM/yyyy";
            this.dtimeTuNgay_dt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtimeTuNgay_dt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtimeTuNgay_dt.Location = new System.Drawing.Point(74, 3);
            this.dtimeTuNgay_dt.Name = "dtimeTuNgay_dt";
            this.dtimeTuNgay_dt.Size = new System.Drawing.Size(134, 26);
            this.dtimeTuNgay_dt.TabIndex = 1;
            // 
            // lvDoanhThu
            // 
            this.lvDoanhThu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lvDoanhThu.FullRowSelect = true;
            this.lvDoanhThu.GridLines = true;
            this.lvDoanhThu.Location = new System.Drawing.Point(59, 129);
            this.lvDoanhThu.Name = "lvDoanhThu";
            this.lvDoanhThu.Size = new System.Drawing.Size(495, 259);
            this.lvDoanhThu.TabIndex = 11;
            this.lvDoanhThu.UseCompatibleStateImageBehavior = false;
            this.lvDoanhThu.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã sản phẩm";
            this.columnHeader1.Width = 81;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên sản phẩm";
            this.columnHeader2.Width = 122;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn giá";
            this.columnHeader4.Width = 99;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Thành tiền";
            this.columnHeader5.Width = 128;
            // 
            // txtTongTien_dt
            // 
            this.txtTongTien_dt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongTien_dt.Location = new System.Drawing.Point(160, 402);
            this.txtTongTien_dt.Name = "txtTongTien_dt";
            this.txtTongTien_dt.ReadOnly = true;
            this.txtTongTien_dt.Size = new System.Drawing.Size(182, 26);
            this.txtTongTien_dt.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(55, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tổng Tiền:";
            // 
            // fmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(615, 443);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvDoanhThu);
            this.Controls.Add(this.txtTongTien_dt);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fmDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH THU THEO SẢN PHẨM";
            this.Load += new System.EventHandler(this.frmDoanhThu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnTra_dt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtimeDenNgay_dt;
        private System.Windows.Forms.DateTimePicker dtimeTuNgay_dt;
        private System.Windows.Forms.ListView lvDoanhThu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txtTongTien_dt;
        private System.Windows.Forms.Label label3;
    }
}