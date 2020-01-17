using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaTipoDannoCardDettPag
    {
        public int IdAniaTipoDannoDettPag { get; set; }
        public int? IdAniaTipoDannoCard { get; set; }
        public int? IdAniaSinistroCard { get; set; }
        public int? IdFlussoCard { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public string FlgTipoDannoAnia { get; set; }
        public string FlgGestionarioDebitore { get; set; }
        public string FlgScartatoSino { get; set; }
        public DateTime? DtInvio { get; set; }
        public string IdentificativoPartita { get; set; }
        public string FlgTipoResponsabilitaDeb { get; set; }
        public DateTime? DtPagamento { get; set; }
        public string FlgTipoMovimento { get; set; }
        public string FlgCausaleMovimento { get; set; }
        public decimal? ImportoLiquidatoGest { get; set; }
        public string FlgDefinizionePagamento { get; set; }
        public string FlgErogazioneImporto { get; set; }
        public string ProvResProprietarioGest { get; set; }
        public string FlgIdentificativoMassimale { get; set; }
        public string ProvinciaForfait { get; set; }
        public string FlgTipoSiglaProvForfait { get; set; }
        public string FlgRuoloImpresa { get; set; }
        public string FlgTipoVeicoloForfait { get; set; }
        public decimal? ForfaitAccreditatoGest { get; set; }
        public DateTime? DtContabileRiferimento { get; set; }
        public string FlgTipoConvenzioneAnia { get; set; }
        public string ADisposizioneGestionaria { get; set; }
        public DateTime? DtElaborazioneAnia { get; set; }
        public int? PrgMovimentoAnia { get; set; }
        public string FlgTipoCaricamento { get; set; }
        public DateTime? DtPredisposizione { get; set; }
        public int? IdSospesoCard { get; set; }
    }
}
