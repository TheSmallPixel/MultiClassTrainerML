using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinSinistriCoass
    {
        public decimal KeySinistrocoass { get; set; }
        public string NSinistroCoass { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal? IdSinistrocoass { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
