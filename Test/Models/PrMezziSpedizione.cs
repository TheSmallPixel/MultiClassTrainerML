using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrMezziSpedizione
    {
        public int KeyPrMezzoSpedizione { get; set; }
        public int? IdPrMezzoSpedizione { get; set; }
        public string FlgMezzoSpedizione { get; set; }
        public int? IdPrProdotto { get; set; }
        public int? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
