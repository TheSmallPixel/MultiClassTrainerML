using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrGarTargetMarket
    {
        public int KeyPrGarTargetMarket { get; set; }
        public int IdPrGarTargetMarket { get; set; }
        public int IdPrGaranzia { get; set; }
        public string FlgTargetMarket { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
