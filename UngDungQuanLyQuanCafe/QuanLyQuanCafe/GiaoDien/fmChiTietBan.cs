using BUS;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class fmChiTietBan : Form
    {
        public fmChiTietBan()
        {
            InitializeComponent();
            if (fmManager.getBan.sTrangThai.Equals("CÓ"))
            {
                LoadHoaDonThanhToan();
                LoadComboboxSanPham();
            }
        }

        public void LoadComboboxSanPham()
        {
            cbbThemMon_Manager.DisplayMember = "TENSP";
            cbbThemMon_Manager.ValueMember = "MASP";
            cbbThemMon_Manager.DataSource = SanPhamDAO.Instance.LoadComBoBoxSanPham();
        }
        public void ShowTongTien()
        {
            float ShowTongTien = HoaDonThanhToanBUS.getTongTien.TongTien;
            ShowTongTien = HoaDonThanhToanBUS.getTongTien.TongTien - (HoaDonThanhToanBUS.getTongTien.TongTien * (float)Convert.ToDouble(nbrGiamGia.Value)) / 100 + (HoaDonThanhToanBUS.getTongTien.TongTien * (float)Convert.ToDouble(nbrVAT.Value)) / 100;
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
            txtTongTien.Text = ShowTongTien.ToString("c", culture);
        }

        public void LoadHoaDonThanhToan()
        {
            lbnhanvien.Text = "";
            lbtime.Text = "";
            string MaBan = fmManager.getBan.sMaBan;
            HoaDonThanhToanBUS.Instance.LoadHoaDonMenu(lvHoaDon, MaBan, lbnhanvien, lbtime, txtTongTien, nbrGiamGia, nbrVAT);
            ShowTongTien();
        }

        private void lvHoaDon_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem lvitem in lvHoaDon.SelectedItems)
            {
                cbbThemMon_Manager.Text = lvitem.SubItems[0].Text;
                nbrSoLuong_Manager.Value = Convert.ToDecimal(lvitem.SubItems[1].Text);
            }
        }

        private void nbrGiamGia_ValueChanged(object sender, EventArgs e)
        {
            ShowTongTien();
        }

        private void nbrVAT_ValueChanged(object sender, EventArgs e)
        {
            ShowTongTien();
        }

        #region THÊM BỚT MÓN
        public delegate void Update();
        public Update UpdatefmManager;
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (SanPhamDAO.Instance.KiemTraTenSP(cbbThemMon_Manager.Text))
            {
                string MaBan = fmManager.getBan.sMaBan;
                int soluong = (int)nbrSoLuong_Manager.Value;
                foreach (ListViewItem lvitem in lvHoaDon.Items)
                {
                    if (cbbThemMon_Manager.Text == lvitem.SubItems[0].Text)
                    {
                        soluong += Convert.ToInt32(lvitem.SubItems[1].Text);
                    }
                }
                string KtraMaHD = HoaDonTheoNgayDAO.Instance.getIDTheoHoaDon(MaBan);
                if (KtraMaHD.Equals("NO")) //nếu chưa tồn tại hóa đơn thì tạo hóa đơn mới
                {
                    string MaHDNew = HoaDonTheoNgayBUS.Instance.getMaHDMoi();
                    string MaNv = fmDangNhap.getTaiKhoan.taiKhoan;
                    float GiamGia = ((float)nbrGiamGia.Value) / 100;
                    float Vat = ((float)nbrVAT.Value) / 100;
                    if (GiamGia == 0 || Vat == 0)
                    {
                        if (MessageBox.Show("Có thêm GIẢM GIÁ hoặc VAT hay không?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.Cancel)
                        {
                            HoaDonTheoNgayDTO hd = new HoaDonTheoNgayDTO(MaHDNew, "", "", MaNv, MaBan, GiamGia, Vat, 0, "");
                            HoaDonTheoNgayDAO.Instance.ThemHoaDon(hd);
                            HoaDonChiTietDAO.Instance.ThemHoaDonChiTiet(MaHDNew, cbbThemMon_Manager.SelectedValue.ToString(), soluong);
                        }
                    }
                }
                else
                {
                    //Nếu mã hóa đơn đã có và chưa thanh toán thì thêm món mới vào hóa đơn chi tiết của hóa đơn đó
                    HoaDonChiTietDAO.Instance.ThemHoaDonChiTiet(KtraMaHD, cbbThemMon_Manager.SelectedValue.ToString(), soluong);
                }
                //Load lại danh sách sản phẩm trong hóa đơn
                HoaDonThanhToanBUS.Instance.LoadHoaDonMenu(lvHoaDon, MaBan, lbnhanvien, lbtime, txtTongTien, nbrGiamGia, nbrVAT);
                UpdatefmManager();
            }
            else
            {
                MessageBox.Show("Sản phẩm không tồn tại", "Thông báo.");
            }
        }

        private void btnBotMon_Click(object sender, EventArgs e)
        {
            string MaBan = fmManager.getBan.sMaBan;
            string KtraMaHD = HoaDonTheoNgayDAO.Instance.getIDTheoHoaDon(MaBan);
            if (!KtraMaHD.Equals("NO"))
            {
                if (SanPhamDAO.Instance.KiemTraTenSP(cbbThemMon_Manager.Text))
                {
                    int soluong = (int)nbrSoLuong_Manager.Value;
                    foreach (ListViewItem lvitem in lvHoaDon.Items)
                    {
                        if (cbbThemMon_Manager.Text == lvitem.SubItems[0].Text)
                        {
                            soluong = Convert.ToInt32(lvitem.SubItems[1].Text) - soluong;
                        }
                    }
                    if (soluong < 0)
                    {
                        MessageBox.Show("Số lượng hiện có ít hơn số lượng bớt", "Thông báo.");
                    }
                    else
                    {
                        HoaDonChiTietDAO.Instance.ThemHoaDonChiTiet(KtraMaHD, cbbThemMon_Manager.SelectedValue.ToString(), soluong);
                    }
                    HoaDonThanhToanBUS.Instance.LoadHoaDonMenu(lvHoaDon, MaBan, lbnhanvien, lbtime, txtTongTien, nbrGiamGia, nbrVAT);
                }
                else
                {
                    MessageBox.Show("Sản phẩm không tồn tại", "Thông báo.");
                }
            }
        }

        #endregion

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string MaBan = fmManager.getBan.sMaBan;
            string KtraMaHD = HoaDonTheoNgayDAO.Instance.getIDTheoHoaDon(MaBan);
            if (!KtraMaHD.Equals("NO"))
            {
                if (MessageBox.Show("Bạn có chắc thanh toán", "Thông Báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    float TongTien = HoaDonThanhToanBUS.getTongTien.TongTien - (HoaDonThanhToanBUS.getTongTien.TongTien * (float)Convert.ToDouble(nbrGiamGia.Value)) / 100 + (HoaDonThanhToanBUS.getTongTien.TongTien * (float)Convert.ToDouble(nbrVAT.Value)) / 100;
                    HoaDonThanhToanDAO.Instance.ThanhToan(KtraMaHD, TongTien);
                    UpdatefmManager();
                    fmHoaDonChiTiet fm = new fmHoaDonChiTiet(KtraMaHD);
                    fm.Text = KtraMaHD;
                    fm.ShowDialog();
                    lvHoaDon.Items.Clear();
                    //HoaDonThanhToanBUS.Instance.LoadHoaDonMenu(lvHoaDon, MaBan, lbnhanvien, lbtime, txtTongTien, nbrGiamGia, nbrVAT);
                    nbrSoLuong_Manager.Value = 0;
                    nbrVAT.Value = 0;
                    nbrGiamGia.Value = 0;
                    lbnhanvien.Text = "";
                    lbtime.Text = "";
                    txtTongTien.Text = "";
                    LoadComboboxSanPham();
                }
            }
        }
    }
}
