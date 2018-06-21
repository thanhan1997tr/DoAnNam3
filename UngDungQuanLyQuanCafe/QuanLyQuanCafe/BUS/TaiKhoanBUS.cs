using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TaiKhoanBUS
    {
        private static TaiKhoanBUS instance;

        public static TaiKhoanBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanBUS();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private TaiKhoanBUS() { }

        public TaiKhoanDTO LoadThongTinTaiKhoan(String tk, TaiKhoanDTO taikhoan)
        {
            return TaiKhoanDAO.Instance.LoadThongTinTaiKhoan(tk, taikhoan);
        }
    }
}
