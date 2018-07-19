using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class fmTienNhapHang : Form
    {
        public fmTienNhapHang()
        {
            InitializeComponent();
            LoadDS();
        }

        public void LoadDS()
        {
            gvDoanhThuNhapHang.DataSource = DoanhThuDAO.Instance.LoadDoanhThuNhapHang();
            TongTien();
        }

        public void TongTien()
        {
            double Tong = 0;
            for (int i = 0; i < gvDoanhThuNhapHang.Rows.Count; i++)
            {
                Tong += Convert.ToDouble(gvDoanhThuNhapHang.Rows[i].Cells["ThanhTien"].Value.ToString());
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
            txtTongTien.Text = Tong.ToString("c", culture);
        }

        public void Tim()
        {
            string ngayBD = dtimeTuNgay_dt.Value.ToString("MM/dd/yyyy");
            string ngayKT = dtimeDenNgay_dt.Value.ToString("MM/dd/yyyy");
            gvDoanhThuNhapHang.DataSource = DoanhThuDAO.Instance.TimDoanhThuNhapHang(ngayBD, ngayKT);
            TongTien();
        }

        private void btnTra_dt_Click(object sender, EventArgs e)
        {
            Tim();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadDS();
        }
    }
}
