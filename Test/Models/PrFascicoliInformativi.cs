using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrFascicoliInformativi
    {
        public int KeyPrFascicoloInformativo { get; set; }
        public int? IdPrFascicoloInformativo { get; set; }
        public int? IdPrProdotto { get; set; }
        public int? IdAllegato { get; set; }
        public int? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
