using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinSchedaValutazioneTemp
    {
        public int KeySchedavalutazionetemp { get; set; }
        public int IdSchedavalutazionetemp { get; set; }
        public int IdEntitaschedadannoval { get; set; }
        public int IdEntitacoinvolta { get; set; }
        public int IdSinistro { get; set; }
        public int? GiorniInabilita { get; set; }
        public decimal? PctInabilita { get; set; }
        public decimal? ImpDanno { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
