using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolFranchigie
    {
        public decimal KeyPolFranchigia { get; set; }
        public decimal? IdPolFranchigia { get; set; }
        public decimal? IdPolGaranzia { get; set; }
        public decimal? IdPolizza { get; set; }
        public string NFranchigia { get; set; }
        public string NSinistro { get; set; }
        public string ChiaveEsterneSinistro { get; set; }
        public string ChiaveEsternaFranchigia { get; set; }
        public DateTime? DtEffetto { get; set; }
        public decimal? ImpFranchigia { get; set; }
        public decimal? ImpProvvigione { get; set; }
        public string FlgStatoFranchigia { get; set; }
        public decimal IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
