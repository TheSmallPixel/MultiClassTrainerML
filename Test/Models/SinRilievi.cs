using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinRilievi
    {
        public int IdSinRilievo { get; set; }
        public int IdRilievo { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdOggettoRilievo { get; set; }
        public string FlgTipoOggettoRilievo { get; set; }
        public int? IdTipoOggetto { get; set; }
        public int? IdStatoOggetto { get; set; }
        public DateTime? DtCreazione { get; set; }
        public DateTime? DtStatoAttuale { get; set; }
        public DateTime? DtScadenzaStato { get; set; }
        public string CodErroreIvass { get; set; }
    }
}
