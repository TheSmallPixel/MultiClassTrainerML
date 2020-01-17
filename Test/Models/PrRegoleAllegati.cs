using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrRegoleAllegati
    {
        public int KeyPrRegoleAllegati { get; set; }
        public int IdPrRegoleAllegati { get; set; }
        public int IdPrProdotto { get; set; }
        public int IdRegolaAllegato { get; set; }
        public string FlgDerogaSino { get; set; }
        public decimal? CodDeroga { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
        public string FlgTuttiCanaliRete { get; set; }
    }
}
