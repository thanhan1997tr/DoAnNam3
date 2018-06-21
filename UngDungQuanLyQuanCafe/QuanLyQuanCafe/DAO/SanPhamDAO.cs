using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SanPhamDAO
    {
        private static SanPhamDAO instance;
        public static SanPhamDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SanPhamDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private SanPhamDAO() { }
        public DataTable LoadComBoBoxSanPham()
        {
            string sql = "SP_SANPHAM_LOAD";
            return DataProvider.Instance.ExecuteQuery(sql);
        }
        public bool KiemTraTenSP(string TenSP)
        {
            string query = "SP_SANPHAM_KTRATENSP @TENSP";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { TenSP });
            return result.Rows.Count > 0;
        }
    }
}
