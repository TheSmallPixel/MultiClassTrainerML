using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcPosizioneDanno
    {
        public int IdArcPosizioneDanno { get; set; }
        public decimal? IdSinistro { get; set; }
        public decimal? IdPosizione { get; set; }
        public string Danno { get; set; }
        public string FlgTipoConvenzione { get; set; }
        public string FlgTipoDanno { get; set; }
        public string FlgStatoDanno { get; set; }
        public DateTime? DtRiferimento { get; set; }
        public string FlgTipologiaGestione { get; set; }
        public int? IdCompagnia { get; set; }
        public DateTime? DtSysEvento { get; set; }
    }
}
