using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PtfContrattiScaduti
    {
        public decimal IdRegistroScaduti { get; set; }
        public decimal? IdCompagnia { get; set; }
        public decimal? IdPolizza { get; set; }
        public decimal? AnnoCompetenza { get; set; }
        public decimal? MeseCompetenza { get; set; }
        public string NPolizza { get; set; }
        public DateTime? DtEffetto { get; set; }
        public DateTime? DtScadenza { get; set; }
        public string Contraente { get; set; }
        public string CodfiscPiva { get; set; }
        public string FlgTipoDelega { get; set; }
        public decimal? PctQuota { get; set; }
        public string FlgRamoBilancio { get; set; }
        public string FlgTipoPrestazione { get; set; }
        public DateTime? DtAnnullamento { get; set; }
        public decimal? ContaInteri { get; set; }
        public decimal? ContaQuota { get; set; }
    }
}
