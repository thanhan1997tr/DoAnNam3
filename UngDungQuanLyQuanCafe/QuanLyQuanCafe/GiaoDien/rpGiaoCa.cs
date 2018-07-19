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
    public partial class rpGiaoCa : Form
    {
        public rpGiaoCa(DateTime ngay, string maca)
        {
            InitializeComponent();
            this.SP_HOADON_GIAOCATableAdapter.Fill(this.DataSet1.SP_HOADON_GIAOCA, maca, ngay);

            this.reportViewer1.RefreshReport();
        }

        private void rpGiaoCa_Load(object sender, EventArgs e)
        {

        }
    }
}
