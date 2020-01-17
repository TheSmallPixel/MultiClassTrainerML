using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AnaContiCorrentiTglAss
    {
        public decimal KeyContocorrenteTglAss { get; set; }
        public decimal IdContocorrenteTglAss { get; set; }
        public decimal? IdContocorrente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgTaglioAss { get; set; }
        public decimal? IdUtente { get; set; }
    }
}
