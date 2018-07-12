namespace GiaoDien
{
    partial class fmSanPham
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
            this.tabSanPham = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSuasp = new System.Windows.Forms.Button();
            this.btnXoasp = new System.Windows.Forms.Button();
            this.btnThemsp = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDienThoaiNCC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiaChiNCC = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvNCC = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbTimNCC = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnNgungBan = new System.Windows.Forms.Button();
            this.btnDangBan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lvSanPham = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMasp_sp = new System.Windows.Forms.TextBox();
            this.txtTensp_sp = new System.Windows.Forms.TextBox();
            this.txtDonGiaBan_sp = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabSanPham.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSanPham
            // 
            this.tabSanPham.Controls.Add(this.panel2);
            this.tabSanPham.Controls.Add(this.panel1);
            this.tabSanPham.Location = new System.Drawing.Point(4, 22);
            this.tabSanPham.Name = "tabSanPham";
            this.tabSanPham.Padding = new System.Windows.Forms.Padding(3);
            this.tabSanPham.Size = new System.Drawing.Size(597, 273);
            this.tabSanPham.TabIndex = 0;
            this.tabSanPham.Text = "Sản Phẩm";
            this.tabSanPham.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDangBan);
            this.panel1.Controls.Add(this.btnNgungBan);
            this.panel1.Controls.Add(this.btnSuasp);
            this.panel1.Controls.Add(this.btnXoasp);
            this.panel1.Controls.Add(this.btnThemsp);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 63);
            this.panel1.TabIndex = 2;
            // 
            // btnSuasp
            // 
            this.btnSuasp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuasp.Location = new System.Drawing.Point(243, 7);
            this.btnSuasp.Name = "btnSuasp";
            this.btnSuasp.Size = new System.Drawing.Size(102, 37);
            this.btnSuasp.TabIndex = 2;
            this.btnSuasp.Text = "Sửa";
            this.btnSuasp.UseVisualStyleBackColor = true;
            this.btnSuasp.Click += new System.EventHandler(this.btnSuasp_Click);
            // 
            // btnXoasp
            // 
            this.btnXoasp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoasp.Location = new System.Drawing.Point(124, 7);
            this.btnXoasp.Name = "btnXoasp";
            this.btnXoasp.Size = new System.Drawing.Size(102, 37);
            this.btnXoasp.TabIndex = 1;
            this.btnXoasp.Text = "Xóa";
            this.btnXoasp.UseVisualStyleBackColor = true;
            this.btnXoasp.Click += new System.EventHandler(this.btnXoasp_Click);
            // 
            // btnThemsp
            // 
            this.btnThemsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemsp.Location = new System.Drawing.Point(6, 7);
            this.btnThemsp.Name = "btnThemsp";
            this.btnThemsp.Size = new System.Drawing.Size(102, 37);
            this.btnThemsp.TabIndex = 0;
            this.btnThemsp.Text = "Thêm";
            this.btnThemsp.UseVisualStyleBackColor = true;
            this.btnThemsp.Click += new System.EventHandler(this.btnThemsp_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSanPham);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(-3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(605, 299);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(597, 235);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtDienThoaiNCC);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtDiaChiNCC);
            this.panel3.Controls.Add(this.txtTenNCC);
            this.panel3.Controls.Add(this.txtMaNCC);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lvNCC);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(2, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(593, 181);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txtDienThoaiNCC
            // 
            this.txtDienThoaiNCC.Location = new System.Drawing.Point(466, 99);
            this.txtDienThoaiNCC.Name = "txtDienThoaiNCC";
            this.txtDienThoaiNCC.Size = new System.Drawing.Size(121, 20);
            this.txtDienThoaiNCC.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Điện thoại NCC";
            // 
            // txtDiaChiNCC
            // 
            this.txtDiaChiNCC.Location = new System.Drawing.Point(466, 65);
            this.txtDiaChiNCC.Name = "txtDiaChiNCC";
            this.txtDiaChiNCC.Size = new System.Drawing.Size(122, 20);
            this.txtDiaChiNCC.TabIndex = 7;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(466, 34);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(122, 20);
            this.txtTenNCC.TabIndex = 6;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(467, 4);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(122, 20);
            this.txtMaNCC.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(356, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Địa chỉ NCC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(355, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên NCC";
            // 
            // lvNCC
            // 
            this.lvNCC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7});
            this.lvNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lvNCC.FullRowSelect = true;
            this.lvNCC.GridLines = true;
            this.lvNCC.Location = new System.Drawing.Point(6, 4);
            this.lvNCC.Name = "lvNCC";
            this.lvNCC.Size = new System.Drawing.Size(339, 174);
            this.lvNCC.TabIndex = 8;
            this.lvNCC.UseCompatibleStateImageBehavior = false;
            this.lvNCC.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã NCC";
            this.columnHeader3.Width = 68;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên NCC";
            this.columnHeader4.Width = 93;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Địa chỉ NCC";
            this.columnHeader6.Width = 86;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Điện thoại NCC";
            this.columnHeader7.Width = 85;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(356, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mã NCC";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbTimNCC);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.button4);
            this.panel5.Location = new System.Drawing.Point(1, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(593, 50);
            this.panel5.TabIndex = 3;
            // 
            // cbTimNCC
            // 
            this.cbTimNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbTimNCC.FormattingEnabled = true;
            this.cbTimNCC.Location = new System.Drawing.Point(359, 12);
            this.cbTimNCC.Name = "cbTimNCC";
            this.cbTimNCC.Size = new System.Drawing.Size(122, 28);
            this.cbTimNCC.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(487, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.Location = new System.Drawing.Point(243, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.Location = new System.Drawing.Point(124, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 37);
            this.button3.TabIndex = 1;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button4.Location = new System.Drawing.Point(6, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 37);
            this.button4.TabIndex = 0;
            this.button4.Text = "Thêm";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnNgungBan
            // 
            this.btnNgungBan.Location = new System.Drawing.Point(359, 7);
            this.btnNgungBan.Name = "btnNgungBan";
            this.btnNgungBan.Size = new System.Drawing.Size(225, 23);
            this.btnNgungBan.TabIndex = 3;
            this.btnNgungBan.Text = "Sản phẩm ngừng bán";
            this.btnNgungBan.UseVisualStyleBackColor = true;
            this.btnNgungBan.Click += new System.EventHandler(this.btnNgungBan_Click);
            // 
            // btnDangBan
            // 
            this.btnDangBan.Location = new System.Drawing.Point(359, 35);
            this.btnDangBan.Name = "btnDangBan";
            this.btnDangBan.Size = new System.Drawing.Size(225, 23);
            this.btnDangBan.TabIndex = 4;
            this.btnDangBan.Text = "Sản phẩm đang bán";
            this.btnDangBan.UseVisualStyleBackColor = true;
            this.btnDangBan.Click += new System.EventHandler(this.btnDangBan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(356, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã sản phẩm";
            // 
            // lvSanPham
            // 
            this.lvSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5});
            this.lvSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lvSanPham.FullRowSelect = true;
            this.lvSanPham.GridLines = true;
            this.lvSanPham.Location = new System.Drawing.Point(6, 4);
            this.lvSanPham.Name = "lvSanPham";
            this.lvSanPham.Size = new System.Drawing.Size(339, 172);
            this.lvSanPham.TabIndex = 8;
            this.lvSanPham.UseCompatibleStateImageBehavior = false;
            this.lvSanPham.View = System.Windows.Forms.View.Details;
            this.lvSanPham.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvSanPham_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã sản phẩm";
            this.columnHeader1.Width = 91;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên sản phẩm";
            this.columnHeader2.Width = 157;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Đơn giá bán";
            this.columnHeader5.Width = 86;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(356, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tên sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(356, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đơn giá bán";
            // 
            // txtMasp_sp
            // 
            this.txtMasp_sp.Location = new System.Drawing.Point(467, 4);
            this.txtMasp_sp.Name = "txtMasp_sp";
            this.txtMasp_sp.Size = new System.Drawing.Size(122, 20);
            this.txtMasp_sp.TabIndex = 5;
            // 
            // txtTensp_sp
            // 
            this.txtTensp_sp.Location = new System.Drawing.Point(467, 50);
            this.txtTensp_sp.Name = "txtTensp_sp";
            this.txtTensp_sp.Size = new System.Drawing.Size(122, 20);
            this.txtTensp_sp.TabIndex = 6;
            // 
            // txtDonGiaBan_sp
            // 
            this.txtDonGiaBan_sp.Location = new System.Drawing.Point(467, 104);
            this.txtDonGiaBan_sp.Name = "txtDonGiaBan_sp";
            this.txtDonGiaBan_sp.Size = new System.Drawing.Size(122, 20);
            this.txtDonGiaBan_sp.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtDonGiaBan_sp);
            this.panel2.Controls.Add(this.txtTensp_sp);
            this.panel2.Controls.Add(this.txtMasp_sp);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lvSanPham);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(593, 179);
            this.panel2.TabIndex = 3;
            // 
            // fmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(599, 304);
            this.Controls.Add(this.tabControl1);
            this.Name = "fmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmSanPham";
            this.Load += new System.EventHandler(this.fmSanPham_Load);
            this.tabSanPham.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabSanPham;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSuasp;
        private System.Windows.Forms.Button btnXoasp;
        private System.Windows.Forms.Button btnThemsp;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtDienThoaiNCC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiaChiNCC;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvNCC;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbTimNCC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDonGiaBan_sp;
        private System.Windows.Forms.TextBox txtTensp_sp;
        private System.Windows.Forms.TextBox txtMasp_sp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvSanPham;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDangBan;
        private System.Windows.Forms.Button btnNgungBan;
    }
}