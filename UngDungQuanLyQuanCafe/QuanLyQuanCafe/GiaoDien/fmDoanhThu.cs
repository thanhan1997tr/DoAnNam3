using BUS;
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
    public partial class fmDoanhThu : Form
    {
        public fmDoanhThu()
        {
            InitializeComponent();
            loadDoanhThu();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadDoanhThu();
        }

        private void frmDoanhThu_Load(object sender, EventArgs e)
        {

        }

        private void loadDoanhThu()
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
            txtTongTien_dt.Text = DoanhThuBUS.Instance.load(lvDoanhThu).ToString("c", culture);
        }

        private void loadDoanhThuTheoNgay()
        {
            string ngayBD = dtimeTuNgay_dt.Value.ToString("MM/dd/yyyy");
            string ngayKT = dtimeDenNgay_dt.Value.ToString("MM/dd/yyyy");
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
            txtTongTien_dt.Text = DoanhThuBUS.Instance.loadTheoNgay(lvDoanhThu, ngayBD, ngayKT).ToString("c", culture);
        }

        private void btnTra_dt_Click(object sender, EventArgs e)
        {
            loadDoanhThuTheoNgay();
        }
    }
}
