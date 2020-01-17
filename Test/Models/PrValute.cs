using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrValute
    {
        public decimal KeyPrValuta { get; set; }
        public decimal IdPrValuta { get; set; }
        public decimal IdPrProdotto { get; set; }
        public decimal IdUtente { get; set; }
        public decimal IdValuta { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
