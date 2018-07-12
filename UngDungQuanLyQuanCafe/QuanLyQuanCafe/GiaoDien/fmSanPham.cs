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
            //loadcomboSP();
            loadNCC();
            loadcomboNCC();
        }

        private void fmSanPham_Load(object sender, EventArgs e)
        {
            
        }
        public void loadcomboNCC()
        {
            cbTimNCC.DisplayMember = "TENNCC";
            cbTimNCC.ValueMember = "MANCC";
            cbTimNCC.DataSource = NhaCungCapDAO.Instance.LoadComBoBoxNCC();
        }
        public void loadcomboSP()
        {
            //cbbTimsp.DisplayMember = "TENSP";
            //cbbTimsp.ValueMember = "MASP";
            //cbbTimsp.DataSource = SanPhamDAO.Instance.LoadComBoBoxSanPham();
        }

        public void loadlv()
        {
            SanPhamBUS.Instance.loadSanPham(lvSanPham);
        }
        public void loadNCC()
        {
            NhaCungCapBUS.Instance.loadNCC(lvNCC);
        }
        private void btnThemsp_Click(object sender, EventArgs e)
        {
            if (txtMasp_sp.Text == "" || txtTensp_sp.Text == "" || txtDonGiaBan_sp.Text == "")
            {
                MessageBox.Show("Nhập thông tin chưa đầy đủ", "Thông báo");
            }
            else
            {
                try
                {
                    SanPhamDTO sp = new SanPhamDTO(txtMasp_sp.Text,txtTensp_sp.Text, (float)Convert.ToDouble(txtDonGiaBan_sp.Text));
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

        private void btnSuasp_Click(object sender, EventArgs e)
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

        private void btnXoasp_Click(object sender, EventArgs e)
        {
            if(txtMasp_sp.Text =="")
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(txtMaNCC.Text ==""|| txtTenNCC.Text =="" || txtDiaChiNCC.Text ==""||txtDienThoaiNCC.Text =="")
            {
                MessageBox.Show("Dữ liệu nhập chưa đủ", "Thông báo");
            }
            else
            {
                try
                {
                    NhaCungCapDTO ncc = new NhaCungCapDTO(txtMaNCC.Text, txtTenNCC.Text, txtDiaChiNCC.Text, txtDienThoaiNCC.Text);
                    if(NhaCungCapBUS.Instance.ThemNCC(ncc) > 0)
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

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
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

        private void btnNgungBan_Click(object sender, EventArgs e)
        {
            if (SanPhamBUS.Instance.loadSanPhamNgungBan(lvSanPham) == false)
            {
                MessageBox.Show("Không có sản phẩm nào ngừng bán");
            }
        }

        private void btnDangBan_Click(object sender, EventArgs e)
        {
            loadlv();
        }

        private void lvSanPham_MouseClick(object sender, MouseEventArgs e)
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
