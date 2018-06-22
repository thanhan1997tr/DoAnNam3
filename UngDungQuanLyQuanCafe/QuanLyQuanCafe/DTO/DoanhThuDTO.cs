using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DoanhThuDTO : SanPhamDTO
    {
        private int iSoLuong;

        public int ISoLuong
        {
            get { return iSoLuong; }
            set { iSoLuong = value; }
        }
        private float fThanhTien;

        public float FThanhTien
        {
            get { return fThanhTien; }
            set { fThanhTien = value; }
        }

        public DoanhThuDTO(string maSP, string TenSP, int soluong, float dongia, float thanhtien)
            : base(maSP, TenSP, dongia)
        {
            this.iSoLuong = soluong;
            this.fThanhTien = thanhtien;
        }
    }
}
