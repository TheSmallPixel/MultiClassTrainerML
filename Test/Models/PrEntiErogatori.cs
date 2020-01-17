using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrEntiErogatori
    {
        public int KeyPrEnteErogatore { get; set; }
        public int IdPrEnteErogatore { get; set; }
        public int IdPrGaranzia { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgEnteErogatore { get; set; }
        public int IdUtente { get; set; }
    }
}
