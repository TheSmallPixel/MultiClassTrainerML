using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrGarConvenzioni
    {
        public int KeyPrGarConvenzioni { get; set; }
        public int? IdPrGarConvenzioni { get; set; }
        public int? IdPrGaranzia { get; set; }
        public int? IdConvenzione { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
        public string FlgDerogabileSino { get; set; }
        public decimal? CodDeroga { get; set; }
    }
}
