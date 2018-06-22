using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCapDTO
    {
        private string sMaNCC;

        public string SMaNCC
        {
            get { return sMaNCC; }
            set { sMaNCC = value; }
        }
        private string sTenNCC;

        public string STenNCC
        {
            get { return sTenNCC; }
            set { sTenNCC = value; }
        }
        private string sDiaChiNCC;

        public string SDiaChiNCC
        {
            get { return sDiaChiNCC; }
            set { sDiaChiNCC = value; }
        }
        private string sDienThoaiNCC;

        public string SDienThoaiNCC
        {
            get { return sDienThoaiNCC; }
            set { sDienThoaiNCC = value; }
        }

        public NhaCungCapDTO(string mancc, string tenncc, string diachi, string dienthoai)
        {
            this.sMaNCC = mancc;
            this.sTenNCC = tenncc;
            this.sDiaChiNCC = diachi;
            this.sDienThoaiNCC = dienthoai;
        }
    }
}
