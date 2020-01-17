using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolRegPremio
    {
        public decimal KeyPolRegPremio { get; set; }
        public decimal IdPolRegPremio { get; set; }
        public decimal IdPolizza { get; set; }
        public DateTime? DtInizioRegolazione { get; set; }
        public DateTime? DtFineRegolazione { get; set; }
        public string FlgStatoRegolazione { get; set; }
        public decimal? PrgRichieste { get; set; }
        public decimal IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
