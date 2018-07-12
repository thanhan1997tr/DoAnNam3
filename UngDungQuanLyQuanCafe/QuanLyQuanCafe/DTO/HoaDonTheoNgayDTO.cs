using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonTheoNgayDTO
    {
        private string sMaHD;

        public string SMaHD
        {
            get { return sMaHD; }
            set { sMaHD = value; }
        }
        private string sNgayNhap;

        public string SNgayNhap
        {
            get { return sNgayNhap; }
            set { sNgayNhap = value; }
        }
        private string sNgayXuat;

        public string SNgayXuat
        {
            get { return sNgayXuat; }
            set { sNgayXuat = value; }
        }
        private string sMaNVNhap;

        public string SMaNVNhap
        {
            get { return sMaNVNhap; }
            set { sMaNVNhap = value; }
        }
        private string sMaBan;

        public string SMaBan
        {
            get { return sMaBan; }
            set { sMaBan = value; }
        }
        private float fGiamGia;

        public float FGiamGia
        {
            get { return fGiamGia; }
            set { fGiamGia = value; }
        }
        private float fVAT;

        public float FVAT
        {
            get { return fVAT; }
            set { fVAT = value; }
        }
        private float fThanhToan;

        public float FThanhToan
        {
            get { return fThanhToan; }
            set { fThanhToan = value; }
        }
        private string sGhiChu;

        public string SGhiChu
        {
            get { return sGhiChu; }
            set { sGhiChu = value; }
        }

        public string SMaCa
        {
            get
            {
                return sMaCa;
            }

            set
            {
                sMaCa = value;
            }
        }

        private string sMaCa;

        public HoaDonTheoNgayDTO(string maHD, string ngaynhap, string ngayxuat, string manv, string maban, float giamgia, float vat, float thanhtoan, string ghichu, string maca)
        {
            this.sMaHD = maHD;
            this.sNgayNhap = ngaynhap;
            this.sNgayXuat = ngayxuat;
            this.sMaNVNhap = manv;
            this.sMaBan = maban;
            this.fGiamGia = giamgia;
            this.fVAT = vat;
            this.fThanhToan = thanhtoan;
            this.sGhiChu = ghichu;
            this.SMaCa = maca;
        }
    }
}
