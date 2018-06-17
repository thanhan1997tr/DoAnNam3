using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TableBUS
    {
        private static TableBUS instance;

        public static TableBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TableBUS();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private TableBUS() { }
    }
}
