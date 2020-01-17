using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CtbRecuperi
    {
        public decimal KeyRecupero { get; set; }
        public decimal IdRecupero { get; set; }
        public decimal? IdRecuperoStornato { get; set; }
        public decimal? IdDebitorerecupero { get; set; }
        public DateTime DtOrdineRecupero { get; set; }
        public DateTime? DtPagamento { get; set; }
        public decimal ImpRecupero { get; set; }
        public decimal IdValuta { get; set; }
        public decimal? MeseInvioCoass { get; set; }
        public decimal? AnnoInvioCoass { get; set; }
        public decimal? IdContocorrente { get; set; }
        public decimal? IdUtente { get; set; }
        public string FlgMezzoPagamento { get; set; }
        public string FlgMotivoStorno { get; set; }
        public string FlgStatoContabile { get; set; }
        public string FlgTipoCaricamento { get; set; }
        public string FlgTipoRecupero { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public DateTime? DtRata { get; set; }
        public decimal IdEntitacoinvolta { get; set; }
        public decimal? IdEcdelegaaltrui { get; set; }
        public decimal IdSinistro { get; set; }
        public decimal? IdIncarico { get; set; }
        public decimal? IdIspettorato { get; set; }
        public DateTime? DtScaricoContabile { get; set; }
        public string FlgTotaleSino { get; set; }
        public string FlgTitolo { get; set; }
        public string Note { get; set; }
        public decimal? IdUtenteIncaricato { get; set; }
        public DateTime? DtConfermaAnia { get; set; }
        public DateTime? DtScaricoContabileAnia { get; set; }
        public decimal? ImpIniziale { get; set; }
        public int? IdRecuperoPrecedente { get; set; }
        public DateTime? DtCaricamentoResponline { get; set; }
        public DateTime? DtPrescrizioneRecuperoAnia { get; set; }
        public DateTime? DtScartoAnia { get; set; }
        public string RifEsterno { get; set; }
        public string FlgStatoFatturaEstero { get; set; }
        public string FlgRecordAnnullatoSino { get; set; }
        public string FlgSeparatoSino { get; set; }
        public int? IdDanno { get; set; }
    }
}
