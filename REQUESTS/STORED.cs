using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REQUESTS
{
    public class STORED:REQUEST
    {
        public string BUKRS_ID { get; set; }
        public DateTime DATA_BSTART { get; set; }
        public MTART MTART { get; set; }
        public int BSTART { get; set; }
        public double SUMM { get; set; }

        public STORED() { }
        public STORED(DateTime DATE1, DateTime DATE2)
        {
            this.DATA1 = DATE1;
            this.DATA2 = DATE2;
        }

        public override void getRequest()
        {
            Console.WriteLine("DATA1: {0}\n" +
                "DATA2: {1}\n" +
                "BUKRS: {2}\n" +
                "DATA_BSTART: {3}\n" +
                "MTART: {4}\n" +
                "MTART_TXT: {5}\n" +
                "MTART_EINE: {6}\n" +
                "BSTART: {7}\n" +
                "SUMM: {8}", DATA1.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture), DATA2.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture),
                BUKRS_ID, DATA_BSTART.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture), MTART.MTART_ID, MTART.MTART_TXT, MTART.MTART_EINE, BSTART, Math.Round(SUMM));
        }
    }
}
