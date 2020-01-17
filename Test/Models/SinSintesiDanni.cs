using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinSintesiDanni
    {
        public int KeySinSintesiDanni { get; set; }
        public int? IdCompagnia { get; set; }
        public DateTime? DtScarico { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdPartita { get; set; }
        public int? IdDanno { get; set; }
        public string FlgTipoGestione { get; set; }
        public string FlgTipoGestioneOld { get; set; }
        public string FlgTipoGestioneNuova { get; set; }
        public string FlgTipoDannoRegulation { get; set; }
        public string CodConvenzione { get; set; }
        public string EstremiPartita { get; set; }
        public string CodCompagniaCtp { get; set; }
        public string FlgStatoIniziale { get; set; }
        public string FlgStatoFinale { get; set; }
        public string FlgStatoCausaRegulation { get; set; }
        public decimal? ImpRisEntrataInden { get; set; }
        public decimal? ImpRisEntrataSpeseRes { get; set; }
        public decimal? ImpRisEntrataSpeseLiq { get; set; }
        public decimal? ImpRisEntrataRec { get; set; }
        public decimal? ImpPagEntrata { get; set; }
        public decimal? ImpRisUscitaInden { get; set; }
        public decimal? ImpRisUscitaSpeseRes { get; set; }
        public decimal? ImpRisUscitaSpeseLiq { get; set; }
        public decimal? ImpRisUscitaRec { get; set; }
        public decimal? ImpRisCaduta { get; set; }
        public decimal? ImpPagInden { get; set; }
        public decimal? ImpPagSpeseRes { get; set; }
        public decimal? ImpPagSpeseLiq { get; set; }
        public decimal? ImpRec { get; set; }
        public DateTime? DtDenuncia { get; set; }
        public DateTime? DtPervenimento { get; set; }
        public DateTime? DtRegistrazione { get; set; }
    }
}
