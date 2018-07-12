using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CaDAO
    {
        private static CaDAO instance;
        public static CaDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CaDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private CaDAO() { }

        //public bool KiemTraTrungCa(string MaCa)
        //{
        //    string sql = "SELECT * FROM CHITIETCA WHERE MACA = '" + MaCa + "' AND CAST(NGAYLAMVIEC AS DATE) = CAST(GETDATE() AS DATE)";
        //    DataTable rs = DataProvider.Instance.ExecuteQuery(sql);
        //    return rs.Rows.Count > 0;
        //}
        public string TrangThai(string MaCa)
        {
            string tt = "";
            string sql = "SELECT * FROM CHITIETCA WHERE MACA = '" + MaCa + "' AND CAST(NGAYLAMVIEC AS DATE) = CAST(GETDATE() AS DATE)";
            DataTable rs = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow items in rs.Rows)
            {
                tt = items["TRANGTHAI"].ToString();
            }
            return tt;
        }

        public void ThemCa(string MaCa)
        {
            string sql = "SP_THEMCA @MaCa";
            DataProvider.Instance.ExecuteQuery(sql, new object[] { MaCa });
        }

        public void CapNhatTrangThai(string MaCa)
        {
            string sql = "UPDATE CHITIETCA SET TRANGTHAI = '1' WHERE CAST(NGAYLAMVIEC AS DATE) = CAST(GETDATE() AS DATE) AND MACA = '" + MaCa + "'";
            DataProvider.Instance.ExecuteQuery(sql, new object[] { MaCa });
        }
        public int DemTrangThai0()
        {
            string sql = "SELECT COUNT(TRANGTHAI) FROM CHITIETCA WHERE CAST(NGAYLAMVIEC AS DATE) = CAST(GETDATE() AS DATE) AND TRANGTHAI = '0'";
            return (int)DataProvider.Instance.ExecuteScalar(sql);
        }
        public int DemTrangThai1()
        {
            string sql = "SELECT COUNT(TRANGTHAI) FROM CHITIETCA WHERE CAST(NGAYLAMVIEC AS DATE) = CAST(GETDATE() AS DATE) AND TRANGTHAI = '1'";
            return (int)DataProvider.Instance.ExecuteScalar(sql);
        }
        public bool ktraCaToi()
        {
            string sql = "SELECT * FROM CHITIETCA WHERE MACA = 'T' AND CAST(NGAYLAMVIEC AS DATE) = CAST(GETDATE() AS DATE) AND TRANGTHAI = '1'";
            DataTable rs = DataProvider.Instance.ExecuteQuery(sql);
            return rs.Rows.Count > 0;
        }
    }
}
