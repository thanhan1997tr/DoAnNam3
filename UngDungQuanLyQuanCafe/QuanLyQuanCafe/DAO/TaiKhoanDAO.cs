using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private TaiKhoanDAO() { }

        public TaiKhoanDTO LoadThongTinTaiKhoan(String tk, TaiKhoanDTO taikhoan)
        {
            string query = "SP_NHANVIEN_LOADTAIKHOAN @MANV";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tk });
            foreach (DataRow items in data.Rows)
            {
                tk = items["MANV"].ToString();
                string ten = items["TENNV"].ToString();
                string mk = items["MATKHAU"].ToString();
                string q = items["QUYEN"].ToString();
                taikhoan = new TaiKhoanDTO(tk, ten, mk, q);
            }

            return taikhoan;
        }
    }
}