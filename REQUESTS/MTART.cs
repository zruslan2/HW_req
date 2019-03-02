using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REQUESTS
{
    public class MTART
    {
        private static int ID = 0;
        public string MTART_ID { get; }
        public string MTART_TXT { get; set; }
        public string MTART_PROIZVOD_COUNTRY { get; set; }
        public string MTART_EINE { get; set; }
        public MTART()
        {
            ++ID;
            MTART_ID = "MTART_" + ID;
        }
    }
}
