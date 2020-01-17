using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolOperazioniFondi
    {
        public decimal KeyPolOperazioneFondi { get; set; }
        public decimal? IdPolOperazioneFondi { get; set; }
        public decimal? IdPolGaranzia { get; set; }
        public decimal? ImpCapitalePuro { get; set; }
        public decimal? ImpDiritti { get; set; }
        public decimal? ImpCaricamenti { get; set; }
        public decimal? ImpImposte { get; set; }
        public decimal? NrQuote { get; set; }
        public decimal? PrgAppendice { get; set; }
        public decimal IdUtente { get; set; }
        public decimal? IdPolizza { get; set; }
        public decimal? PctVariazione { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
