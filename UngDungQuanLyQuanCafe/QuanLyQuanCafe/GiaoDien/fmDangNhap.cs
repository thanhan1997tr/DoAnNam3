using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using Common;

namespace GiaoDien
{
    public partial class fmDangNhap : Form
    {
        public fmDangNhap()
        {
            InitializeComponent();
        }

        public static class getTaiKhoan
        {
            static public string taiKhoan;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            getTaiKhoan.taiKhoan = txtUser.Text;
            string mk = MaHoaMD5.ToMD5(txtPwd.Text);
            if (DangNhapBUS.Instance.DangNhap(getTaiKhoan.taiKhoan, mk))
            {
                fmManager f = new fmManager();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
