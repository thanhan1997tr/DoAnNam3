using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using BUS;
using DTO;

namespace GiaoDien
{
    public partial class fmSanPham : Form
    {
        public fmSanPham()
        {
            InitializeComponent();
            loadlv();
        }

        public void loadlv()
        {
            SanPhamBUS.Instance.loadSanPham(lvSanPham);
        }

        private void btnThemsp_Click_1(object sender, EventArgs e)
        {
            if (txtMasp_sp.Text == "" || txtTensp_sp.Text == "" || txtDonGiaBan_sp.Text == "")
            {
                MessageBox.Show("Nhập thông tin chưa đầy đủ", "Thông báo");
            }
            else
            {
                try
                {
                    SanPhamDTO sp = new SanPhamDTO(txtMasp_sp.Text, txtTensp_sp.Text, (float)Convert.ToDouble(txtDonGiaBan_sp.Text));
                    if (SanPhamBUS.Instance.ThemSanPham(sp) > 0)
                    {
                        loadlv();
                        MessageBox.Show("Thêm sản phẩm thành công", "Thông báo");
                    }
                }
                catch
                {
                    MessageBox.Show("Thêm sản phẩm không thành công", "Thông báo");
                }
            }
        }

        private void btnXoasp_Click_1(object sender, EventArgs e)
        {
            if (txtMasp_sp.Text == "")
            {
                MessageBox.Show("Nhập mã sản phẩm xóa", "Thông báo");
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Xóa sản phẩm " + txtMasp_sp.Text + "?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        SanPhamBUS.Instance.XoaSanPham(txtMasp_sp.Text);
                        loadlv();
                        MessageBox.Show("Xóa Sản phẩm thành công", "Thông báo");
                    }
                }
                catch
                {
                    MessageBox.Show("Xóa sản phẩm không thành công", "Thông báo");
                }
            }
        }

        private void btnSuasp_Click_1(object sender, EventArgs e)
        {
            if (txtMasp_sp.Text == "" || txtTensp_sp.Text == "" || txtDonGiaBan_sp.Text == "")
            {
                MessageBox.Show("Nhập thông tin chưa đầy đủ", "Thông báo");
            }
            else
            {
                try
                {
                    SanPhamDTO sp = new SanPhamDTO(txtMasp_sp.Text, txtTensp_sp.Text, (float)Convert.ToDouble(txtDonGiaBan_sp.Text));
                    if (SanPhamBUS.Instance.SuaSanPham(sp) > 0)
                    {
                        loadlv();
                        MessageBox.Show("Sửa sản phẩm thành công", "Thông báo");
                    }
                }
                catch
                {
                    MessageBox.Show("Sửa sản phẩm không thành công", "Thông báo");
                }
            }
        }

        private void btnNgungBan_Click_1(object sender, EventArgs e)
        {
            if (SanPhamBUS.Instance.loadSanPhamNgungBan(lvSanPham) == false)
            {
                MessageBox.Show("Không có sản phẩm nào ngừng bán");
            }
        }

        private void btnDangBan_Click_1(object sender, EventArgs e)
        {
            loadlv();
        }

        private void lvSanPham_MouseClick_1(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem lvitem in lvSanPham.SelectedItems)
            {
                txtMasp_sp.Text = lvitem.SubItems[0].Text;
                txtTensp_sp.Text = lvitem.SubItems[1].Text;
                txtDonGiaBan_sp.Text = lvitem.SubItems[2].Text;
            }
        }
    }
}
