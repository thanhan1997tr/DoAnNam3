using BUS;
using DTO;
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
    public partial class fmHoaDonChiTiet : Form
    {
        public fmHoaDonChiTiet(string MaHD)
        {
            InitializeComponent();
            LoadHDCT(MaHD);
        }

        public void LoadHDCT(string MaHD)
        {
            List<HoaDonChiTietDTO> hdlist = HoaDonChiTietBUS.Instance.LoadHDCT(MaHD, lvhdct);
            foreach (HoaDonChiTietDTO l in hdlist)
            {
                txtMaHD.Text = l.SMaHD;
                txtBan.Text = l.SMaBan;
                txtGiamGia.Text = l.FGiamGia.ToString();
                txtNgayNhapHD.Text = Convert.ToDateTime(l.SNgayNhap).ToString("dd/MM/yyyy HH:mm:ss");
                txtNgayXuatHD.Text = Convert.ToDateTime(l.SNgayXuat).ToString("dd/MM/yyyy HH:mm:ss");
                txtNhanVienXuat.Text = l.STenNhanVien;
                txtTongTienHD.Text = l.FThanhToan.ToString();
                txtVAT.Text = l.FVAT.ToString();
            }
        }
    }
}
