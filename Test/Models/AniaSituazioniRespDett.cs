using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaSituazioniRespDett
    {
        public int IdAniaSituazioneRespDett { get; set; }
        public int IdAniaRespCard { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdFlussoCard { get; set; }
        public string FlgTipoMittente { get; set; }
        public DateTime? DtInvio { get; set; }
        public string FlgScartatoSino { get; set; }
        public string FlgRagioneTorto { get; set; }
        public string FlgRagioneTortoAnia { get; set; }
        public string FlgTipoDichiarazione { get; set; }
        public string FlgDichiarazioneResp { get; set; }
        public string FlgDichiarazioneRespAnia { get; set; }
        public string FlgStatoResponsabilitaAnia { get; set; }
        public string FlgSituazioneRespAnia { get; set; }
        public string CasoCidMittente { get; set; }
        public string CasoCidCtp { get; set; }
        public string CodiceImpresaResp { get; set; }
        public string CodiceImpresaRespAnia { get; set; }
        public string CodPrimaImpresaArbitrato { get; set; }
        public string CodSecondaImpresaArbitrato { get; set; }
        public DateTime? DtMaxRichiestaArbitrato { get; set; }
        public string FlgMotivoForzaturaResp { get; set; }
        public string FlgTipoFirma { get; set; }
        public string FlgInterventoAutoritaSino { get; set; }
        public string FlgPresenzaTestimoniSino { get; set; }
        public string Note { get; set; }
        public string FlgInterfaccia { get; set; }
        public string CodiceUtenteWeb { get; set; }
        public string ADisposizioneGestionaria { get; set; }
        public string FlgRuoloImpresa { get; set; }
        public string FlgTipoAggiornamento { get; set; }
        public DateTime? DtMaxRispostaCtp { get; set; }
        public DateTime? DtElaborazioneAnia { get; set; }
        public int? PrgMovimentoAnia { get; set; }
        public DateTime? DtPredisposizione { get; set; }
        public string FlgTipoCaricamento { get; set; }
        public int? IdSospesoCard { get; set; }
        public int? IdAniaSinistroCard { get; set; }
    }
}
