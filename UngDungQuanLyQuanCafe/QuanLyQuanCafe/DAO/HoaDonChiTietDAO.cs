using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HoaDonChiTietDAO
    {
        private static HoaDonChiTietDAO instance;

        public static HoaDonChiTietDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDonChiTietDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private HoaDonChiTietDAO() { }

        public void ThemHoaDonChiTiet(string mahoadon, string masp, int soluong)
        {
            string query = "SP_THEMHOADONCHITIET @mahoadon , @masp , @soluong";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { mahoadon, masp, soluong });
        }

        public List<HoaDonChiTietDTO> LoadHDCT(string MaHD)
        {
            List<HoaDonChiTietDTO> hdlist = new List<HoaDonChiTietDTO>();
            string sql = "SP_HOADONCHITIET_DS @MAHOADON";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql, new object[] { MaHD });
            foreach (DataRow items in data.Rows)
            {
                String ngaynhap = items["NGAYNHAP"].ToString();
                String ngayxuat = items["NGAYXUAT"].ToString();
                String tennv = items["TENNV"].ToString();
                String maban = items["MABAN"].ToString();
                float giamgia = (float)Convert.ToDouble(items["GIAMGIA"].ToString());
                float vat = (float)Convert.ToDouble(items["VAT"].ToString());
                float thanhtoan = (float)Convert.ToDouble(items["THANHTOAN"].ToString());
                String masp = items["MASP"].ToString();
                String tensp = items["TENSP"].ToString();
                int soluong = Convert.ToInt32(items["SOLUONG"].ToString());
                String dongia = items["DONGIABAN"].ToString();
                String maca = items["TENCA"].ToString();
                HoaDonChiTietDTO hdct = new HoaDonChiTietDTO(MaHD, ngaynhap, ngayxuat, "", maban, giamgia, vat, thanhtoan, "", masp, tensp, tennv, soluong, dongia, maca);
                hdlist.Add(hdct);
            }
            return hdlist;
        }
    }
}
