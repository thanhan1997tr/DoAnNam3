using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TableDTO
    {
        private string sMaBan;
        private string sTenBan;
        private string sTrangThai;
        public TableDTO(string mb, string tb, string stt)
        {
            this.sMaBan = mb;
            this.sTenBan = tb;
            this.sTrangThai = stt;
        }
        public string SMaBan
        {
            get
            {
                return sMaBan;
            }

            set
            {
                sMaBan = value;
            }
        }

        public string STenBan
        {
            get
            {
                return sTenBan;
            }

            set
            {
                sTenBan = value;
            }
        }

        public string STrangThai
        {
            get
            {
                return sTrangThai;
            }

            set
            {
                sTrangThai = value;
            }
        }
    }
}
