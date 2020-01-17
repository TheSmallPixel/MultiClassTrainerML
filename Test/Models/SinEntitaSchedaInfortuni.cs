using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinEntitaSchedaInfortuni
    {
        public int KeyEntitaschedainfortuni { get; set; }
        public int IdEntitaschedainfortuni { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public decimal? ImpArrotondamento { get; set; }
        public string Note { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
