using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaScaF
    {
        public int IdAniaScaF { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public int? IdFunzioneSinistro { get; set; }
        public int? KeyStato { get; set; }
        public DateTime? DtFlussoRic { get; set; }
        public DateTime? DtAbbinamento { get; set; }
        public DateTime? DtInizioElaborazione { get; set; }
        public int? ProgressivoRecord { get; set; }
        public string FlgTipoRecord { get; set; }
        public string FlgStatoRecord { get; set; }
        public DateTime? DtPresaInCarico { get; set; }
        public string FlgBloccanteWarning { get; set; }
        public string StringaAnomalie { get; set; }
        public string CodiceStatoPrecedente { get; set; }
        public string CodiceStatoAttuale { get; set; }
        public DateTime? DtScadenza { get; set; }
        public string FlgRuoloGestionaria { get; set; }
        public string FlgRuoloRichiesta { get; set; }
        public string GestoreImpresaMittente { get; set; }
        public string GestoreImpresaCtp { get; set; }
        public string ProcessoAutomatico { get; set; }
        public string FlgMittenteDestinataria { get; set; }
        public DateTime? DtCreazione { get; set; }
        public string FlgTipoRiferimentoAnia { get; set; }
        public string RiferimentoAnia { get; set; }
        public string FlgPresenzaDocumentazione { get; set; }
        public string FlgSospensione { get; set; }
        public string RiservatoAnia { get; set; }
        public string NomeFlusso { get; set; }
        public string CodiceFlusso { get; set; }
    }
}
