using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinEntitaSchedaDannoTemp
    {
        public int KeyEntitaschedadannotemp { get; set; }
        public int IdEntitaschedadannotemp { get; set; }
        public int IdEntitaschedalesioni { get; set; }
        public int IdEntitacoinvolta { get; set; }
        public int IdSinistro { get; set; }
        public int NumeroGiorni { get; set; }
        public decimal PercInabilita { get; set; }
        public decimal? ImpDanno { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
