using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaScaC
    {
        public int IdAniaScaC { get; set; }
        public int IdAniaScaA { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public string FlgCodiceStatoAttuale { get; set; }
        public string FlgCodiceStatoRichiesto { get; set; }
        public string FlgClassificazioneRichiesta { get; set; }
        public string FlgNoteCambioStato { get; set; }
    }
}
