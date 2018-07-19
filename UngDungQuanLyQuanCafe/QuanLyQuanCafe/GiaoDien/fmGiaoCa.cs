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
        public fmGiaoCa(string ngay, string maca)
        {
            InitializeComponent();
            LoadDS(ngay, maca);
            Ngay = ngay;
            MaCa = maca;
            //Nút báo cáo chỉ sử dụng khi đã kết ca đó
            if (HoaDonTheoNgayBUS.Instance.CheckBaoCao(maca, ngay))
            {
                btnBaoCao.Enabled = true;
            }
        }
        string Ngay = "";
        string MaCa = "";
        public static class getTenNv
        {
            static public string Tennv;
        }
        public void LoadDS(string ngay, string maca)
        {
            fmThongTinTaiKhoan fmTk = new fmThongTinTaiKhoan();
            //lblThuNgan.Text = fmTk.getTenNv();
            //lblCa.Text = fmManager.getCa.tenca;
            DateTime date = DateTime.ParseExact(ngay, "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            lblNgay.Text = date.ToString("dd/MM/yyyy");
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
            lblTongTien.Text = HoaDonTheoNgayBUS.Instance.loadGiaoCa(lvGiaoCa, maca, ngay, lblThuNgan, lblCa).ToString("c", culture);
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.ParseExact(Ngay, "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            rpGiaoCa rp = new rpGiaoCa(date, MaCa);
            rp.ShowDialog();
        }
    }
}
