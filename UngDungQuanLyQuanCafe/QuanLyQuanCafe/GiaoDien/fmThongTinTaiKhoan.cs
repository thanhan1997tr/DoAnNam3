using BUS;
using DTO;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class fmThongTinTaiKhoan : Form
    {
        public fmThongTinTaiKhoan()
        {
            InitializeComponent();
            Load_ThongTinTaiKhoan();
        }

        TaiKhoanDTO tk = new TaiKhoanDTO("", "", "", "");
        public String getQuyen()
        {
            return tk.SQuyen;
        }
        public void Load_ThongTinTaiKhoan()
        {
            string taikhoan = fmDangNhap.getTaiKhoan.taiKhoan;
            tk = TaiKhoanBUS.Instance.LoadThongTinTaiKhoan(taikhoan, tk);
            txtTenDangNhap_tt.Text = tk.STaiKhoan;
            txtTenHienThi_tt.Text = tk.STenNhanVien;
            txtMatKhauCu_tt.Text = "";
            txtMatKhauMoi_tt.Text = "";
            txtNhapLaiMk_tt.Text = "";
        }
        public Boolean CapNhatMatKhau()
        {
            bool ktra = true;
            string matkhaumoi = MaHoaMD5.ToMD5(txtMatKhauMoi_tt.Text);
            string matkhaucu = MaHoaMD5.ToMD5(txtMatKhauCu_tt.Text);
            if(!txtMatKhauMoi_tt.Text.Equals("") && tk.SMatKhau.Equals(matkhaucu) && txtMatKhauMoi_tt.Text.Equals(txtNhapLaiMk_tt.Text))
            {
                NhanVienBUS.Instance.SuaMatKhauNhanVien(txtTenDangNhap_tt.Text, matkhaumoi);
                ktra = true;
            }
            else
            {
                ktra = false;
            }
            return ktra;
        }

        private void btnCapNhatMatKhau_tt_Click(object sender, EventArgs e)
        {
            if (CapNhatMatKhau())
            {
                Load_ThongTinTaiKhoan();
                MessageBox.Show("Cập nhật thành công.", "Thông báo.");
            }
            else
            {
                MessageBox.Show("Thất bại.", "Thông báo.");
            }
        }
    }
}
