using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class StatGestDettaglioPrest
    {
        public int IdStatGestDettaglioPrest { get; set; }
        public int IdStatGestDettaglio { get; set; }
        public int IdPrestazione { get; set; }
        public decimal? ImpPagato { get; set; }
        public decimal? ImpRiserva { get; set; }
        public decimal? ImpRiservaInEntrata { get; set; }
    }
}
