using DAO;
using DTO;
using Common;
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
    public class HoaDonTheoNgayBUS
    {
         private static HoaDonTheoNgayBUS instance;

        public static HoaDonTheoNgayBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDonTheoNgayBUS();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private HoaDonTheoNgayBUS() { }

        public void load(ListView lv)
        {
            lv.Items.Clear();
            foreach (HoaDonTheoNgayDTO l in HoaDonTheoNgayDAO.Instance.LoadHoaDon())
            {
                ListViewItem item = new ListViewItem();
                item.Text = l.SMaHD;
                item.SubItems.Add(Convert.ToDateTime(l.SNgayNhap).ToString("dd/MM/yyyy HH:mm:ss"));
                item.SubItems.Add(Convert.ToDateTime(l.SNgayXuat).ToString("dd/MM/yyyy HH:mm:ss"));
                item.SubItems.Add(l.SMaNVNhap);
                item.SubItems.Add(l.SMaBan);
                item.SubItems.Add(l.FGiamGia.ToString());
                item.SubItems.Add(l.FVAT.ToString());
                item.SubItems.Add(l.FThanhToan.ToString());
                item.SubItems.Add(l.SGhiChu);
                lv.Items.Add(item);
            }
        }

        public void loadTheoNgay(ListView lv, string ngayBD, string ngayKT)
        {
            lv.Items.Clear();
            foreach (HoaDonTheoNgayDTO l in HoaDonTheoNgayDAO.Instance.LoadHoaDonTheoNgay(ngayBD, ngayKT))
            {
                ListViewItem item = new ListViewItem();
                item.Text = l.SMaHD;
                item.SubItems.Add(Convert.ToDateTime(l.SNgayNhap).ToString("dd/MM/yyyy HH:mm:ss"));
                item.SubItems.Add(Convert.ToDateTime(l.SNgayXuat).ToString("dd/MM/yyyy HH:mm:ss"));
                item.SubItems.Add(l.SMaNVNhap);
                item.SubItems.Add(l.SMaBan);
                item.SubItems.Add(l.FGiamGia.ToString());
                item.SubItems.Add(l.FVAT.ToString());
                item.SubItems.Add(l.FThanhToan.ToString());
                item.SubItems.Add(l.SGhiChu);
                lv.Items.Add(item);
            }
        }

        public string getMaHDMoi()
        {
            return "HD" + getDateTimeNow.getStringMa();
        }
    }
}
