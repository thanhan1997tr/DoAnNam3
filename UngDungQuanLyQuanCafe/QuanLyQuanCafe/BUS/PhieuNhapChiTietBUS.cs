using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class PhieuNhapChiTietBUS
    {
        private static PhieuNhapChiTietBUS instance;
        public static PhieuNhapChiTietBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuNhapChiTietBUS();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private PhieuNhapChiTietBUS() { }

        public double LoadDsPhieuNhap(ListView lv, string MaPhieuNhap)
        {
            lv.Items.Clear();
            double TongTien = 0;
            foreach (PhieuNhapChiTietDTO l in PhieuNhapChiTietDAO.Instance.LoadDsPhieuNhapChiTiet(MaPhieuNhap))
            {
                ListViewItem item = new ListViewItem();
                item.Text = l.SMaHang;
                item.SubItems.Add(l.FSoLuong.ToString());
                item.SubItems.Add(l.FGia.ToString());
                item.SubItems.Add(l.FThanhTien.ToString());
                lv.Items.Add(item);
                TongTien += l.FThanhTien;
            }
            return TongTien;
        }
        public bool ThemPhieuNhapChiTiet(PhieuNhapChiTietDTO pnct)
        {
            return PhieuNhapChiTietDAO.Instance.ThemPhieuNhapChiTiet(pnct);
        }

        public int SuaPhieuNhapChiTiet(PhieuNhapChiTietDTO pnct)
        {
            return PhieuNhapChiTietDAO.Instance.SuaPhieuNhapChiTiet(pnct);
        }

        public int XoaPhieuNhapChiTiet(string manhap, string mahang)
        {
            return PhieuNhapChiTietDAO.Instance.XoaPhieuNhapChiTiet(manhap, mahang);
        }
    }
}
