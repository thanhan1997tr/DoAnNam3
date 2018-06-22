using System;
using DTO;
using DAO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhaCungCapBUS
    {
        private static NhaCungCapBUS instance;
        public static NhaCungCapBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhaCungCapBUS();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private NhaCungCapBUS() { }

        public void loadNCC(ListView lv)
        {
            lv.Items.Clear();
            foreach(NhaCungCapDTO l in NhaCungCapDAO.Instance.loadNCC())
            {
                ListViewItem item = new ListViewItem();
                item.Text = l.SMaNCC;
                item.SubItems.Add(l.STenNCC);
                item.SubItems.Add(l.SDiaChiNCC);
                item.SubItems.Add(l.SDienThoaiNCC);
                lv.Items.Add(item);

            }
        }

        public int ThemNCC(NhaCungCapDTO ncc)
        {
            return NhaCungCapDAO.Instance.themNCC(ncc);
        }

        public int SuaNCC(NhaCungCapDTO ncc)
        {
            return NhaCungCapDAO.Instance.suaNCC(ncc);
        }

        public int XoaNCC(string mancc)
        {
            return NhaCungCapDAO.Instance.xoaNCC(mancc);
        }
    }
}
