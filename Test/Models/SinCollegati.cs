using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinCollegati
    {
        public int KeySinCollegato { get; set; }
        public int? IdSinCollegato { get; set; }
        public int IdSinistro { get; set; }
        public int IdCollegato { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
