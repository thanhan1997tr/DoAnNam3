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
    public partial class fmGiaoCa : Form
    {
        public fmGiaoCa(string ngay, string MaCa)
        {
            InitializeComponent();
            LoadDS(ngay, MaCa);
        }
        public static class getTenNv
        {
            static public string Tennv;
        }
        public void LoadDS(string ngay, string MaCa)
        {
            fmThongTinTaiKhoan fmTk = new fmThongTinTaiKhoan();
            //lblThuNgan.Text = fmTk.getTenNv();
            lblCa.Text = fmManager.getCa.tenca;
            DateTime date = DateTime.ParseExact(ngay, "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            lblNgay.Text = date.ToString("dd/MM/yyyy");
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
            lblTongTien.Text = HoaDonTheoNgayBUS.Instance.loadGiaoCa(lvGiaoCa, MaCa, ngay, lblThuNgan).ToString("c", culture);
        }
    }
}
