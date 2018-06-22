using DTO;
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
        public List<SanPhamDTO> loadSanPham()
        {
            List<SanPhamDTO> listSP = new List<SanPhamDTO>();
            string query = "SP_SANPHAM_LOAD";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                string maSP = item["MASP"].ToString();
                string tenSP = item["TENSP"].ToString();
                float dongiaban = (float)Convert.ToDouble(item["DONGIABAN"]);
                SanPhamDTO spnew = new SanPhamDTO(maSP, tenSP, dongiaban);
                listSP.Add(spnew);
            }
            return listSP;
        }

        public int themSP(SanPhamDTO sp)
        {
            string sql = "SP_SANPHAM_THEM @MASP , @TENSP , @DONGIABAN";
            return DataProvider.Instance.ExecuteNonQuery(sql, new object[] { sp.SMaSp, sp.STenSp, sp.FDonGiaBan });
        }

        public int suaSP(SanPhamDTO sp)
        {
            string sql = "SP_SANPHAM_SUA @MASP , @TENSP , @DONGIABAN";
            return DataProvider.Instance.ExecuteNonQuery(sql, new object[] { sp.SMaSp, sp.STenSp, sp.FDonGiaBan });
        }

        public int xoaSP(string masp)
        {
            string sql = "DELETE FROM SANPHAM WHERE MASP = '" + masp + "'";
            return DataProvider.Instance.ExecuteNonQuery(sql);
        }
    }

}
