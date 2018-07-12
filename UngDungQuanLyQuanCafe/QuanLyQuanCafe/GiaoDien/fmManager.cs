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
        }

        private void fmManager_Load(object sender, EventArgs e)
        {
            LoadTable();
            LoadComBoBoxTable1();
            LoadComBoBoxTable2();
            fmThongTinTaiKhoan fmTk = new fmThongTinTaiKhoan();
            lblChucVu.Text = fmTk.getChucvu();
            lblTenNv.Text = fmTk.getTenNv();
            getQuyen();
            LoadComboCa();
        }

        public void getQuyen()
        {
            string chucvu = lblChucVu.Text;
            if (chucvu.ToUpper().Equals("THU NGÂN"))
            {
                btnChonCa.Enabled = true;
                adminToolStripMenuItem.Visible = false;
                //quảnLýToolStripMenuItem.Visible = false;
                mặtHàngToolStripMenuItem.Visible = false;
                phiếuNhậpToolStripMenuItem.Visible = false;
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
                //quảnLýToolStripMenuItem.Visible = false;
                hóaĐơnToolStripMenuItem.Visible = false;
                khoHàngToolStripMenuItem.Visible = false;
                thốngKêToolStripMenuItem.Visible = false;
                btnQuanLyBan.Visible = false;
            }
        }
        public void LoadComboCa()
        {
            cbbCaLam.DataSource = NhanVienDAO.Instance.LoadComboCa();
            cbbCaLam.DisplayMember = "TENCA";
            cbbCaLam.ValueMember = "MACA";
        }
        public void LoadTable()
        {
            flplisttable.Controls.Clear();
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
            //f.UpdatefmManager = new fmChiTietBan.Update(LoadTable);
            f.Text = ((sender as Button).Tag as TableDTO).STenBan;
            f.ShowDialog();
            this.Show();


            //getFormManager.lv.Tag = (sender as Button).Tag;
            //lbnhanvien.Text = "";
            //lbtime.Text = "";

            //HoaDonMenuBUS.Instance.LoadHoaDonMenu(lvHoaDon, MaBan, lbnhanvien, lbtime, txtTongTien);
            //ShowTongTien();


            //---------------------
            //txtGhiChu.Tag = (sender as Button).Tag;
            //string MaHD = HoaDonDAO.Instance.getIDTheoHoaDon(MaBan);
            //HoaDonDAO.Instance.XoaHDTheoBan(MaBan, MaHD);
            //throw new NotImplementedException();
        }

        public void LoadComBoBoxTable1()
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

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmNhanVien f = new fmNhanVien();
            f.Show();
        }

        private void btnQuanLyBan_Click(object sender, EventArgs e)
        {
            fmQuanLyBan f = new fmQuanLyBan(this);
            //f.UpdatefmManager = new fmQuanLyBan.Update(LoadTable); // Update table khi thêm table
            f.ShowDialog();
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

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            string MaHDNew = HoaDonTheoNgayBUS.Instance.getMaHDMoi(); //Làm hóa đơn mới để chuyển sản phẩm vào
            string tb1 = cbbTable1.SelectedValue.ToString();
            string tb2 = cbbTable2.SelectedValue.ToString();
            if (MessageBox.Show("Bạn muốn chuyển bàn " + cbbTable1.Text + " qua bàn " + cbbTable2.Text + "", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (TableDAO.Instance.getTrangThai(tb1).Equals("TRỐNG"))
                {
                    //MessageBox.Show("Phải chuyển bàn CÓ qua bàn TRỐNG\n\t" + cbbTable2.Text + " --> " + cbbTable1.Text, "LỖI");
                    tb1 = cbbTable2.SelectedValue.ToString();
                    tb2 = cbbTable1.SelectedValue.ToString();
                    TableDAO.Instance.ChuyenBan(tb1, tb2, MaHDNew, fmDangNhap.getTaiKhoan.taiKhoan);
                    LoadTable();
                }
                else
                {
                    if (tb1 == tb2) { }
                    else
                    {
                        TableDAO.Instance.ChuyenBan(tb1, tb2, MaHDNew, fmDangNhap.getTaiKhoan.taiKhoan);
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

        private void btnChonCa_Click(object sender, EventArgs e)
        {
            ChonCa();
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
        public void ChonCa()
        {
            string MaCa = cbbCaLam.SelectedValue.ToString();
            getCa.tenca = cbbCaLam.Text;
            string trangthai = CaDAO.Instance.TrangThai(MaCa);
            if (trangthai.ToUpper().Equals("FALSE")) //chưa giao ca
            {
                EnabledTrue();
                getCa.maca = MaCa;
                TongTienCa(MaCa);
            }
            else if (trangthai.ToUpper().Equals("TRUE")) //ca đã làm
            {
                EnabledFalse();
            }
            else
            {
                //MessageBox.Show("Ca chưa làm");
                EnabledFalse();
                if (CaDAO.Instance.DemTrangThai0() >= 1)
                {
                    MessageBox.Show("Có ca chưa giao");
                }
                else
                {
                    //string ca = "";
                    if (MaCa.Equals("S") && CaDAO.Instance.DemTrangThai1() == 0)
                    {
                        CaDAO.Instance.ThemCa(MaCa);
                        EnabledTrue();
                        getCa.maca = MaCa;
                        TongTienCa(MaCa);
                    }
                    if (MaCa.Equals("C") && CaDAO.Instance.DemTrangThai1() == 1)
                    {
                        if (CaDAO.Instance.ktraCaToi() == false)
                        {
                            CaDAO.Instance.ThemCa(MaCa);
                            EnabledTrue();
                            getCa.maca = MaCa;
                            TongTienCa(MaCa);
                        }
                    }
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
                    if (MaCa.Equals("T") && CaDAO.Instance.DemTrangThai1() == 2)
                    {
                        CaDAO.Instance.ThemCa(MaCa);
                        EnabledTrue();
                        getCa.maca = MaCa;
                        TongTienCa(MaCa);
                    }
                    else if (MaCa.Equals("T") && CaDAO.Instance.DemTrangThai1() < 2)
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
                    MessageBox.Show("Còn bàn chưa thanh toán.");
                }
                else
                {
                    CaDAO.Instance.CapNhatTrangThai(getCa.maca);
                    fmGiaoCa fGc = new fmGiaoCa();
                    fGc.ShowDialog();
                    lblTongTien.Text = "";
                    EnabledFalse();
                }
            }
        }
    }
}
