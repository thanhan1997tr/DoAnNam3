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
    public class MatHangBUS
    {
        private static MatHangBUS instance;
        public static MatHangBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new MatHangBUS();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private MatHangBUS() { }

        public void LoadDsMatHang(ListView lv)
        {
            lv.Items.Clear();
            foreach (MatHangDTO l in MatHangDAO.Instance.LoadDsMatHang())
            {
                ListViewItem item = new ListViewItem();
                item.Text = l.SMaHang;
                item.SubItems.Add(l.STenHang);
                item.SubItems.Add(l.SMaNcc);
                lv.Items.Add(item);

            }
        }

        public bool ThemMatHang(MatHangDTO mh)
        {
            return MatHangDAO.Instance.ThemMatHang(mh);
        }

        public int SuaMatHang(MatHangDTO mh)
        {
            return MatHangDAO.Instance.SuaMatHang(mh);
        }

        public int XoaMatHang(string mahang)
        {
            return MatHangDAO.Instance.XoaMatHang(mahang);
        }
    }
}
