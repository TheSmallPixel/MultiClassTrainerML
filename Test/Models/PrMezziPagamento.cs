using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrMezziPagamento
    {
        public int KeyPrMezzoPagamento { get; set; }
        public int? IdPrMezzoPagamento { get; set; }
        public string FlgMezzoIncasso { get; set; }
        public int? IdPrProdotto { get; set; }
        public int? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
