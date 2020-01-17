using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class QuiArretrate
    {
        public int IdQuiArretrata { get; set; }
        public int? IdCompagnia { get; set; }
        public int? AnnoCompetenza { get; set; }
        public int? MeseCompetenza { get; set; }
        public int? IdPolizza { get; set; }
        public DateTime? DtEffettoQuietanza { get; set; }
        public string FlgRamoBilancio { get; set; }
        public decimal? ImportoQuietanza { get; set; }
        public int? AnnoCompetenzaEmesso { get; set; }
        public int? MeseCompetenzaEmesso { get; set; }
    }
}
