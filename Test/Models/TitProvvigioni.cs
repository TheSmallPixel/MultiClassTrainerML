using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TitProvvigioni
    {
        public decimal KeyTitProvvigione { get; set; }
        public decimal? IdTitProvvigione { get; set; }
        public decimal? IdTitGaranzia { get; set; }
        public decimal? IdRetevendita { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal? ImpGarAcquisto { get; set; }
        public decimal? ImpGarIncasso { get; set; }
        public decimal? ImpAccAcquisto { get; set; }
        public decimal? ImpAccIncasso { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdTitTitolo { get; set; }
    }
}
