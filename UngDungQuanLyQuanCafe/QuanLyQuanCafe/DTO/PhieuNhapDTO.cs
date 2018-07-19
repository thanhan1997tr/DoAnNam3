using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhapDTO
    {
        private string sMaPhieuNhap;
        private string sNgayNhap;
        private string sMaNv;

        public PhieuNhapDTO(string ma, string ngay, string manv)
        {
            this.sMaPhieuNhap = ma;
            this.sNgayNhap = ngay;
            this.sMaNv = manv;
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

        public string SNgayNhap
        {
            get
            {
                return sNgayNhap;
            }

            set
            {
                sNgayNhap = value;
            }
        }

        public string SMaNv
        {
            get
            {
                return sMaNv;
            }

            set
            {
                sMaNv = value;
            }
        }
    }
}
