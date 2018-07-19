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
    public partial class fmMatHang : Form
    {
        public fmMatHang()
        {
            InitializeComponent();
            LoadDS();
            LoadComboboxNcc();
        }

        public void LoadDS()
        {
            MatHangBUS.Instance.LoadDsMatHang(lvMatHang);
        }

        public void LoadComboboxNcc()
        {
            cbbNhaCungCap.DisplayMember = "TENNCC";
            cbbNhaCungCap.ValueMember = "MANCC";
            cbbNhaCungCap.DataSource = NhaCungCapDAO.Instance.LoadComBoBoxNCC();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string mahang = txtMaHang.Text;
                string tenhang = txtTenHang.Text;
                string mancc = cbbNhaCungCap.SelectedValue.ToString();
                MatHangDTO mh = new MatHangDTO(mahang, tenhang, mancc);
                if (txtMaHang.Text.Equals("") || txtTenHang.Text.Equals(""))
                {
                    MessageBox.Show("Nhập thiếu thông tin.", "Thông báo!");
                }
                else
                {
                    if (MatHangBUS.Instance.ThemMatHang(mh))
                    {
                        LoadDS();
                        MessageBox.Show("Thêm thành công.", "Thông báo!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công.", "Thông báo!");
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi", "Thông báo!");
            }
        }

        private void lvMatHang_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem lvitem in lvMatHang.SelectedItems)
            {
                txtMaHang.Text = lvitem.SubItems[0].Text;
                txtTenHang.Text = lvitem.SubItems[1].Text;
                cbbNhaCungCap.Text = lvitem.SubItems[2].Text;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string mahang = txtMaHang.Text;
                string tenhang = txtTenHang.Text;
                string mancc = cbbNhaCungCap.SelectedValue.ToString();
                MatHangDTO mh = new MatHangDTO(mahang, tenhang, mancc);
                if (txtMaHang.Text.Equals("") || txtTenHang.Text.Equals(""))
                {
                    MessageBox.Show("Nhập thiếu thông tin.", "Thông báo!");
                }
                else
                {
                    if (MatHangBUS.Instance.SuaMatHang(mh) > 0)
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
                string mahang = txtMaHang.Text;
                if (MatHangBUS.Instance.XoaMatHang(mahang) > 0)
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
    }
}
