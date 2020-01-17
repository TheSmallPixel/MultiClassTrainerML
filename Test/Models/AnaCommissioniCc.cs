using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AnaCommissioniCc
    {
        public int KeyAnaCommissioniCc { get; set; }
        public int IdAnaCommissioniCc { get; set; }
        public decimal? PctCommissioni { get; set; }
        public decimal? ImpCommissioni { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
    }
}
