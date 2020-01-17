using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrGarTpRetiRegAlleg
    {
        public decimal KeyPrGarTpRetiRegAlleg { get; set; }
        public decimal? IdPrGarTpRetiRegAlleg { get; set; }
        public decimal IdPrGarRegAllegati { get; set; }
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
