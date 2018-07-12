using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GiaoDien
{
    public partial class fmQuanLyBan : Form
    {
        fmManager fmMa;
        public fmQuanLyBan(fmManager f)
        {
            fmMa = f;
            InitializeComponent();
            LoadDsTable();
        }

        public void LoadDsTable()
        {
            TableBUS.Instance.LoadTable(lvBan);
        }

        //public delegate void Update();
        //public Update UpdatefmManager;
        private void btnThemban_Click(object sender, EventArgs e)
        {
            TableBUS.Instance.ThemBan();
            LoadDsTable();
            fmMa.LoadTable();
            //UpdatefmManager();
        }

        private void btnXoaban_Click(object sender, EventArgs e)
        {
            if (TableBUS.Instance.XoaBan() == 0)
            {
                MessageBox.Show("Xóa thất bại.", "Thông báo");
            }
            else
            {
                LoadDsTable();
                fmMa.LoadTable();
                //UpdatefmManager();
            }
        }

        private void fmQuanLyBan_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
