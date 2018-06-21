using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HoaDonThanhToanDAO
    {
        private static HoaDonThanhToanDAO instance;

        public static HoaDonThanhToanDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDonThanhToanDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private HoaDonThanhToanDAO() { }

        public List<HoaDonThanhToanDTO> LoadHoaDonThanhToan(string MaBan)
        {
            string query = "SP_HOADONTHANHTOAN_LOAD @MABAN";
            List<HoaDonThanhToanDTO> hdlist = new List<HoaDonThanhToanDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[]{MaBan});
            foreach (DataRow items in data.Rows)
            {
                string tensp = items["TENSP"].ToString();
                int soluong = (int)items["SOLUONG"];
                float dongia = (float)Convert.ToDouble(items["DONGIABAN"]);     
                float thanhtien = (float)Convert.ToDouble(items["THANHTIEN"]);
                string ngaynhap = items["NGAYNHAP"].ToString();
                string tennv = items["TENNV"].ToString();
                float giamgia = (float)Convert.ToDouble(items["GIAMGIA"]) * 100;
                float vat = (float)Convert.ToDouble(items["VAT"]) * 100;
                HoaDonThanhToanDTO hdnew = new HoaDonThanhToanDTO(tennv, ngaynhap, tensp, soluong, dongia, thanhtien, giamgia, vat);
                hdlist.Add(hdnew);
            }
            return hdlist;
        }

        public void ThanhToan(string MaHD, float thanhtoan)
        {
            string sql = "SP_THANHTOANHOADON @MAHOADON , @THANHTOAN";
            DataProvider.Instance.ExecuteNonQuery(sql, new object[] { MaHD, thanhtoan });
        }
    }
}
