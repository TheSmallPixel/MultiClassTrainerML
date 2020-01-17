using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class MfPvAbbinamenti
    {
        public decimal KeyMfPvAbbinamento { get; set; }
        public decimal IdMfPvAbbinamento { get; set; }
        public string FlgAutomaticoSino { get; set; }
        public string FlgTipoOperazioneMf { get; set; }
        public DateTime? DtOperazione { get; set; }
        public decimal IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdRetevendita { get; set; }
    }
}
