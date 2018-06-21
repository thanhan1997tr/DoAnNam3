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
    public partial class fmHoaDonTheoNgay : Form
    {
        public fmHoaDonTheoNgay()
        {
            InitializeComponent();
            loadHoaDon();
        }
        public void loadHoaDon()
        {
            HoaDonTheoNgayBUS.Instance.load(lvXemHoaDon);
        }
        private void loadHoaDonTheoNgay()
        {
            string ngayBD = dtimeTuNgay_xhd.Value.ToString("MM/dd/yyyy");
            string ngayKT = dtimeDenNgay_xhd.Value.ToString("MM/dd/yyyy");
            HoaDonTheoNgayBUS.Instance.loadTheoNgay(lvXemHoaDon, ngayBD,ngayKT);
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadHoaDon();
        }
        private void btnTimhd_Click(object sender, EventArgs e)
        {
            loadHoaDonTheoNgay();
        }

        private void lvXemHoaDon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string MaHD = "";
            foreach (ListViewItem lvitem in lvXemHoaDon.SelectedItems)
            {
                MaHD = lvitem.SubItems[0].Text;
            }
            fmHoaDonChiTiet HDCT = new fmHoaDonChiTiet(MaHD);
            HDCT.Text = MaHD;
            HDCT.Show();
        }
    }
}
