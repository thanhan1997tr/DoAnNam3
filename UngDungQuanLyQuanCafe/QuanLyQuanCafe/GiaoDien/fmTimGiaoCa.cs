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
    public partial class fmTimGiaoCa : Form
    {
        public fmTimGiaoCa()
        {
            InitializeComponent();
            LoadComboCa();
            fmManager.getCa.tenca = cbbCaLam.Text.ToString();
        }

        public void Tim()
        {
            string Ngay = dTimeNgay.Value.ToString("MM/dd/yyyy");
            string MaCa = cbbCaLam.SelectedValue.ToString();
            fmGiaoCa fm = new fmGiaoCa(Ngay, MaCa);
            fm.ShowDialog();
        }

        public void LoadComboCa()
        {
            cbbCaLam.DisplayMember = "TENCA";
            cbbCaLam.ValueMember = "MACA";
            cbbCaLam.DataSource = NhanVienDAO.Instance.LoadComboCa();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            Tim();
        }
    }
}
