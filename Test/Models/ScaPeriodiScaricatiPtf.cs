using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ScaPeriodiScaricatiPtf
    {
        public decimal IdScaPeriodiscaricati { get; set; }
        public DateTime? DtCompetenza { get; set; }
        public DateTime? DtScarico { get; set; }
        public decimal? IdCompagnia { get; set; }
    }
}
