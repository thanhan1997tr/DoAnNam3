﻿namespace GiaoDien
{
    partial class fmHoaDonTheoNgay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmHoaDonTheoNgay));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimhd = new System.Windows.Forms.Button();
            this.dtimeDenNgay_xhd = new System.Windows.Forms.DateTimePicker();
            this.dtimeTuNgay_xhd = new System.Windows.Forms.DateTimePicker();
            this.btnLoad = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvXemHoaDon = new System.Windows.Forms.ListView();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSoHoaDon = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnTimhd);
            this.panel1.Controls.Add(this.dtimeDenNgay_xhd);
            this.panel1.Controls.Add(this.dtimeTuNgay_xhd);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Location = new System.Drawing.Point(245, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 34);
            this.panel1.TabIndex = 6;
            // 
            // btnTimhd
            // 
            this.btnTimhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimhd.Location = new System.Drawing.Point(362, 3);
            this.btnTimhd.Name = "btnTimhd";
            this.btnTimhd.Size = new System.Drawing.Size(81, 27);
            this.btnTimhd.TabIndex = 3;
            this.btnTimhd.Text = "Tìm";
            this.btnTimhd.UseVisualStyleBackColor = true;
            this.btnTimhd.Click += new System.EventHandler(this.btnTimhd_Click);
            // 
            // dtimeDenNgay_xhd
            // 
            this.dtimeDenNgay_xhd.CustomFormat = "dd/MM/yyyy";
            this.dtimeDenNgay_xhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtimeDenNgay_xhd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtimeDenNgay_xhd.Location = new System.Drawing.Point(195, 3);
            this.dtimeDenNgay_xhd.Name = "dtimeDenNgay_xhd";
            this.dtimeDenNgay_xhd.Size = new System.Drawing.Size(135, 26);
            this.dtimeDenNgay_xhd.TabIndex = 2;
            // 
            // dtimeTuNgay_xhd
            // 
            this.dtimeTuNgay_xhd.CustomFormat = "dd/MM/yyyy";
            this.dtimeTuNgay_xhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtimeTuNgay_xhd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtimeTuNgay_xhd.Location = new System.Drawing.Point(3, 3);
            this.dtimeTuNgay_xhd.Name = "dtimeTuNgay_xhd";
            this.dtimeTuNgay_xhd.Size = new System.Drawing.Size(135, 26);
            this.dtimeTuNgay_xhd.TabIndex = 1;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLoad.Location = new System.Drawing.Point(465, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 27);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã hóa đơn";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ngày nhập";
            this.columnHeader2.Width = 137;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày xuất";
            this.columnHeader3.Width = 128;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã nv nhập";
            this.columnHeader4.Width = 118;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã bàn";
            this.columnHeader5.Width = 103;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Giảm giá";
            this.columnHeader6.Width = 91;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "VAT";
            this.columnHeader7.Width = 87;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Thanh toán";
            this.columnHeader8.Width = 123;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ghi chú";
            this.columnHeader9.Width = 121;
            // 
            // lvXemHoaDon
            // 
            this.lvXemHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvXemHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lvXemHoaDon.FullRowSelect = true;
            this.lvXemHoaDon.GridLines = true;
            this.lvXemHoaDon.Location = new System.Drawing.Point(4, 42);
            this.lvXemHoaDon.Name = "lvXemHoaDon";
            this.lvXemHoaDon.Size = new System.Drawing.Size(1035, 396);
            this.lvXemHoaDon.TabIndex = 7;
            this.lvXemHoaDon.UseCompatibleStateImageBehavior = false;
            this.lvXemHoaDon.View = System.Windows.Forms.View.Details;
            this.lvXemHoaDon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvXemHoaDon_MouseDoubleClick);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(890, 454);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(85, 21);
            this.lblTongTien.TabIndex = 17;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(799, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tổng tiền:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tổng số hóa đơn:";
            // 
            // lblSoHoaDon
            // 
            this.lblSoHoaDon.AutoSize = true;
            this.lblSoHoaDon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoHoaDon.Location = new System.Drawing.Point(150, 441);
            this.lblSoHoaDon.Name = "lblSoHoaDon";
            this.lblSoHoaDon.Size = new System.Drawing.Size(101, 21);
            this.lblSoHoaDon.TabIndex = 19;
            this.lblSoHoaDon.Text = "Số hóa đơn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "==>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(2, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Double Click vào từng hóa đơn để xem chi tiết";
            // 
            // fmHoaDonTheoNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1042, 495);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSoHoaDon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvXemHoaDon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmHoaDonTheoNgay";
            this.Text = "Thống kê hóa đơn theo ngày";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTimhd;
        private System.Windows.Forms.DateTimePicker dtimeDenNgay_xhd;
        private System.Windows.Forms.DateTimePicker dtimeTuNgay_xhd;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ListView lvXemHoaDon;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSoHoaDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}