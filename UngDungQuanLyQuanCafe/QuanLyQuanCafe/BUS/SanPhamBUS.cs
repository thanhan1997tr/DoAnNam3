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
    public class SanPhamBUS
    {
        private static SanPhamBUS instance;
        public static SanPhamBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new SanPhamBUS();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private SanPhamBUS() { }

        public void loadSanPham(ListView lv)
        {
            lv.Items.Clear();
            foreach (SanPhamDTO l in SanPhamDAO.Instance.loadSanPham())
            {
                ListViewItem item = new ListViewItem();
                item.Text = l.SMaSp;
                item.SubItems.Add(l.STenSp);
                item.SubItems.Add(l.FDonGiaBan.ToString());
                lv.Items.Add(item);
            }
        }

        public bool loadSanPhamNgungBan(ListView lv)
        {
            bool ktra = true;
            int dem = 0;
            lv.Items.Clear();
            foreach (SanPhamDTO l in SanPhamDAO.Instance.loadSanPhamNgungBan())
            {
                ListViewItem item = new ListViewItem();
                item.Text = l.SMaSp;
                item.SubItems.Add(l.STenSp);
                item.SubItems.Add(l.FDonGiaBan.ToString());
                lv.Items.Add(item);
                dem++;
            }
            if (dem > 0)
            {
                ktra = true;
            }
            else
            {
                ktra = false;
            }
            return ktra;
        }

        public int ThemSanPham(SanPhamDTO sp){
            return SanPhamDAO.Instance.themSP(sp);
        }

        public int SuaSanPham(SanPhamDTO sp)
        {
            return SanPhamDAO.Instance.suaSP(sp);
        }

        public int XoaSanPham(string masp)
        {
            return SanPhamDAO.Instance.xoaSP(masp);
        }
    }
}
