using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SctRetrocessione
    {
        public decimal KeySctRetrocessione { get; set; }
        public decimal? IdSctRetrocessione { get; set; }
        public decimal? IdCompagnia { get; set; }
        public decimal? IdRetevendita { get; set; }
        public decimal? PctRetrocessione { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
