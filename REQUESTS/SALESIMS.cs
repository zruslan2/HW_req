using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REQUESTS
{
    public class SALESIMS:REQUEST
    {
        public string BUKRS_ID { get; set; }
        public string WERKS { get; set; }
        public MTART MTART { get; set; }
        public int BSTART { get; set; }
        public double SUMM { get; set; }

        public SALESIMS() { }
        public SALESIMS(DateTime DATE1, DateTime DATE2)
        {
            this.DATA1 = DATE1;
            this.DATA2 = DATE2;
        }
        public override void getRequest()
        {
            Console.WriteLine("DATA1: {0}\n" +
                "DATA2: {1}\n" +
                "BUKRS: {2}\n" +
                "WERKS: {3}\n" +
                "MTART: {4}\n" +
                "MTART_TXT: {5}\n" +
                "MTART_PROIZVOD_COUNTRY: {6}\n" +
                "BSTART: {7}\n" +
                "SUMM: {8}", DATA1.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture), DATA2.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture),
                BUKRS_ID, WERKS, MTART.MTART_ID, MTART.MTART_TXT, MTART.MTART_PROIZVOD_COUNTRY, BSTART, SUMM);
        }
    }
}
