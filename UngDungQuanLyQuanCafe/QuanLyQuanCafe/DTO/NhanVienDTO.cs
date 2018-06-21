using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        private String sManv;
        private String sTennv;
        private String sNgaysinh;
        private String sGioitinh;
        private String sDiachi;
        private String sDienthoai;
        private String sLuong;
        private String sMatkhau;
        private String sQuyen;

        public NhanVienDTO(String ma, String ten, String ngaysinh, String gioitinh, String diachi, String dienthoai, String matkhau, String quyen, String luong)
        {
            this.sManv = ma;
            this.sTennv = ten;
            this.sNgaysinh = ngaysinh;
            this.sGioitinh = gioitinh;
            this.sDiachi = diachi;
            this.sDienthoai = dienthoai;
            this.sMatkhau = matkhau;
            this.sQuyen = quyen;
            this.sLuong = luong;
        }

        public string SManv
        {
            get
            {
                return sManv;
            }

            set
            {
                sManv = value;
            }
        }

        public string STennv
        {
            get
            {
                return sTennv;
            }

            set
            {
                sTennv = value;
            }
        }

        public string SNgaysinh
        {
            get
            {
                return sNgaysinh;
            }

            set
            {
                sNgaysinh = value;
            }
        }

        public string SGioitinh
        {
            get
            {
                return sGioitinh;
            }

            set
            {
                sGioitinh = value;
            }
        }

        public string SDiachi
        {
            get
            {
                return sDiachi;
            }

            set
            {
                sDiachi = value;
            }
        }

        public string SDienthoai
        {
            get
            {
                return sDienthoai;
            }

            set
            {
                sDienthoai = value;
            }
        }

        public string SLuong
        {
            get
            {
                return sLuong;
            }

            set
            {
                sLuong = value;
            }
        }

        public string SMatkhau
        {
            get
            {
                return sMatkhau;
            }

            set
            {
                sMatkhau = value;
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
