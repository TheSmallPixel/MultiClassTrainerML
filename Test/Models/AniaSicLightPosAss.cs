using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaSicLightPosAss
    {
        public int IdRispostaLightPosAss { get; set; }
        public int IdRispostaLight { get; set; }
        public int? IdSinistro { get; set; }
        public string CodImpresa { get; set; }
        public string TipoVeicolo { get; set; }
        public string NumPolizza { get; set; }
        public DateTime? DtEffetto { get; set; }
        public DateTime? DtScadenza { get; set; }
        public string FlgUtilizzo { get; set; }
        public string FlgCopertura { get; set; }
        public string TipoMovimento { get; set; }
        public string Causale { get; set; }
        public string CodFiscaleContraente { get; set; }
        public string CodFiscaleProprietario { get; set; }
        public string CognomeContraente { get; set; }
        public string NomeProprietario { get; set; }
        public string CognomeProprietario { get; set; }
        public string NomeContraente { get; set; }
        public DateTime? DtScadenzaMora { get; set; }
    }
}
