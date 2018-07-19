using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataProvider
    {
        public string conString = "Data Source=DESKTOP-6VGHVNB;Initial Catalog=QuanLyQuanCf;Persist Security Info=True;User ID=sa;Password=12345";
        //public string conString = "Data Source=DESKTOP-JH25FD7;Initial Catalog=QuanLyQuanCf;Integrated Security=True"; //Thương
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private DataProvider() { }

        //trả về DataTable, truyền vào câu query và parameter (= null vì câu query có thể không có parameter)
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection con = new SqlConnection(conString)) //tự giải phóng sau khi thực hiện xong khối lệnh
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' '); //Cắt theo khoảng trắng
                    int i = 0;
                    foreach (string item in listPara) 
                    {
                        if (item.Contains('@')) //Nếu item có '@' thì item này có chứa parameter
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);  //cmd.Parameters.AddWithValue("@MaNv", NV0002')
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                con.Close();
            }

            return data;
        }


        //trà về số lượng dòng đã insert, update, delete
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteNonQuery();
                con.Close();
            }
            return data;
        }

        //Ví dụ SELECT Count(*) FROM NHANVIEN
        //Trả về một giá trị đơn
        //Cần chuyển đổi kiểu dữ liệu sang int vì nó trả về kiểu object
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteScalar();
                con.Close();
            }
            return data;
        }
    }
}
