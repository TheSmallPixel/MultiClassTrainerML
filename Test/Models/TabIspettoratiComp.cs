using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabIspettoratiComp
    {
        public decimal KeyIspettoratoCompagnia { get; set; }
        public decimal IdIspettoratoCompagnia { get; set; }
        public decimal IdCompagnia { get; set; }
        public decimal IdIspettorato { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdUtente { get; set; }
    }
}
