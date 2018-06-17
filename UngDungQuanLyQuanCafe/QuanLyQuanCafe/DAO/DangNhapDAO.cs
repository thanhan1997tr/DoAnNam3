using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DangNhapDAO
    {
        private static DangNhapDAO instance;
        public static DangNhapDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DangNhapDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private DangNhapDAO() { }

        public bool DangNhap(string TaiKhoan, string MatKhau)
        {
            string query = "SP_DANGNHAP @taikhoan , @matkhau";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { TaiKhoan, MatKhau });
            return result.Rows.Count > 0;
        }
    }
}
