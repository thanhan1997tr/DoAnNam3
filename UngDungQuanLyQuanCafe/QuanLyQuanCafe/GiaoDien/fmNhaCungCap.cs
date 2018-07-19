using BUS;
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
    public partial class fmNhaCungCap : Form
    {
        public fmNhaCungCap()
        {
            InitializeComponent();
            loadNCC();
        }
        public void loadNCC()
        {
            NhaCungCapBUS.Instance.loadNCC(lvNCC);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "" || txtTenNCC.Text == "" || txtDiaChiNCC.Text == "" || txtDienThoaiNCC.Text == "")
            {
                MessageBox.Show("Dữ liệu nhập chưa đủ", "Thông báo");
            }
            else
            {
                try
                {
                    double dt = Convert.ToDouble(txtDienThoaiNCC.Text);
                    NhaCungCapDTO ncc = new NhaCungCapDTO(txtMaNCC.Text, txtTenNCC.Text, txtDiaChiNCC.Text, txtDienThoaiNCC.Text);
                    if (NhaCungCapBUS.Instance.ThemNCC(ncc) > 0)
                    {
                        loadNCC();
                        MessageBox.Show("Thêm nhà cung cấp thành công", "Thông báo");
                    }
                }
                catch
                {
                    MessageBox.Show("Thêm nhà cung cấp không thành công", "Thông báo");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Nhập mã nhà cung cấp cần xóa");
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa nhà cung cập " + txtMaNCC.Text + "?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        NhaCungCapBUS.Instance.XoaNCC(txtMaNCC.Text);
                        loadNCC();
                        MessageBox.Show("Xóa thành công", "Thông báo");
                    }
                }
                catch
                {
                    MessageBox.Show("Xóa không thành công", "THông báo");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "" || txtTenNCC.Text == "" || txtDiaChiNCC.Text == "" || txtDienThoaiNCC.Text == "")
            {
                MessageBox.Show("Dữ liệu nhập chưa đủ", "Thông báo");
            }
            else
            {
                try
                {
                    double dt = Convert.ToDouble(txtDienThoaiNCC.Text);
                    NhaCungCapDTO ncc = new NhaCungCapDTO(txtMaNCC.Text, txtTenNCC.Text, txtDiaChiNCC.Text, txtDienThoaiNCC.Text);
                    if (NhaCungCapBUS.Instance.SuaNCC(ncc) > 0)
                    {
                        loadNCC();
                        MessageBox.Show("Sửa nhà cung cấp thành công", "Thông báo");
                    }
                }
                catch
                {
                    MessageBox.Show("Sửa nhà cung cấp không thành công", "Thông báo");
                }
            }
        }

        private void lvNCC_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem lvitem in lvNCC.SelectedItems)
            {
                txtMaNCC.Text = lvitem.SubItems[0].Text;
                txtTenNCC.Text = lvitem.SubItems[1].Text;
                txtDiaChiNCC.Text = lvitem.SubItems[2].Text;
                txtDienThoaiNCC.Text = lvitem.SubItems[3].Text;
            }
        }
    }
}
