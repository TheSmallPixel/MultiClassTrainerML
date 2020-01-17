using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaScaA
    {
        public int IdAniaScaA { get; set; }
        public int? IdAniaScaF { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public int? IdRichiestaTransizione { get; set; }
        public int? IdFunzioneSinistro { get; set; }
        public DateTime? DtFlussoInv { get; set; }
        public DateTime? DtFlussoRic { get; set; }
        public DateTime? DtInizioElaborazione { get; set; }
        public int? ProgressivoRecord { get; set; }
        public string FlgTipoRecord { get; set; }
        public string FlgTipoFunzione { get; set; }
        public string FlgRuoloImpresaMittente { get; set; }
        public DateTime? DtEvento { get; set; }
        public string CodImpresaMittente { get; set; }
        public string FlgFormatoVeicMittente { get; set; }
        public string IdentVeicMittente { get; set; }
        public string CodImpresaCtp { get; set; }
        public string FlgFormatoVeicCtp { get; set; }
        public string IdentVeicCtp { get; set; }
        public string RifImpresaMittente { get; set; }
        public string NomeFlusso { get; set; }
        public string CodiceFlusso { get; set; }
    }
}
