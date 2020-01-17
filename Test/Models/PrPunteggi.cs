using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrPunteggi
    {
        public decimal KeyPrPunteggio { get; set; }
        public decimal? IdPrPunteggio { get; set; }
        public decimal? IdPrGarTariffa { get; set; }
        public decimal? Punti { get; set; }
        public decimal? Premio { get; set; }
        public string FlgTuttiSettoriSino { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
