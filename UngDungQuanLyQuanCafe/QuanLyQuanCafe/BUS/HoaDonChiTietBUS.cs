using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Windows.Forms;
using DTO;

namespace BUS
{
    public class HoaDonChiTietBUS
    {
        private static HoaDonChiTietBUS instance;

        public static HoaDonChiTietBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDonChiTietBUS();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private HoaDonChiTietBUS() { }
        public List<HoaDonChiTietDTO> LoadHDCT(string MaHD, ListView lv)
        {
            List<HoaDonChiTietDTO> hdlist = HoaDonChiTietDAO.Instance.LoadHDCT(MaHD);
            lv.Items.Clear();
            foreach (HoaDonChiTietDTO l in hdlist)
            {
                ListViewItem items = new ListViewItem();
                items.Text = l.SMaSanPham;
                items.SubItems.Add(l.STenSanPham);
                items.SubItems.Add(l.ISoLuong.ToString());
                items.SubItems.Add(l.SDonGia);
                lv.Items.Add(items);
            }
            return hdlist;
        }
    }
}
