using BUS;
using Common;
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
    public partial class fmNhanVien : Form
    {
        public fmNhanVien()
        {
            InitializeComponent();
            LoadDsNhanVien();
            txtManv.Text = NhanVienBUS.Instance.getMaNvMoi();
            LoadComboboxTenNhanVien();
        }
        #region CÁC HÀM XỬ LÝ
        public void Clear_ALL()
        {
            txtManv.Text = NhanVienBUS.Instance.getMaNvMoi();
            txtTennv.Text = "";
            dtimeNgaySinhNV.Text = DateTime.Now.ToString();
            rbtnNam.Checked = true;
            txtDiaChinv.Text = "";
            txtDienThoainv.Text = "";
            txtLuongnv.Text = "";
            txtMatKhau.Text = "1";
        }
        private void btnLamMoiForm_Click(object sender, EventArgs e)
        {
            Clear_ALL();
            LoadDsNhanVien();
        }
        public void LoadComboboxTenNhanVien()
        {
            cbbTimNv.DisplayMember = "TENNV";
            cbbTimNv.DataSource = NhanVienDAO.Instance.LoadComboTenNhanVien();
        }
        public void LoadDsNhanVien()
        {
            NhanVienBUS.Instance.Load(lvNhanVien);
        }
        #endregion

        #region THÊM, XÓA, SỬA, TÌM NHÂN VIÊN
        private void btnThemNv_Click(object sender, EventArgs e)
        {
            if(txtTennv.Text.Equals("") || txtMatKhau.Text.Equals("") || txtLuongnv.Text.Equals("") || txtDienThoainv.Text.Equals("") || txtDiaChinv.Text.Equals(""))
            {
                MessageBox.Show("Nhập thông tin chưa đầy đủ", "Thông báo");
            }
            else
            {
                try
                {
                    int dt = Convert.ToInt32(txtDienThoainv.Text);
                    double l = Convert.ToDouble(txtLuongnv.Text);

                    string ma = txtManv.Text;
                    string ten = txtTennv.Text;
                    string ngaysinh = dtimeNgaySinhNV.Value.ToString("MM/dd/yyyy");
                    string gt;
                    if (rbtnNam.Checked)
                        gt = "Nam";
                    else
                        gt = "Nữ";

                    string diachi = txtDiaChinv.Text;
                    string dienthoai = txtDienThoainv.Text;
                    string luong = txtLuongnv.Text;
                    string matkhau = MaHoaMD5.ToMD5(txtMatKhau.Text);
                    string q = "";
                    if (rbtnAD.Checked)
                        q = "ADMIN";
                    else if (rbtnNv.Checked)
                        q = "NHÂN VIÊN";
                    else
                        q = "QUẢN LÝ";

                    NhanVienDTO nv = new NhanVienDTO(ma, ten, ngaysinh, gt, diachi, dienthoai, matkhau, q, luong);
                    if (NhanVienBUS.Instance.ThemNhanVien(nv) > 0)
                    {
                        LoadDsNhanVien();
                        Clear_ALL();
                        LoadComboboxTenNhanVien();
                        MessageBox.Show("Thêm thành công", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công", "Thông báo");
                    }
                }
                catch(Exception)
                {
                    if (NhanVienBUS.Instance.ktraDienThoai(txtDienThoainv.Text) == false)
                    {
                        MessageBox.Show("Điện thoại nhập sai", "Thông báo");
                    }
                    if (NhanVienBUS.Instance.ktraLuong(txtLuongnv.Text) == false)
                    {
                        MessageBox.Show("Lương nhập sai", "Thông báo");
                    }
                }
            }
        }

        private void btnXoaNv_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtnAD.Checked)
                {
                    MessageBox.Show("Không thể xóa ADMIN", "Thông báo");
                }
                else
                {
                    if (NhanVienBUS.Instance.ktraMaNv(lvNhanVien, txtManv.Text))
                    {
                        if (MessageBox.Show("Xóa nhân viên " + txtTennv.Text + " (" + txtManv.Text + ")" + " ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                        {
                            NhanVienBUS.Instance.XoaNhanVien(txtManv.Text);
                            LoadDsNhanVien();
                            Clear_ALL();
                            LoadComboboxTenNhanVien();
                            MessageBox.Show("Xóa thành công", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mời chọn 1 nhân viên", "Thông báo");
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
        }

        private void btnSuaNv_Click(object sender, EventArgs e)
        {
            if (NhanVienBUS.Instance.ktraMaNv(lvNhanVien, txtManv.Text))
            {
                if (txtTennv.Text.Equals("") || txtLuongnv.Text.Equals("") || txtDienThoainv.Text.Equals("") || txtDiaChinv.Text.Equals(""))
                {
                    MessageBox.Show("Nhập thông tin chưa đầy đủ", "Thông báo");
                }
                else
                {
                    try
                    {
                        int dt = Convert.ToInt32(txtDienThoainv.Text);
                        double l = Convert.ToDouble(txtLuongnv.Text);

                        string ma = txtManv.Text;
                        string ten = txtTennv.Text;
                        string ngaysinh = dtimeNgaySinhNV.Value.ToString("MM/dd/yyyy");
                        string gt;
                        if (rbtnNam.Checked)
                            gt = "Nam";
                        else
                            gt = "Nữ";

                        string diachi = txtDiaChinv.Text;
                        string dienthoai = txtDienThoainv.Text;
                        string luong = txtLuongnv.Text;
                        string matkhau = "";
                        string q = "";
                        if (rbtnAD.Checked)
                            q = "ADMIN";
                        else if (rbtnNv.Checked)
                            q = "NHÂN VIÊN";
                        else
                            q = "QUẢN LÝ";

                        NhanVienDTO nv = new NhanVienDTO(ma, ten, ngaysinh, gt, diachi, dienthoai, matkhau, q, luong);
                        if (NhanVienBUS.Instance.SuaNhanVien(nv) > 0)
                        {
                            LoadDsNhanVien();
                            Clear_ALL();
                            LoadComboboxTenNhanVien();
                            MessageBox.Show("Sửa thành công", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Sửa không thành công", "Thông báo");
                        }
                    }
                    catch (Exception)
                    {
                        if (NhanVienBUS.Instance.ktraDienThoai(txtDienThoainv.Text) == false)
                        {
                            MessageBox.Show("Điện thoại nhập sai", "Thông báo");
                        }
                        if (NhanVienBUS.Instance.ktraLuong(txtLuongnv.Text) == false)
                        {
                            MessageBox.Show("Lương nhập sai", "Thông báo");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Mời chọn 1 nhân viên", "Thông báo");
            }
        }

        private void btnDatLaiMk_Click(object sender, EventArgs e)
        {
            if (NhanVienBUS.Instance.ktraMaNv(lvNhanVien, txtManv.Text))
            {
                string ma = txtManv.Text;
                string matkhau = MaHoaMD5.ToMD5(txtMatKhau.Text);
                if (MessageBox.Show("Đặt lại mật khẩu là: " + txtMatKhau.Text + " ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    if (NhanVienBUS.Instance.SuaMatKhauNhanVien(ma, matkhau) > 0)
                    {
                        Clear_ALL();
                        MessageBox.Show("Thành công", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Không thành công", "Thông báo");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Mời chọn 1 nhân viên", "Thông báo");
            }
        }

        private void btnTimNv_Click(object sender, EventArgs e)
        {
            NhanVienBUS.Instance.TimNhanVien(lvNhanVien, cbbTimNv.Text);
        }

        #endregion

        #region MOUSE CLICK
        private void lvNhanVien_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem lvitem in lvNhanVien.SelectedItems)
            {
                txtManv.Text = lvitem.SubItems[0].Text;
                txtTennv.Text = lvitem.SubItems[1].Text;
                dtimeNgaySinhNV.Text = lvitem.SubItems[2].Text;
                if (lvitem.SubItems[3].Text.ToString() == "Nam")
                    rbtnNam.Checked = true;
                else
                    rbtnNu.Checked = true;
                txtDiaChinv.Text = lvitem.SubItems[4].Text;
                txtDienThoainv.Text = lvitem.SubItems[5].Text;
                txtLuongnv.Text = lvitem.SubItems[6].Text;
                if (lvitem.SubItems[7].Text.ToString().ToUpper() == "ADMIN")
                    rbtnAD.Checked = true;
                else if (lvitem.SubItems[7].Text.ToString().ToUpper() == "NHÂN VIÊN")
                    rbtnNv.Checked = true;
                else
                    rbtnQL.Checked = true;
            }
        }
        #endregion
    }
}
