using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        private string sTaiKhoan;
        private string sTenNhanVien;
        private string sMatKhau;
        private string sQuyen;

        public TaiKhoanDTO(string tk, string tnv, string mk, string q)
        {
            this.sTaiKhoan = tk;
            this.sTenNhanVien = tnv;
            this.sMatKhau = mk;
            this.sQuyen = q;
        }

        public string STaiKhoan
        {
            get
            {
                return sTaiKhoan;
            }

            set
            {
                sTaiKhoan = value;
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

        public string SMatKhau
        {
            get
            {
                return sMatKhau;
            }

            set
            {
                sMatKhau = value;
            }
        }

        public string SQuyen
        {
            get
            {
                return sQuyen;
            }

            set
            {
                sQuyen = value;
            }
        }
    }
}
