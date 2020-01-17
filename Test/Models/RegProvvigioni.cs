using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RegProvvigioni
    {
        public decimal KeyRegProvvigione { get; set; }
        public decimal? IdRegProvvigione { get; set; }
        public decimal? IdRegGaranzia { get; set; }
        public decimal? IdRetevendita { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal? ImpGarAcquisto { get; set; }
        public decimal? ImpGarIncasso { get; set; }
        public decimal? ImpAccAcquisto { get; set; }
        public decimal? ImpAccIncasso { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
