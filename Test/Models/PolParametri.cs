using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolParametri
    {
        public decimal KeyPolParametro { get; set; }
        public decimal? IdPolParametro { get; set; }
        public decimal? IdPolGaranzia { get; set; }
        public decimal? IdPolizza { get; set; }
        public decimal? IdPrParametro { get; set; }
        public decimal? IdPrValParametro { get; set; }
        public string DatoVariabile { get; set; }
        public decimal IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgForzatoSino { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
