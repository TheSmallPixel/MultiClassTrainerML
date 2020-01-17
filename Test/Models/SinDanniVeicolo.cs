using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinDanniVeicolo
    {
        public decimal KeyDannoveicolo { get; set; }
        public decimal? IdDannoveicolo { get; set; }
        public decimal? IdUtente { get; set; }
        public string FlgDannoVeicolo { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal IdEntitacoinvolta { get; set; }
    }
}
