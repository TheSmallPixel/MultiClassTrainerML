using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CtbClausole
    {
        public decimal KeyClausolaquietanza { get; set; }
        public decimal? IdClausolaquietanza { get; set; }
        public decimal? IdClausola { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal IdQuietanza { get; set; }
    }
}
