using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class HoaDonThanhToanBUS
    {
        private static HoaDonThanhToanBUS instance;

        public static HoaDonThanhToanBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDonThanhToanBUS();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private HoaDonThanhToanBUS() { }

        public class getTongTien
        {
            static public float TongTien;
        }

        public void LoadHoaDonMenu(ListView lv, string MaBan, Label lb1, Label lb2, TextBox tt, NumericUpDown nbrGiamGia, NumericUpDown nbrVat)
        {
            getTongTien.TongTien = 0;
            lv.Items.Clear();
            foreach (HoaDonThanhToanDTO l in HoaDonThanhToanDAO.Instance.LoadHoaDonThanhToan(MaBan))
            {
                ListViewItem item = new ListViewItem();
                item.Text = l.STenSp;
                item.SubItems.Add(l.ISoLuong.ToString());
                item.SubItems.Add(l.FDonGia.ToString());
                item.SubItems.Add(l.FThanhTien.ToString());
                lv.Items.Add(item);
                getTongTien.TongTien += l.FThanhTien;
                lb1.Text = l.STenNv;
                lb2.Text = l.SThoiGianVao;
                nbrGiamGia.Value = Convert.ToInt32(l.Fgiamgia.ToString());
                nbrVat.Value = Convert.ToInt32(l.Fvat.ToString());
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;

            tt.Text = getTongTien.TongTien.ToString("c", culture);
        }
    }
}
