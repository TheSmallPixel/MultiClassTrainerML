using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrDurate
    {
        public decimal KeyPrDurata { get; set; }
        public decimal IdPrDurata { get; set; }
        public decimal? IdPrProdotto { get; set; }
        public decimal IdUtente { get; set; }
        public string FlgDurata { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgAmmessoPolBaseSino { get; set; }
    }
}
