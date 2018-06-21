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
    public class NhanVienBUS
    {
        private static NhanVienBUS instance;
        public static NhanVienBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienBUS();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private NhanVienBUS() { }

        public string getMaNvMoi()
        {
            string Manv = "000" + NhanVienDAO.Instance.getMaNv();
            Manv = Manv.Substring(Manv.Length - 4, 4);
            return "NV" + Manv;
        }

        public Boolean ktraDienThoai(String dt)
        {
            bool kt = true;
            try
            {
                int d = Convert.ToInt32(dt);
                kt = true;
            }
            catch (Exception)
            {
                kt = false;
            }
            return kt;
        }

        public Boolean ktraLuong(String luong)
        {
            bool kt = true;
            try
            {
                double l = Convert.ToDouble(luong);
                kt = true;
            }
            catch (Exception)
            {
                kt = false;
            }
            return kt;
        }

        public Boolean ktraMaNv(ListView lv, string ma)
        {
            bool kt = false; // không tồn tại mã
            foreach(ListViewItem items in lv.Items)
            {
                if (items.SubItems[0].Text.Equals(ma))
                {
                    kt = true;
                    break;
                }
            }
            return kt;
        }

        public void Load(ListView lv)
        {
            lv.Items.Clear();
            foreach (NhanVienDTO l in NhanVienDAO.Instance.Load())
            {
                ListViewItem items = new ListViewItem();
                items.Text = l.SManv;
                items.SubItems.Add(l.STennv);
                items.SubItems.Add(Convert.ToDateTime(l.SNgaysinh).ToString("dd/MM/yyyy"));
                items.SubItems.Add(l.SGioitinh);
                items.SubItems.Add(l.SDiachi);
                items.SubItems.Add(l.SDienthoai);
                items.SubItems.Add(l.SLuong);
                items.SubItems.Add(l.SQuyen);
                lv.Items.Add(items);
            }
        }

        public int ThemNhanVien(NhanVienDTO nv)
        {
            return NhanVienDAO.Instance.ThemNhanVien(nv);
        }
        public int XoaNhanVien(string manv)
        {
            return NhanVienDAO.Instance.XoaNhanVien(manv);
        }
        public int SuaNhanVien(NhanVienDTO nv)
        {
            return NhanVienDAO.Instance.SuaNhanVien(nv);
        }
        public int SuaMatKhauNhanVien(string manv, string matkhau)
        {
            return NhanVienDAO.Instance.SuaMatKhauNhanVien(manv, matkhau);
        }
        public void TimNhanVien(ListView lv, string ten)
        {
            lv.Items.Clear();
            List<NhanVienDTO> dsnv = NhanVienDAO.Instance.Load();
            foreach (NhanVienDTO l in dsnv)
            {
                if (l.STennv.Equals(ten))
                {
                    ListViewItem items = new ListViewItem();
                    items.Text = l.SManv;
                    items.SubItems.Add(l.STennv);
                    items.SubItems.Add(Convert.ToDateTime(l.SNgaysinh).ToString("dd/MM/yyyy"));
                    items.SubItems.Add(l.SGioitinh);
                    items.SubItems.Add(l.SDiachi);
                    items.SubItems.Add(l.SDienthoai);
                    items.SubItems.Add(l.SLuong);
                    items.SubItems.Add(l.SQuyen);
                    lv.Items.Add(items);
                }
            }
        }
    }
}
