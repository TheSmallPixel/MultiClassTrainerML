using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaSicRichiesteLight
    {
        public int IdRichiestaLight { get; set; }
        public DateTime DtRichiesta { get; set; }
        public int? IdSinistro { get; set; }
        public string CodImpMand { get; set; }
        public string CodUser { get; set; }
        public string Password { get; set; }
        public string Canale { get; set; }
        public string RifRichiesta { get; set; }
        public string RifRichiedente { get; set; }
        public string CodServizio { get; set; }
        public string CodFunzione { get; set; }
        public string FlgIdentVeicolo1 { get; set; }
        public string IdentVeicolo1 { get; set; }
        public string FlgTipoVeicolo1 { get; set; }
        public string CodImpCtp { get; set; }
        public string FlgIdentVeicolo2 { get; set; }
        public string IdentVeicolo2 { get; set; }
        public string FlgTipoVeicolo2 { get; set; }
        public DateTime DtAvvenimento { get; set; }
        public int? IdRispostaLight { get; set; }
    }
}
