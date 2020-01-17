using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrDettEvoluzioneBm
    {
        public decimal KeyPrDettEvoluzioneBm { get; set; }
        public decimal? IdPrDettEvoluzioneBm { get; set; }
        public decimal? IdPrEvoluzioneBm { get; set; }
        public decimal? IdPrValParClasseMer { get; set; }
        public decimal? IdPrValParClasseMerAss { get; set; }
        public decimal? NumSinistriOsservatiDa { get; set; }
        public decimal? NumSinistriOsservatiA { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
