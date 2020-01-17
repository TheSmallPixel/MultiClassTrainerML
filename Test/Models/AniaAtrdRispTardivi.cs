using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaAtrdRispTardivi
    {
        public int KeyAniaAtrdRispTardivi { get; set; }
        public int IdAniaAtrdRispTardivi { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
        public DateTime? DtInvio { get; set; }
        public string Testata { get; set; }
        public string TipoRecord { get; set; }
        public string CodImpresa { get; set; }
        public string CodIur { get; set; }
        public string NSinistro { get; set; }
        public string TipologiaSinistro { get; set; }
        public int? PctResponsabilita { get; set; }
        public DateTime? DtAvvenimentoSinistro { get; set; }
        public DateTime? DtDenunciaSinistro { get; set; }
        public string TipoMovimento { get; set; }
        public string CausaleMovimento { get; set; }
        public DateTime? DtPagamentoSinistro { get; set; }
        public DateTime? DtAggiornamentoSinistro { get; set; }
        public string FormatoIdentVeicolo { get; set; }
        public string IdentVeicolo { get; set; }
        public string TipoVeicolo { get; set; }
        public string NPolizza { get; set; }
        public DateTime? DtScadenzaContratto { get; set; }
        public string FormaTariffaria { get; set; }
        public string IdentFiscaleContraente { get; set; }
        public string IdentFiscaleAventeDiritto { get; set; }
        public string TipologiaAventeDiritto { get; set; }
        public string IdentSinistroAnia { get; set; }
        public string RiferimentoRichiesta { get; set; }
        public string RiferimentoRichiedente { get; set; }
    }
}
