using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrGarTipoFabbricato
    {
        public int KeyPrGarTpFabbricato { get; set; }
        public int IdPrGarTpFabbricato { get; set; }
        public int IdPrGaranzia { get; set; }
        public string FlgTipoFabbricato { get; set; }
        public int? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
