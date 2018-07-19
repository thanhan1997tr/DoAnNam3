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

        public double load(ListView lv)
        {
            lv.Items.Clear();
            double tongtien = 0;
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
                tongtien += Convert.ToDouble(l.FThanhToan);
            }
            return tongtien;
        }

        public double loadTheoNgay(ListView lv, string ngayBD, string ngayKT)
        {
            lv.Items.Clear();
            double tongtien = 0;
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
                tongtien += Convert.ToDouble(l.FThanhToan);
            }
            return tongtien;
        }

        public double loadGiaoCa(ListView lv, string MaCa, string Ngay, Label lbl, Label ca)
        {
            lv.Items.Clear();
            double tongtien = 0;
            string tennv = "";
            string maca = "";
            foreach (HoaDonTheoNgayDTO l in HoaDonTheoNgayDAO.Instance.LoadHoaDonGiaoCa(Ngay, MaCa))
            {
                ListViewItem item = new ListViewItem();
                item.Text = l.SMaHD;
                item.SubItems.Add(Convert.ToDateTime(l.SNgayNhap).ToString("dd/MM/yyyy HH:mm:ss"));
                item.SubItems.Add(Convert.ToDateTime(l.SNgayXuat).ToString("dd/MM/yyyy HH:mm:ss"));
                item.SubItems.Add(l.FThanhToan.ToString());
                lv.Items.Add(item);
                tongtien += Convert.ToDouble(l.FThanhToan);
                tennv = l.SMaNVNhap;
                maca = l.SMaCa;
            }
            lbl.Text = tennv;
            ca.Text = maca;
            return tongtien;
        }
        
        public bool CheckBaoCao(string ca, string ngay)
        {
            if (CaDAO.Instance.BaoCaoGiaoCa(ca, ngay) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string getMaHDMoi()
        {
            return "HD" + getDateTimeNow.getStringMa();
        }
    }
}
