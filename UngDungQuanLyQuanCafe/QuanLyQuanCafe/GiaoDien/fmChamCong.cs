using DAO;
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
    public partial class fmChamCong : Form
    {
        DataTable dt;
        ChamCongDAO cc = new ChamCongDAO();

        public fmChamCong()
        {
            InitializeComponent();
            LoadCombobox();
            DateTime date = DateTime.Now;
            string thangN = date.Month.ToString();
            string namN = date.Year.ToString();
            LoadDS(thangN, namN);
            LoadNgay(thangN, namN);
            if (cc.KiemTraTrungThang(thangN, namN) == 0)
            {
                btnThem.Enabled = true;
            }
        }

        public void LoadDS(string thang, string nam)
        {
            dt = cc.LoadDs(thang, nam);
            dataGridView1.DataSource = dt;
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
            cbbNam.DataSource = cc.LoadNam();
            cbbNam.DisplayMember = "NAM";
            cbbNam.ValueMember = "NAM";
            string nam;
            try
            {
                nam = cbbNam.SelectedValue.ToString();
            }
            catch (Exception)
            {
                nam  = "";
            }
            cbbThang.DataSource = cc.LoadThangTheoNam(nam);
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

            //int index = dataGridView1.CurrentCell.RowIndex; //lấy ra chỉ số của row đang đc chọn
            //for (int i = 3; i < 34; i++)
            //{
            //    //bool cell = Convert.ToBoolean(dataGridView1.Rows[index].Cells[i].Value);
            //    if (dataGridView1.Rows[index].Cells[i].Value.ToString().ToUpper() == "TRUE")
            //    {
            //        dem++;
            //    }
            //}
            string s = "";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int dem = 0;
                for (var j = 1; j <= 31; j++)
                {
                    var n = "N" + j;
                    //bool cell = Convert.ToBoolean(dataGridView1.Rows[index].Cells[i].Value);
                    if (dataGridView1.Rows[i].Cells[n].Value.ToString().ToUpper() == "TRUE")
                    {
                        dem++;
                    }
                }
                s += dem.ToString() + " - ";
            }
            MessageBox.Show(s);

        }

        private void cbbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbThang.DataSource = cc.LoadThangTheoNam(cbbNam.Text);
            cbbThang.DisplayMember = "THANG";
            cbbThang.ValueMember = "THANG";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            cc.UpDate(dt);
            MessageBox.Show("Đã lưu", "Thông báo");
        }

        private void btnTinhCong_Click(object sender, EventArgs e)
        {
            TinhSoNgayCong();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                string nam = cbbNam.SelectedValue.ToString();
                string thang = cbbThang.SelectedValue.ToString();
                LoadDS(thang, nam);
                LoadNgay(thang, nam);
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
            cc.ThemChamCong(thang, nam);
            int t = Convert.ToInt32(thang);
            int n = Convert.ToInt32(nam);
            LoadNgay(thang, nam);
            LoadDS(thang, nam);
            LoadCombobox();
        }
    }
}
