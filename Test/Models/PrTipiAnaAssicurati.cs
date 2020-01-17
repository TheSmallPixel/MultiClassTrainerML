using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrTipiAnaAssicurati
    {
        public int KeyPrTipoAnaAssicurato { get; set; }
        public int IdPrTipoAnaAssicurato { get; set; }
        public int? IdPrBene { get; set; }
        public int? IdUtente { get; set; }
        public string FlgTipoAnagrafica { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
