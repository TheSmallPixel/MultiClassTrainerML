using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinRimorchi
    {
        public int KeySinRimorchio { get; set; }
        public int IdSinRimorchio { get; set; }
        public int IdVeicolo { get; set; }
        public string TargaRimorchio { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
    }
}
