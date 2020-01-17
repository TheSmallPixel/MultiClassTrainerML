using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrTargetMarket
    {
        public int KeyPrTargetMarket { get; set; }
        public int IdPrTargetMarket { get; set; }
        public int IdPrProdotto { get; set; }
        public string FlgTargetMarket { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
