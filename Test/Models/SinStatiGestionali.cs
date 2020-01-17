using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinStatiGestionali
    {
        public int KeyStatoGestionale { get; set; }
        public int IdStatoGestionale { get; set; }
        public int IdSinistro { get; set; }
        public int IdEntitacoinvolta { get; set; }
        public int IdDanno { get; set; }
        public string FlgStato { get; set; }
        public decimal? ImpRiservaGestionale { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
