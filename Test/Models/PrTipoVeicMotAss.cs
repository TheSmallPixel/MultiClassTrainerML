using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrTipoVeicMotAss
    {
        public int KeyPrTipoVeicMotAss { get; set; }
        public int IdPrTipoVeicMotAss { get; set; }
        public int IdPrTipoVeicolo { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgMotivoAssicurazione { get; set; }
    }
}
