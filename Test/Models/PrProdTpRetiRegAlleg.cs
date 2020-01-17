using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrProdTpRetiRegAlleg
    {
        public decimal KeyPrProdTpRetiRegAlleg { get; set; }
        public decimal? IdPrProdTpRetiRegAlleg { get; set; }
        public decimal IdPrRegoleAllegati { get; set; }
        public string FlgTipoReteVendita { get; set; }
        public string FlgDerogaSino { get; set; }
        public decimal? CodDeroga { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal IdUtente { get; set; }
    }
}
