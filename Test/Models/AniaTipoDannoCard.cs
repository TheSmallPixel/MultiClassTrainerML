using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaTipoDannoCard
    {
        public int KeyAniaTipoDannoCard { get; set; }
        public int IdAniaTipoDannoCard { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public string FlgTipoDannoAnia { get; set; }
        public string FlgStatoDannoAnia { get; set; }
        public string FlgGestionarioDebitore { get; set; }
        public string FlgUltimoFlussoAccettSino { get; set; }
        public string FlgUltimoTipoFlussoAgg { get; set; }
        public DateTime? DtPrimaPredisposizione { get; set; }
        public DateTime? DtPrimoInvio { get; set; }
        public DateTime? DtUltimoInvio { get; set; }
        public DateTime? DtPrimoOk { get; set; }
        public DateTime? DtUltimoOk { get; set; }
        public DateTime? DtAggiornamento { get; set; }
        public string FlgTipoConvenzione { get; set; }
        public string FlgTipoConvenzioneAnia { get; set; }
        public string FlgAvvisoChiusuraUffSino { get; set; }
        public string FlgChiusuraUfficioSino { get; set; }
        public string FlgMovBloccatiDaAniaSino { get; set; }
        public string FlgMotivoChiusura { get; set; }
        public decimal? ImportoRiserva { get; set; }
        public string FlgIndicatoreCttFranchigia { get; set; }
        public DateTime? DtUltimoPagamento { get; set; }
        public string FlgDefinizionePagamentoAnia { get; set; }
        public decimal? ForfaitRecuperatoAnia { get; set; }
        public decimal? ForfaitRecuperatoWise { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
        public string FlgTipoCaricamento { get; set; }
        public DateTime? DtUltimaPredisposizione { get; set; }
        public int? IdAniaSinistroCard { get; set; }
        public int? IdAniaPartitaCard { get; set; }
        public string IdentificativoPartita { get; set; }
        public int? IdAniaTipoDannoDett { get; set; }
    }
}
