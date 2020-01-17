using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaTipoDannoCardDettAgg
    {
        public int IdAniaTipoDannoDettAgg { get; set; }
        public int IdAniaTipoDannoCard { get; set; }
        public int? IdFlussoCard { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public string FlgTipoDannoAnia { get; set; }
        public string FlgGestionarioDebitore { get; set; }
        public string FlgScartatoSino { get; set; }
        public DateTime? DtInvio { get; set; }
        public string IdentificativoPartita { get; set; }
        public DateTime? DtAggiornamento { get; set; }
        public decimal? ImportoRiserva { get; set; }
        public string FlgDefinizionePagamento { get; set; }
        public DateTime? DtContabileRiferimento { get; set; }
        public string FlgTipoConvenzioneAnia { get; set; }
        public string ADisposizioneGestionaria { get; set; }
        public DateTime? DtElaborazioneAnia { get; set; }
        public int? PrgMovimentoAnia { get; set; }
        public string FlgTipoCaricamento { get; set; }
        public int? IdSospesoCard { get; set; }
    }
}
