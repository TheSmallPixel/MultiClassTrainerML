using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrTipoVeicoliFrazionamenti
    {
        public int KeyPrTipoVeicoliFraz { get; set; }
        public int IdPrTipoVeicoliFraz { get; set; }
        public int IdPrTipoVeicolo { get; set; }
        public int IdPrFrazAmmessi { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
