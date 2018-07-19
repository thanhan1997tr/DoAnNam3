using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhapChiTietDTO
    {
        private string sMaPhieuNhap;
        private string sMaHang;
        private double fGia;
        private float fSoLuong;
        private double fThanhTien;
        
        public PhieuNhapChiTietDTO(string manhap, string mahang, double gia, float sl, double thanhtien)
        {
            this.sMaPhieuNhap = manhap;
            this.sMaHang = mahang;
            this.fGia = gia;
            this.fSoLuong = sl;
            this.fThanhTien = thanhtien;
        }

        public string SMaPhieuNhap
        {
            get
            {
                return sMaPhieuNhap;
            }

            set
            {
                sMaPhieuNhap = value;
            }
        }

        public string SMaHang
        {
            get
            {
                return sMaHang;
            }

            set
            {
                sMaHang = value;
            }
        }

        public double FGia
        {
            get
            {
                return fGia;
            }

            set
            {
                fGia = value;
            }
        }

        public float FSoLuong
        {
            get
            {
                return fSoLuong;
            }

            set
            {
                fSoLuong = value;
            }
        }

        public double FThanhTien
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
    }
}
