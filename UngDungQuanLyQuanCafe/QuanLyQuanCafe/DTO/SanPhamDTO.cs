using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPhamDTO
    {
        private string sMaSp;
        private string sTenSp;
        private float fDonGiaBan;

        public SanPhamDTO(string masp, string tensp, float dongiaban)
        {
            this.sMaSp = masp;
            this.sTenSp = tensp;
            this.fDonGiaBan = dongiaban;
        }
        public string SMaSp
        {
            get
            {
                return sMaSp;
            }

            set
            {
                sMaSp = value;
            }
        }

        public string STenSp
        {
            get
            {
                return sTenSp;
            }

            set
            {
                sTenSp = value;
            }
        }

        public float FDonGiaBan
        {
            get
            {
                return fDonGiaBan;
            }

            set
            {
                fDonGiaBan = value;
            }
        }
    }
}
