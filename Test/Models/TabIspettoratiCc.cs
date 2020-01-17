using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabIspettoratiCc
    {
        public decimal KeyIspettoratoCc { get; set; }
        public decimal IdIspettoratoCc { get; set; }
        public decimal IdContocorrente { get; set; }
        public decimal IdIspettorato { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdUtente { get; set; }
    }
}
