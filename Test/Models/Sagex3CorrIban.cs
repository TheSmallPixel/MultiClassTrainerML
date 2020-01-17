using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Sagex3CorrIban
    {
        public string Tipopag { get; set; }
        public string Iban { get; set; }
        public int IdCorrIban { get; set; }
        public int KeyCorrIban { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
    }
}
