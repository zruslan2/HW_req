using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REQUESTS
{
    public class SALES_CHANEL
    {
        private static int ID = 0;
        public string SALES_CHANEL_ID { get; }
        public string SALES_CHANEL_TXT { get; set; }

        public SALES_CHANEL()
        {
            ++ID;
            SALES_CHANEL_ID = "SC_ID_" + ID;
        }
        public SALES_CHANEL(string SALES_CHANEL_TXT)
        {
            ++ID;
            SALES_CHANEL_ID = "SC_ID_" + ID;
            this.SALES_CHANEL_TXT = SALES_CHANEL_TXT;
        }
    }
}
