using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcAllegatiIdm
    {
        public int KeyAllegatoIdm { get; set; }
        public int IdAllegatoIdm { get; set; }
        public string PrgEsternoIdm { get; set; }
        public string FlgCanaleTelnetSino { get; set; }
        public string FlgCanaleFaxSino { get; set; }
        public string FlgCanaleCartaSino { get; set; }
        public int? IdCompagnia { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdAllegato { get; set; }
        public int? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
