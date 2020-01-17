using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinEntitaCoinvolteRca
    {
        public decimal KeyEntitacoinvoltarca { get; set; }
        public decimal? IdContraente { get; set; }
        public decimal? IdVeicolo { get; set; }
        public string NoteDannoCorporale { get; set; }
        public string NoteDannoVeicoli { get; set; }
        public decimal? ImpPreIniPersone { get; set; }
        public decimal? ImpPreIniVeicoli { get; set; }
        public decimal? IdConducente { get; set; }
        public decimal? IdProprietario { get; set; }
        public decimal? IdRimessa { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal IdEntitacoinvoltarca { get; set; }
        public string FlgDannoCorporaleSino { get; set; }
        public string FlgDannoVeicoliSino { get; set; }
        public string FlgTipoDanno { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdValuta { get; set; }
        public string FlgTipologiaGestioneCose { get; set; }
        public string FlgTipologiaGestionePers { get; set; }
        public string FlgTipologiaGestioneVeic { get; set; }
        public string FlgStatoDannoPers { get; set; }
        public string FlgStatoDannoVeic { get; set; }
        public string NoteStatoPers { get; set; }
        public string NoteStatoVeic { get; set; }
        public string FlgStanza { get; set; }
        public string CodRuoloIsvap { get; set; }
        public string CodRuoloAnia { get; set; }
        public string FlgPresenteSulVeicoloSino { get; set; }
        public string FlgInviareAnia { get; set; }
        public string FlgForzaturaRcaSino { get; set; }
        public DateTime? DtStatoCard { get; set; }
        public string FlgRuoloCoinvolto { get; set; }
        public decimal? IdEntitacoinvolta148 { get; set; }
        public string FlgCdInGestioneSino { get; set; }
        public string FlgCauDannoPersIsvap { get; set; }
        public string FlgCauDannoCoseIsvap { get; set; }
        public string FlgCauDannoVeicIsvap { get; set; }
        public decimal IdSinistro { get; set; }
        public string FlgInvioInps { get; set; }
        public string FlgResponsabileSino { get; set; }
        public string FlgPartitaFittiziaSino { get; set; }
        public string FlgCausaleChiusuraPers { get; set; }
        public string FlgCausaleChiusuraVeic { get; set; }
        public decimal? PerResponsabilita { get; set; }
        public string TrasportatoFuoriCttSino { get; set; }
        public decimal? PercRespCivile { get; set; }
        public string FlgTipoCtt { get; set; }
        public string FlgAttesaIntegr57Sino { get; set; }
        public DateTime? DtForzaturaRuoloAnia { get; set; }
        public string FlgRecordAnnullatoSino { get; set; }
        public decimal? PercRespForzaturaCtt { get; set; }
    }
}
