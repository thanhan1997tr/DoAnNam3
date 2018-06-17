using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class fmManager : Form
    {
        public fmManager()
        {
            InitializeComponent();
        }

        private void fmManager_Load(object sender, EventArgs e)
        {
            LoadTable();
            LoadComBoBoxTable();
        }

        public void LoadTable()
        {
            flplisttable.Controls.Clear();
            List<TableDTO> tb = TableDAO.Instance.Load_Table();
            foreach (TableDTO item in tb)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.STenBan + Environment.NewLine + item.STrangThai;
                btn.Click += btn_Click;
                //btn.DoubleClick += new EventHandler(btn_DoubleClick); ;
                btn.Tag = item;
                switch (item.STrangThai.ToUpper())
                {
                    case "TRỐNG":
                        btn.BackColor = Color.White;
                        break;
                    default:
                        btn.BackColor = Color.Aqua;
                        break;
                }
                flplisttable.Controls.Add(btn);
            }
        }

        //private void btn_DoubleClick(object sender, EventArgs e)
        //{
        //    getMaBan.sMaBan = ((sender as Button).Tag as TableDTO).SMaBan;

        //    fmChiTietBan f = new fmChiTietBan();
        //    f.Text = ((sender as Button).Tag as TableDTO).STenBan;
        //    f.ShowDialog();
        //    this.Show();
        //}

        private void btn_Click(object sender, EventArgs e)
        {
            getMaBan.sMaBan = ((sender as Button).Tag as TableDTO).SMaBan;

            fmChiTietBan f = new fmChiTietBan();
            f.Text = ((sender as Button).Tag as TableDTO).STenBan;
            f.ShowDialog();
            this.Show();


            //getFormManager.lv.Tag = (sender as Button).Tag;
            //lbnhanvien.Text = "";
            //lbtime.Text = "";

            //HoaDonMenuBUS.Instance.LoadHoaDonMenu(lvHoaDon, MaBan, lbnhanvien, lbtime, txtTongTien);
            //ShowTongTien();


            //---------------------
            //txtGhiChu.Tag = (sender as Button).Tag;
            //string MaHD = HoaDonDAO.Instance.getIDTheoHoaDon(MaBan);
            //HoaDonDAO.Instance.XoaHDTheoBan(MaBan, MaHD);
            //throw new NotImplementedException();
        }

        public void LoadComBoBoxTable()
        {
            cbbTable.DisplayMember = "TENBAN";
            cbbTable.ValueMember = "MABAN";
            cbbTable.DataSource = TableDAO.Instance.Load_ComboboxTable();
        }

        public class getMaBan
        {
            static public string sMaBan;
        }
    }
}
