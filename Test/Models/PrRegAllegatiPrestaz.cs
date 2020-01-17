using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrRegAllegatiPrestaz
    {
        public decimal KeyPrRegAllegatiPrestaz { get; set; }
        public decimal? IdPrRegAllegatiPrestaz { get; set; }
        public decimal IdPrGarPrestazioni { get; set; }
        public decimal IdRegolaAllegato { get; set; }
        public string FlgDerogaSino { get; set; }
        public decimal? CodDeroga { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal IdUtente { get; set; }
    }
}
