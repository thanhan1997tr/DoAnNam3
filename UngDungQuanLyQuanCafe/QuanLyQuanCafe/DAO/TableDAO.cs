using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TableDAO
    {
        public static int TableWidth = 85;
        public static int TableHeight = 85;
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TableDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private TableDAO() { }

        public DataTable Load_ComboboxTable()
        {
            return DataProvider.Instance.ExecuteQuery("SP_TABLE_LOAD");
        }
        public List<TableDTO> Load_Table()
        {
            List<TableDTO> tablelist = new List<TableDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_TABLE_LOAD");
            foreach (DataRow items in data.Rows)
            {
                string mb = items["MABAN"].ToString();
                string tb = items["TENBAN"].ToString();
                string stt = items["TRANGTHAI"].ToString();
                TableDTO tbnew = new TableDTO(mb, tb, stt);
                tablelist.Add(tbnew);
            }
            return tablelist;
        }

        public void ThemBan()
        {
            string sql = "SP_TABLE_THEM";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }

        public int XoaBan()
        {
            string sql = "SP_TABLE_XOA";
            return DataProvider.Instance.ExecuteNonQuery(sql);
        }
        //public void SwitchTable(string id1, string id2, string mahoadon, string manv)
        //{
        //    string query = "SP_SwitchTabel @idTable1 , @idTable2 , @mahoadon , @manv";
        //    DataProvider.Instance.ExecuteNonQuery(query, new object[] { id1, id2, mahoadon, manv });
        //}
    }
}
