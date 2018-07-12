namespace GiaoDien
{
    partial class fmChiTietBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmChiTietBan));
            this.panel = new System.Windows.Forms.Panel();
            this.btnBotMon = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.nbrVAT = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nbrGiamGia = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nbrSoLuong_Manager = new System.Windows.Forms.NumericUpDown();
            this.cbbThemMon_Manager = new System.Windows.Forms.ComboBox();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvHoaDon = new System.Windows.Forms.ListView();
            this.clnTenMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lbnhanvien = new System.Windows.Forms.Label();
            this.lbtime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbrVAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrGiamGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrSoLuong_Manager)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Controls.Add(this.btnBotMon);
            this.panel.Controls.Add(this.btnThanhToan);
            this.panel.Controls.Add(this.nbrVAT);
            this.panel.Controls.Add(this.label11);
            this.panel.Controls.Add(this.label7);
            this.panel.Controls.Add(this.nbrGiamGia);
            this.panel.Controls.Add(this.label10);
            this.panel.Controls.Add(this.label9);
            this.panel.Controls.Add(this.label12);
            this.panel.Controls.Add(this.nbrSoLuong_Manager);
            this.panel.Controls.Add(this.cbbThemMon_Manager);
            this.panel.Controls.Add(this.btnThemMon);
            this.panel.Controls.Add(this.txtTongTien);
            this.panel.Controls.Add(this.label13);
            this.panel.Location = new System.Drawing.Point(471, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(273, 345);
            this.panel.TabIndex = 32;
            // 
            // btnBotMon
            // 
            this.btnBotMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBotMon.Location = new System.Drawing.Point(144, 179);
            this.btnBotMon.Name = "btnBotMon";
            this.btnBotMon.Size = new System.Drawing.Size(118, 41);
            this.btnBotMon.TabIndex = 33;
            this.btnBotMon.Text = "Bớt món";
            this.btnBotMon.UseVisualStyleBackColor = true;
            this.btnBotMon.Click += new System.EventHandler(this.btnBotMon_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThanhToan.Location = new System.Drawing.Point(6, 296);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(264, 41);
            this.btnThanhToan.TabIndex = 32;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // nbrVAT
            // 
            this.nbrVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nbrVAT.Location = new System.Drawing.Point(153, 134);
            this.nbrVAT.Name = "nbrVAT";
            this.nbrVAT.Size = new System.Drawing.Size(49, 26);
            this.nbrVAT.TabIndex = 31;
            this.nbrVAT.ValueChanged += new System.EventHandler(this.nbrVAT_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(212, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(212, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "%";
            // 
            // nbrGiamGia
            // 
            this.nbrGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nbrGiamGia.Location = new System.Drawing.Point(153, 87);
            this.nbrGiamGia.Name = "nbrGiamGia";
            this.nbrGiamGia.Size = new System.Drawing.Size(49, 26);
            this.nbrGiamGia.TabIndex = 30;
            this.nbrGiamGia.ValueChanged += new System.EventHandler(this.nbrGiamGia_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(48, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "VAT:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(48, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Giảm giá:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(46, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Số Lượng";
            // 
            // nbrSoLuong_Manager
            // 
            this.nbrSoLuong_Manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nbrSoLuong_Manager.Location = new System.Drawing.Point(153, 45);
            this.nbrSoLuong_Manager.Name = "nbrSoLuong_Manager";
            this.nbrSoLuong_Manager.Size = new System.Drawing.Size(83, 26);
            this.nbrSoLuong_Manager.TabIndex = 21;
            // 
            // cbbThemMon_Manager
            // 
            this.cbbThemMon_Manager.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbThemMon_Manager.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbThemMon_Manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbThemMon_Manager.FormattingEnabled = true;
            this.cbbThemMon_Manager.Location = new System.Drawing.Point(7, 4);
            this.cbbThemMon_Manager.Name = "cbbThemMon_Manager";
            this.cbbThemMon_Manager.Size = new System.Drawing.Size(263, 28);
            this.cbbThemMon_Manager.TabIndex = 20;
            // 
            // btnThemMon
            // 
            this.btnThemMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemMon.Location = new System.Drawing.Point(6, 179);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(118, 41);
            this.btnThemMon.TabIndex = 22;
            this.btnThemMon.Text = "Thêm Món";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongTien.Location = new System.Drawing.Point(52, 264);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(163, 26);
            this.txtTongTien.TabIndex = 25;
            this.txtTongTien.Text = "0";
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(11, 235);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(251, 25);
            this.label13.TabIndex = 14;
            this.label13.Text = "Tổng Tiền Thanh Toán";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.lvHoaDon);
            this.panel3.Location = new System.Drawing.Point(3, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(465, 252);
            this.panel3.TabIndex = 31;
            // 
            // lvHoaDon
            // 
            this.lvHoaDon.AllowColumnReorder = true;
            this.lvHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnTenMon,
            this.clnSoLuong,
            this.clnDonGia,
            this.clnThanhTien});
            this.lvHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lvHoaDon.FullRowSelect = true;
            this.lvHoaDon.GridLines = true;
            this.lvHoaDon.Location = new System.Drawing.Point(3, 4);
            this.lvHoaDon.Name = "lvHoaDon";
            this.lvHoaDon.Size = new System.Drawing.Size(459, 244);
            this.lvHoaDon.TabIndex = 12;
            this.lvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lvHoaDon.View = System.Windows.Forms.View.Details;
            this.lvHoaDon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvHoaDon_MouseClick);
            // 
            // clnTenMon
            // 
            this.clnTenMon.Text = "Tên Món";
            this.clnTenMon.Width = 190;
            // 
            // clnSoLuong
            // 
            this.clnSoLuong.Text = "Số Lượng";
            this.clnSoLuong.Width = 68;
            // 
            // clnDonGia
            // 
            this.clnDonGia.Text = "Đơn Giá";
            this.clnDonGia.Width = 88;
            // 
            // clnThanhTien
            // 
            this.clnThanhTien.Text = "Thành Tiền";
            this.clnThanhTien.Width = 109;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lbnhanvien);
            this.panel2.Controls.Add(this.lbtime);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 86);
            this.panel2.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(3, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nhân viên:";
            // 
            // lbnhanvien
            // 
            this.lbnhanvien.AutoSize = true;
            this.lbnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbnhanvien.Location = new System.Drawing.Point(126, 45);
            this.lbnhanvien.Name = "lbnhanvien";
            this.lbnhanvien.Size = new System.Drawing.Size(0, 24);
            this.lbnhanvien.TabIndex = 0;
            // 
            // lbtime
            // 
            this.lbtime.AutoSize = true;
            this.lbtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbtime.Location = new System.Drawing.Point(126, 5);
            this.lbtime.Name = "lbtime";
            this.lbtime.Size = new System.Drawing.Size(0, 24);
            this.lbtime.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thời gian:";
            // 
            // fmChiTietBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(745, 349);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmChiTietBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmChiTietBan_FormClosing);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbrVAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrGiamGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrSoLuong_Manager)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nbrSoLuong_Manager;
        private System.Windows.Forms.ComboBox cbbThemMon_Manager;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lvHoaDon;
        private System.Windows.Forms.ColumnHeader clnTenMon;
        private System.Windows.Forms.ColumnHeader clnSoLuong;
        private System.Windows.Forms.ColumnHeader clnDonGia;
        private System.Windows.Forms.ColumnHeader clnThanhTien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbnhanvien;
        private System.Windows.Forms.Label lbtime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.NumericUpDown nbrVAT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nbrGiamGia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBotMon;
    }
}