using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REQUESTS
{
    public enum VALUTA { KZT, USD, RUR };
    public class SALES:REQUEST
    {
        private static int ID = 0;

        public string BUKRS_ID { get; set; }
        public string WERKS { get; set; }
        public string LGORT { get; set; }
        public SALES_CHANEL SALES_CHANEL { get; set; }
        public KUNNR KUNNR { get; set; }
        public string ID_OUT_DELIVERY { get; }
        public DateTime ID_OUT_DELIVERY_DATA { get; set; }
        public int BSTART { get; set; }
        public double SUMM { get; set; }
        public VALUTA VALUTA { get; set; }

        public SALES()
        {
            ++ID;
            ID_OUT_DELIVERY = "IOD_" + ID;
        }
        public SALES(DateTime DATE1, DateTime DATE2)
        {
            ++ID;
            ID_OUT_DELIVERY = "IOD_" + ID;
            this.DATA1 = DATE1;
            this.DATA2 = DATE2;
        }

        public override void getRequest()
        {
            Console.WriteLine("DATA1: {0}\n" +
                "DATA1: {1}\n" +
                "BUKRS_ID: {2}\n" +
                "WERKS: {3}\n" +
                "LGORT: {4}\n" +
                "SALES_CHANEL : {5}\n" +
                "SALES_CHANEL_TXT: {6}\n", DATA1.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture), DATA2.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture),
                BUKRS_ID, WERKS, LGORT, SALES_CHANEL.SALES_CHANEL_ID, SALES_CHANEL.SALES_CHANEL_TXT);
            KUNNR.KUNNRInfo();
            Console.WriteLine("ID_OUT_DELIVERY: {0}\n" +
                "ID_OUT_DELIVERY_DATA: {1}\n" +
                "BSTART: {2}\n" +
                "SUMM: {3}\n" +
                "VALUTA: {4}", ID_OUT_DELIVERY, ID_OUT_DELIVERY_DATA.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture), BSTART, Math.Round(SUMM, 2), VALUTA);
        }
    }
}
