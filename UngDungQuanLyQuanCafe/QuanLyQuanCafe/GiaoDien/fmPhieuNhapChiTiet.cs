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
    public partial class fmPhieuNhapChiTiet : Form
    {
        public static class getMaPhieuNhap
        {
            static public string MaPhieuNhap;
        }
        public fmPhieuNhapChiTiet(string MaPhieuNhap)
        {
            InitializeComponent();
            TongTien(MaPhieuNhap);
            LoadComboboxMatHang();
            getMaPhieuNhap.MaPhieuNhap = MaPhieuNhap;
        }
        public void TongTien(string MaPhieuNhap)
        {
            lblTongTien.Text = PhieuNhapChiTietBUS.Instance.LoadDsPhieuNhap(lvChiTietPN, MaPhieuNhap).ToString();
        }
        public void LoadComboboxMatHang()
        {
            cbbMatHang.DisplayMember = "TENHANG";
            cbbMatHang.ValueMember = "MAHANG";
            cbbMatHang.DataSource = PhieuNhapChiTietDAO.Instance.LoadComboboxMatHang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string manhap = getMaPhieuNhap.MaPhieuNhap;
                string mahang = cbbMatHang.SelectedValue.ToString();
                double gia = Convert.ToDouble(txtGia.Text);
                float sl = (float)Convert.ToDouble(txtSoLuong.Text);
                PhieuNhapChiTietDTO pnct = new PhieuNhapChiTietDTO(manhap, mahang, gia, sl, 0);
                if (txtGia.Text.Equals("") || txtSoLuong.Text.Equals(""))
                {
                    MessageBox.Show("Nhập thiếu thông tin.", "Thông báo!");
                }
                else
                {
                    if (PhieuNhapChiTietBUS.Instance.ThemPhieuNhapChiTiet(pnct))
                    {
                        TongTien(manhap);
                        MessageBox.Show("Thêm thành công.", "Thông báo!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công.", "Thông báo!");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi", "Thông báo!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string manhap = getMaPhieuNhap.MaPhieuNhap;
                string mahang = cbbMatHang.SelectedValue.ToString();
                double gia = Convert.ToDouble(txtGia.Text);
                float sl = (float)Convert.ToDouble(txtSoLuong.Text);
                PhieuNhapChiTietDTO pnct = new PhieuNhapChiTietDTO(manhap, mahang, gia, sl, 0);
                if (txtGia.Text.Equals("") || txtSoLuong.Text.Equals(""))
                {
                    MessageBox.Show("Nhập thiếu thông tin.", "Thông báo!");
                }
                else
                {
                    if (PhieuNhapChiTietBUS.Instance.SuaPhieuNhapChiTiet(pnct) > 0)
                    {
                        TongTien(manhap);
                        MessageBox.Show("Sửa thành công.", "Thông báo!");
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công.", "Thông báo!");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi", "Thông báo!");
            }
        }

        private void lvChiTietPN_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem lvitem in lvChiTietPN.SelectedItems)
            {
                cbbMatHang.Text= lvitem.SubItems[0].Text;
                txtSoLuong.Text = lvitem.SubItems[1].Text;
                txtGia.Text = lvitem.SubItems[2].Text;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string manhap = getMaPhieuNhap.MaPhieuNhap;
                string mahang = cbbMatHang.SelectedValue.ToString();
                if (PhieuNhapChiTietBUS.Instance.XoaPhieuNhapChiTiet(manhap, mahang) > 0)
                {
                    TongTien(manhap);
                    MessageBox.Show("Xóa thành công.", "Thông báo!");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công.", "Thông báo!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi", "Thông báo!");
            }
        }
    }
}
