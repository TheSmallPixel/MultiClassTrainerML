using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaSicRisposteLight
    {
        public int IdRispostaLight { get; set; }
        public int? IdSinistro { get; set; }
        public string TipoErrore { get; set; }
        public string CodErrore { get; set; }
        public string ProtocolloSic { get; set; }
        public string RispostaOffline { get; set; }
        public string RispostaOnline { get; set; }
        public string TipoRispostaOnline { get; set; }
        public string DescVeicolo1 { get; set; }
        public string DescVeicolo2 { get; set; }
        public string FlgSinCardVeicolo1 { get; set; }
        public string FlgSinCardVeicolo2 { get; set; }
        public int? NumSinistriVeicolo1 { get; set; }
        public int? NumSinistriVeicolo2 { get; set; }
        public int? NumRigheDaVis { get; set; }
        public int? NumRigheTrovate { get; set; }
    }
}
