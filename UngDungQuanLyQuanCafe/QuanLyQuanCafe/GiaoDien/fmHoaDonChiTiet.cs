using BUS;
using DTO;
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
    public partial class fmHoaDonChiTiet : Form
    {
        public fmHoaDonChiTiet(string MaHD)
        {
            getMaHd.sMaHd = MaHD;
            InitializeComponent();
            LoadHDCT(MaHD);
        }
        public static class getMaHd
        {
            static public string sMaHd;
        }
        public void LoadHDCT(string MaHD)
        {
            List<HoaDonChiTietDTO> hdlist = HoaDonChiTietBUS.Instance.LoadHDCT(MaHD, lvhdct);
            foreach (HoaDonChiTietDTO l in hdlist)
            {
                txtMaHD.Text = l.SMaHD;
                txtBan.Text = l.SMaBan;
                float giamgia = l.FGiamGia * 100;
                float vat = l.FVAT * 100;
                txtGiamGia.Text = giamgia.ToString();
                txtNgayNhapHD.Text = Convert.ToDateTime(l.SNgayNhap).ToString("dd/MM/yyyy HH:mm:ss");
                txtNgayXuatHD.Text = Convert.ToDateTime(l.SNgayXuat).ToString("dd/MM/yyyy HH:mm:ss");
                txtNhanVienXuat.Text = l.STenNhanVien;
                CultureInfo culture = new CultureInfo("vi-VN");
                Thread.CurrentThread.CurrentCulture = culture;
                txtTongTienHD.Text = l.FThanhToan.ToString("c", culture);
                txtVAT.Text = vat.ToString();
                txtCaLam.Text = l.SMaCa;
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            rpHoaDon rp = new rpHoaDon(getMaHd.sMaHd);
            rp.ShowDialog();
        }
    }
}
