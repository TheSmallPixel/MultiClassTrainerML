using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RiepSinStatiDettImp
    {
        public decimal IdDettaglio { get; set; }
        public decimal? IdStato { get; set; }
        public string FlgTipoStatoRiepilogo { get; set; }
        public string FlgTipoMovimento { get; set; }
        public string FlgTipoMovimento2 { get; set; }
        public string FlgTipoRiserva { get; set; }
        public string FlgTipoRiserva2 { get; set; }
        public decimal? Importo { get; set; }
        public decimal? IdValuta { get; set; }
        public decimal? IdCompagnia { get; set; }
    }
}
