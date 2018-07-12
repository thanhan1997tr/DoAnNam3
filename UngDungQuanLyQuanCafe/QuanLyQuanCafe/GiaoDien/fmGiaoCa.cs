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
    public partial class fmGiaoCa : Form
    {
        public fmGiaoCa()
        {
            InitializeComponent();
            LoadDS();
        }
        public void LoadDS()
        {
            fmThongTinTaiKhoan fmTk = new fmThongTinTaiKhoan();
            lblThuNgan.Text = fmTk.getTenNv();
            lblCa.Text = fmManager.getCa.tenca;
            DateTime date = DateTime.Now;
            lblNgay.Text = date.ToString("dd/MM/yyyy");
            lblTongTien.Text = HoaDonTheoNgayBUS.Instance.loadGiaoCa(lvGiaoCa, fmManager.getCa.maca).ToString();
        }
    }
}
