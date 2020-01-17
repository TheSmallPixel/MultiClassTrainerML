using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabCassaPrevidenzaAge
    {
        public decimal KeyTabCpa { get; set; }
        public decimal? IdTabCpa { get; set; }
        public decimal? PercCpa { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
