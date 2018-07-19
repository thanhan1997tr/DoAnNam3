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
    public partial class fmManager : Form
    {
        public fmManager()
        {
            InitializeComponent();
            LoadTable();
            LoadComBoBoxTable1();
            LoadComBoBoxTable2();
            fmThongTinTaiKhoan fmTk = new fmThongTinTaiKhoan();
            lblChucVu.Text = fmTk.getChucvu(); //Lấy từ hàm getChucVu ử form fmThongTinTaiKhoan
            lblTenNv.Text = fmTk.getTenNv();
            getQuyen();
            LoadComboCa();
        }

        #region Phân quyền
        public void getQuyen()
        {
            string chucvu = lblChucVu.Text;
            if (chucvu.ToUpper().Equals("THU NGÂN"))
            {
                btnChonCa.Enabled = true;
                adminToolStripMenuItem.Visible = false;
                mặtHàngToolStripMenuItem.Visible = false;
                phiếuNhậpToolStripMenuItem.Visible = false;
                nhàCungCấpToolStripMenuItem.Visible = false;
            }
            else if (chucvu.ToUpper().Equals("QUẢN LÝ"))
            {
                adminToolStripMenuItem.Visible = false;
            }
            else if (chucvu.ToUpper().Equals("ADMIN"))
            {
            }
            else
            {
                adminToolStripMenuItem.Visible = false;
                hóaĐơnToolStripMenuItem.Visible = false;
                khoHàngToolStripMenuItem.Visible = false;
                thốngKêToolStripMenuItem.Visible = false;
                btnQuanLyBan.Visible = false;
            }
        }
        #endregion

        #region Bàn
        public void LoadTable()
        {
            flplisttable.Controls.Clear();
            //Load button danh sách bàn tự động
            List<TableDTO> tb = TableDAO.Instance.Load_Table();

            foreach (TableDTO item in tb)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                //btn.Text = item.STenBan + Environment.NewLine + item.STrangThai;
                btn.Text = item.SMaBan;
                btn.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;
                btn.Cursor = System.Windows.Forms.Cursors.Hand;
                btn.Click += btn_Click;
                //btn.DoubleClick += new EventHandler(btn_DoubleClick); ;
                btn.Tag = item;
                switch (item.STrangThai.ToUpper())
                {
                    case "TRỐNG":
                        btn.BackColor = Color.White;
                        btn.BackgroundImage = Properties.Resources.btnTable;
                        btn.ForeColor = Color.White;
                        break;
                    default:
                        btn.BackColor = Color.Red;
                        btn.ForeColor = Color.White;
                        break;
                }
                flplisttable.Controls.Add(btn);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            getBan.sMaBan = ((sender as Button).Tag as TableDTO).SMaBan;
            getBan.sTrangThai = ((sender as Button).Tag as TableDTO).STrangThai;

            fmChiTietBan f = new fmChiTietBan(this);
            //f.UpdatefmManager = new fmChiTietBan.Update(LoadTable); // Update form fmManager Cách 2
            f.Text = ((sender as Button).Tag as TableDTO).STenBan;
            f.ShowDialog();
            this.Show();
        }

        public void LoadComBoBoxTable1() //Load combobox bàn để thực hiện chuyển, gộp bàn
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

        private void btnQuanLyBan_Click(object sender, EventArgs e)
        {
            fmQuanLyBan f = new fmQuanLyBan(this);
            //f.UpdatefmManager = new fmQuanLyBan.Update(LoadTable); // Update table khi thêm table Cách 2
            f.ShowDialog();
        }
        #endregion

        #region Chuyển bàn, Gộp bàn
        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            string MaHDNew = HoaDonTheoNgayBUS.Instance.getMaHDMoi(); //Làm hóa đơn mới để chuyển sản phẩm vào
            string tb1 = cbbTable1.SelectedValue.ToString();
            string tb2 = cbbTable2.SelectedValue.ToString();
            if (MessageBox.Show("Bạn muốn chuyển bàn " + cbbTable1.Text + " qua bàn " + cbbTable2.Text + "", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                //Nếu tb1 trống thì hoán đổi tb1 và tb2
                //Bình thường chỉ chuyển được khi tb1 có người và tb2 trống (Nếu cả 2 tb đề có người thì không sao)
                if (TableDAO.Instance.getTrangThai(tb1).Equals("TRỐNG"))
                {
                    tb1 = cbbTable2.SelectedValue.ToString();
                    tb2 = cbbTable1.SelectedValue.ToString();
                    TableDAO.Instance.ChuyenBan(tb1, tb2, MaHDNew, fmDangNhap.getTaiKhoan.taiKhoan, fmManager.getCa.maca);
                    LoadTable();
                }
                else
                {
                    if (tb1 == tb2) { }
                    else
                    {
                        TableDAO.Instance.ChuyenBan(tb1, tb2, MaHDNew, fmDangNhap.getTaiKhoan.taiKhoan, fmManager.getCa.maca);
                        LoadTable();
                    }
                }
            }
        }

        private void btnGopBan_Click(object sender, EventArgs e)
        {
            string MaHDNew = HoaDonTheoNgayBUS.Instance.getMaHDMoi();
            string tb1 = cbbTable1.SelectedValue.ToString();
            string tb2 = cbbTable2.SelectedValue.ToString();
            if (MessageBox.Show("Bạn muốn gộp bàn " + cbbTable1.Text + " qua bàn " + cbbTable2.Text + "", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (tb1 == tb2) { }
                else
                {
                    TableDAO.Instance.GopBan(tb1, tb2);
                    LoadTable();
                }
            }
        }
        #endregion

        #region Giao Ca
        public void LoadComboCa()
        {
            cbbCaLam.DataSource = NhanVienDAO.Instance.LoadComboCa();
            cbbCaLam.DisplayMember = "TENCA";
            cbbCaLam.ValueMember = "MACA";
        }
        
        public static class getCa
        {
            static public string maca;
            static public string tenca;
        }
        public void TongTienCa(string MaCa)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
            lblTongTien.Text = HoaDonThanhToanDAO.Instance.TongTienCa(MaCa).ToString("c", culture);
        }
        public void EnabledTrue()
        {
            flplisttable.Enabled = true;
            btnChuyenBan.Enabled = true;
            btnGopBan.Enabled = true;
            btnQuanLyBan.Enabled = true;
            btnGiaoCa.Enabled = true;
        }
        public void EnabledFalse()
        {
            flplisttable.Enabled = false;
            btnChuyenBan.Enabled = false;
            btnGopBan.Enabled = false;
            btnQuanLyBan.Enabled = false;
            btnGiaoCa.Enabled = false;
            lblTongTien.Text = "";
        }

        private void btnChonCa_Click(object sender, EventArgs e)
        {
            ChonCa();
        }

        public void ChonCa()
        {
            string MaCa = cbbCaLam.SelectedValue.ToString();
            getCa.tenca = cbbCaLam.Text;

            //Lấy trạng thái trong bảng chi tiết ca theo ngày làm việc hiện tại. Nếu = 0 <=> FALSE là chưa giao ca ngày hôm đó
            string trangthai = CaDAO.Instance.TrangThai(MaCa);
            if (trangthai.ToUpper().Equals("FALSE")) //chưa giao ca
            {
                EnabledTrue();
                getCa.maca = MaCa;
                TongTienCa(MaCa);
                btnChonCa.Enabled = false;
                cbbCaLam.Enabled = false;
            }
            else if (trangthai.ToUpper().Equals("TRUE")) //ca đã làm
            {
                MessageBox.Show("Ca đã làm");
                EnabledFalse();
            }
            else //trạng thái = "" nếu chưa không được tìm thấy
            {
                //MessageBox.Show("Ca chưa làm");
                EnabledFalse();
                if (CaDAO.Instance.DemTrangThai0() >= 1)
                {
                    MessageBox.Show("Có ca chưa giao");
                }
                else
                {
                    if (MaCa.Equals("S") && CaDAO.Instance.DemTrangThai1() == 0) // Nếu là ca sáng và ngày đó chưa có ca nào giao ca thì thêm ca sáng vào csdl
                    {
                        CaDAO.Instance.ThemCa(MaCa);
                        EnabledTrue();
                        getCa.maca = MaCa;
                        TongTienCa(MaCa);
                    }
                    if (MaCa.Equals("C") && CaDAO.Instance.DemTrangThai1() == 1) //Nếu là ca chiều và ngày đó có 1 ca được giao (ca sáng) thì thêm ca chiều vào csdl
                    {
                        if (CaDAO.Instance.ktraCaToi() == false) //Nếu ca tối chưa làm thì mới thêm ca chiều //Phải kiểm tra ca tối vì có thể ngày hôm đó quán nghỉ ca chiều
                        {
                            CaDAO.Instance.ThemCa(MaCa);
                            EnabledTrue();
                            getCa.maca = MaCa;
                            TongTienCa(MaCa);
                        }
                    }
                    //Nếu là ca chiều và ngày đó có 0 ca được giao (quán nghỉca sáng) thì hỏi lại nhân viên và thêm ca chiều vào csdl
                    //Nếu sai nhân viên sẽ chịu phạt
                    else if (MaCa.Equals("C") && CaDAO.Instance.DemTrangThai1() == 0)
                    {
                        if (MessageBox.Show("Có chắc hiện tại là ca CHIỀU?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                        {
                            CaDAO.Instance.ThemCa(MaCa);
                            EnabledTrue();
                            getCa.maca = MaCa;
                            TongTienCa(MaCa);
                        }
                    }
                    //Ca tối tương tự ca chiều
                    if (MaCa.Equals("T") && CaDAO.Instance.DemTrangThai1() == 2) //Thêm ca tối
                    {
                        CaDAO.Instance.ThemCa(MaCa);
                        EnabledTrue();
                        getCa.maca = MaCa;
                        TongTienCa(MaCa);
                    }
                    else if (MaCa.Equals("T") && CaDAO.Instance.DemTrangThai1() < 2) // Hỏi lại và thêm ca tối nếu hôm đó qán nghỉ ca sáng hoặc chiều
                    {
                        if (MessageBox.Show("Có chắc hiện tại là ca TỐI?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                        {
                            CaDAO.Instance.ThemCa(MaCa);
                            EnabledTrue();
                            getCa.maca = MaCa;
                            TongTienCa(MaCa);
                        }
                    }
                }
            }
        }

        private void btnGiaoCa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn giao ca không?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                //Đếm số bàn chưa thanh toán
                int demTb = 0;
                List<TableDTO> tb = TableDAO.Instance.Load_Table();
                foreach (TableDTO item in tb)
                {
                    if (item.STrangThai.ToUpper().Equals("CÓ"))
                    {
                        demTb++;
                    }
                }
                if (demTb > 0)
                {
                    MessageBox.Show("Còn bàn chưa thanh toán.", "Thông báo");
                }
                else
                {
                    //Mở lại btn Chọn ca
                    btnChonCa.Enabled = true;
                    cbbCaLam.Enabled = true;

                    //Sau khi thanh toán thì cập nhật lại ca làm việc ngày hôm đấy = 1
                    CaDAO.Instance.CapNhatTrangThai(getCa.maca);
                    string MaCa = getCa.maca;
                    DateTime date = DateTime.Now;
                    string Ngay = date.ToString("MM/dd/yyyy");

                    //Hiện form giao ca để in báo cao kết ca đưa cho quản lý kiểm tra
                    fmGiaoCa fGc = new fmGiaoCa(Ngay, MaCa);
                    fGc.ShowDialog();
                    lblTongTien.Text = "";
                    EnabledFalse();
                }
            }
        }
        #endregion

        #region Menu Strip
        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmNhanVien f = new fmNhanVien();
            f.Show();
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

        private void xemGiaoCaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmTimGiaoCa fm = new fmTimGiaoCa();
            fm.Show();
        }

        private void mặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmMatHang fm = new fmMatHang();
            fm.Show();
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmPhieuNhap fm = new fmPhieuNhap();
            fm.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmNhaCungCap fm = new fmNhaCungCap();
            fm.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            fmDangNhap fm = new fmDangNhap();
            fm.Show();
        }

        private void tổngTiềnNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmTienNhapHang fm = new fmTienNhapHang();
            fm.Show();
        }
        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmSanPham f = new fmSanPham();
            f.Show();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmDoanhThu f = new fmDoanhThu();
            f.Show();
        }

        private void chấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmChamCong f = new fmChamCong();
            f.Show();
        }
        #endregion
    }
}
