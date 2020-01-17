using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolAssicurati
    {
        public decimal KeyPolAssicurato { get; set; }
        public decimal? IdPolBene { get; set; }
        public decimal? IdPolAssicurato { get; set; }
        public decimal IdPolizza { get; set; }
        public decimal IdAnagrafica { get; set; }
        public decimal IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdPolRischioImpiego { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
