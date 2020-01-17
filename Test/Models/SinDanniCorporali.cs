using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinDanniCorporali
    {
        public decimal KeyDannocorporale { get; set; }
        public decimal? IdDannocorporale { get; set; }
        public decimal? IdUtente { get; set; }
        public string FlgDannoCorporale { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal IdEntitacoinvolta { get; set; }
    }
}
