using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinEntitaSchedaInfGar
    {
        public int KeyEntitaschedainfgar { get; set; }
        public int IdEntitaschedainfgar { get; set; }
        public int IdEntitaschedainfortuni { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public int? IdGaranziacolpita { get; set; }
        public string FlgTipoSchedaDanno { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
