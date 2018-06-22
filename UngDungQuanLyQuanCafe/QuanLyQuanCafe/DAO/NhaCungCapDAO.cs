using System;
using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO
{
    public class NhaCungCapDAO
    {
        private static NhaCungCapDAO instance;
        public static NhaCungCapDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhaCungCapDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private NhaCungCapDAO() { }

        public DataTable LoadComBoBoxNCC()
        {
            string sql = "SP_NHACUNGCAP_DS";
            return DataProvider.Instance.ExecuteQuery(sql);
        }

        public List<NhaCungCapDTO> loadNCC()
        {
            List<NhaCungCapDTO> listNCC = new List<NhaCungCapDTO>();
            string query = "SP_NHACUNGCAP_DS";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                string maNCC = item["MANCC"].ToString();
                string tenNCC = item["TENNCC"].ToString();
                string diaChiNCC = item["DIACHINCC"].ToString();
                string dienthoaiNCC = item["DIENTHOAINCC"].ToString();
                NhaCungCapDTO nccnew = new NhaCungCapDTO(maNCC, tenNCC, diaChiNCC, dienthoaiNCC);
                listNCC.Add(nccnew);
            }
            return listNCC;
        }

        public int themNCC(NhaCungCapDTO ncc)
        {
            string sql = "SP_NHACUNGCAP_THEM @MANCC , @TENNCC , @DIACHINCC , @DIENTHOAINCC";
            return DataProvider.Instance.ExecuteNonQuery(sql, new object[] { ncc.SMaNCC, ncc.STenNCC, ncc.SDiaChiNCC, ncc.SDienThoaiNCC });
        }

        public int suaNCC(NhaCungCapDTO ncc)
        {
            string sql = "SP_NHACUNGCAP_SUA @MANCC , @TENNCC , @DIACHINCC , @DIENTHOAINCC";
            return DataProvider.Instance.ExecuteNonQuery(sql, new object[] { ncc.SMaNCC, ncc.STenNCC, ncc.SDiaChiNCC, ncc.SDienThoaiNCC });
        }
        public int xoaNCC(string mancc)
        {
            string sql = "SP_NHACUNGCAP_XOA @MANCC";
            return DataProvider.Instance.ExecuteNonQuery(sql, new object[] { mancc });
        }
    }
}
