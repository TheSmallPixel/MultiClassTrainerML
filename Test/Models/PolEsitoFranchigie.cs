using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolEsitoFranchigie
    {
        public decimal KeyPolEsitoFranchigia { get; set; }
        public decimal? IdPolEsitoFranchigia { get; set; }
        public decimal? IdPolizza { get; set; }
        public decimal? IdPolFranchigia { get; set; }
        public DateTime? DtEsito { get; set; }
        public string FlgTipoEsito { get; set; }
        public string FlgMezzoPagamento { get; set; }
        public decimal? IdAgenziaEsito { get; set; }
        public decimal? ImpIncassato { get; set; }
        public decimal? KeyArcFoglioCassa { get; set; }
        public decimal? IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
