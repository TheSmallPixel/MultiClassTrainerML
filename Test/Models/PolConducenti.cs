using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolConducenti
    {
        public decimal KeyPolConducente { get; set; }
        public decimal? IdPolConducente { get; set; }
        public decimal? IdPolVeicolo { get; set; }
        public decimal? IdPolizza { get; set; }
        public decimal? IdAnagrafica { get; set; }
        public decimal IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
