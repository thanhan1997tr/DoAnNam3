using BUS;
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
            LoadComBoBoxTable1();
            LoadComBoBoxTable2();
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

        private void btn_Click(object sender, EventArgs e)
        {
            getBan.sMaBan = ((sender as Button).Tag as TableDTO).SMaBan;
            getBan.sTrangThai = ((sender as Button).Tag as TableDTO).STrangThai;

            fmChiTietBan f = new fmChiTietBan();
            f.UpdatefmManager = new fmChiTietBan.Update(LoadTable);
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

        public void LoadComBoBoxTable1()
        {
            cbbTable1.DisplayMember = "TENBAN";
            cbbTable1.ValueMember = "MABAN";
            cbbTable1.DataSource = TableDAO.Instance.Load_ComboboxTable();
        }
        public void LoadComBoBoxTable2()
        {
            cbbTable2.DisplayMember = "TENBAN";
            cbbTable2.ValueMember = "MABAN";
            cbbTable2.DataSource = TableDAO.Instance.Load_ComboboxTable();
        }

        public class getBan
        {
            static public string sMaBan;
            static public string sTrangThai;
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmNhanVien f = new fmNhanVien();
            f.Show();
        }

        private void btnQuanLyBan_Click(object sender, EventArgs e)
        {
            fmQuanLyBan f = new fmQuanLyBan();
            f.UpdatefmManager = new fmQuanLyBan.Update(LoadTable); // Update table khi thêm table
            f.ShowDialog();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmThongTinTaiKhoan f = new fmThongTinTaiKhoan();
            f.Show();
        }

        private void xemHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmHoaDonTheoNgay f = new fmHoaDonTheoNgay();
            f.Show();
        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            string MaHDNew = HoaDonTheoNgayBUS.Instance.getMaHDMoi();
            string tb1 = cbbTable1.SelectedValue.ToString();
            string tb2 = cbbTable2.SelectedValue.ToString();
            if (MessageBox.Show("Bạn muốn chuyển bàn " + cbbTable1.Text + " qua bàn " + cbbTable2.Text + "", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TableDAO.Instance.ChuyenBan(tb1, tb2, MaHDNew, fmDangNhap.getTaiKhoan.taiKhoan);
                LoadTable();
            }
        }

        private void btnGopBan_Click(object sender, EventArgs e)
        {
            string MaHDNew = HoaDonTheoNgayBUS.Instance.getMaHDMoi();
            string tb1 = cbbTable1.SelectedValue.ToString();
            string tb2 = cbbTable2.SelectedValue.ToString();
            if (MessageBox.Show("Bạn muốn chuyển bàn " + cbbTable1.Text + " qua bàn " + cbbTable2.Text + "", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TableDAO.Instance.GopBan(tb1, tb2);
                LoadTable();
            }
        }
    }
}
