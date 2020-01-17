using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabFondi
    {
        public decimal KeyTabFondo { get; set; }
        public decimal IdTabFondo { get; set; }
        public string CodiceFondo { get; set; }
        public decimal? IdDescRidotta { get; set; }
        public decimal? IdDescEstesa { get; set; }
        public decimal IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string DescRidotta { get; set; }
        public string DescEstesa { get; set; }
    }
}
