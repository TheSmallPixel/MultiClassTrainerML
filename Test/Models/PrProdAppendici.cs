using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrProdAppendici
    {
        public decimal KeyPrProdAppendice { get; set; }
        public decimal? IdPrProdAppendice { get; set; }
        public decimal? IdPrProdotto { get; set; }
        public decimal? IdTabAppendice { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
