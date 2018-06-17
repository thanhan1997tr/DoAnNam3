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
    public partial class fmChiTietBan : Form
    {
        public fmChiTietBan()
        {
            InitializeComponent();
            LoadHoaDonThanhToan();
        }

        public void ShowTongTien()
        {
            float ShowTongTien = HoaDonThanhToanBUS.getTongTien.TongTien;
            ShowTongTien = HoaDonThanhToanBUS.getTongTien.TongTien - (HoaDonThanhToanBUS.getTongTien.TongTien * (float)Convert.ToDouble(nbrGiamGia.Value)) / 100 + (HoaDonThanhToanBUS.getTongTien.TongTien * (float)Convert.ToDouble(nbrVAT.Value)) / 100;
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
            txtTongTien.Text = ShowTongTien.ToString("c", culture);
        }

        public void LoadHoaDonThanhToan()
        {
            lbnhanvien.Text = "";
            lbtime.Text = "";
            string MaBan = fmManager.getMaBan.sMaBan;
            HoaDonThanhToanBUS.Instance.LoadHoaDonMenu(lvHoaDon, MaBan, lbnhanvien, lbtime, txtTongTien, nbrGiamGia, nbrVAT);
            ShowTongTien();
        }

        private void lvHoaDon_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem lvitem in lvHoaDon.SelectedItems)
            {
                cbbThemMon_Manager.Text = lvitem.SubItems[0].Text;
                nbrSoLuong_Manager.Value = Convert.ToDecimal(lvitem.SubItems[1].Text);
            }
        }

        private void nbrGiamGia_ValueChanged(object sender, EventArgs e)
        {
            ShowTongTien();
        }

        private void nbrVAT_ValueChanged(object sender, EventArgs e)
        {
            ShowTongTien();
        }
    }
}
