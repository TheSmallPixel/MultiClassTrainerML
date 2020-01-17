using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabForfaitCard
    {
        public decimal IdForfaitCard { get; set; }
        public decimal IdProvincia { get; set; }
        public DateTime DtInizioValidita { get; set; }
        public DateTime DtFineValidita { get; set; }
        public decimal? ImpForfaitVeicolo { get; set; }
        public decimal? ImpForfaitLesioni { get; set; }
        public decimal? ImpForfaitCtt { get; set; }
        public decimal? ImpFrancFissaLesioni { get; set; }
        public decimal? ImpFrancFissaCtt { get; set; }
        public decimal? ImpPlafondLesioni { get; set; }
        public decimal? ImpPlafondCtt { get; set; }
        public decimal? ImpFrancMaxLesioni { get; set; }
        public decimal? ImpFrancMaxCtt { get; set; }
        public decimal? PerFrancLesioni { get; set; }
        public decimal? PerFrancCtt { get; set; }
        public decimal? ImpForfaitCttM { get; set; }
        public decimal? ImpForfaitVeicoloM { get; set; }
    }
}
