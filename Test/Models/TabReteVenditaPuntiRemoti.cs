using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaPuntiRemoti
    {
        public decimal KeyRetevenditaPuntoRemoto { get; set; }
        public decimal IdRetevenditaPuntoRemoto { get; set; }
        public decimal IdIndirizzo { get; set; }
        public DateTime? DtAttivazione { get; set; }
        public DateTime? DtDisattivazione { get; set; }
        public decimal IdRetevendita { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal IdUtente { get; set; }
    }
}
