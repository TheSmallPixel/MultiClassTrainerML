using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaSituazioniResp
    {
        public int KeyAniaSituazioneResp { get; set; }
        public int IdAniaSituazioneResp { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdFlussoCard { get; set; }
        public string TipoDichiarazione { get; set; }
        public string DicResp { get; set; }
        public string ImpResp { get; set; }
        public string MotivoForzatura { get; set; }
        public string TipoFirma { get; set; }
        public string CasoCidNostro { get; set; }
        public string CasoCidTerzo { get; set; }
        public string FlgAutorita { get; set; }
        public string FlgTestimoni { get; set; }
        public string Note { get; set; }
        public string RagioneTorto { get; set; }
        public string CtpTipoDichiarazione { get; set; }
        public string CtpDicResp { get; set; }
        public string CtpImpResp { get; set; }
        public string CtpMotivoForzatura { get; set; }
        public string CtpTipoFirma { get; set; }
        public string CtpCasoCidNostro { get; set; }
        public string CtpCasoCidTerzo { get; set; }
        public string CtpFlgAutorita { get; set; }
        public string CtpFlgTestimoni { get; set; }
        public string CtpNote { get; set; }
        public string CtpRagioneTorto { get; set; }
        public string AniaCodImpCtp { get; set; }
        public string AniaRuoloImpresa { get; set; }
        public string AniaStatoResp { get; set; }
        public string AniaCodResp { get; set; }
        public string AniaImpResp { get; set; }
        public string AniaSitResp { get; set; }
        public string AniaTipoAggiornamento { get; set; }
        public DateTime? AniaDtMaxRisp { get; set; }
        public string AniaPrimaImpresaArbitrato { get; set; }
        public string AniaSecondaImpresaArbitrato { get; set; }
        public DateTime? AniaDtMaxArbitrato { get; set; }
        public string AniaRagioneTorto { get; set; }
        public DateTime? AniaDtElaborazione { get; set; }
        public int? AniaProgressivo { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
        public int? IdCompagnia { get; set; }
        public DateTime? DtInvio { get; set; }
        public DateTime? CptDtInvio { get; set; }
        public string FlgUltimoFlussoAccettSino { get; set; }
        public string FlgTipoMittente { get; set; }
        public DateTime? DtPrimaPredisposizione { get; set; }
        public DateTime? DtUltimaPredisposizione { get; set; }
        public DateTime? DtPrimoInvio { get; set; }
        public DateTime? DtUltimoInvio { get; set; }
        public DateTime? DtPrimoOk { get; set; }
        public DateTime? DtUltimoOk { get; set; }
        public string ClassificazioneNa { get; set; }
        public string CtpClassificazioneNa { get; set; }
        public string FlgTipoCardAnia { get; set; }
        public int? IdCinquinaCard { get; set; }
    }
}
