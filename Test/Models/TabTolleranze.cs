using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabTolleranze
    {
        public decimal KeyTabTolleranze { get; set; }
        public decimal IdTabTolleranze { get; set; }
        public decimal IdCompagnia { get; set; }
        public string FlgCodTolleranza { get; set; }
        public decimal? ImportoTolleranza { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal? IdValuta { get; set; }
    }
}
