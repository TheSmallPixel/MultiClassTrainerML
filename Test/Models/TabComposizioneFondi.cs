using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabComposizioneFondi
    {
        public decimal KeyComposizioneFondo { get; set; }
        public decimal IdComposizioneFondo { get; set; }
        public decimal IdTabFondo { get; set; }
        public decimal? IdDescFondo { get; set; }
        public decimal? PctFondo { get; set; }
        public decimal IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string DescFondo { get; set; }
    }
}
