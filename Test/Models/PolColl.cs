using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolColl
    {
        public decimal KeyPolCollegata { get; set; }
        public decimal? IdPolCollegata { get; set; }
        public decimal IdPolizza { get; set; }
        public decimal IdCollegata { get; set; }
        public decimal IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
