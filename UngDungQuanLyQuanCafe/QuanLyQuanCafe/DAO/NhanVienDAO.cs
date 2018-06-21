using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;
        public static NhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private NhanVienDAO() { }

        //Lấy mã số lớn mới nhất chưa được thêm
        public string getMaNv()
        {
            string sMaNVMoi = "";
            string query = "SP_GETMANV";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow items in data.Rows)
            {
                sMaNVMoi = items["MASONV"].ToString();
            }
            return sMaNVMoi;
        }

        //Load combobox theo tên nhân vên
        public DataTable LoadComboTenNhanVien()
        {
            string sql = "SP_NHANVIEN_LOADCOMBOBOX";
            return DataProvider.Instance.ExecuteQuery(sql);
        }
        public List<NhanVienDTO> Load()
        {
            List<NhanVienDTO> nv = new List<NhanVienDTO>();
            string query = "SP_NHANVIEN_LOAD";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow items in data.Rows)
            {
                string manv = items["MANV"].ToString();
                string tennv = items["TENNV"].ToString();
                string ngaysinh = items["NGAYSINH"].ToString();
                string gioitinh = items["GIOITINH"].ToString();
                string diachi = items["DIACHI"].ToString();
                string dienthoai = items["DIENTHOAI"].ToString();
                string matkhau = items["MATKHAU"].ToString();
                string q = items["QUYEN"].ToString();
                string luong = items["LUONGCOBAN"].ToString();
                NhanVienDTO nvnew = new NhanVienDTO(manv, tennv, ngaysinh, gioitinh, diachi, dienthoai, matkhau, q, luong);
                nv.Add(nvnew);
            }
            return nv;
        }

        public int ThemNhanVien(NhanVienDTO nv)
        {
            string sql = "SP_NHANVIEN_THEM @manv , @tennv , @ngaysinh , @gioitinh , @diachi , @dienthoai , @matkhau , @quyen , @luong";
            return DataProvider.Instance.ExecuteNonQuery(sql, new object[] { nv.SManv, nv.STennv, nv.SNgaysinh, nv.SGioitinh, nv.SDiachi, nv.SDienthoai, nv.SMatkhau, nv.SQuyen, nv.SLuong });
        }
        public int XoaNhanVien(string manv)
        {
            string sql = "SP_NHANVIEN_XOA @manv";
            return DataProvider.Instance.ExecuteNonQuery(sql, new object[] {manv});
        }
        public int SuaNhanVien(NhanVienDTO nv)
        {
            string sql = "SP_NHANVIEN_SUA @manv , @tennv , @ngaysinh , @gioitinh , @diachi , @dienthoai , @quyen , @luong";
            return DataProvider.Instance.ExecuteNonQuery(sql, new object[] { nv.SManv, nv.STennv, nv.SNgaysinh, nv.SGioitinh, nv.SDiachi, nv.SDienthoai, nv.SQuyen, nv.SLuong });
        }
        public int SuaMatKhauNhanVien(string manv, string matkhau)
        {
            string sql = "SP_NHANVIEN_SUA_MATKHAU @manv , @matkhau";
            return DataProvider.Instance.ExecuteNonQuery(sql, new object[] { manv, matkhau });
        }
    }
}
