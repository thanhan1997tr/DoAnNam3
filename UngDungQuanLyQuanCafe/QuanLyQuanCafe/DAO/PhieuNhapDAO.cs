using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhieuNhapDAO
    {
        private static PhieuNhapDAO instance;
        public static PhieuNhapDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuNhapDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private PhieuNhapDAO() { }

        public List<PhieuNhapDTO> LoadDsPhieuNhap()
        {
            List<PhieuNhapDTO> dspn = new List<PhieuNhapDTO>();
            string sql = "SP_PHIEUNHAP_DS";
            DataTable rs = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow items in rs.Rows)
            {
                string manhap = items["MASONHAP"].ToString();
                string ngaynhap = items["NGAYNHAP"].ToString();
                string nv = items["TENNV"].ToString();
                PhieuNhapDTO pn = new PhieuNhapDTO(manhap, ngaynhap, nv);
                dspn.Add(pn);
            }
            return dspn;
        }

        public List<PhieuNhapDTO> TimPhieuNhap(string manhap)
        {
            List<PhieuNhapDTO> dspn = new List<PhieuNhapDTO>();
            string sql = "SP_PHIEUNHAP_TIM @MASONHAP";
            DataTable rs = DataProvider.Instance.ExecuteQuery(sql, new object[] { manhap });
            foreach (DataRow items in rs.Rows)
            {
                string mn = items["MASONHAP"].ToString();
                string ngaynhap = items["NGAYNHAP"].ToString();
                string nv = items["TENNV"].ToString();
                PhieuNhapDTO pn = new PhieuNhapDTO(mn, ngaynhap, nv);
                dspn.Add(pn);
            }
            return dspn;
        }

        public bool ThemPhieuNhap(PhieuNhapDTO pn)
        {
            bool ktra = true;

            try
            {
                string sql = "SP_PHIEUNHAP_THEM @MASONHAP , @NGAYNHAP , @MANV";
                DataProvider.Instance.ExecuteNonQuery(sql, new object[] { pn.SMaPhieuNhap, pn.SNgayNhap, pn.SMaNv });
                ktra = true;
            }
            catch (Exception)
            {
                ktra = false;
            }
            return ktra;
        }
        public int SuaPhieuNhap(PhieuNhapDTO pn)
        {
            string sql = "SP_PHIEUNHAP_SUA @MASONHAP , @NGAYNHAP , @MANV";
            return DataProvider.Instance.ExecuteNonQuery(sql, new object[] { pn.SMaPhieuNhap, pn.SNgayNhap, pn.SMaNv });
        }

        public int XoaPhieuNhap(string manhap)
        {
            string sql = "SP_PHIEUNHAP_XOA @MASONHAP";
            return DataProvider.Instance.ExecuteNonQuery(sql, new object[] { manhap });
        }

        public DataTable LoadComboNhanVien()
        {
            string sql = "SELECT * FROM NHANVIEN";
            return DataProvider.Instance.ExecuteQuery(sql);
        }
    }
}
