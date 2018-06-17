using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class DangNhapBUS
    {
        private static DangNhapBUS instance;
        public static DangNhapBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new DangNhapBUS();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private DangNhapBUS() { }

        public Boolean DangNhap(string TaiKhoan, string MatKhau)
        {
            return DangNhapDAO.Instance.DangNhap(TaiKhoan, MatKhau);
        }
    }
}
