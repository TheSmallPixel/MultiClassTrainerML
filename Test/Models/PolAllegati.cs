using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolAllegati
    {
        public decimal KeyPolAllegato { get; set; }
        public decimal IdPolAllegato { get; set; }
        public decimal IdPolizza { get; set; }
        public decimal IdAllegato { get; set; }
        public decimal IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
