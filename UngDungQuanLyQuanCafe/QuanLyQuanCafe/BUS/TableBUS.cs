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
    public class TableBUS
    {
        private static TableBUS instance;

        public static TableBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TableBUS();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private TableBUS() { }

        public void LoadTable(ListView lv)
        {
            lv.Items.Clear();
            foreach (TableDTO l in TableDAO.Instance.Load_Table())
            {
                ListViewItem items = new ListViewItem();
                items.Text = l.SMaBan;
                items.SubItems.Add(l.STenBan);
                items.SubItems.Add(l.STrangThai);
                lv.Items.Add(items);
            }
        }

        public void ThemBan()
        {
            TableDAO.Instance.ThemBan();
        }

        public int XoaBan()
        {
            return TableDAO.Instance.XoaBan();
        }
    }
}
