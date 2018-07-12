using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChamCongDAO
    {
        private static ChamCongDAO instance;
        public static ChamCongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChamCongDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private ChamCongDAO() { }
        public DataTable LoadDs(string thang, string nam)
        {
            //SqlConnection con = new SqlConnection(conString);
            //con.Open();
            string sql = "SP_CHAMCONG @thang , @nam";
            return DataProvider.Instance.ExecuteQuery(sql, new object[] { thang, nam });
        }
        public void UpdateCong(string n, string ngay, string manv, string macong)
        {
            string sql = "UPDATE CHAMCONGCHITIET SET " + n + " = " + "'" + ngay + "' WHERE MANV = '" + manv + "' AND MACHAMCONG = '" + macong + "'";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }

        public void UpdateTongCong(int tong, string manv, string macong)
        {
            string sql = "UPDATE CHAMCONGCHITIET SET TONGCONG = '" + tong+ "' WHERE MANV = '" + manv + "' AND MACHAMCONG = '" + macong + "'";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
        public DataTable LoadNam()
        {
            //return DataProvider.Instance.ExecuteQuery("SELECT NAM FROM CHAMCONG GROUP BY NAM ORDER BY NAM DESC");
            string sql = "SELECT NAM FROM CHAMCONG GROUP BY NAM ORDER BY NAM DESC";
            return DataProvider.Instance.ExecuteQuery(sql);
        }

        public DataTable LoadThangTheoNam(string nam)
        {
            //return DataProvider.Instance.ExecuteQuery("SELECT THANG FROM CHAMCONG WHERE NAM = '" + nam + "' GROUP BY THANG ORDER BY THANG DESC");
            
            string sql = "SELECT THANG FROM CHAMCONG WHERE NAM = '" + nam + "' GROUP BY THANG ORDER BY THANG DESC";
            return DataProvider.Instance.ExecuteQuery(sql);
        }

        public void ThemChamCong(string thang, string nam)
        {
            string sql = "SP_CHAMCONG_THEM @thang , @nam";
            DataProvider.Instance.ExecuteQuery(sql, new object[] { thang, nam });

            List<NhanVienDTO> listnv = NhanVienDAO.Instance.Load();
            foreach (NhanVienDTO nv in listnv)
            {
                //DataProvider.Instance.ExecuteNonQuery("SP_CHAMCONG_THEM @MANV , @THANG , @NAM", new object[] { nv.SManv, thang, nam });
                string s = "SP_CHAMCONGCHITIET_THEM @manv";
                DataProvider.Instance.ExecuteQuery(s, new object[] { nv.SManv });
            }
        }

        public int KiemTraTrungThang(string thang, string nam)
        {
            string sql = "SP_CHAMCONG_CHECKTHANGNAM @thang , @nam";
            return (int)DataProvider.Instance.ExecuteScalar(sql, new object[] { thang, nam });
            
        }
    }
}
