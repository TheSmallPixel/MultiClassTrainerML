using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SctMaturato
    {
        public decimal KeySctMaturato { get; set; }
        public decimal? IdSctMaturato { get; set; }
        public decimal? IdSctPlafond { get; set; }
        public decimal? ImpMaturato { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
