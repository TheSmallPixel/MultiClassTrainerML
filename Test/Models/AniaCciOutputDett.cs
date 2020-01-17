using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaCciOutputDett
    {
        public decimal IdAniaCciOutputDett { get; set; }
        public decimal? IdAniaCciOutput { get; set; }
        public decimal? IdentificativoSinistro { get; set; }
        public decimal? IdentificativoPartDanno { get; set; }
        public string RecordInviato { get; set; }
        public string FlgTipoComunicazione { get; set; }
    }
}
