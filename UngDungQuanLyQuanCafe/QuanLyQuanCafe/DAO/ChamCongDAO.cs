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

        //Load danh sách theo tháng và năm truyền vào
        public DataTable LoadDs(string thang, string nam)
        {
            string sql = "SP_CHAMCONG @thang , @nam";
            return DataProvider.Instance.ExecuteQuery(sql, new object[] { thang, nam });
        }

        //Update bảng chi tiết công
        public void UpdateCong(string n, string ngay, string manv, string macong)
        {
            string sql = "UPDATE CHAMCONGCHITIET SET " + n + " = " + "'" + ngay + "' WHERE MANV = '" + manv + "' AND MACHAMCONG = '" + macong + "'";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }


        //Update tổng công
        public void UpdateTongCong(int tong, string manv, string macong)
        {
            string sql = "UPDATE CHAMCONGCHITIET SET TONGCONG = '" + tong+ "' WHERE MANV = '" + manv + "' AND MACHAMCONG = '" + macong + "'";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }

        //Load combobox các năm mà quán đã làm được 
        public DataTable LoadNam()
        {
            string sql = "SELECT NAM FROM CHAMCONG GROUP BY NAM ORDER BY NAM DESC";
            return DataProvider.Instance.ExecuteQuery(sql);
        }

        //Load tháng theo từng năm (năm 2018 có 7 tháng làm việc thì load đúng 7 tháng)
        public DataTable LoadThangTheoNam(string nam)
        {
            string sql = "SELECT THANG FROM CHAMCONG WHERE NAM = '" + nam + "' GROUP BY THANG ORDER BY THANG DESC";
            return DataProvider.Instance.ExecuteQuery(sql);
        }

        //Nếu như qua tháng mới thì thêm bảng chấm công cho tháng mới
        //Nếu như có nhân viên mới vào, được thêm từ form Nhân Viên
        //Thì nhân viên đó được tự động thêm vào bảng chấm công dựa vào trigger TG_CHAMCONGCHITIET_NHANVIEN được xử lý bên csdl
        public void ThemChamCong(string thang, string nam)
        {
            //Thêm năm và tháng chấm công mới
            //Mã chấm công tăng tự động theo IDENTITY (Từ 1->.....)
            string sql = "SP_CHAMCONG_THEM @thang , @nam";
            DataProvider.Instance.ExecuteQuery(sql, new object[] { thang, nam });

            //Load danh sách các nhân viên hiện có
            //Thêm từng nhân viên vào bảng chấm công chi tiết tương ứng với mã chấm công vừa được tạo ở trên
            //Xứ lấy mã chấm công mới thêm trong proc
            List<NhanVienDTO> listnv = NhanVienDAO.Instance.Load();
            foreach (NhanVienDTO nv in listnv)
            {
                string s = "SP_CHAMCONGCHITIET_THEM @manv";
                DataProvider.Instance.ExecuteQuery(s, new object[] { nv.SManv });
            }
        }

        //Kiểm tra trùng tháng, năm khi nhấn vào nút thêm
        public int KiemTraTrungThang(string thang, string nam)
        {
            string sql = "SP_CHAMCONG_CHECKTHANGNAM @thang , @nam";
            return (int)DataProvider.Instance.ExecuteScalar(sql, new object[] { thang, nam });
        }
    }
}
