using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcAssegni
    {
        public int IdAssegno { get; set; }
        public int IdCarnetAss { get; set; }
        public string FlgStatoAss { get; set; }
        public string FlgCausaleAnnAss { get; set; }
        public DateTime? DtAnnullamento { get; set; }
        public decimal? NumeroAssegno { get; set; }
    }
}
