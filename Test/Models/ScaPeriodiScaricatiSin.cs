using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ScaPeriodiScaricatiSin
    {
        public decimal IdScaPeriodiscaricati { get; set; }
        public DateTime? DtLimiteOperazioni { get; set; }
        public DateTime? DtScarico { get; set; }
        public decimal? IdCompagnia { get; set; }
    }
}
