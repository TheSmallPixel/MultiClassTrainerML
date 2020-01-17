using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrVariaPercBm
    {
        public int KeyPrVariaPercBm { get; set; }
        public int IdPrVariaPercBm { get; set; }
        public int IdPrGarTariffa { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgClasseProvenienza { get; set; }
        public string FlgClasseAssegnazione { get; set; }
        public decimal? PercVariazione { get; set; }
    }
}
