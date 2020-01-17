using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolVariapremi
    {
        public decimal KeyPolVariapremio { get; set; }
        public decimal? IdPolVariapremio { get; set; }
        public decimal? IdPolGaranzia { get; set; }
        public decimal? IdPolizza { get; set; }
        public decimal? IdPrVariapremio { get; set; }
        public decimal? ImpVariazione { get; set; }
        public decimal? CoefVariazione { get; set; }
        public decimal? PuntiVariazione { get; set; }
        public decimal IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? PerVariazione { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
