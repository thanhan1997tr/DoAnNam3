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
        fmManager fmMa;
        public fmChiTietBan(fmManager f)
        {
            fmMa = f; //Khi tắt form thì bên form fmManager cập nhật (cập nhật bàn trống hoặc có người khi thanh toán hoặc thêm món vào bàn mới
            InitializeComponent();
            LoadComboboxSanPham();
            if (fmManager.getBan.sTrangThai.Equals("CÓ")) //Lấy từ btn_Click bên form fmManager
            {
                LoadHoaDonThanhToan();
            }
        }

        public void LoadComboboxSanPham()
        {
            cbbThemMon_Manager.DisplayMember = "TENSP";
            cbbThemMon_Manager.ValueMember = "MASP";
            cbbThemMon_Manager.DataSource = SanPhamDAO.Instance.LoadComBoBoxSanPham();
        }

        //Tính tổng tiền khi thay đổi Giảm giá và vat
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

        //Khi giảm giá thay đổi thì cập nhật vào csdl
        private void nbrGiamGia_ValueChanged(object sender, EventArgs e)
        {
            string MaBan = fmManager.getBan.sMaBan; //Lấy từ btn_Click bên form fmManager
            string KtraMaHD = HoaDonTheoNgayDAO.Instance.getIDTheoHoaDon(MaBan);
            float GiamGia = ((float)nbrGiamGia.Value) / 100;
            float Vat = ((float)nbrVAT.Value) / 100;
            if (!KtraMaHD.Equals("NO"))
            {
                HoaDonThanhToanDAO.Instance.UpdateGiamGia_VAT(KtraMaHD, GiamGia, Vat);
                ShowTongTien();
            }
        }

        private void nbrVAT_ValueChanged(object sender, EventArgs e)
        {
            string MaBan = fmManager.getBan.sMaBan;
            string KtraMaHD = HoaDonTheoNgayDAO.Instance.getIDTheoHoaDon(MaBan);
            float GiamGia = ((float)nbrGiamGia.Value) / 100;
            float Vat = ((float)nbrVAT.Value) / 100;
            if (!KtraMaHD.Equals("NO"))
            {
                HoaDonThanhToanDAO.Instance.UpdateGiamGia_VAT(KtraMaHD, GiamGia, Vat);
                ShowTongTien();
            }
        }

        #region THÊM BỚT MÓN
        //Cập nhật form fmManager cách 2
        //public delegate void Update();
        //public Update UpdatefmManager;

        //Thêm vào csdl rồi load lại từ csdl
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            //Trường hợp người dùng tự nhập bằng tay nếu nhập không có sp thì thông báo. Nếu đúng thì thực hiện thêm món
            if (SanPhamDAO.Instance.KiemTraTenSP(cbbThemMon_Manager.Text))
            {
                string MaBan = fmManager.getBan.sMaBan;
                int soluong = (int)nbrSoLuong_Manager.Value; //Số lượng món
                foreach (ListViewItem lvitem in lvHoaDon.Items)
                {
                    //Kiểm tra món chọn trên combobox có trong listview hay không. Nếu có thì cộng với số lượng trên listview
                    if (cbbThemMon_Manager.Text == lvitem.SubItems[0].Text)
                    {
                        soluong += Convert.ToInt32(lvitem.SubItems[1].Text);
                    }
                }
                string KtraMaHD = HoaDonTheoNgayDAO.Instance.getIDTheoHoaDon(MaBan); //Kiểm tra xem bàn hiện tại có hóa đơn hay chưa
                if (KtraMaHD.Equals("NO")) //nếu chưa tồn tại hóa đơn thì tạo hóa đơn mới
                {
                    string MaHDNew = HoaDonTheoNgayBUS.Instance.getMaHDMoi(); //Tự động lấy mã theo //HD+ngày tháng năm giờ phút giây
                    string MaNv = fmDangNhap.getTaiKhoan.taiKhoan; //Mã nhân viên đăng nhập hiện tại
                    float GiamGia = ((float)nbrGiamGia.Value) / 100;
                    float Vat = ((float)nbrVAT.Value) / 100;
                    string MaCa = fmManager.getCa.maca;
                    if (soluong > 0) //Khi thêm món số lượng phải > 0
                    {
                        HoaDonTheoNgayDTO hd = new HoaDonTheoNgayDTO(MaHDNew, "", "", MaNv, MaBan, GiamGia, Vat, 0, "", MaCa);
                        //Thêm hóa đơn vào csdl
                        HoaDonTheoNgayDAO.Instance.ThemHoaDon(hd);
                        //Thêm hóa đơn chi tiết vào csdl
                        HoaDonChiTietDAO.Instance.ThemHoaDonChiTiet(MaHDNew, cbbThemMon_Manager.SelectedValue.ToString(), soluong);
                        //Load lại hóa đơn vừa mới thêm trong csdl ra form
                        HoaDonThanhToanBUS.Instance.LoadHoaDonMenu(lvHoaDon, MaBan, lbnhanvien, lbtime, txtTongTien, nbrGiamGia, nbrVAT);
                    }
                    else
                    {
                        MessageBox.Show("Chưa nhập số lượng", "Thông báo");
                    }
                }
                else
                {
                    if (soluong > 0)
                    {
                        //Nếu mã hóa đơn đã có và chưa thanh toán thì thêm món mới vào hóa đơn chi tiết của hóa đơn đó
                        HoaDonChiTietDAO.Instance.ThemHoaDonChiTiet(KtraMaHD, cbbThemMon_Manager.SelectedValue.ToString(), soluong);
                        //Load lại hóa đơn vừa mới thêm trong csdl ra form
                        HoaDonThanhToanBUS.Instance.LoadHoaDonMenu(lvHoaDon, MaBan, lbnhanvien, lbtime, txtTongTien, nbrGiamGia, nbrVAT);
                    }
                    else
                    {
                        MessageBox.Show("Chưa nhập số lượng", "Thông báo");
                    }
                }
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
                    bool ktrasp = false;
                    foreach (ListViewItem lvitem in lvHoaDon.Items)
                    {
                        if (cbbThemMon_Manager.Text == lvitem.SubItems[0].Text)
                        {
                            soluong = Convert.ToInt32(lvitem.SubItems[1].Text) - soluong; //Lấy số lượng đã có trừ số lượng muốn trừ nhập vào
                            ktrasp = true;
                            break;
                        }
                    }
                    if (soluong < 0)
                    {
                        MessageBox.Show("Số lượng hiện có ít hơn số lượng bớt", "Thông báo.");
                    }
                    else
                    {
                        if (ktrasp)
                        {
                            //Cập nhật lại số lượng vào hdct. Nếu như số lượng = 0 thì đồng nghĩa với việc xóa món đó
                            HoaDonChiTietDAO.Instance.ThemHoaDonChiTiet(KtraMaHD, cbbThemMon_Manager.SelectedValue.ToString(), soluong);
                            HoaDonThanhToanBUS.Instance.LoadHoaDonMenu(lvHoaDon, MaBan, lbnhanvien, lbtime, txtTongTien, nbrGiamGia, nbrVAT);
                        }
                        else
                        {
                            MessageBox.Show("Sản phẩm không có trong danh sách.", "Thông báo.");
                        }
                    }
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
            if (!KtraMaHD.Equals("NO")) //Nếu bàn này có người thì thanh toán (có hóa đơn)
            {
                if (MessageBox.Show("Bạn có chắc thanh toán", "Thông Báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    float GiamGia = (float)Convert.ToDouble(nbrGiamGia.Value) / 100;
                    float Vat = (float)Convert.ToDouble(nbrVAT.Value) / 100;
                    float TongTien = HoaDonThanhToanBUS.getTongTien.TongTien - (HoaDonThanhToanBUS.getTongTien.TongTien * GiamGia) + (HoaDonThanhToanBUS.getTongTien.TongTien * Vat);
                    //Tổng tiền
                    HoaDonThanhToanDAO.Instance.ThanhToan(KtraMaHD, TongTien, GiamGia, Vat);

                    //Cập nhật tổng tiền ca đang làm việc bán được bao nhiêu
                    string MaCa = fmManager.getCa.maca;
                    fmMa.TongTienCa(MaCa);

                    //Show form hóa đơn chi tiết để in hóa đơn
                    fmHoaDonChiTiet fm = new fmHoaDonChiTiet(KtraMaHD);
                    fm.Text = KtraMaHD;
                    fm.ShowDialog();

                    //Reset form
                    lvHoaDon.Items.Clear();
                    nbrSoLuong_Manager.Value = 0;
                    nbrVAT.Value = 0;
                    nbrGiamGia.Value = 0;
                    lbnhanvien.Text = "";
                    lbtime.Text = "";
                    txtTongTien.Text = "";
                }
            }
        }

        ////Khi tắt form thì bên form fmManager cập nhật (cập nhật bàn trống hoặc có người khi thanh toán hoặc thêm món vào bàn mới
        private void fmChiTietBan_FormClosing(object sender, FormClosingEventArgs e)
        {
            //UpdatefmManager();
            fmMa.LoadTable();
        }
    }
}
