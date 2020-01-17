using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinEcRichiesteDanni
    {
        public int KeyEcRichiesteDanni { get; set; }
        public int IdEcRichiesteDanni { get; set; }
        public int IdEntitacoinvolta { get; set; }
        public int IdSinistro { get; set; }
        public DateTime? DtRichiestaDannoCose { get; set; }
        public DateTime? DtDenunciaDannoCose { get; set; }
        public DateTime? DtRichiestaDannoLesioni { get; set; }
        public DateTime? DtDenunciaDannoLesioni { get; set; }
        public DateTime? DtRichiestaDannoVeicoli { get; set; }
        public DateTime? DtDenunciaDannoVeicoli { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
