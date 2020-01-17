using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaOmnia
    {
        public decimal KeyOmnia { get; set; }
        public decimal IdOmnia { get; set; }
        public decimal IdRetevendita { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdUtente { get; set; }
        public string CodiceSubagente { get; set; }
        public string CodiceAgenzia { get; set; }
    }
}
