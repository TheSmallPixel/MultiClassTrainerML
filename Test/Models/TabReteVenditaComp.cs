using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaComp
    {
        public decimal KeyRetevenditaComp { get; set; }
        public decimal IdRetevenditaComp { get; set; }
        public decimal IdCompagnia { get; set; }
        public decimal IdRetevendita { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdUtente { get; set; }
    }
}
