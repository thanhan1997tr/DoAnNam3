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
    public class DoanhThuBUS
    {
        private static DoanhThuBUS instance;

        public static DoanhThuBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new DoanhThuBUS();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private DoanhThuBUS() { }

        public double load(ListView lv)
        {
            double tongtien = 0;
            lv.Items.Clear();
            foreach(DoanhThuDTO l in DoanhThuDAO.Instance.loadDoanhThu())
            {
                ListViewItem item = new ListViewItem();
                item.Text = l.SMaSp;
                item.SubItems.Add(l.STenSp);
                item.SubItems.Add(l.ISoLuong.ToString());
                item.SubItems.Add(l.FDonGiaBan.ToString());
                item.SubItems.Add(l.FThanhTien.ToString());
                tongtien += l.FThanhTien;
                lv.Items.Add(item);
            }
            return tongtien;
        }

        public double loadTheoNgay(ListView lv, string ngayBD, string ngayKT)
        {
            lv.Items.Clear();
            double tongtien = 0;
            foreach (DoanhThuDTO l in DoanhThuDAO.Instance.loadDoanhThuTheoNgay(ngayBD, ngayKT))
            {
                ListViewItem item = new ListViewItem();
                item.Text = l.SMaSp;
                item.SubItems.Add(l.STenSp);
                item.SubItems.Add(l.ISoLuong.ToString());
                item.SubItems.Add(l.FDonGiaBan.ToString());
                item.SubItems.Add(l.FThanhTien.ToString());
                tongtien += l.FThanhTien;
                lv.Items.Add(item);
            }
            return tongtien;
        }
    }
}
