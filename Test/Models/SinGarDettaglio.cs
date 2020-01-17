using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinGarDettaglio
    {
        public int KeySinGarDettaglio { get; set; }
        public int? IdCompagnia { get; set; }
        public DateTime? DtScarico { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdGaranzia { get; set; }
        public string FlgTipoGestione { get; set; }
        public string EstremiPartita { get; set; }
        public string CodCompagniaCtp { get; set; }
        public decimal? ImpRisEntrataInden { get; set; }
        public decimal? ImpRisEntrataSpeseRes { get; set; }
        public decimal? ImpRisEntrataSpeseLiq { get; set; }
        public decimal? ImpRisEntrataRec { get; set; }
        public decimal? ImpRisUscitaInden { get; set; }
        public decimal? ImpRisUscitaSpeseRes { get; set; }
        public decimal? ImpRisUscitaSpeseLiq { get; set; }
        public decimal? ImpRisUscitaRec { get; set; }
        public decimal? ImpPagInden { get; set; }
        public decimal? ImpPagSpeseRes { get; set; }
        public decimal? ImpPagSpeseLiq { get; set; }
        public decimal? ImpRec { get; set; }
        public DateTime? DtDenuncia { get; set; }
        public DateTime? DtPervenimento { get; set; }
        public DateTime? DtRegistrazione { get; set; }
    }
}
