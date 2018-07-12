using DAO;
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
    public partial class fmChamCong : Form
    {
        public fmChamCong()
        {
            InitializeComponent();
            LoadCombobox();
            getQuyen();
            DateTime date = DateTime.Now;
            string thangN = date.Month.ToString();
            string namN = date.Year.ToString();
            LoadDS(thangN, namN);
            dataGridView1.Columns["TenNv"].ReadOnly = true;
            dataGridView1.Columns["TONGCONG"].ReadOnly = true;
            LoadNgay(thangN, namN);
            if (ChamCongDAO.Instance.KiemTraTrungThang(thangN, namN) == 0)
            {
                btnThem.Enabled = true;
            }
        }

        public void getQuyen()
        {
            fmThongTinTaiKhoan fm = new fmThongTinTaiKhoan();
            string chucvu = fm.getChucvu();
            if (!chucvu.ToUpper().Equals("QUẢN LÝ") && !chucvu.ToUpper().Equals("ADMIN"))
            {
                btnLuu.Visible = false;
                btnTraLuong.Visible = false;
                btnThem.Visible = false;
                dataGridView1.ReadOnly = true;
                label1.Visible = false;
            }
        }
        public void LoadDS(string thang, string nam)
        {
            
            dataGridView1.Columns["LUONGCOBAN"].ReadOnly = true;
            dataGridView1.Columns["LUONG"].ReadOnly = true;
            dataGridView1.Columns["LUONGCOBAN"].Visible = false;
            dataGridView1.Columns["LUONG"].Visible = false;
            dataGridView1.Columns["MANV"].Visible = false;
            dataGridView1.Columns["TenNv"].ReadOnly = true;
            dataGridView1.Columns["TONGCONG"].ReadOnly = true;
            dataGridView1.DataSource = ChamCongDAO.Instance.LoadDs(thang, nam);
            DateTime date = DateTime.Now;
            string thangN = date.Month.ToString();
            string namN = date.Year.ToString();
            if (thang.Equals(thangN) && nam.Equals(namN))
            {
                dataGridView1.ReadOnly = false;
            }
            else
            {
                dataGridView1.ReadOnly = true;
            }
        }

        public void LoadCombobox()
        {
            cbbNam.DataSource = ChamCongDAO.Instance.LoadNam();
            cbbNam.DisplayMember = "NAM";
            cbbNam.ValueMember = "NAM";
            string nam;
            try
            {
                nam = cbbNam.SelectedValue.ToString();
            }
            catch (Exception)
            {
                nam = "";
            }
            cbbThang.DataSource = ChamCongDAO.Instance.LoadThangTheoNam(nam);
            cbbThang.DisplayMember = "THANG";
            cbbThang.ValueMember = "THANG";
        }
        public void LoadNgay(string t, string na)
        {
            int thang = Convert.ToInt32(t);
            int nam = Convert.ToInt32(na);
            int songay = DateTime.DaysInMonth(nam, thang);
            for (var i = 1; i <= songay; i++)
            {
                var n = "N" + i;
                dataGridView1.Columns[n].Visible = true;
            }
            for (var i = songay + 1; i <= 31; i++)
            {
                var n = "N" + i;
                dataGridView1.Columns[n].Visible = false;
            }
        }

        public void TinhSoNgayCong()
        {
            string macong = "";
            try
            {
                macong = dataGridView1.Rows[0].Cells["MaChamCong"].Value.ToString();
            }
            catch
            {

            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string manv = dataGridView1.Rows[i].Cells["MaNv"].Value.ToString();
                int tong = 0;
                for (var j = 1; j <= 31; j++)
                {
                    var n = "N" + j;
                    int ngay = Convert.ToInt32(dataGridView1.Rows[i].Cells[n].Value);
                    //string tennv = dataGridView1.Rows[i].Cells["TenNv"].Value.ToString();
                    tong += ngay;
                    //bool cell = Convert.ToBoolean(dataGridView1.Rows[index].Cells[i].Value);
                    //try
                    //{
                    //    int ng = Convert.ToInt32(ngay);
                    //    if (ng > 3 || ng < 0)
                    //    {
                    //        MessageBox.Show(tennv + "-> Ngày " + j + " nhập sai.");

                    //    }
                    //    else
                    //    {
                    //        tong += ngay;
                    //    }
                    //}
                    //catch (Exception)
                    //{
                    //    MessageBox.Show(tennv + "-> Ngày " + j + " nhập sai.");
                    //}
                }
                ChamCongDAO.Instance.UpdateTongCong(tong, manv, macong);
                string nam = cbbNam.Text.ToString();
                string thang = cbbThang.Text.ToString();
                LoadDS(thang, nam);
                //s += dem.ToString() + " - ";

            }

            //MessageBox.Show(s);

        }

        private void cbbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbThang.DataSource = ChamCongDAO.Instance.LoadThangTheoNam(cbbNam.Text);
            cbbThang.DisplayMember = "THANG";
            cbbThang.ValueMember = "THANG";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //btnTim_Click(sender, e);
            int dem = 0;
            string macong = "";
            try
            {
                macong = dataGridView1.Rows[0].Cells["MaChamCong"].Value.ToString();
            }
            catch
            {
                
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string manv = dataGridView1.Rows[i].Cells["MaNv"].Value.ToString();
                for (var j = 1; j <= 31; j++)
                {
                    var n = "N" + j;
                    //bool cell = Convert.ToBoolean(dataGridView1.Rows[index].Cells[i].Value);
                    string ngay = dataGridView1.Rows[i].Cells[n].Value.ToString();
                    string tennv = dataGridView1.Rows[i].Cells["TenNv"].Value.ToString();
                    try
                    {
                        int ng = Convert.ToInt32(ngay);
                        if (ng > 3 || ng < 0)
                        {
                            MessageBox.Show(tennv + "-> Ngày " + j + " nhập sai.");
                            dem++;

                        }
                        else
                        {
                            ChamCongDAO.Instance.UpdateCong(n, ngay, manv, macong);
                        }
                    }
                    catch(Exception)
                    {
                        MessageBox.Show(tennv + "-> Ngày " + j + " nhập sai.");
                        dem++;
                    }
                }
            }
            if (dem == 0)
            {
                TinhSoNgayCong();
            }
            lblTongLuong.Text = "";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                string nam = cbbNam.SelectedValue.ToString();
                string thang = cbbThang.SelectedValue.ToString();
                LoadDS(thang, nam);
                LoadNgay(thang, nam);
                lblTongLuong.Text = "";
            }
            catch (Exception)
            {

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string thang = date.Month.ToString();
            string nam = date.Year.ToString();
            ChamCongDAO.Instance.ThemChamCong(thang, nam);
            int t = Convert.ToInt32(thang);
            int n = Convert.ToInt32(nam);
            LoadNgay(thang, nam);
            LoadDS(thang, nam);
            LoadCombobox();
            lblTongLuong.Text = "";
        }

        public void TraLuong()
        {
            dataGridView1.Columns["LUONGCOBAN"].Visible = true;
            dataGridView1.Columns["LUONG"].Visible = true;
            dataGridView1.Columns["LUONGCOBAN"].ReadOnly = true;
            dataGridView1.Columns["LUONG"].ReadOnly = true;
            for (var i = 1; i <= 31; i++)
            {
                var n = "N" + i;
                dataGridView1.Columns[n].Visible = false;
            }
            double luong = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                luong += Convert.ToDouble(dataGridView1.Rows[i].Cells["LUONG"].Value.ToString());
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
            lblTongLuong.Text = luong.ToString("c", culture);
        }

        private void btnTraLuong_Click(object sender, EventArgs e)
        {
            btnTim_Click(sender, e);
            TraLuong();
        }
    }
}
