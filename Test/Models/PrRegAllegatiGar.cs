using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrRegAllegatiGar
    {
        public decimal KeyPrGarRegAllegati { get; set; }
        public decimal? IdPrGarRegAllegati { get; set; }
        public decimal? IdPrGaranzia { get; set; }
        public decimal IdRegolaAllegato { get; set; }
        public string FlgTuttiCanaliRete { get; set; }
        public string FlgDerogaSino { get; set; }
        public decimal? CodDeroga { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal IdUtente { get; set; }
    }
}
