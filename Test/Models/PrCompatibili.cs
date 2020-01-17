using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrCompatibili
    {
        public decimal KeyPrCompatibile { get; set; }
        public decimal? IdPrCompatibile { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal? IdPrProdotto { get; set; }
        public decimal? IdPrProdottoCompatibile { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
