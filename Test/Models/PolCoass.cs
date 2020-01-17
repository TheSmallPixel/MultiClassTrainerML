using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolCoass
    {
        public decimal KeyPolCoass { get; set; }
        public decimal? IdPolCoass { get; set; }
        public decimal IdPolizza { get; set; }
        public decimal IdCompagnia { get; set; }
        public string FlgTipoCompCoass { get; set; }
        public decimal PctQuota { get; set; }
        public string NPolizzaCoass { get; set; }
        public decimal IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdAgeCoass { get; set; }

        public virtual ArcAgeCoass IdAgeCoassNavigation { get; set; }
        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
