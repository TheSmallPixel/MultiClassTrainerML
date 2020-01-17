using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaScaR
    {
        public int IdAniaScaR { get; set; }
        public int? IdAniaScaP { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public DateTime? DtFlussoInv { get; set; }
        public DateTime? DtFlussoRic { get; set; }
        public DateTime? DtInizioElaborazione { get; set; }
        public int? ProgressivoRecord { get; set; }
        public string FlgTipoRecord { get; set; }
        public string FlgTipoFunzione { get; set; }
        public string FlgCodiceStatoRich { get; set; }
        public DateTime? DtEvento { get; set; }
        public string GestoreImpresaMittente { get; set; }
        public string CodImpresaMittente { get; set; }
        public string FlgFormatoVeicMittente { get; set; }
        public string IdentVeicMittente { get; set; }
        public string CodImpresaCtp { get; set; }
        public string FlgFormatoVeicCtp { get; set; }
        public string IdentVeicCtp { get; set; }
        public string NomeFlusso { get; set; }
    }
}
