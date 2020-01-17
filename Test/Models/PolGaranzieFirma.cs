using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolGaranzieFirma
    {
        public decimal IdPolGaranziaFirma { get; set; }
        public decimal? IdPolizza { get; set; }
        public decimal? IdPolGaranzia { get; set; }
        public decimal? ImpNetto { get; set; }
        public decimal? ImpAccessori { get; set; }
        public decimal? ImpSsn { get; set; }
        public decimal? ImpTasse { get; set; }
        public decimal? ImpAntiracket { get; set; }
        public decimal? ImpFranchigiaAgg { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
