using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PtfDebitori
    {
        public decimal KeyDebitore { get; set; }
        public decimal? IdDebitore { get; set; }
        public decimal? IdAnagrafica { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
