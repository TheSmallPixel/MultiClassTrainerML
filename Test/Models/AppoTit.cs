using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AppoTit
    {
        public decimal? IdTitTitolo { get; set; }
        public decimal? IdPolizza { get; set; }
        public string CodAgenzia { get; set; }
        public string CodSubagenzia { get; set; }
        public string CodProduttore { get; set; }
        public string CodProduttore4 { get; set; }
        public string CodTipoTitolo { get; set; }
        public DateTime? DtEffetto { get; set; }
        public DateTime? DtCopertura { get; set; }
        public DateTime? DtSysEmesso { get; set; }
        public string FlgStatoTitolo { get; set; }
        public DateTime? CompetenzaEmesso { get; set; }
        public decimal? ImpLordo { get; set; }
        public decimal? ImpLordo100 { get; set; }
        public decimal? ImpTasse { get; set; }
        public decimal? TotProvAcquistoAge { get; set; }
        public decimal? TotProvIncassoAge { get; set; }
        public decimal? IdTitEsito { get; set; }
    }
}
