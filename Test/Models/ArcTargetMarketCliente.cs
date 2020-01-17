using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcTargetMarketCliente
    {
        public int KeyTargetMarketCliente { get; set; }
        public int IdTargetMarketCliente { get; set; }
        public int IdRispQuestionarioIdd { get; set; }
        public string FlgTargetMarket { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
    }
}
