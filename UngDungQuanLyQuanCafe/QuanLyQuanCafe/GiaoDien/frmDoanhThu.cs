using BUS;
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
    public partial class frmDoanhThu : Form
    {
        public frmDoanhThu()
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
            txtTongTien_dt.Text = DoanhThuBUS.Instance.load(lvDoanhThu).ToString();
        }

        private void loadDoanhThuTheoNgay()
        {
            string ngayBD = dtimeTuNgay_dt.Value.ToString("MM/dd/yyyy");
            string ngayKT = dtimeDenNgay_dt.Value.ToString("MM/dd/yyyy");
            txtTongTien_dt.Text = DoanhThuBUS.Instance.loadTheoNgay(lvDoanhThu, ngayBD, ngayKT).ToString();
        }

        private void btnTra_dt_Click(object sender, EventArgs e)
        {
            loadDoanhThuTheoNgay();
        }
    }
}
