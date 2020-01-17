using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolSostituite
    {
        public decimal KeyPolSostituita { get; set; }
        public decimal? IdPolSostituita { get; set; }
        public decimal IdPolizza { get; set; }
        public decimal IdSostituita { get; set; }
        public decimal IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
