using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinRegTotali
    {
        public int KeySinRegTotali { get; set; }
        public int? IdCompagnia { get; set; }
        public DateTime? DtScarico { get; set; }
        public string FlgCodTipoRegistro { get; set; }
        public string FlgComprendeUlaeSino { get; set; }
        public string FlgTipoTot { get; set; }
        public string FlgRamoBilancio { get; set; }
        public string FlgTipoGestione { get; set; }
        public string AnnoAccadimento { get; set; }
        public decimal? NumPezzi { get; set; }
        public decimal? ImpTotPagato { get; set; }
        public decimal? ImpRiservaCaduta { get; set; }
        public decimal? ImpTotRecupero { get; set; }
        public string FlgCausaleUscita { get; set; }
        public decimal? ImpTotRiserva { get; set; }
        public decimal? ImpTotRiservaRec { get; set; }
        public string FlgCausaleEntrata { get; set; }
        public decimal? ImpRiservaRiap { get; set; }
        public string FlgRiservaInizialeSino { get; set; }
        public decimal? ImpTotSpeseUlae { get; set; }
        public string FlgTipoRiservaRegulation { get; set; }
    }
}
