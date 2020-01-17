using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaAltriDp2
    {
        public decimal KeyRetevenditaAltriDp2 { get; set; }
        public decimal IdRetevenditaAltriDp2 { get; set; }
        public string FlgLegameParentelaSino { get; set; }
        public string FlgPianoPersonalizzatoSino { get; set; }
        public decimal IdRetevendita { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal IdUtente { get; set; }
        public string FlgTutor { get; set; }
        public string FlgTutorizzato { get; set; }
    }
}
