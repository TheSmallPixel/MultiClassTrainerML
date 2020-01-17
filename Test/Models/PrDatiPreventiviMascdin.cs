using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrDatiPreventiviMascdin
    {
        public int KeyPrDatoPreventivoMascdin { get; set; }
        public int IdPrDatoPreventivoMascdin { get; set; }
        public int IdPrPreventivo { get; set; }
        public int IdFrmVariabileEntita { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
    }
}
