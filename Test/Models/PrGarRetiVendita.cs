using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrGarRetiVendita
    {
        public int KeyPrGarRetiVendita { get; set; }
        public int? IdPrGarRetiVendita { get; set; }
        public int? IdPrGaranzia { get; set; }
        public int? IdRetevendita { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
        public string FlgSottoreteSino { get; set; }
        public string FlgDerogabileSino { get; set; }
        public decimal? CodDeroga { get; set; }
    }
}
