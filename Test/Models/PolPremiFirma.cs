using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolPremiFirma
    {
        public decimal KeyPolPremioFirma { get; set; }
        public decimal? IdPolPremioFirma { get; set; }
        public decimal? IdPolizza { get; set; }
        public decimal? ImpNetto { get; set; }
        public decimal? ImpAccessori { get; set; }
        public decimal? ImpSsn { get; set; }
        public decimal? ImpTasse { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal? ImpVariazioneMaturato { get; set; }
        public decimal? ImpPlafondConsumato { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
