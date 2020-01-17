using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolSinistriSconti
    {
        public int KeyPolSinistriSconti { get; set; }
        public int? IdPolSinistriSconti { get; set; }
        public int? IdPolVeicolo { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdPolizza { get; set; }
    }
}
