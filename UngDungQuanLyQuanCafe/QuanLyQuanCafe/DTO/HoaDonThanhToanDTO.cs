using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonThanhToanDTO
    {
        private string sTenNv;
        private string sThoiGianVao;
        private string sTenSp;
        private int iSoLuong;
        private float fDonGia;
        private float fThanhTien;
        private float fgiamgia;
        private float fvat;

        public HoaDonThanhToanDTO(string tennv, string thoigianvao, string tensp, int soluong, float dongia, float thanhtien, float giamgia, float vat)
        {
            this.sTenNv = tennv;
            this.sThoiGianVao = thoigianvao;
            this.sTenSp = tensp;
            this.iSoLuong = soluong;
            this.fDonGia = dongia;
            this.fThanhTien = thanhtien;
            this.fgiamgia = giamgia;
            this.fvat = vat;
        }

        public string STenNv
        {
            get
            {
                return sTenNv;
            }

            set
            {
                sTenNv = value;
            }
        }

        public string SThoiGianVao
        {
            get
            {
                return sThoiGianVao;
            }

            set
            {
                sThoiGianVao = value;
            }
        }

        public string STenSp
        {
            get
            {
                return sTenSp;
            }

            set
            {
                sTenSp = value;
            }
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

        public float FDonGia
        {
            get
            {
                return fDonGia;
            }

            set
            {
                fDonGia = value;
            }
        }

        public float FThanhTien
        {
            get
            {
                return fThanhTien;
            }

            set
            {
                fThanhTien = value;
            }
        }

        public float Fgiamgia
        {
            get
            {
                return fgiamgia;
            }

            set
            {
                fgiamgia = value;
            }
        }

        public float Fvat
        {
            get
            {
                return fvat;
            }

            set
            {
                fvat = value;
            }
        }
    }
}
