using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrParCombinazioni
    {
        public decimal KeyPrParCombinazione { get; set; }
        public decimal? IdPrParCombinazione { get; set; }
        public decimal? IdPrGarCombinazione { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal? IdPrValParametro { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
