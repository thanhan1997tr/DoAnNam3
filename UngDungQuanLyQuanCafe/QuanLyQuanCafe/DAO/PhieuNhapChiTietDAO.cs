using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhieuNhapChiTietDAO
    {
        private static PhieuNhapChiTietDAO instance;
        public static PhieuNhapChiTietDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuNhapChiTietDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private PhieuNhapChiTietDAO() { }

        public List<PhieuNhapChiTietDTO> LoadDsPhieuNhapChiTiet(string MaPhieuNhap)
        {
            List<PhieuNhapChiTietDTO> dspnct = new List<PhieuNhapChiTietDTO>();
            string sql = "SP_PHIEUNHAPCHITIET_DS @MASONHAP";
            DataTable rs = DataProvider.Instance.ExecuteQuery(sql, new object[] { MaPhieuNhap });
            foreach (DataRow items in rs.Rows)
            {
                string manhap = items["MASONHAP"].ToString();
                string mahang = items["TENHANG"].ToString();
                double gia = Convert.ToDouble(items["GIAHANGNHAP"].ToString());
                float sl = (float)Convert.ToDouble(items["SOLUONGNHAP"].ToString());
                double thanhtien = Convert.ToDouble(items["THANHTIEN"].ToString());
                PhieuNhapChiTietDTO pnct = new PhieuNhapChiTietDTO(manhap, mahang, gia, sl, thanhtien);
                dspnct.Add(pnct);
            }
            return dspnct;
        }

        public bool ThemPhieuNhapChiTiet(PhieuNhapChiTietDTO pnct)
        {
            bool ktra = true;

            try
            {
                string sql = "SP_PHIEUNHAPCHITIET_THEM @MASONHAP , @MAHANG , @GIAHANGNHAP , @SOLUONGNHAP";
                DataProvider.Instance.ExecuteNonQuery(sql, new object[] { pnct.SMaPhieuNhap, pnct.SMaHang, pnct.FGia, pnct.FSoLuong });
                ktra = true;
            }
            catch (Exception)
            {
                ktra = false;
            }
            return ktra;
        }

        public int SuaPhieuNhapChiTiet(PhieuNhapChiTietDTO pnct)
        {
            string sql = "SP_PHIEUNHAPCHITIET_SUA @MASONHAP , @MAHANG , @GIAHANGNHAP , @SOLUONGNHAP";
            return DataProvider.Instance.ExecuteNonQuery(sql, new object[] { pnct.SMaPhieuNhap, pnct.SMaHang, pnct.FGia, pnct.FSoLuong });
        }
        public int XoaPhieuNhapChiTiet(string manhap, string mahang)
        {
            string sql = "SP_PHIEUNHAPCHITIET_XOA @MASONHAP , @MAHANG";
            return DataProvider.Instance.ExecuteNonQuery(sql, new object[] { manhap, mahang });
        }

        public DataTable LoadComboboxMatHang()
        {
            string sql = "SELECT * FROM MATHANG";
            return DataProvider.Instance.ExecuteQuery(sql);
        }
    }
}
