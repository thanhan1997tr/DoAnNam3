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
    public partial class fmPhieuNhap : Form
    {
        public fmPhieuNhap()
        {
            InitializeComponent();
            LoadDS();
            LoadComboboxNhanVien();
        }

        public void LoadDS()
        {
            PhieuNhapBUS.Instance.LoadDsPhieuNhap(lvPhieuNhap);
        }

        public void LoadComboboxNhanVien()
        {
            cbbMaNv.DisplayMember = "TENNV";
            cbbMaNv.ValueMember = "MANV";
            cbbMaNv.DataSource = PhieuNhapDAO.Instance.LoadComboNhanVien();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string manhap = txtMaNhap.Text;
                string ngaynhap = dTimeNgayNhap.Value.ToString("MM/dd/yyyy");
                string manv = cbbMaNv.SelectedValue.ToString();
                PhieuNhapDTO pn = new PhieuNhapDTO(manhap, ngaynhap, manv);
                if (txtMaNhap.Text.Equals(""))
                {
                    MessageBox.Show("Nhập thiếu thông tin.", "Thông báo!");
                }
                else
                {
                    if (PhieuNhapBUS.Instance.ThemPhieuNhap(pn))
                    {
                        LoadDS();
                        MessageBox.Show("Thêm thành công.", "Thông báo!");
                        fmPhieuNhapChiTiet fm = new fmPhieuNhapChiTiet(manhap);
                        fm.Text = manhap;
                        fm.ShowDialog();
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

        private void lvPhieuNhap_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem lvitem in lvPhieuNhap.SelectedItems)
            {
                txtMaNhap.Text = lvitem.SubItems[0].Text;
                dTimeNgayNhap.Text = lvitem.SubItems[1].Text;
                cbbMaNv.Text = lvitem.SubItems[2].Text;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string manhap = txtMaNhap.Text;
                string ngaynhap = dTimeNgayNhap.Value.ToString("MM/dd/yyyy");
                string manv = cbbMaNv.SelectedValue.ToString();
                PhieuNhapDTO pn = new PhieuNhapDTO(manhap, ngaynhap, manv);
                if (txtMaNhap.Text.Equals(""))
                {
                    MessageBox.Show("Nhập thiếu thông tin.", "Thông báo!");
                }
                else
                {
                    if (PhieuNhapBUS.Instance.SuaPhieuNhap(pn) > 0)
                    {
                        LoadDS();
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string manhap = txtMaNhap.Text;
                if (PhieuNhapBUS.Instance.XoaPhieuNhap(manhap) > 0)
                {
                    LoadDS();
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

        private void lvPhieuNhap_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string manhap = "";
            foreach (ListViewItem lvitem in lvPhieuNhap.SelectedItems)
            {
                manhap = lvitem.SubItems[0].Text;
            }
            fmPhieuNhapChiTiet fm = new fmPhieuNhapChiTiet(manhap);
            fm.Text = manhap;
            fm.ShowDialog();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string manhap = txtMaNhap.Text;
            PhieuNhapBUS.Instance.TimPhieuNhap(lvPhieuNhap, manhap);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadDS();
        }
    }
}
