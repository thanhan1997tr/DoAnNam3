using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class getDateTimeNow
    {
        //trả về mã theo ngày tháng năm hiện tại
        public static string getStringMa()
        {
            DateTime date = DateTime.Now;
            string s = date.ToString("MM/dd/yyyy HH:mm:ss");
            date = DateTime.ParseExact(s, "MM/dd/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            string ngay = date.Day.ToString();
            string thang = date.Month.ToString();
            string nam = date.Year.ToString();
            string gio = date.Hour.ToString();
            string phut = date.Minute.ToString();
            string giay = date.Second.ToString();
            if (Convert.ToInt32(ngay) < 10)
            {
                ngay = "0" + ngay;
            }
            if (Convert.ToInt32(thang) < 10)
            {
                thang = "0" + thang;
            }
            if (Convert.ToInt32(gio) < 10)
            {
                gio = "0" + gio;
            }
            if (Convert.ToInt32(phut) < 10)
            {
                phut = "0" + phut;
            }
            if (Convert.ToInt32(giay) < 10)
            {
                giay = "0" + giay;
            }
            return ngay + thang + nam + gio + phut + giay;
        }
    }
}
