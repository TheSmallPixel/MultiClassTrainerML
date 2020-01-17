using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinEntitaCoinvolte
    {
        public decimal KeyEntitacoinvolta { get; set; }
        public decimal IdEntitacoinvolta { get; set; }
        public int? IdIspettorato { get; set; }
        public string NoteDannoReCose { get; set; }
        public decimal? ImpPreIniReCose { get; set; }
        public decimal? PerInvPermanente { get; set; }
        public decimal? IdOspedale { get; set; }
        public decimal? IdMedico { get; set; }
        public decimal? IdValuta { get; set; }
        public string NoteEntitaCoinvolta { get; set; }
        public DateTime DtStato { get; set; }
        public string ProgressivoEntitaCoinvolta { get; set; }
        public decimal? IdLiquidatore { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal? IdEntitacoinvoltarca { get; set; }
        public string FlgContraenteSino { get; set; }
        public string FlgDannoReCoseSino { get; set; }
        public string FlgMortoSino { get; set; }
        public string FlgStatoDannoReCose { get; set; }
        public string FlgValidataSino { get; set; }
        public decimal? GgInvTemporanea { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string NoteStatoReCose { get; set; }
        public string FlgStatoRecupero { get; set; }
        public decimal IdSinistro { get; set; }
        public decimal IdAnagrafica { get; set; }
        public decimal? IdPerito { get; set; }
        public string FlgFurtoTotaleSino { get; set; }
        public string FlgMotivoRiapertura { get; set; }
        public string FlgPresaCaricoIspetSino { get; set; }
        public string FlgTipoCaricamento { get; set; }
        public string FlgStatoSpeseResistenza { get; set; }
        public string FlgStato { get; set; }
        public DateTime? DtStatoRecupero { get; set; }
        public string FlgAttesaRecupero { get; set; }
        public DateTime? DtRiapertura { get; set; }
        public decimal? IdEntitacoinvoltacci { get; set; }
        public string FlgCausaleChiusuraCose { get; set; }
        public string FlgCausaleChiusuraSpeRes { get; set; }
        public int? PrgEntitaCoinvolta { get; set; }
        public int? IdEntitacoinvoltaAnt { get; set; }
        public int? IdIndirizzo { get; set; }
        public DateTime? DtInvioLetteraCortesia { get; set; }
        public string IdentificativoAnia { get; set; }
        public int? IdEcAltridati { get; set; }
        public string FlgRecordAnnullatoSino { get; set; }
        public string FlgPartitaPasSino { get; set; }
    }
}
