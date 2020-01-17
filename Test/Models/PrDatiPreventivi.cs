using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrDatiPreventivi
    {
        public int KeyPrDatoPreventivo { get; set; }
        public int IdPrDatoPreventivo { get; set; }
        public int IdPrPreventivo { get; set; }
        public int IdFlgvalue { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
    }
}
