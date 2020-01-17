using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrCaricamenti
    {
        public decimal KeyPrCaricamento { get; set; }
        public decimal? IdPrCaricamento { get; set; }
        public decimal? IdPrProdotto { get; set; }
        public decimal? ImpCapitaleDa { get; set; }
        public decimal? ImpCapitaleA { get; set; }
        public decimal? PercCaricamento { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
