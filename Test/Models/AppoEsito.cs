using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AppoEsito
    {
        public decimal? IdTitEsito { get; set; }
        public decimal? IdTitTitolo { get; set; }
        public string FlgTipoEsito { get; set; }
        public string CodAgenzia { get; set; }
        public DateTime? DtEsito { get; set; }
        public DateTime? CompetenzaEsito { get; set; }
        public DateTime? DtSysEsito { get; set; }
        public decimal? ImpIncassato { get; set; }
        public decimal? IdTabMotivoStorno { get; set; }
        public DateTime? DtFogliocassa { get; set; }
        public decimal? NFogliocassa { get; set; }
    }
}
