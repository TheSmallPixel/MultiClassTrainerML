using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolAppendici
    {
        public decimal KeyPolAppendice { get; set; }
        public decimal? IdPolAppendice { get; set; }
        public decimal IdPolizza { get; set; }
        public DateTime? DtEffetto { get; set; }
        public string HhmmEffetto { get; set; }
        public decimal? PrgAppendice { get; set; }
        public string Note { get; set; }
        public string FlgStatoAppendice { get; set; }
        public DateTime? DtAnnullamento { get; set; }
        public decimal? IdTabMotivoStorno { get; set; }
        public decimal? IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public DateTime? DtScadenzaCopertura { get; set; }
        public decimal? IdTabParametriOperazione { get; set; }
        public string FlgMotivoRistampa { get; set; }
        public string NRifEsterno { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
