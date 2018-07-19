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
    public class PhieuNhapBUS
    {
        private static PhieuNhapBUS instance;
        public static PhieuNhapBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuNhapBUS();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private PhieuNhapBUS() { }
        public void LoadDsPhieuNhap(ListView lv)
        {
            lv.Items.Clear();
            foreach (PhieuNhapDTO l in PhieuNhapDAO.Instance.LoadDsPhieuNhap())
            {
                ListViewItem item = new ListViewItem();
                item.Text = l.SMaPhieuNhap;
                item.SubItems.Add(Convert.ToDateTime(l.SNgayNhap).ToString("dd/MM/yyyy"));
                item.SubItems.Add(l.SMaNv);
                lv.Items.Add(item);
            }
        }

        public void TimPhieuNhap(ListView lv, string manhap)
        {
            lv.Items.Clear();
            foreach (PhieuNhapDTO l in PhieuNhapDAO.Instance.TimPhieuNhap(manhap))
            {
                ListViewItem item = new ListViewItem();
                item.Text = l.SMaPhieuNhap;
                item.SubItems.Add(Convert.ToDateTime(l.SNgayNhap).ToString("dd/MM/yyyy"));
                item.SubItems.Add(l.SMaNv);
                lv.Items.Add(item);
            }
        }

        public bool ThemPhieuNhap(PhieuNhapDTO pn)
        {
            return PhieuNhapDAO.Instance.ThemPhieuNhap(pn);
        }

        public int SuaPhieuNhap(PhieuNhapDTO pn)
        {
            return PhieuNhapDAO.Instance.SuaPhieuNhap(pn);
        }

        public int XoaPhieuNhap(string manhap)
        {
            return PhieuNhapDAO.Instance.XoaPhieuNhap(manhap);
        }
    }
}
