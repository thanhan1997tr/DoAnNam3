using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MatHangDTO
    {
        private string sMaHang;
        private string sTenHang;
        private string sMaNcc;

        public MatHangDTO(string mahang, string tenhang, string mancc)
        {
            this.sMaHang = mahang;
            this.sTenHang = tenhang;
            this.sMaNcc = mancc;
        }

        public string SMaHang
        {
            get
            {
                return sMaHang;
            }

            set
            {
                sMaHang = value;
            }
        }

        public string STenHang
        {
            get
            {
                return sTenHang;
            }

            set
            {
                sTenHang = value;
            }
        }

        public string SMaNcc
        {
            get
            {
                return sMaNcc;
            }

            set
            {
                sMaNcc = value;
            }
        }
    }
}
