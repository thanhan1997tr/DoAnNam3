using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DoanhThuDAO
    {
        private static DoanhThuDAO instance;
        public static DoanhThuDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DoanhThuDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private DoanhThuDAO() { }
        public List<DoanhThuDTO> loadDoanhThu()
        {
            List<DoanhThuDTO> listDoanhThu = new List<DoanhThuDTO>();
            string query = "SP_DOANHTHU_DS";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow items in data.Rows){
                string maSP = items["MASP"].ToString();
                string tenSP = items["TENSP"].ToString();
                int soluong = Convert.ToInt32(items["SOLUONG"]);
                float dongia = (float)Convert.ToDouble(items["DONGIABAN"]);
                float thanhtien = (float)Convert.ToDouble(items["THANHTIEN"]);
                DoanhThuDTO dtnew = new DoanhThuDTO(maSP, tenSP, soluong, dongia, thanhtien);
                listDoanhThu.Add(dtnew);
            }
            return listDoanhThu;
        }

        public List<DoanhThuDTO> loadDoanhThuTheoNgay(string ngayBD, string ngayKT)
        {
            List<DoanhThuDTO> listDoanhThu = new List<DoanhThuDTO>();
            string query = "SP_DOANHTHU_TIM @TUNGAY , @DENNGAY";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { ngayBD , ngayKT });
            foreach (DataRow items in data.Rows)
            {
                string maSP = items["MASP"].ToString();
                string tenSP = items["TENSP"].ToString();
                int soluong = Convert.ToInt32(items["SOLUONG"]);
                float dongia = (float)Convert.ToDouble(items["DONGIABAN"]);
                float thanhtien = (float)Convert.ToDouble(items["THANHTIEN"]);
                DoanhThuDTO dtnew = new DoanhThuDTO(maSP, tenSP, soluong, dongia, thanhtien);
                listDoanhThu.Add(dtnew);
            }
            return listDoanhThu;
        }
    }
}
