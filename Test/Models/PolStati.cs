using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolStati
    {
        public decimal KeyPolStato { get; set; }
        public decimal? IdPolStato { get; set; }
        public decimal IdPolizza { get; set; }
        public DateTime? DtAnnullamento { get; set; }
        public string FlgStatoContratto { get; set; }
        public decimal? IdTabMotivoStorno { get; set; }
        public decimal? KeyPolAutorizzazione { get; set; }
        public decimal IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
