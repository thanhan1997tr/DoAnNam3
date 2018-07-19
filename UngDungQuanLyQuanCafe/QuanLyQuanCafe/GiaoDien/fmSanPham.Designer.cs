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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmSanPham));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDonGiaBan_sp = new System.Windows.Forms.TextBox();
            this.txtTensp_sp = new System.Windows.Forms.TextBox();
            this.txtMasp_sp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lvSanPham = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDangBan = new System.Windows.Forms.Button();
            this.btnNgungBan = new System.Windows.Forms.Button();
            this.btnSuasp = new System.Windows.Forms.Button();
            this.btnXoasp = new System.Windows.Forms.Button();
            this.btnThemsp = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel2.Location = new System.Drawing.Point(3, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(593, 179);
            this.panel2.TabIndex = 5;
            // 
            // txtDonGiaBan_sp
            // 
            this.txtDonGiaBan_sp.Location = new System.Drawing.Point(467, 104);
            this.txtDonGiaBan_sp.Name = "txtDonGiaBan_sp";
            this.txtDonGiaBan_sp.Size = new System.Drawing.Size(122, 20);
            this.txtDonGiaBan_sp.TabIndex = 7;
            // 
            // txtTensp_sp
            // 
            this.txtTensp_sp.Location = new System.Drawing.Point(467, 50);
            this.txtTensp_sp.Name = "txtTensp_sp";
            this.txtTensp_sp.Size = new System.Drawing.Size(122, 20);
            this.txtTensp_sp.TabIndex = 6;
            // 
            // txtMasp_sp
            // 
            this.txtMasp_sp.Location = new System.Drawing.Point(467, 4);
            this.txtMasp_sp.Name = "txtMasp_sp";
            this.txtMasp_sp.Size = new System.Drawing.Size(122, 20);
            this.txtMasp_sp.TabIndex = 5;
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
            // lvSanPham
            // 
            this.lvSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5});
            this.lvSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lvSanPham.FullRowSelect = true;
            this.lvSanPham.GridLines = true;
            this.lvSanPham.Location = new System.Drawing.Point(6, 4);
            this.lvSanPham.Name = "lvSanPham";
            this.lvSanPham.Size = new System.Drawing.Size(339, 172);
            this.lvSanPham.TabIndex = 8;
            this.lvSanPham.UseCompatibleStateImageBehavior = false;
            this.lvSanPham.View = System.Windows.Forms.View.Details;
            this.lvSanPham.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvSanPham_MouseClick_1);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDangBan);
            this.panel1.Controls.Add(this.btnNgungBan);
            this.panel1.Controls.Add(this.btnSuasp);
            this.panel1.Controls.Add(this.btnXoasp);
            this.panel1.Controls.Add(this.btnThemsp);
            this.panel1.Location = new System.Drawing.Point(2, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 63);
            this.panel1.TabIndex = 4;
            // 
            // btnDangBan
            // 
            this.btnDangBan.Location = new System.Drawing.Point(359, 35);
            this.btnDangBan.Name = "btnDangBan";
            this.btnDangBan.Size = new System.Drawing.Size(225, 23);
            this.btnDangBan.TabIndex = 4;
            this.btnDangBan.Text = "Sản phẩm đang bán";
            this.btnDangBan.UseVisualStyleBackColor = true;
            this.btnDangBan.Click += new System.EventHandler(this.btnDangBan_Click_1);
            // 
            // btnNgungBan
            // 
            this.btnNgungBan.Location = new System.Drawing.Point(359, 7);
            this.btnNgungBan.Name = "btnNgungBan";
            this.btnNgungBan.Size = new System.Drawing.Size(225, 23);
            this.btnNgungBan.TabIndex = 3;
            this.btnNgungBan.Text = "Sản phẩm ngừng bán";
            this.btnNgungBan.UseVisualStyleBackColor = true;
            this.btnNgungBan.Click += new System.EventHandler(this.btnNgungBan_Click_1);
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
            this.btnSuasp.Click += new System.EventHandler(this.btnSuasp_Click_1);
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
            this.btnXoasp.Click += new System.EventHandler(this.btnXoasp_Click_1);
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
            this.btnThemsp.Click += new System.EventHandler(this.btnThemsp_Click_1);
            // 
            // fmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(599, 304);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÔNG TIN SẢN PHẨM";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDangBan;
        private System.Windows.Forms.Button btnNgungBan;
        private System.Windows.Forms.Button btnSuasp;
        private System.Windows.Forms.Button btnXoasp;
        private System.Windows.Forms.Button btnThemsp;
    }
}