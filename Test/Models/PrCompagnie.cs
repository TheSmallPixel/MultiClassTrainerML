using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrCompagnie
    {
        public decimal KeyPrCompagnia { get; set; }
        public decimal IdPrCompagnia { get; set; }
        public decimal IdUtente { get; set; }
        public decimal IdCompagnia { get; set; }
        public decimal? IdPrRamo { get; set; }
        public decimal? IdPrProdotto { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
