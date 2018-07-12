using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HoaDonTheoNgayDAO
    {
        private static HoaDonTheoNgayDAO instance;

        public static HoaDonTheoNgayDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDonTheoNgayDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private HoaDonTheoNgayDAO() { }
        public List<HoaDonTheoNgayDTO> LoadHoaDon()
        {
            string query = "SP_HOADON_DS";
            List<HoaDonTheoNgayDTO> hdlist = new List<HoaDonTheoNgayDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow items in data.Rows)
            {
                string maHD = items["MAHOADON"].ToString();
                string ngaynhap = items["NGAYNHAP"].ToString();
                string ngayxuat = items["NGAYXUAT"].ToString();
                string maNVnhap = items["THUNGAN"].ToString();
                string maban = items["MABAN"].ToString();
                float giamgia = (float)Convert.ToDouble(items["GIAMGIA"]) * 100;
                float vat = (float)Convert.ToDouble(items["VAT"]) * 100;
                float thanhtoan = (float)Convert.ToDouble(items["THANHTOAN"]);
                string ghichu = items["GHICHU"].ToString();
                string maca = items["MACA"].ToString();
                HoaDonTheoNgayDTO hdnew = new HoaDonTheoNgayDTO(maHD, ngaynhap, ngayxuat, maNVnhap, maban, giamgia, vat, thanhtoan, ghichu, maca);
                hdlist.Add(hdnew);

            }
            return hdlist;
        }
        public List<HoaDonTheoNgayDTO> LoadHoaDonTheoNgay(string ngayBD, string ngayKT)
        {
            string query = "SP_HOADON_TIM @TUNGAY , @DENNGAY";
            List<HoaDonTheoNgayDTO> hdlist = new List<HoaDonTheoNgayDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[]{ngayBD , ngayKT});
            foreach (DataRow items in data.Rows)
            {
                string maHD = items["MAHOADON"].ToString();
                string ngaynhap = items["NGAYNHAP"].ToString();
                string ngayxuat = items["NGAYXUAT"].ToString();
                string maNVnhap = items["THUNGAN"].ToString();
                string maban = items["MABAN"].ToString();
                float giamgia = (float)Convert.ToDouble(items["GIAMGIA"])*100;
                float vat = (float)Convert.ToDouble(items["VAT"])*100;
                float thanhtoan = (float)Convert.ToDouble(items["THANHTOAN"]);
                string ghichu = items["GHICHU"].ToString();
                string maca = items["MACA"].ToString();
                HoaDonTheoNgayDTO hdnew = new HoaDonTheoNgayDTO(maHD, ngaynhap, ngayxuat, maNVnhap, maban, giamgia, vat, thanhtoan, ghichu, maca);
                hdlist.Add(hdnew);

            }
            return hdlist;
        }

        public List<HoaDonTheoNgayDTO> LoadHoaDonGiaoCa(string MaCa)
        {
            List<HoaDonTheoNgayDTO> hdlist = new List<HoaDonTheoNgayDTO>();
            string query = "SP_HOADON_GIAOCA @MACA";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { MaCa });
            foreach (DataRow items in data.Rows)
            {
                string maHD = items["MAHOADON"].ToString();
                string ngaynhap = items["NGAYNHAP"].ToString();
                string ngayxuat = items["NGAYXUAT"].ToString();
                string maNVnhap = items["THUNGAN"].ToString();
                string maban = items["MABAN"].ToString();
                float giamgia = (float)Convert.ToDouble(items["GIAMGIA"]) * 100;
                float vat = (float)Convert.ToDouble(items["VAT"]) * 100;
                float thanhtoan = (float)Convert.ToDouble(items["THANHTOAN"]);
                string ghichu = items["GHICHU"].ToString();
                string maca = items["MACA"].ToString();
                HoaDonTheoNgayDTO hdnew = new HoaDonTheoNgayDTO(maHD, ngaynhap, ngayxuat, maNVnhap, maban, giamgia, vat, thanhtoan, ghichu, maca);
                hdlist.Add(hdnew);
            }
            return hdlist;
        }

        //Trả về mã hóa đơn nếu hóa đơn đã có mà chưa thanh toán
        //Trả về NO nếu chưa có mã hóa đơn
        public string getIDTheoHoaDon(string MaBan)
        {
            string sql = "SP_HOADON_TONTAIHD @MABAN";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql,new object[] { MaBan });

            if (data.Rows.Count > 0)
            {
                string MaHD = "";
                foreach (DataRow items in data.Rows)
                {
                    MaHD = items["MAHOADON"].ToString();
                }
                return MaHD;
            }

            return "NO";
        }

        //Thêm hóa đơn
        public void ThemHoaDon(HoaDonTheoNgayDTO hd)
        {
            string sql = "SP_THEMHOADON @MAHOADON , @MANV , @MABAN , @GIAMGIA , @VAT , @MACA";
            DataProvider.Instance.ExecuteNonQuery(sql, new object[] { hd.SMaHD, hd.SMaNVNhap, hd.SMaBan, hd.FGiamGia, hd.FVAT , hd.SMaCa});
        }
    }
}
