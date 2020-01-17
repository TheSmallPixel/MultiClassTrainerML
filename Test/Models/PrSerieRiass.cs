using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrSerieRiass
    {
        public decimal KeyPrSerieRiass { get; set; }
        public decimal IdPrSerieRiass { get; set; }
        public decimal IdPrProdotto { get; set; }
        public string FlgTipoSerieRiass { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdUtente { get; set; }
    }
}
