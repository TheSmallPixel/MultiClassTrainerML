using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrPreventivi
    {
        public int KeyPrPreventivo { get; set; }
        public int IdPrPreventivo { get; set; }
        public int IdPrProdotto { get; set; }
        public int IdCompagnia { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
    }
}
