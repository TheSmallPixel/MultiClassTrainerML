using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PtfSostituenti
    {
        public int KeySostituente { get; set; }
        public int IdSostituente { get; set; }
        public int IdPolizza { get; set; }
        public string NPolizza { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
    }
}
