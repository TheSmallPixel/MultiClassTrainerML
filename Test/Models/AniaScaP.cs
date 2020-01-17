using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaScaP
    {
        public int IdAniaScaP { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public DateTime? DtFlussoRic { get; set; }
        public DateTime? DtAbbinamento { get; set; }
        public DateTime? DtInizioElaborazione { get; set; }
        public int? ProgressivoRecord { get; set; }
        public string FlgTipoRecord { get; set; }
        public string FlgStatoRecord { get; set; }
        public string FlgTipoFunzione { get; set; }
        public string FlgBloccanteWarning { get; set; }
        public string StringaAnomalie { get; set; }
        public string FlgTipoRiferimentoAnia { get; set; }
        public string RiferimentoAnia { get; set; }
        public string CodiceStato { get; set; }
        public string CodiceClassificazione { get; set; }
        public string Note { get; set; }
        public string NomeFileOriginale { get; set; }
        public string NomeFileInArichivio { get; set; }
        public string FlgTipoDocumento { get; set; }
        public string FlgTipoFile { get; set; }
        public int? DimensioneFile { get; set; }
        public string CheckSum { get; set; }
        public string NomeFlusso { get; set; }
    }
}
