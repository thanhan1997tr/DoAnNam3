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
    public partial class rpHoaDon : Form
    {
        public rpHoaDon(string MaHoaDon)
        {
            InitializeComponent();
            // TODO: This line of code loads data into the 'DataSet1.SP_HOADONCHITIET_DS' table. You can move, or remove it, as needed.
            this.SP_HOADONCHITIET_DSTableAdapter.Fill(this.DataSet1.SP_HOADONCHITIET_DS, MaHoaDon);

            this.reportViewer1.RefreshReport();
        }

        private void rpHoaDon_Load(object sender, EventArgs e)
        {
            
        }
    }
}
