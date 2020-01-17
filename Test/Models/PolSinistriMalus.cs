using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolSinistriMalus
    {
        public int KeyPolSinistriMalus { get; set; }
        public int? IdPolSinistriMalus { get; set; }
        public int? IdPolTestata { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdPolizza { get; set; }
    }
}
