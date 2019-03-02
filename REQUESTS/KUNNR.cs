using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REQUESTS
{
    public class KUNNR
    {
        private static int Id = 0;
        public string KUNNR_ID { get; }
        public string KUNNR_TXT { get; set; }
        public string KUNNR_BIN { get; set; }
        public string KUNNR_ADR_UR { get; set; }
        public string KUNNR_ADR_DOST { get; set; }
        public KUNNR()
        {
            ++Id;
            KUNNR_ID = "KUNNR_" + Id;
        }
        public KUNNR(string KUNNR_TXT, string KUNNR_BIN, string KUNNR_ADR_UR, string KUNNR_ADR_DOST)
        {
            ++Id;
            KUNNR_ID = "KUNNR_" + Id;
            this.KUNNR_TXT = KUNNR_TXT;
            this.KUNNR_BIN = KUNNR_BIN;
            this.KUNNR_ADR_UR = KUNNR_ADR_UR;
            this.KUNNR_ADR_DOST = KUNNR_ADR_DOST;
        }
        public void KUNNRInfo()
        {
            Console.WriteLine("KUNNR_ID: {0}\n" +
                "KUNNR_TXT: {1}\n" +
                "KUNNR_BIN: {2}\n" +
                "KUNNR_ADR_UR: {3}\n" +
                "KUNNR_ADR_DOST: {4}\n", KUNNR_ID, KUNNR_TXT, KUNNR_BIN, KUNNR_ADR_UR, KUNNR_ADR_DOST);
        }
        public string KUNNRToString()
        {
            return (KUNNR_ID + ";" + KUNNR_TXT + ";" + KUNNR_BIN + ";" + KUNNR_ADR_UR + ";" + KUNNR_ADR_DOST);
        }
    }
}
