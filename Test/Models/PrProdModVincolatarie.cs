using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrProdModVincolatarie
    {
        public decimal KeyProdModVincolataria { get; set; }
        public decimal IdProdModVincolataria { get; set; }
        public decimal IdModVincolataria { get; set; }
        public decimal IdPrProdotto { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdUtente { get; set; }

        public virtual PrModelliVincolatarie IdModVincolatariaNavigation { get; set; }
    }
}
