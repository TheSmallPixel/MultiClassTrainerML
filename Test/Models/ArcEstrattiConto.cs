using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcEstrattiConto
    {
        public int IdEstrattoConto { get; set; }
        public int IdRetevendita { get; set; }
        public int IdTitEsito { get; set; }
        public DateTime DtPagamento { get; set; }
        public decimal ImpPagato { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtSysRegistrazione { get; set; }
        public int IdProduttore { get; set; }
        public decimal? ImpProvvPagato { get; set; }
    }
}
