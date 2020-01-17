using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaSegStra
    {
        public int IdSegmentazioneStra { get; set; }
        public int IdRetevendita { get; set; }
        public DateTime DtInizioValidita { get; set; }
        public DateTime DtFineValidita { get; set; }
        public string FlgSegStra { get; set; }
        public DateTime? DtAgg { get; set; }
        public int? IdUtenteAgg { get; set; }
    }
}
