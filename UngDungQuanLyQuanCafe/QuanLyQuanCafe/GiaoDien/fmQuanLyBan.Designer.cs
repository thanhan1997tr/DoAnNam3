namespace GiaoDien
{
    partial class fmQuanLyBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmQuanLyBan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoaban = new System.Windows.Forms.Button();
            this.btnThemban = new System.Windows.Forms.Button();
            this.lvBan = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXoaban);
            this.panel1.Controls.Add(this.btnThemban);
            this.panel1.Location = new System.Drawing.Point(354, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 51);
            this.panel1.TabIndex = 8;
            // 
            // btnXoaban
            // 
            this.btnXoaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaban.Location = new System.Drawing.Point(124, 7);
            this.btnXoaban.Name = "btnXoaban";
            this.btnXoaban.Size = new System.Drawing.Size(102, 37);
            this.btnXoaban.TabIndex = 1;
            this.btnXoaban.Text = "Xóa";
            this.btnXoaban.UseVisualStyleBackColor = true;
            this.btnXoaban.Click += new System.EventHandler(this.btnXoaban_Click);
            // 
            // btnThemban
            // 
            this.btnThemban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemban.Location = new System.Drawing.Point(6, 7);
            this.btnThemban.Name = "btnThemban";
            this.btnThemban.Size = new System.Drawing.Size(102, 37);
            this.btnThemban.TabIndex = 0;
            this.btnThemban.Text = "Thêm";
            this.btnThemban.UseVisualStyleBackColor = true;
            this.btnThemban.Click += new System.EventHandler(this.btnThemban_Click);
            // 
            // lvBan
            // 
            this.lvBan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvBan.FullRowSelect = true;
            this.lvBan.GridLines = true;
            this.lvBan.Location = new System.Drawing.Point(9, 4);
            this.lvBan.Name = "lvBan";
            this.lvBan.Size = new System.Drawing.Size(339, 257);
            this.lvBan.TabIndex = 13;
            this.lvBan.UseCompatibleStateImageBehavior = false;
            this.lvBan.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã bàn";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên bàn";
            this.columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Trạng thái";
            this.columnHeader3.Width = 112;
            // 
            // fmQuanLyBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(597, 262);
            this.Controls.Add(this.lvBan);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmQuanLyBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmQuanLyBan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmQuanLyBan_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoaban;
        private System.Windows.Forms.Button btnThemban;
        private System.Windows.Forms.ListView lvBan;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}