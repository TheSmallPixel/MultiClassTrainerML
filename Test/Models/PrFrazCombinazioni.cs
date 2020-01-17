using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrFrazCombinazioni
    {
        public decimal KeyPrFrazCombinazione { get; set; }
        public decimal? IdPrFrazCombinazione { get; set; }
        public decimal? IdPrCombinazione { get; set; }
        public decimal? IdPrFrazAmmesso { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
