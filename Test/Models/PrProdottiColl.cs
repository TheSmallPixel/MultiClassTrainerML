using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrProdottiColl
    {
        public decimal KeyPrProdottoColl { get; set; }
        public decimal IdPrProdottoColl { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public decimal IdUtente { get; set; }
        public decimal IdPrProdotto { get; set; }
        public decimal IdProdottoColl { get; set; }
    }
}
