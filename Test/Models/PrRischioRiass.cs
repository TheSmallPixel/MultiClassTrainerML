using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrRischioRiass
    {
        public decimal KeyPrRischioRiass { get; set; }
        public decimal IdPrRischioRiass { get; set; }
        public decimal IdPrGaranzia { get; set; }
        public string FlgRischioRiass { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdUtente { get; set; }
    }
}
