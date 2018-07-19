using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MatHangDAO
    {
        private static MatHangDAO instance;
        public static MatHangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new MatHangDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private MatHangDAO() { }

        public List<MatHangDTO> LoadDsMatHang()
        {
            List<MatHangDTO> dsmh = new List<MatHangDTO>();
            string sql = "SP_MATHANG_DS";
            DataTable rs = DataProvider.Instance.ExecuteQuery(sql);
            foreach(DataRow items in rs.Rows)
            {
                string mahang = items["MAHANG"].ToString();
                string tenhang = items["TENHANG"].ToString();
                string ncc = items["TENNCC"].ToString();
                MatHangDTO mh = new MatHangDTO(mahang, tenhang, ncc);
                dsmh.Add(mh);
            }
            return dsmh;
        }

        public bool ThemMatHang(MatHangDTO mh)
        {
            bool ktra = true;

            try
            {
                string sql = "SP_MATHANG_THEM @MAHANG , @TENHANG , @MANCC";
                DataProvider.Instance.ExecuteNonQuery(sql, new object[] { mh.SMaHang, mh.STenHang, mh.SMaNcc});
                ktra = true;
            }
            catch(Exception)
            {
                ktra = false;
            }
            return ktra;
        }

        public int SuaMatHang(MatHangDTO mh)
        {
            string sql = "SP_MATHANG_SUA @MAHANG , @TENHANG , @MANCC";
            return DataProvider.Instance.ExecuteNonQuery(sql, new object[] { mh.SMaHang, mh.STenHang, mh.SMaNcc });
        }

        public int XoaMatHang(string mahang)
        {
            string sql = "SP_MATHANG_XOA @MAHANG";
            return DataProvider.Instance.ExecuteNonQuery(sql, new object[] { mahang });
        }
    }
}
