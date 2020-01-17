using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabQuotazioneFondi
    {
        public decimal KeyTabQuotazioneFondo { get; set; }
        public decimal IdTabQuotazioneFondo { get; set; }
        public decimal IdTabFondo { get; set; }
        public decimal? ValoreFondo { get; set; }
        public decimal IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
