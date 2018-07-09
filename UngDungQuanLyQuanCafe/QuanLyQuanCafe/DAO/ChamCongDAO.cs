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
        SqlDataAdapter da1;
        SqlCommandBuilder sqlComd;
        public string conString = "Data Source=DESKTOP-6VGHVNB;Initial Catalog=QuanLyQuanCf;Persist Security Info=True;User ID=sa;Password=12345";
        public DataTable LoadDs(string thang, string nam)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string sql = "EXEC SP_CHAMCONG " + thang + "," + nam;
            da1 = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da1.Fill(dt);
            sqlComd = new SqlCommandBuilder(da1);
            da1.UpdateCommand = sqlComd.GetUpdateCommand();
            return dt;
        }
        public void UpDate(DataTable dt)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                da1.Update(dt);
                con.Close();
            }
        }
        public DataTable LoadNam()
        {
            //return DataProvider.Instance.ExecuteQuery("SELECT NAM FROM CHAMCONG GROUP BY NAM ORDER BY NAM DESC");
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string sql = "SELECT NAM FROM CHAMCONG GROUP BY NAM ORDER BY NAM DESC";
            da1 = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da1.Fill(dt);
            return dt;
        }

        public DataTable LoadThangTheoNam(string nam)
        {
            //return DataProvider.Instance.ExecuteQuery("SELECT THANG FROM CHAMCONG WHERE NAM = '" + nam + "' GROUP BY THANG ORDER BY THANG DESC");
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string sql = "SELECT THANG FROM CHAMCONG WHERE NAM = '" + nam + "' GROUP BY THANG ORDER BY THANG DESC";
            da1 = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da1.Fill(dt);
            return dt;
        }

        public void ThemChamCong(string thang, string nam)
        {
            SqlConnection con = new SqlConnection(conString);
            List<NhanVienDTO> listnv = NhanVienDAO.Instance.Load();
            foreach (NhanVienDTO nv in listnv)
            {
                //DataProvider.Instance.ExecuteNonQuery("SP_CHAMCONG_THEM @MANV , @THANG , @NAM", new object[] { nv.SManv, thang, nam });
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_CHAMCONG_THEM", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MANV", nv.SManv);
                cmd.Parameters.AddWithValue("@THANG", thang);
                cmd.Parameters.AddWithValue("@NAM", nam);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public int KiemTraTrungThang(string thang, string nam)
        {
            SqlConnection con = new SqlConnection(conString);
            //return (int)DataProvider.Instance.ExecuteScalar("SP_CHAMCONG_CHECKTHANGNAM @THANG , @NAM", new object[] { thang, nam });
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_CHAMCONG_CHECKTHANGNAM", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@THANG", thang);
            cmd.Parameters.AddWithValue("@NAM", nam);
            int dem = (int)cmd.ExecuteScalar();
            return dem;
        }
    }
}
