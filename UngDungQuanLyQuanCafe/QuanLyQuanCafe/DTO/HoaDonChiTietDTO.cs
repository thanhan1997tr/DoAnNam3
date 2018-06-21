using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonChiTietDTO : HoaDonTheoNgayDTO
    {
        private string sMaSanPham;
        private string sTenSanPham;
        private int iSoLuong;
        private string sTenNhanVien;
        private string sDonGia;

        public HoaDonChiTietDTO(String mahd, String ngaynhap, String ngayxuat, String manv, String maban, float giamgia, float vat, float thanhtoan, String ghichu, String masp, String tensp, String tennv, int soluong, String dongia)
            : base(mahd, ngaynhap, ngayxuat, manv, maban, giamgia, vat, thanhtoan, ghichu)
        {
            this.SMaSanPham = masp;
            this.STenSanPham = tensp;
            this.sTenNhanVien = tennv;
            this.iSoLuong = soluong;
            this.sDonGia = dongia;
        }

        public int ISoLuong
        {
            get
            {
                return iSoLuong;
            }

            set
            {
                iSoLuong = value;
            }
        }

        public string STenNhanVien
        {
            get
            {
                return sTenNhanVien;
            }

            set
            {
                sTenNhanVien = value;
            }
        }

        public string SDonGia
        {
            get
            {
                return sDonGia;
            }

            set
            {
                sDonGia = value;
            }
        }

        public string SMaSanPham
        {
            get
            {
                return sMaSanPham;
            }

            set
            {
                sMaSanPham = value;
            }
        }

        public string STenSanPham
        {
            get
            {
                return sTenSanPham;
            }

            set
            {
                sTenSanPham = value;
            }
        }
    }
}
