using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaSegTat
    {
        public int IdSegmentazioneTat { get; set; }
        public int IdRetevendita { get; set; }
        public DateTime DtInizioValidita { get; set; }
        public DateTime DtFineValidita { get; set; }
        public string FlgSegTat { get; set; }
        public DateTime? DtAgg { get; set; }
        public int? IdUtenteAgg { get; set; }
    }
}
